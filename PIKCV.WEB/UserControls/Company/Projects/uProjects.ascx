<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uProjects.ascx.cs" Inherits="UserControls_Company_Projects_uProjects" %>
<div class="contentPad">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="HeaderPR floatLeft">
                <h2 class="sIFRHeader">
                    Projelerim</h2>
            </div>
            <div class="SectionCombo">
                <asp:DropDownList ID="ddlProjects" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlProjects_SelectedIndexChanged">
                </asp:DropDownList>
            </div>
            <div class="brclear">
            </div>
            <div class="BoxContentTop">
            </div>
            <div class="BoxContent">
                <div class="BoxPadder">
                <p>
                    <asp:Label ID="lbMessage" runat="server" Text="Herhangi bir projeniz bulunmamaktadýr."
                        Visible="false"></asp:Label>
                </p>
                    <asp:Panel ID="pnlProjects" runat="server">
                        <h3>
                            <asp:Label ID="lbProjectName" runat="server"></asp:Label>&nbsp;(<asp:Label ID="lbProjectDate"
                                runat="server"></asp:Label>)</h3>
                        <p>
                            &nbsp;</p>
                        <p>
                            Proje bedeli: <strong>
                                <asp:Label ID="lbProjectPrice" runat="server"></asp:Label>&nbsp;YTL</strong>
                        </p>
                        <p>
                            &nbsp;</p>
                        <table width="100%" class="dataGrid">
                            <asp:Repeater ID="rptProejects" runat="server">
                                <HeaderTemplate>
                                    <tr>
                                        <th>
                                            <strong>Pozisyon </strong>
                                        </th>
                                        <th>
                                            <strong>Eleman tipi</strong>
                                        </th>
                                        <th>
                                            <strong>Alýmý Ýstenen</strong>
                                        </th>
                                        <th>
                                            <strong>Þirkete Ýletilen</strong>
                                        </th>
                                        <th>
                                            <strong>Ýþe Alýnan</strong>
                                        </th>
                                        <th>
                                            <strong>Kalan kiþi</strong></th>
                                        <th>
                                            <strong>Durum</strong></th>
                                        <th>
                                            &nbsp;</th>
                                    </tr>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <tr>
                                        <td>
                                            <asp:Label ID="lbProjectPosition" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "PositionName") %>'></asp:Label>
                                        </td>
                                        <td>
                                            <asp:Label ID="lbEmployeeType" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "EmployeeType") %>'></asp:Label>
                                        </td>
                                        <td>
                                            <asp:Label ID="lbWantedEmployeeCount" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "WantedEmployeeCount") %>'></asp:Label></td>
                                        <td>
                                            <asp:Label ID="lbFoundEmployeeCount" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "FoundEmployeeCount") %>'></asp:Label></td>
                                        <td>
                                            <asp:Label ID="lbCompanyTakenToWork" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "FoundEmployeeCount") %>'></asp:Label></td>
                                        <td>
                                            <asp:Label ID="lbRemainingEmployeeCount" runat="server" Text='<%#(Convert.ToInt32(DataBinder.Eval(Container.DataItem, "WantedEmployeeCount")) - Convert.ToInt32(DataBinder.Eval(Container.DataItem, "FoundEmployeeCount"))).ToString() %>'></asp:Label></td>
                                        <td>
                                            <asp:Label ID="lbCustomProjectStateName" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "CustomProjectStateName") %>'></asp:Label></td>
                                        <td>
                                            <div class="ChartHorizontalBar">
                                                <div class="ChartBar" style="width: <%#(((Convert.ToInt32(DataBinder.Eval(Container.DataItem, "FoundEmployeeCount")) * 100) / Convert.ToInt32(DataBinder.Eval(Container.DataItem, "WantedEmployeeCount")))).ToString() %>px;">
                                                </div>
                                                &nbsp;%<asp:Label ID="lbPercentage" runat="server" Text='<%#(((Convert.ToInt32(DataBinder.Eval(Container.DataItem, "FoundEmployeeCount")) * 100) / Convert.ToInt32(DataBinder.Eval(Container.DataItem, "WantedEmployeeCount")))).ToString() %>'></asp:Label></div>
                                        </td>
                                    </tr>
                                </ItemTemplate>
                            </asp:Repeater>
                            <tr>
                                <td>
                                    <strong>Genel toplam</strong></td>
                                    <td>
                                    &nbsp;
                                    </td>
                                <td>
                                    <strong>
                                        <asp:Label ID="lbTotalWantedEmployee" runat="server"></asp:Label></strong></td>
                                <td>
                                    <strong>
                                        <asp:Label ID="lbTotalFoundEmployeeCount" runat="server"></asp:Label></strong></td>
                                        <td>
                                    <strong>
                                        <asp:Label ID="Label1" runat="server"></asp:Label></strong></td>
                                <td>
                                    <strong>
                                        <asp:Label ID="lbTotalRemainingEmployeeCount" runat="server"></asp:Label></strong></td>
                                <td>
                                    &nbsp;</td>
                                <td>
                                    <div class="ChartHorizontalBar">
                                        <div class="ChartBar" runat="server" id="ChartBarTotal">
                                        </div>
                                        &nbsp;%<asp:Label ID="lbTotalPercentage" runat="server"></asp:Label></div>
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                    <div class="brclear">
                    </div>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</div>
