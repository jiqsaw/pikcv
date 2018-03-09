<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uTestResults.ascx.cs" Inherits="UserControls_Employee_Membership_uTestResults" %>
<%@ Register Src="../Common/uCVTabs.ascx" TagName="uCVTabs" TagPrefix="uc1" %>

<div class="contentPad">
      <div class="HeaderPR floatLeft">
        <h2 class="sIFRHeader">Test Sonuçlarý</h2>
      </div>
      
        <uc1:uCVTabs ID="UCVTabs1" runat="server" />
      
      <div class="brclear"></div>
      <!-- start roundcornered box -->
      <div class="BoxContentTop"></div>
      <div class="BoxContent">
        <div class="BoxPadder">
          <p>&nbsp;</p>
          <ul class="SubTab">
            <li id="liMAT" runat="server" class="selected"><a href="javascript:;">Genel Yetenek Testi</a></li>
            <li id="liYET" runat="server">
                <asp:HyperLink runat="server" ID="hlYetResult" NavigateUrl="">
                Yetkinlik Testi</asp:HyperLink></li>
          </ul>
          <div class="brclear"></div>
          <p>&nbsp;</p>
          <table width="100%" class="TestResultTable">
            <tr>
              <td class="empty">&nbsp;</td>
              <td colspan="7" style="border:none;"><h2><strong>Genel Yetenek Testi</strong></h2></td>
            </tr>
            <tr>
              <td class="empty">&nbsp;</td>
              <td colspan="7" style="border-top:none;padding-bottom:10px;">Test tarihi: <asp:Literal runat="server" ID="ltlTestDate"></asp:Literal> </td>
            </tr>
            
            <tr>
              <td>&nbsp;</td>
              <td align="center" valign="top" class="cell header"> <asp:Literal runat="server" ID="ltlGroupName1"></asp:Literal> </td>
              <td align="center" valign="top" class="cell header"> <asp:Literal runat="server" ID="ltlGroupName2"></asp:Literal> </td>
              <td align="center" valign="top" class="cell header"> <asp:Literal runat="server" ID="ltlGroupName3"></asp:Literal> </td>
              <td align="center" valign="top" class="cell header"> <asp:Literal runat="server" ID="ltlGroupName4"></asp:Literal> </td>
              <td align="center" valign="top" class="cell header"> <asp:Literal runat="server" ID="ltlGroupName5"></asp:Literal> </td>
              <td align="center" valign="top" class="cell header"> <asp:Literal runat="server" ID="ltlGroupName6"></asp:Literal> </td>
              <td align="center" class="cell" style="border-bottom:none">Toplam</td>
            </tr>
            <tr id="trLevelCode" runat="server" visible="true">
              <td align="right" class="cell">Sonuç</td>
              <td align="center" class="cell"><strong> <asp:Literal runat="server" ID="ltlLevelCode1"></asp:Literal> </strong></td>
              <td align="center" class="cell"><strong> <asp:Literal runat="server" ID="ltlLevelCode2"></asp:Literal> </strong></td>
              <td align="center" class="cell"><strong> <asp:Literal runat="server" ID="ltlLevelCode3"></asp:Literal> </strong></td>
              <td align="center" class="cell"><strong> <asp:Literal runat="server" ID="ltlLevelCode4"></asp:Literal> </strong></td>
              <td align="center" class="cell"><strong> <asp:Literal runat="server" ID="ltlLevelCode5"></asp:Literal> </strong></td>
              <td align="center" class="cell"><strong> <asp:Literal runat="server" ID="ltlLevelCode6"></asp:Literal> </strong></td>
              <td align="center" class="cell" style="border-bottom:none;border-top:none">&nbsp;</td>
            </tr>
            <tr>
              <td align="right" class="cell">Skor</td>
              <td align="center" class="cell"><strong> <asp:Literal runat="server" ID="ltlPoint1"></asp:Literal> </strong></td>
              <td align="center" class="cell"><strong> <asp:Literal runat="server" ID="ltlPoint2"></asp:Literal> </strong></td>
              <td align="center" class="cell"><strong> <asp:Literal runat="server" ID="ltlPoint3"></asp:Literal> </strong></td>
              <td align="center" class="cell"><strong> <asp:Literal runat="server" ID="ltlPoint4"></asp:Literal> </strong></td>
              <td align="center" class="cell"><strong> <asp:Literal runat="server" ID="ltlPoint5"></asp:Literal> </strong></td>
              <td align="center" class="cell"><strong> <asp:Literal runat="server" ID="ltlPoint6"></asp:Literal> </strong></td>
              <td align="center" class="cell" style="border-bottom:none;border-top:none"><strong>
                <asp:Literal runat="server" ID="ltlTotalScore"></asp:Literal>
              </strong></td>            
            </tr>
            <tr class="bar" style="height: 92px">
              <td style="background:none;">&nbsp;</td>
              <td align="center" valign="bottom"> <asp:Image runat="server" ImageUrl="~/Images/misc/test_bar.png" ID="imgBar1" Width="18" /> </td>
              <td align="center" valign="bottom"> <asp:Image runat="server" ImageUrl="~/Images/misc/test_bar.png" ID="imgBar2" Width="18" /> </td>
              <td align="center" valign="bottom"> <asp:Image runat="server" ImageUrl="~/Images/misc/test_bar.png" ID="imgBar3" Width="18" /> </td>
              <td align="center" valign="bottom"> <asp:Image runat="server" ImageUrl="~/Images/misc/test_bar.png" ID="imgBar4" Width="18" /> </td>
              <td align="center" valign="bottom"> <asp:Image runat="server" ImageUrl="~/Images/misc/test_bar.png" ID="imgBar5" Width="18" /> </td>
              <td align="center" valign="bottom"> <asp:Image runat="server" ImageUrl="~/Images/misc/test_bar.png" ID="imgBar6" Width="18" /> </td>
              <td align="center" valign="bottom" style="background:none">
              
                <asp:Image runat="server" ImageUrl="~/Images/misc/test_bar.png" ID="imgBarResult" Width="18" />

              </td>
            </tr>
            <tr>
              <td style="border-bottom:none;">&nbsp;</td>
              <td colspan="7" style="padding:10px 0;border-bottom:none;">
                <strong>Sonuç:</strong> 
                <asp:Literal runat="server" ID="ltlResultDescription"></asp:Literal>
              </td>
            </tr>
          </table>
          <p>&nbsp;
            <asp:HyperLink runat="server" ID="hlTestInfo" NavigateUrl="#Employee-Membership-Tests&TestType=0&Ref=1">
            Test Bilgileri</asp:HyperLink>
          </p>
          <div class="brclear"></div>
        </div>
      </div>
      <div class="BoxContentBottom"></div>
  <!-- finish roundcornered box -->
  <p>&nbsp;</p>
</div>