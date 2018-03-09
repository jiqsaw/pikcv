<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uLogin.ascx.cs" Inherits="UserControls_Common_uLogin" %>
<%@ Register Src="ModalPopup/ModalPopup.ascx" TagName="ModalPopup" TagPrefix="uc1" %>

<asp:Panel runat="server" ID="pnlLoginOFF">
    <div class="SignupBtn">
        <asp:Panel runat="server" ID="pnlSignUpEmployee">
            <asp:HyperLink runat="server" ID="hlSignUp" 
                ImageUrl="~/Images/buttons/SignUpLeft.png"
                NavigateUrl="#Employee-Membership-UserInfo"
                ></asp:HyperLink>
        </asp:Panel>
        <asp:Panel runat="server" ID="pnlSignUpCompany" Visible="false">
            <asp:HyperLink runat="server" ID="hlSignUpCompany" 
                ImageUrl="~/Images/buttons/corp_become_member.png"
                NavigateUrl="#Company-Membership-CompanyInfo"
                Text="Üye Olmak Ýstiyorum"></asp:HyperLink>
        </asp:Panel>
    </div>
    <asp:Panel runat="server" ID="pnLoginForm" DefaultButton="btnLogin">
    <div class="ShadowBox">
        <div class="ShadowBoxContent">
            <div class="BoxPadder">
                <div class="HeaderPG">
                    <h3 class="sIFRHeader">
                        <asp:Literal runat="server" ID="ltlUserLogin" Text="Üye Giriþi">Üye Giriþi</asp:Literal>
                    </h3>
                </div>
                <div id="LoginForm">
                    <table>
                        <tr>
                            <td align="right" valign="top">
                                <p> <asp:Label runat="server" ID="lblUserName" Text="E-Posta"></asp:Label>:  </p>
                            </td>
                            <td>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ValidationGroup="vgGroup" 
                                ErrorMessage="Lütfen Email adresinizi doðru giriniz" Display="None" SetFocusOnError="True" 
                                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                                <asp:TextBox ValidationGroup="vgGroup" runat="server" ID="txtEmail" MaxLength="128" />
                                
                                <asp:RequiredFieldValidator ErrorMessage="Lütfen email adresinizi giriniz" ValidationGroup="vgGroup" runat="server" ID="errUserName" 
                                ControlToValidate="txtEmail" Display="None" SetFocusOnError="True"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" valign="top">
                                <p> <asp:Label runat="server" ID="lblPass" Text="Þifre"></asp:Label>: </p>
                            </td>
                            <td>
                                <asp:TextBox TextMode="Password" ValidationGroup="vgGroup" runat="server" ID="txtPassword" MaxLength="20" />
                                <asp:RequiredFieldValidator ErrorMessage="Lütfen þifrenizi giriniz" ValidationGroup="vgGroup" runat="server" ID="errPassword" ControlToValidate="txtPassword" Display="None"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr id="pnlSecurityCode" runat="server" visible="false">
                            <td align="right" valign="top">
                                <p> <asp:Label runat="server" ID="lblSecurityCode" Text="Güvenlik Kodu"></asp:Label>: </p>
                            </td>
                            <td><asp:Image ID="SecurityImage1" runat="server" ImageUrl="~/RandomImage.aspx" />
                                <asp:TextBox runat="server" ID="txtSecurityCode" Text="ds" MaxLength="10"></asp:TextBox>
                                <asp:RequiredFieldValidator ErrorMessage="Lütfen Güvenlik Kodunu Giriniz" ValidationGroup="vgGroup" runat="server" ID="errSecurityCode" 
                                ControlToValidate="txtSecurityCode" Display="None" SetFocusOnError="True"></asp:RequiredFieldValidator>  
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td> <asp:ImageButton CssClass="btnLogin" runat="server" ID="btnLogin" ImageUrl="~/Images/buttons/Login.png" AlternateText="Giriþ" OnClick="btnLogin_Click" ValidationGroup="vgGroup" /> </td>
                        </tr>
                    </table>
                    <asp:ValidationSummary runat="server" ID="vlsmryLogin" ShowMessageBox="true" ShowSummary="False" ValidationGroup="vgGroup" />
                </div>
                <div class="Forgotpass">
                &gt; <asp:HyperLink runat="server" id="hlForgotPassword" Text="Þifremi unuttum..." NavigateUrl="#Employee-ForgotPassword-ForgotPassword"></asp:HyperLink>
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">l</asp:LinkButton></div>
            </div>
        </div>
    </div>
    </asp:Panel>

</asp:Panel>

<asp:Panel runat="server" ID="pnlLoginON" Visible="false">

    <div class="ShadowBox">
      <div class="ShadowBoxContent">
        <div class="BoxPadder">
          <asp:Panel runat="server" ID="pnlCompanyName" Visible="false">
          <asp:Literal runat="server" ID="ltlCompanyName"/>
          </asp:Panel>
          <p class="UserSalute">Sayýn<br />
            <strong>
                <asp:Literal runat="server" ID="ltlFullName" />
            </strong>,<br />
                <asp:Literal runat="server" ID="ltlLoginWelcome">
            sitemize hoþgeldiniz.</asp:Literal></p>
          <p class="UserLoginDate">Son iþlem tarihiz: <asp:Literal runat="server" ID="ltlLastLoginDate"></asp:Literal> </p>
          <p class="Logout">
            <asp:LinkButton runat="server" ID="lnkLogOut" Text="Çýkýþ" OnClick="LogOut"></asp:LinkButton>
          </p>
          <asp:Panel runat="server" ID="pnlCVStatus">
          <div class="CvStatusLinkOn">Özgeçmiþ Durumu: <strong>
            <asp:CheckBox runat="server" ID="chIsCvActive" AutoPostBack="true" OnCheckedChanged="CVStatusChange" Text="Aktif" />
          </strong></div>
          </asp:Panel>
          <asp:Panel runat="server" ID="pnlCompanyStatus" Visible="false">
          <div class="CvStatusLinkOn">Pik Krediniz: <strong>
          <asp:HyperLink runat="server" ID="hlPikCredi" NavigateUrl="#Company-Credits-SelectCreditPackage"></asp:HyperLink>
          </strong></div>
          </asp:Panel>
        </div>
      </div>
    </div>
    
</asp:Panel>

<div id="dvScript" runat="server">
</div>

<uc1:ModalPopup ID="ShowModal" runat="server" Visible="false" />
