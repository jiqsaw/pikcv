<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uSentMessages.ascx.cs" Inherits="UserControls_Company_Messages_uSentMessages" %>
<%@ Register Src="~/UserControls/Common/uList.ascx" TagName="uList" TagPrefix="uc2" %>

<div class="contentPad">
    <div class="HeaderPR floatLeft">
        <h2 class="sIFRHeader" style="width: 200px;">
            <asp:Literal runat="server" ID="ltlMessages">Gönderilen Mesajlarým</asp:Literal></h2>
    </div>
    
    <div id="Tab">
    <ul>
        <li runat="server" id="liInbox">
        <asp:LinkButton runat="server" ID="lnkMessages" OnClick="lnkMessages_Click"><span>Gelen Mesajlarým</span></asp:LinkButton>
        </li>
        <li runat="server" class="TabActive" id="liSentMessages">
        <asp:LinkButton runat="server" ID="lnkSentMessages" OnClick="lnkSentMessages_Click"><span>Gönderilen Mesajlar</span></asp:LinkButton>
        </li>
        <li runat="server" id="liDrafts"><a href="#Company-Messages-MessageDrafts"><span>Mesaj Taslaklarý</span></a></li>
    </ul>
    </div>
    
    <div class="brclear">
    </div>
    
    <uc2:uList id="UList1" runat="server"></uc2:uList>
    
    <div class="brclear"></div>
    
</div>