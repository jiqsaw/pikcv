<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uTransactionsDetails.ascx.cs"
    Inherits="UserControls_Company_Transactions_uTransactionsDetails" %>
<%@ Register Src="../../Common/uPaging.ascx" TagName="uPaging" TagPrefix="uc1" %>
<div id="content">
    <div class="contentPad">
        <div class="HeaderPR floatLeft">
            <h2 class="sIFRHeader">
                Ýþlemlerim / 
                <asp:Literal Visible="false" runat="server" ID="ltlTransaction_non_invoiced" Text="Faturalanmamýþ Ýþlemlerim"></asp:Literal>
                <asp:Literal Visible="false" runat="server" ID="ltlTransaction_unpaid" Text="Ödemesi Bekleyen Ýþlemlerim"></asp:Literal>
                <asp:Literal Visible="false" runat="server" ID="ltlTransaction_paid" Text="Ödenmiþ Ýþlemlerim"></asp:Literal>
            </h2>
        </div>
        <div class="SectionCombo" style="text-align: right">
            <asp:DropDownList ID="ddlTransactionType" runat="server" OnSelectedIndexChanged="ddlTransactionType_SelectedIndexChanged"
                AutoPostBack="true">
                <asp:ListItem Text="Ýþlemlerim..." Selected="True" Value="0"></asp:ListItem>
                <asp:ListItem Text="Faturalanmamýþ Ýþlemlerim" Value="1"></asp:ListItem>
                <asp:ListItem Text="Ödemesi Bekleyen Ýþlemlerim" Value="2"></asp:ListItem>
                <asp:ListItem Text="Ödemesi Yapýlmýþ Ýþlemlerim" Value="3"></asp:ListItem>
                <asp:ListItem Text="Ýþlem Raporu" Value="4"></asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="brclear">
        </div>
        <div class="BoxContentTop">
        </div>
        <div class="BoxContent">
            <div class="BoxPadder">
                <p>
                    &nbsp;</p>
                <asp:Repeater ID="rptTransactions" runat="server">
                    <HeaderTemplate>
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
                                    <strong>Durum</strong></th>
                            </tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr class="odd">
                            <td>
                                <strong>
                                    <%# Eval("OrderTypeName")%> (<%# Eval("TotalCreditsUsed")%>)
                                </strong>
                            </td>
                            <td>
                                <%# Eval("Price")%>
                                YTL
                            </td>
                            <td>
                                <%# Eval("OrderDate")%>
                            </td>
                            <td>
                                <%# Convert.ToBoolean( Eval("isConfirmed"))? "Onaylandý" : "Onay Bekliyor." %>
                            </td>
                        </tr>
                    </ItemTemplate>
                    <AlternatingItemTemplate>
                    <tr class="even">
                            <td>
                                <strong>
                                    <%# Eval("OrderTypeName")%>
                                </strong>
                            </td>
                            <td>
                                <%# Eval("Price")%>
                                YTL
                            </td>
                            <td>
                                <%# Eval("OrderDate")%>
                            </td>
                            <td>
                                <%# Convert.ToBoolean( Eval("isConfirmed"))? "Onaylandý" : "Onay Bekliyor." %>
                            </td>
                        </tr>
                    </AlternatingItemTemplate>
                    <FooterTemplate>
                        </table>
                    </FooterTemplate>
                </asp:Repeater>
                
                <p>
                <asp:Literal runat="server" ID="ltlNoRecord" Visible="false">
                    Kayýtlý iþleminiz bulunmamaktadýr.
                </asp:Literal>
                </p>
                
                <div class="brclear">
                </div>
            </div>
        </div>
        <div class="BoxContentBottom">
        </div>
        <!-- finish roundcornered box -->
        <p>
            <uc1:uPaging ID="UPaging1" runat="server" />
            &nbsp;</p>
    </div>

</div>
