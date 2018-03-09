<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uTransactionsDetails.ascx.cs"
    Inherits="UserControls_Company_Transactions_uTransactionsDetails" %>
<%@ Register Src="../../Common/uPaging.ascx" TagName="uPaging" TagPrefix="uc1" %>
<div id="content">
    <div class="contentPad">
        <div class="HeaderPR floatLeft">
            <h2 class="sIFRHeader">
                ��lemlerim / 
                <asp:Literal Visible="false" runat="server" ID="ltlTransaction_non_invoiced" Text="Faturalanmam�� ��lemlerim"></asp:Literal>
                <asp:Literal Visible="false" runat="server" ID="ltlTransaction_unpaid" Text="�demesi Bekleyen ��lemlerim"></asp:Literal>
                <asp:Literal Visible="false" runat="server" ID="ltlTransaction_paid" Text="�denmi� ��lemlerim"></asp:Literal>
            </h2>
        </div>
        <div class="SectionCombo" style="text-align: right">
            <asp:DropDownList ID="ddlTransactionType" runat="server" OnSelectedIndexChanged="ddlTransactionType_SelectedIndexChanged"
                AutoPostBack="true">
                <asp:ListItem Text="��lemlerim..." Selected="True" Value="0"></asp:ListItem>
                <asp:ListItem Text="Faturalanmam�� ��lemlerim" Value="1"></asp:ListItem>
                <asp:ListItem Text="�demesi Bekleyen ��lemlerim" Value="2"></asp:ListItem>
                <asp:ListItem Text="�demesi Yap�lm�� ��lemlerim" Value="3"></asp:ListItem>
                <asp:ListItem Text="��lem Raporu" Value="4"></asp:ListItem>
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
                                    <strong>��lem a��klamas� </strong>
                                </th>
                                <th nowrap="nowrap">
                                    <strong>Tutar </strong>
                                </th>
                                <th nowrap="nowrap">
                                    <strong>��lem Tarihi </strong>
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
                                <%# Convert.ToBoolean( Eval("isConfirmed"))? "Onayland�" : "Onay Bekliyor." %>
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
                                <%# Convert.ToBoolean( Eval("isConfirmed"))? "Onayland�" : "Onay Bekliyor." %>
                            </td>
                        </tr>
                    </AlternatingItemTemplate>
                    <FooterTemplate>
                        </table>
                    </FooterTemplate>
                </asp:Repeater>
                
                <p>
                <asp:Literal runat="server" ID="ltlNoRecord" Visible="false">
                    Kay�tl� i�leminiz bulunmamaktad�r.
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
