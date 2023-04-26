using DevExpress.Web;
using DXMNCGUI_INFORMA.Controllers;
using DXMNCGUI_INFORMA.Controllers.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DXMNCGUI_INFORMA.Reporting.InternalMemo.PendingGiro
{
    public partial class DeviasiDetailListing : BasePage
    {
        protected SqlDBSetting myDBSetting
        {
            get { isValidLogin(false); return (SqlDBSetting)HttpContext.Current.Session["myDBSetting" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["myDBSetting" + this.ViewState["_PageID"]] = value; }
        }
        protected SqlLocalDBSetting myLocalDBSetting
        {
            get { isValidLogin(false); return (SqlLocalDBSetting)HttpContext.Current.Session["myLocalDBSetting" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["myLocalDBSetting" + this.ViewState["_PageID"]] = value; }
        }
        protected SqlDBSession myDBSession
        {
            get { isValidLogin(false); return (SqlDBSession)HttpContext.Current.Session["myDBSession" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["myDBSession" + this.ViewState["_PageID"]] = value; }
        }
        protected string myDtlKey
        {
            get { isValidLogin(false); return (string)HttpContext.Current.Session["myDtlKey" + this.ViewState["_PageID"]]; }
            set { HttpContext.Current.Session["myDtlKey" + this.ViewState["_PageID"]] = value; }
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            isValidLogin(false);
            if (!Page.IsPostBack)
            {
                this.ViewState["_PageID"] = Guid.NewGuid();
                myDBSetting = dbsetting;
                myLocalDBSetting = localdbsetting;
                myDBSession = dbsession;

                if (IsAccess())
                {
                    btnUpdate.Visible = true;
                }

            }
            if (!IsCallback)
            {

            }
        }

        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            gvMain.DataBind();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        protected void cplMain_Callback(object source, DevExpress.Web.CallbackEventArgs e)
        {
            isValidLogin();
            string[] callbackParam = e.Parameter.ToString().Split(';');
            cplMain.JSProperties["cpCallbackParam"] = callbackParam[0].ToUpper();
            string urlsave = "~/Reporting/InternalMemo/PendingGiro/DeviasiDetailListing.aspx";

            object paramValue = callbackParam[1];

            switch (callbackParam[0].ToUpper())
            {
                case "SAVE_CONFIRM":
                    cplMain.JSProperties["cplblmessageError"] = "";
                    cplMain.JSProperties["cplblmessage"] = "are you sure want to save this memo?";
                    cplMain.JSProperties["cplblActionButton"] = "SAVE";

                    DataRow myrow = gvMain.GetDataRow(gvMain.FocusedRowIndex);
                    if (myrow != null)
                    {
                        //if(myrow["Detail Status"] != null)
                        //{
                        //    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Detail status already update! .." + "');", true);
                        //    return;
                        //}

                        //if (myrow["Status"].ToString() != "APPROVE")
                        //{
                        //    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Status memo must be final APPROVE to update detail status .." + "');", true);
                        //    return;
                        //}

                        //cplMain.JSProperties["cpmmDocNo"] = myrow["DocNo"].ToString();

                        cplMain.JSProperties["cplblmessage"] = myrow["DocNo"].ToString();
                        cplMain.JSProperties["cpmmPerihal"] = myrow["Perihal"].ToString();
                        myDtlKey = myrow["DtlKey"].ToString();



                    }else
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "please select row first.." + "');", true);
                        return;
                    }
                    break;
                case "SAVE":
                    //Save(DXISaveAction.Save);
                    UpdateStatusDetail(myDtlKey);
                    cplMain.JSProperties["cpAlertMessage"] = "Status has been updated...";
                    cplMain.JSProperties["cplblActionButton"] = "SAVE";
                    ASPxWebControl.RedirectOnCallback(urlsave);
                    break;
            }
        }


        protected void UpdateStatusDetail(string dtlKey)
        {
            string ssql = "Update InternalMemoDetailDeviasi set Status = 'DONE', UpdateBy = ? , UpdateDate = getdate() where DtlKey = ?";
            myLocalDBSetting.ExecuteNonQuery(ssql, this.UserID, dtlKey);
        }

        protected bool IsAccess()
        {
            bool res = false;
            string strSQL = "select Count(NIK) [CountCanUpdate] from AccessRight where CMDid = 'DEVIASI_CAN_UPDATE' and nik=?";
            object obj = myLocalDBSetting.ExecuteScalar(strSQL, this.UserID);
            if (obj != null && obj != DBNull.Value)
            {
                int countCanApprove = Convert.ToInt32(obj);
                if (countCanApprove > 0)
                {
                    res = true;
                }
            }

            return res;
        }

    }
}