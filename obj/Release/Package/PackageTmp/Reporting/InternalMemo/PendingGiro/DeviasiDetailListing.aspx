<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="DeviasiDetailListing.aspx.cs" Inherits="DXMNCGUI_INFORMA.Reporting.InternalMemo.PendingGiro.DeviasiDetailListing" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript" src="~/Scripts/Application.js"></script>
    <script type="text/javascript">
        function cplMain_EndCallback(s, e) {
            switch (cplMain.cpCallbackParam) {
                case "SAVE_CONFIRM":
                    apcconfirm.Show();
                    lblmessage.SetText(cplMain.cplblmessage);
                    mmPerihal.SetText(cplMain.cpmmPerihal);
                    break;
                case "SAVE":
                    apcalert.SetContentHtml(cplMain.cpAlertMessage);
                    apcalert.Show();
                    break;
            }
        }
    </script>
    <dx:ASPxHiddenField runat="server" ID="HiddenField" ClientInstanceName="HiddenField"/>


    <dx:ASPxPopupControl ID="apcconfirm" ClientInstanceName="apcconfirm" runat="server" Modal="True"
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" HeaderText="Update Confirmation !" AllowDragging="True" PopupAnimationType="Fade" EnableViewState="False">
        <ContentCollection>
            <dx:PopupControlContentControl ID="PopupControlContentControl1" runat="server">
                <dx:ASPxFormLayout ID="ASPxFormLayout6" runat="server" Theme="Aqua">
                    <Items>
                        <dx:LayoutGroup ShowCaption="False" GroupBoxDecoration="None" ColCount="2">
                            <Items>
                                <dx:LayoutItem Caption="" ShowCaption="False" ColSpan="2">
                                    <LayoutItemNestedControlCollection>
                                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer7" runat="server">
                                            <dx:ASPxLabel ID="lblmessage" ClientInstanceName="lblmessage" runat="server" Text="" Width="100%">
                                            </dx:ASPxLabel>
                                        </dx:LayoutItemNestedControlContainer>
                                    </LayoutItemNestedControlCollection>
                                </dx:LayoutItem>

                                <dx:LayoutItem ShowCaption="False" ColSpan="2">
                                    <LayoutItemNestedControlCollection>
                                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer2" runat="server">
                                            <dx:ASPxMemo runat="server" ID="mmPerihal" ClientInstanceName="mmPerihal" Width="100%" Height="50px" Theme="Aqua" ReadOnly="true">
                                            </dx:ASPxMemo>
                                        </dx:LayoutItemNestedControlContainer>
                                    </LayoutItemNestedControlCollection>
                                </dx:LayoutItem>

                                <dx:LayoutItem ShowCaption="False" ColSpan="1">
                                    <LayoutItemNestedControlCollection>
                                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer8" runat="server">
                                            <dx:ASPxButton ID="btnSaveConfirm" runat="server" Text="OK" AutoPostBack="False" UseSubmitBehavior="false" Width="100">
                                                <ClientSideEvents Click="function(s, e) { apcconfirm.Hide();cplMain.PerformCallback(cplMain.cplblActionButton + ';'+cplMain.cplblActionButton); }" />
                                            </dx:ASPxButton>
                                        </dx:LayoutItemNestedControlContainer>
                                    </LayoutItemNestedControlCollection>
                                </dx:LayoutItem>
                                <dx:LayoutItem ShowCaption="False" ColSpan="1">
                                    <LayoutItemNestedControlCollection>
                                        <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer9" runat="server">
                                            <dx:ASPxButton ID="btnCancelConfirm" runat="server" Text="Cancel" AutoPostBack="False" UseSubmitBehavior="false" Width="100">
                                                <ClientSideEvents Click="function(s, e) { apcconfirm.Hide(); }" />
                                            </dx:ASPxButton>
                                        </dx:LayoutItemNestedControlContainer>
                                    </LayoutItemNestedControlCollection>
                                </dx:LayoutItem>
                            </Items>
                        </dx:LayoutGroup>
                    </Items>
                </dx:ASPxFormLayout>
            </dx:PopupControlContentControl>
        </ContentCollection>
    </dx:ASPxPopupControl>


    <dx:ASPxFormLayout runat="server" ID="FormLayout" ClientInstanceName="FormLayout" Font-Names="Calibri">
        <SettingsAdaptivity AdaptivityMode="SingleColumnWindowLimit" SwitchToSingleColumnAtWindowInnerWidth="800"/>
        <Items>
            <dx:LayoutGroup ShowCaption="True" GroupBoxDecoration="HeadingLine" Caption="Memo Deviasi Detail Listing" ColCount="5">
                <GroupBoxStyle>
                    <Caption ForeColor="SlateGray" Font-Size="Larger" Font-Bold="true" BackColor="Transparent"></Caption>
                </GroupBoxStyle>
                <Items>
                    <dx:LayoutItem ShowCaption="False" Width="10%">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer4" runat="server">
                                <dx:ASPxButton ID="btnRefresh" ClientInstanceName="btnRefresh" runat="server" Text="Refresh" OnClick="btnRefresh_Click" Width="100%" Theme="Aqua">
                                </dx:ASPxButton>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem ShowCaption="False" Width="10%">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server">
                                <dx:ASPxButton ID="btnUpdate" ClientInstanceName="btnUpdate" runat="server" Text="Update Status" Width="100%" Theme="Aqua" AutoPostBack="false" Visible="false">
                                    <ClientSideEvents Click="function(s,e) { cplMain.PerformCallback('SAVE_CONFIRM;' + 'SAVE_CONFIRM'); }" />
                                </dx:ASPxButton>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                </Items>
            </dx:LayoutGroup>
            <dx:LayoutGroup ShowCaption="False" ColCount="1" GroupBoxDecoration="None">
                <GroupBoxStyle>
                    <Caption ForeColor="SlateGray" Font-Size="Larger" Font-Bold="true" BackColor="Transparent"></Caption>
                </GroupBoxStyle>
                <Items>
                    <dx:LayoutItem ShowCaption="False">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxGridView
                                    ID="gvMain"
                                    ClientInstanceName="gvMain"
                                    runat="server" 
                                    DataSourceID="sdsDeviasiDetailListing"
                                    KeyFieldName="DocNo"
                                    Width="100%"
                                    AutoGenerateColumns="False"
                                    EnableCallBacks="true"
                                    EnablePagingCallbackAnimation="true"
                                    EnableTheming="True" Theme="Aqua"
                                    Font-Size="Small" Font-Names="Calibri" >
                                    <SettingsAdaptivity AdaptivityMode="HideDataCellsWindowLimit" AllowOnlyOneAdaptiveDetailExpanded="True" HideDataCellsAtWindowInnerWidth="700">
                                    </SettingsAdaptivity>
                                    <Settings ShowFilterRow="false" ShowGroupPanel="True" ShowFilterRowMenu="true" ShowFilterBar="Auto" ShowHeaderFilterButton="true" ShowFooter="true"  HorizontalScrollBarMode="Visible"/>
                                    <SettingsBehavior AllowFocusedRow="True" AllowSelectByRowClick="True" FilterRowMode="OnClick" EnableRowHotTrack="true" EnableCustomizationWindow="true" AllowEllipsisInText="true" />
                                    <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
                                    <SettingsSearchPanel Visible="True" />
                                    <SettingsFilterControl ViewMode="VisualAndText" AllowHierarchicalColumns="true" ShowAllDataSourceColumns="true" MaxHierarchyDepth="1" />
                                    <SettingsLoadingPanel Mode="Disabled" />
                                    <SettingsExport EnableClientSideExportAPI="true" ExcelExportMode="WYSIWYG" Landscape="true" PaperKind="A4" />
                                    <SettingsPager PageSize="15"></SettingsPager>
                                    <SettingsResizing ColumnResizeMode="Control" Visualization="Live" />
                                    <Toolbars>
                                        <dx:GridViewToolbar ItemAlign="Right" EnableAdaptivity="true" Position="Top">
                                            <Items>
                                                <dx:GridViewToolbarItem Command="ShowCustomizationWindow" DisplayMode="ImageWithText" />
                                                <dx:GridViewToolbarItem Command="ExportToXlsx" Text="Export to .xlsx" ToolTip="Click here to export grid data to excel" />
                                            </Items>
                                        </dx:GridViewToolbar>
                                    </Toolbars>
                                    <Columns>
                                        <dx:GridViewDataTextColumn Name="colDocNo" Caption="Memo No." FieldName="DocNo" ReadOnly="True" ShowInCustomizationForm="true">
                                            <HeaderStyle BackColor="WhiteSmoke" Font-Bold="true"/>
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataDateColumn Name="colDocDate" Caption="Memo Date" FieldName="DocDate" ReadOnly="True" ShowInCustomizationForm="true" PropertiesDateEdit-DisplayFormatString="dd/MM/yyyy">
                                            <HeaderStyle BackColor="WhiteSmoke" Font-Bold="true"/>
                                        </dx:GridViewDataDateColumn>
                                        <dx:GridViewDataTextColumn Name="colBranch" Caption="Cabang" FieldName="MemoBranch" ReadOnly="True" ShowInCustomizationForm="true">
                                            <HeaderStyle BackColor="WhiteSmoke" Font-Bold="true"/>
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="colDebitur" Caption="Debitur" FieldName="DeviasiNamaDebitur" ReadOnly="True" ShowInCustomizationForm="true">
                                            <HeaderStyle BackColor="WhiteSmoke" Font-Bold="true"/>
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="colPFK" Caption="No PFK" FieldName="DeviasiNoPFK" ReadOnly="True" ShowInCustomizationForm="true">
                                            <HeaderStyle BackColor="WhiteSmoke" Font-Bold="true"/>
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="colUnit" Caption="Unit" FieldName="DeviasiUnit" ReadOnly="True" ShowInCustomizationForm="true">
                                            <HeaderStyle BackColor="WhiteSmoke" Font-Bold="true"/>
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="colJenisPembiayaan" Caption="Jenis Pembiayaan" FieldName="DeviasiJenisPembiayaan" ReadOnly="True" ShowInCustomizationForm="true">
                                            <HeaderStyle BackColor="WhiteSmoke" Font-Bold="true"/>
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="colNamaAO" Caption="Nama AO" FieldName="DeviasiNamaAO" ReadOnly="True" ShowInCustomizationForm="true">
                                            <HeaderStyle BackColor="WhiteSmoke" Font-Bold="true"/>
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="colHdrMemo" Caption="Header Memo" FieldName="HeaderMemo" ReadOnly="True" ShowInCustomizationForm="true">
                                            <HeaderStyle BackColor="WhiteSmoke" Font-Bold="true"/>
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="colTBO" Caption="TBO" FieldName="DeviasiTBO" ReadOnly="True" ShowInCustomizationForm="true">
                                            <HeaderStyle BackColor="WhiteSmoke" Font-Bold="true"/>
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="colDtlKey" Caption="DtlKey" FieldName="DtlKey" ReadOnly="True" ShowInCustomizationForm="true" Visible="false">
                                            <HeaderStyle BackColor="WhiteSmoke" Font-Bold="true"/>
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="colKategori" Caption="Kategori" FieldName="KategoriDeviasi" ReadOnly="True" ShowInCustomizationForm="true">
                                            <HeaderStyle BackColor="WhiteSmoke" Font-Bold="true"/>
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="colPerihal" Caption="Perihal" FieldName="Perihal" ReadOnly="True" ShowInCustomizationForm="true">
                                            <HeaderStyle BackColor="WhiteSmoke" Font-Bold="true"/>
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="colStatus" Caption="Status" FieldName="Status" ReadOnly="True" ShowInCustomizationForm="true">
                                            <HeaderStyle BackColor="WhiteSmoke" Font-Bold="true"/>
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="colStatusDtl" Caption="Detail Status" FieldName="Detail Status" ReadOnly="True" ShowInCustomizationForm="true">
                                            <HeaderStyle BackColor="WhiteSmoke" Font-Bold="true"/>
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataDateColumn Name="colDeadlineDate" Caption="Deadline Date" FieldName="Deadline" ReadOnly="True" ShowInCustomizationForm="true" PropertiesDateEdit-DisplayFormatString="dd/MM/yyyy">
                                            <HeaderStyle BackColor="WhiteSmoke" Font-Bold="true"/>
                                        </dx:GridViewDataDateColumn>
                                        <dx:GridViewDataDateColumn Name="colUpdateDate" Caption="Done Date" FieldName="Updatedate" ReadOnly="True" ShowInCustomizationForm="true" PropertiesDateEdit-DisplayFormatString="dd/MM/yyyy">
                                            <HeaderStyle BackColor="WhiteSmoke" Font-Bold="true"/>
                                        </dx:GridViewDataDateColumn>
                                        <dx:GridViewDataTextColumn Name="colAging" Caption="Aging" FieldName="aging" ReadOnly="True" ShowInCustomizationForm="true">
                                            <HeaderStyle BackColor="WhiteSmoke" Font-Bold="true"/>
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="colFinalApprover" Caption="Final Approver" FieldName="FinalApprover" ReadOnly="True" ShowInCustomizationForm="true">
                                            <HeaderStyle BackColor="WhiteSmoke" Font-Bold="true"/>
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataMemoColumn Name="colFinalApprovalNote" Caption="Final Approval Note" FieldName="FinalApprovalNote" ReadOnly="True" ShowInCustomizationForm="true">
                                            <HeaderStyle BackColor="WhiteSmoke" Font-Bold="true"/>
                                        </dx:GridViewDataMemoColumn>
                                    </Columns>
                                    <Styles AdaptiveDetailButtonWidth="22">
                                        <AlternatingRow Enabled="True"></AlternatingRow>
                                    </Styles>
                                </dx:ASPxGridView>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                </Items>
            </dx:LayoutGroup>
        </Items>
    </dx:ASPxFormLayout>
    <dx:ASPxCallback ID="cplMain" runat="server" ClientInstanceName="cplMain" OnCallback="cplMain_Callback">
        <ClientSideEvents EndCallback="cplMain_EndCallback" />
    </dx:ASPxCallback>
    <asp:SqlDataSource ID="sdsDeviasiDetailListing" runat="server" ConnectionString="<%$ ConnectionStrings:SqlLocalConnectionString %>" ProviderName="<%$ ConnectionStrings:SqlLocalConnectionString.ProviderName %>"
        SelectCommand="SELECT 
	            A.DocNo,
	            A.DocDate,
	            A.MemoBranch,
	            A.DeviasiNamaDebitur,
	            A.DeviasiNoPFK,
	            A.DeviasiUnit,
	            A.DeviasiJenisPembiayaan,
	            A.DeviasiNamaAO,
	            A.DeviasiTBO,
	            A.MemoRefNo [HeaderMemo],
                B.DtlKey,
                A.KategoriDeviasi,
	            B.Perihal,
	            B.Deadline,
	            A.Status,
	            ISNULL(B.status,'-') [Detail Status],
	            B.Deadline,
	            B.Updatedate,
	            case when B.status is not null then DATEDIFF(day,B.deadline,B.Updatedate)
		            else DATEDIFF(day,B.deadline,getdate()) end aging,
	            (SELECT TOP 1 Nama FROM [InternalMemoApprovalList] WHERE DocKey = A.DocKey ORDER BY Seq DESC) AS FinalApprover,
	            (SELECT TOP 1 DecisionNote FROM [InternalMemoApprovalList] WHERE DocKey = A.DocKey ORDER BY Seq DESC) AS FinalApprovalNote
            FROM [dbo].[InternalMemo] A
            INNER JOIN [dbo].[InternalMemoDetailDeviasi] B ON A.DocKey = B.DocKey 
            left join DeviasiExtendHistory C on A.Docno = C.RefNo
            WHERE A.Status NOT IN('REJECT','CANCELED')
            ORDER BY A.DocDate DESC"></asp:SqlDataSource>
</asp:Content>
