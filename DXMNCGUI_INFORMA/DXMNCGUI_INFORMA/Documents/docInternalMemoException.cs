using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for docInternalMemoPendingGiro
/// </summary>
public class docInternalMemoException : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
    private ReportHeaderBand ReportHeader;
    private XRLine xrLine1;
    private XRTable xrTable1;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell1;
    private XRTableCell xrTableCell2;
    private XRTableCell xrTableCell3;
    private XRTableRow xrTableRow3;
    private XRTableCell xrTableCell7;
    private XRTableCell xrTableCell8;
    private XRTableCell xrTableCell9;
    private XRTableRow xrTableRow4;
    private XRTableCell xrTableCell10;
    private XRTableCell xrTableCell11;
    private XRTableCell xrTableCell12;
    private XRTableRow xrTableRow2;
    private XRTableCell xrTableCell4;
    private XRTableCell xrTableCell5;
    private XRTableCell xrTableCell6;
    private XRTableRow xrTableRow5;
    private XRTableCell xrTableCell13;
    private XRTableCell xrTableCell14;
    private XRTableCell xrTableCell15;
    private XRLabel xrLabel1;
    private XRLabel xrLabel2;
    private GroupHeaderBand GroupHeader1;
    private XRLabel xrLabel5;
    private XRTable xrTable4;
    private XRTableRow xrTableRow16;
    private XRTableCell xrTableCell45;
    private XRTableCell xrTableCell46;
    private XRTableCell xrTableCell47;
    private XRTableCell xrTableCell48;
    private DetailReportBand DetailReport;
    private DetailBand Detail1;
    private ReportFooterBand ReportFooter;
    private XRLabel xrLabel13;
    private XRLabel xrLabel15;
    private XRPageInfo xrPageInfo1;
    private XRLabel xrLabel14;
    private XRLabel xrLabel16;
    private DevExpress.XtraReports.Parameters.Parameter DocKey;
    private DevExpress.XtraReports.Parameters.Parameter DocNo;
    private XRPictureBox xrPictureBox1;
    private XRTable xrTable5;
    private XRTableRow xrTableRow15;
    private XRTableCell xrTableCell41;
    private XRTableCell xrTableCell42;
    private XRTableCell xrTableCell43;
    private XRTableRow xrTableRow17;
    private XRTableCell xrTableCell44;
    private XRTableCell xrTableCell49;
    private XRTableCell xrTableCell50;
    private XRTableRow xrTableRow18;
    private XRTableCell xrTableCell51;
    private XRTableCell xrTableCell52;
    private XRTableCell xrTableCell53;
    private XRTableRow xrTableRow19;
    private XRTableCell xrTableCell54;
    private XRTableCell xrTableCell55;
    private XRTableCell xrTableCell56;
    private XRTableRow xrTableRow20;
    private XRTableCell xrTableCell57;
    private XRTableCell xrTableCell58;
    private XRTableCell xrTableCell59;
    private XRLabel xrLabel3;
    private XRTable xrTable2;
    private XRTableRow xrTableRow7;
    private XRTableCell xrTableCell24;
    private XRTableCell xrTableCell25;
    private XRTableCell xrTableCell26;
    private XRTableCell xrTableCell27;
    private XRLabel xrLabel11;
    private XRTable xrTable3;
    private XRTableRow xrTableRow12;
    private XRTableCell xrTableCell20;
    private XRTableCell xrTableCell34;
    private XRTableRow xrTableRow13;
    private XRTableCell xrTableCell37;
    private XRPictureBox picBoxMySign1;
    private XRTableCell xrTableCell38;
    private XRLabel lblException1;
    private XRLabel lblException2;
    private XRPictureBox picBoxException2;
    private XRPictureBox picBoxException1;
    private XRTableCell xrTableCell39;
    private XRLabel lblException3;
    private XRLabel lblException4;
    private XRPictureBox picBoxException4;
    private XRPictureBox picBoxException3;
    private XRTableRow xrTableRow6;
    private XRTableCell xrTableCell40;
    private XRTableCell xrException16;
    private XRTableCell xrException17;
    private XRTableRow xrTableRow25;
    private XRTableCell xrTableCell70;
    private XRTableCell xrException711;
    private XRTableCell xrException722;
    private XRLabel xrLabel12;
    private XRLabel xrLabel4;
    private XRLabel lblException5;
    //private XRLabel lblException6;
    private XRLabel lblException7;
    //private XRLabel lblException8;
    private XRLabel lblException9;
    //private XRLabel lblException10;
    private XRLabel lblException11;
    //private XRLabel lblException12;
    private XRLabel xrLabel6;
    private XRLabel lblException13;
    //private XRLabel lblException14;
    private XRLabel lblException15;
    //private XRLabel lblException16;
    private XRTableRow xrTableRow36;
    private XRTableCell xrTableCell22;
    private XRTableCell xrTableCell35;
    private XRTableCell xrTableCell83;
    private XRTable xrTable6;
    private XRTableRow xrTableRow8;
    private XRTableCell xrTableCell18;
    private XRTableCell xrTableCell21;
    private XRTableRow xrTableRow26;
    private XRTableCell xrTableCell74;
    private XRTableCell xrTableCell75;
    private XRTableRow xrTableRow9;
    private XRTableCell xrTableCell23;
    private XRTableCell xrTableCell29;
    private XRTableRow xrTableRow22;
    private XRTableCell xrTableCell62;
    private XRTableCell xrTableCell63;
    private XRTableRow xrTableRow23;
    private XRTableCell xrTableCell65;
    private XRTableCell xrTableCell66;
    private XRTableRow xrTableRow27;
    private XRTableCell xrTableCell77;
    private XRTableCell xrTableCell78;
    private XRTableRow xrTableRow10;
    private XRTableCell xrTableCell31;
    private XRTableCell xrTableCell32;
    private XRTableRow xrTableRow21;
    private XRTableCell xrTableCell33;
    private XRTableCell xrTableCell60;
    private XRTableRow xrTableRow30;
    private XRTableCell xrTableCell84;
    private XRTableCell xrTableCell85;
    private XRTableRow xrTableRow31;
    private XRTableCell xrTableCell87;
    private XRTableCell xrTableCell88;
    private XRTableRow xrTableRow29;
    private XRTableCell xrTableCell81;
    private XRTableCell xrTableCell82;
    private XRTableRow xrTableRow24;
    private XRTableCell xrTableCell68;
    private XRTableCell xrTableCell69;
    private XRTableRow xrTableRow28;
    private XRTableCell xrTableCell79;
    private XRTableCell xrTableCell80;
    private XRTableRow xrTableRow11;
    private XRTableCell xrTableCell17;
    private XRTableCell xrTableCell19;
    private XRTableRow xrTableRow14;
    private XRTableCell xrTableCell28;
    private XRTableCell xrTableCell30;
    private XRTableRow xrTableRow32;
    private XRTableCell xrTableCell61;
    private XRTableCell xrTableCell64;
    private XRTableRow xrTableRow33;
    private XRTableCell xrTableCell71;
    private XRTableCell xrTableCell72;
    private XRTableRow xrTableRow34;
    private XRTableCell xrTableCell86;
    private XRTableCell xrTableCell89;
    private XRTableRow xrTableRow35;
    private XRTableCell xrTableCell91;
    private XRTableCell xrTableCell92;
    private XRTableCell xrTableCell36;
    private XRTableCell xrTableCell73;
    private XRPictureBox picBoxException5;
    private XRPictureBox picBoxException6;
    private XRTableCell xrException22;
    private XRTableCell xrException611;
    private XRTableCell xrTableCell641;
    private XRPictureBox picBoxException8;
    private XRPictureBox picBoxException7;
    private XRTableCell xrException644;
    private XRTableCell xrException300;
    private XRTableCell xrTableCell581;
    private XRPictureBox picBoxException10;
    private XRPictureBox picBoxException9;
    private XRTableCell xrException833;
    private XRTableCell xrException866;
    private XRTableCell xrTableCell76;
    private XRPictureBox picBoxException11;
    private XRPictureBox picBoxException12;
    private XRTableCell xrException35;
    private XRTableCell xrException677;
    private XRTableCell xrTableCell16;
    private XRPictureBox picBoxException13;
    private XRPictureBox picBoxException14;
    private XRTableCell xrException221;
    private XRTableCell xrException351;
    private XRTableCell xrTableCell67;
    private XRPictureBox picBoxException15;
    private XRTableCell xrException83;
    private XRTableCell xrException90;
    private XRPictureBox picBoxException16;
    private XRTableRow xrTableRow37;
    private XRTableCell xrTableCell90;
    private XRPictureBox picBoxException17;
    private XRPictureBox picBoxException18;
    private XRTableCell xrTableCell93;
    private XRLabel lblException17;
    private XRTableCell xrTableCell94;
    private XRTableRow xrTableRow38;
    private XRTableCell xrException95;
    private XRTableCell xrTableCell96;
    private XRTableCell xrTableCell97;
    private XRTableRow xrTableRow39;
    private XRTableCell xrException98;
    private XRTableCell xrTableCell99;
    private XRTableCell xrTableCell100;
    //private XRLabel lblException18;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public docInternalMemoException()
    {
        InitializeComponent();
        //
        // TODO: Add constructor logic here
        //
    }

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
        DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(docInternalMemoException));
        DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
        DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
        DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery3 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
        DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
        DevExpress.DataAccess.Sql.MasterDetailInfo masterDetailInfo1 = new DevExpress.DataAccess.Sql.MasterDetailInfo();
        DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
        DevExpress.DataAccess.Sql.MasterDetailInfo masterDetailInfo2 = new DevExpress.DataAccess.Sql.MasterDetailInfo();
        DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo2 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
        this.Detail = new DevExpress.XtraReports.UI.DetailBand();
        this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
        this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
        this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
        this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
        this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
        this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
        this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
        this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
        this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
        this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
        this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrTable5 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow15 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell41 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell42 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell43 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow17 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell44 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell49 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell50 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow18 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell51 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell52 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell53 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow19 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell54 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell55 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell56 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow36 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell35 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell83 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow20 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell57 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell58 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell59 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable4 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow16 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell45 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell46 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell47 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell48 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
        this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
        this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
        this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow7 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell26 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell27 = new DevExpress.XtraReports.UI.XRTableCell();
        this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
        this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrTable6 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow8 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell36 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow26 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell73 = new DevExpress.XtraReports.UI.XRTableCell();
        this.picBoxException5 = new DevExpress.XtraReports.UI.XRPictureBox();
        this.picBoxException6 = new DevExpress.XtraReports.UI.XRPictureBox();
        this.xrTableCell74 = new DevExpress.XtraReports.UI.XRTableCell();
        this.lblException5 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrTableCell75 = new DevExpress.XtraReports.UI.XRTableCell();
        //this.lblException6 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrTableRow9 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrException22 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell29 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow22 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrException611 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell62 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell63 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow23 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell641 = new DevExpress.XtraReports.UI.XRTableCell();
        this.picBoxException8 = new DevExpress.XtraReports.UI.XRPictureBox();
        this.picBoxException7 = new DevExpress.XtraReports.UI.XRPictureBox();
        this.xrTableCell65 = new DevExpress.XtraReports.UI.XRTableCell();
        this.lblException7 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrTableCell66 = new DevExpress.XtraReports.UI.XRTableCell();
        //this.lblException8 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrTableRow27 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrException644 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell77 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell78 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow10 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrException300 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell31 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell32 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow21 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell581 = new DevExpress.XtraReports.UI.XRTableCell();
        this.picBoxException10 = new DevExpress.XtraReports.UI.XRPictureBox();
        this.picBoxException9 = new DevExpress.XtraReports.UI.XRPictureBox();
        this.xrTableCell33 = new DevExpress.XtraReports.UI.XRTableCell();
        this.lblException9 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrTableCell60 = new DevExpress.XtraReports.UI.XRTableCell();
        //this.lblException10 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrTableRow30 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrException833 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell84 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell85 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow31 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrException866 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell87 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell88 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow29 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell76 = new DevExpress.XtraReports.UI.XRTableCell();
        this.picBoxException11 = new DevExpress.XtraReports.UI.XRPictureBox();
        this.picBoxException12 = new DevExpress.XtraReports.UI.XRPictureBox();
        this.xrTableCell81 = new DevExpress.XtraReports.UI.XRTableCell();
        this.lblException11 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrTableCell82 = new DevExpress.XtraReports.UI.XRTableCell();
        //this.lblException12 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrTableRow24 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrException35 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell68 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell69 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow28 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrException677 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell79 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell80 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow11 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
        this.picBoxException13 = new DevExpress.XtraReports.UI.XRPictureBox();
        this.picBoxException14 = new DevExpress.XtraReports.UI.XRPictureBox();
        this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
        this.lblException13 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrTableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
        //this.lblException14 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrTableRow14 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrException221 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell28 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell30 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow32 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrException351 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell61 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell64 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow33 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell67 = new DevExpress.XtraReports.UI.XRTableCell();
        this.picBoxException15 = new DevExpress.XtraReports.UI.XRPictureBox();
        this.picBoxException16 = new DevExpress.XtraReports.UI.XRPictureBox();
        this.xrTableCell71 = new DevExpress.XtraReports.UI.XRTableCell();
        this.lblException15 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrTableCell72 = new DevExpress.XtraReports.UI.XRTableCell();
        //this.lblException16 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrTableRow34 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrException83 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell86 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell89 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow35 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrException90 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell91 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell92 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow37 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell90 = new DevExpress.XtraReports.UI.XRTableCell();
        this.picBoxException17 = new DevExpress.XtraReports.UI.XRPictureBox();
        this.picBoxException18 = new DevExpress.XtraReports.UI.XRPictureBox();
        this.xrTableCell93 = new DevExpress.XtraReports.UI.XRTableCell();
        this.lblException17 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrTableCell94 = new DevExpress.XtraReports.UI.XRTableCell();
        //this.lblException18 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrTableRow38 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrException95 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell96 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell97 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow39 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrException98 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell99 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell100 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow12 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell34 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow13 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell37 = new DevExpress.XtraReports.UI.XRTableCell();
        this.picBoxMySign1 = new DevExpress.XtraReports.UI.XRPictureBox();
        this.xrTableCell38 = new DevExpress.XtraReports.UI.XRTableCell();
        this.lblException1 = new DevExpress.XtraReports.UI.XRLabel();
        this.lblException2 = new DevExpress.XtraReports.UI.XRLabel();
        this.picBoxException2 = new DevExpress.XtraReports.UI.XRPictureBox();
        this.picBoxException1 = new DevExpress.XtraReports.UI.XRPictureBox();
        this.xrTableCell39 = new DevExpress.XtraReports.UI.XRTableCell();
        this.lblException3 = new DevExpress.XtraReports.UI.XRLabel();
        this.lblException4 = new DevExpress.XtraReports.UI.XRLabel();
        this.picBoxException4 = new DevExpress.XtraReports.UI.XRPictureBox();
        this.picBoxException3 = new DevExpress.XtraReports.UI.XRPictureBox();
        this.xrTableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell40 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrException16 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrException17 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableRow25 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell70 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrException711 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrException722 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
        this.DocKey = new DevExpress.XtraReports.Parameters.Parameter();
        this.DocNo = new DevExpress.XtraReports.Parameters.Parameter();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
        // 
        // Detail
        // 
        this.Detail.HeightF = 100F;
        this.Detail.Name = "Detail";
        this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // TopMargin
        // 
        this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel13,
            this.xrLabel15});
        this.TopMargin.HeightF = 54F;
        this.TopMargin.Name = "TopMargin";
        this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // xrLabel13
        // 
        this.xrLabel13.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DocNo]")});
        this.xrLabel13.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
        this.xrLabel13.ForeColor = System.Drawing.Color.DarkGray;
        this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(36.74574F, 9.99999F);
        this.xrLabel13.Name = "xrLabel13";
        this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel13.SizeF = new System.Drawing.SizeF(265.6263F, 15.70835F);
        this.xrLabel13.StylePriority.UseFont = false;
        this.xrLabel13.StylePriority.UseForeColor = false;
        this.xrLabel13.StylePriority.UseTextAlignment = false;
        this.xrLabel13.Text = "xrLabel8";
        // 
        // xrLabel15
        // 
        this.xrLabel15.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DocType]")});
        this.xrLabel15.Font = new System.Drawing.Font("Tahoma", 5.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.xrLabel15.ForeColor = System.Drawing.Color.DarkGray;
        this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(36.74706F, 25.70836F);
        this.xrLabel15.Name = "xrLabel15";
        this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel15.SizeF = new System.Drawing.SizeF(265.625F, 15.70835F);
        this.xrLabel15.StylePriority.UseFont = false;
        this.xrLabel15.StylePriority.UseForeColor = false;
        this.xrLabel15.StylePriority.UseTextAlignment = false;
        this.xrLabel15.Text = "xrLabel8";
        // 
        // BottomMargin
        // 
        this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo1,
            this.xrLabel14,
            this.xrLabel16});
        this.BottomMargin.HeightF = 455F;
        this.BottomMargin.Name = "BottomMargin";
        this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // xrPageInfo1
        // 
        this.xrPageInfo1.Font = new System.Drawing.Font("Tahoma", 8F);
        this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(357.3273F, 9.999997F);
        this.xrPageInfo1.Name = "xrPageInfo1";
        this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrPageInfo1.SizeF = new System.Drawing.SizeF(26.04166F, 16.75002F);
        this.xrPageInfo1.StylePriority.UseFont = false;
        this.xrPageInfo1.StylePriority.UseTextAlignment = false;
        this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrLabel14
        // 
        this.xrLabel14.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DocNo]")});
        this.xrLabel14.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
        this.xrLabel14.ForeColor = System.Drawing.Color.DarkGray;
        this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(36.74574F, 9.999974F);
        this.xrLabel14.Name = "xrLabel14";
        this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel14.SizeF = new System.Drawing.SizeF(284.8941F, 15.70835F);
        this.xrLabel14.StylePriority.UseFont = false;
        this.xrLabel14.StylePriority.UseForeColor = false;
        this.xrLabel14.Text = "xrLabel8";
        // 
        // xrLabel16
        // 
        this.xrLabel16.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MemoPerihal]")});
        this.xrLabel16.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
        this.xrLabel16.ForeColor = System.Drawing.Color.DarkGray;
        this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(36.74704F, 25.70839F);
        this.xrLabel16.Name = "xrLabel16";
        this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel16.SizeF = new System.Drawing.SizeF(284.8929F, 13.62502F);
        this.xrLabel16.StylePriority.UseFont = false;
        this.xrLabel16.StylePriority.UseForeColor = false;
        this.xrLabel16.Text = "xrLabel14";
        // 
        // sqlDataSource1
        // 
        this.sqlDataSource1.ConnectionName = "SqlLocalConnectionString";
        this.sqlDataSource1.Name = "sqlDataSource1";
        customSqlQuery1.Name = "InternalMemo";
        queryParameter1.Name = "DocKey";
        queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
        queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.DocKey]", typeof(int));
        customSqlQuery1.Parameters.Add(queryParameter1);
        customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
        customSqlQuery2.Name = "InternalMemoApprovalList";
        queryParameter2.Name = "DocKey";
        queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
        queryParameter2.Value = new DevExpress.DataAccess.Expression("[Parameters.DocKey]", typeof(int));
        customSqlQuery2.Parameters.Add(queryParameter2);
        customSqlQuery2.Sql = resources.GetString("customSqlQuery2.Sql");
        customSqlQuery3.Name = "InternalMemoDetailException";
        queryParameter3.Name = "DocKey";
        queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
        queryParameter3.Value = new DevExpress.DataAccess.Expression("[Parameters.DocKey]", typeof(int));
        customSqlQuery3.Parameters.Add(queryParameter3);
        customSqlQuery3.Sql = resources.GetString("customSqlQuery3.Sql");
        this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1,
            customSqlQuery2,
            customSqlQuery3});
        masterDetailInfo1.DetailQueryName = "InternalMemoApprovalList";
        relationColumnInfo1.NestedKeyColumn = "DocKey";
        relationColumnInfo1.ParentKeyColumn = "DocKey";
        masterDetailInfo1.KeyColumns.Add(relationColumnInfo1);
        masterDetailInfo1.MasterQueryName = "InternalMemo";
        masterDetailInfo2.DetailQueryName = "InternalMemoDetailException";
        relationColumnInfo2.NestedKeyColumn = "DocKey";
        relationColumnInfo2.ParentKeyColumn = "DocKey";
        masterDetailInfo2.KeyColumns.Add(relationColumnInfo2);
        masterDetailInfo2.MasterQueryName = "InternalMemo";
        this.sqlDataSource1.Relations.AddRange(new DevExpress.DataAccess.Sql.MasterDetailInfo[] {
            masterDetailInfo1,
            masterDetailInfo2});
        this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
        // 
        // ReportHeader
        // 
        this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine1,
            this.xrTable1,
            this.xrLabel1,
            this.xrLabel2,
            this.xrPictureBox1});
        this.ReportHeader.HeightF = 216.7313F;
        this.ReportHeader.Name = "ReportHeader";
        // 
        // xrLine1
        // 
        this.xrLine1.LineWidth = 2;
        this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(32.57913F, 209.5887F);
        this.xrLine1.Name = "xrLine1";
        this.xrLine1.SizeF = new System.Drawing.SizeF(650.3834F, 7.142548F);
        // 
        // xrTable1
        // 
        this.xrTable1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(32.57913F, 108.7374F);
        this.xrTable1.Name = "xrTable1";
        this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1,
            this.xrTableRow3,
            this.xrTableRow4,
            this.xrTableRow2,
            this.xrTableRow5});
        this.xrTable1.SizeF = new System.Drawing.SizeF(650.3834F, 88.06821F);
        this.xrTable1.StylePriority.UseFont = false;
        this.xrTable1.StylePriority.UseTextAlignment = false;
        this.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrTableRow1
        // 
        this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3});
        this.xrTableRow1.Name = "xrTableRow1";
        this.xrTableRow1.Weight = 1D;
        // 
        // xrTableCell1
        // 
        this.xrTableCell1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.xrTableCell1.Name = "xrTableCell1";
        this.xrTableCell1.StylePriority.UseFont = false;
        this.xrTableCell1.Text = "Kepada";
        this.xrTableCell1.Weight = 1.1096236359843479D;
        // 
        // xrTableCell2
        // 
        this.xrTableCell2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.xrTableCell2.Name = "xrTableCell2";
        this.xrTableCell2.StylePriority.UseFont = false;
        this.xrTableCell2.Text = ":";
        this.xrTableCell2.Weight = 0.15524725618000446D;
        // 
        // xrTableCell3
        // 
        this.xrTableCell3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MemoTo]")});
        this.xrTableCell3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.xrTableCell3.Name = "xrTableCell3";
        this.xrTableCell3.StylePriority.UseFont = false;
        this.xrTableCell3.Text = "xrTableCell3";
        this.xrTableCell3.Weight = 6.2551291078356472D;
        // 
        // xrTableRow3
        // 
        this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell7,
            this.xrTableCell8,
            this.xrTableCell9});
        this.xrTableRow3.Name = "xrTableRow3";
        this.xrTableRow3.Weight = 1D;
        // 
        // xrTableCell7
        // 
        this.xrTableCell7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.xrTableCell7.Name = "xrTableCell7";
        this.xrTableCell7.StylePriority.UseFont = false;
        this.xrTableCell7.Text = "CC";
        this.xrTableCell7.Weight = 1.1096236359843479D;
        // 
        // xrTableCell8
        // 
        this.xrTableCell8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.xrTableCell8.Name = "xrTableCell8";
        this.xrTableCell8.StylePriority.UseFont = false;
        this.xrTableCell8.Text = ":";
        this.xrTableCell8.Weight = 0.15524725618000446D;
        // 
        // xrTableCell9
        // 
        this.xrTableCell9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MemoCC]")});
        this.xrTableCell9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.xrTableCell9.Name = "xrTableCell9";
        this.xrTableCell9.StylePriority.UseFont = false;
        this.xrTableCell9.Text = "xrTableCell9";
        this.xrTableCell9.Weight = 6.2551291078356472D;
        // 
        // xrTableRow4
        // 
        this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell10,
            this.xrTableCell11,
            this.xrTableCell12});
        this.xrTableRow4.Name = "xrTableRow4";
        this.xrTableRow4.Weight = 1D;
        // 
        // xrTableCell10
        // 
        this.xrTableCell10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.xrTableCell10.Name = "xrTableCell10";
        this.xrTableCell10.StylePriority.UseFont = false;
        this.xrTableCell10.Text = "Dari";
        this.xrTableCell10.Weight = 1.1096236359843479D;
        // 
        // xrTableCell11
        // 
        this.xrTableCell11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.xrTableCell11.Name = "xrTableCell11";
        this.xrTableCell11.StylePriority.UseFont = false;
        this.xrTableCell11.Text = ":";
        this.xrTableCell11.Weight = 0.15524725618000446D;
        // 
        // xrTableCell12
        // 
        this.xrTableCell12.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MemoFrom]")});
        this.xrTableCell12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.xrTableCell12.Name = "xrTableCell12";
        this.xrTableCell12.StylePriority.UseFont = false;
        this.xrTableCell12.Text = "xrTableCell12";
        this.xrTableCell12.Weight = 6.2551291078356472D;
        // 
        // xrTableRow2
        // 
        this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell4,
            this.xrTableCell5,
            this.xrTableCell6});
        this.xrTableRow2.Name = "xrTableRow2";
        this.xrTableRow2.Weight = 1D;
        // 
        // xrTableCell4
        // 
        this.xrTableCell4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.xrTableCell4.Name = "xrTableCell4";
        this.xrTableCell4.StylePriority.UseFont = false;
        this.xrTableCell4.Text = "Tanggal";
        this.xrTableCell4.Weight = 1.1096236359843479D;
        // 
        // xrTableCell5
        // 
        this.xrTableCell5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.xrTableCell5.Name = "xrTableCell5";
        this.xrTableCell5.StylePriority.UseFont = false;
        this.xrTableCell5.Text = ":";
        this.xrTableCell5.Weight = 0.15524725618000446D;
        // 
        // xrTableCell6
        // 
        this.xrTableCell6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DocDate]")});
        this.xrTableCell6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.xrTableCell6.Name = "xrTableCell6";
        this.xrTableCell6.StylePriority.UseFont = false;
        this.xrTableCell6.Text = "xrTableCell6";
        this.xrTableCell6.TextFormatString = "{0:dd/MM/yyyy}";
        this.xrTableCell6.Weight = 6.2551291078356472D;
        // 
        // xrTableRow5
        // 
        this.xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell13,
            this.xrTableCell14,
            this.xrTableCell15});
        this.xrTableRow5.Name = "xrTableRow5";
        this.xrTableRow5.Weight = 1D;
        // 
        // xrTableCell13
        // 
        this.xrTableCell13.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.xrTableCell13.Name = "xrTableCell13";
        this.xrTableCell13.StylePriority.UseFont = false;
        this.xrTableCell13.Text = "Perihal";
        this.xrTableCell13.Weight = 1.1096236359843479D;
        // 
        // xrTableCell14
        // 
        this.xrTableCell14.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.xrTableCell14.Name = "xrTableCell14";
        this.xrTableCell14.StylePriority.UseFont = false;
        this.xrTableCell14.Text = ":";
        this.xrTableCell14.Weight = 0.15524725618000446D;
        // 
        // xrTableCell15
        // 
        this.xrTableCell15.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MemoPerihal]")});
        this.xrTableCell15.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.xrTableCell15.Name = "xrTableCell15";
        this.xrTableCell15.StylePriority.UseFont = false;
        this.xrTableCell15.Text = "xrTableCell15";
        this.xrTableCell15.Weight = 6.2551291078356472D;
        // 
        // xrLabel1
        // 
        this.xrLabel1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(341.4972F, 9.999997F);
        this.xrLabel1.Name = "xrLabel1";
        this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel1.SizeF = new System.Drawing.SizeF(341.4654F, 26.12499F);
        this.xrLabel1.StylePriority.UseFont = false;
        this.xrLabel1.StylePriority.UseTextAlignment = false;
        this.xrLabel1.Text = "INTERNAL MEMORANDUM";
        this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
        // 
        // xrLabel2
        // 
        this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DocNo]")});
        this.xrLabel2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
        this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(341.4973F, 36.12501F);
        this.xrLabel2.Name = "xrLabel2";
        this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel2.SizeF = new System.Drawing.SizeF(341.464F, 20.91666F);
        this.xrLabel2.StylePriority.UseFont = false;
        this.xrLabel2.StylePriority.UseTextAlignment = false;
        this.xrLabel2.Text = "INTERNAL MEMORANDUM";
        this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrPictureBox1
        // 
        this.xrPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox1.Image")));
        this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(32.57913F, 0F);
        this.xrPictureBox1.Name = "xrPictureBox1";
        this.xrPictureBox1.SizeF = new System.Drawing.SizeF(188.5749F, 54.1174F);
        this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
        // 
        // GroupHeader1
        // 
        this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel3,
            this.xrTable5,
            this.xrTable4,
            this.xrLabel5});
        this.GroupHeader1.HeightF = 316.5625F;
        this.GroupHeader1.Name = "GroupHeader1";
        // 
        // xrLabel3
        // 
        this.xrLabel3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(32.57914F, 230.5417F);
        this.xrLabel3.Name = "xrLabel3";
        this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel3.SizeF = new System.Drawing.SizeF(651.4251F, 26.12498F);
        this.xrLabel3.StylePriority.UseFont = false;
        this.xrLabel3.StylePriority.UseTextAlignment = false;
        this.xrLabel3.Text = "Rincian Exception, antara lain:";
        this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // xrTable5
        // 
        this.xrTable5.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.xrTable5.LocationFloat = new DevExpress.Utils.PointFloat(32.57913F, 68.75F);
        this.xrTable5.Name = "xrTable5";
        this.xrTable5.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrTable5.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow15,
            this.xrTableRow17,
            this.xrTableRow18,
            this.xrTableRow19,
            this.xrTableRow36,
            this.xrTableRow20});
        this.xrTable5.SizeF = new System.Drawing.SizeF(651.4251F, 150F);
        this.xrTable5.StylePriority.UseBorders = false;
        this.xrTable5.StylePriority.UseFont = false;
        this.xrTable5.StylePriority.UsePadding = false;
        this.xrTable5.StylePriority.UseTextAlignment = false;
        this.xrTable5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
        // 
        // xrTableRow15
        // 
        this.xrTableRow15.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell41,
            this.xrTableCell42,
            this.xrTableCell43});
        this.xrTableRow15.Name = "xrTableRow15";
        this.xrTableRow15.Weight = 1D;
        // 
        // xrTableCell41
        // 
        this.xrTableCell41.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell41.Name = "xrTableCell41";
        this.xrTableCell41.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrTableCell41.StylePriority.UseBorders = false;
        this.xrTableCell41.StylePriority.UsePadding = false;
        this.xrTableCell41.StylePriority.UseTextAlignment = false;
        this.xrTableCell41.Text = "Nama";
        this.xrTableCell41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
        this.xrTableCell41.Weight = 1D;
        // 
        // xrTableCell42
        // 
        this.xrTableCell42.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell42.Name = "xrTableCell42";
        this.xrTableCell42.StylePriority.UseBorders = false;
        this.xrTableCell42.Text = ":";
        this.xrTableCell42.Weight = 0.11731998813074063D;
        // 
        // xrTableCell43
        // 
        this.xrTableCell43.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell43.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DeviasiNamaDebitur]")});
        this.xrTableCell43.Name = "xrTableCell43";
        this.xrTableCell43.StylePriority.UseBorders = false;
        this.xrTableCell43.Weight = 1.8826800118692595D;
        // 
        // xrTableRow17
        // 
        this.xrTableRow17.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell44,
            this.xrTableCell49,
            this.xrTableCell50});
        this.xrTableRow17.Name = "xrTableRow17";
        this.xrTableRow17.Weight = 1D;
        // 
        // xrTableCell44
        // 
        this.xrTableCell44.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell44.Name = "xrTableCell44";
        this.xrTableCell44.StylePriority.UseBorders = false;
        this.xrTableCell44.Text = "No. CR";
        this.xrTableCell44.Weight = 1D;
        // 
        // xrTableCell49
        // 
        this.xrTableCell49.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell49.Name = "xrTableCell49";
        this.xrTableCell49.StylePriority.UseBorders = false;
        this.xrTableCell49.Text = ":";
        this.xrTableCell49.Weight = 0.11731998813074063D;
        // 
        // xrTableCell50
        // 
        this.xrTableCell50.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell50.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DeviasiNoPFK]")});
        this.xrTableCell50.Name = "xrTableCell50";
        this.xrTableCell50.StylePriority.UseBorders = false;
        this.xrTableCell50.Weight = 1.8826800118692595D;
        // 
        // xrTableRow18
        // 
        this.xrTableRow18.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell51,
            this.xrTableCell52,
            this.xrTableCell53});
        this.xrTableRow18.Name = "xrTableRow18";
        this.xrTableRow18.Weight = 1D;
        // 
        // xrTableCell51
        // 
        this.xrTableCell51.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell51.Name = "xrTableCell51";
        this.xrTableCell51.StylePriority.UseBorders = false;
        this.xrTableCell51.Text = "Unit";
        this.xrTableCell51.Weight = 1D;
        // 
        // xrTableCell52
        // 
        this.xrTableCell52.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell52.Name = "xrTableCell52";
        this.xrTableCell52.StylePriority.UseBorders = false;
        this.xrTableCell52.Text = ":";
        this.xrTableCell52.Weight = 0.11731998813074063D;
        // 
        // xrTableCell53
        // 
        this.xrTableCell53.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell53.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DeviasiUnit]")});
        this.xrTableCell53.Name = "xrTableCell53";
        this.xrTableCell53.StylePriority.UseBorders = false;
        this.xrTableCell53.Weight = 1.8826800118692595D;
        // 
        // xrTableRow19
        // 
        this.xrTableRow19.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell54,
            this.xrTableCell55,
            this.xrTableCell56});
        this.xrTableRow19.Name = "xrTableRow19";
        this.xrTableRow19.Weight = 1D;
        // 
        // xrTableCell54
        // 
        this.xrTableCell54.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell54.Name = "xrTableCell54";
        this.xrTableCell54.StylePriority.UseBorders = false;
        this.xrTableCell54.Text = "Jenis Pembiayaan";
        this.xrTableCell54.Weight = 1D;
        // 
        // xrTableCell55
        // 
        this.xrTableCell55.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell55.Name = "xrTableCell55";
        this.xrTableCell55.StylePriority.UseBorders = false;
        this.xrTableCell55.Text = ":";
        this.xrTableCell55.Weight = 0.11731998813074063D;
        // 
        // xrTableCell56
        // 
        this.xrTableCell56.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell56.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DeviasiJenisPembiayaan]")});
        this.xrTableCell56.Name = "xrTableCell56";
        this.xrTableCell56.StylePriority.UseBorders = false;
        this.xrTableCell56.Weight = 1.8826800118692595D;
        // 
        // xrTableRow36
        // 
        this.xrTableRow36.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell22,
            this.xrTableCell35,
            this.xrTableCell83});
        this.xrTableRow36.Name = "xrTableRow36";
        this.xrTableRow36.Weight = 1D;
        // 
        // xrTableCell22
        // 
        this.xrTableCell22.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell22.Name = "xrTableCell22";
        this.xrTableCell22.StylePriority.UseBorders = false;
        this.xrTableCell22.Text = "Kategori";
        this.xrTableCell22.Weight = 1D;
        // 
        // xrTableCell35
        // 
        this.xrTableCell35.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell35.Name = "xrTableCell35";
        this.xrTableCell35.StylePriority.UseBorders = false;
        this.xrTableCell35.Text = ":";
        this.xrTableCell35.Weight = 0.11731998813074063D;
        // 
        // xrTableCell83
        // 
        this.xrTableCell83.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell83.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[KategoriDeviasi]")});
        this.xrTableCell83.Name = "xrTableCell83";
        this.xrTableCell83.StylePriority.UseBorders = false;
        this.xrTableCell83.Weight = 1.8826800118692595D;
        // 
        // xrTableRow20
        // 
        this.xrTableRow20.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell57,
            this.xrTableCell58,
            this.xrTableCell59});
        this.xrTableRow20.Name = "xrTableRow20";
        this.xrTableRow20.Weight = 1D;
        // 
        // xrTableCell57
        // 
        this.xrTableCell57.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell57.Name = "xrTableCell57";
        this.xrTableCell57.StylePriority.UseBorders = false;
        this.xrTableCell57.Text = "Nama AO Pengelola";
        this.xrTableCell57.Weight = 1D;
        // 
        // xrTableCell58
        // 
        this.xrTableCell58.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell58.Name = "xrTableCell58";
        this.xrTableCell58.StylePriority.UseBorders = false;
        this.xrTableCell58.Text = ":";
        this.xrTableCell58.Weight = 0.11731998813074063D;
        // 
        // xrTableCell59
        // 
        this.xrTableCell59.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell59.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DeviasiNamaAO]")});
        this.xrTableCell59.Name = "xrTableCell59";
        this.xrTableCell59.StylePriority.UseBorders = false;
        this.xrTableCell59.Weight = 1.8826800118692595D;
        // 
        // xrTable4
        // 
        this.xrTable4.Font = new System.Drawing.Font("Tahoma", 8F);
        this.xrTable4.LocationFloat = new DevExpress.Utils.PointFloat(31.53868F, 274.375F);
        this.xrTable4.Name = "xrTable4";
        this.xrTable4.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow16});
        this.xrTable4.SizeF = new System.Drawing.SizeF(650.3821F, 42.1875F);
        this.xrTable4.StylePriority.UseFont = false;
        // 
        // xrTableRow16
        // 
        this.xrTableRow16.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell45,
            this.xrTableCell46,
            this.xrTableCell47,
            this.xrTableCell48});
        this.xrTableRow16.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
        this.xrTableRow16.Name = "xrTableRow16";
        this.xrTableRow16.StylePriority.UseFont = false;
        this.xrTableRow16.StylePriority.UseTextAlignment = false;
        this.xrTableRow16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableRow16.Weight = 1D;
        // 
        // xrTableCell45
        // 
        this.xrTableCell45.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell45.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.xrTableCell45.Multiline = true;
        this.xrTableCell45.Name = "xrTableCell45";
        this.xrTableCell45.StylePriority.UseBorders = false;
        this.xrTableCell45.StylePriority.UseFont = false;
        this.xrTableCell45.Text = "No";
        this.xrTableCell45.Weight = 0.24745670888297866D;
        // 
        // xrTableCell46
        // 
        this.xrTableCell46.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell46.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.xrTableCell46.Name = "xrTableCell46";
        this.xrTableCell46.StylePriority.UseBorders = false;
        this.xrTableCell46.StylePriority.UseFont = false;
        this.xrTableCell46.Text = "Perihal";
        this.xrTableCell46.Weight = 1.0907174102871489D;
        // 
        // xrTableCell47
        // 
        this.xrTableCell47.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell47.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.xrTableCell47.Name = "xrTableCell47";
        this.xrTableCell47.StylePriority.UseBorders = false;
        this.xrTableCell47.StylePriority.UseFont = false;
        this.xrTableCell47.Text = "Alasan";
        this.xrTableCell47.Weight = 1.2460698385014708D;
        // 
        // xrTableCell48
        // 
        this.xrTableCell48.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell48.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.xrTableCell48.Name = "xrTableCell48";
        this.xrTableCell48.StylePriority.UseBorders = false;
        this.xrTableCell48.StylePriority.UseFont = false;
        this.xrTableCell48.Text = "Mitigasi Resiko";
        this.xrTableCell48.Weight = 1.3545674692255063D;
        // 
        // xrLabel5
        // 
        this.xrLabel5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(32.57914F, 26.12499F);
        this.xrLabel5.Name = "xrLabel5";
        this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel5.SizeF = new System.Drawing.SizeF(651.4251F, 26.12498F);
        this.xrLabel5.StylePriority.UseFont = false;
        this.xrLabel5.StylePriority.UseTextAlignment = false;
        this.xrLabel5.Text = "Bersama ini kami mangajukan Permohonan Exception a.n [DeviasiNamaDebitur],  denga" +
"n rincian sebagai berikut:";
        this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // DetailReport
        // 
        this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail1});
        this.DetailReport.DataMember = "InternalMemoDetailException";
        this.DetailReport.DataSource = this.sqlDataSource1;
        this.DetailReport.Level = 0;
        this.DetailReport.Name = "DetailReport";
        // 
        // Detail1
        // 
        this.Detail1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
        this.Detail1.HeightF = 17.88194F;
        this.Detail1.Name = "Detail1";
        // 
        // xrTable2
        // 
        this.xrTable2.Font = new System.Drawing.Font("Tahoma", 8F);
        this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(31.53868F, 0F);
        this.xrTable2.Name = "xrTable2";
        this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow7});
        this.xrTable2.SizeF = new System.Drawing.SizeF(650.3821F, 17.88194F);
        this.xrTable2.StylePriority.UseFont = false;
        // 
        // xrTableRow7
        // 
        this.xrTableRow7.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell24,
            this.xrTableCell25,
            this.xrTableCell26,
            this.xrTableCell27});
        this.xrTableRow7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
        this.xrTableRow7.Name = "xrTableRow7";
        this.xrTableRow7.StylePriority.UseFont = false;
        this.xrTableRow7.StylePriority.UseTextAlignment = false;
        this.xrTableRow7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableRow7.Weight = 0.42386827256944448D;
        // 
        // xrTableCell24
        // 
        this.xrTableCell24.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell24.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Seq] + 1")});
        this.xrTableCell24.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.xrTableCell24.Multiline = true;
        this.xrTableCell24.Name = "xrTableCell24";
        this.xrTableCell24.StylePriority.UseBorders = false;
        this.xrTableCell24.StylePriority.UseFont = false;
        this.xrTableCell24.Text = "Nama Debitur";
        this.xrTableCell24.Weight = 0.24745711332802373D;
        // 
        // xrTableCell25
        // 
        this.xrTableCell25.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell25.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Perihal]")});
        this.xrTableCell25.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.xrTableCell25.Multiline = true;
        this.xrTableCell25.Name = "xrTableCell25";
        this.xrTableCell25.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrTableCell25.StylePriority.UseBorders = false;
        this.xrTableCell25.StylePriority.UseFont = false;
        this.xrTableCell25.StylePriority.UsePadding = false;
        this.xrTableCell25.StylePriority.UseTextAlignment = false;
        this.xrTableCell25.Text = "Perihal";
        this.xrTableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
        this.xrTableCell25.Weight = 1.090719338709746D;
        // 
        // xrTableCell26
        // 
        this.xrTableCell26.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell26.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Alasan]")});
        this.xrTableCell26.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.xrTableCell26.Multiline = true;
        this.xrTableCell26.Name = "xrTableCell26";
        this.xrTableCell26.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrTableCell26.StylePriority.UseBorders = false;
        this.xrTableCell26.StylePriority.UseFont = false;
        this.xrTableCell26.StylePriority.UsePadding = false;
        this.xrTableCell26.StylePriority.UseTextAlignment = false;
        this.xrTableCell26.Text = "Alasan";
        this.xrTableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
        this.xrTableCell26.Weight = 1.2460717566912252D;
        // 
        // xrTableCell27
        // 
        this.xrTableCell27.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell27.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MitigasiResiko]")});
        this.xrTableCell27.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.xrTableCell27.Multiline = true;
        this.xrTableCell27.Name = "xrTableCell27";
        this.xrTableCell27.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrTableCell27.StylePriority.UseBorders = false;
        this.xrTableCell27.StylePriority.UseFont = false;
        this.xrTableCell27.StylePriority.UsePadding = false;
        this.xrTableCell27.StylePriority.UseTextAlignment = false;
        this.xrTableCell27.Text = "Mitigasi Resiko";
        this.xrTableCell27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
        this.xrTableCell27.Weight = 1.3545700399581389D;
        // 
        // ReportFooter
        // 
        this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel6,
            this.xrTable6,
            this.xrLabel11,
            this.xrTable3,
            this.xrLabel12,
            this.xrLabel4});
        this.ReportFooter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.ReportFooter.HeightF = 1747.71F;
        this.ReportFooter.Name = "ReportFooter";
        this.ReportFooter.StylePriority.UseFont = false;
        // 
        // xrLabel6
        // 
        this.xrLabel6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(46.75F, 9.375F);
        this.xrLabel6.Name = "xrLabel6";
        this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel6.SizeF = new System.Drawing.SizeF(651.4251F, 26.12498F);
        this.xrLabel6.StylePriority.UseFont = false;
        this.xrLabel6.StylePriority.UseTextAlignment = false;
        this.xrLabel6.Text = "Demikian kami sampaikan, atas perhatiannya kami ucapkan terimakasih.";
        this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // xrTable6
        // 
        this.xrTable6.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom;
        this.xrTable6.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.xrTable6.KeepTogether = true;
        this.xrTable6.LocationFloat = new DevExpress.Utils.PointFloat(36.74704F, 421.1713F);
        this.xrTable6.Name = "xrTable6";
        this.xrTable6.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow8,
            this.xrTableRow26,
            this.xrTableRow9,
            this.xrTableRow22,
            this.xrTableRow23,
            this.xrTableRow27,
            this.xrTableRow10,
            this.xrTableRow21,
            this.xrTableRow30,
            this.xrTableRow31,
            this.xrTableRow29,
            this.xrTableRow24,
            this.xrTableRow28,
            this.xrTableRow11,
            this.xrTableRow14,
            this.xrTableRow32,
            this.xrTableRow33,
            this.xrTableRow34,
            this.xrTableRow35,
            this.xrTableRow37,
            this.xrTableRow38,
            this.xrTableRow39});
        this.xrTable6.SizeF = new System.Drawing.SizeF(647.2585F, 1289.039F);
        this.xrTable6.StylePriority.UseBorders = false;
        this.xrTable6.StylePriority.UseFont = false;
        this.xrTable6.StylePriority.UseTextAlignment = false;
        this.xrTable6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow8
        // 
        this.xrTableRow8.BackColor = System.Drawing.Color.Gainsboro;
        this.xrTableRow8.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell36,
            this.xrTableCell18,
            this.xrTableCell21});
        this.xrTableRow8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
        this.xrTableRow8.Name = "xrTableRow8";
        this.xrTableRow8.StylePriority.UseBackColor = false;
        this.xrTableRow8.StylePriority.UseFont = false;
        this.xrTableRow8.Weight = 0.33496361958647147D;
        // 
        // xrTableCell36
        // 
        this.xrTableCell36.CanGrow = false;
        this.xrTableCell36.Name = "xrTableCell36";
        this.xrTableCell36.Text = "Nama & Tanda Tangan";
        this.xrTableCell36.Weight = 1D;
        // 
        // xrTableCell18
        // 
        this.xrTableCell18.CanGrow = false;
        this.xrTableCell18.Name = "xrTableCell18";
        this.xrTableCell18.Text = "Tanggal";
        this.xrTableCell18.Weight = 0.765895123880648D;
        // 
        // xrTableCell21
        // 
        this.xrTableCell21.CanGrow = false;
        this.xrTableCell21.Name = "xrTableCell21";
        this.xrTableCell21.Text = "Disposisi";
        this.xrTableCell21.Weight = 1.2341048761193521D;
        // 
        // xrTableRow26
        // 
        this.xrTableRow26.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell73,
            this.xrTableCell74,
            this.xrTableCell75});
        this.xrTableRow26.Name = "xrTableRow26";
        this.xrTableRow26.Weight = 1.3261611804842071D;
        // 
        // xrTableCell73
        // 
        this.xrTableCell73.CanGrow = false;
        this.xrTableCell73.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.picBoxException5,
            this.picBoxException6});
        this.xrTableCell73.Name = "xrTableCell73";
        this.xrTableCell73.Text = " ";
        this.xrTableCell73.Weight = 1D;
        // 
        // picBoxException5
        // 
        this.picBoxException5.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.picBoxException5.Image = ((System.Drawing.Image)(resources.GetObject("picBoxException5.Image")));
        this.picBoxException5.LocationFloat = new DevExpress.Utils.PointFloat(60.70722F, 26.22662F);
        this.picBoxException5.Name = "picBoxException5";
        this.picBoxException5.SizeF = new System.Drawing.SizeF(95.49458F, 90.3646F);
        this.picBoxException5.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
        this.picBoxException5.StylePriority.UseBorders = false;
        this.picBoxException5.Visible = false;
        // 
        // picBoxException6
        // 
        this.picBoxException6.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.picBoxException6.Image = ((System.Drawing.Image)(resources.GetObject("picBoxException6.Image")));
        this.picBoxException6.LocationFloat = new DevExpress.Utils.PointFloat(60.70722F, 26.22655F);
        this.picBoxException6.Name = "picBoxException6";
        this.picBoxException6.SizeF = new System.Drawing.SizeF(95.49458F, 90.3646F);
        this.picBoxException6.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
        this.picBoxException6.StylePriority.UseBorders = false;
        this.picBoxException6.Visible = false;
        // 
        // xrTableCell74
        // 
        this.xrTableCell74.CanGrow = false;
        this.xrTableCell74.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblException5});
        this.xrTableCell74.Name = "xrTableCell74";
        this.xrTableCell74.Text = " ";
        this.xrTableCell74.Weight = 0.765895123880648D;
        // 
        // lblException5
        // 
        this.lblException5.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.lblException5.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
        this.lblException5.ForeColor = System.Drawing.Color.Black;
        this.lblException5.LocationFloat = new DevExpress.Utils.PointFloat(10.00005F, 52.96616F);
        this.lblException5.Name = "lblException5";
        this.lblException5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.lblException5.SizeF = new System.Drawing.SizeF(145.244F, 13.62497F);
        this.lblException5.StylePriority.UseBorders = false;
        this.lblException5.StylePriority.UseFont = false;
        this.lblException5.StylePriority.UseForeColor = false;
        this.lblException5.StylePriority.UseTextAlignment = false;
        this.lblException5.Text = "Approve datetime";
        this.lblException5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.lblException5.Visible = false;
        // 
        // xrTableCell75
        // 
        this.xrTableCell75.CanGrow = true;
        this.xrTableCell75.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            /*this.lblException6*/});
        this.xrTableCell75.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
        this.xrTableCell75.ForeColor = System.Drawing.Color.Black;
        this.xrTableCell75.Name = "xrTableCell75";
        this.xrTableCell75.Text = "Note";
        this.xrTableCell75.Weight = 1.2341048761193521D;
        this.xrTableCell75.Multiline = true;
        this.xrTableCell75.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrTableCell75.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // lblException6
        // 
        //this.lblException6.Borders = DevExpress.XtraPrinting.BorderSide.None;
        //this.lblException6.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
        //this.lblException6.ForeColor = System.Drawing.Color.Black;
        //this.lblException6.LocationFloat = new DevExpress.Utils.PointFloat(7.256063F, 10.00036F);
        //this.lblException6.Multiline = true;
        //this.lblException6.Name = "lblException6";
        //this.lblException6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        //this.lblException6.SizeF = new System.Drawing.SizeF(249.0055F, 106.5909F);
        //this.lblException6.StylePriority.UseBorders = false;
        //this.lblException6.StylePriority.UseFont = false;
        //this.lblException6.StylePriority.UseForeColor = false;
        //this.lblException6.StylePriority.UseTextAlignment = false;
        //this.lblException6.Text = "Note";
        //this.lblException6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        //this.lblException6.Visible = false;
        // 
        // xrTableRow9
        // 
        this.xrTableRow9.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrException22,
            this.xrTableCell23,
            this.xrTableCell29});
        this.xrTableRow9.Font = new System.Drawing.Font("Tahoma", 8F);
        this.xrTableRow9.Name = "xrTableRow9";
        this.xrTableRow9.StylePriority.UseFont = false;
        this.xrTableRow9.StylePriority.UseTextAlignment = false;
        this.xrTableRow9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
        this.xrTableRow9.Weight = 0.21418133076930235D;
        // 
        // xrException22
        // 
        this.xrException22.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrException22.CanGrow = false;
        this.xrException22.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Underline);
        this.xrException22.Name = "xrException22";
        this.xrException22.StylePriority.UseBorders = false;
        this.xrException22.StylePriority.UseFont = false;
        this.xrException22.StylePriority.UseTextAlignment = false;
        this.xrException22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
        this.xrException22.Weight = 1D;
        // 
        // xrTableCell23
        // 
        this.xrTableCell23.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell23.CanGrow = false;
        this.xrTableCell23.Name = "xrTableCell23";
        this.xrTableCell23.StylePriority.UseBorders = false;
        this.xrTableCell23.Weight = 0.765895123880648D;
        // 
        // xrTableCell29
        // 
        this.xrTableCell29.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell29.CanGrow = false;
        this.xrTableCell29.Name = "xrTableCell29";
        this.xrTableCell29.StylePriority.UseBorders = false;
        this.xrTableCell29.Weight = 1.2341048761193521D;
        // 
        // xrTableRow22
        // 
        this.xrTableRow22.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrException611,
            this.xrTableCell62,
            this.xrTableCell63});
        this.xrTableRow22.Font = new System.Drawing.Font("Tahoma", 8F);
        this.xrTableRow22.Name = "xrTableRow22";
        this.xrTableRow22.StylePriority.UseFont = false;
        this.xrTableRow22.StylePriority.UseTextAlignment = false;
        this.xrTableRow22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        this.xrTableRow22.Weight = 0.21760327302164578D;
        // 
        // xrException611
        // 
        this.xrException611.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrException611.CanGrow = false;
        this.xrException611.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
        this.xrException611.Name = "xrException611";
        this.xrException611.StylePriority.UseBorders = false;
        this.xrException611.StylePriority.UseFont = false;
        this.xrException611.StylePriority.UseTextAlignment = false;
        this.xrException611.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        this.xrException611.Weight = 1D;
        // 
        // xrTableCell62
        // 
        this.xrTableCell62.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell62.CanGrow = false;
        this.xrTableCell62.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
        this.xrTableCell62.Name = "xrTableCell62";
        this.xrTableCell62.StylePriority.UseBorders = false;
        this.xrTableCell62.StylePriority.UseFont = false;
        this.xrTableCell62.StylePriority.UseTextAlignment = false;
        this.xrTableCell62.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        this.xrTableCell62.Weight = 0.765895123880648D;
        // 
        // xrTableCell63
        // 
        this.xrTableCell63.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell63.CanGrow = false;
        this.xrTableCell63.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
        this.xrTableCell63.Name = "xrTableCell63";
        this.xrTableCell63.StylePriority.UseBorders = false;
        this.xrTableCell63.StylePriority.UseFont = false;
        this.xrTableCell63.StylePriority.UseTextAlignment = false;
        this.xrTableCell63.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        this.xrTableCell63.Weight = 1.2341048761193521D;
        // 
        // xrTableRow23
        // 
        this.xrTableRow23.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableRow23.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell641,
            this.xrTableCell65,
            this.xrTableCell66});
        this.xrTableRow23.Font = new System.Drawing.Font("Tahoma", 8F);
        this.xrTableRow23.Name = "xrTableRow23";
        this.xrTableRow23.StylePriority.UseBorders = false;
        this.xrTableRow23.StylePriority.UseFont = false;
        this.xrTableRow23.StylePriority.UseTextAlignment = false;
        this.xrTableRow23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
        this.xrTableRow23.Weight = 1.3031778163753085D;
        // 
        // xrTableCell641
        // 
        this.xrTableCell641.CanGrow = false;
        this.xrTableCell641.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.picBoxException8,
            this.picBoxException7});
        this.xrTableCell641.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Underline);
        this.xrTableCell641.Name = "xrTableCell641";
        this.xrTableCell641.StylePriority.UseFont = false;
        this.xrTableCell641.StylePriority.UseTextAlignment = false;
        this.xrTableCell641.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
        this.xrTableCell641.Weight = 1D;
        // 
        // picBoxException8
        // 
        this.picBoxException8.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.picBoxException8.Image = ((System.Drawing.Image)(resources.GetObject("picBoxException8.Image")));
        this.picBoxException8.LocationFloat = new DevExpress.Utils.PointFloat(60.70722F, 24.58324F);
        this.picBoxException8.Name = "picBoxException8";
        this.picBoxException8.SizeF = new System.Drawing.SizeF(95.49458F, 90.3646F);
        this.picBoxException8.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
        this.picBoxException8.StylePriority.UseBorders = false;
        this.picBoxException8.Visible = false;
        // 
        // picBoxException7
        // 
        this.picBoxException7.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.picBoxException7.Image = ((System.Drawing.Image)(resources.GetObject("picBoxException7.Image")));
        this.picBoxException7.LocationFloat = new DevExpress.Utils.PointFloat(60.70722F, 24.58331F);
        this.picBoxException7.Name = "picBoxException7";
        this.picBoxException7.SizeF = new System.Drawing.SizeF(95.49458F, 90.3646F);
        this.picBoxException7.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
        this.picBoxException7.StylePriority.UseBorders = false;
        this.picBoxException7.Visible = false;
        // 
        // xrTableCell65
        // 
        this.xrTableCell65.CanGrow = false;
        this.xrTableCell65.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblException7});
        this.xrTableCell65.Name = "xrTableCell65";
        this.xrTableCell65.Weight = 0.765895123880648D;
        // 
        // lblException7
        // 
        this.lblException7.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.lblException7.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
        this.lblException7.ForeColor = System.Drawing.Color.Black;
        this.lblException7.LocationFloat = new DevExpress.Utils.PointFloat(10.00005F, 58.53117F);
        this.lblException7.Name = "lblException7";
        this.lblException7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.lblException7.SizeF = new System.Drawing.SizeF(145.244F, 13.62496F);
        this.lblException7.StylePriority.UseBorders = false;
        this.lblException7.StylePriority.UseFont = false;
        this.lblException7.StylePriority.UseForeColor = false;
        this.lblException7.StylePriority.UseTextAlignment = false;
        this.lblException7.Text = "Approve datetime";
        this.lblException7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.lblException7.Visible = false;
        // 
        // xrTableCell66
        // 
        this.xrTableCell66.CanGrow = true;
        this.xrTableCell66.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            /*this.lblException8*/});
        this.xrTableCell66.Name = "xrTableCell66";
        this.xrTableCell66.Weight = 1.2341048761193521D;
        this.xrTableCell66.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
        this.xrTableCell66.ForeColor = System.Drawing.Color.Black;
        this.xrTableCell66.Multiline = true;
        this.xrTableCell66.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrTableCell66.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrTableCell66.Text = "Note";
        // 
        // lblException8
        // 
        //this.lblException8.Borders = DevExpress.XtraPrinting.BorderSide.None;
        //this.lblException8.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
        //this.lblException8.ForeColor = System.Drawing.Color.Black;
        //this.lblException8.LocationFloat = new DevExpress.Utils.PointFloat(7.256063F, 10.00036F);
        //this.lblException8.Multiline = true;
        //this.lblException8.Name = "lblException8";
        //this.lblException8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        //this.lblException8.SizeF = new System.Drawing.SizeF(249.0055F, 103.1494F);
        //this.lblException8.StylePriority.UseBorders = false;
        //this.lblException8.StylePriority.UseFont = false;
        //this.lblException8.StylePriority.UseForeColor = false;
        //this.lblException8.StylePriority.UseTextAlignment = false;
        //this.lblException8.Text = "Note";
        //this.lblException8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        //this.lblException8.Visible = false;
        // 
        // xrTableRow27
        // 
        this.xrTableRow27.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrException644,
            this.xrTableCell77,
            this.xrTableCell78});
        this.xrTableRow27.Name = "xrTableRow27";
        this.xrTableRow27.Weight = 0.24694500151341417D;
        // 
        // xrException644
        // 
        this.xrException644.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrException644.CanGrow = false;
        this.xrException644.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.xrException644.Name = "xrException644";
        this.xrException644.StylePriority.UseBorders = false;
        this.xrException644.StylePriority.UseFont = false;
        this.xrException644.StylePriority.UseTextAlignment = false;
        this.xrException644.Text = " ";
        this.xrException644.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
        this.xrException644.Weight = 1D;
        // 
        // xrTableCell77
        // 
        this.xrTableCell77.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell77.CanGrow = false;
        this.xrTableCell77.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell77.Name = "xrTableCell77";
        this.xrTableCell77.StylePriority.UseBorders = false;
        this.xrTableCell77.StylePriority.UseFont = false;
        this.xrTableCell77.StylePriority.UseTextAlignment = false;
        this.xrTableCell77.Text = " ";
        this.xrTableCell77.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        this.xrTableCell77.Weight = 0.765895123880648D;
        // 
        // xrTableCell78
        // 
        this.xrTableCell78.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell78.CanGrow = false;
        this.xrTableCell78.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell78.Name = "xrTableCell78";
        this.xrTableCell78.StylePriority.UseBorders = false;
        this.xrTableCell78.StylePriority.UseFont = false;
        this.xrTableCell78.StylePriority.UseTextAlignment = false;
        this.xrTableCell78.Text = " ";
        this.xrTableCell78.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        this.xrTableCell78.Weight = 1.2341048761193521D;
        // 
        // xrTableRow10
        // 
        this.xrTableRow10.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableRow10.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrException300,
            this.xrTableCell31,
            this.xrTableCell32});
        this.xrTableRow10.Font = new System.Drawing.Font("Tahoma", 8F);
        this.xrTableRow10.Name = "xrTableRow10";
        this.xrTableRow10.StylePriority.UseBorders = false;
        this.xrTableRow10.StylePriority.UseFont = false;
        this.xrTableRow10.StylePriority.UseTextAlignment = false;
        this.xrTableRow10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        this.xrTableRow10.Weight = 0.24694500151341417D;
        // 
        // xrException300
        // 
        this.xrException300.CanGrow = false;
        this.xrException300.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
        this.xrException300.Name = "xrException300";
        this.xrException300.StylePriority.UseFont = false;
        this.xrException300.StylePriority.UseTextAlignment = false;
        this.xrException300.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        this.xrException300.Weight = 1D;
        // 
        // xrTableCell31
        // 
        this.xrTableCell31.CanGrow = false;
        this.xrTableCell31.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell31.Name = "xrTableCell31";
        this.xrTableCell31.StylePriority.UseFont = false;
        this.xrTableCell31.StylePriority.UseTextAlignment = false;
        this.xrTableCell31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        this.xrTableCell31.Weight = 0.765895123880648D;
        // 
        // xrTableCell32
        // 
        this.xrTableCell32.CanGrow = false;
        this.xrTableCell32.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell32.Name = "xrTableCell32";
        this.xrTableCell32.StylePriority.UseFont = false;
        this.xrTableCell32.StylePriority.UseTextAlignment = false;
        this.xrTableCell32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        this.xrTableCell32.Weight = 1.2341048761193521D;
        // 
        // xrTableRow21
        // 
        this.xrTableRow21.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableRow21.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell581,
            this.xrTableCell33,
            this.xrTableCell60});
        this.xrTableRow21.Font = new System.Drawing.Font("Tahoma", 8F);
        this.xrTableRow21.Name = "xrTableRow21";
        this.xrTableRow21.StylePriority.UseBorders = false;
        this.xrTableRow21.StylePriority.UseFont = false;
        this.xrTableRow21.StylePriority.UseTextAlignment = false;
        this.xrTableRow21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
        this.xrTableRow21.Weight = 1.312956660701514D;
        // 
        // xrTableCell581
        // 
        this.xrTableCell581.CanGrow = false;
        this.xrTableCell581.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.picBoxException10,
            this.picBoxException9});
        this.xrTableCell581.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Underline);
        this.xrTableCell581.Name = "xrTableCell581";
        this.xrTableCell581.StylePriority.UseFont = false;
        this.xrTableCell581.StylePriority.UseTextAlignment = false;
        this.xrTableCell581.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
        this.xrTableCell581.Weight = 1D;
        // 
        // picBoxException10
        // 
        this.picBoxException10.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.picBoxException10.Image = ((System.Drawing.Image)(resources.GetObject("picBoxException10.Image")));
        this.picBoxException10.LocationFloat = new DevExpress.Utils.PointFloat(60.70722F, 24.75688F);
        this.picBoxException10.Name = "picBoxException10";
        this.picBoxException10.SizeF = new System.Drawing.SizeF(95.49458F, 90.3646F);
        this.picBoxException10.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
        this.picBoxException10.StylePriority.UseBorders = false;
        this.picBoxException10.Visible = false;
        // 
        // picBoxException9
        // 
        this.picBoxException9.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.picBoxException9.Image = ((System.Drawing.Image)(resources.GetObject("picBoxException9.Image")));
        this.picBoxException9.LocationFloat = new DevExpress.Utils.PointFloat(60.70722F, 24.75696F);
        this.picBoxException9.Name = "picBoxException9";
        this.picBoxException9.SizeF = new System.Drawing.SizeF(95.49458F, 90.3646F);
        this.picBoxException9.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
        this.picBoxException9.StylePriority.UseBorders = false;
        this.picBoxException9.Visible = false;
        // 
        // xrTableCell33
        // 
        this.xrTableCell33.CanGrow = false;
        this.xrTableCell33.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblException9});
        this.xrTableCell33.Name = "xrTableCell33";
        this.xrTableCell33.Weight = 0.765895123880648D;
        // 
        // lblException9
        // 
        this.lblException9.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.lblException9.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
        this.lblException9.ForeColor = System.Drawing.Color.Black;
        this.lblException9.LocationFloat = new DevExpress.Utils.PointFloat(9.332747F, 62.69781F);
        this.lblException9.Name = "lblException9";
        this.lblException9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.lblException9.SizeF = new System.Drawing.SizeF(145.9111F, 13.62501F);
        this.lblException9.StylePriority.UseBorders = false;
        this.lblException9.StylePriority.UseFont = false;
        this.lblException9.StylePriority.UseForeColor = false;
        this.lblException9.StylePriority.UseTextAlignment = false;
        this.lblException9.Text = "Approve datetime";
        this.lblException9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.lblException9.Visible = false;
        // 
        // xrTableCell60
        // 
        this.xrTableCell60.CanGrow = false;
        this.xrTableCell60.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            /*this.lblException10*/});
        this.xrTableCell60.Name = "xrTableCell60";
        this.xrTableCell60.Text = "Note";
        this.xrTableCell60.Weight = 1.2341048761193521D;
        this.xrTableCell60.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
        this.xrTableCell60.ForeColor = System.Drawing.Color.Black;
        this.xrTableCell60.Multiline = true;
        this.xrTableCell60.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrTableCell60.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // lblException10
        // 
        //this.lblException10.Borders = DevExpress.XtraPrinting.BorderSide.None;
        //this.lblException10.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
        //this.lblException10.ForeColor = System.Drawing.Color.Black;
        //this.lblException10.LocationFloat = new DevExpress.Utils.PointFloat(7.256063F, 9.999593F);
        //this.lblException10.Name = "lblException10";
        //this.lblException10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        //this.lblException10.SizeF = new System.Drawing.SizeF(249.0055F, 105.1218F);
        //this.lblException10.StylePriority.UseBorders = false;
        //this.lblException10.StylePriority.UseFont = false;
        //this.lblException10.StylePriority.UseForeColor = false;
        //this.lblException10.StylePriority.UseTextAlignment = false;
        //this.lblException10.Text = "Note";
        //this.lblException10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        //this.lblException10.Visible = false;
        // 
        // xrTableRow30
        // 
        this.xrTableRow30.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrException833,
            this.xrTableCell84,
            this.xrTableCell85});
        this.xrTableRow30.Name = "xrTableRow30";
        this.xrTableRow30.Weight = 0.30562159232593311D;
        // 
        // xrException833
        // 
        this.xrException833.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrException833.CanGrow = false;
        this.xrException833.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Underline);
        this.xrException833.Name = "xrException833";
        this.xrException833.StylePriority.UseBorders = false;
        this.xrException833.StylePriority.UseFont = false;
        this.xrException833.StylePriority.UseTextAlignment = false;
        this.xrException833.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
        this.xrException833.Weight = 1D;
        // 
        // xrTableCell84
        // 
        this.xrTableCell84.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell84.CanGrow = false;
        this.xrTableCell84.Name = "xrTableCell84";
        this.xrTableCell84.StylePriority.UseBorders = false;
        this.xrTableCell84.Weight = 0.765895123880648D;
        // 
        // xrTableCell85
        // 
        this.xrTableCell85.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell85.CanGrow = false;
        this.xrTableCell85.Name = "xrTableCell85";
        this.xrTableCell85.StylePriority.UseBorders = false;
        this.xrTableCell85.Weight = 1.2341048761193521D;
        // 
        // xrTableRow31
        // 
        this.xrTableRow31.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrException866,
            this.xrTableCell87,
            this.xrTableCell88});
        this.xrTableRow31.Name = "xrTableRow31";
        this.xrTableRow31.Weight = 0.26650217303632429D;
        // 
        // xrException866
        // 
        this.xrException866.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrException866.CanGrow = false;
        this.xrException866.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
        this.xrException866.Name = "xrException866";
        this.xrException866.StylePriority.UseBorders = false;
        this.xrException866.StylePriority.UseFont = false;
        this.xrException866.StylePriority.UseTextAlignment = false;
        this.xrException866.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        this.xrException866.Weight = 1D;
        // 
        // xrTableCell87
        // 
        this.xrTableCell87.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell87.CanGrow = false;
        this.xrTableCell87.Name = "xrTableCell87";
        this.xrTableCell87.StylePriority.UseBorders = false;
        this.xrTableCell87.Weight = 0.765895123880648D;
        // 
        // xrTableCell88
        // 
        this.xrTableCell88.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell88.CanGrow = false;
        this.xrTableCell88.Name = "xrTableCell88";
        this.xrTableCell88.StylePriority.UseBorders = false;
        this.xrTableCell88.Weight = 1.2341048761193521D;
        // 
        // xrTableRow29
        // 
        this.xrTableRow29.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell76,
            this.xrTableCell81,
            this.xrTableCell82});
        this.xrTableRow29.Name = "xrTableRow29";
        this.xrTableRow29.Weight = 1.3716362128176756D;
        // 
        // xrTableCell76
        // 
        this.xrTableCell76.CanGrow = false;
        this.xrTableCell76.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.picBoxException11,
            this.picBoxException12});
        this.xrTableCell76.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Underline);
        this.xrTableCell76.Name = "xrTableCell76";
        this.xrTableCell76.StylePriority.UseFont = false;
        this.xrTableCell76.StylePriority.UseTextAlignment = false;
        this.xrTableCell76.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
        this.xrTableCell76.Weight = 1D;
        // 
        // picBoxException11
        // 
        this.picBoxException11.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.picBoxException11.Image = ((System.Drawing.Image)(resources.GetObject("picBoxException11.Image")));
        this.picBoxException11.LocationFloat = new DevExpress.Utils.PointFloat(60.70722F, 24.73946F);
        this.picBoxException11.Name = "picBoxException11";
        this.picBoxException11.SizeF = new System.Drawing.SizeF(95.49458F, 90.3646F);
        this.picBoxException11.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
        this.picBoxException11.StylePriority.UseBorders = false;
        this.picBoxException11.Visible = false;
        // 
        // picBoxException12
        // 
        this.picBoxException12.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.picBoxException12.Image = ((System.Drawing.Image)(resources.GetObject("picBoxException12.Image")));
        this.picBoxException12.LocationFloat = new DevExpress.Utils.PointFloat(60.12912F, 24.73948F);
        this.picBoxException12.Name = "picBoxException12";
        this.picBoxException12.SizeF = new System.Drawing.SizeF(95.49458F, 90.3646F);
        this.picBoxException12.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
        this.picBoxException12.StylePriority.UseBorders = false;
        this.picBoxException12.Visible = false;
        // 
        // xrTableCell81
        // 
        this.xrTableCell81.CanGrow = false;
        this.xrTableCell81.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblException11});
        this.xrTableCell81.Name = "xrTableCell81";
        this.xrTableCell81.Weight = 0.765895123880648D;
        // 
        // lblException11
        // 
        this.lblException11.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.lblException11.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
        this.lblException11.ForeColor = System.Drawing.Color.Black;
        this.lblException11.LocationFloat = new DevExpress.Utils.PointFloat(9.666442F, 63.10926F);
        this.lblException11.Name = "lblException11";
        this.lblException11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.lblException11.SizeF = new System.Drawing.SizeF(145.9112F, 13.62501F);
        this.lblException11.StylePriority.UseBorders = false;
        this.lblException11.StylePriority.UseFont = false;
        this.lblException11.StylePriority.UseForeColor = false;
        this.lblException11.StylePriority.UseTextAlignment = false;
        this.lblException11.Text = "Approve datetime";
        this.lblException11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.lblException11.Visible = false;
        // 
        // xrTableCell82
        // 
        this.xrTableCell82.CanGrow = false;
        this.xrTableCell82.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            /*this.lblException12*/});
        this.xrTableCell82.Name = "xrTableCell82";
        this.xrTableCell82.Weight = 1.2341048761193521D;
        this.xrTableCell82.Text = "Note";
        this.xrTableCell82.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
        this.xrTableCell82.ForeColor = System.Drawing.Color.Black;
        this.xrTableCell82.Multiline = true;
        this.xrTableCell82.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrTableCell82.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // lblException12
        // 
        //this.lblException12.Borders = DevExpress.XtraPrinting.BorderSide.None;
        //    this.lblException12.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
        //    this.lblException12.ForeColor = System.Drawing.Color.Black;
        //    this.lblException12.LocationFloat = new DevExpress.Utils.PointFloat(6.090292F, 9.999974F);
        //    this.lblException12.Multiline = true;
        //    this.lblException12.Name = "lblException12";
        //    this.lblException12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        //    this.lblException12.SizeF = new System.Drawing.SizeF(249.0055F, 109.6186F);
        //    this.lblException12.StylePriority.UseBorders = false;
        //    this.lblException12.StylePriority.UseFont = false;
        //    this.lblException12.StylePriority.UseForeColor = false;
        //    this.lblException12.StylePriority.UseTextAlignment = false;
        //    this.lblException12.Text = "Note";
        //    this.lblException12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        //    this.lblException12.Visible = false;
        // 
        // xrTableRow24
        // 
        this.xrTableRow24.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableRow24.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrException35,
            this.xrTableCell68,
            this.xrTableCell69});
        this.xrTableRow24.Name = "xrTableRow24";
        this.xrTableRow24.StylePriority.UseBorders = false;
        this.xrTableRow24.StylePriority.UseTextAlignment = false;
        this.xrTableRow24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        this.xrTableRow24.Weight = 0.31540799157783417D;
        // 
        // xrException35
        // 
        this.xrException35.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrException35.CanGrow = false;
        this.xrException35.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.xrException35.Name = "xrException35";
        this.xrException35.StylePriority.UseBorders = false;
        this.xrException35.StylePriority.UseFont = false;
        this.xrException35.StylePriority.UseTextAlignment = false;
        this.xrException35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
        this.xrException35.Weight = 1D;
        // 
        // xrTableCell68
        // 
        this.xrTableCell68.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell68.CanGrow = false;
        this.xrTableCell68.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell68.Name = "xrTableCell68";
        this.xrTableCell68.StylePriority.UseBorders = false;
        this.xrTableCell68.StylePriority.UseFont = false;
        this.xrTableCell68.StylePriority.UseTextAlignment = false;
        this.xrTableCell68.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        this.xrTableCell68.Weight = 0.765895123880648D;
        // 
        // xrTableCell69
        // 
        this.xrTableCell69.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell69.CanGrow = false;
        this.xrTableCell69.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell69.Name = "xrTableCell69";
        this.xrTableCell69.StylePriority.UseBorders = false;
        this.xrTableCell69.StylePriority.UseFont = false;
        this.xrTableCell69.StylePriority.UseTextAlignment = false;
        this.xrTableCell69.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        this.xrTableCell69.Weight = 1.2341048761193521D;
        // 
        // xrTableRow28
        // 
        this.xrTableRow28.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrException677,
            this.xrTableCell79,
            this.xrTableCell80});
        this.xrTableRow28.Name = "xrTableRow28";
        this.xrTableRow28.Weight = 0.28606799732765426D;
        // 
        // xrException677
        // 
        this.xrException677.CanGrow = false;
        this.xrException677.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
        this.xrException677.Name = "xrException677";
        this.xrException677.StylePriority.UseFont = false;
        this.xrException677.StylePriority.UseTextAlignment = false;
        this.xrException677.Text = " ";
        this.xrException677.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        this.xrException677.Weight = 1D;
        // 
        // xrTableCell79
        // 
        this.xrTableCell79.CanGrow = false;
        this.xrTableCell79.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell79.Name = "xrTableCell79";
        this.xrTableCell79.StylePriority.UseFont = false;
        this.xrTableCell79.StylePriority.UseTextAlignment = false;
        this.xrTableCell79.Text = " ";
        this.xrTableCell79.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        this.xrTableCell79.Weight = 0.765895123880648D;
        // 
        // xrTableCell80
        // 
        this.xrTableCell80.CanGrow = false;
        this.xrTableCell80.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell80.Name = "xrTableCell80";
        this.xrTableCell80.StylePriority.UseFont = false;
        this.xrTableCell80.StylePriority.UseTextAlignment = false;
        this.xrTableCell80.Text = " ";
        this.xrTableCell80.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        this.xrTableCell80.Weight = 1.2341048761193521D;
        // 
        // xrTableRow11
        // 
        this.xrTableRow11.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell16,
            this.xrTableCell17,
            this.xrTableCell19});
        this.xrTableRow11.Name = "xrTableRow11";
        this.xrTableRow11.Weight = 1.2340473365929414D;
        // 
        // xrTableCell16
        // 
        this.xrTableCell16.CanGrow = false;
        this.xrTableCell16.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.picBoxException13,
            this.picBoxException14});
        this.xrTableCell16.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell16.Name = "xrTableCell16";
        this.xrTableCell16.StylePriority.UseFont = false;
        this.xrTableCell16.StylePriority.UseTextAlignment = false;
        this.xrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        this.xrTableCell16.Weight = 1D;
        // 
        // picBoxException13
        // 
        this.picBoxException13.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.picBoxException13.Image = ((System.Drawing.Image)(resources.GetObject("picBoxException13.Image")));
        this.picBoxException13.LocationFloat = new DevExpress.Utils.PointFloat(60.7072F, 13.12599F);
        this.picBoxException13.Name = "picBoxException13";
        this.picBoxException13.SizeF = new System.Drawing.SizeF(95.49458F, 90.3646F);
        this.picBoxException13.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
        this.picBoxException13.StylePriority.UseBorders = false;
        this.picBoxException13.Visible = false;
        // 
        // picBoxException14
        // 
        this.picBoxException14.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.picBoxException14.Image = ((System.Drawing.Image)(resources.GetObject("picBoxException14.Image")));
        this.picBoxException14.LocationFloat = new DevExpress.Utils.PointFloat(60.12912F, 13.12603F);
        this.picBoxException14.Name = "picBoxException14";
        this.picBoxException14.SizeF = new System.Drawing.SizeF(95.49458F, 90.3646F);
        this.picBoxException14.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
        this.picBoxException14.StylePriority.UseBorders = false;
        this.picBoxException14.Visible = false;
        // 
        // xrTableCell17
        // 
        this.xrTableCell17.CanGrow = false;
        this.xrTableCell17.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblException13});
        this.xrTableCell17.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell17.Name = "xrTableCell17";
        this.xrTableCell17.StylePriority.UseFont = false;
        this.xrTableCell17.StylePriority.UseTextAlignment = false;
        this.xrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        this.xrTableCell17.Weight = 0.765895123880648D;
        // 
        // lblException13
        // 
        this.lblException13.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.lblException13.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
        this.lblException13.ForeColor = System.Drawing.Color.Black;
        this.lblException13.LocationFloat = new DevExpress.Utils.PointFloat(9.666442F, 51.49569F);
        this.lblException13.Name = "lblException13";
        this.lblException13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.lblException13.SizeF = new System.Drawing.SizeF(145.9112F, 13.625F);
        this.lblException13.StylePriority.UseBorders = false;
        this.lblException13.StylePriority.UseFont = false;
        this.lblException13.StylePriority.UseForeColor = false;
        this.lblException13.StylePriority.UseTextAlignment = false;
        this.lblException13.Text = "Approve datetime";
        this.lblException13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.lblException13.Visible = false;
        // 
        // xrTableCell19
        // 
        this.xrTableCell19.CanGrow = false;
        this.xrTableCell19.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            /*this.lblException14*/});
        this.xrTableCell19.Name = "xrTableCell19";
        this.xrTableCell19.Weight = 1.2341048761193521D;
        this.xrTableCell19.Text = "Note";
        this.xrTableCell19.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
        this.xrTableCell19.ForeColor = System.Drawing.Color.Black;
        this.xrTableCell19.Multiline = true;
        this.xrTableCell19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrTableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // lblException14
        // 
        //this.lblException14.Borders = DevExpress.XtraPrinting.BorderSide.None;
        //    this.lblException14.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
        //    this.lblException14.ForeColor = System.Drawing.Color.Black;
        //    this.lblException14.LocationFloat = new DevExpress.Utils.PointFloat(6.090292F, 13.12625F);
        //    this.lblException14.Multiline = true;
        //    this.lblException14.Name = "lblException14";
        //    this.lblException14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        //    this.lblException14.SizeF = new System.Drawing.SizeF(249.0055F, 90.36459F);
        //    this.lblException14.StylePriority.UseBorders = false;
        //    this.lblException14.StylePriority.UseFont = false;
        //    this.lblException14.StylePriority.UseForeColor = false;
        //    this.lblException14.StylePriority.UseTextAlignment = false;
        //    this.lblException14.Text = "Note";
        //    this.lblException14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        //    this.lblException14.Visible = false;
        // 
        // xrTableRow14
        // 
        this.xrTableRow14.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrException221,
            this.xrTableCell28,
            this.xrTableCell30});
        this.xrTableRow14.Name = "xrTableRow14";
        this.xrTableRow14.Weight = 0.34118411056965481D;
        // 
        // xrException221
        // 
        this.xrException221.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrException221.CanGrow = false;
        this.xrException221.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.xrException221.Name = "xrException221";
        this.xrException221.StylePriority.UseBorders = false;
        this.xrException221.StylePriority.UseFont = false;
        this.xrException221.StylePriority.UseTextAlignment = false;
        this.xrException221.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        this.xrException221.Weight = 1D;
        // 
        // xrTableCell28
        // 
        this.xrTableCell28.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell28.CanGrow = false;
        this.xrTableCell28.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell28.Name = "xrTableCell28";
        this.xrTableCell28.StylePriority.UseBorders = false;
        this.xrTableCell28.StylePriority.UseFont = false;
        this.xrTableCell28.StylePriority.UseTextAlignment = false;
        this.xrTableCell28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        this.xrTableCell28.Weight = 0.765895123880648D;
        // 
        // xrTableCell30
        // 
        this.xrTableCell30.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell30.CanGrow = false;
        this.xrTableCell30.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell30.Name = "xrTableCell30";
        this.xrTableCell30.StylePriority.UseBorders = false;
        this.xrTableCell30.StylePriority.UseFont = false;
        this.xrTableCell30.StylePriority.UseTextAlignment = false;
        this.xrTableCell30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        this.xrTableCell30.Weight = 1.2341048761193521D;
        // 
        // xrTableRow32
        // 
        this.xrTableRow32.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrException351,
            this.xrTableCell61,
            this.xrTableCell64});
        this.xrTableRow32.Name = "xrTableRow32";
        this.xrTableRow32.Weight = 0.34118411056965481D;
        // 
        // xrException351
        // 
        this.xrException351.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrException351.CanGrow = false;
        this.xrException351.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
        this.xrException351.Name = "xrException351";
        this.xrException351.StylePriority.UseBorders = false;
        this.xrException351.StylePriority.UseFont = false;
        this.xrException351.StylePriority.UseTextAlignment = false;
        this.xrException351.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        this.xrException351.Weight = 1D;
        // 
        // xrTableCell61
        // 
        this.xrTableCell61.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell61.CanGrow = false;
        this.xrTableCell61.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell61.Name = "xrTableCell61";
        this.xrTableCell61.StylePriority.UseBorders = false;
        this.xrTableCell61.StylePriority.UseFont = false;
        this.xrTableCell61.StylePriority.UseTextAlignment = false;
        this.xrTableCell61.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        this.xrTableCell61.Weight = 0.765895123880648D;
        // 
        // xrTableCell64
        // 
        this.xrTableCell64.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell64.CanGrow = false;
        this.xrTableCell64.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell64.Name = "xrTableCell64";
        this.xrTableCell64.StylePriority.UseBorders = false;
        this.xrTableCell64.StylePriority.UseFont = false;
        this.xrTableCell64.StylePriority.UseTextAlignment = false;
        this.xrTableCell64.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        this.xrTableCell64.Weight = 1.2341048761193521D;
        // 
        // xrTableRow33
        // 
        this.xrTableRow33.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell67,
            this.xrTableCell71,
            this.xrTableCell72});
        this.xrTableRow33.Name = "xrTableRow33";
        this.xrTableRow33.Weight = 1.3332536677210727D;
        // 
        // xrTableCell67
        // 
        this.xrTableCell67.CanGrow = false;
        this.xrTableCell67.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.picBoxException15,
            this.picBoxException16});
        this.xrTableCell67.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell67.Name = "xrTableCell67";
        this.xrTableCell67.StylePriority.UseFont = false;
        this.xrTableCell67.StylePriority.UseTextAlignment = false;
        this.xrTableCell67.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        this.xrTableCell67.Weight = 0.99693141842644339D;
        // 
        // picBoxException15
        // 
        this.picBoxException15.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.picBoxException15.Image = ((System.Drawing.Image)(resources.GetObject("picBoxException15.Image")));
        this.picBoxException15.LocationFloat = new DevExpress.Utils.PointFloat(60.70722F, 17.81349F);
        this.picBoxException15.Name = "picBoxException15";
        this.picBoxException15.SizeF = new System.Drawing.SizeF(95.49458F, 90.3646F);
        this.picBoxException15.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
        this.picBoxException15.StylePriority.UseBorders = false;
        this.picBoxException15.Visible = false;
        // 
        // picBoxException16
        // 
        this.picBoxException16.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.picBoxException16.Image = ((System.Drawing.Image)(resources.GetObject("picBoxException16.Image")));
        this.picBoxException16.LocationFloat = new DevExpress.Utils.PointFloat(60.12912F, 17.8135F);
        this.picBoxException16.Name = "picBoxException16";
        this.picBoxException16.SizeF = new System.Drawing.SizeF(95.49458F, 90.3646F);
        this.picBoxException16.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
        this.picBoxException16.StylePriority.UseBorders = false;
        this.picBoxException16.Visible = false;
        // 
        // xrTableCell71
        // 
        this.xrTableCell71.CanGrow = false;
        this.xrTableCell71.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblException15});
        this.xrTableCell71.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell71.Name = "xrTableCell71";
        this.xrTableCell71.StylePriority.UseFont = false;
        this.xrTableCell71.StylePriority.UseTextAlignment = false;
        this.xrTableCell71.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        this.xrTableCell71.Weight = 0.76354403366776036D;
        // 
        // lblException15
        // 
        this.lblException15.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.lblException15.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
        this.lblException15.ForeColor = System.Drawing.Color.Black;
        this.lblException15.LocationFloat = new DevExpress.Utils.PointFloat(9.666442F, 56.1834F);
        this.lblException15.Name = "lblException15";
        this.lblException15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.lblException15.SizeF = new System.Drawing.SizeF(145.9112F, 13.62501F);
        this.lblException15.StylePriority.UseBorders = false;
        this.lblException15.StylePriority.UseFont = false;
        this.lblException15.StylePriority.UseForeColor = false;
        this.lblException15.StylePriority.UseTextAlignment = false;
        this.lblException15.Text = "Approve datetime";
        this.lblException15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.lblException15.Visible = false;
        // 
        // xrTableCell72
        // 
        this.xrTableCell72.CanGrow = false;
        this.xrTableCell72.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            /*this.lblException16*/});
        this.xrTableCell72.Name = "xrTableCell72";
        this.xrTableCell72.Weight = 1.2303186150174674D;
        this.xrTableCell72.Text = "Note";
        this.xrTableCell72.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
        this.xrTableCell72.ForeColor = System.Drawing.Color.Black;
        this.xrTableCell72.Multiline = true;
        this.xrTableCell72.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrTableCell72.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // lblException16
        // 
        //this.lblException16.Borders = DevExpress.XtraPrinting.BorderSide.None;
        //    this.lblException16.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
        //    this.lblException16.ForeColor = System.Drawing.Color.Black;
        //    this.lblException16.LocationFloat = new DevExpress.Utils.PointFloat(6.090037F, 9.999847F);
        //    this.lblException16.Multiline = true;
        //    this.lblException16.Name = "lblException16";
        //    this.lblException16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        //    this.lblException16.SizeF = new System.Drawing.SizeF(249.0056F, 105.9916F);
        //    this.lblException16.StylePriority.UseBorders = false;
        //    this.lblException16.StylePriority.UseFont = false;
        //    this.lblException16.StylePriority.UseForeColor = false;
        //    this.lblException16.StylePriority.UseTextAlignment = false;
        //    this.lblException16.Text = "Note";
        //    this.lblException16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        //    this.lblException16.Visible = false;
        // 
        // xrTableRow34
        // 
        this.xrTableRow34.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrException83,
            this.xrTableCell86,
            this.xrTableCell89});
        this.xrTableRow34.Name = "xrTableRow34";
        this.xrTableRow34.Weight = 0.29709179006670738D;
        // 
        // xrException83
        // 
        this.xrException83.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrException83.CanGrow = false;
        this.xrException83.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.xrException83.Name = "xrException83";
        this.xrException83.StylePriority.UseBorders = false;
        this.xrException83.StylePriority.UseFont = false;
        this.xrException83.StylePriority.UseTextAlignment = false;
        this.xrException83.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        this.xrException83.Weight = 1D;
        // 
        // xrTableCell86
        // 
        this.xrTableCell86.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell86.CanGrow = false;
        this.xrTableCell86.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell86.Name = "xrTableCell86";
        this.xrTableCell86.StylePriority.UseBorders = false;
        this.xrTableCell86.StylePriority.UseFont = false;
        this.xrTableCell86.StylePriority.UseTextAlignment = false;
        this.xrTableCell86.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        this.xrTableCell86.Weight = 0.765895123880648D;
        // 
        // xrTableCell89
        // 
        this.xrTableCell89.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell89.CanGrow = false;
        this.xrTableCell89.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell89.Name = "xrTableCell89";
        this.xrTableCell89.StylePriority.UseBorders = false;
        this.xrTableCell89.StylePriority.UseFont = false;
        this.xrTableCell89.StylePriority.UseTextAlignment = false;
        this.xrTableCell89.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        this.xrTableCell89.Weight = 1.2341048761193521D;
        // 
        // xrTableRow35
        // 
        this.xrTableRow35.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrException90,
            this.xrTableCell91,
            this.xrTableCell92});
        this.xrTableRow35.Name = "xrTableRow35";
        this.xrTableRow35.Weight = 0.29709179006670738D;
        // 
        // xrException90
        // 
        this.xrException90.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrException90.CanGrow = false;
        this.xrException90.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
        this.xrException90.Name = "xrException90";
        this.xrException90.StylePriority.UseBorders = false;
        this.xrException90.StylePriority.UseFont = false;
        this.xrException90.StylePriority.UseTextAlignment = false;
        this.xrException90.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        this.xrException90.Weight = 1D;
        // 
        // xrTableCell91
        // 
        this.xrTableCell91.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell91.CanGrow = false;
        this.xrTableCell91.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell91.Name = "xrTableCell91";
        this.xrTableCell91.StylePriority.UseBorders = false;
        this.xrTableCell91.StylePriority.UseFont = false;
        this.xrTableCell91.StylePriority.UseTextAlignment = false;
        this.xrTableCell91.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        this.xrTableCell91.Weight = 0.765895123880648D;
        // 
        // xrTableCell92
        // 
        this.xrTableCell92.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell92.CanGrow = false;
        this.xrTableCell92.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell92.Name = "xrTableCell92";
        this.xrTableCell92.StylePriority.UseBorders = false;
        this.xrTableCell92.StylePriority.UseFont = false;
        this.xrTableCell92.StylePriority.UseTextAlignment = false;
        this.xrTableCell92.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        this.xrTableCell92.Weight = 1.2341048761193521D;
        // 
        // xrTableRow37
        // 
        this.xrTableRow37.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell90,
            this.xrTableCell93,
            this.xrTableCell94});
        this.xrTableRow37.Name = "xrTableRow37";
        this.xrTableRow37.Weight = 1.3332536677210727D;
        // 
        // xrTableCell90
        // 
        this.xrTableCell90.CanGrow = false;
        this.xrTableCell90.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.picBoxException17,
            this.picBoxException18});
        this.xrTableCell90.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell90.Name = "xrTableCell90";
        this.xrTableCell90.StylePriority.UseFont = false;
        this.xrTableCell90.StylePriority.UseTextAlignment = false;
        this.xrTableCell90.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        this.xrTableCell90.Weight = 0.99693141842644339D;
        // 
        // picBoxException17
        // 
        this.picBoxException17.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.picBoxException17.Image = ((System.Drawing.Image)(resources.GetObject("picBoxException17.Image")));
        this.picBoxException17.LocationFloat = new DevExpress.Utils.PointFloat(60.1291F, 9.999974F);
        this.picBoxException17.Name = "picBoxException17";
        this.picBoxException17.SizeF = new System.Drawing.SizeF(95.49458F, 90.3646F);
        this.picBoxException17.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
        this.picBoxException17.StylePriority.UseBorders = false;
        this.picBoxException17.Visible = false;
        // 
        // picBoxException18
        // 
        this.picBoxException18.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.picBoxException18.Image = ((System.Drawing.Image)(resources.GetObject("picBoxException18.Image")));
        this.picBoxException18.LocationFloat = new DevExpress.Utils.PointFloat(60.12914F, 10F);
        this.picBoxException18.Name = "picBoxException18";
        this.picBoxException18.SizeF = new System.Drawing.SizeF(95.49458F, 90.3646F);
        this.picBoxException18.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
        this.picBoxException18.StylePriority.UseBorders = false;
        this.picBoxException18.Visible = false;
        // 
        // xrTableCell93
        // 
        this.xrTableCell93.CanGrow = false;
        this.xrTableCell93.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblException17});
        this.xrTableCell93.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell93.Name = "xrTableCell93";
        this.xrTableCell93.StylePriority.UseFont = false;
        this.xrTableCell93.StylePriority.UseTextAlignment = false;
        this.xrTableCell93.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        this.xrTableCell93.Weight = 0.76354403366776036D;
        // 
        // lblException17
        // 
        this.lblException17.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.lblException17.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
        this.lblException17.ForeColor = System.Drawing.Color.Black;
        this.lblException17.LocationFloat = new DevExpress.Utils.PointFloat(9.336017F, 66.72305F);
        this.lblException17.Name = "lblException17";
        this.lblException17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.lblException17.SizeF = new System.Drawing.SizeF(145.9112F, 13.62501F);
        this.lblException17.StylePriority.UseBorders = false;
        this.lblException17.StylePriority.UseFont = false;
        this.lblException17.StylePriority.UseForeColor = false;
        this.lblException17.StylePriority.UseTextAlignment = false;
        this.lblException17.Text = "Approve datetime";
        this.lblException17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.lblException17.Visible = false;
        // 
        // xrTableCell94
        // 
        this.xrTableCell94.CanGrow = false;
        this.xrTableCell94.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            /*this.lblException18*/});
        this.xrTableCell94.Name = "xrTableCell94";
        this.xrTableCell94.Weight = 1.2303186150174674D;
        this.xrTableCell94.Text = "Note";
        this.xrTableCell94.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
        this.xrTableCell94.ForeColor = System.Drawing.Color.Black;
        this.xrTableCell94.Multiline = true;
        this.xrTableCell94.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrTableCell94.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // lblException18
        // 
        //this.lblException18.Borders = DevExpress.XtraPrinting.BorderSide.None;
        //this.lblException18.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
        //this.lblException18.ForeColor = System.Drawing.Color.Black;
        //this.lblException18.LocationFloat = new DevExpress.Utils.PointFloat(6.42217F, 10.0001F);
        //this.lblException18.Multiline = true;
        //this.lblException18.Name = "lblException18";
        //this.lblException18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        //this.lblException18.SizeF = new System.Drawing.SizeF(249.0057F, 105.9916F);
        //this.lblException18.StylePriority.UseBorders = false;
        //this.lblException18.StylePriority.UseFont = false;
        //this.lblException18.StylePriority.UseForeColor = false;
        //this.lblException18.StylePriority.UseTextAlignment = false;
        //this.lblException18.Text = "Note";
        //this.lblException18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        //this.lblException18.Visible = false;
        // 
        // xrTableRow38
        // 
        this.xrTableRow38.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrException95,
            this.xrTableCell96,
            this.xrTableCell97});
        this.xrTableRow38.Name = "xrTableRow38";
        this.xrTableRow38.Weight = 0.29709179006670738D;
        // 
        // xrException95
        // 
        this.xrException95.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrException95.CanGrow = false;
        this.xrException95.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.xrException95.Name = "xrException95";
        this.xrException95.StylePriority.UseBorders = false;
        this.xrException95.StylePriority.UseFont = false;
        this.xrException95.StylePriority.UseTextAlignment = false;
        this.xrException95.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        this.xrException95.Weight = 1D;
        // 
        // xrTableCell96
        // 
        this.xrTableCell96.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell96.CanGrow = false;
        this.xrTableCell96.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell96.Name = "xrTableCell96";
        this.xrTableCell96.StylePriority.UseBorders = false;
        this.xrTableCell96.StylePriority.UseFont = false;
        this.xrTableCell96.StylePriority.UseTextAlignment = false;
        this.xrTableCell96.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        this.xrTableCell96.Weight = 0.765895123880648D;
        // 
        // xrTableCell97
        // 
        this.xrTableCell97.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell97.CanGrow = false;
        this.xrTableCell97.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell97.Name = "xrTableCell97";
        this.xrTableCell97.StylePriority.UseBorders = false;
        this.xrTableCell97.StylePriority.UseFont = false;
        this.xrTableCell97.StylePriority.UseTextAlignment = false;
        this.xrTableCell97.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        this.xrTableCell97.Weight = 1.2341048761193521D;
        // 
        // xrTableRow39
        // 
        this.xrTableRow39.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrException98,
            this.xrTableCell99,
            this.xrTableCell100});
        this.xrTableRow39.Name = "xrTableRow39";
        this.xrTableRow39.Weight = 0.29709179006670738D;
        // 
        // xrException98
        // 
        this.xrException98.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrException98.CanGrow = false;
        this.xrException98.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
        this.xrException98.Name = "xrException98";
        this.xrException98.StylePriority.UseBorders = false;
        this.xrException98.StylePriority.UseFont = false;
        this.xrException98.StylePriority.UseTextAlignment = false;
        this.xrException98.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        this.xrException98.Weight = 1D;
        // 
        // xrTableCell99
        // 
        this.xrTableCell99.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell99.CanGrow = false;
        this.xrTableCell99.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell99.Name = "xrTableCell99";
        this.xrTableCell99.StylePriority.UseBorders = false;
        this.xrTableCell99.StylePriority.UseFont = false;
        this.xrTableCell99.StylePriority.UseTextAlignment = false;
        this.xrTableCell99.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        this.xrTableCell99.Weight = 0.765895123880648D;
        // 
        // xrTableCell100
        // 
        this.xrTableCell100.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell100.CanGrow = false;
        this.xrTableCell100.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell100.Name = "xrTableCell100";
        this.xrTableCell100.StylePriority.UseBorders = false;
        this.xrTableCell100.StylePriority.UseFont = false;
        this.xrTableCell100.StylePriority.UseTextAlignment = false;
        this.xrTableCell100.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        this.xrTableCell100.Weight = 1.2341048761193521D;
        // 
        // xrLabel11
        // 
        this.xrLabel11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(171.3804F, 284.507F);
        this.xrLabel11.Name = "xrLabel11";
        this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel11.SizeF = new System.Drawing.SizeF(384.2503F, 17.79166F);
        this.xrLabel11.StylePriority.UseFont = false;
        this.xrLabel11.StylePriority.UseTextAlignment = false;
        this.xrLabel11.Text = "LEMBAR PERSETUJUAN INTERNAL MEMORANDUM";
        this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTable3
        // 
        this.xrTable3.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable3.Font = new System.Drawing.Font("Tahoma", 9.75F);
        this.xrTable3.KeepTogether = true;
        this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(47.87499F, 40.625F);
        this.xrTable3.Name = "xrTable3";
        this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow12,
            this.xrTableRow13,
            this.xrTableRow6,
            this.xrTableRow25});
        this.xrTable3.SizeF = new System.Drawing.SizeF(619.8333F, 226.0417F);
        this.xrTable3.StylePriority.UseBorders = false;
        this.xrTable3.StylePriority.UseFont = false;
        // 
        // xrTableRow12
        // 
        this.xrTableRow12.BackColor = System.Drawing.Color.Gainsboro;
        this.xrTableRow12.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell20,
            this.xrTableCell34});
        this.xrTableRow12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
        this.xrTableRow12.Name = "xrTableRow12";
        this.xrTableRow12.StylePriority.UseBackColor = false;
        this.xrTableRow12.StylePriority.UseFont = false;
        this.xrTableRow12.StylePriority.UseTextAlignment = false;
        this.xrTableRow12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableRow12.Weight = 0.37288139731197034D;
        // 
        // xrTableCell20
        // 
        this.xrTableCell20.Name = "xrTableCell20";
        this.xrTableCell20.Text = "Diajukan Oleh";
        this.xrTableCell20.Weight = 1D;
        // 
        // xrTableCell34
        // 
        this.xrTableCell34.Name = "xrTableCell34";
        this.xrTableCell34.StylePriority.UseTextAlignment = false;
        this.xrTableCell34.Text = "Mengetahui";
        this.xrTableCell34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell34.Weight = 2D;
        // 
        // xrTableRow13
        // 
        this.xrTableRow13.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell37,
            this.xrTableCell38,
            this.xrTableCell39});
        this.xrTableRow13.Name = "xrTableRow13";
        this.xrTableRow13.Weight = 1.8671186183130306D;
        // 
        // xrTableCell37
        // 
        this.xrTableCell37.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.picBoxMySign1});
        this.xrTableCell37.Name = "xrTableCell37";
        this.xrTableCell37.Weight = 1D;
        // 
        // picBoxMySign1
        // 
        this.picBoxMySign1.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.picBoxMySign1.Image = ((System.Drawing.Image)(resources.GetObject("picBoxMySign1.Image")));
        this.picBoxMySign1.LocationFloat = new DevExpress.Utils.PointFloat(22.91667F, 75.58746F);
        this.picBoxMySign1.Name = "picBoxMySign1";
        this.picBoxMySign1.SizeF = new System.Drawing.SizeF(164.5833F, 56.15431F);
        this.picBoxMySign1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
        this.picBoxMySign1.StylePriority.UseBorders = false;
        // 
        // xrTableCell38
        // 
        this.xrTableCell38.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblException1,
            this.lblException2,
            this.picBoxException2,
            this.picBoxException1});
        this.xrTableCell38.Name = "xrTableCell38";
        this.xrTableCell38.Weight = 1D;
        // 
        // lblException1
        // 
        this.lblException1.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.lblException1.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
        this.lblException1.ForeColor = System.Drawing.Color.Black;
        this.lblException1.LocationFloat = new DevExpress.Utils.PointFloat(72.86177F, 104.4918F);
        this.lblException1.Name = "lblException1";
        this.lblException1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.lblException1.SizeF = new System.Drawing.SizeF(132.8911F, 13.62502F);
        this.lblException1.StylePriority.UseBorders = false;
        this.lblException1.StylePriority.UseFont = false;
        this.lblException1.StylePriority.UseForeColor = false;
        this.lblException1.Text = "Approve datetime";
        this.lblException1.Visible = false;
        // 
        // lblException2
        // 
        this.lblException2.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.lblException2.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
        this.lblException2.ForeColor = System.Drawing.Color.Black;
        this.lblException2.LocationFloat = new DevExpress.Utils.PointFloat(72.86177F, 118.1168F);
        this.lblException2.Name = "lblException2";
        this.lblException2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.lblException2.SizeF = new System.Drawing.SizeF(132.8911F, 13.62502F);
        this.lblException2.StylePriority.UseBorders = false;
        this.lblException2.StylePriority.UseFont = false;
        this.lblException2.StylePriority.UseForeColor = false;
        this.lblException2.Text = "Note";
        this.lblException2.Visible = false;
        // 
        // picBoxException2
        // 
        this.picBoxException2.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.picBoxException2.Image = ((System.Drawing.Image)(resources.GetObject("picBoxException2.Image")));
        this.picBoxException2.LocationFloat = new DevExpress.Utils.PointFloat(9.332848F, 10.0001F);
        this.picBoxException2.Name = "picBoxException2";
        this.picBoxException2.SizeF = new System.Drawing.SizeF(95.49458F, 90.3646F);
        this.picBoxException2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
        this.picBoxException2.StylePriority.UseBorders = false;
        this.picBoxException2.Visible = false;
        // 
        // picBoxException1
        // 
        this.picBoxException1.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.picBoxException1.Image = ((System.Drawing.Image)(resources.GetObject("picBoxException1.Image")));
        this.picBoxException1.LocationFloat = new DevExpress.Utils.PointFloat(9.332848F, 10.00005F);
        this.picBoxException1.Name = "picBoxException1";
        this.picBoxException1.SizeF = new System.Drawing.SizeF(95.49458F, 90.3646F);
        this.picBoxException1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
        this.picBoxException1.StylePriority.UseBorders = false;
        this.picBoxException1.Visible = false;
        // 
        // xrTableCell39
        // 
        this.xrTableCell39.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblException3,
            this.lblException4,
            this.picBoxException4,
            this.picBoxException3});
        this.xrTableCell39.Name = "xrTableCell39";
        this.xrTableCell39.Weight = 1D;
        // 
        // lblException3
        // 
        this.lblException3.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.lblException3.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
        this.lblException3.ForeColor = System.Drawing.Color.Black;
        this.lblException3.LocationFloat = new DevExpress.Utils.PointFloat(72.8618F, 104.4917F);
        this.lblException3.Name = "lblException3";
        this.lblException3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.lblException3.SizeF = new System.Drawing.SizeF(132.8911F, 13.62502F);
        this.lblException3.StylePriority.UseBorders = false;
        this.lblException3.StylePriority.UseFont = false;
        this.lblException3.StylePriority.UseForeColor = false;
        this.lblException3.Text = "Approve datetime";
        this.lblException3.Visible = false;
        // 
        // lblException4
        // 
        this.lblException4.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.lblException4.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
        this.lblException4.ForeColor = System.Drawing.Color.Black;
        this.lblException4.LocationFloat = new DevExpress.Utils.PointFloat(72.8618F, 118.1167F);
        this.lblException4.Name = "lblException4";
        this.lblException4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.lblException4.SizeF = new System.Drawing.SizeF(132.8911F, 13.62502F);
        this.lblException4.StylePriority.UseBorders = false;
        this.lblException4.StylePriority.UseFont = false;
        this.lblException4.StylePriority.UseForeColor = false;
        this.lblException4.Text = "Note";
        this.lblException4.Visible = false;
        // 
        // picBoxException4
        // 
        this.picBoxException4.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.picBoxException4.Image = ((System.Drawing.Image)(resources.GetObject("picBoxException4.Image")));
        this.picBoxException4.LocationFloat = new DevExpress.Utils.PointFloat(10.00004F, 10.00005F);
        this.picBoxException4.Name = "picBoxException4";
        this.picBoxException4.SizeF = new System.Drawing.SizeF(95.49458F, 90.3646F);
        this.picBoxException4.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
        this.picBoxException4.StylePriority.UseBorders = false;
        this.picBoxException4.Visible = false;
        // 
        // picBoxException3
        // 
        this.picBoxException3.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.picBoxException3.Image = ((System.Drawing.Image)(resources.GetObject("picBoxException3.Image")));
        this.picBoxException3.LocationFloat = new DevExpress.Utils.PointFloat(10.0001F, 10.00004F);
        this.picBoxException3.Name = "picBoxException3";
        this.picBoxException3.SizeF = new System.Drawing.SizeF(95.49458F, 90.3646F);
        this.picBoxException3.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
        this.picBoxException3.StylePriority.UseBorders = false;
        this.picBoxException3.Visible = false;
        // 
        // xrTableRow6
        // 
        this.xrTableRow6.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell40,
            this.xrException16,
            this.xrException17});
        this.xrTableRow6.Font = new System.Drawing.Font("Tahoma", 8F);
        this.xrTableRow6.Name = "xrTableRow6";
        this.xrTableRow6.StylePriority.UseBorders = false;
        this.xrTableRow6.StylePriority.UseFont = false;
        this.xrTableRow6.StylePriority.UseTextAlignment = false;
        this.xrTableRow6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
        this.xrTableRow6.Weight = 0.31999998620345649D;
        // 
        // xrTableCell40
        // 
        this.xrTableCell40.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MemoFrom]")});
        this.xrTableCell40.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Underline);
        this.xrTableCell40.Name = "xrTableCell40";
        this.xrTableCell40.StylePriority.UseFont = false;
        this.xrTableCell40.StylePriority.UseTextAlignment = false;
        this.xrTableCell40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
        this.xrTableCell40.Weight = 1D;
        // 
        // xrException16
        // 
        this.xrException16.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Underline);
        this.xrException16.Name = "xrException16";
        this.xrException16.StylePriority.UseFont = false;
        this.xrException16.StylePriority.UseTextAlignment = false;
        this.xrException16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
        this.xrException16.Weight = 1D;
        // 
        // xrException17
        // 
        this.xrException17.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Underline);
        this.xrException17.Name = "xrException17";
        this.xrException17.StylePriority.UseFont = false;
        this.xrException17.StylePriority.UseTextAlignment = false;
        this.xrException17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
        this.xrException17.Weight = 1D;
        // 
        // xrTableRow25
        // 
        this.xrTableRow25.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableRow25.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell70,
            this.xrException711,
            this.xrException722});
        this.xrTableRow25.Font = new System.Drawing.Font("Tahoma", 8F);
        this.xrTableRow25.Name = "xrTableRow25";
        this.xrTableRow25.StylePriority.UseBorders = false;
        this.xrTableRow25.StylePriority.UseFont = false;
        this.xrTableRow25.StylePriority.UseTextAlignment = false;
        this.xrTableRow25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        this.xrTableRow25.Weight = 0.33333338458554851D;
        // 
        // xrTableCell70
        // 
        this.xrTableCell70.Font = new System.Drawing.Font("Tahoma", 8F);
        this.xrTableCell70.Name = "xrTableCell70";
        this.xrTableCell70.StylePriority.UseFont = false;
        this.xrTableCell70.StylePriority.UseTextAlignment = false;
        this.xrTableCell70.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell70.Weight = 1D;
        // 
        // xrException711
        // 
        this.xrException711.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
        this.xrException711.Name = "xrException711";
        this.xrException711.StylePriority.UseFont = false;
        this.xrException711.StylePriority.UseTextAlignment = false;
        this.xrException711.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        this.xrException711.Weight = 1D;
        // 
        // xrException722
        // 
        this.xrException722.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
        this.xrException722.Name = "xrException722";
        this.xrException722.StylePriority.UseFont = false;
        this.xrException722.StylePriority.UseTextAlignment = false;
        this.xrException722.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        this.xrException722.Weight = 1D;
        // 
        // xrLabel12
        // 
        this.xrLabel12.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DocNo]")});
        this.xrLabel12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(171.3804F, 302.2985F);
        this.xrLabel12.Name = "xrLabel12";
        this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel12.SizeF = new System.Drawing.SizeF(384.2504F, 18.83337F);
        this.xrLabel12.StylePriority.UseFont = false;
        this.xrLabel12.StylePriority.UseTextAlignment = false;
        this.xrLabel12.Text = "xrLabel12";
        this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrLabel4
        // 
        this.xrLabel4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DocDate]")});
        this.xrLabel4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(171.3804F, 321.1319F);
        this.xrLabel4.Name = "xrLabel4";
        this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel4.SizeF = new System.Drawing.SizeF(384.2504F, 18.83328F);
        this.xrLabel4.StylePriority.UseFont = false;
        this.xrLabel4.StylePriority.UseTextAlignment = false;
        this.xrLabel4.Text = "xrLabel13";
        this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrLabel4.TextFormatString = "{0:dd/MM/yyyy}";
        // 
        // DocKey
        // 
        this.DocKey.Description = "DocKey";
        this.DocKey.Name = "DocKey";
        this.DocKey.Type = typeof(int);
        this.DocKey.ValueInfo = "0";
        this.DocKey.Visible = false;
        // 
        // DocNo
        // 
        this.DocNo.Description = "DocNo";
        this.DocNo.Name = "DocNo";
        this.DocNo.Visible = false;
        // 
        // docInternalMemoException
        // 
        this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.GroupHeader1,
            this.DetailReport,
            this.ReportFooter});
        this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
        this.DataMember = "InternalMemo";
        this.DataSource = this.sqlDataSource1;
        this.Margins = new System.Drawing.Printing.Margins(47, 51, 54, 455);
        this.PageHeight = 1169;
        this.PageWidth = 827;
        this.PaperKind = System.Drawing.Printing.PaperKind.A4;
        this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.DocKey,
            this.DocNo});
        this.Version = "17.2";
        ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion
}
