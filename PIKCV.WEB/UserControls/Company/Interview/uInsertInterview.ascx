<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uInsertInterview.ascx.cs"
    Inherits="UserControls_Company_Interview_uInsertInterview" %>
<%@ Register Src="../../Common/uDate.ascx" TagName="uDate" TagPrefix="uc1" %>
<div class="contentPad">
    <!-- start roundcornered box -->
    <img src="images/misc/pikcv_popup_logo.png" width="230" height="70" />
    <div class="BoxPadder">
        <table width="450" class="FormTable" style="text-align: left;">
            <tr>
                <td width="30%">
                    &nbsp;</td>
                <td width="70%">
                    <h1>
                        Mülakata çaðýr
                    </h1>
                </td>
            </tr>
            <tr>
                <td align="right" valign="top">
                    <p>
                        <strong>Pozisyon</strong></p>
                </td>
                <td>
                    <asp:DropDownList ID="drpPosition" Width="200" runat="server">
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="errPosition" runat="server" ErrorMessage="Lütfen Bir Pozisyon Seçiniz"
                        ControlToValidate="drpPosition" InitialValue="0" Display="Dynamic"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td align="right">
                    <p>
                        <strong>Tarih</strong></p>
                </td>
                <td>
                    <uc1:uDate ID="UDate1" runat="server" />
                </td>
            </tr>
            <tr>
                <td align="right" valign="top">
                    <p>
                        <strong>Baþlangýç saati</strong></p>
                </td>
                <td>
                    <asp:DropDownList ID="drpStartHour" runat="server">
                    </asp:DropDownList>
                    <asp:DropDownList ID="drpStartMinute" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td align="right" valign="top">
                    <p>
                        <strong>Bitiþ saati</strong></p>
                </td>
                <td>
                    <asp:DropDownList ID="drpEndHour" runat="server">
                    </asp:DropDownList>
                    <asp:DropDownList ID="drpEndMinute" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td align="right">
                    <p>
                        <strong>Yer</strong></p>
                </td>
                <td>
                    <asp:TextBox ID="txtInterviewPlace" runat="server" MaxLength="255"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="errInterviewPlace" runat="server" ErrorMessage="Lütfen Mülakat Yerini Giriniz"
                        ControlToValidate="txtInterviewPlace" Display="Dynamic"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td align="right">
                    <p>
                        <strong>Danýþman</strong></p>
                </td>
                <td>
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <asp:DropDownList ID="drpAdvisor" runat="server" OnSelectedIndexChanged="drpAdvisor_SelectedIndexChanged" AutoPostBack="true">
                            </asp:DropDownList>
                            <asp:TextBox ID="txtAdvisor" runat="server" MaxLength="128"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="errAdvisorTextBox" runat="server" ErrorMessage="Lütfen Bir Danýþman Seçiniz"
                                ControlToValidate="txtAdvisor" Display="Dynamic"></asp:RequiredFieldValidator>
                        </ContentTemplate>
                    </asp:UpdatePanel>
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
                    <asp:ImageButton ID="btnSubmit" runat="server" Text="Gönder" OnClick="btnSubmit_Click"
                        ImageUrl="~/images/buttons/corp_save.png" />
                </td>
            </tr>
        </table>
    </div>
</div>
