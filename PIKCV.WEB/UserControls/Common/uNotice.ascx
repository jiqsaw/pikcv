<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uNotice.ascx.cs" Inherits="UserControls_Common_uNotice" %>
        
<asp:Panel runat="server" ID="pnlEmployee" Visible="false">
    <div class="BoxBlueGradient">
      <div class="BoxPadder">
        <div class="HeaderPR">
            <h3 class="sIFRHeader"> Yetkinlik Testi </h3>
        </div>
      <p class="articleHeader">
        <a href="#Employee-Membership-Tests&Notice=1">
        Yetkinlik Testini almak ister misiniz?
        </a>
        <br />
      </p>
      </div>
    </div>
    <br />
 </asp:Panel>
    
<asp:Panel runat="server" ID="pnlCompany" Visible="false">
    <div class="BoxBlueGradient">
      <div class="BoxPadder">        
    <h5>
        Müþteri temsilciniz:</h5>
    <p class="PikcvDesk">
        <strong>
            <asp:Label ID="lbFirstName" runat="server"></asp:Label>&nbsp
            <asp:Label ID="lbLastName" runat="server"></asp:Label>
            </strong>
        <br />
        <asp:Label ID="lbPhoneNumber" runat="server"></asp:Label><br />
        <asp:HyperLink runat="server" Target="_blank" ID="hlEmail" NavigateUrl='mailto:'></asp:HyperLink>
       </p>
      </div>
    </div>
    <br />
</asp:Panel>