<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AddTemporaryUsers.ascx.cs" Inherits="UserControls_Company_Folders_AddTemporaryUsers" %>


    <asp:Image ID="imgPopupLogo" runat="server" Width="230" Height="70" ImageUrl="~/images/misc/pikcv_popup_logo.png" />
    <div style="padding-left: 15px;">
        <table class="FormTable" style="text-align:left;">
            <asp:Panel ID="pnlMessage" runat="server" Visible="false">
            <tr>
                <td>
                    <asp:Label ID="lbMessage" runat="server"></asp:Label>
                </td>
            </tr>
            </asp:Panel>
            <tr>
                <td style="padding-left:20;">
                    <h1>
                        Klasör Paylaþ
                    </h1>
                </td>
            </tr>
            <tr>
                <td style="padding-left:20;">
                    <strong>Kullanýcý E-Posta Adresi</strong><br />
                    <asp:TextBox Width="200" ID="txtEmail" runat="server"></asp:TextBox><br />
                    <asp:RequiredFieldValidator CssClass="Error" ID="errEmail" runat="server" ErrorMessage="Lütfen E-Posta Adresi Giriniz"
                        ControlToValidate="txtEmail" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator CssClass="Error" ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail"
                    Display="Dynamic" ErrorMessage="Lütfen E-Posta Adresini Düzgün Giriniz" SetFocusOnError="True"
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="vgUserInfo"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 420px; padding-left:20;" >
                    <br /><strong>Not</strong><br />
                    <asp:TextBox Width="300" ID="txtNotes" runat="server" TextMode="MultiLine" Rows="5"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="padding-left:20;">
                    <asp:ImageButton ID="btnSubmit" runat="server" OnClick="btnSubmit_Click"
                        ImageUrl="~/images/buttons/corp_save.png" />
                </td>
            </tr>
        </table>
    </div>

