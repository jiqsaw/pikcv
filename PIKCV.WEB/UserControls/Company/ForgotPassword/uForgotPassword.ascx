<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uForgotPassword.ascx.cs" Inherits="UserControls_Company_ForgotPassword_uForgotPassword" %>
<div class="contentPad">
      <div class="HeaderPR floatLeft">
        <h2 class="sIFRHeader">Þifremi unuttum...</h2>
      </div>
      <div class="brclear"></div>
      <!-- start roundcornered box -->
      <div class="BoxContentTop"></div>
      <div class="BoxContent">
        <div class="BoxPadder">
          <table width="100%" class="FormTable">
            <tr>
              <td colspan="2"><p class="infoMsg">
              <asp:Literal runat="server" ID="ltlInfoMessage">
                Lütfen üyelik bilgi giriþi yaparken kullandýðýnýz e-posta adresinizi giriniz ve gönder butonuna basýnýz   
                </asp:Literal>
                </p>
                </td>
            </tr>
            
            <tr>
              <td align="right">&nbsp;</td>
              <td>&nbsp;</td>
            </tr>
            <tr id="trEmail" runat="server">
                <td align="right"><p><strong>E-postanýz:</strong></p></td>
                <td align="left">
                    <asp:TextBox Width="200" runat="server" ID="txtEmail" MaxLength="128"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtEmail"
                        CssClass="Error" ErrorMessage="Lütfen E-posta Adresinizi Giriniz" SetFocusOnError="True"
                        ValidationGroup="vgForgotPass" Display="Dynamic"></asp:RequiredFieldValidator>
                      <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail"
                          Display="Dynamic" ErrorMessage="Lütfen Email Adresini Düzgün Giriniz" SetFocusOnError="True" CssClass="Error"
                          ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="vgForgotPass"></asp:RegularExpressionValidator>                    
                </td>
            </tr>
            <tr id="trSecretQuestion" runat="server" visible="false">
                <td align="right"><p><strong>Gizli Sorunuz:</strong></p></td>
                <td>
                    <strong><asp:Literal runat="server" ID="ltlSecretQuestion"></asp:Literal></strong>    
                </td>
            </tr>
            <tr id="trSecretAnswer" runat="server" visible="false">
                <td align="right"><p><strong>Gizli Cevabýnýz:</strong></p></td>
                <td>
                    <asp:TextBox Width="200" runat="server" ID="txtSecretAnswer" MaxLength="128"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtSecretAnswer"
                        CssClass="Error" ErrorMessage="Lütfen Gizli Sorunuzun Cevabýný Giriniz" SetFocusOnError="True"
                        ValidationGroup="vgForgotPass"></asp:RequiredFieldValidator></td>
            </tr>                        
            <tr>
              <td>&nbsp;</td>
              <td>
                <asp:ImageButton runat="server" ID="ImgBtnSend" ImageUrl="~/Images/buttons/gonder.png" ValidationGroup="vgForgotPass" OnClick="ImgBtnSend_Click" />
              </td>
            </tr>
          </table>
          <p>&nbsp;</p>
          <p>&nbsp;</p>
          <div class="brclear"></div>
        </div>
      </div>
      <div class="BoxContentBottom"></div>
      <!-- finish roundcornered box -->
      <p>&nbsp;</p>
    </div>