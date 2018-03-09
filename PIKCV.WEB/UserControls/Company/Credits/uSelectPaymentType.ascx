<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uSelectPaymentType.ascx.cs"
    Inherits="UserControls_Company_Credits_uSelectPaymentType" %>
<div class="contentPad">
    <div class="HeaderPR floatLeft">
        <h2 class="sIFRHeader">
            Pik Kredi Sat�n Alma
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
                            Paket detay�:
                        </td>
                        <td>
                            <strong>
                                <asp:Label ID="lbCredits" runat="server"></asp:Label>
                                Pik Kredi</strong> (<asp:Label ID="lbPrice" runat="server"></asp:Label>&nbsp;YTL)&nbsp;&nbsp;|&nbsp;&nbsp;<a
                                    href="#Company-Credits-SelectCreditPackage">Paketi de�i�tir</a>
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
                            L�tfen �deme tipini belirleyin:</td>
                        <td>
                            <table>
                                <asp:Panel ID="pnlPaymentTypeLoan" runat="server">
                                    <tr>
                                        <td>
                                            <asp:RadioButton ID="rbLoan" runat="server" Text="Bor�land�rma" GroupName="PaymentType"
                                                Checked="true" />&nbsp;&nbsp;&nbsp;
                                        </td>
                                        <td>
                                            <p class="mute">
                                                Pik kredi al�m�n�z taraf�n�za faturaland�r�lacakt�r</p>
                                        </td>
                                    </tr>
                                </asp:Panel>
                                <tr>
                                    <td>
                                        <asp:RadioButton ID="rbTransfer" runat="server" Text="Havale / EFT" GroupName="PaymentType" />&nbsp;&nbsp;&nbsp;
                                    </td>
                                    <td>
                                        <p class="mute">
                                            2 g�n i�inde �demesi yap�lmayan i�lemler iptal edilecektir</p>
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
                            <strong>(Pik kredi al�m�n�z taraf�n�za faturaland�r�lacakt�r)</strong></td>
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
                                L�tfen �demenizi en ge� 2 g�n i�inde a�a��da detaylar� belirtilen bankaya yap�n�z<br />
                                2 g�n i�inde �demesi yap�lmayan i�lemler iptal edilecektir.</p>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" valign="top">
                            &nbsp;</td>
                        <td>
                            <table>
                                <tr>
                                    <td align="right">
                                        Banka ad� / Banka kodu:</td>
                                    <td>
                                            <strong>Akbank-0046</strong>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        �ube ad� / �ube kodu:</td>
                                    <td>
                                            <strong>Maslak / 0645 </strong>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        Hesap numaras�:</td>
                                    <td>
                                        <strong>60790 - 3</strong></td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        Hesap ad�:</td>
                                    <td>
                                        <strong>Perakende �nsan Kaynaklar� Ltd. �ti.</strong></td>
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
                    <strong>��lem onay�</strong>
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
                            <strong>��lem a��klamas� </strong>
                        </th>
                        <th nowrap="nowrap">
                            <strong>Tutar </strong>
                        </th>
                        <th nowrap="nowrap">
                            <strong>��lem Tarihi </strong>
                        </th>
                        <th>
                            <strong>�deme tipi </strong>
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
