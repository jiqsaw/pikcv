<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uSelectSpecialCredit.ascx.cs"
    Inherits="UserControls_Company_Credits_uSelectSpecialCredit" %>

    <div class="contentPad">
        <div class="HeaderPR floatLeft">
            <h2 class="sIFRHeader">
                Pik Kredi Satýn Alma
            </h2>
        </div>
        <div class="brclear">
        </div>
        <div class="BoxContentTop">
        </div>
        <div class="BoxContent">
            <div class="BoxPadder">
                <table width="100%" class="FormTable">
                    <tr>
                        <td width="20%" align="right" valign="top">
                            &nbsp;</td>
                        <td width="80%">
                            <h1>
                                Pik Kredi Limiti Belirleme
                            </h1>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" valign="top">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td align="right" valign="top">
                            <p>
                                Almak istediðiniz<br />
                                Pik Kredi miktarý</p>
                        </td>
                        <td>
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                <ContentTemplate>
                                    <table>
                                        <tr>
                                            <td>
                                                <asp:TextBox ID="txtCredits" runat="server" MaxLength="8"></asp:TextBox></td>
                                            <td>
                                                <asp:ImageButton ID="btnCalculate" runat="server" ImageUrl="~/images/buttons/calculate.png"
                                                    OnClick="btnCalculate_Click" ValidationGroup="vgPikCredi" />
                                                <asp:RequiredFieldValidator ID="errPikcreditexist" runat="server" Display="Dynamic"
                                                    ControlToValidate="txtCredits" ErrorMessage="Lütfen bir pik kredi miktarý giriniz"
                                                    ValidationGroup="vgPikCredi"></asp:RequiredFieldValidator>
                                                <asp:RangeValidator ID="errMinPikCredi" MaximumValue="99999" runat="server" ErrorMessage=""
                                                    Display="Dynamic" ControlToValidate="txtCredits" ValidationGroup="vgPikCredi" Type="Integer"></asp:RangeValidator>
                                            </td>
                                        </tr>
                                    </table>
                                    <p>
                                        &nbsp;</p>
                                    <p class="infoMsg">
                                    <asp:Label runat="server" ID="pnlCalcMsg" Visible="false">
                                        <asp:Label ID="lbCredits" runat="server"></asp:Label>
                                        Pik Kredi = <strong>
                                            <asp:Label ID="lbPrice" runat="server"></asp:Label>
                                            YTL</strong> 
                                        </asp:Label>
                                            
                                        (1 Pik Kredi =
                                        <asp:Label ID="lbCreditMultiplier" runat="server"></asp:Label>
                                        YTL)&nbsp;&nbsp;|&nbsp;&nbsp;<asp:LinkButton ID="lbChangePackage" runat="server" Text="Paketi deðiþtir" OnClick="lbChangePackage_Click"></asp:LinkButton></p>
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
                            <asp:ImageButton ID="btnContinue" runat="server" ImageUrl="~/images/buttons/corp_continue.png"
                                Width="137" Height="27" border="0" OnClick="btnContinue_Click1" CausesValidation="false" ValidationGroup="vgPikCredi"/>
                        </td>
                    </tr>
                </table>
                <div class="brclear">
                </div>
            </div>
        </div>
        <div class="BoxContentBottom">
        </div>
        <p>
            &nbsp;</p>
    </div>
