<%@ Page Title="" Language="C#" MasterPageFile="~/Root.master" AutoEventWireup="true" CodeBehind="DetailCIFDebiturMemo.aspx.cs" Inherits="DXMNCGUI_INFORMA.Transaction.DetailCIFDebiturMemo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Content" runat="server">
    <script type="text/javascript">
        function cplMain_EndCallback(s, e) {
            switch (cplMain.cpCallbackParam) {
                case "dafault":
                    break;
            }
            cplMain.cpCallbackParam = null;
        }
    </script>
    <dx:ASPxFormLayout runat="server" ID="FormLayout1" ClientInstanceName="FormLayout1" Font-Names="Calibri">
        <SettingsAdaptivity AdaptivityMode="SingleColumnWindowLimit" SwitchToSingleColumnAtWindowInnerWidth="800" />
        <Items>
            <dx:LayoutGroup ShowCaption="True" GroupBoxDecoration="HeadingLine" Caption="Detail Application Debitur" ColCount="3">
                <GroupBoxStyle>
                    <Caption ForeColor="SlateGray" Font-Size="Larger" Font-Bold="true" BackColor="Transparent"></Caption>
                </GroupBoxStyle>
            </dx:LayoutGroup>

            <%--<dx:LayoutGroup ShowCaption="False" ColCount="1" GroupBoxDecoration="None" Visible="false">
                <Items>
                    <dx:LayoutItem ShowCaption="False" Caption="Detail Tagihan">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxGridView
                                    ID="gvMain"
                                    ClientInstanceName="gvMain"
                                    runat="server"
                                    KeyFieldName="id"
                                    Width="100%"
                                    AutoGenerateColumns="false"
                                    EnableCallBacks="true"
                                    EnablePagingCallbackAnimation="true"
                                    OnDataBinding="gvMain_DataBinding"
                                    EnableTheming="True"
                                    Theme="Glass" Font-Size="Small" Font-Names="Calibri" OnCustomButtonCallback="gvMain_CustomButtonCallback" EnableCallbackAnimation="true">
                                    <SettingsAdaptivity AdaptivityMode="HideDataCellsWindowLimit" AllowOnlyOneAdaptiveDetailExpanded="True" HideDataCellsAtWindowInnerWidth="700">
                                    </SettingsAdaptivity>
                                    <Settings ShowFilterRow="false" ShowGroupPanel="True" ShowFilterRowMenu="true" ShowFilterBar="Auto" ShowHeaderFilterButton="true" ShowFooter="true" />
                                    <SettingsBehavior AllowFocusedRow="True" AllowSelectByRowClick="True" FilterRowMode="OnClick" EnableRowHotTrack="true" EnableCustomizationWindow="true" AllowEllipsisInText="true" />
                                    <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
                                    <SettingsSearchPanel Visible="True" />
                                    <SettingsFilterControl ViewMode="VisualAndText" AllowHierarchicalColumns="true" ShowAllDataSourceColumns="true" MaxHierarchyDepth="1" />
                                    <SettingsLoadingPanel Mode="Disabled" />
                                    <SettingsExport EnableClientSideExportAPI="true" ExcelExportMode="WYSIWYG" Landscape="true" PaperKind="A4" />
                                    <SettingsPager PageSize="5" Summary-Visible="true" Visible="true"></SettingsPager>
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

                                        <dx:GridViewDataTextColumn Name="id" Caption="id" FieldName="id" ReadOnly="True" ShowInCustomizationForm="true" Visible="false" VisibleIndex="0">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="APPLICNO" Caption="Application No" FieldName="NO_APLIKASI" ReadOnly="True" ShowInCustomizationForm="true" Visible="true">
                                            <HeaderStyle Font-Bold="true" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="STATUS_APLIKASI" Caption="Application Status" FieldName="STATUS_APLIKASI" ReadOnly="True" ShowInCustomizationForm="true" Visible="true">
                                            <HeaderStyle Font-Bold="true" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="TGL_APLIKASI" Caption="Application Date" FieldName="TGL_APLIKASI" ReadOnly="True" ShowInCustomizationForm="true" Visible="true">
                                            <HeaderStyle Font-Bold="true" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="CONTRACTNO" Caption="Contract No" FieldName="NO_KONTRAK" ReadOnly="True" ShowInCustomizationForm="true" Visible="true">
                                            <HeaderStyle Font-Bold="true" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="TGL_KONTRAK" Caption="Contract Date" FieldName="TGL_KONTRAK" ReadOnly="True" ShowInCustomizationForm="true" Visible="true">
                                            <HeaderStyle Font-Bold="true" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="STATUSKONTRAK" Caption="Contract Status" FieldName="STATUS_KONTRAK" ReadOnly="True" ShowInCustomizationForm="true" Visible="true">
                                            <HeaderStyle Font-Bold="true" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="DISBURSEDT" Caption="Disburse Date" FieldName="TGL_CAIR" ReadOnly="True" ShowInCustomizationForm="true" Visible="true">
                                            <HeaderStyle Font-Bold="true" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="JENISPEMBIAYAAN" Caption="Jenis Pembiayaan" FieldName="JENIS_PEMBIAYAAN" ReadOnly="True" ShowInCustomizationForm="true" Visible="true" Width="110px">
                                            <HeaderStyle Font-Bold="true" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="TENOR" Caption="TENOR" FieldName="TENOR" ReadOnly="True" ShowInCustomizationForm="true" Visible="true">
                                            <HeaderStyle Font-Bold="true" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="NTF" Caption="NTF" FieldName="NTF" ReadOnly="True" ShowInCustomizationForm="true" Visible="true">
                                            <HeaderStyle Font-Bold="true" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="RENTAL_PAYABLE" Caption="Rental Payable" FieldName="RENTAL_PAYABLE" ReadOnly="True" ShowInCustomizationForm="true" Visible="true">
                                            <HeaderStyle Font-Bold="true" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="OS_PRINCIPAL" Caption="Sisa OS" FieldName="OS_PRINCIPAL" ReadOnly="True" ShowInCustomizationForm="true" Visible="true">
                                            <HeaderStyle Font-Bold="true" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="OVD" Caption="Overdue" FieldName="OVD" ReadOnly="True" ShowInCustomizationForm="true" Visible="true">
                                            <HeaderStyle Font-Bold="true" />
                                        </dx:GridViewDataTextColumn>
                                    </Columns>
                                    <TotalSummary>
                                        <dx:ASPxSummaryItem FieldName="OS_PRINCIPAL" SummaryType="Sum" DisplayFormat="'Rp '#,0.00" />
                                    </TotalSummary>
                                    <Styles AdaptiveDetailButtonWidth="22" Footer-Font-Bold="true" Footer-ForeColor="#255658" Footer-Font-Size="10" Footer-Font-Names="Calibri">
                                        <AlternatingRow Enabled="True"></AlternatingRow>
                                    </Styles>
                                </dx:ASPxGridView>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                </Items>
            </dx:LayoutGroup>--%>
            <%--<dx:EmptyLayoutItem></dx:EmptyLayoutItem>--%>
            <%--<dx:LayoutGroup ShowCaption="False" ColCount="1" GroupBoxDecoration="None">
                <Items>
                    <dx:LayoutItem ShowCaption="False">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxLabel ID="lblTagihan" runat="server" Text="Detail Asset :" Font-Bold="true" Font-Size="Medium" Font-Names="Calibri" ForeColor="Black"></dx:ASPxLabel>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem ShowCaption="False">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxGridView
                                    ID="gvColl"
                                    ClientInstanceName="gvColl"
                                    runat="server"
                                    KeyFieldName="id"
                                    Width="100%"
                                    AutoGenerateColumns="false"
                                    EnableCallBacks="true"
                                    EnablePagingCallbackAnimation="true"
                                    OnDataBinding="gvColl_DataBinding"
                                    EnableTheming="True"
                                    Theme="Glass" Font-Size="Small" Font-Names="Calibri" OnCustomButtonCallback="gvColl_CustomButtonCallback" EnableCallbackAnimation="true">
                                    <SettingsAdaptivity AdaptivityMode="HideDataCellsWindowLimit" AllowOnlyOneAdaptiveDetailExpanded="True" HideDataCellsAtWindowInnerWidth="700">
                                    </SettingsAdaptivity>
                                    <Settings ShowFilterRow="false" ShowGroupPanel="True" ShowFilterRowMenu="true" ShowFilterBar="Auto" ShowHeaderFilterButton="true" ShowFooter="true" />
                                    <SettingsBehavior AllowFocusedRow="True" AllowSelectByRowClick="True" FilterRowMode="OnClick" EnableRowHotTrack="true" EnableCustomizationWindow="true" AllowEllipsisInText="true" />
                                    <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
                                    <SettingsSearchPanel Visible="True" />
                                    <SettingsFilterControl ViewMode="VisualAndText" AllowHierarchicalColumns="true" ShowAllDataSourceColumns="true" MaxHierarchyDepth="1" />
                                    <SettingsLoadingPanel Mode="Disabled" />
                                    <SettingsExport EnableClientSideExportAPI="true" ExcelExportMode="WYSIWYG" Landscape="true" PaperKind="A4" />
                                    <SettingsPager PageSize="5"></SettingsPager>
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
                                        <dx:GridViewDataTextColumn Name="id" Caption="id" FieldName="id" ReadOnly="True" ShowInCustomizationForm="true" Visible="false" VisibleIndex="0">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="APPLICNO" Caption="Application No" FieldName="APPLICNO" ReadOnly="True" ShowInCustomizationForm="true" Visible="true">
                                            <HeaderStyle Font-Bold="true" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="LSAGREE" Caption="Contract No" FieldName="LSAGREE" ReadOnly="True" ShowInCustomizationForm="true" Visible="true">
                                            <HeaderStyle Font-Bold="true" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="ASSETDESC" Caption="Asset Description" FieldName="ASSETDESC" ReadOnly="True" ShowInCustomizationForm="true" Visible="true">
                                            <HeaderStyle Font-Bold="true" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="ENGINENO" Caption="Engine No" FieldName="ENGINENO" ReadOnly="True" ShowInCustomizationForm="true" Visible="true" Width="110px">
                                            <HeaderStyle Font-Bold="true" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="SERIALNO" Caption="Serial No" FieldName="SERIALNO" ReadOnly="True" ShowInCustomizationForm="true" Visible="true" Width="110px">
                                            <HeaderStyle Font-Bold="true" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="APPSTATUS" Caption="App Status" FieldName="APPSTATUS" ReadOnly="True" ShowInCustomizationForm="true" Visible="true" Width="110px">
                                            <HeaderStyle Font-Bold="true" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="YEAR" Caption="Year" FieldName="YEAR" ReadOnly="True" ShowInCustomizationForm="true" Visible="true" Width="110px">
                                            <HeaderStyle Font-Bold="true" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="VHCCHASS" Caption="VHCCHASS" FieldName="VHCCHASS" ReadOnly="True" ShowInCustomizationForm="true" Visible="true">
                                            <HeaderStyle Font-Bold="true" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="VHCCOLOR" Caption="VHCCOLOR" FieldName="VHCCOLOR" ReadOnly="True" ShowInCustomizationForm="true" Visible="true">
                                            <HeaderStyle Font-Bold="true" />
                                        </dx:GridViewDataTextColumn>
                                    </Columns>
                                    <Styles>
                                        <AlternatingRow Enabled="True"></AlternatingRow>
                                    </Styles>
                                    <Styles AdaptiveDetailButtonWidth="22" Footer-Font-Bold="true"></Styles>
                                    <SettingsDetail ShowDetailRow="false" />
                                </dx:ASPxGridView>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                </Items>
            </dx:LayoutGroup>--%>

            <dx:TabbedLayoutGroup Height="200px" Name="tbLayoutGroupDetail" ClientInstanceName="tbLayoutGroup" Width="100%" ActiveTabIndex="0" Border-BorderStyle="Solid" Border-BorderWidth="0" Border-BorderColor="#d1ecee">
                <Items>
                    <dx:LayoutGroup Caption="Detail Nasabah">
                        <Items>
                            <dx:LayoutItem ShowCaption="False" Width="100%">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server">
                                        <dx:ASPxGridView
                                    ID="gvMain"
                                    ClientInstanceName="gvMain"
                                    runat="server"
                                    KeyFieldName="id"
                                    Width="100%"
                                    AutoGenerateColumns="false"
                                    EnableCallBacks="true"
                                    EnablePagingCallbackAnimation="true"
                                    OnDataBinding="gvMain_DataBinding"
                                    EnableTheming="True"
                                    Theme="Aqua" Font-Size="Small" Font-Names="Calibri" OnCustomButtonCallback="gvMain_CustomButtonCallback" EnableCallbackAnimation="true">
                                    <SettingsAdaptivity AdaptivityMode="HideDataCellsWindowLimit" AllowOnlyOneAdaptiveDetailExpanded="True" HideDataCellsAtWindowInnerWidth="700">
                                    </SettingsAdaptivity>
                                    <Settings ShowFilterRow="false" ShowGroupPanel="True" ShowFilterRowMenu="true" ShowFilterBar="Auto" ShowHeaderFilterButton="true" ShowFooter="true" />
                                    <SettingsBehavior AllowFocusedRow="True" AllowSelectByRowClick="True" FilterRowMode="OnClick" EnableRowHotTrack="true" EnableCustomizationWindow="true" AllowEllipsisInText="true" />
                                    <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
                                    <SettingsSearchPanel Visible="True" />
                                    <SettingsFilterControl ViewMode="VisualAndText" AllowHierarchicalColumns="true" ShowAllDataSourceColumns="true" MaxHierarchyDepth="1" />
                                    <SettingsLoadingPanel Mode="Disabled" />
                                    <SettingsExport EnableClientSideExportAPI="true" ExcelExportMode="WYSIWYG" Landscape="true" PaperKind="A4" />
                                    <SettingsPager PageSize="5" Summary-Visible="true" Visible="true"></SettingsPager>
                                    <SettingsResizing ColumnResizeMode="Control" Visualization="Live"/>
                                    <Toolbars>
                                        <dx:GridViewToolbar ItemAlign="Right" EnableAdaptivity="true" Position="Top">
                                            <Items>
                                                <dx:GridViewToolbarItem Command="ShowCustomizationWindow" DisplayMode="ImageWithText" />
                                                <dx:GridViewToolbarItem Command="ExportToXlsx" Text="Export to .xlsx" ToolTip="Click here to export grid data to excel" />
                                            </Items>
                                        </dx:GridViewToolbar>
                                    </Toolbars>
                                    <Columns>
                                        
                                        <dx:GridViewDataTextColumn Name="id" Caption="id" FieldName="id" ReadOnly="True" ShowInCustomizationForm="true" Visible="false" VisibleIndex="0">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="APPLICNO" Caption="Application No" FieldName="NO_APLIKASI" ReadOnly="True" ShowInCustomizationForm="true" Visible="true">
                                            <HeaderStyle Font-Bold="true" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="STATUS_APLIKASI" Caption="Application Status" FieldName="STATUS_APLIKASI" ReadOnly="True" ShowInCustomizationForm="true" Visible="true">
                                            <HeaderStyle Font-Bold="true" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="TGL_APLIKASI" Caption="Application Date" FieldName="TGL_APLIKASI" ReadOnly="True" ShowInCustomizationForm="true" Visible="true">
                                            <HeaderStyle Font-Bold="true" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="CONTRACTNO" Caption="Contract No" FieldName="NO_KONTRAK" ReadOnly="True" ShowInCustomizationForm="true" Visible="true">
                                            <HeaderStyle Font-Bold="true" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="TGL_KONTRAK" Caption="Contract Date" FieldName="TGL_KONTRAK" ReadOnly="True" ShowInCustomizationForm="true" Visible="true">
                                            <HeaderStyle Font-Bold="true" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="STATUSKONTRAK" Caption="Contract Status" FieldName="STATUS_KONTRAK" ReadOnly="True" ShowInCustomizationForm="true" Visible="true">
                                            <HeaderStyle Font-Bold="true" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="DISBURSEDT" Caption="Disburse Date" FieldName="TGL_CAIR" ReadOnly="True" ShowInCustomizationForm="true" Visible="true">
                                            <HeaderStyle Font-Bold="true" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="JENISPEMBIAYAAN" Caption="Jenis Pembiayaan" FieldName="JENIS_PEMBIAYAAN" ReadOnly="True" ShowInCustomizationForm="true" Visible="true" Width="110px">
                                            <HeaderStyle Font-Bold="true" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="TENOR" Caption="TENOR" FieldName="TENOR" ReadOnly="True" ShowInCustomizationForm="true" Visible="true">
                                            <HeaderStyle Font-Bold="true" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="NTF" Caption="NTF" FieldName="NTF" ReadOnly="True" ShowInCustomizationForm="true" Visible="true">
                                            <HeaderStyle Font-Bold="true" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="RENTAL_PAYABLE" Caption="Rental Payable" FieldName="RENTAL_PAYABLE" ReadOnly="True" ShowInCustomizationForm="true" Visible="true">
                                            <HeaderStyle Font-Bold="true" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="OS_PRINCIPAL" Caption="Sisa OS" FieldName="OS_PRINCIPAL" ReadOnly="True" ShowInCustomizationForm="true" Visible="true"  >
                                            <HeaderStyle Font-Bold="true" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Name="OVD" Caption="Overdue" FieldName="OVD" ReadOnly="True" ShowInCustomizationForm="true" Visible="true">
                                            <HeaderStyle Font-Bold="true" />
                                        </dx:GridViewDataTextColumn>
                                    </Columns>
                                    <TotalSummary>
                                        <dx:ASPxSummaryItem FieldName="OS_PRINCIPAL" SummaryType="Sum" DisplayFormat="'Rp '#,0.00" />
                                    </TotalSummary>
                                    <Styles AdaptiveDetailButtonWidth="22" Footer-Font-Bold="true" Footer-ForeColor="#255658" Footer-Font-Size="10" Footer-Font-Names="Calibri">
                                        <AlternatingRow Enabled="True"></AlternatingRow>
                                    </Styles>
                                </dx:ASPxGridView>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                        </Items>
                    </dx:LayoutGroup>

                    <dx:LayoutGroup Caption="Detail Asset ">
                        <Items>
                            <dx:LayoutItem ShowCaption="False" Width="100%">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer2" runat="server">
                                        <dx:ASPxGridView
                                            runat="server"
                                            ID="gvDetail2"
                                            ClientInstanceName="gvDetail2"
                                            Width="100%"
                                            KeyFieldName="DtlKey"
                                            AutoGenerateColumns="False"
                                            EnableCallBacks="true"
                                            EnablePagingCallbackAnimation="true"
                                            EnableTheming="True"
                                            Theme="Aqua"
                                            Font-Names="Calibri"
                                            OnDataBinding="gvDetail2_DataBinding"
                                            OnCustomCallback="gvDetail2_CustomCallback">
                                            <SettingsAdaptivity AdaptivityMode="HideDataCellsWindowLimit" AllowOnlyOneAdaptiveDetailExpanded="True" HideDataCellsAtWindowInnerWidth="700"></SettingsAdaptivity>
                                            
                                            <Settings ShowFilterRow="false" ShowGroupPanel="false" ShowFilterRowMenu="false" ShowFilterBar="Auto" ShowHeaderFilterButton="false" />
                                            <SettingsBehavior AllowFocusedRow="True" AllowSelectByRowClick="True" FilterRowMode="OnClick" EnableRowHotTrack="true" />
                                            <SettingsDataSecurity AllowDelete="true" AllowEdit="true" AllowInsert="true" />
                                            <SettingsSearchPanel Visible="false" />
                                            <SettingsFilterControl ViewMode="VisualAndText" AllowHierarchicalColumns="true" ShowAllDataSourceColumns="true" MaxHierarchyDepth="1" />
                                            <SettingsPager PageSize="5" Summary-Visible="true" Visible="true"></SettingsPager>
                                            <SettingsText ConfirmDelete="Are you really want to Delete?" />
                                            <SettingsEditing Mode="Inline" NewItemRowPosition="Bottom"></SettingsEditing>
                                            <Columns>
                                                <dx:GridViewDataTextColumn Name="APPLICNO" Caption="No Aplikasi" FieldName="APPLICNO" ReadOnly="True" Visible="true">
                                                    <HeaderStyle Font-Bold="true" />
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn Name="LSAGREE" Caption="No Kontrak" FieldName="LSAGREE" ReadOnly="True" Visible="true">
                                                    <HeaderStyle Font-Bold="true" />
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn Name="ASSETDESC" Caption="Asset Desc" FieldName="ASSETDESC" ReadOnly="True" ShowInCustomizationForm="true" Visible="true">
                                                    <HeaderStyle Font-Bold="true" />
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn Name="ENGINENO" Caption="Engine No" FieldName="ENGINENO" ReadOnly="True" ShowInCustomizationForm="true" Visible="true">
                                                    <HeaderStyle Font-Bold="true" />
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn Name="SERIALNO" Caption="Serial No" FieldName="SERIALNO" ReadOnly="True" ShowInCustomizationForm="true" Visible="true">
                                                    <HeaderStyle Font-Bold="true" />
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn Name="APPSTATUS" Caption="App Status" FieldName="APPSTATUS" ReadOnly="True" ShowInCustomizationForm="true" Visible="true">
                                                    <HeaderStyle Font-Bold="true" />
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn Name="YEAR" Caption="Tahun" FieldName="YEAR" ReadOnly="True" ShowInCustomizationForm="true" Visible="true">
                                                    <HeaderStyle Font-Bold="true" />
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn Name="VHCCHASS" Caption="VHCCHASS" FieldName="VHCCHASS" ReadOnly="True" ShowInCustomizationForm="true" Visible="true">
                                                    <HeaderStyle Font-Bold="true" />
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn Name="VHCCOLOR" Caption="VHCCOLOR" FieldName="VHCCOLOR" ReadOnly="True" ShowInCustomizationForm="true" Visible="true">
                                                    <HeaderStyle Font-Bold="true" />
                                                </dx:GridViewDataTextColumn>
                                            </Columns>
                                        </dx:ASPxGridView>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                        </Items>
                    </dx:LayoutGroup>
                </Items>
            </dx:TabbedLayoutGroup>




        </Items>
    </dx:ASPxFormLayout>

    

    <dx:ASPxCallback ID="cplMain" runat="server" ClientInstanceName="cplMain" OnCallback="cplMain_Callback">
        <ClientSideEvents EndCallback="cplMain_EndCallback" />
    </dx:ASPxCallback>
</asp:Content>
