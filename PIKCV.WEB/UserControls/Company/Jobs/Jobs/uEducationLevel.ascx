<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uEducationLevel.ascx.cs"
    Inherits="UserControls_Company_Jobs_Jobs_uEducationLevel" %>
<table width="100%" class="FormTable">
    <tr>
        <td colspan="2">
            <asp:Panel runat="server" ID="pnlError" Visible="false">
                <div class="infoMsg">
                    <p>
                        <asp:Literal runat="server" ID="errTitleError" Text="HATA! "></asp:Literal>
                        <asp:Label CssClass="Error" runat="server" ID="ltlError">
                        </asp:Label>
                    </p>
                </div>
            </asp:Panel>
        </td>
    </tr>
    <tr>
        <td width="25%" align="right" valign="top">
        <asp:ValidationSummary runat="server" ID="vlsmryJobEducationLevel" ShowMessageBox="true" ShowSummary="False" ValidationGroup="vgGroup" />
            &nbsp;</td>
        <td width="75%">
            <h1>
                Eðitim durumu
            </h1>
        </td>
    </tr>
    <tr>
        <td align="right" valign="top">
            <p>
                <strong>Eðitim derecesi </strong>
            </p>
            <p class="mute">
                En çok 5 tercih yapabilirsiniz.</p>
        </td>
        <td>
            <table>
                <tr>
                    <td valign="top">
                        <asp:ListBox ID="lbEducationLevel" runat="server" Width="220" Rows="5" SelectionMode="Multiple"></asp:ListBox>
                    </td>
                    <td>
                        <p>
                            <asp:Image runat="server" ID="imgAddToListEducationLevel" ImageUrl="~/Images/buttons/add_to_list.png" /><br />
                            <asp:Image runat="server" ID="imgRemoveToListEducationLevel" ImageUrl="~/Images/buttons/remove_from_list.png" />
                    </td>
                    <td valign="top">
                        <asp:ListBox ID="lbSelectedEducationLevel" runat="server" Width="220" Rows="5" SelectionMode="Multiple"></asp:ListBox>
                        <asp:RequiredFieldValidator ErrorMessage="Lütfen eðitim derecesi seçiniz" ValidationGroup="vgGroup" runat="server" ID="errJobEducationLevel" 
                        ControlToValidate="lbSelectedEducationLevel" Display="none" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td align="right" valign="top">
            <p>
                <strong>Yabancý dil bilgisi </strong>
            </p>
            <p class="mute">
                En çok 5 tercih yapabilirsiniz</p>
        </td>
        <td>
            <table>
                <tr>
                    <td valign="top">
                        <asp:ListBox ID="lbForeignLanguages" runat="server" Width="220" Rows="5" SelectionMode="Multiple"></asp:ListBox>
                    </td>
                    <td>
                        <asp:Image runat="server" ID="imgAddToListLanguages" ImageUrl="~/Images/buttons/add_to_list.png" /><br />
                        <asp:Image runat="server" ID="imgRemoveToListLanguages" ImageUrl="~/Images/buttons/remove_from_list.png" />
                    </td>
                    <td valign="top">
                        <asp:ListBox ID="lbSelectedForeignLanguages" runat="server" Width="220" Rows="5" SelectionMode="Multiple"></asp:ListBox>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td align="right" valign="top">
            <p>
                <strong>Teknik / Bilgisayar bilgisi</strong></p>
            <p class="mute">
                En çok 10 tercih yapabilirsiniz.</p>
        </td>
        <td>
            <table>
                <tr>
                    <td valign="top">
                        <asp:ListBox ID="lbComputerKnowledge" runat="server" Width="220" Rows="5" SelectionMode="Multiple"></asp:ListBox>
                    </td>
                    <td>
                       <asp:Image runat="server" ID="imgAddToListComputerKnowledge" ImageUrl="~/Images/buttons/add_to_list.png" /><br />
                       <asp:Image runat="server" ID="imgRemoveToListComputerKnowledge" ImageUrl="~/Images/buttons/remove_from_list.png" />
                    </td>
                    <td valign="top">
                        <asp:ListBox ID="lbSelectedComputerKnowledge" runat="server" Width="220" Rows="5" SelectionMode="Multiple"></asp:ListBox>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            <asp:ImageButton ID="imgContinue" runat="server" ImageUrl="~/images/buttons/corp_continue.png"
                OnClick="imgContinue_Click" ValidationGroup="vgGroup" Visible="false"/>
           <asp:ImageButton ID="imgSave" runat="server" ImageUrl="~/images/buttons/corp_update_and_save.png"
                OnClick="imgContinue_Click" ValidationGroup="vgGroup" Visible="false" />
       </td>
    </tr>
</table>
