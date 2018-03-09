<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uEntry.ascx.cs" Inherits="UserControls_Entry_uEntry" %>
<%@ Register Src="~/UserControls/Common/uFooter.ascx" TagName="uFooter" TagPrefix="uc2" %>

<table width="100%" border="0" cellpadding="0" cellspacing="0">
  <tr>
    <td valign="top" style="width:150px;"><div id="RibbonLeft"></div></td>
    <td><h1 id="logoPikcv">PÝKcv.com / Perakende Ýnsan Kaynaklarý</h1>
      <div class="DefaultLinks">
        <div><a href="javascript:;">Ýlanlar</a></div>
        <div><asp:HyperLink runat="server" ID="hlAbout" Text="Hakkýmýzda" NavigateUrl="~/About.aspx"></asp:HyperLink></div>
        <%--<a href="javascript:;">Hakkýmýzda</a>--%>
      </div>
        
      <asp:ImageButton ID="ImgBtnEmployee" runat="server" ImageUrl="~/Images/home/search_job.png" OnClick="ImgBtnEmployee_Click" />
      <asp:ImageButton ID="ImgBtnCompany" runat="server" ImageUrl="~/Images/home/search_people.png" OnClick="ImgBtnCompany_Click" />
      <!-- START FOOTER -->

        <uc2:uFooter ID="UFooter1" runat="server" />

      <!-- END FOOTER -->
    </td>
    <td valign="top" style="width:165px;"><div id="RibbonRight"></div>
      <div id="sponsors"><span>Sponsorlarýmýz:</span><br />
        <div id="sponsorsSWF">&nbsp;</div>
        <script type="text/javascript">
			// <![CDATA[
			var so = new SWFObject("images/sponsors/sponsors.swf", "sponsorsSWF", "140", "80", "7");
			so.write("sponsorsSWF");
			// ]]>
		</script>
      </div></td>
  </tr>
</table>