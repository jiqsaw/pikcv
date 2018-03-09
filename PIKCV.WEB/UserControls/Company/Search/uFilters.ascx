<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uFilters.ascx.cs" Inherits="UserControls_Company_Search_uFilters" %>
<div class="contentPad">
    <div class="HeaderPR floatLeft">
        <h2 class="sIFRHeader">
            Arama</h2>
    </div>
    <div id="Tab">
        <ul>
            <li class="TabActive"><a href="#Company-Search-Filters"><span>Kayýtlý filtreler</span></a></li>
            <li id="tab1" runat="server"><a href="#Company-Search-EmployeeSearch&Type=2"><span>Yönetici
                arama</span></a></li>
            <li id="tab2" runat="server"><a href="#Company-Search-EmployeeSearch&Type=1"><span>Eleman
                / Uzman arama</span></a></li>
            <li><a href="#Company-Search-ApplicationSearch"><span>Baþvuru arama</span></a></li>
        </ul>
    </div>
    <div class="brclear">
    </div>
    <!-- start roundcornered box -->
    <div class="BoxContentTop">
    </div>
    <div class="BoxContent">
        <div class="BoxPadder">
            <div class="infoMsg">
                <p>
                    Daha önce kaydettiðiniz arama filtreleriniz ile hýzlý arama yapabilirsiniz.
                    <br />
                    <br />
                    <b>
                        <asp:Literal runat="server" ID="ltlNoRecord" Text="Hiç kayýtlý filtreniz bulunmamaktadýr"
                            Visible="false"></asp:Literal></b>
                </p>
            </div>
            <asp:Repeater runat="server" ID="rptFilters" OnItemCommand="rptFilters_ItemCommand">
                <ItemTemplate>
                    <div class="FilterItem">
                        <p>
                            <strong>
                                <asp:LinkButton runat="server" ID="lnkFilterName" CssClass="detailLink" CommandName="Detail"
                                    CommandArgument='<%#DataBinder.Eval(Container.DataItem, "FilterID") %>' Text='<%#DataBinder.Eval(Container.DataItem, "FilterName") %>'></asp:LinkButton>
                                <asp:TextBox runat="server" ID="txtFilterName" MaxLength="64" Visible="false"></asp:TextBox>
                            </strong>
                            
                            <asp:LinkButton runat="server" ID="lnkFilterRenameSave" CssClass="detailLink" 
                            CommandName="RenameSave" Visible="false"
                            CommandArgument='<%#DataBinder.Eval(Container.DataItem, "FilterID") %>'
                            Text='Kaydet'></asp:LinkButton>                        
                            &nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;                            
                            
                            <asp:LinkButton runat="server" ID="lnkRemoveFilter" CssClass="detailLink" CommandName="Remove"
                                OnClientClick="return confirm('Silmek Ýstediðinizden Emin misiniz?')" CommandArgument='<%#DataBinder.Eval(Container.DataItem, "FilterID") %>'
                                Text='Filtreyi Sil'></asp:LinkButton>
                             &nbsp;&nbsp;
                                <asp:LinkButton runat="server" ID="lnkRenameFilter" CssClass="detailLink" 
                                CommandName="Rename"
                                CommandArgument='<%#DataBinder.Eval(Container.DataItem, "FilterID") %>'
                                Text='Ýsmini Deðiþtir'></asp:LinkButton>                                 
                        </p>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
            <div class="brclear">
            </div>
        </div>
    </div>
    <div class="BoxContentBottom">
    </div>
    <!-- finish roundcornered box -->
</div>
