<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uTestResultsPerfection.ascx.cs" Inherits="UserControls_Employee_Membership_uTestResultsPerfection" %>
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
            <li id="liMAT" runat="server">
                <asp:HyperLink runat="server" ID="hlMatResult" NavigateUrl="">
                Genel Yetenek Testi</asp:HyperLink></li>
            <li id="liYET" runat="server" class="selected"><a href="javascript:;">Yetkinlik Testi</a></li>
          </ul>
          <div class="brclear"></div>
          <p>&nbsp;</p>
          

          <table width="100%" class="TestResultTable">
            <tr>
              <td class="empty">&nbsp;</td>
              <td colspan="6" style="border:none;"><h2><strong>Yetkinlik Testi</strong></h2></td>
            </tr>
            <tr>
              <td class="empty">&nbsp;</td>
              <td colspan="6" style="border-top:none;padding-bottom:10px;">Test tarihi: <asp:Literal runat="server" ID="ltlTestDate"></asp:Literal></td>
            </tr>
            <tr>
              <td>&nbsp;</td>
              <td align="center" valign="top" class="cell header"> <asp:Literal runat="server" ID="ltlGroupName1"></asp:Literal> </td>
              <td align="center" valign="top" class="cell header"> <asp:Literal runat="server" ID="ltlGroupName2"></asp:Literal> </td>
              <td align="center" valign="top" class="cell header"> <asp:Literal runat="server" ID="ltlGroupName3"></asp:Literal> </td>
              <td align="center" valign="top" class="cell header"> <asp:Literal runat="server" ID="ltlGroupName4"></asp:Literal> </td>
              <td align="center" valign="top" class="cell header"> <asp:Literal runat="server" ID="ltlGroupName5"></asp:Literal> </td>
              <td align="center" valign="top" class="cell header"> <asp:Literal runat="server" ID="ltlGroupName6"></asp:Literal> </td>
            </tr>
            <tr id="trLevelCode" runat="server" visible="true">
              <td align="right" class="cell">Sonuç</td>
              <td align="center" class="cell"><strong> <asp:Literal runat="server" ID="ltlLevelCode1"></asp:Literal> </strong></td>
              <td align="center" class="cell"><strong> <asp:Literal runat="server" ID="ltlLevelCode2"></asp:Literal> </strong></td>
              <td align="center" class="cell"><strong> <asp:Literal runat="server" ID="ltlLevelCode3"></asp:Literal> </strong></td>
              <td align="center" class="cell"><strong> <asp:Literal runat="server" ID="ltlLevelCode4"></asp:Literal> </strong></td>
              <td align="center" class="cell"><strong> <asp:Literal runat="server" ID="ltlLevelCode5"></asp:Literal> </strong></td>
              <td align="center" class="cell"><strong> <asp:Literal runat="server" ID="ltlLevelCode6"></asp:Literal> </strong></td>
            </tr>
            <tr style="display: none;">
              <td align="right" class="cell" style="border-bottom:none;">Yönetici</td>
              <td align="center" class="cell" style="border-bottom:none;"><asp:Image runat="server" ID="imgFalse1" ImageUrl="~/Images/misc/false.png" /></td>
              <td align="center" class="cell" style="border-bottom:none;"><asp:Image runat="server" ID="imgFalse2" ImageUrl="~/Images/misc/false.png" /></td>
              <td align="center" class="cell" style="border-bottom:none;"><span class="cell" style="border-bottom:none;"><asp:Image runat="server" ID="imgFalse3" ImageUrl="~/Images/misc/false.png" /></span></td>
              <td align="center" class="cell" style="border-bottom:none;"><span class="cell" style="border-bottom:none;"><asp:Image runat="server" ID="imgFalse4" ImageUrl="~/Images/misc/false.png" /></span></td>
              <td align="center" class="cell" style="border-bottom:none;"><span class="cell" style="border-bottom:none;"><asp:Image runat="server" ID="imgFalse5" ImageUrl="~/Images/misc/false.png" /></span></td>
              <td align="center" class="cell" style="border-bottom:none;"><span class="cell" style="border-bottom:none;"><asp:Image runat="server" ID="imgFalse6" ImageUrl="~/Images/misc/false.png" /></span></td>
            </tr>
            
            <tr>
              <td align="right" valign="top" class="cell">&nbsp;</td>
              <td valign="top" class="cell"><p> <asp:Literal runat="server" ID="ltlResultDescription1"></asp:Literal></p></td>
              <td valign="top" class="cell"><p> <asp:Literal runat="server" ID="ltlResultDescription2"></asp:Literal></p></td>
              <td valign="top" class="cell"><p> <asp:Literal runat="server" ID="ltlResultDescription3"></asp:Literal></p></td>
              <td valign="top" class="cell"><p> <asp:Literal runat="server" ID="ltlResultDescription4"></asp:Literal></p></td>
              <td valign="top" class="cell"><p> <asp:Literal runat="server" ID="ltlResultDescription5"></asp:Literal></p></td>
              <td valign="top" class="cell"><p> <asp:Literal runat="server" ID="ltlResultDescription6"></asp:Literal></p></td>
            </tr>
          </table>          
          
          <p>
            <asp:HyperLink runat="server" ID="hlTestInfo" NavigateUrl="#Employee-Membership-Tests&TestType=1&Ref=1">
            Test Bilgileri</asp:HyperLink>          
          </p>
          <div class="brclear"></div>
        </div>
      </div>
      <div class="BoxContentBottom"></div>
  <!-- finish roundcornered box -->
  <p>&nbsp;</p>
</div>