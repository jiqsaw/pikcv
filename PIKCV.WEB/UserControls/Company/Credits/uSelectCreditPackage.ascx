<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uSelectCreditPackage.ascx.cs" Inherits="UserControls_Company_Credits_uSelectCreditPackage" %>

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
                            Paket seçimi</h1>
                    </td>
                </tr>
                <tr>
                    <td align="right" valign="top">
                        <p>
                            Pik Kredi paketleri</p>
                    </td>
                    <td>
                        <table>
                            <tr>
                                <td>
                                    <asp:RadioButtonList ID="rbCreditPackages" runat="server"></asp:RadioButtonList>
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
                        <asp:ImageButton ID="btnContinue" runat="server" ImageUrl="~/images/buttons/corp_continue.png" width="137" height="27" border="0" OnClick="btnContinue_Click" />
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
