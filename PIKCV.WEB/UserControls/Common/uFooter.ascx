<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uFooter.ascx.cs" Inherits="UserControls_Common_uFooter" %>


<div id="footer">
<p> 
    <asp:HyperLink runat="server" ID="hlContact" Text="�leti�im" NavigateUrl="~/Contact.aspx" /> &nbsp;&nbsp;|&nbsp;&nbsp;
    <asp:HyperLink runat="server" ID="hlSiteMap" Text="Site Haritas�" NavigateUrl="#Common-SiteMap" /> &nbsp;&nbsp;|&nbsp;&nbsp;
    <asp:HyperLink runat="server" ID="hlHelp" Text="Yard�m" NavigateUrl="#Common-Help" /> &nbsp;&nbsp;|&nbsp;&nbsp;
    <asp:HyperLink runat="server" ID="hlEnglish" Text="English" NavigateUrl="#English" /> &nbsp;&nbsp;|&nbsp;&nbsp;
</p> 
<p>
    <asp:HyperLink runat="server" ID="hlUserAgreement" Text="�yelik �artlar�" NavigateUrl="#Employee-Common-UserAgreement" /> 
    <asp:HyperLink runat="server" ID="hlCompanyContract" Text="Dan��manl�k S�zle�mesi" NavigateUrl="#Company-Common-CompanyContract" />
    &nbsp;&nbsp;|&nbsp;&nbsp;
    <asp:HyperLink runat="server" ID="hlPrivacy" Text="Gizlilik ve Kullan�m �artlar�" NavigateUrl="#Common-Privacy" /> 
</p>
<p class="mute">Pikcv.com Perakende �nsan Kaynaklar� Ltd. �irketine ait bir sitedir.<br />
  Perakende �nsan Kaynaklar� Ltd. �irketi T�rkiye �� Kurumu�nun 25.12.2007 tarih <br />ve 258 numaral� izin belgesi ile faaliyet g�stermektedir.<br />
  <br />
  &copy; 2007 Perakende �nsan Kaynaklar�</p>
</div>