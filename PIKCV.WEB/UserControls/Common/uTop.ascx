<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uTop.ascx.cs" Inherits="UserControls_Common_uTop" %>

<div id="header">
    <h1 id="logoPikcv">
        <asp:ImageButton AlternateText="PIKcv.com / Perakende �nsan Kaynaklar�" runat="server" ID="imgLogo" ImageUrl="~/Images/bg/pikcv_logo2.png" OnClick="imgLogo_Click"/>
    </h1>
    <ul id="topnav">
        <li class="topnav1"> <asp:HyperLink runat="server" ID="hlAboutUs" NavigateUrl="~/About.aspx" Text="Hakk�m�zda"></asp:HyperLink> </li>
        <li class="topnav2"> <asp:HyperLink runat="server" ID="hlServices" NavigateUrl="~/Services||MemberType||.aspx" Text="Hizmetlerimiz"></asp:HyperLink> </li>
        <li id="liEmployee" runat="server" class="topnav3" visible="false"> 
        <asp:HyperLink runat="server" ID="hlSearchJob" NavigateUrl="#Employee-Jobs-EasyJobSearch" Text="�lan Arama"></asp:HyperLink> </li>
        <li id="liCompany" runat="server" class="topnav4" visible="false"> 
        <asp:HyperLink runat="server" ID="hlNewJob" NavigateUrl="#Company-Jobs-Jobs&JobID=0" Text="Yeni �lan Giri�i"></asp:HyperLink> 
        </li>
    </ul>
<div id="sponsors"> <span>Sponsorlar�m�z:</span>
<asp:Image runat="server" ID="imgSponsors" AlternateText="Carrefour" ImageUrl="~/Images/sponsors/carrefour.png" />
</div>
</div>
<div class="brclear"></div>