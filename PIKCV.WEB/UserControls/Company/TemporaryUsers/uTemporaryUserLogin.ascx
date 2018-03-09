<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uTemporaryUserLogin.ascx.cs"
    Inherits="UserControls_Company_TemporaryUsers_uTemporaryUserLogin" %>

    <img src="images/misc/pikcv_popup_logo.png" width="230" height="70" />
    <br />


    <div class="brclear"></div>    

    <div class="BoxPadder">
            <table width="450" align="center" class="FormTable" style="text-align: left;">
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        <h1>
                            Klas�r giri�i
                        </h1>
                    </td>
                </tr>
                <tr>
                    <td valign="top">
                        <p>
                            <strong>Kullan�c� ad�</strong></p>
                    </td>
                    <td>
                        <asp:TextBox ID="txtUserName" runat="server" Width="220"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="errUserName" runat="server" ErrorMessage="L�tfen bir kullan�c� ad� giriniz"
                            ControlToValidate="txtUserName" Display="Dynamic" ValidationGroup="vgTempLogin"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <p>
                            <strong>�ifre</strong></p>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server" Width="220" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="errPassword" runat="server" ErrorMessage="L�tfen bir �ifre giriniz"
                            ControlToValidate="txtPassword" Display="Dynamic" ValidationGroup="vgTempLogin"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:ImageButton ID="btnSend" runat="server" ImageUrl="~/images/buttons/corp_send.png"
                            Width="97" Height="27" OnClick="btnSend_Click" ValidationGroup="vgTempLogin" />
                    </td>
                </tr>
            </table>
        </div>
        