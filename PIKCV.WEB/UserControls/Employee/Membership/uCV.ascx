<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uCV.ascx.cs" Inherits="UserControls_Employee_Membership_uCV" %>
<%@ Register Src="../Common/uCVTabs.ascx" TagName="uCVTabs" TagPrefix="uc1" %>

    <div class="contentPad">
      <div class="HeaderPR floatLeft">
      <h2 class="sIFRHeader">
            <asp:Label ID="lblCVHeader" runat="server"></asp:Label>
        </h2>
      </div>

        <uc1:uCVTabs ID="UCVTabs1" runat="server" />
      
      <div class="brclear"></div>

      <!-- start roundcornered box -->
      <div class="BoxContentTop"></div>
           
        <div class="BoxContent">
            <div class="BoxPadder">
                <ul class="SubTab">
                    <li runat="server" id="li1">
                        <asp:HyperLink runat="server" ID="hlPersonalInfo" Text="Kiþisel Bilgiler"
                        NavigateUrl="#Employee-Membership-CV&CVFocus=||FocusNo||"></asp:HyperLink>
                    </li>
                    <li runat="server" id="li2">
                        <asp:HyperLink Enabled="False" runat="server" ID="hlEducation" Text="Eðitim Durumu"
                        NavigateUrl="#Employee-Membership-CV&CVFocus=||FocusNo||"></asp:HyperLink>
                    </li>
                    <li runat="server" id="li3">
                        <asp:HyperLink Enabled="False" runat="server" ID="hlEmployment" Text="Ýþ Deneyimi"
                        NavigateUrl="#Employee-Membership-CV&CVFocus=||FocusNo||"></asp:HyperLink>
                    </li>
                    <li runat="server" id="li4">
                        <asp:HyperLink Enabled="False" runat="server" ID="hlSocial" Text="Nitelikler / Ýlgi Alanlarý"
                        NavigateUrl="#Employee-Membership-CV&CVFocus=||FocusNo||"></asp:HyperLink>
                    </li>
                    <li runat="server" id="li5">
                        <asp:HyperLink Enabled="False" runat="server" ID="hlPreferences" Text="Tercihler"
                        NavigateUrl="#Employee-Membership-CV&CVFocus=||FocusNo||"></asp:HyperLink>
                    </li>
                </ul>
                <asp:Panel runat="server" ID="pnlNoEmailConfirmed">
                  <p class="ErrorMsg" style="text-align: center;">
                        <br /><br /><br /><br />
                        <asp:Label CssClass="Error" runat="server" ID="ltlError">
                        Bu bölüme geçmek için e-postanýza gönderilen aktivasyon linkine týklayýp login olmanýz gerekmektedir.
                        </asp:Label>
                        <br /><br />
                  </p>
                </asp:Panel>    
                  
                <div class="brclear"></div>
                <p>&nbsp;</p><p>&nbsp;</p>
                
                <asp:PlaceHolder runat="server" ID="PHCVFocus"></asp:PlaceHolder>
                
                <div class="brclear">
                </div>
            </div>
        </div>
        <div class="BoxContentBottom"></div>
      <!-- finish roundcornered box -->
      <p>&nbsp;</p>
      
    </div>