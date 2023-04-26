using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for docInternalMemoPendingGiro
/// </summary>
public class docInternalMemoDeviasi : DevExpress.XtraReports.UI.XtraReport
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
    private XRLabel lblHeadertext;
    private XRTable xrTable4;
    private XRTableRow xrTableRow16;
    private XRTableCell xrTableCell45;
    private XRTableCell xrTableCell46;
    private XRTableCell xrTableCell47;
    private XRTableCell xrTableCell48;
    private XRTableCell xrTableCell19;
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
    private XRTableCell xrTableCell28;
    private XRLabel xrLabel11;
    private XRTable xrTable3;
    private XRTableRow xrTableRow12;
    private XRTableCell xrTableCell20;
    private XRTableCell xrTableCell34;
    private XRTableRow xrTableRow13;
    private XRTableCell xrTableCell37;
    private XRPictureBox picBoxMySign1;
    private XRTableCell xrTableCell38;
    private XRLabel lblDeviasi1;
    private XRLabel lblDeviasi2;
    private XRPictureBox picBoxDeviasi2;
    private XRPictureBox picBoxDeviasi1;
    private XRTableCell xrTableCell39;
    private XRLabel lblDeviasi3;
    private XRLabel lblDeviasi4;
    private XRPictureBox picBoxDeviasi4;
    private XRPictureBox picBoxDeviasi3;
    private XRTableRow xrTableRow6;
    private XRTableCell xrTableCell40;
    private XRTableCell xrTableCell16;
    private XRTableCell xrTableCell17;
    private XRTableRow xrTableRow25;
    private XRTableCell xrTableCell70;
    private XRTableCell xrTableCell711;
    private XRTableCell xrTableCell722;
    private XRLabel xrLabel12;
    private XRLabel xrLabel4;
    private XRTable xrTable6;
    private XRTableRow xrTableRow8;
    private XRTableCell xrTableCell36;
    private XRTableCell xrTableCell18;
    private XRTableCell xrTableCell21;
    private XRTableRow xrTableRow26;
    private XRTableCell xrTableCell73;
    private XRPictureBox picBoxDeviasi5;
    private XRPictureBox picBoxDeviasi6;
    private XRTableCell xrTableCell74;
    private XRLabel lblDeviasi5;
    private XRTableCell xrTableCell75;
    private XRLabel lblDeviasi6;
    private XRTableRow xrTableRow9;
    private XRTableCell xrTableCell22;
    private XRTableCell xrTableCell23;
    private XRTableCell xrTableCell29;
    private XRTableRow xrTableRow22;
    private XRTableCell xrTableCell611;
    private XRTableCell xrTableCell62;
    private XRTableCell xrTableCell63;
    private XRTableRow xrTableRow23;
    private XRTableCell xrTableCell641;
    private XRPictureBox picBoxDeviasi8;
    private XRPictureBox picBoxDeviasi7;
    private XRTableCell xrTableCell65;
    private XRLabel lblDeviasi7;
    private XRTableCell xrTableCell66;
    private XRLabel lblDeviasi8;
    private XRTableRow xrTableRow27;
    private XRTableCell xrTableCell644;
    private XRTableCell xrTableCell77;
    private XRTableCell xrTableCell78;
    private XRTableRow xrTableRow10;
    private XRTableCell xrTableCell300;
    private XRTableCell xrTableCell31;
    private XRTableCell xrTableCell32;
    private XRTableRow xrTableRow21;
    private XRTableCell xrTableCell581;
    private XRPictureBox picBoxDeviasi10;
    private XRPictureBox picBoxDeviasi9;
    private XRTableCell xrTableCell33;
    private XRLabel lblDeviasi9;
    private XRTableCell xrTableCell60;
    private XRLabel lblDeviasi10;
    private XRTableRow xrTableRow30;
    private XRTableCell xrTableCell833;
    private XRTableCell xrTableCell84;
    private XRTableCell xrTableCell85;
    private XRTableRow xrTableRow31;
    private XRTableCell xrTableCell866;
    private XRTableCell xrTableCell87;
    private XRTableCell xrTableCell88;
    private XRTableRow xrTableRow29;
    private XRTableCell xrTableCell76;
    private XRPictureBox picBoxDeviasi11;
    private XRPictureBox picBoxDeviasi12;
    private XRTableCell xrTableCell81;
    private XRLabel lblDeviasi11;
    private XRTableCell xrTableCell82;
    private XRLabel lblDeviasi12;
    private XRTableRow xrTableRow24;
    private XRTableCell xrTableCell35;
    private XRTableCell xrTableCell68;
    private XRTableCell xrTableCell69;
    private XRTableRow xrTableRow28;
    private XRTableCell xrTableCell677;
    private XRTableCell xrTableCell79;
    private XRTableCell xrTableCell80;
    private XRLabel xrLabel6;
    private XRTableRow xrTableRow11;
    private XRTableCell xrTableCell30;
    private XRTableCell xrTableCell61;
    private XRLabel lblDeviasi13;
    private XRTableCell xrTableCell64;
    private XRLabel lblDeviasi14;
    private XRTableRow xrTableRow14;
    private XRTableCell xrTableCell671;
    private XRTableCell xrTableCell71;
    private XRTableCell xrTableCell72;
    private XRTableRow xrTableRow32;
    private XRTableCell xrTableCell831;
    private XRTableCell xrTableCell86;
    private XRTableCell xrTableCell89;
    private XRTableRow xrTableRow33;
    private XRTableCell xrTableCell90;
    private XRPictureBox picBoxDeviasi15;
    private XRPictureBox picBoxDeviasi16;
    private XRTableCell xrTableCell91;
    private XRLabel lblDeviasi15;
    private XRTableCell xrTableCell92;
    private XRLabel lblDeviasi16;
    private XRTableRow xrTableRow34;
    private XRTableCell xrTableCell93;
    private XRTableCell xrTableCell94;
    private XRTableCell xrTableCell95;
    private XRTableRow xrTableRow35;
    private XRTableCell xrTableCell96;
    private XRTableCell xrTableCell97;
    private XRTableCell xrTableCell98;
    private XRPictureBox picBoxDeviasi14;
    private XRPictureBox picBoxDeviasi13;
    private XRTableRow xrTableRow36;
    private XRTableCell xrTableCell67;
    private XRTableCell xrTableCell83;
    private XRTableCell xrTableCell99;
    private XRTableRow xrTableRow37;
    private XRTableCell xrTableCell100;
    private XRTableCell xrTableCell101;
    private XRTableCell xrTableCell102;
    private XRTableRow xrTableRow38;
    private XRTableCell xrTableCell103;
    private XRPictureBox picBoxDeviasi62;
    private XRTableCell xrTableCell104;
    private XRLabel lblDeviasi60;
    private XRTableCell xrTableCell105;
    private XRLabel lblDeviasi70;
    private XRTableRow xrTableRow39;
    private XRTableCell xrTableCell180;
    private XRTableCell xrTableCell107;
    private XRTableCell xrTableCell108;
    private XRTableRow xrTableRow40;
    private XRTableCell xrTableCell183;
    private XRTableCell xrTableCell110;
    private XRTableCell xrTableCell111;
    private XRPictureBox picBoxDeviasi61;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public docInternalMemoDeviasi()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(docInternalMemoDeviasi));
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
            this.xrTableRow37 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell100 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell101 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell102 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow20 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell57 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell58 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell59 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow36 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell67 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell83 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell99 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable4 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow16 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell45 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell46 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell47 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell48 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblHeadertext = new DevExpress.XtraReports.UI.XRLabel();
            this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow7 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell26 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell27 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell28 = new DevExpress.XtraReports.UI.XRTableCell();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable6 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow8 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell36 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow26 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell73 = new DevExpress.XtraReports.UI.XRTableCell();
            this.picBoxDeviasi5 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.picBoxDeviasi6 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrTableCell74 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblDeviasi5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell75 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblDeviasi6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableRow9 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell29 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow22 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell611 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell62 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell63 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow23 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell641 = new DevExpress.XtraReports.UI.XRTableCell();
            this.picBoxDeviasi8 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.picBoxDeviasi7 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrTableCell65 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblDeviasi7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell66 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblDeviasi8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableRow27 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell644 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell77 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell78 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow10 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell300 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell31 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell32 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow21 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell581 = new DevExpress.XtraReports.UI.XRTableCell();
            this.picBoxDeviasi10 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.picBoxDeviasi9 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrTableCell33 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblDeviasi9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell60 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblDeviasi10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableRow30 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell833 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell84 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell85 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow31 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell866 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell87 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell88 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow29 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell76 = new DevExpress.XtraReports.UI.XRTableCell();
            this.picBoxDeviasi11 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.picBoxDeviasi12 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrTableCell81 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblDeviasi11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell82 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblDeviasi12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableRow24 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell35 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell68 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell69 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow28 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell677 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell79 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell80 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow11 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell30 = new DevExpress.XtraReports.UI.XRTableCell();
            this.picBoxDeviasi14 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.picBoxDeviasi13 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrTableCell61 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblDeviasi13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell64 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblDeviasi14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableRow14 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell671 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell71 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell72 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow32 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell831 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell86 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell89 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow33 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell90 = new DevExpress.XtraReports.UI.XRTableCell();
            this.picBoxDeviasi15 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.picBoxDeviasi16 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrTableCell91 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblDeviasi15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell92 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblDeviasi16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableRow34 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell93 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell94 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell95 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow35 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell96 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell97 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell98 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow38 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell103 = new DevExpress.XtraReports.UI.XRTableCell();
            this.picBoxDeviasi61 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.picBoxDeviasi62 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrTableCell104 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblDeviasi60 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell105 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblDeviasi70 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableRow39 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell180 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell107 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell108 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow40 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell183 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell110 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell111 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow12 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell34 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow13 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell37 = new DevExpress.XtraReports.UI.XRTableCell();
            this.picBoxMySign1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrTableCell38 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblDeviasi1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblDeviasi2 = new DevExpress.XtraReports.UI.XRLabel();
            this.picBoxDeviasi2 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.picBoxDeviasi1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrTableCell39 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblDeviasi3 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblDeviasi4 = new DevExpress.XtraReports.UI.XRLabel();
            this.picBoxDeviasi4 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.picBoxDeviasi3 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrTableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell40 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow25 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell70 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell711 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell722 = new DevExpress.XtraReports.UI.XRTableCell();
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
            this.Detail.Expanded = false;
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
            customSqlQuery3.Name = "InternalMemoDetailDeviasi";
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
            masterDetailInfo2.DetailQueryName = "InternalMemoDetailDeviasi";
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
            this.lblHeadertext});
            this.GroupHeader1.HeightF = 341.5625F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // xrLabel3
            // 
            this.xrLabel3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(32.58041F, 260.75F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(651.4251F, 26.12498F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "Rincian deviasi, antara lain:";
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
            this.xrTableRow37,
            this.xrTableRow20,
            this.xrTableRow36});
            this.xrTable5.SizeF = new System.Drawing.SizeF(651.4251F, 175F);
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
            this.xrTableCell44.Text = "No. PFK";
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
            // xrTableRow37
            // 
            this.xrTableRow37.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell100,
            this.xrTableCell101,
            this.xrTableCell102});
            this.xrTableRow37.Name = "xrTableRow37";
            this.xrTableRow37.Weight = 1D;
            // 
            // xrTableCell100
            // 
            this.xrTableCell100.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell100.Name = "xrTableCell100";
            this.xrTableCell100.StylePriority.UseBorders = false;
            this.xrTableCell100.Text = "Kategori";
            this.xrTableCell100.Weight = 1D;
            // 
            // xrTableCell101
            // 
            this.xrTableCell101.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell101.Name = "xrTableCell101";
            this.xrTableCell101.StylePriority.UseBorders = false;
            this.xrTableCell101.Text = ":";
            this.xrTableCell101.Weight = 0.11731998813074063D;
            // 
            // xrTableCell102
            // 
            this.xrTableCell102.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell102.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[KategoriDeviasi]")});
            this.xrTableCell102.Name = "xrTableCell102";
            this.xrTableCell102.StylePriority.UseBorders = false;
            this.xrTableCell102.Weight = 1.8826800118692595D;
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
            // xrTableRow36
            // 
            this.xrTableRow36.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell67,
            this.xrTableCell83,
            this.xrTableCell99});
            this.xrTableRow36.Name = "xrTableRow36";
            this.xrTableRow36.Weight = 1D;
            // 
            // xrTableCell67
            // 
            this.xrTableCell67.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell67.Name = "xrTableCell67";
            this.xrTableCell67.StylePriority.UseBorders = false;
            this.xrTableCell67.Text = "Perpanjangan";
            this.xrTableCell67.Weight = 1D;
            // 
            // xrTableCell83
            // 
            this.xrTableCell83.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell83.Name = "xrTableCell83";
            this.xrTableCell83.StylePriority.UseBorders = false;
            this.xrTableCell83.Text = ":";
            this.xrTableCell83.Weight = 0.11731998813074063D;
            // 
            // xrTableCell99
            // 
            this.xrTableCell99.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell99.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DeviasiTBO]")});
            this.xrTableCell99.Name = "xrTableCell99";
            this.xrTableCell99.StylePriority.UseBorders = false;
            this.xrTableCell99.Text = "[]";
            this.xrTableCell99.Weight = 1.8826800118692595D;
            // 
            // xrTable4
            // 
            this.xrTable4.Font = new System.Drawing.Font("Tahoma", 8F);
            this.xrTable4.LocationFloat = new DevExpress.Utils.PointFloat(31.53868F, 299.375F);
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
            this.xrTableCell48,
            this.xrTableCell19});
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
            this.xrTableCell46.Weight = 0.89458100495006954D;
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
            this.xrTableCell47.Weight = 0.9823977010933127D;
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
            this.xrTableCell48.Text = "Action Plan";
            this.xrTableCell48.Weight = 0.90676846594966376D;
            // 
            // xrTableCell19
            // 
            this.xrTableCell19.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell19.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell19.Name = "xrTableCell19";
            this.xrTableCell19.StylePriority.UseBorders = false;
            this.xrTableCell19.StylePriority.UseFont = false;
            this.xrTableCell19.Text = "Deadline";
            this.xrTableCell19.Weight = 0.907607048056416D;
            // 
            // lblHeadertext
            // 
            this.lblHeadertext.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadertext.LocationFloat = new DevExpress.Utils.PointFloat(32.57914F, 26.12499F);
            this.lblHeadertext.Name = "lblHeadertext";
            this.lblHeadertext.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblHeadertext.SizeF = new System.Drawing.SizeF(651.4251F, 26.12498F);
            this.lblHeadertext.StylePriority.UseFont = false;
            this.lblHeadertext.StylePriority.UseTextAlignment = false;
            this.lblHeadertext.Text = "Bersama ini kami mangajukan permohonan persetujuan penyimpangan bagi debitur deng" +
    "an rincian berikut:";
            this.lblHeadertext.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // DetailReport
            // 
            this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail1});
            this.DetailReport.DataMember = "InternalMemoDetailDeviasi";
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
            this.xrTableCell27,
            this.xrTableCell28});
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
            this.xrTableCell25.Weight = 0.89641239748395651D;
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
            this.xrTableCell26.Text = "Nama Bank";
            this.xrTableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell26.Weight = 0.97766233551900128D;
            // 
            // xrTableCell27
            // 
            this.xrTableCell27.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell27.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Action]")});
            this.xrTableCell27.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell27.Multiline = true;
            this.xrTableCell27.Name = "xrTableCell27";
            this.xrTableCell27.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
            this.xrTableCell27.StylePriority.UseBorders = false;
            this.xrTableCell27.StylePriority.UseFont = false;
            this.xrTableCell27.StylePriority.UsePadding = false;
            this.xrTableCell27.StylePriority.UseTextAlignment = false;
            this.xrTableCell27.Text = "No. Giro";
            this.xrTableCell27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell27.Weight = 0.90822275626008808D;
            // 
            // xrTableCell28
            // 
            this.xrTableCell28.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell28.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Deadline]")});
            this.xrTableCell28.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell28.Name = "xrTableCell28";
            this.xrTableCell28.StylePriority.UseBorders = false;
            this.xrTableCell28.StylePriority.UseFont = false;
            this.xrTableCell28.StylePriority.UseTextAlignment = false;
            this.xrTableCell28.Text = "Nominal";
            this.xrTableCell28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell28.TextFormatString = "{0:dd MMMM yyyy}";
            this.xrTableCell28.Weight = 0.90906344397819272D;
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
            this.ReportFooter.HeightF = 1793.911F;
            this.ReportFooter.Name = "ReportFooter";
            this.ReportFooter.StylePriority.UseFont = false;
            // 
            // xrLabel6
            // 
            this.xrLabel6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(49.95823F, 10.00001F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(618.9752F, 26.12497F);
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
            this.xrTable6.LocationFloat = new DevExpress.Utils.PointFloat(36.74704F, 378.5789F);
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
            this.xrTableRow38,
            this.xrTableRow39,
            this.xrTableRow40});
            this.xrTable6.SizeF = new System.Drawing.SizeF(647.2585F, 1415.332F);
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
            this.xrTableCell18.Weight = 1D;
            // 
            // xrTableCell21
            // 
            this.xrTableCell21.CanGrow = false;
            this.xrTableCell21.Name = "xrTableCell21";
            this.xrTableCell21.Text = "Disposisi";
            this.xrTableCell21.Weight = 1D;
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
            this.picBoxDeviasi5,
            this.picBoxDeviasi6});
            this.xrTableCell73.Name = "xrTableCell73";
            this.xrTableCell73.Text = " ";
            this.xrTableCell73.Weight = 1D;
            // 
            // picBoxDeviasi5
            // 
            this.picBoxDeviasi5.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxDeviasi5.Image = ((System.Drawing.Image)(resources.GetObject("picBoxDeviasi5.Image")));
            this.picBoxDeviasi5.LocationFloat = new DevExpress.Utils.PointFloat(60.70722F, 26.22662F);
            this.picBoxDeviasi5.Name = "picBoxDeviasi5";
            this.picBoxDeviasi5.SizeF = new System.Drawing.SizeF(95.49458F, 90.3646F);
            this.picBoxDeviasi5.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxDeviasi5.StylePriority.UseBorders = false;
            this.picBoxDeviasi5.Visible = false;
            // 
            // picBoxDeviasi6
            // 
            this.picBoxDeviasi6.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxDeviasi6.Image = ((System.Drawing.Image)(resources.GetObject("picBoxDeviasi6.Image")));
            this.picBoxDeviasi6.LocationFloat = new DevExpress.Utils.PointFloat(60.70722F, 26.22655F);
            this.picBoxDeviasi6.Name = "picBoxDeviasi6";
            this.picBoxDeviasi6.SizeF = new System.Drawing.SizeF(95.49458F, 90.3646F);
            this.picBoxDeviasi6.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxDeviasi6.StylePriority.UseBorders = false;
            this.picBoxDeviasi6.Visible = false;
            // 
            // xrTableCell74
            // 
            this.xrTableCell74.CanGrow = false;
            this.xrTableCell74.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblDeviasi5});
            this.xrTableCell74.Name = "xrTableCell74";
            this.xrTableCell74.Text = " ";
            this.xrTableCell74.Weight = 1D;
            // 
            // lblDeviasi5
            // 
            this.lblDeviasi5.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblDeviasi5.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblDeviasi5.ForeColor = System.Drawing.Color.DarkGray;
            this.lblDeviasi5.LocationFloat = new DevExpress.Utils.PointFloat(10.00004F, 52.96605F);
            this.lblDeviasi5.Name = "lblDeviasi5";
            this.lblDeviasi5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblDeviasi5.SizeF = new System.Drawing.SizeF(195.7528F, 13.62499F);
            this.lblDeviasi5.StylePriority.UseBorders = false;
            this.lblDeviasi5.StylePriority.UseFont = false;
            this.lblDeviasi5.StylePriority.UseForeColor = false;
            this.lblDeviasi5.StylePriority.UseTextAlignment = false;
            this.lblDeviasi5.Text = "Approve datetime";
            this.lblDeviasi5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lblDeviasi5.Visible = false;
            // 
            // xrTableCell75
            // 
            this.xrTableCell75.CanGrow = false;
            this.xrTableCell75.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblDeviasi6});
            this.xrTableCell75.Name = "xrTableCell75";
            this.xrTableCell75.Text = " ";
            this.xrTableCell75.Weight = 1D;
            // 
            // lblDeviasi6
            // 
            this.lblDeviasi6.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblDeviasi6.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblDeviasi6.ForeColor = System.Drawing.Color.DarkGray;
            this.lblDeviasi6.LocationFloat = new DevExpress.Utils.PointFloat(12.33139F, 26.22649F);
            this.lblDeviasi6.Name = "lblDeviasi6";
            this.lblDeviasi6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblDeviasi6.SizeF = new System.Drawing.SizeF(193.4216F, 90.36465F);
            this.lblDeviasi6.StylePriority.UseBorders = false;
            this.lblDeviasi6.StylePriority.UseFont = false;
            this.lblDeviasi6.StylePriority.UseForeColor = false;
            this.lblDeviasi6.StylePriority.UseTextAlignment = false;
            this.lblDeviasi6.Text = "Note";
            this.lblDeviasi6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lblDeviasi6.Visible = false;
            // 
            // xrTableRow9
            // 
            this.xrTableRow9.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell22,
            this.xrTableCell23,
            this.xrTableCell29});
            this.xrTableRow9.Font = new System.Drawing.Font("Tahoma", 8F);
            this.xrTableRow9.Name = "xrTableRow9";
            this.xrTableRow9.StylePriority.UseFont = false;
            this.xrTableRow9.StylePriority.UseTextAlignment = false;
            this.xrTableRow9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            this.xrTableRow9.Weight = 0.21418133076930235D;
            // 
            // xrTableCell22
            // 
            this.xrTableCell22.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell22.CanGrow = false;
            this.xrTableCell22.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Underline);
            this.xrTableCell22.Name = "xrTableCell22";
            this.xrTableCell22.StylePriority.UseBorders = false;
            this.xrTableCell22.StylePriority.UseFont = false;
            this.xrTableCell22.StylePriority.UseTextAlignment = false;
            this.xrTableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            this.xrTableCell22.Weight = 1D;
            // 
            // xrTableCell23
            // 
            this.xrTableCell23.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell23.CanGrow = false;
            this.xrTableCell23.Name = "xrTableCell23";
            this.xrTableCell23.StylePriority.UseBorders = false;
            this.xrTableCell23.Weight = 1D;
            // 
            // xrTableCell29
            // 
            this.xrTableCell29.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell29.CanGrow = false;
            this.xrTableCell29.Name = "xrTableCell29";
            this.xrTableCell29.StylePriority.UseBorders = false;
            this.xrTableCell29.Weight = 1D;
            // 
            // xrTableRow22
            // 
            this.xrTableRow22.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell611,
            this.xrTableCell62,
            this.xrTableCell63});
            this.xrTableRow22.Font = new System.Drawing.Font("Tahoma", 8F);
            this.xrTableRow22.Name = "xrTableRow22";
            this.xrTableRow22.StylePriority.UseFont = false;
            this.xrTableRow22.StylePriority.UseTextAlignment = false;
            this.xrTableRow22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableRow22.Weight = 0.21760327302164578D;
            // 
            // xrTableCell611
            // 
            this.xrTableCell611.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell611.CanGrow = false;
            this.xrTableCell611.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell611.Name = "xrTableCell611";
            this.xrTableCell611.StylePriority.UseBorders = false;
            this.xrTableCell611.StylePriority.UseFont = false;
            this.xrTableCell611.StylePriority.UseTextAlignment = false;
            this.xrTableCell611.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell611.Weight = 1D;
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
            this.xrTableCell62.Weight = 1D;
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
            this.xrTableCell63.Weight = 1D;
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
            this.picBoxDeviasi8,
            this.picBoxDeviasi7});
            this.xrTableCell641.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Underline);
            this.xrTableCell641.Name = "xrTableCell641";
            this.xrTableCell641.StylePriority.UseFont = false;
            this.xrTableCell641.StylePriority.UseTextAlignment = false;
            this.xrTableCell641.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            this.xrTableCell641.Weight = 1D;
            // 
            // picBoxDeviasi8
            // 
            this.picBoxDeviasi8.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxDeviasi8.Image = ((System.Drawing.Image)(resources.GetObject("picBoxDeviasi8.Image")));
            this.picBoxDeviasi8.LocationFloat = new DevExpress.Utils.PointFloat(60.70722F, 24.58324F);
            this.picBoxDeviasi8.Name = "picBoxDeviasi8";
            this.picBoxDeviasi8.SizeF = new System.Drawing.SizeF(95.49458F, 90.3646F);
            this.picBoxDeviasi8.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxDeviasi8.StylePriority.UseBorders = false;
            this.picBoxDeviasi8.Visible = false;
            // 
            // picBoxDeviasi7
            // 
            this.picBoxDeviasi7.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxDeviasi7.Image = ((System.Drawing.Image)(resources.GetObject("picBoxDeviasi7.Image")));
            this.picBoxDeviasi7.LocationFloat = new DevExpress.Utils.PointFloat(60.70722F, 24.58331F);
            this.picBoxDeviasi7.Name = "picBoxDeviasi7";
            this.picBoxDeviasi7.SizeF = new System.Drawing.SizeF(95.49458F, 90.3646F);
            this.picBoxDeviasi7.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxDeviasi7.StylePriority.UseBorders = false;
            this.picBoxDeviasi7.Visible = false;
            // 
            // xrTableCell65
            // 
            this.xrTableCell65.CanGrow = false;
            this.xrTableCell65.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblDeviasi7});
            this.xrTableCell65.Name = "xrTableCell65";
            this.xrTableCell65.Weight = 1D;
            // 
            // lblDeviasi7
            // 
            this.lblDeviasi7.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblDeviasi7.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblDeviasi7.ForeColor = System.Drawing.Color.DarkGray;
            this.lblDeviasi7.LocationFloat = new DevExpress.Utils.PointFloat(10.00004F, 58.53119F);
            this.lblDeviasi7.Name = "lblDeviasi7";
            this.lblDeviasi7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblDeviasi7.SizeF = new System.Drawing.SizeF(195.7528F, 13.62495F);
            this.lblDeviasi7.StylePriority.UseBorders = false;
            this.lblDeviasi7.StylePriority.UseFont = false;
            this.lblDeviasi7.StylePriority.UseForeColor = false;
            this.lblDeviasi7.StylePriority.UseTextAlignment = false;
            this.lblDeviasi7.Text = "Approve datetime";
            this.lblDeviasi7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lblDeviasi7.Visible = false;
            // 
            // xrTableCell66
            // 
            this.xrTableCell66.CanGrow = false;
            this.xrTableCell66.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblDeviasi8});
            this.xrTableCell66.Name = "xrTableCell66";
            this.xrTableCell66.Weight = 1D;
            // 
            // lblDeviasi8
            // 
            this.lblDeviasi8.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblDeviasi8.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblDeviasi8.ForeColor = System.Drawing.Color.DarkGray;
            this.lblDeviasi8.LocationFloat = new DevExpress.Utils.PointFloat(12.33139F, 24.58344F);
            this.lblDeviasi8.Name = "lblDeviasi8";
            this.lblDeviasi8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblDeviasi8.SizeF = new System.Drawing.SizeF(193.4215F, 90.36459F);
            this.lblDeviasi8.StylePriority.UseBorders = false;
            this.lblDeviasi8.StylePriority.UseFont = false;
            this.lblDeviasi8.StylePriority.UseForeColor = false;
            this.lblDeviasi8.StylePriority.UseTextAlignment = false;
            this.lblDeviasi8.Text = "Note";
            this.lblDeviasi8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lblDeviasi8.Visible = false;
            // 
            // xrTableRow27
            // 
            this.xrTableRow27.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell644,
            this.xrTableCell77,
            this.xrTableCell78});
            this.xrTableRow27.Name = "xrTableRow27";
            this.xrTableRow27.Weight = 0.24694500151341417D;
            // 
            // xrTableCell644
            // 
            this.xrTableCell644.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell644.CanGrow = false;
            this.xrTableCell644.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell644.Name = "xrTableCell644";
            this.xrTableCell644.StylePriority.UseBorders = false;
            this.xrTableCell644.StylePriority.UseFont = false;
            this.xrTableCell644.StylePriority.UseTextAlignment = false;
            this.xrTableCell644.Text = " ";
            this.xrTableCell644.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            this.xrTableCell644.Weight = 1D;
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
            this.xrTableCell77.Weight = 1D;
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
            this.xrTableCell78.Weight = 1D;
            // 
            // xrTableRow10
            // 
            this.xrTableRow10.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableRow10.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell300,
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
            // xrTableCell300
            // 
            this.xrTableCell300.CanGrow = false;
            this.xrTableCell300.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell300.Name = "xrTableCell300";
            this.xrTableCell300.StylePriority.UseFont = false;
            this.xrTableCell300.StylePriority.UseTextAlignment = false;
            this.xrTableCell300.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell300.Weight = 1D;
            // 
            // xrTableCell31
            // 
            this.xrTableCell31.CanGrow = false;
            this.xrTableCell31.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell31.Name = "xrTableCell31";
            this.xrTableCell31.StylePriority.UseFont = false;
            this.xrTableCell31.StylePriority.UseTextAlignment = false;
            this.xrTableCell31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell31.Weight = 1D;
            // 
            // xrTableCell32
            // 
            this.xrTableCell32.CanGrow = false;
            this.xrTableCell32.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell32.Name = "xrTableCell32";
            this.xrTableCell32.StylePriority.UseFont = false;
            this.xrTableCell32.StylePriority.UseTextAlignment = false;
            this.xrTableCell32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell32.Weight = 1D;
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
            this.picBoxDeviasi10,
            this.picBoxDeviasi9});
            this.xrTableCell581.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Underline);
            this.xrTableCell581.Name = "xrTableCell581";
            this.xrTableCell581.StylePriority.UseFont = false;
            this.xrTableCell581.StylePriority.UseTextAlignment = false;
            this.xrTableCell581.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            this.xrTableCell581.Weight = 1D;
            // 
            // picBoxDeviasi10
            // 
            this.picBoxDeviasi10.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxDeviasi10.Image = ((System.Drawing.Image)(resources.GetObject("picBoxDeviasi10.Image")));
            this.picBoxDeviasi10.LocationFloat = new DevExpress.Utils.PointFloat(60.70722F, 24.75688F);
            this.picBoxDeviasi10.Name = "picBoxDeviasi10";
            this.picBoxDeviasi10.SizeF = new System.Drawing.SizeF(95.49458F, 90.3646F);
            this.picBoxDeviasi10.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxDeviasi10.StylePriority.UseBorders = false;
            this.picBoxDeviasi10.Visible = false;
            // 
            // picBoxDeviasi9
            // 
            this.picBoxDeviasi9.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxDeviasi9.Image = ((System.Drawing.Image)(resources.GetObject("picBoxDeviasi9.Image")));
            this.picBoxDeviasi9.LocationFloat = new DevExpress.Utils.PointFloat(60.70722F, 24.75696F);
            this.picBoxDeviasi9.Name = "picBoxDeviasi9";
            this.picBoxDeviasi9.SizeF = new System.Drawing.SizeF(95.49458F, 90.3646F);
            this.picBoxDeviasi9.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxDeviasi9.StylePriority.UseBorders = false;
            this.picBoxDeviasi9.Visible = false;
            // 
            // xrTableCell33
            // 
            this.xrTableCell33.CanGrow = false;
            this.xrTableCell33.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblDeviasi9});
            this.xrTableCell33.Name = "xrTableCell33";
            this.xrTableCell33.Weight = 1D;
            // 
            // lblDeviasi9
            // 
            this.lblDeviasi9.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblDeviasi9.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblDeviasi9.ForeColor = System.Drawing.Color.DarkGray;
            this.lblDeviasi9.LocationFloat = new DevExpress.Utils.PointFloat(9.332789F, 62.69794F);
            this.lblDeviasi9.Name = "lblDeviasi9";
            this.lblDeviasi9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblDeviasi9.SizeF = new System.Drawing.SizeF(196.42F, 13.62498F);
            this.lblDeviasi9.StylePriority.UseBorders = false;
            this.lblDeviasi9.StylePriority.UseFont = false;
            this.lblDeviasi9.StylePriority.UseForeColor = false;
            this.lblDeviasi9.StylePriority.UseTextAlignment = false;
            this.lblDeviasi9.Text = "Approve datetime";
            this.lblDeviasi9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lblDeviasi9.Visible = false;
            // 
            // xrTableCell60
            // 
            this.xrTableCell60.CanGrow = false;
            this.xrTableCell60.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblDeviasi10});
            this.xrTableCell60.Name = "xrTableCell60";
            this.xrTableCell60.Weight = 1D;
            // 
            // lblDeviasi10
            // 
            this.lblDeviasi10.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblDeviasi10.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblDeviasi10.ForeColor = System.Drawing.Color.DarkGray;
            this.lblDeviasi10.LocationFloat = new DevExpress.Utils.PointFloat(12.33139F, 24.75688F);
            this.lblDeviasi10.Name = "lblDeviasi10";
            this.lblDeviasi10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblDeviasi10.SizeF = new System.Drawing.SizeF(193.4215F, 100.0794F);
            this.lblDeviasi10.StylePriority.UseBorders = false;
            this.lblDeviasi10.StylePriority.UseFont = false;
            this.lblDeviasi10.StylePriority.UseForeColor = false;
            this.lblDeviasi10.StylePriority.UseTextAlignment = false;
            this.lblDeviasi10.Text = "Note";
            this.lblDeviasi10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lblDeviasi10.Visible = false;
            // 
            // xrTableRow30
            // 
            this.xrTableRow30.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell833,
            this.xrTableCell84,
            this.xrTableCell85});
            this.xrTableRow30.Name = "xrTableRow30";
            this.xrTableRow30.Weight = 0.30562159232593311D;
            // 
            // xrTableCell833
            // 
            this.xrTableCell833.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell833.CanGrow = false;
            this.xrTableCell833.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Underline);
            this.xrTableCell833.Name = "xrTableCell833";
            this.xrTableCell833.StylePriority.UseBorders = false;
            this.xrTableCell833.StylePriority.UseFont = false;
            this.xrTableCell833.StylePriority.UseTextAlignment = false;
            this.xrTableCell833.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            this.xrTableCell833.Weight = 1D;
            // 
            // xrTableCell84
            // 
            this.xrTableCell84.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell84.CanGrow = false;
            this.xrTableCell84.Name = "xrTableCell84";
            this.xrTableCell84.StylePriority.UseBorders = false;
            this.xrTableCell84.Weight = 1D;
            // 
            // xrTableCell85
            // 
            this.xrTableCell85.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell85.CanGrow = false;
            this.xrTableCell85.Name = "xrTableCell85";
            this.xrTableCell85.StylePriority.UseBorders = false;
            this.xrTableCell85.Weight = 1D;
            // 
            // xrTableRow31
            // 
            this.xrTableRow31.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell866,
            this.xrTableCell87,
            this.xrTableCell88});
            this.xrTableRow31.Name = "xrTableRow31";
            this.xrTableRow31.Weight = 0.26650217303632429D;
            // 
            // xrTableCell866
            // 
            this.xrTableCell866.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell866.CanGrow = false;
            this.xrTableCell866.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell866.Name = "xrTableCell866";
            this.xrTableCell866.StylePriority.UseBorders = false;
            this.xrTableCell866.StylePriority.UseFont = false;
            this.xrTableCell866.StylePriority.UseTextAlignment = false;
            this.xrTableCell866.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell866.Weight = 1D;
            // 
            // xrTableCell87
            // 
            this.xrTableCell87.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell87.CanGrow = false;
            this.xrTableCell87.Name = "xrTableCell87";
            this.xrTableCell87.StylePriority.UseBorders = false;
            this.xrTableCell87.Weight = 1D;
            // 
            // xrTableCell88
            // 
            this.xrTableCell88.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell88.CanGrow = false;
            this.xrTableCell88.Name = "xrTableCell88";
            this.xrTableCell88.StylePriority.UseBorders = false;
            this.xrTableCell88.Weight = 1D;
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
            this.picBoxDeviasi11,
            this.picBoxDeviasi12});
            this.xrTableCell76.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Underline);
            this.xrTableCell76.Name = "xrTableCell76";
            this.xrTableCell76.StylePriority.UseFont = false;
            this.xrTableCell76.StylePriority.UseTextAlignment = false;
            this.xrTableCell76.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            this.xrTableCell76.Weight = 1D;
            // 
            // picBoxDeviasi11
            // 
            this.picBoxDeviasi11.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxDeviasi11.Image = ((System.Drawing.Image)(resources.GetObject("picBoxDeviasi11.Image")));
            this.picBoxDeviasi11.LocationFloat = new DevExpress.Utils.PointFloat(60.70722F, 24.73952F);
            this.picBoxDeviasi11.Name = "picBoxDeviasi11";
            this.picBoxDeviasi11.SizeF = new System.Drawing.SizeF(95.49458F, 90.3646F);
            this.picBoxDeviasi11.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxDeviasi11.StylePriority.UseBorders = false;
            this.picBoxDeviasi11.Visible = false;
            // 
            // picBoxDeviasi12
            // 
            this.picBoxDeviasi12.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxDeviasi12.Image = ((System.Drawing.Image)(resources.GetObject("picBoxDeviasi12.Image")));
            this.picBoxDeviasi12.LocationFloat = new DevExpress.Utils.PointFloat(60.12912F, 24.73948F);
            this.picBoxDeviasi12.Name = "picBoxDeviasi12";
            this.picBoxDeviasi12.SizeF = new System.Drawing.SizeF(95.49458F, 90.3646F);
            this.picBoxDeviasi12.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxDeviasi12.StylePriority.UseBorders = false;
            this.picBoxDeviasi12.Visible = false;
            // 
            // xrTableCell81
            // 
            this.xrTableCell81.CanGrow = false;
            this.xrTableCell81.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblDeviasi11});
            this.xrTableCell81.Name = "xrTableCell81";
            this.xrTableCell81.Weight = 1D;
            // 
            // lblDeviasi11
            // 
            this.lblDeviasi11.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblDeviasi11.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblDeviasi11.ForeColor = System.Drawing.Color.DarkGray;
            this.lblDeviasi11.LocationFloat = new DevExpress.Utils.PointFloat(9.666412F, 63.10929F);
            this.lblDeviasi11.Name = "lblDeviasi11";
            this.lblDeviasi11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblDeviasi11.SizeF = new System.Drawing.SizeF(196.42F, 13.62498F);
            this.lblDeviasi11.StylePriority.UseBorders = false;
            this.lblDeviasi11.StylePriority.UseFont = false;
            this.lblDeviasi11.StylePriority.UseForeColor = false;
            this.lblDeviasi11.StylePriority.UseTextAlignment = false;
            this.lblDeviasi11.Text = "Approve datetime";
            this.lblDeviasi11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lblDeviasi11.Visible = false;
            // 
            // xrTableCell82
            // 
            this.xrTableCell82.CanGrow = false;
            this.xrTableCell82.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblDeviasi12});
            this.xrTableCell82.Name = "xrTableCell82";
            this.xrTableCell82.Weight = 1D;
            // 
            // lblDeviasi12
            // 
            this.lblDeviasi12.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblDeviasi12.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblDeviasi12.ForeColor = System.Drawing.Color.DarkGray;
            this.lblDeviasi12.LocationFloat = new DevExpress.Utils.PointFloat(11.16562F, 24.73952F);
            this.lblDeviasi12.Name = "lblDeviasi12";
            this.lblDeviasi12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblDeviasi12.SizeF = new System.Drawing.SizeF(193.4215F, 90.36472F);
            this.lblDeviasi12.StylePriority.UseBorders = false;
            this.lblDeviasi12.StylePriority.UseFont = false;
            this.lblDeviasi12.StylePriority.UseForeColor = false;
            this.lblDeviasi12.StylePriority.UseTextAlignment = false;
            this.lblDeviasi12.Text = "Note";
            this.lblDeviasi12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lblDeviasi12.Visible = false;
            // 
            // xrTableRow24
            // 
            this.xrTableRow24.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableRow24.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell35,
            this.xrTableCell68,
            this.xrTableCell69});
            this.xrTableRow24.Name = "xrTableRow24";
            this.xrTableRow24.StylePriority.UseBorders = false;
            this.xrTableRow24.StylePriority.UseTextAlignment = false;
            this.xrTableRow24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableRow24.Weight = 0.31540799157783417D;
            // 
            // xrTableCell35
            // 
            this.xrTableCell35.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell35.CanGrow = false;
            this.xrTableCell35.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell35.Name = "xrTableCell35";
            this.xrTableCell35.StylePriority.UseBorders = false;
            this.xrTableCell35.StylePriority.UseFont = false;
            this.xrTableCell35.StylePriority.UseTextAlignment = false;
            this.xrTableCell35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            this.xrTableCell35.Weight = 1D;
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
            this.xrTableCell68.Weight = 1D;
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
            this.xrTableCell69.Weight = 1D;
            // 
            // xrTableRow28
            // 
            this.xrTableRow28.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell677,
            this.xrTableCell79,
            this.xrTableCell80});
            this.xrTableRow28.Name = "xrTableRow28";
            this.xrTableRow28.Weight = 0.28606799732765426D;
            // 
            // xrTableCell677
            // 
            this.xrTableCell677.CanGrow = false;
            this.xrTableCell677.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell677.Name = "xrTableCell677";
            this.xrTableCell677.StylePriority.UseFont = false;
            this.xrTableCell677.StylePriority.UseTextAlignment = false;
            this.xrTableCell677.Text = " ";
            this.xrTableCell677.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell677.Weight = 1D;
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
            this.xrTableCell79.Weight = 1D;
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
            this.xrTableCell80.Weight = 1D;
            // 
            // xrTableRow11
            // 
            this.xrTableRow11.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell30,
            this.xrTableCell61,
            this.xrTableCell64});
            this.xrTableRow11.Name = "xrTableRow11";
            this.xrTableRow11.Weight = 1.3150837254671992D;
            // 
            // xrTableCell30
            // 
            this.xrTableCell30.CanGrow = false;
            this.xrTableCell30.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.picBoxDeviasi14,
            this.picBoxDeviasi13});
            this.xrTableCell30.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell30.Name = "xrTableCell30";
            this.xrTableCell30.StylePriority.UseFont = false;
            this.xrTableCell30.StylePriority.UseTextAlignment = false;
            this.xrTableCell30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell30.Weight = 1D;
            // 
            // picBoxDeviasi14
            // 
            this.picBoxDeviasi14.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxDeviasi14.Image = ((System.Drawing.Image)(resources.GetObject("picBoxDeviasi14.Image")));
            this.picBoxDeviasi14.LocationFloat = new DevExpress.Utils.PointFloat(60.12912F, 22.3451F);
            this.picBoxDeviasi14.Name = "picBoxDeviasi14";
            this.picBoxDeviasi14.SizeF = new System.Drawing.SizeF(95.49458F, 90.3646F);
            this.picBoxDeviasi14.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxDeviasi14.StylePriority.UseBorders = false;
            this.picBoxDeviasi14.Visible = false;
            // 
            // picBoxDeviasi13
            // 
            this.picBoxDeviasi13.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxDeviasi13.Image = ((System.Drawing.Image)(resources.GetObject("picBoxDeviasi13.Image")));
            this.picBoxDeviasi13.LocationFloat = new DevExpress.Utils.PointFloat(60.12912F, 22.3451F);
            this.picBoxDeviasi13.Name = "picBoxDeviasi13";
            this.picBoxDeviasi13.SizeF = new System.Drawing.SizeF(95.49458F, 90.3646F);
            this.picBoxDeviasi13.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxDeviasi13.StylePriority.UseBorders = false;
            this.picBoxDeviasi13.Visible = false;
            // 
            // xrTableCell61
            // 
            this.xrTableCell61.CanGrow = false;
            this.xrTableCell61.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblDeviasi13});
            this.xrTableCell61.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell61.Name = "xrTableCell61";
            this.xrTableCell61.StylePriority.UseFont = false;
            this.xrTableCell61.StylePriority.UseTextAlignment = false;
            this.xrTableCell61.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell61.Weight = 1D;
            // 
            // lblDeviasi13
            // 
            this.lblDeviasi13.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblDeviasi13.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblDeviasi13.ForeColor = System.Drawing.Color.DarkGray;
            this.lblDeviasi13.LocationFloat = new DevExpress.Utils.PointFloat(9.666412F, 55.32478F);
            this.lblDeviasi13.Name = "lblDeviasi13";
            this.lblDeviasi13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblDeviasi13.SizeF = new System.Drawing.SizeF(196.42F, 13.62498F);
            this.lblDeviasi13.StylePriority.UseBorders = false;
            this.lblDeviasi13.StylePriority.UseFont = false;
            this.lblDeviasi13.StylePriority.UseForeColor = false;
            this.lblDeviasi13.StylePriority.UseTextAlignment = false;
            this.lblDeviasi13.Text = "Approve datetime";
            this.lblDeviasi13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lblDeviasi13.Visible = false;
            // 
            // xrTableCell64
            // 
            this.xrTableCell64.CanGrow = false;
            this.xrTableCell64.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblDeviasi14});
            this.xrTableCell64.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell64.Name = "xrTableCell64";
            this.xrTableCell64.StylePriority.UseFont = false;
            this.xrTableCell64.StylePriority.UseTextAlignment = false;
            this.xrTableCell64.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell64.Weight = 1D;
            // 
            // lblDeviasi14
            // 
            this.lblDeviasi14.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblDeviasi14.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblDeviasi14.ForeColor = System.Drawing.Color.DarkGray;
            this.lblDeviasi14.LocationFloat = new DevExpress.Utils.PointFloat(11.16562F, 22.3451F);
            this.lblDeviasi14.Name = "lblDeviasi14";
            this.lblDeviasi14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblDeviasi14.SizeF = new System.Drawing.SizeF(193.4215F, 90.36496F);
            this.lblDeviasi14.StylePriority.UseBorders = false;
            this.lblDeviasi14.StylePriority.UseFont = false;
            this.lblDeviasi14.StylePriority.UseForeColor = false;
            this.lblDeviasi14.StylePriority.UseTextAlignment = false;
            this.lblDeviasi14.Text = "Note";
            this.lblDeviasi14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lblDeviasi14.Visible = false;
            // 
            // xrTableRow14
            // 
            this.xrTableRow14.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell671,
            this.xrTableCell71,
            this.xrTableCell72});
            this.xrTableRow14.Name = "xrTableRow14";
            this.xrTableRow14.Weight = 0.3913644909177591D;
            // 
            // xrTableCell671
            // 
            this.xrTableCell671.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell671.CanGrow = false;
            this.xrTableCell671.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell671.Name = "xrTableCell671";
            this.xrTableCell671.StylePriority.UseBorders = false;
            this.xrTableCell671.StylePriority.UseFont = false;
            this.xrTableCell671.StylePriority.UseTextAlignment = false;
            this.xrTableCell671.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell671.Weight = 1D;
            // 
            // xrTableCell71
            // 
            this.xrTableCell71.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell71.CanGrow = false;
            this.xrTableCell71.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell71.Name = "xrTableCell71";
            this.xrTableCell71.StylePriority.UseBorders = false;
            this.xrTableCell71.StylePriority.UseFont = false;
            this.xrTableCell71.StylePriority.UseTextAlignment = false;
            this.xrTableCell71.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell71.Weight = 1D;
            // 
            // xrTableCell72
            // 
            this.xrTableCell72.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell72.CanGrow = false;
            this.xrTableCell72.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell72.Name = "xrTableCell72";
            this.xrTableCell72.StylePriority.UseBorders = false;
            this.xrTableCell72.StylePriority.UseFont = false;
            this.xrTableCell72.StylePriority.UseTextAlignment = false;
            this.xrTableCell72.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell72.Weight = 1D;
            // 
            // xrTableRow32
            // 
            this.xrTableRow32.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell831,
            this.xrTableCell86,
            this.xrTableCell89});
            this.xrTableRow32.Name = "xrTableRow32";
            this.xrTableRow32.Weight = 0.333527536119971D;
            // 
            // xrTableCell831
            // 
            this.xrTableCell831.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell831.CanGrow = false;
            this.xrTableCell831.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell831.Name = "xrTableCell831";
            this.xrTableCell831.StylePriority.UseBorders = false;
            this.xrTableCell831.StylePriority.UseFont = false;
            this.xrTableCell831.StylePriority.UseTextAlignment = false;
            this.xrTableCell831.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell831.Weight = 1D;
            // 
            // xrTableCell86
            // 
            this.xrTableCell86.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell86.CanGrow = false;
            this.xrTableCell86.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell86.Name = "xrTableCell86";
            this.xrTableCell86.StylePriority.UseBorders = false;
            this.xrTableCell86.StylePriority.UseFont = false;
            this.xrTableCell86.StylePriority.UseTextAlignment = false;
            this.xrTableCell86.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell86.Weight = 1D;
            // 
            // xrTableCell89
            // 
            this.xrTableCell89.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell89.CanGrow = false;
            this.xrTableCell89.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell89.Name = "xrTableCell89";
            this.xrTableCell89.StylePriority.UseBorders = false;
            this.xrTableCell89.StylePriority.UseFont = false;
            this.xrTableCell89.StylePriority.UseTextAlignment = false;
            this.xrTableCell89.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell89.Weight = 1D;
            // 
            // xrTableRow33
            // 
            this.xrTableRow33.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell90,
            this.xrTableCell91,
            this.xrTableCell92});
            this.xrTableRow33.Name = "xrTableRow33";
            this.xrTableRow33.Weight = 1.3132682094057686D;
            // 
            // xrTableCell90
            // 
            this.xrTableCell90.CanGrow = false;
            this.xrTableCell90.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.picBoxDeviasi15,
            this.picBoxDeviasi16});
            this.xrTableCell90.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell90.Name = "xrTableCell90";
            this.xrTableCell90.StylePriority.UseFont = false;
            this.xrTableCell90.StylePriority.UseTextAlignment = false;
            this.xrTableCell90.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell90.Weight = 1D;
            // 
            // picBoxDeviasi15
            // 
            this.picBoxDeviasi15.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxDeviasi15.Image = ((System.Drawing.Image)(resources.GetObject("picBoxDeviasi15.Image")));
            this.picBoxDeviasi15.LocationFloat = new DevExpress.Utils.PointFloat(60.12904F, 20.96189F);
            this.picBoxDeviasi15.Name = "picBoxDeviasi15";
            this.picBoxDeviasi15.SizeF = new System.Drawing.SizeF(95.4946F, 90.36459F);
            this.picBoxDeviasi15.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxDeviasi15.StylePriority.UseBorders = false;
            this.picBoxDeviasi15.Visible = false;
            // 
            // picBoxDeviasi16
            // 
            this.picBoxDeviasi16.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxDeviasi16.Image = ((System.Drawing.Image)(resources.GetObject("picBoxDeviasi16.Image")));
            this.picBoxDeviasi16.LocationFloat = new DevExpress.Utils.PointFloat(60.70722F, 20.96189F);
            this.picBoxDeviasi16.Name = "picBoxDeviasi16";
            this.picBoxDeviasi16.SizeF = new System.Drawing.SizeF(95.49458F, 90.36461F);
            this.picBoxDeviasi16.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxDeviasi16.StylePriority.UseBorders = false;
            this.picBoxDeviasi16.Visible = false;
            // 
            // xrTableCell91
            // 
            this.xrTableCell91.CanGrow = false;
            this.xrTableCell91.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblDeviasi15});
            this.xrTableCell91.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell91.Name = "xrTableCell91";
            this.xrTableCell91.StylePriority.UseFont = false;
            this.xrTableCell91.StylePriority.UseTextAlignment = false;
            this.xrTableCell91.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell91.Weight = 1D;
            // 
            // lblDeviasi15
            // 
            this.lblDeviasi15.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblDeviasi15.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblDeviasi15.ForeColor = System.Drawing.Color.DarkGray;
            this.lblDeviasi15.LocationFloat = new DevExpress.Utils.PointFloat(9.999974F, 62.48322F);
            this.lblDeviasi15.Name = "lblDeviasi15";
            this.lblDeviasi15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblDeviasi15.SizeF = new System.Drawing.SizeF(196.42F, 13.62498F);
            this.lblDeviasi15.StylePriority.UseBorders = false;
            this.lblDeviasi15.StylePriority.UseFont = false;
            this.lblDeviasi15.StylePriority.UseForeColor = false;
            this.lblDeviasi15.StylePriority.UseTextAlignment = false;
            this.lblDeviasi15.Text = "Approve datetime";
            this.lblDeviasi15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lblDeviasi15.Visible = false;
            // 
            // xrTableCell92
            // 
            this.xrTableCell92.CanGrow = false;
            this.xrTableCell92.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblDeviasi16});
            this.xrTableCell92.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell92.Name = "xrTableCell92";
            this.xrTableCell92.StylePriority.UseFont = false;
            this.xrTableCell92.StylePriority.UseTextAlignment = false;
            this.xrTableCell92.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell92.Weight = 1D;
            // 
            // lblDeviasi16
            // 
            this.lblDeviasi16.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblDeviasi16.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblDeviasi16.ForeColor = System.Drawing.Color.DarkGray;
            this.lblDeviasi16.LocationFloat = new DevExpress.Utils.PointFloat(12.33139F, 20.96176F);
            this.lblDeviasi16.Name = "lblDeviasi16";
            this.lblDeviasi16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblDeviasi16.SizeF = new System.Drawing.SizeF(193.4215F, 90.36446F);
            this.lblDeviasi16.StylePriority.UseBorders = false;
            this.lblDeviasi16.StylePriority.UseFont = false;
            this.lblDeviasi16.StylePriority.UseForeColor = false;
            this.lblDeviasi16.StylePriority.UseTextAlignment = false;
            this.lblDeviasi16.Text = "Note";
            this.lblDeviasi16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lblDeviasi16.Visible = false;
            // 
            // xrTableRow34
            // 
            this.xrTableRow34.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell93,
            this.xrTableCell94,
            this.xrTableCell95});
            this.xrTableRow34.Name = "xrTableRow34";
            this.xrTableRow34.Weight = 0.34080884244506393D;
            // 
            // xrTableCell93
            // 
            this.xrTableCell93.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell93.CanGrow = false;
            this.xrTableCell93.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell93.Name = "xrTableCell93";
            this.xrTableCell93.StylePriority.UseBorders = false;
            this.xrTableCell93.StylePriority.UseFont = false;
            this.xrTableCell93.StylePriority.UseTextAlignment = false;
            this.xrTableCell93.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell93.Weight = 1D;
            // 
            // xrTableCell94
            // 
            this.xrTableCell94.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell94.CanGrow = false;
            this.xrTableCell94.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell94.Name = "xrTableCell94";
            this.xrTableCell94.StylePriority.UseBorders = false;
            this.xrTableCell94.StylePriority.UseFont = false;
            this.xrTableCell94.StylePriority.UseTextAlignment = false;
            this.xrTableCell94.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell94.Weight = 1D;
            // 
            // xrTableCell95
            // 
            this.xrTableCell95.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell95.CanGrow = false;
            this.xrTableCell95.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell95.Name = "xrTableCell95";
            this.xrTableCell95.StylePriority.UseBorders = false;
            this.xrTableCell95.StylePriority.UseFont = false;
            this.xrTableCell95.StylePriority.UseTextAlignment = false;
            this.xrTableCell95.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell95.Weight = 1D;
            // 
            // xrTableRow35
            // 
            this.xrTableRow35.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell96,
            this.xrTableCell97,
            this.xrTableCell98});
            this.xrTableRow35.Name = "xrTableRow35";
            this.xrTableRow35.Weight = 0.34268393238400041D;
            // 
            // xrTableCell96
            // 
            this.xrTableCell96.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell96.CanGrow = false;
            this.xrTableCell96.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell96.Name = "xrTableCell96";
            this.xrTableCell96.StylePriority.UseBorders = false;
            this.xrTableCell96.StylePriority.UseFont = false;
            this.xrTableCell96.StylePriority.UseTextAlignment = false;
            this.xrTableCell96.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell96.Weight = 1D;
            // 
            // xrTableCell97
            // 
            this.xrTableCell97.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell97.CanGrow = false;
            this.xrTableCell97.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell97.Name = "xrTableCell97";
            this.xrTableCell97.StylePriority.UseBorders = false;
            this.xrTableCell97.StylePriority.UseFont = false;
            this.xrTableCell97.StylePriority.UseTextAlignment = false;
            this.xrTableCell97.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell97.Weight = 1D;
            // 
            // xrTableCell98
            // 
            this.xrTableCell98.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell98.CanGrow = false;
            this.xrTableCell98.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell98.Name = "xrTableCell98";
            this.xrTableCell98.StylePriority.UseBorders = false;
            this.xrTableCell98.StylePriority.UseFont = false;
            this.xrTableCell98.StylePriority.UseTextAlignment = false;
            this.xrTableCell98.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell98.Weight = 1D;
            // 
            // xrTableRow38
            // 
            this.xrTableRow38.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell103,
            this.xrTableCell104,
            this.xrTableCell105});
            this.xrTableRow38.Name = "xrTableRow38";
            this.xrTableRow38.Weight = 1.3132682094057686D;
            // 
            // xrTableCell103
            // 
            this.xrTableCell103.CanGrow = false;
            this.xrTableCell103.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.picBoxDeviasi61,
            this.picBoxDeviasi62});
            this.xrTableCell103.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell103.Name = "xrTableCell103";
            this.xrTableCell103.StylePriority.UseFont = false;
            this.xrTableCell103.StylePriority.UseTextAlignment = false;
            this.xrTableCell103.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell103.Weight = 1D;
            // 
            // picBoxDeviasi61
            // 
            this.picBoxDeviasi61.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxDeviasi61.Image = ((System.Drawing.Image)(resources.GetObject("picBoxDeviasi61.Image")));
            this.picBoxDeviasi61.LocationFloat = new DevExpress.Utils.PointFloat(60.12904F, 22.91667F);
            this.picBoxDeviasi61.Name = "picBoxDeviasi61";
            this.picBoxDeviasi61.SizeF = new System.Drawing.SizeF(95.49459F, 90.36458F);
            this.picBoxDeviasi61.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxDeviasi61.StylePriority.UseBorders = false;
            this.picBoxDeviasi61.Visible = false;
            // 
            // picBoxDeviasi62
            // 
            this.picBoxDeviasi62.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxDeviasi62.Image = ((System.Drawing.Image)(resources.GetObject("picBoxDeviasi62.Image")));
            this.picBoxDeviasi62.LocationFloat = new DevExpress.Utils.PointFloat(60.12904F, 22.91667F);
            this.picBoxDeviasi62.Name = "picBoxDeviasi62";
            this.picBoxDeviasi62.SizeF = new System.Drawing.SizeF(95.49458F, 90.36462F);
            this.picBoxDeviasi62.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxDeviasi62.StylePriority.UseBorders = false;
            this.picBoxDeviasi62.Visible = false;
            // 
            // xrTableCell104
            // 
            this.xrTableCell104.CanGrow = false;
            this.xrTableCell104.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblDeviasi60});
            this.xrTableCell104.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell104.Name = "xrTableCell104";
            this.xrTableCell104.StylePriority.UseFont = false;
            this.xrTableCell104.StylePriority.UseTextAlignment = false;
            this.xrTableCell104.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell104.Weight = 1D;
            // 
            // lblDeviasi60
            // 
            this.lblDeviasi60.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblDeviasi60.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblDeviasi60.ForeColor = System.Drawing.Color.DarkGray;
            this.lblDeviasi60.LocationFloat = new DevExpress.Utils.PointFloat(9.332784F, 60.10844F);
            this.lblDeviasi60.Name = "lblDeviasi60";
            this.lblDeviasi60.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblDeviasi60.SizeF = new System.Drawing.SizeF(196.42F, 13.625F);
            this.lblDeviasi60.StylePriority.UseBorders = false;
            this.lblDeviasi60.StylePriority.UseFont = false;
            this.lblDeviasi60.StylePriority.UseForeColor = false;
            this.lblDeviasi60.StylePriority.UseTextAlignment = false;
            this.lblDeviasi60.Text = "Approve datetime";
            this.lblDeviasi60.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lblDeviasi60.Visible = false;
            // 
            // xrTableCell105
            // 
            this.xrTableCell105.CanGrow = false;
            this.xrTableCell105.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblDeviasi70});
            this.xrTableCell105.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell105.Name = "xrTableCell105";
            this.xrTableCell105.StylePriority.UseFont = false;
            this.xrTableCell105.StylePriority.UseTextAlignment = false;
            this.xrTableCell105.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell105.Weight = 1D;
            // 
            // lblDeviasi70
            // 
            this.lblDeviasi70.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblDeviasi70.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblDeviasi70.ForeColor = System.Drawing.Color.DarkGray;
            this.lblDeviasi70.LocationFloat = new DevExpress.Utils.PointFloat(11.16562F, 22.91654F);
            this.lblDeviasi70.Name = "lblDeviasi70";
            this.lblDeviasi70.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblDeviasi70.SizeF = new System.Drawing.SizeF(193.4215F, 90.36484F);
            this.lblDeviasi70.StylePriority.UseBorders = false;
            this.lblDeviasi70.StylePriority.UseFont = false;
            this.lblDeviasi70.StylePriority.UseForeColor = false;
            this.lblDeviasi70.StylePriority.UseTextAlignment = false;
            this.lblDeviasi70.Text = "Note";
            this.lblDeviasi70.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lblDeviasi70.Visible = false;
            // 
            // xrTableRow39
            // 
            this.xrTableRow39.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell180,
            this.xrTableCell107,
            this.xrTableCell108});
            this.xrTableRow39.Name = "xrTableRow39";
            this.xrTableRow39.Weight = 0.34080884244506393D;
            // 
            // xrTableCell180
            // 
            this.xrTableCell180.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell180.CanGrow = false;
            this.xrTableCell180.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell180.Name = "xrTableCell180";
            this.xrTableCell180.StylePriority.UseBorders = false;
            this.xrTableCell180.StylePriority.UseFont = false;
            this.xrTableCell180.StylePriority.UseTextAlignment = false;
            this.xrTableCell180.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell180.Weight = 1D;
            // 
            // xrTableCell107
            // 
            this.xrTableCell107.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell107.CanGrow = false;
            this.xrTableCell107.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell107.Name = "xrTableCell107";
            this.xrTableCell107.StylePriority.UseBorders = false;
            this.xrTableCell107.StylePriority.UseFont = false;
            this.xrTableCell107.StylePriority.UseTextAlignment = false;
            this.xrTableCell107.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell107.Weight = 1D;
            // 
            // xrTableCell108
            // 
            this.xrTableCell108.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell108.CanGrow = false;
            this.xrTableCell108.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell108.Name = "xrTableCell108";
            this.xrTableCell108.StylePriority.UseBorders = false;
            this.xrTableCell108.StylePriority.UseFont = false;
            this.xrTableCell108.StylePriority.UseTextAlignment = false;
            this.xrTableCell108.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell108.Weight = 1D;
            // 
            // xrTableRow40
            // 
            this.xrTableRow40.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell183,
            this.xrTableCell110,
            this.xrTableCell111});
            this.xrTableRow40.Name = "xrTableRow40";
            this.xrTableRow40.Weight = 0.34268393238400041D;
            // 
            // xrTableCell183
            // 
            this.xrTableCell183.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell183.CanGrow = false;
            this.xrTableCell183.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell183.Name = "xrTableCell183";
            this.xrTableCell183.StylePriority.UseBorders = false;
            this.xrTableCell183.StylePriority.UseFont = false;
            this.xrTableCell183.StylePriority.UseTextAlignment = false;
            this.xrTableCell183.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell183.Weight = 1D;
            // 
            // xrTableCell110
            // 
            this.xrTableCell110.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell110.CanGrow = false;
            this.xrTableCell110.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell110.Name = "xrTableCell110";
            this.xrTableCell110.StylePriority.UseBorders = false;
            this.xrTableCell110.StylePriority.UseFont = false;
            this.xrTableCell110.StylePriority.UseTextAlignment = false;
            this.xrTableCell110.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell110.Weight = 1D;
            // 
            // xrTableCell111
            // 
            this.xrTableCell111.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell111.CanGrow = false;
            this.xrTableCell111.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell111.Name = "xrTableCell111";
            this.xrTableCell111.StylePriority.UseBorders = false;
            this.xrTableCell111.StylePriority.UseFont = false;
            this.xrTableCell111.StylePriority.UseTextAlignment = false;
            this.xrTableCell111.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell111.Weight = 1D;
            // 
            // xrLabel11
            // 
            this.xrLabel11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(173.4637F, 297.1227F);
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
            this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(49.95823F, 53.24075F);
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
            this.lblDeviasi1,
            this.lblDeviasi2,
            this.picBoxDeviasi2,
            this.picBoxDeviasi1});
            this.xrTableCell38.Name = "xrTableCell38";
            this.xrTableCell38.Weight = 1D;
            // 
            // lblDeviasi1
            // 
            this.lblDeviasi1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblDeviasi1.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblDeviasi1.ForeColor = System.Drawing.Color.DarkGray;
            this.lblDeviasi1.LocationFloat = new DevExpress.Utils.PointFloat(72.86177F, 104.4918F);
            this.lblDeviasi1.Name = "lblDeviasi1";
            this.lblDeviasi1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblDeviasi1.SizeF = new System.Drawing.SizeF(132.8911F, 13.62502F);
            this.lblDeviasi1.StylePriority.UseBorders = false;
            this.lblDeviasi1.StylePriority.UseFont = false;
            this.lblDeviasi1.StylePriority.UseForeColor = false;
            this.lblDeviasi1.Text = "Approve datetime";
            this.lblDeviasi1.Visible = false;
            // 
            // lblDeviasi2
            // 
            this.lblDeviasi2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblDeviasi2.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblDeviasi2.ForeColor = System.Drawing.Color.DarkGray;
            this.lblDeviasi2.LocationFloat = new DevExpress.Utils.PointFloat(72.86173F, 118.1168F);
            this.lblDeviasi2.Name = "lblDeviasi2";
            this.lblDeviasi2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblDeviasi2.SizeF = new System.Drawing.SizeF(132.8911F, 17.75188F);
            this.lblDeviasi2.StylePriority.UseBorders = false;
            this.lblDeviasi2.StylePriority.UseFont = false;
            this.lblDeviasi2.StylePriority.UseForeColor = false;
            this.lblDeviasi2.Text = "Note";
            this.lblDeviasi2.Visible = false;
            // 
            // picBoxDeviasi2
            // 
            this.picBoxDeviasi2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxDeviasi2.Image = ((System.Drawing.Image)(resources.GetObject("picBoxDeviasi2.Image")));
            this.picBoxDeviasi2.LocationFloat = new DevExpress.Utils.PointFloat(9.332848F, 10.0001F);
            this.picBoxDeviasi2.Name = "picBoxDeviasi2";
            this.picBoxDeviasi2.SizeF = new System.Drawing.SizeF(95.49458F, 90.3646F);
            this.picBoxDeviasi2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxDeviasi2.StylePriority.UseBorders = false;
            this.picBoxDeviasi2.Visible = false;
            // 
            // picBoxDeviasi1
            // 
            this.picBoxDeviasi1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxDeviasi1.Image = ((System.Drawing.Image)(resources.GetObject("picBoxDeviasi1.Image")));
            this.picBoxDeviasi1.LocationFloat = new DevExpress.Utils.PointFloat(9.332848F, 10.00005F);
            this.picBoxDeviasi1.Name = "picBoxDeviasi1";
            this.picBoxDeviasi1.SizeF = new System.Drawing.SizeF(95.49458F, 90.3646F);
            this.picBoxDeviasi1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxDeviasi1.StylePriority.UseBorders = false;
            this.picBoxDeviasi1.Visible = false;
            // 
            // xrTableCell39
            // 
            this.xrTableCell39.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblDeviasi3,
            this.lblDeviasi4,
            this.picBoxDeviasi4,
            this.picBoxDeviasi3});
            this.xrTableCell39.Name = "xrTableCell39";
            this.xrTableCell39.Weight = 1D;
            // 
            // lblDeviasi3
            // 
            this.lblDeviasi3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblDeviasi3.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblDeviasi3.ForeColor = System.Drawing.Color.DarkGray;
            this.lblDeviasi3.LocationFloat = new DevExpress.Utils.PointFloat(72.8618F, 104.4917F);
            this.lblDeviasi3.Name = "lblDeviasi3";
            this.lblDeviasi3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblDeviasi3.SizeF = new System.Drawing.SizeF(132.8911F, 13.62502F);
            this.lblDeviasi3.StylePriority.UseBorders = false;
            this.lblDeviasi3.StylePriority.UseFont = false;
            this.lblDeviasi3.StylePriority.UseForeColor = false;
            this.lblDeviasi3.Text = "Approve datetime";
            this.lblDeviasi3.Visible = false;
            // 
            // lblDeviasi4
            // 
            this.lblDeviasi4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblDeviasi4.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic);
            this.lblDeviasi4.ForeColor = System.Drawing.Color.DarkGray;
            this.lblDeviasi4.LocationFloat = new DevExpress.Utils.PointFloat(72.86173F, 118.1167F);
            this.lblDeviasi4.Name = "lblDeviasi4";
            this.lblDeviasi4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblDeviasi4.SizeF = new System.Drawing.SizeF(132.8912F, 17.752F);
            this.lblDeviasi4.StylePriority.UseBorders = false;
            this.lblDeviasi4.StylePriority.UseFont = false;
            this.lblDeviasi4.StylePriority.UseForeColor = false;
            this.lblDeviasi4.Text = "Note";
            this.lblDeviasi4.Visible = false;
            // 
            // picBoxDeviasi4
            // 
            this.picBoxDeviasi4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxDeviasi4.Image = ((System.Drawing.Image)(resources.GetObject("picBoxDeviasi4.Image")));
            this.picBoxDeviasi4.LocationFloat = new DevExpress.Utils.PointFloat(10.00004F, 10.00005F);
            this.picBoxDeviasi4.Name = "picBoxDeviasi4";
            this.picBoxDeviasi4.SizeF = new System.Drawing.SizeF(95.49458F, 90.3646F);
            this.picBoxDeviasi4.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxDeviasi4.StylePriority.UseBorders = false;
            this.picBoxDeviasi4.Visible = false;
            // 
            // picBoxDeviasi3
            // 
            this.picBoxDeviasi3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.picBoxDeviasi3.Image = ((System.Drawing.Image)(resources.GetObject("picBoxDeviasi3.Image")));
            this.picBoxDeviasi3.LocationFloat = new DevExpress.Utils.PointFloat(10.0001F, 10.00004F);
            this.picBoxDeviasi3.Name = "picBoxDeviasi3";
            this.picBoxDeviasi3.SizeF = new System.Drawing.SizeF(95.49458F, 90.3646F);
            this.picBoxDeviasi3.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.picBoxDeviasi3.StylePriority.UseBorders = false;
            this.picBoxDeviasi3.Visible = false;
            // 
            // xrTableRow6
            // 
            this.xrTableRow6.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell40,
            this.xrTableCell16,
            this.xrTableCell17});
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
            // xrTableCell16
            // 
            this.xrTableCell16.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Underline);
            this.xrTableCell16.Name = "xrTableCell16";
            this.xrTableCell16.StylePriority.UseFont = false;
            this.xrTableCell16.StylePriority.UseTextAlignment = false;
            this.xrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            this.xrTableCell16.Weight = 1D;
            // 
            // xrTableCell17
            // 
            this.xrTableCell17.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Underline);
            this.xrTableCell17.Name = "xrTableCell17";
            this.xrTableCell17.StylePriority.UseFont = false;
            this.xrTableCell17.StylePriority.UseTextAlignment = false;
            this.xrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            this.xrTableCell17.Weight = 1D;
            // 
            // xrTableRow25
            // 
            this.xrTableRow25.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableRow25.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell70,
            this.xrTableCell711,
            this.xrTableCell722});
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
            // xrTableCell711
            // 
            this.xrTableCell711.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell711.Name = "xrTableCell711";
            this.xrTableCell711.StylePriority.UseFont = false;
            this.xrTableCell711.StylePriority.UseTextAlignment = false;
            this.xrTableCell711.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell711.Weight = 1D;
            // 
            // xrTableCell722
            // 
            this.xrTableCell722.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell722.Name = "xrTableCell722";
            this.xrTableCell722.StylePriority.UseFont = false;
            this.xrTableCell722.StylePriority.UseTextAlignment = false;
            this.xrTableCell722.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell722.Weight = 1D;
            // 
            // xrLabel12
            // 
            this.xrLabel12.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DocNo]")});
            this.xrLabel12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(173.4637F, 314.9142F);
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
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(173.4637F, 333.7476F);
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
            // docInternalMemoDeviasi
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
