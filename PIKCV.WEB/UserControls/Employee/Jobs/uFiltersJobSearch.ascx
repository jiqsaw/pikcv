<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uFiltersJobSearch.ascx.cs" Inherits="UserControls_Employee_Jobs_uFiltersJobSearch" %>
<div class="contentPad">

    <div class="HeaderPR floatLeft">
        <h2 class="sIFRHeader" style="width:180px;">Ýlan Arama</h2>
      </div>

    <div id="Tab">     
        <ul>
            <li id="li1">
                <a href="#Employee-Jobs-EasyJobSearch"><span>Kolay arama</span></a>
            </li>
            <li id="li2">
                <a href="#Employee-Jobs-DetailJobSearch"><span>Detaylý arama</span></a>
            </li>
            <li class="TabActive" id="li3">
                 <a href="#Employee-Jobs-FiltersJobSearch"><span>Kayýtlý Filtreler</span></a>
            </li>
        </ul>
    </div>
           
    <div class="BoxContent">
            <div class="BoxPadder">

                <div class="brclear"></div>

                  <div class="infoMsg">
          	        <p>
          	        
          	            Daha önce kaydettiðiniz arama filtreleriniz ile hýzlý arama yapabilirsiniz.
          	            <br /><br />
                        <b><asp:Literal runat="server" ID="ltlNoRecord" 
                        Text="Hiç kayýtlý filtreniz bulunmamaktadýr" Visible="false"></asp:Literal></b>
          	        </p>          	        
          	        
                  </div>
                  
                <asp:Repeater runat="server" ID="rptFilters" OnItemCommand="rptFilters_ItemCommand" OnItemDataBound="rptFilters_ItemDataBound">
                <ItemTemplate>
                    <div class="FilterItem">
                        <p><strong>
                            <asp:LinkButton runat="server" ID="lnkFilterName" CssClass="detailLink" 
                            CommandName="Detail"
                            CommandArgument='<%#DataBinder.Eval(Container.DataItem, "FilterID") %>'
                            Text='<%#DataBinder.Eval(Container.DataItem, "FilterName") %>'></asp:LinkButton>
                            <asp:TextBox runat="server" ID="txtFilterName" MaxLength="64" Visible="false"></asp:TextBox>
                        </strong>
                            <asp:LinkButton runat="server" ID="lnkFilterRenameSave" CssClass="detailLink" 
                            CommandName="RenameSave" Visible="false"
                            CommandArgument='<%#DataBinder.Eval(Container.DataItem, "FilterID") %>'
                            Text='Kaydet'></asp:LinkButton>                        
                        &nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
                            <asp:HyperLink runat="server" ID="hplRemoveFilter" CssClass="detailLink"
                            NavigateUrl='<%#DataBinder.Eval(Container.DataItem, "FilterID") %>'
                            Text='Filtreyi Sil'></asp:HyperLink>
                            &nbsp;&nbsp;
                            <asp:LinkButton runat="server" ID="lnkRenameFilter" CssClass="detailLink" 
                            CommandName="Rename"
                            CommandArgument='<%#DataBinder.Eval(Container.DataItem, "FilterID") %>'
                            Text='Ýsmini Deðiþtir'></asp:LinkButton>                            
                        </p>
                    </div>              
                </ItemTemplate>
                </asp:Repeater>
                  
                  <div class="brclear"></div>

            </div>
        </div>
      
</div>