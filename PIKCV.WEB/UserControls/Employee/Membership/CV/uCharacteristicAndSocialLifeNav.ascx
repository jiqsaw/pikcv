<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uCharacteristicAndSocialLifeNav.ascx.cs" Inherits="UserControls_Employee_Membership_CV_uCharacteristicAndSocialLifeNav" %>

<div class="ContentColA">
    <ul class="SubTabNav">

        <li runat="server" id="liDriverLicence">
            <asp:HyperLink runat="server" ID="hlDriverLicence" Text="S�r�c� Belgesi"
            NavigateUrl="#Employee-Membership-CV&CVFocus=||FocusNo||"></asp:HyperLink>                
        </li>
                
        <li runat="server" id="liForeignLanguages">
            <asp:HyperLink runat="server" ID="hlForeignLanguages" Text="Yabanc� Dil"
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
            <asp:HyperLink runat="server" ID="hlInterests" Text="�lgi Alanlar�"
            NavigateUrl="#Employee-Membership-CV&CVFocus=||FocusNo||"></asp:HyperLink>
        </li>
        
        <li runat="server" id="liClubs">
            <asp:HyperLink runat="server" ID="hlClubs" Text="Kul�p ve Dernekler"
            NavigateUrl="#Employee-Membership-CV&CVFocus=||FocusNo||"></asp:HyperLink>                 
        </li>
        
    </ul>
</div>