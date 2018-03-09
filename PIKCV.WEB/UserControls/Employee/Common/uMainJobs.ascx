<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uMainJobs.ascx.cs" Inherits="UserControls_Employee_Common_uMainJobs" %>
<div class="contentPad">
  <div class="HeaderPR floatLeft">
    <h2 class="sIFRHeader" style="width:200px;"><asp:Literal runat="server" ID="ltlTitleFittingJob">Ýlanlar</asp:Literal></h2>
  </div>
  <div id="Tab">
    <ul>
        <li id="li1" class="TabActive"><a href="javascript:MainJobsTabChange();"> <span> <asp:Literal runat="server" ID="ltlPrimaryTen">Ýlk 20</asp:Literal> </span> </a></li>
        <li id="li2"><a href="javascript:MainJobsTabChange();"><span><asp:Literal runat="server" ID="ltlSecondTen">Ýkinci 20</asp:Literal></span></a></li>
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
    
    <div class="adList" id="MainJobs1" style="width: 100%">
        

        <asp:DataList runat="server" ID="dlMainJobs1" RepeatColumns="2" RepeatDirection="Horizontal">
            <HeaderTemplate>
                <ul>
            </HeaderTemplate>
            <ItemTemplate>
                <li style="width: 100%">
                    <a href='<%#DataBinder.Eval(Container.DataItem, "JobID", "#Employee-Jobs-JobDetail&JobID={0}") %>'>
                        <strong> <%#DataBinder.Eval(Container.DataItem, "CompanyName") %> </strong><br />
                        <%#DataBinder.Eval(Container.DataItem, "PositionName") %>
                    </a>
                </li>
            </ItemTemplate>
            <SeparatorTemplate>
                <div style="width: 50px;"></div>
            </SeparatorTemplate>
            <FooterTemplate>
                </ul>
            </FooterTemplate>
        </asp:DataList>

    </div>

    <div class="adList" id="MainJobs2" style="display: none;">
        <ul>

        <asp:DataList runat="server" ID="dlMainJobs2" RepeatColumns="2" RepeatDirection="Horizontal">
            <ItemTemplate>
                <li>
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
</div>
<div id="dvScript" runat="server"></div>