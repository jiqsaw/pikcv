<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uEducationNav.ascx.cs" Inherits="UserControls_Employee_Membership_CV_uEducationNav" %>
<div class="ContentColA">
    <ul class="SubTabNav">

        <li runat="server" id="liDoktorate" visible="false">
            <asp:HyperLink runat="server" ID="hlDoktorate" Text="Doktora"
            NavigateUrl="#Employee-Membership-CV&CVFocus=||FocusNo||"></asp:HyperLink>                
        </li>
                
        <li runat="server" id="liUniversity2" visible="false">
            <asp:HyperLink runat="server" ID="hlUniversity2" Text="Lisansüstü Bilgileri"
            NavigateUrl="#Employee-Membership-CV&CVFocus=||FocusNo||"></asp:HyperLink>                
        </li>

        <li runat="server" id="liUniversity1" visible="false">
            <asp:HyperLink runat="server" ID="hlUniversity1" Text="Üniversite Bilgileri"
            NavigateUrl="#Employee-Membership-CV&CVFocus=||FocusNo||"></asp:HyperLink>                
        </li>
        
        <li runat="server" id="liUniversity0" visible="false">
            <asp:HyperLink runat="server" ID="hlUniversity0" Text="Önlisans Bilgileri"
            NavigateUrl="#Employee-Membership-CV&CVFocus=||FocusNo||"></asp:HyperLink>                
        </li>
        
        <li runat="server" id="liHighSchool" visible="false">
            <asp:HyperLink runat="server" ID="hlHighSchool" Text="Lise Bilgileri"
            NavigateUrl="#Employee-Membership-CV&CVFocus=||FocusNo||"></asp:HyperLink>
        </li>
        
        <li runat="server" id="liMiddleSchool" visible="false">
            <asp:HyperLink runat="server" ID="hlMiddleSchool" Text="Ýlköðretim Bilgileri"
            NavigateUrl="#Employee-Membership-CV&CVFocus=||FocusNo||"></asp:HyperLink>                 
        </li>
        
    </ul>
</div>