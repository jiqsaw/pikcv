<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uCharacteristicAndSocialLifeNav.ascx.cs" Inherits="UserControls_Employee_Membership_CV_uCharacteristicAndSocialLifeNav" %>

<div class="ContentColA">
    <ul class="SubTabNav">

        <li runat="server" id="liDriverLicence">
            <asp:HyperLink runat="server" ID="hlDriverLicence" Text="Sürücü Belgesi"
            NavigateUrl="#Employee-Membership-CV&CVFocus=||FocusNo||"></asp:HyperLink>                
        </li>
                
        <li runat="server" id="liForeignLanguages">
            <asp:HyperLink runat="server" ID="hlForeignLanguages" Text="Yabancý Dil"
            NavigateUrl="#Employee-Membership-CV&CVFocus=||FocusNo||"></asp:HyperLink>                
        </li>

        <li runat="server" id="liComputerKnowledge">
            <asp:HyperLink runat="server" ID="hlComputerKnowledge" Text="Bilgisayar Bilgisi"
            NavigateUrl="#Employee-Membership-CV&CVFocus=||FocusNo||"></asp:HyperLink>                
        </li>
        
        <li runat="server" id="liCourseAndCertificate">
            <asp:HyperLink runat="server" ID="hlCourseAndCertificate" Text="Kurs ve Sertifikalar"
            NavigateUrl="#Employee-Membership-CV&CVFocus=||FocusNo||"></asp:HyperLink>                
        </li>
        
        <li runat="server" id="liInterests">
            <asp:HyperLink runat="server" ID="hlInterests" Text="Ýlgi Alanlarý"
            NavigateUrl="#Employee-Membership-CV&CVFocus=||FocusNo||"></asp:HyperLink>
        </li>
        
        <li runat="server" id="liClubs">
            <asp:HyperLink runat="server" ID="hlClubs" Text="Kulüp ve Dernekler"
            NavigateUrl="#Employee-Membership-CV&CVFocus=||FocusNo||"></asp:HyperLink>                 
        </li>
        
    </ul>
</div>