<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uFooter.ascx.cs" Inherits="UserControls_Common_uFooter" %>


<div id="footer">
<p> 
    <asp:HyperLink runat="server" ID="hlContact" Text="Ýletiþim" NavigateUrl="~/Contact.aspx" /> &nbsp;&nbsp;|&nbsp;&nbsp;
    <asp:HyperLink runat="server" ID="hlSiteMap" Text="Site Haritasý" NavigateUrl="#Common-SiteMap" /> &nbsp;&nbsp;|&nbsp;&nbsp;
    <asp:HyperLink runat="server" ID="hlHelp" Text="Yardým" NavigateUrl="#Common-Help" /> &nbsp;&nbsp;|&nbsp;&nbsp;
    <asp:HyperLink runat="server" ID="hlEnglish" Text="English" NavigateUrl="#English" /> &nbsp;&nbsp;|&nbsp;&nbsp;
</p> 
<p>
    <asp:HyperLink runat="server" ID="hlUserAgreement" Text="Üyelik Þartlarý" NavigateUrl="#Employee-Common-UserAgreement" /> 
    <asp:HyperLink runat="server" ID="hlCompanyContract" Text="Danýþmanlýk Sözleþmesi" NavigateUrl="#Company-Common-CompanyContract" />
    &nbsp;&nbsp;|&nbsp;&nbsp;
    <asp:HyperLink runat="server" ID="hlPrivacy" Text="Gizlilik ve Kullaným Þartlarý" NavigateUrl="#Common-Privacy" /> 
</p>
<p class="mute">Pikcv.com Perakende Ýnsan Kaynaklarý Ltd. Þirketine ait bir sitedir.<br />
  Perakende Ýnsan Kaynaklarý Ltd. Þirketi Türkiye Ýþ Kurumu’nun 25.12.2007 tarih <br />ve 258 numaralý izin belgesi ile faaliyet göstermektedir.<br />
  <br />
  &copy; 2007 Perakende Ýnsan Kaynaklarý</p>
</div>