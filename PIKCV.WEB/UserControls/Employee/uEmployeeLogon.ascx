<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uEmployeeLogon.ascx.cs" Inherits="UserControls_Employee_uEmployeeLogon" %>
<%@ Register Src="Common/uMainJobs.ascx" TagName="uMainJobs" TagPrefix="uc2" %>
<%@ Register Src="Common/uNotification.ascx" TagName="uNotification" TagPrefix="uc1" %>
<%@ Register Src="Common/uTeaser.ascx" TagName="uTeaser" TagPrefix="uc1" %>
<uc1:uTeaser ID="UTeaser1" runat="server" />
<div class="contentPad">
    
    <uc1:uNotification id="UNotification1" runat="server"></uc1:uNotification>
    
  <p>&nbsp;</p>
  <asp:Panel ID="pnlCustomJobs" runat="server">
        <div class="HeaderPR floatLeft">
        <h2 class="sIFRHeader" style="width:200px;"><asp:Literal runat="server" ID="ltlTitleFittingJob">Size uygun ilanlar</asp:Literal></h2>
        </div>
      
        <div id="Tab">
            <ul>
                <li id="li1" class="TabActive"><a href="javascript:MainJobsTabChange();"> <span> <asp:Literal runat="server" ID="ltlPrimaryTen">Ýlk 10</asp:Literal> </span> </a></li>
                <li id="li2"><a href="javascript:MainJobsTabChange();"><span><asp:Literal runat="server" ID="ltlSecondTen">Ýkinci 10</asp:Literal></span></a></li>
                <li class="NoTab">
                    <asp:HyperLink runat="server" ID="hlSearchJob" NavigateUrl="#Employee-Jobs-DetailJobSearch">Ýlan Arama</asp:HyperLink>
                </li>
            </ul>
        </div>
      
        <div class="brclear"></div>
        <!-- start roundcornered box -->
        <div class="BoxContentTop"></div>
        
        <div class="BoxContent">
        <div class="BoxPadder">

        <div class="adListLogon" id="MainJobs1" style="width: 100%">

            <asp:DataList runat="server" ID="dlMainJobs1" RepeatColumns="2" RepeatDirection="Horizontal">
                <HeaderTemplate>
                    <ul>
                </HeaderTemplate>
                <ItemTemplate>
                    <li style="width: 100%">
                        <asp:HyperLink runat="server" ID="hlDetailLink" NavigateUrl='<%#DataBinder.Eval(Container.DataItem, "JobID", "#Employee-Jobs-JobDetail&JobID={0}") %>'>
                            <strong> <%#DataBinder.Eval(Container.DataItem, "CompanyName") %> </strong><br />
                                <%#DataBinder.Eval(Container.DataItem, "PositionName") %>
                        </asp:HyperLink>
                    </li>
                </ItemTemplate>
                <FooterTemplate>
                    </ul>
                </FooterTemplate>
            </asp:DataList>

        </div>

        <div class="adList" id="MainJobs2" style="display: none; width: 100%;">
            <ul>

            <asp:DataList runat="server" ID="dlMainJobs2" RepeatColumns="2" RepeatDirection="Horizontal">
                <ItemTemplate>
                    <li style="width: 100%">
                        <a href='<%#DataBinder.Eval(Container.DataItem, "JobID", "#Employee-Jobs-JobDetail&JobID={0}") %>'>
                            <strong> <%#DataBinder.Eval(Container.DataItem, "CompanyName") %> </strong><br />
                            <%#DataBinder.Eval(Container.DataItem, "PositionName") %>
                        </a>
                    </li>
                </ItemTemplate>
            </asp:DataList>

            </ul>
        </div>

          <div class="brclear"></div>
        </div>
        </div>

        <div class="BoxContentBottom"></div>
        <!-- finish roundcornered box -->
  </asp:Panel>
  <uc2:uMainJobs ID="UMainJobs1" runat="server" />
</div>

<div id="dvScript" runat="server"></div>