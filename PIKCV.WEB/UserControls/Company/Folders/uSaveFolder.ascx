<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uSaveFolder.ascx.cs" Inherits="UserControls_Company_Folders_uCreateFolder" %>

<div class="contentPad">
    <!-- start roundcornered box -->
    <asp:Image ID="imgPopupLogo" runat="server" Width="230" Height="70" ImageUrl="~/images/misc/pikcv_popup_logo.png" />
    <div>
        <table class="FormTable" style="text-align: left;">
            <asp:Panel ID="pnlMessage" runat="server" Visible="false">
            <tr>
                <td>
                    <asp:Label ID="lbMessage" runat="server"></asp:Label>
                </td>
            </tr>
            </asp:Panel>
            <tr>
                <td width="30%">
                    &nbsp;</td>
                <td width="70%">
                    <h1>
                        Klasör Kaydet
                    </h1>
                </td>
            </tr>
            <tr>
                <td >
                    <p>
                    <strong>Klasör Adý:</strong></p>
                </td>
                <td>
                    <asp:TextBox ID="txtFolderName" runat="server" MaxLength="30"></asp:TextBox><br />
                    <asp:RequiredFieldValidator CssClass="Error" ID="errFolderName" runat="server" ErrorMessage="Lütfen Klasör Adýný Giriniz"
                        ControlToValidate="txtFolderName" Display="Dynamic"></asp:RequiredFieldValidator>
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
                    &nbsp;</td>
                <td>
                    <asp:ImageButton ID="btnSubmit" runat="server" OnClick="btnSubmit_Click"
                        ImageUrl="~/images/buttons/corp_save.png" />
                </td>
            </tr>
        </table>
    </div>
</div>
