<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uJobType.ascx.cs" Inherits="UserControls_Company_Jobs_Jobs_uJobType" %>
<div class="ContentColB">
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
                &nbsp;</td>
            <td width="75%">
                <h1>
                    Ýlan Tipi</h1>
            </td>
        </tr>
        <tr>
            <td align="right" valign="top">
                <p>
                    <strong>Ýlanýnýzý yayýnlamak istediðiniz bölüm</strong></p>
            </td>
            <td>
                <asp:RadioButtonList ID="rblJobListType" runat="server">
                    <asp:ListItem Text="Ýlk 10" Value="" Selected="True"></asp:ListItem>
                    <asp:ListItem Text="Ýkinci 10" Value=""></asp:ListItem>
                    <asp:ListItem Text="Standart" Value=""></asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td align="right" valign="top">
                <p>
                    <strong>Ýlan vermek istediðiniz ünvan </strong>
                </p>
            </td>
            <td>
                <asp:RadioButtonList ID="rblEmployeeTypes" runat="server">
                    <asp:ListItem Text="Yönetici" Value="" Selected="True"></asp:ListItem>
                    <asp:ListItem Text="Eleman / Uzman" Value=""></asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td align="right" valign="top">
                <p>
                    <strong>Özel ilan </strong>
                </p>
            </td>
            <td>
                <table>
                    <tr>
                        <td>
                            <asp:CheckBox ID="chkMartyrRelative" runat="server" Text="Þehit yakýný" />
                        </td>
                        <td>
                            <asp:CheckBox ID="chkDisabled" runat="server" Text="Engelli" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:CheckBox ID="chkOldConvicted" runat="server" Text="Eski hükümlü" />
                        </td>
                        <td>
                            <asp:CheckBox ID="chkTerrorWronged" runat="server" Text="Terör Maðduru" />
                        </td>
                    </tr>
                </table>
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
                <asp:ImageButton ID="btnSubmit" runat="server" ImageUrl="~/images/buttons/corp_continue.png"
                    OnClick="btnSubmit_Click" Visible="false" />
                <asp:ImageButton ID="btnSave" runat="server" ImageUrl="~/images/buttons/corp_update_and_save.png"
                    OnClick="btnSubmit_Click" Visible="false" />
            </td>
        </tr>
    </table>
</div>
