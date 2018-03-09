<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uMessageDrafts.ascx.cs" Inherits="UserControls_Company_Messages_uMessageDrafts" %>
<div class="contentPad">
    <div class="HeaderPR floatLeft">
        <h2 class="sIFRHeader">
            <asp:Literal runat="server" ID="ltlMessages">Mesaj Taslaklarý</asp:Literal></h2>
    </div>
    
    <div id="Tab">
    <ul>
        <li runat="server" id="liInbox">
        <asp:LinkButton runat="server" ID="lnkMessages" OnClick="lnkMessages_Click"><span>Gelen Mesajlarým</span></asp:LinkButton>
        </li>
        <li runat="server" id="liSentMessages">
        <asp:LinkButton runat="server" ID="lnkSentMessages" OnClick="lnkSentMessages_Click"><span>Gönderilen Mesajlar</span></asp:LinkButton>
        </li>
        <li runat="server" id="liDrafts" class="TabActive"><a href="#Company-Messages-MessageDrafts"><span>Mesaj Taslaklarý</span></a></li>
    </ul>
    </div>    
    
    <div class="BoxContent">
            <div class="BoxPadder">

                <div class="brclear"></div>

                  <div class="infoMsg">
          	        <p>
          	        
          	            Daha önce kaydettiðiniz taslaklarý görüntüleyebilirsiniz.
          	            <br /><br />
                        <b><asp:Literal runat="server" ID="ltlNoRecord" 
                        Text="Hiç kayýtlý mesajýnýz bulunmamaktadýr" Visible="false"></asp:Literal></b>
          	        </p>          	        
          	        
                  </div>
                  
                <asp:Repeater runat="server" ID="rptDrafts" OnItemCommand="rptDrafts_ItemCommand">
                <ItemTemplate>
                    <div class="FilterItem">
                        <p><strong>
                            <asp:LinkButton runat="server" ID="lnkDraftName" CssClass="detailLink" 
                            CommandName="Detail"
                            CommandArgument='<%#DataBinder.Eval(Container.DataItem, "MessageDraftID") %>'
                            Text='<%#DataBinder.Eval(Container.DataItem, "MessageName") %>'></asp:LinkButton>
                        </strong>          
                        &nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
                            <asp:LinkButton runat="server" ID="lnkUpdateDraft" CssClass="detailLink" 
                            CommandName="Update"
                            CommandArgument='<%#DataBinder.Eval(Container.DataItem, "MessageDraftID") %>'
                            Text='Güncelle'></asp:LinkButton>         
                        &nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
                            <asp:LinkButton runat="server" ID="lnkRemoveDraft" CssClass="detailLink" 
                            CommandName="Remove" OnClientClick="return confirm('Mesajýnýzý silmek istediðinizden eminmisiniz')"
                            CommandArgument='<%#DataBinder.Eval(Container.DataItem, "MessageDraftID") %>'
                            Text='Taslaðý Sil'></asp:LinkButton>                   
                        </p>
                    </div>              
                </ItemTemplate>
                </asp:Repeater>
                  
                  <div class="brclear"></div>

<br /><br />
                <asp:HyperLink runat="server" ID="hlNew" 
                NavigateUrl="#Company-Messages-SendMessage&IsNew=1"
                ImageUrl="~/Images/buttons/NewMessage.png" />                
                
            </div>
    </div>


</div>