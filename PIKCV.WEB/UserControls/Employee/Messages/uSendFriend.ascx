<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uSendFriend.ascx.cs" Inherits="UserControls_Employee_Messages_uSendFriend" %>
<%@ Register Src="../../Common/ModalPopup/ModalPopup.ascx" TagName="ModalPopup" TagPrefix="uc1" %>
<asp:Image runat="server" ID="imgLogo" ImageUrl="~/Images/logos/pikcv_popup_logo.png" /> <br />
<div style="padding: 6px 8px;">

      <div class="HeaderPR floatLeft">
        <h2 class="sIFRHeader">
            <asp:Literal runat="server" ID="ltlSendFriend">Arkadaþýma Gönder</asp:Literal>
        </h2>
      </div>

      <div class="brclear"></div>
      <div class="BoxContentTop"></div>
      <div class="BoxContent2">
        <div class="BoxPadder">
          <table class="FormTable">
              <tr>
                  <td colspan="2">
                      <p class="infoMsg">
                          <asp:Literal runat="server" ID="ltlInfoMessage">
                                Bu eposta sistem üzerinden gönderilecektir
                          </asp:Literal>
                      </p>
                  </td>
              </tr>
            <tr>
              <td align="right" valign="top" nowrap="nowrap"><strong>Kime:</strong></td>
              <td>
                  <asp:TextBox ID="txtTo" runat="server" Width="250"></asp:TextBox>
                </td>
            </tr>
            <tr>
              <td width="100" align="right" valign="top" nowrap="nowrap"><strong>Konu:</strong></td>
              <td align="left">
                  <asp:TextBox ID="txtSubject" runat="server" Width="250"></asp:TextBox><br />
                </td>
            </tr>          
            <tr>
              <td align="right" valign="top" nowrap="nowrap"><strong>Mesaj:</strong></td>
              <td>
                <div id="dvMessage" runat="server">
                </div>
            </tr>
            <tr>
              <td width="100" align="right" valign="top" nowrap="nowrap"><strong>Not:</strong></td>
              <td align="left">
                  <asp:TextBox ID="txtNote" runat="server" TextMode="multiLine" Rows="3" Width="250"></asp:TextBox><br />
                </td>
            </tr>              
            <tr>
              <td>&nbsp;</td>
              <td>
                   <asp:ImageButton ID="imgSend" runat="server" ImageUrl="~/images/buttons/gonder.png" width="97" height="27" OnClick="imgSend_Click" ValidationGroup="vgSendFriend"/>
              </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:ValidationSummary CssClass="Error" ValidationGroup="vgSendFriend" DisplayMode="BulletList" ID="ValidationSummary1" runat="server" />
                </td>
            </tr>
          </table>
          <div class="brclear"></div>
        </div>
      </div>

 </div>
 

<asp:RequiredFieldValidator CssClass="Error" ID="errEmail" runat="server" ControlToValidate="txtTo"
Display="None" ErrorMessage="Lütfen arkadaþýnýzýn email adresini giriniz" ValidationGroup="vgSendFriend"></asp:RequiredFieldValidator>

<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtTo" Display="None"
ErrorMessage="Lütfen geçerli bir e-posta adresi giriniz" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
ValidationGroup="vgSendFriend"></asp:RegularExpressionValidator>

<asp:RequiredFieldValidator SetFocusOnError="true" ID="errMessageSubject" runat="server"
ErrorMessage="Lütfen bir mesaj konusu giriniz" Display="None" ValidationGroup="vgSendFriend" CssClass="Error"
ControlToValidate="txtSubject"></asp:RequiredFieldValidator><br />
<br />
<uc1:ModalPopup ID="ShowModal" runat="server" Visible="false" />
