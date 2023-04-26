using DevExpress.Web;
using DXMNCGUI_INFORMA.Controllers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DXMNCGUI_INFORMA.Transaction
{
    public partial class DetailCIFDebiturMemo : BasePage
    {
        protected DataTable myMainTable
        {
            get { isValidLogin(false); return (DataTable)HttpContext.Current.Session["myMainTable" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["myMainTable" + this.ViewState["_PageID"]] = value; }
        }

        protected DataTable myCollTable
        {
            get { isValidLogin(false); return (DataTable)HttpContext.Current.Session["myCollTable" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["myCollTable" + this.ViewState["_PageID"]] = value; }
        }

        public string getValue()
        {
            string url = HttpContext.Current.Request.Url.AbsoluteUri;
            Uri myUri = new Uri(url);
            string param1 = HttpUtility.ParseQueryString(myUri.Query).Get("CLIENT");

            return param1;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            getValue();

            myMainTable = new DataTable();
            GetMainTable();
            gvMain.DataBind();
            //gvDetail.DataBind();

            myMainTable = new DataTable();
            GetCollTable();
            //gvColl.DataBind();
            gvDetail2.DataBind();
        }

        protected void gvMain_CustomButtonCallback(object sender, DevExpress.Web.ASPxGridViewCustomButtonCallbackEventArgs e)
        {

        }

        protected void gvMain_DataBinding(object sender, EventArgs e)
        {
            (sender as ASPxGridView).DataSource = myMainTable;
        }

        protected void gvColl_DataBinding(object sender, EventArgs e)
        {
            (sender as ASPxGridView).DataSource = myCollTable;
        }

        protected void gvColl_CustomButtonCallback(object sender, DevExpress.Web.ASPxGridViewCustomButtonCallbackEventArgs e)
        {

        }

        protected void cplMain_Callback(object source, DevExpress.Web.CallbackEventArgs e)
        {

        }

        protected void GetMainTable()
        {
            string Client = getValue();

            string ssql = @"select 
            	a.APPLICNO AS NO_APLIKASI
            	, b.LSAGREE AS NO_KONTRAK
            	, convert(varchar, b.DISBURSEDT, 106) AS TGL_APLIKASI
            	, a.APPSTATUS AS STATUS_APLIKASI
            	, convert(varchar, b.CONTRACT_DATE, 106) AS TGL_KONTRAK
            	, b.CONTRACT_STATUS AS STATUS_KONTRAK
            	, convert(varchar, b.DISBURSEDT, 106) AS TGL_CAIR
            	, CASE a.RENTALPAY
            			WHEN 1 THEN 'ADVANCE' ELSE 'ARREARS' END AS RENTAL_PAYABLE
            	, xx1.LINE_DESC + ' - ' + xx2.LINE_DESC AS JENIS_PEMBIAYAAN
            	, A.LSPERIOD AS TENOR
            	, CAST(CONVERT(VARCHAR, CAST(a.AMTLEASE AS MONEY), 1) AS VARCHAR) AS NTF
							, CAST(CONVERT(VARCHAR, CAST(((select sum(isnull(PRINCIPAL, 0))
            					from dbo.LS_LEDGERRENTAL z
            					where z.LSAGREE = b.LSAGREE
            						and PAYMENT > 0 )
            				+ ISNULL((select sum(isnull(PRINCIPAL, 0))
            					from dbo.LS_LEDGERRENTAL z
            					where z.LSAGREE = b.LSAGREE
            						and (z.VALUEDATE <= convert(varchar(10), dbo.fn_get_system_date(), 121)
            						and PAYMENT < 0
            					)), 0)) AS MONEY), 1) AS VARCHAR) AS OS_PRINCIPAL
            	, case when b.CONTRACT_STATUS = 'GOLIVE' 
            		then dbo.fn_overdue (convert(varchar(10), dbo.fn_get_system_date(), 121), b.LSAGREE) else 0 end AS OVD
            from LS_APPLICATION a with (nolock)
            LEFT join LS_AGREEMENT b with (nolock) on a.APPLICNO = b.APPLICNO
            LEFT join dbo.MASTER_PURPOSE_LOAN_HD xx1 with (nolock) ON a.PURPOSE_LOAN_HD_CODE = xx1.PURPOSE_LOAN_HD_CODE
            LEFT JOIN dbo.MASTER_PURPOSE_LOAN_DT xx2 with (nolock) ON a.PURPOSE_LOAN_DT_CODE = xx2.PURPOSE_LOAN_DT_CODE
            where a.LESSEE = ?
            and a.APPSTATUS <> 'CANCEL'
            and b.CONTRACT_STATUS <> 'TERMINATE'
            and a.MODULE <> 6
            order by b.DISBURSEDT, a.APPLICDT
            ";
            myMainTable = dbsetting.GetDataTable(ssql, false, Client);
        }

        protected void GetCollTable()
        {
            string ssql = @"select *
            from (
            	select a.APPLICNO, b.LESSEE, a.ASSETDESC, a.ENGINENO, a.SERIALNO, b.APPSTATUS, a.YEAR, b.MODULE
            	from LS_APPLIASSET a with (nolock)
            	left join LS_APPLICATION b with (nolock) on a.APPLICNO = b.APPLICNO) a1
            left join (
            	select c.LSAGREE, d.APPLICNO, d.LESSEE, c.DESCRIPTION, c.VHCCHASS, c.VHCCOLOR, c.SERIALNO 
            	from LS_ASSETVEHICLE c with (nolock)
            	left join LS_AGREEMENT d with (nolock) on c.LSAGREE = d.LSAGREE
            ) a2 on a1.APPLICNO = a2.APPLICNO
            where a1.LESSEE = ?
            and a1.APPSTATUS <> 'CANCEL'
            and a1.MODULE <> 6";
            myCollTable = dbsetting.GetDataTable(ssql, false, getValue());
        }

        protected void gvDetail2_DataBinding(object sender, EventArgs e)
        {
            (sender as ASPxGridView).DataSource = myCollTable;
        }

        protected void gvDetail2_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e)
        {

        }

        protected void gvDetail_DataBinding(object sender, EventArgs e)
        {
            (sender as ASPxGridView).DataSource = myMainTable;
        }

        protected void gvDetail_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e)
        {

        }
    }
}
