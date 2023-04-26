using System;
using DXMNCGUI_INFORMA.Controllers;
using DevExpress.XtraReports.Security;
using DXMNCGUI_INFORMA.Controllers.Data;
using DXMNCGUI_INFORMA.Transaction.InternalMemo;
using System.Data;
using System.IO;
using System.Web;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.Web;

namespace DXMNCGUI_INFORMA.Shared
{
    public partial class DocViewer : BasePage
    {
        protected MemoryStream myFreeTextDownload
        {
            get { isValidLogin(false); return (MemoryStream)HttpContext.Current.Session["myFreeTextDownload" + this.UserID]; }
            set { HttpContext.Current.Session["myFreeTextDownload" + this.UserID] = value; }
        }

        protected int iDocKey;
        protected DataTable myTable;
        protected DataTable myTableDetail;
        protected DataTable myTableFreeText;
        protected SqlLocalDBSetting myLocalDBSetting;
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable myTable = new DataTable();
            DataTable myTableDeviasi = new DataTable();
            myLocalDBSetting = localdbsetting;
            ScriptPermissionManager.GlobalInstance = new ScriptPermissionManager(ExecutionMode.Unrestricted);
            if (this.Request.QueryString["Title"] != null)
                pnlMain.HeaderText = this.Request.QueryString["Title"].ToString();

            if (this.Request.QueryString["ReportType"] != null)
            {
                switch (this.Request.QueryString["ReportType"].ToString().ToUpper())
                {
                    #region docInternalMemoPemakaianCashColl
                    case "IM1":
                        if (this.Request.QueryString["DocNo"] == null) return;
                        docInternalMemoPemakaianCashColl docInternalMemoPemakaianCashColl = new docInternalMemoPemakaianCashColl();
                        docInternalMemoPemakaianCashColl.Parameters["DocNo"].Value = this.Request["DocNo"];
                        docInternalMemoPemakaianCashColl.Parameters["DocKey"].Value = this.Request["DocKey"];
                        iDocKey = Convert.ToInt32(this.Request["DocKey"]);

                        myTable = myLocalDBSetting.GetDataTable("SELECT * FROM [dbo].[InternalMemoApprovalList] WHERE DocKey=?", false, iDocKey);

                        var picBoxPemakaianCashColl1 = docInternalMemoPemakaianCashColl.FindControl("picBoxPemakaianCashColl1", false);
                        var picBoxPemakaianCashColl2 = docInternalMemoPemakaianCashColl.FindControl("picBoxPemakaianCashColl2", false);
                        var lblPemakaianCashColl1 = docInternalMemoPemakaianCashColl.FindControl("lblPemakaianCashColl1", false);
                        var lblPemakaianCashColl2 = docInternalMemoPemakaianCashColl.FindControl("lblPemakaianCashColl2", false);
                        var xrTableCell44 = docInternalMemoPemakaianCashColl.FindControl("xrTableCell44", false);
                        var xrTableCell71 = docInternalMemoPemakaianCashColl.FindControl("xrTableCell71", false);

                        var picBoxPemakaianCashColl3 = docInternalMemoPemakaianCashColl.FindControl("picBoxPemakaianCashColl3", false);
                        var picBoxPemakaianCashColl4 = docInternalMemoPemakaianCashColl.FindControl("picBoxPemakaianCashColl4", false);
                        var lblPemakaianCashColl3 = docInternalMemoPemakaianCashColl.FindControl("lblPemakaianCashColl3", false);
                        var lblPemakaianCashColl4 = docInternalMemoPemakaianCashColl.FindControl("lblPemakaianCashColl4", false);
                        var xrTableCell49 = docInternalMemoPemakaianCashColl.FindControl("xrTableCell49", false);
                        var xrTableCell72 = docInternalMemoPemakaianCashColl.FindControl("xrTableCell72", false);

                        var picBoxPemakaianCashColl5 = docInternalMemoPemakaianCashColl.FindControl("picBoxPemakaianCashColl5", false);
                        var picBoxPemakaianCashColl6 = docInternalMemoPemakaianCashColl.FindControl("picBoxPemakaianCashColl6", false);
                        var lblPemakaianCashColl5 = docInternalMemoPemakaianCashColl.FindControl("lblPemakaianCashColl5", false);
                        var lblPemakaianCashColl6 = docInternalMemoPemakaianCashColl.FindControl("lblPemakaianCashColl6", false);
                        var xrTableCell52 = docInternalMemoPemakaianCashColl.FindControl("xrTableCell52", false);
                        var xrTableCell61 = docInternalMemoPemakaianCashColl.FindControl("xrTableCell61", false);

                        var picBoxPemakaianCashColl7 = docInternalMemoPemakaianCashColl.FindControl("picBoxPemakaianCashColl7", false);
                        var picBoxPemakaianCashColl8 = docInternalMemoPemakaianCashColl.FindControl("picBoxPemakaianCashColl8", false);
                        var lblPemakaianCashColl7 = docInternalMemoPemakaianCashColl.FindControl("lblPemakaianCashColl7", false);
                        var lblPemakaianCashColl8 = docInternalMemoPemakaianCashColl.FindControl("lblPemakaianCashColl8", false);
                        var xrTableCell64 = docInternalMemoPemakaianCashColl.FindControl("xrTableCell64", false);
                        var xrTableCell55 = docInternalMemoPemakaianCashColl.FindControl("xrTableCell55", false);

                        var picBoxPemakaianCashColl9 = docInternalMemoPemakaianCashColl.FindControl("picBoxPemakaianCashColl9", false);
                        var picBoxPemakaianCashColl10 = docInternalMemoPemakaianCashColl.FindControl("picBoxPemakaianCashColl10", false);
                        var lblPemakaianCashColl9 = docInternalMemoPemakaianCashColl.FindControl("lblPemakaianCashColl9", false);
                        var lblPemakaianCashColl10 = docInternalMemoPemakaianCashColl.FindControl("lblPemakaianCashColl10", false);
                        var xrTableCell58 = docInternalMemoPemakaianCashColl.FindControl("xrTableCell58", false);
                        var xrTableCell67 = docInternalMemoPemakaianCashColl.FindControl("xrTableCell67", false);

                        var picBoxPemakaianCashColl11 = docInternalMemoPemakaianCashColl.FindControl("picBoxPemakaianCashColl11", false);
                        var picBoxPemakaianCashColl12 = docInternalMemoPemakaianCashColl.FindControl("picBoxPemakaianCashColl12", false);
                        var lblPemakaianCashColl11 = docInternalMemoPemakaianCashColl.FindControl("lblPemakaianCashColl11", false);
                        var lblPemakaianCashColl12 = docInternalMemoPemakaianCashColl.FindControl("lblPemakaianCashColl12", false);
                        var xrTableCell83 = docInternalMemoPemakaianCashColl.FindControl("xrTableCell83", false);
                        var xrTableCell86 = docInternalMemoPemakaianCashColl.FindControl("xrTableCell86", false);

                        foreach (DataRow dataRow in myTable.Rows)
                        {
                            switch (Convert.ToInt32(dataRow["Seq"]))
                            {
                                case 0:
                                    break;
                                case 1:
                                    if (dataRow.Field<string>("IsDecision") == "T")
                                    {
                                        picBoxPemakaianCashColl1.Visible = dataRow.Field<string>("DecisionState") == "APPROVE" ? true : false;
                                        picBoxPemakaianCashColl2.Visible = dataRow.Field<string>("DecisionState") == "REJECT" ? true : false;
                                        lblPemakaianCashColl1.Visible = true;
                                        lblPemakaianCashColl1.Text = "Date : " + dataRow.Field<DateTime>("DecisionDate").ToString("dd/MM/yyyy HH:mm:ss");
                                        lblPemakaianCashColl2.Visible = true;
                                        lblPemakaianCashColl2.Text = "Note : " + dataRow.Field<string>("DecisionNote");
                                    }
                                    xrTableCell44.Text = dataRow.Field<string>("Nama");
                                    xrTableCell71.Text = dataRow.Field<string>("Jabatan");
                                    break;
                                case 2:
                                    if (dataRow.Field<string>("IsDecision") == "T")
                                    {
                                        picBoxPemakaianCashColl3.Visible = dataRow.Field<string>("DecisionState") == "APPROVE" ? true : false;
                                        picBoxPemakaianCashColl4.Visible = dataRow.Field<string>("DecisionState") == "REJECT" ? true : false;
                                        lblPemakaianCashColl3.Visible = true;
                                        lblPemakaianCashColl3.Text = "Date : " + dataRow.Field<DateTime>("DecisionDate").ToString("dd/MM/yyyy HH:mm:ss");
                                        lblPemakaianCashColl4.Visible = true;
                                        lblPemakaianCashColl4.Text = "Note : " + dataRow.Field<string>("DecisionNote");
                                    }
                                    xrTableCell49.Text = dataRow.Field<string>("Nama");
                                    xrTableCell72.Text = dataRow.Field<string>("Jabatan");
                                    break;
                                case 3:
                                    if (dataRow.Field<string>("IsDecision") == "T")
                                    {
                                        picBoxPemakaianCashColl5.Visible = dataRow.Field<string>("DecisionState") == "APPROVE" ? true : false;
                                        picBoxPemakaianCashColl6.Visible = dataRow.Field<string>("DecisionState") == "REJECT" ? true : false;
                                        lblPemakaianCashColl5.Visible = true;
                                        lblPemakaianCashColl5.Text = "Date : " + dataRow.Field<DateTime>("DecisionDate").ToString("dd/MM/yyyy HH:mm:ss");
                                        lblPemakaianCashColl6.Visible = true;
                                        lblPemakaianCashColl6.Text = "Note : " + dataRow.Field<string>("DecisionNote");
                                    }
                                    xrTableCell52.Text = dataRow.Field<string>("Nama");
                                    xrTableCell61.Text = dataRow.Field<string>("Jabatan");
                                    break;
                                case 4:
                                    if (dataRow.Field<string>("IsDecision") == "T")
                                    {
                                        picBoxPemakaianCashColl7.Visible = dataRow.Field<string>("DecisionState") == "APPROVE" ? true : false;
                                        picBoxPemakaianCashColl8.Visible = dataRow.Field<string>("DecisionState") == "REJECT" ? true : false;
                                        lblPemakaianCashColl7.Visible = true;
                                        lblPemakaianCashColl7.Text = "Date : " + dataRow.Field<DateTime>("DecisionDate").ToString("dd/MM/yyyy HH:mm:ss");
                                        lblPemakaianCashColl8.Visible = true;
                                        lblPemakaianCashColl8.Text = "Note : " + dataRow.Field<string>("DecisionNote");
                                    }
                                    xrTableCell64.Text = dataRow.Field<string>("Nama");
                                    xrTableCell55.Text = dataRow.Field<string>("Jabatan");
                                    break;
                                case 5:
                                    if (dataRow.Field<string>("IsDecision") == "T")
                                    {
                                        picBoxPemakaianCashColl9.Visible = dataRow.Field<string>("DecisionState") == "APPROVE" ? true : false;
                                        picBoxPemakaianCashColl10.Visible = dataRow.Field<string>("DecisionState") == "REJECT" ? true : false;
                                        lblPemakaianCashColl9.Visible = true;
                                        lblPemakaianCashColl9.Text = "Date : " + dataRow.Field<DateTime>("DecisionDate").ToString("dd/MM/yyyy HH:mm:ss");
                                        lblPemakaianCashColl10.Visible = true;
                                        lblPemakaianCashColl10.Text = "Note : " + dataRow.Field<string>("DecisionNote");
                                    }
                                    xrTableCell83.Text = dataRow.Field<string>("Nama");
                                    xrTableCell86.Text = dataRow.Field<string>("Jabatan");
                                    break;
                                case 6:
                                    if (dataRow.Field<string>("IsDecision") == "T")
                                    {
                                        picBoxPemakaianCashColl12.Visible = dataRow.Field<string>("DecisionState") == "APPROVE" ? true : false;
                                        picBoxPemakaianCashColl11.Visible = dataRow.Field<string>("DecisionState") == "REJECT" ? true : false;
                                        lblPemakaianCashColl11.Visible = true;
                                        lblPemakaianCashColl11.Text = "Date : " + dataRow.Field<DateTime>("DecisionDate").ToString("dd/MM/yyyy HH:mm:ss");
                                        lblPemakaianCashColl12.Visible = true;
                                        lblPemakaianCashColl12.Text = "Note : " + dataRow.Field<string>("DecisionNote");
                                    }
                                    xrTableCell58.Text = dataRow.Field<string>("Nama");
                                    xrTableCell67.Text = dataRow.Field<string>("Jabatan");
                                    break;

                            }
                        }

                        DevExpress.DataAccess.Sql.SqlDataSource ds1 = docInternalMemoPemakaianCashColl.DataSource as DevExpress.DataAccess.Sql.SqlDataSource;
                        ds1.ConnectionName = "SqlLocalConnectionString";
                        //ds1.ConnectionParameters = new DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters(".\\MNCGUI", "INFORMA", "sa", "invictus14", DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.SqlServer);
                        ds1.ConnectionParameters = new DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters("MNCGUI-NONCORE", "INFORMA", "applogin", "Gr3atMNC", DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.SqlServer);
                        //ds1.ConnectionParameters = new DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters("192.168.1.10", "INFORMA", "mncl", "Mncleasing123", DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.SqlServer);

                        dvrMain.Report = docInternalMemoPemakaianCashColl;
                        break;
                    #endregion
                    #region docInternalMemoPelepasanCrossColl
                    case "IM2":
                        if (this.Request.QueryString["DocNo"] == null) return;
                        docInternalMemoPelepasanCrossColl docInternalMemoPelepasanCrossColl = new docInternalMemoPelepasanCrossColl();
                        docInternalMemoPelepasanCrossColl.Parameters["DocNo"].Value = this.Request["DocNo"];
                        docInternalMemoPelepasanCrossColl.Parameters["DocKey"].Value = this.Request["DocKey"];
                        iDocKey = Convert.ToInt32(this.Request["DocKey"]);

                        myTable = myLocalDBSetting.GetDataTable("SELECT * FROM [dbo].[InternalMemoApprovalList] WHERE DocKey=?", false, iDocKey);

                        var picBoxPelepasanCrossColl1 = docInternalMemoPelepasanCrossColl.FindControl("picBoxPelepasanCrossColl1", false);
                        var picBoxPelepasanCrossColl2 = docInternalMemoPelepasanCrossColl.FindControl("picBoxPelepasanCrossColl2", false);
                        var lblPelepasanCrossColl1 = docInternalMemoPelepasanCrossColl.FindControl("lblPelepasanCrossColl1", false);
                        var lblPelepasanCrossColl2 = docInternalMemoPelepasanCrossColl.FindControl("lblPelepasanCrossColl2", false);
                        var NamaIM2_1 = docInternalMemoPelepasanCrossColl.FindControl("xrTableCell49", false);
                        var JabatanIM2_1 = docInternalMemoPelepasanCrossColl.FindControl("xrTableCell72", false);

                        var picBoxPelepasanCrossColl3 = docInternalMemoPelepasanCrossColl.FindControl("picBoxPelepasanCrossColl3", false);
                        var picBoxPelepasanCrossColl4 = docInternalMemoPelepasanCrossColl.FindControl("picBoxPelepasanCrossColl4", false);
                        var lblPelepasanCrossColl3 = docInternalMemoPelepasanCrossColl.FindControl("lblPelepasanCrossColl3", false);
                        var lblPelepasanCrossColl4 = docInternalMemoPelepasanCrossColl.FindControl("lblPelepasanCrossColl4", false);
                        var NamaIM2_2 = docInternalMemoPelepasanCrossColl.FindControl("xrTableCell53", false);
                        var JabatanIM2_2 = docInternalMemoPelepasanCrossColl.FindControl("xrTableCell56", false);

                        var picBoxPelepasanCrossColl5 = docInternalMemoPelepasanCrossColl.FindControl("picBoxPelepasanCrossColl5", false);
                        var picBoxPelepasanCrossColl6 = docInternalMemoPelepasanCrossColl.FindControl("picBoxPelepasanCrossColl6", false);
                        var lblPelepasanCrossColl5 = docInternalMemoPelepasanCrossColl.FindControl("lblPelepasanCrossColl5", false);
                        var lblPelepasanCrossColl6 = docInternalMemoPelepasanCrossColl.FindControl("lblPelepasanCrossColl6", false);
                        var NamaIM2_3 = docInternalMemoPelepasanCrossColl.FindControl("xrTableCell62", false);
                        var JabatanIM2_3 = docInternalMemoPelepasanCrossColl.FindControl("xrTableCell65", false);
                        var TableIM2_3 = docInternalMemoPelepasanCrossColl.FindControl("xrTable7", false);

                        var picBoxPelepasanCrossColl7 = docInternalMemoPelepasanCrossColl.FindControl("picBoxPelepasanCrossColl7", false);
                        var picBoxPelepasanCrossColl8 = docInternalMemoPelepasanCrossColl.FindControl("picBoxPelepasanCrossColl8", false);
                        var lblPelepasanCrossColl7 = docInternalMemoPelepasanCrossColl.FindControl("lblPelepasanCrossColl7", false);
                        var lblPelepasanCrossColl8 = docInternalMemoPelepasanCrossColl.FindControl("lblPelepasanCrossColl8", false);
                        var NamaIM2_4 = docInternalMemoPelepasanCrossColl.FindControl("xrTableCell74", false);
                        var JabatanIM2_4 = docInternalMemoPelepasanCrossColl.FindControl("xrTableCell77", false);
                        var TableIM2_4 = docInternalMemoPelepasanCrossColl.FindControl("xrTable8", false);

                        var picBoxPelepasanCrossColl9 = docInternalMemoPelepasanCrossColl.FindControl("picBoxPelepasanCrossColl9", false);
                        var picBoxPelepasanCrossColl10 = docInternalMemoPelepasanCrossColl.FindControl("picBoxPelepasanCrossColl10", false);
                        var lblPelepasanCrossColl9 = docInternalMemoPelepasanCrossColl.FindControl("lblPelepasanCrossColl9", false);
                        var lblPelepasanCrossColl10 = docInternalMemoPelepasanCrossColl.FindControl("lblPelepasanCrossColl10", false);
                        var NamaIM2_5 = docInternalMemoPelepasanCrossColl.FindControl("xrTableCell83", false);
                        var JabatanIM2_5 = docInternalMemoPelepasanCrossColl.FindControl("xrTableCell86", false);
                        var TableIM2_5 = docInternalMemoPelepasanCrossColl.FindControl("xrTable9", false);

                        var picBoxPelepasanCrossColl11 = docInternalMemoPelepasanCrossColl.FindControl("picBoxPelepasanCrossColl11", false);
                        var picBoxPelepasanCrossColl12 = docInternalMemoPelepasanCrossColl.FindControl("picBoxPelepasanCrossColl12", false);
                        var lblPelepasanCrossColl11 = docInternalMemoPelepasanCrossColl.FindControl("lblPelepasanCrossColl11", false);
                        var lblPelepasanCrossColl12 = docInternalMemoPelepasanCrossColl.FindControl("lblPelepasanCrossColl12", false);
                        var NamaIM2_6 = docInternalMemoPelepasanCrossColl.FindControl("xrTableCell71", false);
                        var JabatanIM2_6 = docInternalMemoPelepasanCrossColl.FindControl("xrTableCell91", false);
                        var TableIM2_6 = docInternalMemoPelepasanCrossColl.FindControl("xrTable10", false);

                        foreach (DataRow dataRow in myTable.Rows)
                        {
                            switch (Convert.ToInt32(dataRow["Seq"]))
                            {
                                case 0:
                                    break;
                                case 1:
                                    if (dataRow.Field<string>("IsDecision") == "T")
                                    {
                                        picBoxPelepasanCrossColl1.Visible = dataRow.Field<string>("DecisionState") == "APPROVE" ? true : false;
                                        picBoxPelepasanCrossColl2.Visible = dataRow.Field<string>("DecisionState") == "REJECT" ? true : false;
                                        lblPelepasanCrossColl1.Visible = true;
                                        lblPelepasanCrossColl1.Text = "Date : " + dataRow.Field<DateTime>("DecisionDate").ToString("dd/MM/yyyy HH:mm:ss");
                                        lblPelepasanCrossColl2.Visible = true;
                                        lblPelepasanCrossColl2.Text = "Note : " + dataRow.Field<string>("DecisionNote");
                                    }
                                    NamaIM2_1.Text = dataRow.Field<string>("Nama");
                                    JabatanIM2_1.Text = dataRow.Field<string>("Jabatan");
                                    break;
                                case 2:
                                    if (dataRow.Field<string>("IsDecision") == "T")
                                    {
                                        picBoxPelepasanCrossColl3.Visible = dataRow.Field<string>("DecisionState") == "APPROVE" ? true : false;
                                        picBoxPelepasanCrossColl4.Visible = dataRow.Field<string>("DecisionState") == "REJECT" ? true : false;
                                        lblPelepasanCrossColl3.Visible = true;
                                        lblPelepasanCrossColl3.Text = "Date : " + dataRow.Field<DateTime>("DecisionDate").ToString("dd/MM/yyyy HH:mm:ss");
                                        lblPelepasanCrossColl4.Visible = true;
                                        lblPelepasanCrossColl4.Text = "Note : " + dataRow.Field<string>("DecisionNote");
                                    }
                                    NamaIM2_2.Text = dataRow.Field<string>("Nama");
                                    JabatanIM2_2.Text = dataRow.Field<string>("Jabatan");
                                    break;
                                case 3:
                                    if (dataRow.Field<string>("IsDecision") == "T")
                                    {
                                        picBoxPelepasanCrossColl5.Visible = dataRow.Field<string>("DecisionState") == "APPROVE" ? true : false;
                                        picBoxPelepasanCrossColl6.Visible = dataRow.Field<string>("DecisionState") == "REJECT" ? true : false;
                                        lblPelepasanCrossColl5.Visible = true;
                                        lblPelepasanCrossColl5.Text = "Date : " + dataRow.Field<DateTime>("DecisionDate").ToString("dd/MM/yyyy HH:mm:ss");
                                        lblPelepasanCrossColl6.Visible = true;
                                        lblPelepasanCrossColl6.Text = "Note : " + dataRow.Field<string>("DecisionNote");
                                    }
                                    NamaIM2_3.Text = dataRow.Field<string>("Nama");
                                    JabatanIM2_3.Text = dataRow.Field<string>("Jabatan");
                                    break;
                                case 4:
                                    if (dataRow.Field<string>("IsDecision") == "T")
                                    {
                                        picBoxPelepasanCrossColl7.Visible = dataRow.Field<string>("DecisionState") == "APPROVE" ? true : false;
                                        picBoxPelepasanCrossColl8.Visible = dataRow.Field<string>("DecisionState") == "REJECT" ? true : false;
                                        lblPelepasanCrossColl7.Visible = true;
                                        lblPelepasanCrossColl7.Text = "Date : " + dataRow.Field<DateTime>("DecisionDate").ToString("dd/MM/yyyy HH:mm:ss");
                                        lblPelepasanCrossColl8.Visible = true;
                                        lblPelepasanCrossColl8.Text = "Note : " + dataRow.Field<string>("DecisionNote");
                                    }
                                    NamaIM2_4.Text = dataRow.Field<string>("Nama");
                                    JabatanIM2_4.Text = dataRow.Field<string>("Jabatan");
                                    break;
                                case 5:
                                    if (dataRow.Field<string>("IsDecision") == "T")
                                    {
                                        picBoxPelepasanCrossColl9.Visible = dataRow.Field<string>("DecisionState") == "APPROVE" ? true : false;
                                        picBoxPelepasanCrossColl10.Visible = dataRow.Field<string>("DecisionState") == "REJECT" ? true : false;
                                        lblPelepasanCrossColl9.Visible = true;
                                        lblPelepasanCrossColl9.Text = "Date : " + dataRow.Field<DateTime>("DecisionDate").ToString("dd/MM/yyyy HH:mm:ss");
                                        lblPelepasanCrossColl10.Visible = true;
                                        lblPelepasanCrossColl10.Text = "Note : " + dataRow.Field<string>("DecisionNote");
                                    }
                                    NamaIM2_5.Text = dataRow.Field<string>("Nama");
                                    JabatanIM2_5.Text = dataRow.Field<string>("Jabatan");
                                    break;
                                case 6:
                                    if (dataRow.Field<string>("IsDecision") == "T")
                                    {
                                        picBoxPelepasanCrossColl11.Visible = dataRow.Field<string>("DecisionState") == "APPROVE" ? true : false;
                                        picBoxPelepasanCrossColl12.Visible = dataRow.Field<string>("DecisionState") == "REJECT" ? true : false;
                                        lblPelepasanCrossColl11.Visible = true;
                                        lblPelepasanCrossColl11.Text = "Date : " + dataRow.Field<DateTime>("DecisionDate").ToString("dd/MM/yyyy HH:mm:ss");
                                        lblPelepasanCrossColl12.Visible = true;
                                        lblPelepasanCrossColl12.Text = "Note : " + dataRow.Field<string>("DecisionNote");
                                    }
                                    NamaIM2_6.Text = dataRow.Field<string>("Nama");
                                    JabatanIM2_6.Text = dataRow.Field<string>("Jabatan");
                                    break;
                            }
                        }

                        //if (NamaIM2_3.Text.Length < 10)
                        //    TableIM2_3.Visible = false;
                        //if (NamaIM2_4.Text.Length < 10)
                        //    TableIM2_4.Visible = false;
                        //if (NamaIM2_5.Text.Length < 10)
                        //    TableIM2_5.Visible = false;

                        DevExpress.DataAccess.Sql.SqlDataSource ds2 = docInternalMemoPelepasanCrossColl.DataSource as DevExpress.DataAccess.Sql.SqlDataSource;
                        ds2.ConnectionName = "SqlLocalConnectionString";
                        //ds2.ConnectionParameters = new DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters(".\\MNCGUI", "INFORMA", "sa", "invictus14", DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.SqlServer);
                        ds2.ConnectionParameters = new DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters("MNCGUI-NONCORE", "INFORMA", "applogin", "Gr3atMNC", DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.SqlServer);
                        //ds2.ConnectionParameters = new DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters("192.168.1.10", "INFORMA", "mncl", "Mncleasing123", DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.SqlServer);


                        dvrMain.Report = docInternalMemoPelepasanCrossColl;
                        break;
                    #endregion
                    #region docInternalMemoPendingGiro
                    case "IM3":
                        if (this.Request.QueryString["DocNo"] == null) return;
                        docInternalMemoPendingGiro docInternalMemoPendingGiro = new docInternalMemoPendingGiro();
                        docInternalMemoPendingGiro.Parameters["DocNo"].Value = this.Request["DocNo"];
                        docInternalMemoPendingGiro.Parameters["DocKey"].Value = this.Request["DocKey"];
                        iDocKey = Convert.ToInt32(this.Request["DocKey"]);

                        myTable = myLocalDBSetting.GetDataTable("SELECT * FROM [dbo].[InternalMemoApprovalList] WHERE DocKey=?", false, iDocKey);
                        myTableDetail = myLocalDBSetting.GetDataTable("SELECT TOP 1 * FROM [dbo].[InternalMemoDetailPendingGiro] WHERE DocKey=? ORDER BY LamaPenundaan DESC", false, iDocKey);

                        var picBoxPendingGiro1 = docInternalMemoPendingGiro.FindControl("picBoxPendingGiro1", false);
                        var picBoxPendingGiro2 = docInternalMemoPendingGiro.FindControl("picBoxPendingGiro2", false);
                        var lblPendingGiro1 = docInternalMemoPendingGiro.FindControl("lblPendingGiro1", false);
                        var lblPendingGiro2 = docInternalMemoPendingGiro.FindControl("lblPendingGiro2", false);
                        var lblGiroReviewName1 = docInternalMemoPendingGiro.FindControl("lblGiroReviewName1", false);
                        var lblGiroReviewJabatan1 = docInternalMemoPendingGiro.FindControl("lblGiroReviewJabatan1", false);

                        var picBoxPendingGiro3 = docInternalMemoPendingGiro.FindControl("picBoxPendingGiro3", false);
                        var picBoxPendingGiro4 = docInternalMemoPendingGiro.FindControl("picBoxPendingGiro4", false);
                        var lblPendingGiro3 = docInternalMemoPendingGiro.FindControl("lblPendingGiro3", false);
                        var lblPendingGiro4 = docInternalMemoPendingGiro.FindControl("lblPendingGiro4", false);
                        var lblGiroReviewName2 = docInternalMemoPendingGiro.FindControl("lblGiroReviewName2", false);
                        var lblGiroReviewJabatan2 = docInternalMemoPendingGiro.FindControl("lblGiroReviewJabatan2", false);

                        var picBoxPendingGiro5 = docInternalMemoPendingGiro.FindControl("picBoxPendingGiro5", false);
                        var picBoxPendingGiro6 = docInternalMemoPendingGiro.FindControl("picBoxPendingGiro6", false);
                        var lblPendingGiro5 = docInternalMemoPendingGiro.FindControl("lblPendingGiro5", false);
                        var lblPendingGiro6 = docInternalMemoPendingGiro.FindControl("lblPendingGiro6", false);
                        var lblGiroMenyetujuiName = docInternalMemoPendingGiro.FindControl("lblGiroMenyetujuiName", false);
                        var lblGiroMenyetujuiJabatan = docInternalMemoPendingGiro.FindControl("lblGiroMenyetujuiJabatan", false);

                        var picBoxPendingGiro7 = docInternalMemoPendingGiro.FindControl("picBoxPendingGiro7", false);
                        var picBoxPendingGiro8 = docInternalMemoPendingGiro.FindControl("picBoxPendingGiro8", false);
                        var lblPendingGiro7 = docInternalMemoPendingGiro.FindControl("lblPendingGiro7", false);
                        var lblPendingGiro8 = docInternalMemoPendingGiro.FindControl("lblPendingGiro8", false);
                        var lblGiroMenyetujuiName2 = docInternalMemoPendingGiro.FindControl("lblGiroMenyetujuiName2", false);
                        var lblGiroMenyetujuiJabatan2 = docInternalMemoPendingGiro.FindControl("lblGiroMenyetujuiJabatan2", false);

                        var picBoxPendingGiro9 = docInternalMemoPendingGiro.FindControl("picBoxPendingGiro9", false);
                        var picBoxPendingGiro10 = docInternalMemoPendingGiro.FindControl("picBoxPendingGiro10", false);
                        var lblPendingGiro9 = docInternalMemoPendingGiro.FindControl("lblPendingGiro9", false);
                        var lblPendingGiro10 = docInternalMemoPendingGiro.FindControl("lblPendingGiro10", false);
                        var lblGiroMenyetujuiName3 = docInternalMemoPendingGiro.FindControl("lblGiroMenyetujuiName3", false);
                        var lblGiroMenyetujuiJabatan3 = docInternalMemoPendingGiro.FindControl("lblGiroMenyetujuiJabatan3", false);

                        var xrtblPendingGiroFinalApp = docInternalMemoPendingGiro.FindControl("xrtblPendingGiroFinalApp", false);
                        var xrtblPendingGiroFinalApp2 = docInternalMemoPendingGiro.FindControl("xrtblPendingGiroFinalApp2", false);

                        foreach (DataRow dataRow in myTable.Rows)
                        {
                            switch (Convert.ToInt32(dataRow["Seq"]))
                            {
                                case 0:
                                    break;
                                case 1:
                                    if (dataRow.Field<string>("IsDecision") == "T")
                                    {
                                        picBoxPendingGiro1.Visible = dataRow.Field<string>("DecisionState") == "APPROVE" ? true : false;
                                        picBoxPendingGiro2.Visible = dataRow.Field<string>("DecisionState") == "REJECT" ? true : false;
                                        lblPendingGiro1.Visible = true;
                                        lblPendingGiro1.Text = "Date : " + dataRow.Field<DateTime>("DecisionDate").ToString("dd/MM/yyyy HH:mm:ss");
                                        lblPendingGiro2.Visible = true;
                                        lblPendingGiro2.Text = "Note : " + dataRow.Field<string>("DecisionNote");
                                    }
                                    lblGiroReviewName1.Text = dataRow.Field<string>("Nama");
                                    lblGiroReviewJabatan1.Text = dataRow.Field<string>("Jabatan");
                                    break;
                                case 2:
                                    if (dataRow.Field<string>("IsDecision") == "T")
                                    {
                                        picBoxPendingGiro3.Visible = dataRow.Field<string>("DecisionState") == "APPROVE" ? true : false;
                                        picBoxPendingGiro4.Visible = dataRow.Field<string>("DecisionState") == "REJECT" ? true : false;
                                        lblPendingGiro3.Visible = true;
                                        lblPendingGiro3.Text = "Date : " + dataRow.Field<DateTime>("DecisionDate").ToString("dd/MM/yyyy HH:mm:ss");
                                        lblPendingGiro4.Visible = true;
                                        lblPendingGiro4.Text = "Note : " + dataRow.Field<string>("DecisionNote");
                                    }
                                    lblGiroReviewName2.Text = dataRow.Field<string>("Nama");
                                    lblGiroReviewJabatan2.Text = dataRow.Field<string>("Jabatan");
                                    break;
                                case 3:
                                    if (dataRow.Field<string>("IsDecision") == "T")
                                    {
                                        picBoxPendingGiro5.Visible = dataRow.Field<string>("DecisionState") == "APPROVE" ? true : false;
                                        picBoxPendingGiro6.Visible = dataRow.Field<string>("DecisionState") == "REJECT" ? true : false;
                                        lblPendingGiro5.Visible = true;
                                        lblPendingGiro5.Text = "Date : " + dataRow.Field<DateTime>("DecisionDate").ToString("dd/MM/yyyy HH:mm:ss");
                                        lblPendingGiro6.Visible = true;
                                        lblPendingGiro6.Text = "Note : " + dataRow.Field<string>("DecisionNote");
                                    }
                                    lblGiroMenyetujuiName.Text = dataRow.Field<string>("Nama");
                                    lblGiroMenyetujuiJabatan.Text = dataRow.Field<string>("Jabatan");
                                    break;
                                case 4:
                                    if (dataRow.Field<string>("IsDecision") == "T")
                                    {
                                        picBoxPendingGiro7.Visible = dataRow.Field<string>("DecisionState") == "APPROVE" ? true : false;
                                        picBoxPendingGiro8.Visible = dataRow.Field<string>("DecisionState") == "REJECT" ? true : false;
                                        lblPendingGiro7.Visible = true;
                                        lblPendingGiro7.Text = "Date : " + dataRow.Field<DateTime>("DecisionDate").ToString("dd/MM/yyyy HH:mm:ss");
                                        lblPendingGiro8.Visible = true;
                                        lblPendingGiro8.Text = "Note : " + dataRow.Field<string>("DecisionNote");
                                    }
                                    lblGiroMenyetujuiName2.Text = dataRow.Field<string>("Nama");
                                    lblGiroMenyetujuiJabatan2.Text = dataRow.Field<string>("Jabatan");
                                    break;
                                case 5:
                                    if (dataRow.Field<string>("IsDecision") == "T")
                                    {
                                        picBoxPendingGiro9.Visible = dataRow.Field<string>("DecisionState") == "APPROVE" ? true : false;
                                        picBoxPendingGiro10.Visible = dataRow.Field<string>("DecisionState") == "REJECT" ? true : false;
                                        lblPendingGiro9.Visible = true;
                                        lblPendingGiro9.Text = "Date : " + dataRow.Field<DateTime>("DecisionDate").ToString("dd/MM/yyyy HH:mm:ss");
                                        lblPendingGiro10.Visible = true;
                                        lblPendingGiro10.Text = "Note : " + dataRow.Field<string>("DecisionNote");
                                    }
                                    lblGiroMenyetujuiName3.Text = dataRow.Field<string>("Nama");
                                    lblGiroMenyetujuiJabatan3.Text = dataRow.Field<string>("Jabatan");
                                    break;
                            }
                        }

                        foreach (DataRow dataRow in myTableDetail.Rows)
                        {
                            if (dataRow.Field<decimal>("LamaPenundaan") <= 7)
                            {
                                xrtblPendingGiroFinalApp.Visible = false;
                                xrtblPendingGiroFinalApp2.Visible = false;
                            }
                        }

                        DevExpress.DataAccess.Sql.SqlDataSource ds3 = docInternalMemoPendingGiro.DataSource as DevExpress.DataAccess.Sql.SqlDataSource;
                        ds3.ConnectionName = "SqlLocalConnectionString";
                        //ds3.ConnectionParameters = new DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters(".\\SQLEXPRESS", "INFORMA","","", DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.Windows);
                        ds3.ConnectionParameters = new DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters("MNCGUI-NONCORE", "INFORMA", "applogin", "Gr3atMNC", DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.SqlServer);
                        //ds3.ConnectionParameters = new DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters("192.168.1.10", "INFORMA", "mncl", "Mncleasing123", DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.SqlServer);


                        dvrMain.Report = docInternalMemoPendingGiro;
                        break;
                    #endregion
                    #region docInternalMemoPermohonanPengadaanBarang&Jasa
                    case "IM4":
                        if (this.Request.QueryString["DocNo"] == null) return;
                        docInternalMemoPermohonanBarangJasa docInternalMemoPermohonanBarangJasa = new docInternalMemoPermohonanBarangJasa();
                        docInternalMemoPermohonanBarangJasa.Parameters["DocNo"].Value = this.Request["DocNo"];
                        docInternalMemoPermohonanBarangJasa.Parameters["DocKey"].Value = this.Request["DocKey"];
                        iDocKey = Convert.ToInt32(this.Request["DocKey"]);

                        myTable = myLocalDBSetting.GetDataTable("SELECT * FROM [dbo].[InternalMemoApprovalList] WHERE DocKey=?", false, iDocKey);

                        var picBoxPurchaseReq1 = docInternalMemoPermohonanBarangJasa.FindControl("picBoxPurchaseReq1", false);
                        var picBoxPurchaseReq2 = docInternalMemoPermohonanBarangJasa.FindControl("picBoxPurchaseReq2", false);
                        var lblPurchaseReq1 = docInternalMemoPermohonanBarangJasa.FindControl("lblPurchaseReq1", false);
                        var lblPurchaseReq2 = docInternalMemoPermohonanBarangJasa.FindControl("lblPurchaseReq2", false);
                        var lblDisetujuiName = docInternalMemoPermohonanBarangJasa.FindControl("lblDisetujuiName", false);
                        var lblDisetujuiJabatan = docInternalMemoPermohonanBarangJasa.FindControl("lblDisetujuiJabatan", false);

                        var picBoxPurchaseReq3 = docInternalMemoPermohonanBarangJasa.FindControl("picBoxPurchaseReq3", false);
                        var picBoxPurchaseReq4 = docInternalMemoPermohonanBarangJasa.FindControl("picBoxPurchaseReq4", false);
                        var lblPurchaseReq3 = docInternalMemoPermohonanBarangJasa.FindControl("lblPurchaseReq3", false);
                        var lblPurchaseReq4 = docInternalMemoPermohonanBarangJasa.FindControl("lblPurchaseReq4", false);
                        var lblReviewITName = docInternalMemoPermohonanBarangJasa.FindControl("lblReviewITName", false);
                        var lblReviewITJabatan = docInternalMemoPermohonanBarangJasa.FindControl("lblReviewITJabatan", false);

                        var picBoxPurchaseReq5 = docInternalMemoPermohonanBarangJasa.FindControl("picBoxPurchaseReq5", false);
                        var picBoxPurchaseReq6 = docInternalMemoPermohonanBarangJasa.FindControl("picBoxPurchaseReq6", false);
                        var lblPurchaseReq5 = docInternalMemoPermohonanBarangJasa.FindControl("lblPurchaseReq5", false);
                        var lblPurchaseReq6 = docInternalMemoPermohonanBarangJasa.FindControl("lblPurchaseReq6", false);
                        var lblReviewBudgetName = docInternalMemoPermohonanBarangJasa.FindControl("lblReviewBudgetName", false);
                        var lblReviewBudgetJabatan = docInternalMemoPermohonanBarangJasa.FindControl("lblReviewBudgetJabatan", false);

                        var picBoxPurchaseReq7 = docInternalMemoPermohonanBarangJasa.FindControl("picBoxPurchaseReq7", false);
                        var picBoxPurchaseReq8 = docInternalMemoPermohonanBarangJasa.FindControl("picBoxPurchaseReq8", false);
                        var lblPurchaseReq7 = docInternalMemoPermohonanBarangJasa.FindControl("lblPurchaseReq7", false);
                        var lblPurchaseReq8 = docInternalMemoPermohonanBarangJasa.FindControl("lblPurchaseReq8", false);
                        var lblKeputusanCFOName = docInternalMemoPermohonanBarangJasa.FindControl("lblKeputusanCFOName", false);
                        var lblKeputusanCFOJabatan = docInternalMemoPermohonanBarangJasa.FindControl("lblKeputusanCFOJabatan", false);

                        foreach (DataRow dataRow in myTable.Rows)
                        {
                            switch (Convert.ToInt32(dataRow["Seq"]))
                            {
                                case 0:
                                    break;
                                case 1:
                                    if (dataRow.Field<string>("IsDecision") == "T")
                                    {
                                        picBoxPurchaseReq1.Visible = dataRow.Field<string>("DecisionState") == "APPROVE" ? true : false;
                                        picBoxPurchaseReq2.Visible = dataRow.Field<string>("DecisionState") == "REJECT" ? true : false;
                                        lblPurchaseReq1.Visible = true;
                                        lblPurchaseReq1.Text = "Date : " + dataRow.Field<DateTime>("DecisionDate").ToString("dd/MM/yyyy HH:mm:ss");
                                        lblPurchaseReq2.Visible = true;
                                        lblPurchaseReq2.Text = "Note : " + dataRow.Field<string>("DecisionNote");
                                    }
                                    lblDisetujuiName.Text = dataRow.Field<string>("Nama");
                                    lblDisetujuiJabatan.Text = dataRow.Field<string>("Jabatan");
                                    break;
                                case 2:
                                    if (dataRow.Field<string>("IsDecision") == "T")
                                    {
                                        picBoxPurchaseReq3.Visible = dataRow.Field<string>("DecisionState") == "APPROVE" ? true : false;
                                        picBoxPurchaseReq4.Visible = dataRow.Field<string>("DecisionState") == "REJECT" ? true : false;
                                        lblPurchaseReq3.Visible = true;
                                        lblPurchaseReq3.Text = "Date : " + dataRow.Field<DateTime>("DecisionDate").ToString("dd/MM/yyyy HH:mm:ss");
                                        lblPurchaseReq4.Visible = true;
                                        lblPurchaseReq4.Text = "Note : " + dataRow.Field<string>("DecisionNote");
                                    }
                                    lblReviewITName.Text = dataRow.Field<string>("Nama");
                                    lblReviewITJabatan.Text = dataRow.Field<string>("Jabatan");
                                    break;
                                case 3:
                                    if (dataRow.Field<string>("IsDecision") == "T")
                                    {
                                        picBoxPurchaseReq5.Visible = dataRow.Field<string>("DecisionState") == "APPROVE" ? true : false;
                                        picBoxPurchaseReq6.Visible = dataRow.Field<string>("DecisionState") == "REJECT" ? true : false;
                                        lblPurchaseReq5.Visible = true;
                                        lblPurchaseReq5.Text = "Date : " + dataRow.Field<DateTime>("DecisionDate").ToString("dd/MM/yyyy HH:mm:ss");
                                        lblPurchaseReq6.Visible = true;
                                        lblPurchaseReq6.Text = "Note : " + dataRow.Field<string>("DecisionNote");
                                    }
                                    lblReviewBudgetName.Text = dataRow.Field<string>("Nama");
                                    lblReviewBudgetJabatan.Text = dataRow.Field<string>("Jabatan");
                                    break;
                                case 4:
                                    if (dataRow.Field<string>("IsDecision") == "T")
                                    {
                                        picBoxPurchaseReq7.Visible = dataRow.Field<string>("DecisionState") == "APPROVE" ? true : false;
                                        picBoxPurchaseReq8.Visible = dataRow.Field<string>("DecisionState") == "REJECT" ? true : false;
                                        lblPurchaseReq7.Visible = true;
                                        lblPurchaseReq7.Text = "Date : " + dataRow.Field<DateTime>("DecisionDate").ToString("dd/MM/yyyy HH:mm:ss");
                                        lblPurchaseReq8.Visible = true;
                                        lblPurchaseReq8.Text = "Note : " + dataRow.Field<string>("DecisionNote");
                                    }
                                    lblKeputusanCFOName.Text = dataRow.Field<string>("Nama");
                                    lblKeputusanCFOJabatan.Text = dataRow.Field<string>("Jabatan");
                                    break;
                            }
                        }

                        DevExpress.DataAccess.Sql.SqlDataSource ds4 = docInternalMemoPermohonanBarangJasa.DataSource as DevExpress.DataAccess.Sql.SqlDataSource;
                        ds4.ConnectionName = "SqlLocalConnectionString";
                        //ds4.ConnectionParameters = new DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters(".\\MNCGUI", "INFORMA", "sa", "invictus14", DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.SqlServer);
                        ds4.ConnectionParameters = new DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters("MNCGUI-NONCORE", "INFORMA", "applogin", "Gr3atMNC", DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.SqlServer);

                        dvrMain.Report = docInternalMemoPermohonanBarangJasa;
                        break;
                    #endregion
                    #region docInternalMemoBiayaBulanan
                    case "IM5":
                        if (this.Request.QueryString["DocNo"] == null) return;
                        docInternalMemoBiayaBulanan docInternalMemoBiayaBulanan = new docInternalMemoBiayaBulanan();
                        docInternalMemoBiayaBulanan.Parameters["DocNo"].Value = this.Request["DocNo"];
                        docInternalMemoBiayaBulanan.Parameters["DocKey"].Value = this.Request["DocKey"];
                        iDocKey = Convert.ToInt32(this.Request["DocKey"]);

                        myTable = myLocalDBSetting.GetDataTable("SELECT * FROM [dbo].[InternalMemoApprovalList] WHERE DocKey=?", false, iDocKey);

                        var picBoxBiayaBulanan1 = docInternalMemoBiayaBulanan.FindControl("picBoxBiayaBulanan1", false);
                        var picBoxBiayaBulanan2 = docInternalMemoBiayaBulanan.FindControl("picBoxBiayaBulanan2", false);
                        var lblBiayaBulanan1 = docInternalMemoBiayaBulanan.FindControl("lblBiayaBulanan1", false);
                        var lblBiayaBulanan2 = docInternalMemoBiayaBulanan.FindControl("lblBiayaBulanan2", false);
                        var lblBiayaBulananMenyetujuiName = docInternalMemoBiayaBulanan.FindControl("lblBiayaBulananMenyetujuiName", false);
                        var lblBiayaBulananMenyetujuiJabatan = docInternalMemoBiayaBulanan.FindControl("lblBiayaBulananMenyetujuiJabatan", false);

                        foreach (DataRow dataRow in myTable.Rows)
                        {
                            switch (Convert.ToInt32(dataRow["Seq"]))
                            {
                                case 1:
                                    if (dataRow.Field<string>("IsDecision") == "T")
                                    {
                                        picBoxBiayaBulanan1.Visible = dataRow.Field<string>("DecisionState") == "APPROVE" ? true : false;
                                        picBoxBiayaBulanan2.Visible = dataRow.Field<string>("DecisionState") == "REJECT" ? true : false;
                                        lblBiayaBulanan1.Visible = true;
                                        lblBiayaBulanan1.Text = "Date : " + dataRow.Field<DateTime>("DecisionDate").ToString("dd/MM/yyyy HH:mm:ss");
                                        lblBiayaBulanan2.Visible = true;
                                        lblBiayaBulanan2.Text = "Note : " + dataRow.Field<string>("DecisionNote");
                                    }
                                    lblBiayaBulananMenyetujuiName.Text = dataRow.Field<string>("Nama");
                                    lblBiayaBulananMenyetujuiJabatan.Text = dataRow.Field<string>("Jabatan");
                                    break;
                            }
                        }

                        DevExpress.DataAccess.Sql.SqlDataSource ds5 = docInternalMemoBiayaBulanan.DataSource as DevExpress.DataAccess.Sql.SqlDataSource;
                        ds5.ConnectionName = "SqlLocalConnectionString";
                        //ds5.ConnectionParameters = new DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters(".\\MNCGUI", "INFORMA", "sa", "invictus14", DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.SqlServer);
                        ds5.ConnectionParameters = new DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters("MNCGUI-NONCORE", "INFORMA", "applogin", "Gr3atMNC", DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.SqlServer);

                        dvrMain.Report = docInternalMemoBiayaBulanan;
                        break;
                    #endregion
                    #region docFreeText
                    case "IM7":
                        dvrMain.Visible = false;
                        reMemo.Visible = true;

                        if (this.Request.QueryString["DocNo"] == null) return;
                        iDocKey = Convert.ToInt32(this.Request["DocKey"]);
                        string DocNo = this.Request.QueryString["DocNo"];

                        //myTable = myLocalDBSetting.GetDataTable("SELECT * FROM [dbo].[InternalMemo] WHERE DocKey=?", false, iDocKey);
                        //myTableDetail = myLocalDBSetting.GetDataTable("SELECT * FROM [dbo].[InternalMemoApprovalList] WHERE DocKey=?", false, iDocKey);
                        //myTableFreeText = myLocalDBSetting.GetDataTable("SELECT * FROM [dbo].[InternalMemoDetailFreeText] WHERE DocKey=?", false, iDocKey);

                        //if (this.Request.QueryString["DocNo"] == null) return;
                        //iDocKey = Convert.ToInt32(this.Request["DocKey"]);
                        //string DocNo = this.Request.QueryString["DocNo"];

                        //myTable = myLocalDBSetting.GetDataTable("SELECT * FROM [dbo].[InternalMemoDetailFreeText] WHERE DocKey=?", false, iDocKey);


                        //string temp_id = Guid.NewGuid().ToString();
                        //foreach (DataRow dataRow in myTable.Rows)
                        //{
                        //    reMemo.Open(temp_id, DocumentFormat.Rtf, () => { return (byte[])dataRow["FreeTextFile"]; });
                        //}

                        break;
                    #endregion


                    #region docInternalMemoDeviasi
                    case "IM8":
                        if (this.Request.QueryString["DocNo"] == null) return;
                        docInternalMemoDeviasi docInternalMemoDeviasi = new docInternalMemoDeviasi();
                        docInternalMemoDeviasi.Parameters["DocNo"].Value = this.Request["DocNo"];
                        docInternalMemoDeviasi.Parameters["DocKey"].Value = this.Request["DocKey"];
                        iDocKey = Convert.ToInt32(this.Request["DocKey"]);

                        myTable = myLocalDBSetting.GetDataTable("SELECT * FROM [dbo].[InternalMemoApprovalList] WHERE DocKey=?", false, iDocKey);
                        myTableDetail = myLocalDBSetting.GetDataTable("SELECT TOP 1 * FROM [dbo].[InternalMemoDetailDeviasi] WHERE DocKey=? ORDER BY Seq", false, iDocKey);
                        myTableDeviasi = myLocalDBSetting.GetDataTable("SELECT * FROM [dbo].[InternalMemo] WHERE DocKey=?", false, iDocKey);

                        var picBoxDeviasi1 = docInternalMemoDeviasi.FindControl("picBoxDeviasi1", false);
                        var picBoxDeviasi2 = docInternalMemoDeviasi.FindControl("picBoxDeviasi2", false);
                        var lblDeviasi1 = docInternalMemoDeviasi.FindControl("lblDeviasi1", false);
                        var lblDeviasi2 = docInternalMemoDeviasi.FindControl("lblDeviasi2", false);
                        var xrTableCell16 = docInternalMemoDeviasi.FindControl("xrTableCell16", false);
                        var xrTableCell711 = docInternalMemoDeviasi.FindControl("xrTableCell711", false);

                        var picBoxDeviasi3 = docInternalMemoDeviasi.FindControl("picBoxDeviasi3", false);
                        var picBoxDeviasi4 = docInternalMemoDeviasi.FindControl("picBoxDeviasi4", false);
                        var lblDeviasi3 = docInternalMemoDeviasi.FindControl("lblDeviasi3", false);
                        var lblDeviasi4 = docInternalMemoDeviasi.FindControl("lblDeviasi4", false);
                        var xrTableCell17 = docInternalMemoDeviasi.FindControl("xrTableCell17", false);
                        var xrTableCell722 = docInternalMemoDeviasi.FindControl("xrTableCell722", false);

                        var picBoxDeviasi5 = docInternalMemoDeviasi.FindControl("picBoxDeviasi5", false);
                        var picBoxDeviasi6 = docInternalMemoDeviasi.FindControl("picBoxDeviasi6", false);
                        var lblDeviasi5 = docInternalMemoDeviasi.FindControl("lblDeviasi5", false);
                        var lblDeviasi6 = docInternalMemoDeviasi.FindControl("lblDeviasi6", false);
                        var xrTableCell22 = docInternalMemoDeviasi.FindControl("xrTableCell22", false);
                        var xrTableCell611 = docInternalMemoDeviasi.FindControl("xrTableCell611", false);

                        var picBoxDeviasi7 = docInternalMemoDeviasi.FindControl("picBoxDeviasi7", false);
                        var picBoxDeviasi8 = docInternalMemoDeviasi.FindControl("picBoxDeviasi8", false);
                        var lblDeviasi7 = docInternalMemoDeviasi.FindControl("lblDeviasi7", false);
                        var lblDeviasi8 = docInternalMemoDeviasi.FindControl("lblDeviasi8", false);
                        var xrTableCell644 = docInternalMemoDeviasi.FindControl("xrTableCell644", false);
                        var xrTableCell300 = docInternalMemoDeviasi.FindControl("xrTableCell300", false);

                        var picBoxDeviasi9 = docInternalMemoDeviasi.FindControl("picBoxDeviasi9", false);
                        var picBoxDeviasi10 = docInternalMemoDeviasi.FindControl("picBoxDeviasi10", false);
                        var lblDeviasi9 = docInternalMemoDeviasi.FindControl("lblDeviasi9", false);
                        var lblDeviasi10 = docInternalMemoDeviasi.FindControl("lblDeviasi10", false);
                        var xrTableCell833 = docInternalMemoDeviasi.FindControl("xrTableCell833", false);
                        var xrTableCell866 = docInternalMemoDeviasi.FindControl("xrTableCell866", false);

                        var picBoxDeviasi11 = docInternalMemoDeviasi.FindControl("picBoxDeviasi11", false);
                        var picBoxDeviasi12 = docInternalMemoDeviasi.FindControl("picBoxDeviasi12", false);
                        var lblDeviasi11 = docInternalMemoDeviasi.FindControl("lblDeviasi11", false);
                        var lblDeviasi12 = docInternalMemoDeviasi.FindControl("lblDeviasi12", false);
                        var xrTableCell35 = docInternalMemoDeviasi.FindControl("xrTableCell35", false);
                        var xrTableCell677 = docInternalMemoDeviasi.FindControl("xrTableCell677", false);

                        var picBoxDeviasi13 = docInternalMemoDeviasi.FindControl("picBoxDeviasi13", false);
                        var picBoxDeviasi14 = docInternalMemoDeviasi.FindControl("picBoxDeviasi14", false);
                        var lblDeviasi13 = docInternalMemoDeviasi.FindControl("lblDeviasi13", false);
                        var lblDeviasi14 = docInternalMemoDeviasi.FindControl("lblDeviasi14", false);
                        var xrTableCell671 = docInternalMemoDeviasi.FindControl("xrTableCell671", false);
                        var xrTableCell831 = docInternalMemoDeviasi.FindControl("xrTableCell831", false);

                        var picBoxDeviasi15 = docInternalMemoDeviasi.FindControl("picBoxDeviasi15", false);
                        var picBoxDeviasi16 = docInternalMemoDeviasi.FindControl("picBoxDeviasi16", false);
                        var lblDeviasi15 = docInternalMemoDeviasi.FindControl("lblDeviasi15", false);
                        var lblDeviasi16 = docInternalMemoDeviasi.FindControl("lblDeviasi16", false);
                        var xrTableCell93 = docInternalMemoDeviasi.FindControl("xrTableCell93", false);
                        var xrTableCell96 = docInternalMemoDeviasi.FindControl("xrTableCell96", false);

                        var picBoxDeviasi61 = docInternalMemoDeviasi.FindControl("picBoxDeviasi61", false);
                        var picBoxDeviasi62 = docInternalMemoDeviasi.FindControl("picBoxDeviasi62", false);
                        var lblDeviasi60 = docInternalMemoDeviasi.FindControl("lblDeviasi60", false);
                        var lblDeviasi70 = docInternalMemoDeviasi.FindControl("lblDeviasi70", false);
                        var xrTableCell180 = docInternalMemoDeviasi.FindControl("xrTableCell180", false);
                        var xrTableCell183 = docInternalMemoDeviasi.FindControl("xrTableCell183", false);

                        var lblHeadertext = docInternalMemoDeviasi.FindControl("lblHeadertext", false);

                        lblHeadertext.Text = "Bersama ini kami mangajukan permohonan persetujuan penyimpangan bagi debitur dengan rincian berikut:";
                        DataRow drDeviasi = myTableDeviasi.Rows[0];
                        if (drDeviasi["DeviasiTBO"].ToString() != "")
                        {
                            lblHeadertext.Text = "Bersama ini kami mangajukan permohonan persetujuan perpanjangan penyimpangan bagi debitur dengan rincian berikut:";
                        }

                        foreach (DataRow dataRow in myTable.Rows)
                        {
                            switch (Convert.ToInt32(dataRow["Seq"]))
                            {
                                //case 0:
                                //    break;
                                case 0:
                                    if (dataRow.Field<string>("IsDecision") == "T")
                                    {
                                        picBoxDeviasi1.Visible = dataRow.Field<string>("DecisionState") == "APPROVE" ? true : false;
                                        picBoxDeviasi2.Visible = dataRow.Field<string>("DecisionState") == "REJECT" ? true : false;
                                        lblDeviasi1.Visible = true;
                                        lblDeviasi1.Text = "Date : " + dataRow.Field<DateTime>("DecisionDate").ToString("dd/MM/yyyy HH:mm:ss");
                                        lblDeviasi2.Visible = true;
                                        lblDeviasi2.Text = "Note : " + dataRow.Field<string>("DecisionNote");
                                    }
                                    xrTableCell16.Text = dataRow.Field<string>("Nama");
                                    xrTableCell711.Text = dataRow.Field<string>("Jabatan");
                                    break;
                                case 1:
                                    if (dataRow.Field<string>("IsDecision") == "T")
                                    {
                                        picBoxDeviasi3.Visible = dataRow.Field<string>("DecisionState") == "APPROVE" ? true : false;
                                        picBoxDeviasi4.Visible = dataRow.Field<string>("DecisionState") == "REJECT" ? true : false;
                                        lblDeviasi3.Visible = true;
                                        lblDeviasi3.Text = "Date : " + dataRow.Field<DateTime>("DecisionDate").ToString("dd/MM/yyyy HH:mm:ss");
                                        lblDeviasi4.Visible = true;
                                        lblDeviasi4.Text = "Note : " + dataRow.Field<string>("DecisionNote");
                                    }
                                    xrTableCell17.Text = dataRow.Field<string>("Nama");
                                    xrTableCell722.Text = dataRow.Field<string>("Jabatan");
                                    break;
                                case 2:
                                    if (dataRow.Field<string>("IsDecision") == "T")
                                    {
                                        picBoxDeviasi5.Visible = dataRow.Field<string>("DecisionState") == "APPROVE" ? true : false;
                                        picBoxDeviasi6.Visible = dataRow.Field<string>("DecisionState") == "REJECT" ? true : false;
                                        lblDeviasi5.Visible = true;
                                        lblDeviasi5.Text = "Date : " + dataRow.Field<DateTime>("DecisionDate").ToString("dd/MM/yyyy HH:mm:ss");
                                        lblDeviasi6.Visible = true;
                                        lblDeviasi6.Text = "Note : " + dataRow.Field<string>("DecisionNote");
                                    }
                                    xrTableCell22.Text = dataRow.Field<string>("Nama");
                                    xrTableCell611.Text = dataRow.Field<string>("Jabatan");
                                    break;
                                case 3:
                                    if (dataRow.Field<string>("IsDecision") == "T")
                                    {
                                        picBoxDeviasi7.Visible = dataRow.Field<string>("DecisionState") == "APPROVE" ? true : false;
                                        picBoxDeviasi8.Visible = dataRow.Field<string>("DecisionState") == "REJECT" ? true : false;
                                        lblDeviasi7.Visible = true;
                                        lblDeviasi7.Text = "Date : " + dataRow.Field<DateTime>("DecisionDate").ToString("dd/MM/yyyy HH:mm:ss");
                                        lblDeviasi8.Visible = true;
                                        lblDeviasi8.Text = "Note : " + dataRow.Field<string>("DecisionNote");
                                    }
                                    xrTableCell644.Text = dataRow.Field<string>("Nama");
                                    xrTableCell300.Text = dataRow.Field<string>("Jabatan");
                                    break;
                                case 4:
                                    if (dataRow.Field<string>("IsDecision") == "T")
                                    {
                                        picBoxDeviasi9.Visible = dataRow.Field<string>("DecisionState") == "APPROVE" ? true : false;
                                        picBoxDeviasi10.Visible = dataRow.Field<string>("DecisionState") == "REJECT" ? true : false;
                                        lblDeviasi9.Visible = true;
                                        lblDeviasi9.Text = "Date : " + dataRow.Field<DateTime>("DecisionDate").ToString("dd/MM/yyyy HH:mm:ss");
                                        lblDeviasi10.Visible = true;
                                        lblDeviasi10.Text = "Note : " + dataRow.Field<string>("DecisionNote");
                                    }
                                    xrTableCell833.Text = dataRow.Field<string>("Nama");
                                    xrTableCell866.Text = dataRow.Field<string>("Jabatan");
                                    break;
                                case 5:
                                    if (dataRow.Field<string>("IsDecision") == "T")
                                    {
                                        picBoxDeviasi11.Visible = dataRow.Field<string>("DecisionState") == "APPROVE" ? true : false;
                                        picBoxDeviasi12.Visible = dataRow.Field<string>("DecisionState") == "REJECT" ? true : false;
                                        lblDeviasi11.Visible = true;
                                        lblDeviasi11.Text = "Date : " + dataRow.Field<DateTime>("DecisionDate").ToString("dd/MM/yyyy HH:mm:ss");
                                        lblDeviasi12.Visible = true;
                                        lblDeviasi12.Text = "Note : " + dataRow.Field<string>("DecisionNote");
                                    }
                                    xrTableCell35.Text = dataRow.Field<string>("Nama");
                                    xrTableCell677.Text = dataRow.Field<string>("Jabatan");
                                    break;
                                case 6:
                                    if (dataRow.Field<string>("IsDecision") == "T")
                                    {
                                        picBoxDeviasi13.Visible = dataRow.Field<string>("DecisionState") == "APPROVE" ? true : false;
                                        picBoxDeviasi14.Visible = dataRow.Field<string>("DecisionState") == "REJECT" ? true : false;
                                        lblDeviasi13.Visible = true;
                                        lblDeviasi13.Text = "Date : " + dataRow.Field<DateTime>("DecisionDate").ToString("dd/MM/yyyy HH:mm:ss");
                                        lblDeviasi14.Visible = true;
                                        lblDeviasi14.Text = "Note : " + dataRow.Field<string>("DecisionNote");
                                    }
                                    xrTableCell671.Text = dataRow.Field<string>("Nama");
                                    xrTableCell831.Text = dataRow.Field<string>("Jabatan");
                                    break;
                                case 7:
                                    if (dataRow.Field<string>("IsDecision") == "T")
                                    {
                                        picBoxDeviasi15.Visible = dataRow.Field<string>("DecisionState") == "APPROVE" ? true : false;
                                        picBoxDeviasi16.Visible = dataRow.Field<string>("DecisionState") == "REJECT" ? true : false;
                                        lblDeviasi15.Visible = true;
                                        lblDeviasi15.Text = "Date : " + dataRow.Field<DateTime>("DecisionDate").ToString("dd/MM/yyyy HH:mm:ss");
                                        lblDeviasi16.Visible = true;
                                        lblDeviasi16.Text = "Note : " + dataRow.Field<string>("DecisionNote");
                                    }
                                    xrTableCell93.Text = dataRow.Field<string>("Nama");
                                    xrTableCell96.Text = dataRow.Field<string>("Jabatan");
                                    break;
                                case 8:
                                    if (dataRow.Field<string>("IsDecision") == "T")
                                    {
                                        picBoxDeviasi61.Visible = dataRow.Field<string>("DecisionState") == "APPROVE" ? true : false;
                                        picBoxDeviasi62.Visible = dataRow.Field<string>("DecisionState") == "REJECT" ? true : false;
                                        lblDeviasi60.Visible = true;
                                        lblDeviasi60.Text = "Date : " + dataRow.Field<DateTime>("DecisionDate").ToString("dd/MM/yyyy HH:mm:ss");
                                        lblDeviasi70.Visible = true;
                                        lblDeviasi70.Text = "Note : " + dataRow.Field<string>("DecisionNote");
                                    }
                                    xrTableCell180.Text = dataRow.Field<string>("Nama");
                                    xrTableCell183.Text = dataRow.Field<string>("Jabatan");
                                    break;
                            }
                        }

                        DevExpress.DataAccess.Sql.SqlDataSource ds8 = docInternalMemoDeviasi.DataSource as DevExpress.DataAccess.Sql.SqlDataSource;
                        ds8.ConnectionName = "SqlLocalConnectionString";
                        //ds8.ConnectionParameters = new DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters(".\\SQLEXPRESS", "INFORMA", "", "", DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.Windows);
                        ds8.ConnectionParameters = new DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters("MNCGUI-NONCORE", "INFORMA", "applogin", "Gr3atMNC", DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.SqlServer);
                        //ds8.ConnectionParameters = new DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters("192.168.1.10", "INFORMA", "mncl", "Mncleasing123", DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.SqlServer);

                        dvrMain.Report = docInternalMemoDeviasi;
                        break;
                    #endregion

                    #region docInternalMemoException
                    case "IM9":
                        if (this.Request.QueryString["DocNo"] == null) return;
                        docInternalMemoException docInternalMemoException = new docInternalMemoException();
                        docInternalMemoException.Parameters["DocNo"].Value = this.Request["DocNo"];
                        docInternalMemoException.Parameters["DocKey"].Value = this.Request["DocKey"];
                        iDocKey = Convert.ToInt32(this.Request["DocKey"]);

                        myTable = myLocalDBSetting.GetDataTable("SELECT * FROM [dbo].[InternalMemoApprovalList] WHERE DocKey=?", false, iDocKey);
                        myTableDetail = myLocalDBSetting.GetDataTable("SELECT TOP 1 * FROM [dbo].[InternalMemoDetailException] WHERE DocKey=? ORDER BY Seq", false, iDocKey);

                        var picBoxException1 = docInternalMemoException.FindControl("picBoxException1", false);
                        var picBoxException2 = docInternalMemoException.FindControl("picBoxException2", false);
                        var lblException1 = docInternalMemoException.FindControl("lblException1", false);
                        var lblException2 = docInternalMemoException.FindControl("lblException2", false);
                        var xrException16 = docInternalMemoException.FindControl("xrException16", false);
                        var xrException711 = docInternalMemoException.FindControl("xrException711", false);

                        var picBoxException3 = docInternalMemoException.FindControl("picBoxException3", false);
                        var picBoxException4 = docInternalMemoException.FindControl("picBoxException4", false);
                        var lblException3 = docInternalMemoException.FindControl("lblException3", false);
                        var lblException4 = docInternalMemoException.FindControl("lblException4", false);
                        var xrException17 = docInternalMemoException.FindControl("xrException17", false);
                        var xrException722 = docInternalMemoException.FindControl("xrException722", false);

                        var picBoxException5 = docInternalMemoException.FindControl("picBoxException5", false);
                        var picBoxException6 = docInternalMemoException.FindControl("picBoxException6", false);
                        var lblException5 = docInternalMemoException.FindControl("lblException5", false);
                        var lblException6 = docInternalMemoException.FindControl("lblException6", false);
                        var xrException22 = docInternalMemoException.FindControl("xrException22", false);
                        var xrException611 = docInternalMemoException.FindControl("xrException611", false);

                        var picBoxException7 = docInternalMemoException.FindControl("picBoxException7", false);
                        var picBoxException8 = docInternalMemoException.FindControl("picBoxException8", false);
                        var lblException7 = docInternalMemoException.FindControl("lblException7", false);
                        var lblException8 = docInternalMemoException.FindControl("lblException8", false);
                        var xrException644 = docInternalMemoException.FindControl("xrException644", false);
                        var xrException300 = docInternalMemoException.FindControl("xrException300", false);

                        var picBoxException9 = docInternalMemoException.FindControl("picBoxException9", false);
                        var picBoxException10 = docInternalMemoException.FindControl("picBoxException10", false);
                        var lblException9 = docInternalMemoException.FindControl("lblException9", false);
                        var lblException10 = docInternalMemoException.FindControl("lblException10", false);
                        var xrException833 = docInternalMemoException.FindControl("xrException833", false);
                        var xrException866 = docInternalMemoException.FindControl("xrException866", false);

                        var picBoxException11 = docInternalMemoException.FindControl("picBoxException11", false);
                        var picBoxException12 = docInternalMemoException.FindControl("picBoxException12", false);
                        var lblException11 = docInternalMemoException.FindControl("lblException11", false);
                        var lblException12 = docInternalMemoException.FindControl("lblException12", false);
                        var xrException35 = docInternalMemoException.FindControl("xrException35", false);
                        var xrException677 = docInternalMemoException.FindControl("xrException677", false);

                        var picBoxException13 = docInternalMemoException.FindControl("picBoxException13", false);
                        var picBoxException14 = docInternalMemoException.FindControl("picBoxException14", false);
                        var lblException13 = docInternalMemoException.FindControl("lblException13", false);
                        var lblException14 = docInternalMemoException.FindControl("lblException14", false);
                        var xrException221 = docInternalMemoException.FindControl("xrException221", false);
                        var xrException351 = docInternalMemoException.FindControl("xrException351", false);

                        var picBoxException15 = docInternalMemoException.FindControl("picBoxException15", false);
                        var picBoxException16 = docInternalMemoException.FindControl("picBoxException16", false);
                        var picBoxException17 = docInternalMemoException.FindControl("picBoxException17", false);
                        var picBoxException18 = docInternalMemoException.FindControl("picBoxException18", false);
                        var lblException15 = docInternalMemoException.FindControl("lblException15", false);
                        var lblException17 = docInternalMemoException.FindControl("lblException17", false);
                        var lblException16 = docInternalMemoException.FindControl("lblException16", false);
                        var lblException18 = docInternalMemoException.FindControl("lblException18", false);
                        var xrException83 = docInternalMemoException.FindControl("xrException83", false);
                        var xrException90 = docInternalMemoException.FindControl("xrException90", false);
                        var xrException95 = docInternalMemoException.FindControl("xrException95", false);
                        var xrException98 = docInternalMemoException.FindControl("xrException98", false);

                        foreach (DataRow dataRow in myTable.Rows)
                        {
                            switch (Convert.ToInt32(dataRow["Seq"]))
                            {
                                //case 0:
                                //    break;
                                case 0:
                                    if (dataRow.Field<string>("IsDecision") == "T")
                                    {
                                        picBoxException1.Visible = dataRow.Field<string>("DecisionState") == "APPROVE" ? true : false;
                                        picBoxException2.Visible = dataRow.Field<string>("DecisionState") == "REJECT" ? true : false;
                                        lblException1.Visible = true;
                                        lblException1.Text = "Date : " + dataRow.Field<DateTime>("DecisionDate").ToString("dd/MM/yyyy HH:mm:ss");
                                        lblException2.Visible = true;
                                        lblException2.Text = "Note : " + dataRow.Field<string>("DecisionNote");
                                    }
                                    xrException16.Text = dataRow.Field<string>("Nama");
                                    xrException711.Text = dataRow.Field<string>("Jabatan");
                                    break;
                                case 1:
                                    if (dataRow.Field<string>("IsDecision") == "T")
                                    {
                                        picBoxException3.Visible = dataRow.Field<string>("DecisionState") == "APPROVE" ? true : false;
                                        picBoxException4.Visible = dataRow.Field<string>("DecisionState") == "REJECT" ? true : false;
                                        lblException3.Visible = true;
                                        lblException3.Text = "Date : " + dataRow.Field<DateTime>("DecisionDate").ToString("dd/MM/yyyy HH:mm:ss");
                                        lblException4.Visible = true;
                                        lblException4.Text = "Note : " + dataRow.Field<string>("DecisionNote");
                                    }
                                    xrException17.Text = dataRow.Field<string>("Nama");
                                    xrException722.Text = dataRow.Field<string>("Jabatan");
                                    break;
                                case 2:
                                    if (dataRow.Field<string>("IsDecision") == "T")
                                    {
                                        picBoxException5.Visible = dataRow.Field<string>("DecisionState") == "APPROVE" ? true : false;
                                        picBoxException6.Visible = dataRow.Field<string>("DecisionState") == "REJECT" ? true : false;
                                        lblException5.Visible = true;
                                        lblException5.Text = "Date : " + dataRow.Field<DateTime>("DecisionDate").ToString("dd/MM/yyyy HH:mm:ss");
                                        lblException6.Visible = true;
                                        lblException6.Text = "Note : " + dataRow.Field<string>("DecisionNote");
                                    }
                                    xrException22.Text = dataRow.Field<string>("Nama");
                                    xrException611.Text = dataRow.Field<string>("Jabatan");
                                    break;
                                case 3:
                                    if (dataRow.Field<string>("IsDecision") == "T")
                                    {
                                        picBoxException7.Visible = dataRow.Field<string>("DecisionState") == "APPROVE" ? true : false;
                                        picBoxException8.Visible = dataRow.Field<string>("DecisionState") == "REJECT" ? true : false;
                                        lblException7.Visible = true;
                                        lblException7.Text = "Date : " + dataRow.Field<DateTime>("DecisionDate").ToString("dd/MM/yyyy HH:mm:ss");
                                        lblException8.Visible = true;
                                        lblException8.Text = "Note : " + dataRow.Field<string>("DecisionNote");
                                    }
                                    xrException644.Text = dataRow.Field<string>("Nama");
                                    xrException300.Text = dataRow.Field<string>("Jabatan");
                                    break;
                                case 4:
                                    if (dataRow.Field<string>("IsDecision") == "T")
                                    {
                                        picBoxException9.Visible = dataRow.Field<string>("DecisionState") == "APPROVE" ? true : false;
                                        picBoxException10.Visible = dataRow.Field<string>("DecisionState") == "REJECT" ? true : false;
                                        lblException9.Visible = true;
                                        lblException9.Text = "Date : " + dataRow.Field<DateTime>("DecisionDate").ToString("dd/MM/yyyy HH:mm:ss");
                                        lblException10.Visible = true;
                                        lblException10.Text = "Note : " + dataRow.Field<string>("DecisionNote");
                                    }
                                    xrException833.Text = dataRow.Field<string>("Nama");
                                    xrException866.Text = dataRow.Field<string>("Jabatan");
                                    break;
                                case 5:
                                    if (dataRow.Field<string>("IsDecision") == "T")
                                    {
                                        picBoxException11.Visible = dataRow.Field<string>("DecisionState") == "APPROVE" ? true : false;
                                        picBoxException12.Visible = dataRow.Field<string>("DecisionState") == "REJECT" ? true : false;
                                        lblException11.Visible = true;
                                        lblException11.Text = "Date : " + dataRow.Field<DateTime>("DecisionDate").ToString("dd/MM/yyyy HH:mm:ss");
                                        lblException12.Visible = true;
                                        lblException12.Text = "Note : " + dataRow.Field<string>("DecisionNote");
                                    }
                                    xrException35.Text = dataRow.Field<string>("Nama");
                                    xrException677.Text = dataRow.Field<string>("Jabatan");
                                    break;
                                case 6:
                                    if (dataRow.Field<string>("IsDecision") == "T")
                                    {
                                        picBoxException14.Visible = dataRow.Field<string>("DecisionState") == "APPROVE" ? true : false;
                                        picBoxException13.Visible = dataRow.Field<string>("DecisionState") == "REJECT" ? true : false;
                                        lblException13.Visible = true;
                                        lblException13.Text = "Date : " + dataRow.Field<DateTime>("DecisionDate").ToString("dd/MM/yyyy HH:mm:ss");
                                        lblException14.Visible = true;
                                        lblException14.Text = "Note : " + dataRow.Field<string>("DecisionNote");
                                    }
                                    xrException221.Text = dataRow.Field<string>("Nama");
                                    xrException351.Text = dataRow.Field<string>("Jabatan");
                                    break;
                                case 7:
                                    if (dataRow.Field<string>("IsDecision") == "T")
                                    {
                                        picBoxException15.Visible = dataRow.Field<string>("DecisionState") == "APPROVE" ? true : false;
                                        picBoxException16.Visible = dataRow.Field<string>("DecisionState") == "REJECT" ? true : false;
                                        lblException15.Visible = true;
                                        lblException15.Text = "Date : " + dataRow.Field<DateTime>("DecisionDate").ToString("dd/MM/yyyy HH:mm:ss");
                                        lblException16.Visible = true;
                                        lblException16.Text = "Note : " + dataRow.Field<string>("DecisionNote");
                                    }
                                    xrException83.Text = dataRow.Field<string>("Nama");
                                    xrException90.Text = dataRow.Field<string>("Jabatan");
                                    break;
                                case 8:
                                    if (dataRow.Field<string>("IsDecision") == "T")
                                    {
                                        picBoxException17.Visible = dataRow.Field<string>("DecisionState") == "APPROVE" ? true : false;
                                        picBoxException18.Visible = dataRow.Field<string>("DecisionState") == "REJECT" ? true : false;
                                        lblException17.Visible = true;
                                        lblException17.Text = "Date : " + dataRow.Field<DateTime>("DecisionDate").ToString("dd/MM/yyyy HH:mm:ss");
                                        lblException18.Visible = true;
                                        lblException18.Text = "Note : " + dataRow.Field<string>("DecisionNote");
                                    }
                                    xrException95.Text = dataRow.Field<string>("Nama");
                                    xrException98.Text = dataRow.Field<string>("Jabatan");
                                    break;

                            }
                        }

                        DevExpress.DataAccess.Sql.SqlDataSource ds9 = docInternalMemoException.DataSource as DevExpress.DataAccess.Sql.SqlDataSource;
                        ds9.ConnectionName = "SqlLocalConnectionString";
                        //ds9.ConnectionParameters = new DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters(".\\SQLEXPRESS", "INFORMA", "", "", DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.Windows);
                        ds9.ConnectionParameters = new DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters("MNCGUI-NONCORE", "INFORMA", "applogin", "Gr3atMNC", DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.SqlServer);
                        //ds9.ConnectionParameters = new DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters("192.168.1.10", "INFORMA", "mncl", "Mncleasing123", DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.SqlServer);

                        dvrMain.Report = docInternalMemoException;
                        break;
                        #endregion
                }
            }
            else
            {

            }
        }

        protected void LoadTemplate()
        {
            DataTable loadDoc = new DataTable();
            loadDoc = localdbsetting.GetDataTable("SELECT * FROM [INFORMA].[dbo].[FreeTextTemplate] WHERE id = 25", false);
            string strRitchEditorKey = Guid.NewGuid().ToString();

            foreach (DataRow dr in loadDoc.Rows)
            {
                reMemo.Open(strRitchEditorKey, DocumentFormat.Rtf, () => { return (byte[])dr["docFile"]; });
            }
        }

        protected void reMemo_Init(object sender, EventArgs e)
        {
            DataTable myTable = new DataTable();
            myLocalDBSetting = localdbsetting;

            if (this.Request.QueryString["ReportType"] != null)
            {
                switch (this.Request.QueryString["ReportType"].ToString().ToUpper())
                {
                    case "IM7":
                        LoadTemplate();
                        break;
                }
            }
        }


        protected void reMemo_CalculateDocumentVariable(object sender, CalculateDocumentVariableEventArgs e)
        {
            myTable = myLocalDBSetting.GetDataTable("SELECT * FROM [dbo].[InternalMemo] WHERE DocKey=?", false, iDocKey);
            myTableDetail = myLocalDBSetting.GetDataTable("SELECT * FROM [dbo].[InternalMemoApprovalList] WHERE DocKey=?", false, iDocKey);
            myTableFreeText = myLocalDBSetting.GetDataTable("SELECT * FROM [dbo].[InternalMemoDetailFreeText] WHERE DocKey=?", false, iDocKey);
            int seqApproval = 0;

            switch (e.VariableName)
            {
                case "Isi":
                    if (myTableFreeText.Rows.Count > 0)
                    {
                        byte[] arr = (byte[])myTableFreeText.Rows[0]["FreeTextFile"];
                        Stream stream = new MemoryStream(arr);

                        RichEditDocumentServer srv = new RichEditDocumentServer();
                        srv.LoadDocument(stream, DocumentFormat.Rtf);

                        e.Value = srv.Document;
                        e.Handled = true;
                    }
                    break;
                case "DocNo":
                    e.Value = myTable.Rows[0]["DocNo"].ToString();
                    e.Handled = true;
                    break;
                case "Header":
                    string hdrVal = e.Arguments[0].Value.ToString();
                    if (hdrVal == "Kepada")
                    {
                        e.Value = myTable.Rows[0]["MemoTo"].ToString();
                        e.Handled = true;
                    }

                    if (hdrVal == "Tembusan")
                    {
                        e.Value = myTable.Rows[0]["MemoCC"].ToString();
                        e.Handled = true;
                    }

                    if (hdrVal == "Dari")
                    {
                        e.Value = myTable.Rows[0]["MemoFrom"].ToString();
                        e.Handled = true;
                    }

                    if (hdrVal == "Tanggal")
                    {
                        e.Value = Convert.ToDateTime(myTable.Rows[0]["DocDate"]).ToString("dd/MM/yyyy");
                        e.Handled = true;
                    }

                    if (hdrVal == "Perihal")
                    {
                        e.Value = myTable.Rows[0]["MemoPerihal"].ToString();
                        e.Handled = true;
                    }

                    break;
                case "Name":
                    string nameVal = e.Arguments[0].Value.ToString();
                    if (myTableDetail.Rows.Count > 0)
                    {
                        seqApproval = 0;
                        foreach (DataRow dr in myTableDetail.Rows)
                        {
                            seqApproval += 1;
                            string hfieldName = "App" + seqApproval.ToString();

                            if (nameVal == "Pemohon")
                            {
                                e.Value = myTable.Rows[0]["MemoFrom"].ToString();
                                e.Handled = true;
                            }

                            if (nameVal == hfieldName)
                            {
                                e.Value = dr["Nama"].ToString();
                                e.Handled = true;
                            }

                        }
                    }
                    break;
                case "Jabatan":
                    string jabatanVal = e.Arguments[0].Value.ToString();
                    if (myTableDetail.Rows.Count > 0)
                    {
                        seqApproval = 0;
                        foreach (DataRow dr in myTableDetail.Rows)
                        {
                            seqApproval += 1;
                            string hfieldJabatan = "App" + seqApproval.ToString();

                            if (jabatanVal == hfieldJabatan)
                            {
                                e.Value = dr["Jabatan"].ToString();
                                e.Handled = true;
                            }
                        }
                    }
                    break;
                case "Sign":
                    string signVal = e.Arguments[0].Value.ToString();
                    if (myTableDetail.Rows.Count > 0)
                    {
                        //Pemohon
                        string filePath = Server.MapPath("~/Content/Images/mysign.png");
                        DocumentImageSource img = DocumentImageSource.FromFile(filePath);
                        RichEditDocumentServer srv = new RichEditDocumentServer();

                        if (signVal == "Pemohon")
                        {
                            srv.Document.Images.Append(img);
                            e.Value = srv.Document;
                            e.Handled = true;
                        }

                        seqApproval = 0;
                        foreach (DataRow dr in myTableDetail.Rows)
                        {
                            seqApproval += 1;
                            string hfieldSign = "App" + seqApproval.ToString();

                            if (signVal == hfieldSign)
                            {
                                string decState = dr["DecisionState"].ToString();
                                if (decState == "APPROVE")
                                {
                                    filePath = Server.MapPath("~/Content/Images/approve.png");
                                    img = DocumentImageSource.FromFile(filePath);
                                    srv = new RichEditDocumentServer();
                                    srv.Document.Images.Append(img);
                                    e.Value = srv.Document;
                                    e.Handled = true;
                                }

                                if (decState == "REJECT")
                                {
                                    filePath = Server.MapPath("~/Content/Images/reject.png");
                                    img = DocumentImageSource.FromFile(filePath);
                                    srv = new RichEditDocumentServer();
                                    srv.Document.Images.Append(img);
                                    e.Value = srv.Document;
                                    e.Handled = true;
                                }
                            }
                        }
                    }
                    break;
                case "Date":
                    string dateVal = e.Arguments[0].Value.ToString();
                    seqApproval = 0;
                    foreach (DataRow dr in myTableDetail.Rows)
                    {
                        seqApproval += 1;
                        string hfieldDate = "App" + seqApproval.ToString();

                        if (dateVal == hfieldDate)
                        {
                            string decState = dr["DecisionState"].ToString();
                            string decDate = "";
                            if (dr["DecisionDate"] != DBNull.Value && dr["DecisionDate"] != null)
                            {
                                decDate = Convert.ToDateTime(dr["DecisionDate"]).ToString("dd/MM/yyyy");
                            }
                            if (decState == "APPROVE" || decState == "REJECT")
                            {
                                e.Value = "Date: " + decDate;
                                e.Handled = true;
                            }
                        }
                    }
                    break;
                case "Note":
                    string noteVal = e.Arguments[0].Value.ToString();
                    seqApproval = 0;
                    foreach (DataRow dr in myTableDetail.Rows)
                    {
                        seqApproval += 1;
                        string hfieldNote = "App" + seqApproval.ToString();

                        if (noteVal == hfieldNote)
                        {
                            string decState = dr["DecisionState"].ToString();
                            string decNote = dr["DecisionNote"].ToString();
                            if (decState == "APPROVE" || decState == "REJECT")
                            {
                                e.Value = "Note: " + decNote;
                                e.Handled = true;
                            }
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        protected void reMemo_PreRender(object sender, EventArgs e)
        {
            reMemo.Focus();
        }

        protected void cplMain_Callback(object source, CallbackEventArgs e)
        {
            string[] callbackParam = e.Parameter.ToString().Split(';');
            cplMain.JSProperties["cpCallbackParam"] = callbackParam[0].ToUpper();

            switch (callbackParam[0].ToUpper())
            {
                case "FREETEXT":
                    reMemo.ReadOnly = true;
                    break;
                case "FREETEXT_PDF":
                    //MemoryStream PDFStream = new MemoryStream();
                    //reMemo.ExportToPdf(PDFStream);
                    //byte[] FileBuffer = PDFStream.ToArray();
                    //if (FileBuffer != null)
                    //{
                    //    Response.ContentType = "application/pdf";
                    //    Response.AddHeader("content-length", FileBuffer.Length.ToString());
                    //    Response.AppendHeader("content-disposition", string.Format("attachment;FileName=\"{0}\"", "FreeTextMemo" + ".pdf"));
                    //    Response.BinaryWrite(FileBuffer);
                    //}
                    break;
            }
        }




    }
}