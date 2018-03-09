<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uInterview.ascx.cs" Inherits="UserControls_Company_Interview_uInterview" %>
<%@ Register Src="../../Common/uList.ascx" TagName="uList" TagPrefix="uc2" %>
<%@ Register Src="../Common/uInterviewTabs.ascx" TagName="uInterviewTabs" TagPrefix="uc1" %>
<div class="contentPad">
    <div class="HeaderPB floatLeft">
        <h2 class="sIFRHeader">
            Mülakatlarým</h2>
    </div>
    <div id="Tab">
        <uc1:uInterviewTabs ID="UInterviewTabs1" runat="server"></uc1:uInterviewTabs>
    </div>
    <div class="brclear">
    </div>
    <!-- start roundcornered box -->
    <div class="BoxContentTop">
    </div>
    <div class="BoxContent">
        <div class="BoxPadder">
        <p>
            <asp:Label ID="lbMessage" runat="server" Visible="false"></asp:Label>
       </p>
        <asp:Panel runat="server" ID="pnlInterviewRpt">

            <table width="100%" class="dataGrid">
                <asp:Repeater ID="rptInterviews" runat="server" OnItemDataBound="rptInterviews_ItemDataBound"
                    Visible="false">
                    <HeaderTemplate>
                        <tr>
                            <th nowrap="nowrap">
                                <strong>Danýþman</strong></th>
                            <th nowrap="nowrap">
                                <strong>Kiþi</strong></th>
                            <th nowrap="nowrap">
                                <strong>Tarih</strong></th>
                            <th nowrap="nowrap">
                                <strong>Saat</strong></th>
                            <th nowrap="nowrap">
                                <strong>Mülakat Sonucu </strong>
                            </th>
                            <th nowrap="nowrap">
                                &nbsp;</th>
                        </tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr class="odd">
                            <td>
                                <asp:Label ID="lbAdvisorFirstName" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "AdvisorFirstName")%>'></asp:Label>&nbsp;
<%--                                <asp:Label ID="lbAdvisorLastName" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "AdvisorLastName")%>'></asp:Label>--%>
                            </td>
                            <td>
                                <asp:Label ID="lbFirstName" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "FirstName")%>'></asp:Label>&nbsp;
                                <asp:Label ID="lbLastName" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "LastName")%>'></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lbInterviewDate" runat="server" Text='<%# String.Format("{0:d}", DataBinder.Eval(Container.DataItem, "InterviewDate"))%>'></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lbInterviewStartTime" runat="server" Text='<%# String.Format("{0:t}",DataBinder.Eval(Container.DataItem, "InterviewStartTime"))%>'></asp:Label>-
                                <asp:Label ID="lbInterviewEndTime" runat="server" Text='<%# String.Format("{0:t}",DataBinder.Eval(Container.DataItem, "InterviewEndTime"))%>'></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="drpInterviewStatus" runat="server" OnSelectedIndexChanged="drpInterviewStatus_SelectedIndexChanged"
                                    AutoPostBack="true">
                                </asp:DropDownList>
                                <asp:HiddenField ID="hfInterviewID" runat="server" Value='<%#DataBinder.Eval(Container.DataItem, "InterviewID")%>' />
                                <asp:HiddenField ID="hfInerviewStatusID" runat="server" Value='<%#DataBinder.Eval(Container.DataItem, "InterviewStatusID")%>' />
                            </td>
                            <td>
                                <asp:HyperLink ID="hplDelete" runat="server" Text="Sil" NavigateUrl='<%#DataBinder.Eval(Container.DataItem, "InterviewID", "#Company-Interview-Interview&InterviewID={0}") %>'></asp:HyperLink>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
                <asp:Repeater ID="rptGeneralInterviews" runat="server" Visible="false">
                    <HeaderTemplate>
                        <tr>
                            <th nowrap="nowrap">
                                <strong>Pozisyon</strong></th>
                        </tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr class="odd">
                            <td>
                                <asp:HyperLink ID="hplPosition" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "PositionName")%>'
                                    NavigateUrl='<%#DataBinder.Eval(Container.DataItem, "PositionID", "#Company-Interview-Interview&InterviewType=0&PositionID={0}") %>'></asp:HyperLink>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
                <asp:Repeater ID="rptPositionInterviews" runat="server" Visible="false">
                    <HeaderTemplate>
                        <tr>
                            <th nowrap="nowrap">
                                <strong>Danýþman</strong></th>
                            <th nowrap="nowrap">
                                <strong>Kiþi</strong></th>
                            <th nowrap="nowrap">
                                <strong>Tarih</strong></th>
                            <th nowrap="nowrap">
                                <strong>Saat</strong></th>
                            <th nowrap="nowrap">
                                <strong>Yer</strong>
                            </th>
                            <th nowrap="nowrap">
                                &nbsp;</th>
                        </tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr class="odd">
                            <td>
                                <asp:Label ID="lbAdvisorFirstName" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "FirstName")%>'></asp:Label>&nbsp;
                                <%--<asp:Label ID="lbAdvisorLastName" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "LastName")%>'></asp:Label>--%>
                            </td>
                            <td>
                                <asp:Label ID="lbInterviewCount" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "InterviewCount")%>'></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lbInterviewDate" runat="server" Text='<%# String.Format("{0:d}", DataBinder.Eval(Container.DataItem, "InterviewDate"))%>'></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lbInterviewStartTime" runat="server" Text='<%# String.Format("{0:t}",DataBinder.Eval(Container.DataItem, "InterviewStartTime"))%>'></asp:Label>-
                                <asp:Label ID="lbInterviewEndTime" runat="server" Text='<%# String.Format("{0:t}",DataBinder.Eval(Container.DataItem, "InterviewEndTime"))%>'></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lbInterviewPlace" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "InterviewPlace")%>'></asp:Label>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
        
        </asp:Panel>

            <div class="brclear"></div>
            <div class="brclear"></div>
        </div>
        
    </div>
    <div class="BoxContentBottom">
    </div>
    <!-- finish roundcornered box -->
</div>
