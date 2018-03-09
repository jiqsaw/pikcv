<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uTransactionReport.ascx.cs"
    Inherits="UserControls_Company_Transactions_uTransactionReport" %>
<%@ Register Src="../../Common/uDate.ascx" TagName="uDate" TagPrefix="uc2" %>
<%@ Register Src="../../Common/uPaging.ascx" TagName="uPaging" TagPrefix="uc1" %>
<%@ register tagprefix="web" namespace="WebChart" assembly="WebChart"%>
<link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
    rel="stylesheet" type="text/css" />
<div class="contentPad">

        <div class="HeaderPR floatLeft">
            <h2 class="sIFRHeader">
                Ýþlemlerim / Ýþlem Raporu
            </h2>
        </div>
        
    <div class="brclear"></div>
    <div class="BoxContentTop">
    </div>
    <div class="BoxContent">
        <div class="BoxPadder">
        
            <table width="450" class="FormTable">
                <tr>
                    <td> <uc2:uDate ID="UOrderStartDate" runat="server" /> </td>
                    <td> ile </td>
                    <td> <uc2:uDate ID="UOrderEndDate" runat="server" /></td>
                    <td>
                        <asp:ImageButton ID="btn_search" runat="server" ImageUrl="~/Images/buttons/corp_search.png" 
                            OnClick="btn_search_Click" ValidationGroup="vgForm" />
                     </td>
                </tr>
            </table>
                        
            <asp:Repeater ID="rptReports" runat="server" OnItemDataBound="rptReports_ItemDataBound">
                <HeaderTemplate>
                    <table width="100%" class="dataGrid">
                        <tr>
                            <th>
                                <strong>Tarihi</strong></th>
                            <th>
                                <strong>Ýþlem<br /> Açýklamasý </strong>
                            </th>                           
                            <th>
                                <strong>Kullanýlan<br /> Pik Kredi </strong>
                            </th>
                            <th>
                                <strong>Kredi<br /> Bakiyesi</strong>
                            </th>                                                        
                            <th>
                                <strong>Alýnan<br /> Pik Kredi Tutarý</strong>
                            </th>
                        </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr class="odd">
                        <td>
                            <%# Convert.ToDateTime(Eval("OrderDate")).ToShortDateString() %>
                        </td>
                        <td>
                            <strong>
                                <%# Eval("Description") %>
                            </strong>
                        </td>
                        <td>
                            <%# (Eval("TotalCreditsUsed").ToString() == "0") ? "" : Eval("TotalCreditsUsed")%>
                        </td>                                                
                        <td>
                            <asp:Literal runat="server" ID="ltlRemainderCredit"></asp:Literal>
                            <asp:Literal runat="server" ID="ltlPriceForCalc" Text='<%#DataBinder.Eval(Container.DataItem, "Price") %>' Visible="false"></asp:Literal>
                            <asp:Literal runat="server" ID="ltlCreditForCalc" Text='<%#DataBinder.Eval(Container.DataItem, "CreditForCalc") %>' Visible="false"></asp:Literal>
                            <asp:Literal runat="server" ID="ltlOrderTypeForCalc" Text='<%#DataBinder.Eval(Container.DataItem, "OrderTypeID") %>' Visible="false"></asp:Literal>
                        </td>                        
                        <td>
                             <%# (Eval("Price").ToString() == "0") ? "" : Eval("Price") + " YTL"%>
                        </td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    <tr class="odd">
                        <td>
                            <strong>TOPLAM:</strong></td>
                        <td> &nbsp; </td>
                        <td> &nbsp; </td>
                        <td> <%=this.TotalPrice.ToString() %> YTL </td>
                        <td> <%=this.RemainderCredit.ToString()%> </td>
                    </tr>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
            <p>
                <b><asp:Literal runat="server" ID="ltlNoRecord" 
                Text="Kayýtlý iþlem bulunamadý" Visible="false"></asp:Literal>            
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
        &nbsp; &nbsp;</p>
        
        <web:chartcontrol runat="server" id="ChartControl1" height="400px" width="350" gridlines="None" legend-position="Bottom" TopPadding="0" >
            <YAxisFont StringFormat="Far,Near,Character,LineLimit" />
            <XTitle StringFormat="Center,Near,Character,LineLimit" />
            <ChartTitle StringFormat="Center,Near,Character,LineLimit" />
            <XAxisFont StringFormat="Center,Near,Character,LineLimit" />
            <YTitle StringFormat="Center,Near,Character,LineLimit" />
        </web:chartcontrol>

        
</div>