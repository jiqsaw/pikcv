<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uSelectPaymentType.ascx.cs"
    Inherits="UserControls_Company_Credits_uSelectPaymentType" %>
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
            <asp:Panel ID="pnlHeader" runat="server">
                <table width="100%" class="FormTable">
                    <tr>
                        <td align="right" valign="top">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td align="right" valign="top">
                            Paket detayý:
                        </td>
                        <td>
                            <strong>
                                <asp:Label ID="lbCredits" runat="server"></asp:Label>
                                Pik Kredi</strong> (<asp:Label ID="lbPrice" runat="server"></asp:Label>&nbsp;YTL)&nbsp;&nbsp;|&nbsp;&nbsp;<a
                                    href="#Company-Credits-SelectCreditPackage">Paketi deðiþtir</a>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" valign="top">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                </table>
            </asp:Panel>
            <asp:Panel ID="pnlPackageDetail" runat="server">
                <table width="100%" class="FormTable">
                    <tr>
                        <td align="right" valign="top">
                            Lütfen ödeme tipini belirleyin:</td>
                        <td>
                            <table>
                                <asp:Panel ID="pnlPaymentTypeLoan" runat="server">
                                    <tr>
                                        <td>
                                            <asp:RadioButton ID="rbLoan" runat="server" Text="Borçlandýrma" GroupName="PaymentType"
                                                Checked="true" />&nbsp;&nbsp;&nbsp;
                                        </td>
                                        <td>
                                            <p class="mute">
                                                Pik kredi alýmýnýz tarafýnýza faturalandýrýlacaktýr</p>
                                        </td>
                                    </tr>
                                </asp:Panel>
                                <tr>
                                    <td>
                                        <asp:RadioButton ID="rbTransfer" runat="server" Text="Havale / EFT" GroupName="PaymentType" />&nbsp;&nbsp;&nbsp;
                                    </td>
                                    <td>
                                        <p class="mute">
                                            2 gün içinde ödemesi yapýlmayan iþlemler iptal edilecektir</p>
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
                                Width="137" Height="27" border="0" OnClick="btnSubmit_Click" />
                        </td>
                    </tr>
                </table>
            </asp:Panel>
            <asp:Panel ID="pnlLoan" runat="server" Visible="false">
                <table width="100%" class="FormTable">
                    <tr>
                        <td align="right">
                            &nbsp;</td>
                        <td>
                            <strong>(Pik kredi alýmýnýz tarafýnýza faturalandýrýlacaktýr)</strong></td>
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
                            <asp:ImageButton ID="btnContinueLoad" runat="server" ImageUrl="~/images/buttons/corp_ok.png"
                                Width="106" Height="27" border="0" OnClick="btnContinueLoad_Click" />
                        </td>
                    </tr>
                </table>
            </asp:Panel>
            <asp:Panel ID="pnlTransfer" runat="server" Visible="false">
                <table width="100%" class="FormTable">
                    <tr>
                        <td align="right" valign="top">
                            &nbsp;</td>
                        <td>
                            <p class="infoMsg">
                                Lütfen ödemenizi en geç 2 gün içinde aþaðýda detaylarý belirtilen bankaya yapýnýz<br />
                                2 gün içinde ödemesi yapýlmayan iþlemler iptal edilecektir.</p>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" valign="top">
                            &nbsp;</td>
                        <td>
                            <table>
                                <tr>
                                    <td align="right">
                                        Banka adý / Banka kodu:</td>
                                    <td>
                                            <strong>Akbank-0046</strong>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        Þube adý / Þube kodu:</td>
                                    <td>
                                            <strong>Maslak / 0645 </strong>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        Hesap numarasý:</td>
                                    <td>
                                        <strong>60790 - 3</strong></td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        Hesap adý:</td>
                                    <td>
                                        <strong>Perakende Ýnsan Kaynaklarý Ltd. Þti.</strong></td>
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
                            <asp:ImageButton ID="btnContinueTransfer" runat="server" ImageUrl="~/images/buttons/corp_continue.png"
                                Width="137" Height="27" border="0" OnClick="btnContinueTransfer_Click" />
                        </td>
                    </tr>
                </table>
            </asp:Panel>
            <asp:Panel ID="pnlApproval" runat="server" Visible="false">
<%--                <h2>
                    <strong>Ýþlem onayý</strong>
                </h2>--%>
                <p>
                    &nbsp;</p>
                <div id="dvMsg" runat="server" class="infoMsg">
                    <p>
                        <asp:Label ID="lbApprovalMessage" runat="server"></asp:Label></p>
                </div>
                <p>&nbsp;</p>
                <table width="100%" class="dataGrid">
                    <tr>
                        <th>
                            <strong>Ýþlem açýklamasý </strong>
                        </th>
                        <th nowrap="nowrap">
                            <strong>Tutar </strong>
                        </th>
                        <th nowrap="nowrap">
                            <strong>Ýþlem Tarihi </strong>
                        </th>
                        <th>
                            <strong>Ödeme tipi </strong>
                        </th>
                    </tr>
                    <tr class="odd">
                        <td>
                            <strong>
                                <asp:Label ID="lbApprovalCreditPackageName" runat="server"></asp:Label></strong></td>
                        <td>
                            <asp:Label ID="lbApprovalPrice" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="lbOrderDate" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="lbOrderType" runat="server"></asp:Label>
                        </td>
                    </tr>
                </table>
            </asp:Panel>
            <div class="brclear">
            </div>
        </div>
    </div>
    <div class="BoxContentBottom">
    </div>
</div>
