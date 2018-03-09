<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uMyMenu.ascx.cs" Inherits="UserControls_Common_uMyMenu" %>

<asp:Panel runat="server" ID="pnlMyMenu" Visible="false">

<div class="ShadowBox">
  <div class="ShadowBoxContent" style="left: 0px; top: 0px">
    <div class="BoxPadder">
      <div class="HeaderPB">
        <h3 class="sIFRHeader"><asp:Literal runat="server" ID="ltlMyMenuTitle"> Ki�isel Men�m </asp:Literal></h3>
      </div>
      <ul class="PersonalNav">

        <li><asp:LinkButton ID="LnkLogonPage" runat="server" Text="Ana Sayfa" OnClick="LnkLogonPage_Click"></asp:LinkButton></li>
        <li><asp:LinkButton ID="LnkMessages" runat="server" Text="Mesajlar�m" OnClick="LnkMessages_Click"></asp:LinkButton></li>
        <li><asp:LinkButton ID="LnkJobApplicants" runat="server" Text="Ba�vurular�m" OnClick="LnkJobApplicants_Click"></asp:LinkButton></li>
        
        <li><a href="#Employee-Jobs-EasyJobSearch"><strong>�lan Arama</strong></a></li>
        <li class="Subtitle"><strong>�yelik Bilgilerim</strong>
            <ul>
                <li> <a href="#Employee-Membership-UserInfo"><asp:Literal runat="server" ID="ltlPersonalInfo" Text="Ki�isel Bilgilerim"></asp:Literal> </a> </li>
                <li> <a href="#Employee-Membership-CV"><asp:Literal runat="server" ID="ltlCVEdit" Text="�zge�mi� Bilgileri"></asp:Literal> </a> </li>
                <li> <a href="#Employee-Membership-CVPreview"><asp:Literal runat="server" ID="ltlCVPreview" Text="�zge�mi� �nizleme"></asp:Literal> </a> </li>
                <li> <a href="#Employee-Membership-TestResults" id="aTestResults" runat="server"><asp:Literal runat="server" ID="ltlTestResults" Text="Test Sonu�lar�"></asp:Literal> </a> </li>
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
                        <asp:Literal runat="server" ID="Literal1">Kurumsal Men� </asp:Literal></h3>
                </div>
                <ul class="PersonalNav">
                    <li><asp:LinkButton ID="LnkLogonPageCompany" runat="server" Text="Ana Sayfa" OnClick="LnkLogonPageCompany_Click"></asp:LinkButton></li>
                    <li><a href="#Company-Credits-SelectCreditPackage"><strong>Pik Kredi Sat�n Alma</strong></a></li>
                    <li><a href="#Company-Search-Filters"><strong>Aday Arama</strong></a></li>
                    <li><asp:LinkButton ID="lnbJobs" runat="server" Text="�lanlar�m" OnClick="lnbJobs_Click"></asp:LinkButton></li>
                    <li style="display: none;"><asp:LinkButton ID="lnbJobApplicants" runat="server" Text="�lan Ba�vurular�" OnClick="lnbJobApplicants_Click"></asp:LinkButton></li>
                    <li><a href="#Company-Interview-Interview&InterviewType=2"><strong>M�lakatlar�m</strong></a></li>
                    <li><a href="#Company-Folders-FoldersMain"><strong>Klas�rlerim</strong></a></li>
                    <li><asp:LinkButton ID="LnkCompanyMessages" runat="server" Text="Mesajlar�m" OnClick="LnkCompanyMessages_Click"></asp:LinkButton></li>
                    <li><a href="#Company-Projects-Projects"><strong>Projelerim</strong></a></li>
                    <li><a href="#Company-Transactions-Transactions"><strong>��lemlerim</strong></a></li>
                    <li><a href="#Company-Membership-CompanyInfo"><strong>�yelik Bilgilerim</strong></a></li>
                </ul>
            </div>
        </div>
    </div>
</asp:Panel> 