<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uPositionDefinition.ascx.cs"
    Inherits="UserControls_Company_Jobs_Jobs_uPositionDefinition" %>
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
        <asp:ValidationSummary runat="server" ID="vlsmryJobDefinition" ShowMessageBox="true" ShowSummary="False" ValidationGroup="vgGroup" />
            &nbsp;</td>
        <td width="75%">
            <h1>
                Pozisyon Tan�m�
            </h1>
        </td>
    </tr>
    <tr>
        <td colspan="2" valign="top">
            <table width="100%">
                <tr>
                    <td width="25%" align="right">
                        <p>
                            <strong>Referans No.</strong></p>
                    </td>
                    <td valign="top">
                        <asp:TextBox ID="txtReferanceNumber" runat="server" Enabled="False"></asp:TextBox>
                    </td>
                    <td align="right">
                        <p>
                            &nbsp;<strong>Al�nacak eleman say�s�</strong></p>
                    </td>
                    <td valign="top">
                        <asp:TextBox MaxLength="4" Width="20" runat="server" ID="txtNumberOfWorkers"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtNumberOfWorkers"
                                Display="None" ErrorMessage="L�tfen Eleman Say�s� Olarak Bir Say� Giriniz" SetFocusOnError="True"
                                ValidationExpression="[0-9]+" ValidationGroup="vgGroup"></asp:RegularExpressionValidator>
<%--                       <asp:DropDownList ID="drpNumberOfWorkers" runat="server">
                            <asp:ListItem Text="Se�iniz" Value="0"></asp:ListItem>
                            <asp:ListItem Text="1" Value=""></asp:ListItem>
                            <asp:ListItem Text="2" Value=""></asp:ListItem>
                            <asp:ListItem Text="3" Value=""></asp:ListItem>
                            <asp:ListItem Text="3-5" Value=""></asp:ListItem>
                            <asp:ListItem Text="5-10" Value=""></asp:ListItem>
                            <asp:ListItem Text="10-20" Value=""></asp:ListItem>
                            <asp:ListItem Text="20+" Value=""></asp:ListItem>
                        </asp:DropDownList>--%>
                        <%-- <asp:RequiredFieldValidator ErrorMessage="L�tfen al�nacak eleman say�s�n� se�iniz" ValidationGroup="vgGroup" runat="server" ID="errNumberOfWorkers" 
                        ControlToValidate="drpNumberOfWorkers" Display="None" SetFocusOnError="True" InitialValue="0"></asp:RequiredFieldValidator>--%>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td align="right" valign="top">
            <p>
                <strong>Sekt�r</strong></p>
            <p class="mute">
                En �ok 5 tercih yapabilirsiniz.</p>
        </td>
        <td>
            <table>
                <tr>
                    <td valign="top">
                        <asp:ListBox ID="lbSectors" runat="server" Width="220" Rows="3" SelectionMode="Multiple">
                        </asp:ListBox>
                    </td>
                    <td>
                        <p>
                            <asp:Image runat="server" ID="imgAddToListSector" ImageUrl="~/Images/buttons/add_to_list.png" /><br />
                            <asp:Image runat="server" ID="imgRemoveToListSector" ImageUrl="~/Images/buttons/remove_from_list.png" /></p>
                    </td>
                    <td valign="top">
                        <asp:ListBox ID="lbSelectedSectors" runat="server" Width="220" Rows="3" SelectionMode="Multiple">
                        </asp:ListBox>
                        <asp:RequiredFieldValidator ErrorMessage="L�tfen sekt�r se�iniz" ValidationGroup="vgGroup" runat="server" ID="errJobSector" 
                        ControlToValidate="lbSelectedSectors" Display="none" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td align="right">
            <p>
                <strong>Pozisyon</strong></p>
        </td>
        <td>
            <asp:DropDownList ID="drpPositions" runat="server">
            </asp:DropDownList>
            <asp:RequiredFieldValidator ErrorMessage="L�tfen pozisyon se�iniz" ValidationGroup="vgGroup" runat="server" ID="errPosition" 
                        ControlToValidate="drpPositions" Display="none" SetFocusOnError="True" InitialValue="0"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td align="right" valign="top">
            <p>
                <strong>�al���lacak �lke</strong></p>
            <p class="mute">
                En �ok 10 tercih yapabilirsiniz.</p>
        </td>
        <td>
            <table>
                <tr>
                    <td valign="top">
                        <asp:ListBox ID="lbCountry" runat="server" Width="220" Rows="3" SelectionMode="Multiple">
                        </asp:ListBox>
                    </td>
                    <td>
                        <p>
                            <asp:Image runat="server" ID="imgAddToListCountry" ImageUrl="~/Images/buttons/add_to_list.png" /><br />
                            <asp:Image runat="server" ID="imgRemoveToListCountry" ImageUrl="~/Images/buttons/remove_from_list.png" />
                        </p>
                    </td>
                    <td valign="top">
                        <asp:ListBox ID="lbSelectedCountry" runat="server" Width="220" Rows="3" SelectionMode="Multiple">
                        </asp:ListBox>
                        <asp:RequiredFieldValidator ErrorMessage="L�tfen en az bir �lke se�iniz" ValidationGroup="vgGroup" runat="server" ID="RequiredFieldValidator1" 
                        ControlToValidate="lbSelectedCountry" Display="none" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td align="right" valign="top">
            <p>
                <strong>�al���lacak �ehir</strong></p>
            <p class="mute">
                En �ok 10 tercih yapabilirsiniz.</p>
        </td>
        <td>
            <table>
                <tr>
                    <td valign="top">
                        <asp:ListBox ID="lbCity" runat="server" Width="220" Rows="3" SelectionMode="Multiple">
                        </asp:ListBox>
                    </td>
                    <td valign="top">
                        <p>
                            <asp:Image runat="server" ID="imgAddToListCity" ImageUrl="~/Images/buttons/add_to_list.png" /><br />
                            <asp:Image runat="server" ID="imgRemoveToListCity" ImageUrl="~/Images/buttons/remove_from_list.png" />
                        </p>
                    </td>
                    <td valign="top">
                        <asp:ListBox ID="lbSelectedCity" runat="server" Width="220" Rows="3" SelectionMode="Multiple">
                        </asp:ListBox>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td align="right" valign="top">
            <p>
                <strong>�� tan�m�</strong></p>
        </td>
        <td>
            <asp:TextBox ID="txtJobDescription" runat="server" TextMode="MultiLine" Rows="2"
                Width="420"></asp:TextBox>
                <asp:RequiredFieldValidator ErrorMessage="L�tfen ilan tan�m�n� giriniz" ValidationGroup="vgGroup" runat="server" ID="errJobDescription" 
                        ControlToValidate="txtJobDescription" Display="none" SetFocusOnError="True"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td align="right">
            &nbsp;</td>
        <td>
            <asp:ImageButton ID="imgContinue" runat="server" ImageUrl="~/images/buttons/corp_continue.png"
                OnClick="imgContinue_Click" ValidationGroup="vgGroup" Visible="false"/>
            <asp:ImageButton ID="imgSave" runat="server" ImageUrl="~/images/buttons/corp_update_and_save.png"
                OnClick="imgContinue_Click" ValidationGroup="vgGroup" Visible="false"/>
            
        </td>
    </tr>
</table>
