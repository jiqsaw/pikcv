<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uSeekingQuality.ascx.cs"
    Inherits="UserControls_Company_Jobs_Jobs_uSeekingQuality" %>
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
        <asp:ValidationSummary runat="server" ID="vlsmryJobSeekingQuality" ShowMessageBox="true" ShowSummary="False" ValidationGroup="vgGroup" />
            &nbsp;</td>
        <td width="75%">
            <h1>
                Aranan nitelikler</h1>
        </td>
    </tr>
    <tr>
        <td align="right" valign="top">
            <p>
                <strong>Sekt�r i� deneyimi</strong></p>
            <p class="mute">
                En �ok 10 se�im yap�labilir</p>
        </td>
        <td>
            <table>
                <tr>
                    <td valign="top">
                        <asp:ListBox ID="lbSectors" runat="server" Width="220" Rows="3" SelectionMode="Multiple">
                        </asp:ListBox>
                    </td>
                    <td>
                       <asp:Image runat="server" ID="imgAddToListSector" ImageUrl="~/Images/buttons/add_to_list.png" /><br />
                       <asp:Image runat="server" ID="imgRemoveToListSector" ImageUrl="~/Images/buttons/remove_from_list.png" />
                    </td>
                    <td valign="top">
                        <asp:ListBox ID="lbSelectedSectors" runat="server" Width="220" Rows="3" SelectionMode="Multiple">
                        </asp:ListBox>
<%--                        <asp:RequiredFieldValidator ErrorMessage="L�tfen sekt�r se�iniz" ValidationGroup="vgGroup" runat="server" ID="errJobSector" 
                        ControlToValidate="lbSelectedSectors" Display="none" SetFocusOnError="True"></asp:RequiredFieldValidator>--%>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td align="right">
            <p>
                <strong>Pozisyon i� deneyimi</strong></p>
                 <p class="mute">
                En �ok 10 se�im yap�labilir</p>
        </td>
        <td>
            <table>
                <tr>
                    <td valign="top">
                        <asp:ListBox ID="lbPositions" runat="server" Width="220" Rows="3" SelectionMode="Multiple">
                        </asp:ListBox>
                    </td>
                    <td>
                       <asp:Image runat="server" ID="imgAddToListPosition" ImageUrl="~/Images/buttons/add_to_list.png" /><br />
                       <asp:Image runat="server" ID="imgRemoveToListPosition" ImageUrl="~/Images/buttons/remove_from_list.png" />
                    </td>
                    <td valign="top">
                        <asp:ListBox ID="lbSelectedPositions" runat="server" Width="220" Rows="3" SelectionMode="Multiple">
                        </asp:ListBox>
<%--                        <asp:RequiredFieldValidator ErrorMessage="L�tfen pozisyon se�iniz" ValidationGroup="vgGroup" runat="server" ID="RequiredFieldValidator1" 
                        ControlToValidate="lbSelectedPositions" Display="none" SetFocusOnError="True"></asp:RequiredFieldValidator>--%>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td align="right" valign="top">
            <p>
                <strong>Yetkinlikler</strong></p>
            <p class="mute">
                En �ok 5 se�im yap�labilir</p>
        </td>
        <td>
            <table>
                <tr>
                    <td valign="top">
                        <asp:ListBox ID="lbPerfection" runat="server" Width="220" Rows="3" SelectionMode="Multiple">
                        </asp:ListBox>
                    </td>
                    <td>
                       <asp:Image runat="server" ID="imgAddToListPerfection" ImageUrl="~/Images/buttons/add_to_list.png" /><br />
                       <asp:Image runat="server" ID="imgRemoveToListPerfection" ImageUrl="~/Images/buttons/remove_from_list.png" />
                    </td>
                    <td valign="top">
                        <asp:ListBox ID="lbSelectedPerfection" runat="server" Width="220" Rows="3" SelectionMode="Multiple">
                        </asp:ListBox>
                        <asp:RequiredFieldValidator ErrorMessage="L�tfen en az bir yetkinlik se�iniz" ValidationGroup="vgGroup" runat="server" ID="RequiredFieldValidator1" 
                        ControlToValidate="lbSelectedPerfection" Display="none" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td align="right" valign="top">
            <p>
                <strong>Cinsiyet</strong></p>
        </td>
        <td>
             <asp:RadioButtonList ID="rblGender" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem Text="Erkek" Value=""></asp:ListItem>
                    <asp:ListItem Text="Bayan" Value=""></asp:ListItem>
                    <asp:ListItem Text="Farketmez" Value="" Selected="True"></asp:ListItem>
             </asp:RadioButtonList>
        </td>
    </tr>
    <tr>
        <td align="right">
            <p>
                <strong>Ya� aral���</strong></p>
        </td>
        <td>
            <asp:RadioButtonList RepeatDirection="Horizontal" runat="server" ID="rdAgeRange">
                <asp:ListItem Selected="True" Text="T�m�" Value=""></asp:ListItem>
                <asp:ListItem Text="18 - 24" Value=""></asp:ListItem>
                <asp:ListItem Text="25 - 29" Value=""></asp:ListItem>
                <asp:ListItem Text="30 - 34" Value=""></asp:ListItem>
                <asp:ListItem Text="35 - 39" Value=""></asp:ListItem>
                <asp:ListItem Text="40 - 44" Value=""></asp:ListItem>
                <asp:ListItem Text="45 - 55" Value=""></asp:ListItem>
                <asp:ListItem Text="56+" Value=""></asp:ListItem>
            </asp:RadioButtonList>
        </td>
    </tr>
    <tr>
        <td align="right" valign="top">
            <p>
                <strong>�al��ma tipi</strong></p>
        </td>
        <td>
            <asp:RadioButtonList RepeatDirection="Horizontal" runat="server" ID="rblLabouringTypes">
            </asp:RadioButtonList>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
           <asp:ImageButton ID="imgContinue" runat="server" ImageUrl="~/images/buttons/corp_continue.png"
                OnClick="imgContinue_Click" ValidationGroup="vgGroup" Visible="false"/>
           <asp:ImageButton ID="imgSave" runat="server" ImageUrl="~/images/buttons/corp_update_and_save.png"
                OnClick="imgContinue_Click" ValidationGroup="vgGroup" Visible="false"/>
        </td>
    </tr>
</table>
