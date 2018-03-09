<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uMyMenu.ascx.cs" Inherits="UserControls_Common_uMyMenu" %>

<asp:Panel runat="server" ID="pnlMyMenu" Visible="false">

<div class="ShadowBox">
  <div class="ShadowBoxContent" style="left: 0px; top: 0px">
    <div class="BoxPadder">
      <div class="HeaderPB">
        <h3 class="sIFRHeader"><asp:Literal runat="server" ID="ltlMyMenuTitle"> Kiþisel Menüm </asp:Literal></h3>
      </div>
      <ul class="PersonalNav">

        <li><asp:LinkButton ID="LnkLogonPage" runat="server" Text="Ana Sayfa" OnClick="LnkLogonPage_Click"></asp:LinkButton></li>
        <li><asp:LinkButton ID="LnkMessages" runat="server" Text="Mesajlarým" OnClick="LnkMessages_Click"></asp:LinkButton></li>
        <li><asp:LinkButton ID="LnkJobApplicants" runat="server" Text="Baþvurularým" OnClick="LnkJobApplicants_Click"></asp:LinkButton></li>
        
        <li><a href="#Employee-Jobs-EasyJobSearch"><strong>Ýlan Arama</strong></a></li>
        <li class="Subtitle"><strong>Üyelik Bilgilerim</strong>
            <ul>
                <li> <a href="#Employee-Membership-UserInfo"><asp:Literal runat="server" ID="ltlPersonalInfo" Text="Kiþisel Bilgilerim"></asp:Literal> </a> </li>
                <li> <a href="#Employee-Membership-CV"><asp:Literal runat="server" ID="ltlCVEdit" Text="Özgeçmiþ Bilgileri"></asp:Literal> </a> </li>
                <li> <a href="#Employee-Membership-CVPreview"><asp:Literal runat="server" ID="ltlCVPreview" Text="Özgeçmiþ Önizleme"></asp:Literal> </a> </li>
                <li> <a href="#Employee-Membership-TestResults" id="aTestResults" runat="server"><asp:Literal runat="server" ID="ltlTestResults" Text="Test Sonuçlarý"></asp:Literal> </a> </li>
            </ul>
        </li>
      </ul>
    </div>
  </div>
</div>

</asp:Panel> 

<asp:Panel runat="server" ID="pnlCompanyMenu" Visible="false">

    <div class="ShadowBox">
        <div class="ShadowBoxContent" style="left: 0px; top: 0px">
            <div class="BoxPadder">
                <div class="HeaderPB">
                    <h3 class="sIFRHeader">
                        <asp:Literal runat="server" ID="Literal1">Kurumsal Menü </asp:Literal></h3>
                </div>
                <ul class="PersonalNav">
                    <li><asp:LinkButton ID="LnkLogonPageCompany" runat="server" Text="Ana Sayfa" OnClick="LnkLogonPageCompany_Click"></asp:LinkButton></li>
                    <li><a href="#Company-Credits-SelectCreditPackage"><strong>Pik Kredi Satýn Alma</strong></a></li>
                    <li><a href="#Company-Search-Filters"><strong>Aday Arama</strong></a></li>
                    <li><asp:LinkButton ID="lnbJobs" runat="server" Text="Ýlanlarým" OnClick="lnbJobs_Click"></asp:LinkButton></li>
                    <li style="display: none;"><asp:LinkButton ID="lnbJobApplicants" runat="server" Text="Ýlan Baþvurularý" OnClick="lnbJobApplicants_Click"></asp:LinkButton></li>
                    <li><a href="#Company-Interview-Interview&InterviewType=2"><strong>Mülakatlarým</strong></a></li>
                    <li><a href="#Company-Folders-FoldersMain"><strong>Klasörlerim</strong></a></li>
                    <li><asp:LinkButton ID="LnkCompanyMessages" runat="server" Text="Mesajlarým" OnClick="LnkCompanyMessages_Click"></asp:LinkButton></li>
                    <li><a href="#Company-Projects-Projects"><strong>Projelerim</strong></a></li>
                    <li><a href="#Company-Transactions-Transactions"><strong>Ýþlemlerim</strong></a></li>
                    <li><a href="#Company-Membership-CompanyInfo"><strong>Üyelik Bilgilerim</strong></a></li>
                </ul>
            </div>
        </div>
    </div>
</asp:Panel> 