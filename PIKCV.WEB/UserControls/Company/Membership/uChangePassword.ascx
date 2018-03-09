<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uChangePassword.ascx.cs" Inherits="UserControls_Company_Membership_uChangePassword" %>

<script type="text/javascript"> 

function cvPassword(source, args)
{   
    args.IsValid = false;
    if (document.getElementById('<%=txtPassword.ClientID %>').value.length>5) { args.IsValid = true; }
}

</script> 

<div class="contentPad">
      <div class="HeaderPR floatLeft">
        <h2 class="sIFRHeader">Þifrenizi Deðiþtiriniz...</h2>
      </div>
      <div class="brclear"></div>
      <!-- start roundcornered box -->
      <div class="BoxContentTop"></div>
      <div class="BoxContent">
        <div class="BoxPadder">
            <asp:Panel ID="pnlChangePassword" DefaultButton="ImgBtnSend" runat="server">
                <table width="100%" class="FormTable">
                    <tr>
                        <td colspan="2">
                            <p class="infoMsg">
                                <asp:Literal runat="server" ID="ltlInfoMessage">
                                Lütfen þifrenizi deðiþtiriniz.
                                </asp:Literal><br />
                                <asp:Literal runat="server" ID="ltlInfoMessage2">
                                Þifreniz en az 6 karakter olmalýdýr. Türkçe karakter kullanýlmamalýdýr.
                                </asp:Literal>
                            </p>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td align="right">
                            <p>
                                <strong>Yeni þifreniz:</strong></p>
                        </td>
                        <td align="left">
                            <asp:TextBox Width="200" runat="server" ID="txtPassword" MaxLength="15" TextMode="Password"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtPassword"
                                CssClass="Error" ErrorMessage="Lütfen Bir Þifre Giriniz" SetFocusOnError="True"
                                ValidationGroup="vgChangePassword" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:CustomValidator ID="CustomValidatorPassword" runat="server" Display="Dynamic"
                                ClientValidationFunction="cvPassword" ValidationGroup="vgChangePassword"
                                ErrorMessage="Þifreniz En Az 6 Karakter Olmalýdýr"></asp:CustomValidator> 
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <p>
                                <strong>Yeni þifre tekrar:</strong></p>
                        </td>
                        <td align="left">
                            <asp:TextBox Width="200" runat="server" ID="txtPasswordConfirm" MaxLength="15" TextMode="Password"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPasswordConfirm"
                                CssClass="Error" ErrorMessage="Lütfen Yeni Þifreyi Tekrar Giriniz" SetFocusOnError="True"
                                ValidationGroup="vgChangePassword" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:CompareValidator ID="CompareValidator1" runat="server" CssClass="Error" SetFocusOnError="True"
                                ControlToCompare="txtPassword" ControlToValidate="txtPasswordConfirm" Display="Dynamic"
                                ErrorMessage="Yeni Þifreyi Yanlýþ Giriniz" ValidationGroup="vgChangePassword"></asp:CompareValidator></td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            <asp:ImageButton runat="server" ID="ImgBtnSend" ImageUrl="~/Images/buttons/gonder.png"
                                ValidationGroup="vgChangePassword" OnClick="ImgBtnSend_Click" />
                        </td>
                    </tr>
                </table>
            </asp:Panel>
          <p>&nbsp;</p>
          <p>&nbsp;</p>
          <div class="brclear"></div>
        </div>
      </div>
      <div class="BoxContentBottom"></div>
      <!-- finish roundcornered box -->
      <p>&nbsp;</p>
    </div>
    
    <div id="dvScript" runat="server"></div>