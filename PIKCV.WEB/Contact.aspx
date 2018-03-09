<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="Contact" %>

<%@ Register Src="~/UserControls/Common/uTop.ascx" TagName="uTop" TagPrefix="uc3" %>
<%@ Register Src="~/UserControls/Common/uFooter.ascx" TagName="uFooter" TagPrefix="uc2" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">

    <!-- #INCLUDE FILE="./Incs/Head.inc" -->

<!-- Import css/ -->
    <link href="./Styles/pikcv_print.css" rel="stylesheet" type="text/css" media="print" />
    <link href="./Styles/reset.css" rel="stylesheet" type="text/css" />
    <link href="./Styles/fonts.css" rel="stylesheet" type="text/css" />
    <link href="./Styles/Paging.css" rel="stylesheet" type="text/css" />
    <link href="./Styles/Custom.css" rel="stylesheet" type="text/css" />
    <link href="./Styles/pikcv_screen.css" rel="stylesheet" type="text/css" media="screen" />
    <link href="./Styles/custom.css" rel="stylesheet" type="text/css" media="screen" />
    <script type="text/javascript" src="./Scripts/Custom.js"></script>
    
    
    <!-- IE6 conditional comment -->
    <!--[if lte IE 6]>
    <link href="./Styles/pikcv_screen_ie6.css" rel="stylesheet" type="text/css" />
    <![endif]-->
    <!--[if IE 7]>
    <link href="./Styles/pikcv_screen_ie7.css" rel="stylesheet" type="text/css" />
    <![endif]-->
<!--// Import css/ -->

    <title> PIKCV | Perakende Ýnsan Kaynaklarý </title>

</head>
<body id="GenericPage">
    <!-- #INCLUDE FILE="./Incs/JSControl.inc" -->
    <form id="form1" runat="server">

    <asp:ScriptManager id="ScrMng1" runat="server" EnablePartialRendering="true">
    <%-- AsyncPostBackTimeout="3600" OnAsyncPostBackError="HandleError">--%>
        <Scripts>
            <asp:ScriptReference Path="~/Scripts/swfobject.js" />
            <asp:ScriptReference Path="~/Scripts/Util.js" />
            <asp:ScriptReference Path="~/Scripts/Custom.js" />
            <asp:ScriptReference Path="~/Scripts/ListboxHelper.js" />
            <asp:ScriptReference Path="~/Scripts/ModalPopup.js" />
        </Scripts>
    </asp:ScriptManager>
    
    <div id="wrapper">
    
        <%-- START HEADER --%>
        <uc3:uTop ID="uTop1" runat="server" />
        <%--END HEADER--%>
    
    <script src="Scripts/p7APscripts.js" language="javascript" type="text/javascript"></script>
    
    
    <div id="content">
    <div class="contentPad">
      <div class="brclear"></div>
      <!-- start roundcornered box -->
      <div class="BoxContentTop"></div>
      <div class="BoxContent">
        <div class="BoxPadder">
          <table width="100%">
            <tr>
              <td valign="top" style="width:34%"><img src="images/misc/about_us.jpg" /></td>
              <td valign="top" style="width:66%"><div class="HeaderPR">
                  <h2 class="sIFRHeader">Ýletiþim</h2>
                </div>
                <p>&nbsp;</p>
                <table class="GenericTable">
                  <tr>
                    <td><p>Telefon:</p></td>
                    <td><p>212 329 79  33-34</p></td>
                  </tr>
                  <tr>
                    <td><p>Faks</p></td>
                    <td><p>212 329 79 35</p></td>
                  </tr>
                  <tr>
                    <td><p>E-posta</p></td>
                    <td><p>info@pikcv.com</p></td>
                  </tr>
                  <tr>
                    <td valign="top"><p>Adres</p></td>
                    <td><p>Büyükdere Caddesi Meydan Sok.<br />
                      Spring Giz Plaza No: 47 Kat 13</p>
                    <p>Þiþli – Maslak / Ýstanbul </p></td>
                  </tr>
                </table>
                <p>&nbsp;</p>
                <p>Ýstek öneri ve  problemlerinizde bize ulaþmak için aþaðýdaki formu kullanabilirsiniz.</p>
                <p>&nbsp;</p>
                <div id="p7ABW1" class="p7AB">
                  <div class="p7ABtrig">
                    <h4><a href="javascript:;" id="p7ABt1_1">Adaylar</a></h4>
                  </div>
                  <div id="p7ABw1_1">
                    <div id="p7ABc1_1" class="p7ABcontent" style="padding-bottom:5px;">
                      <table class="FormTable">
                        <tr>
                          <td align="right">Adýnýz Soyadýnýz:</td>
                          <td>                            <input name='Ilce2' type='text' id='Ilce2' style="width:210px;"/>                                                    </td>
                        </tr>
                        <tr>
                          <td align="right">E-posta adresiniz: </td>
                          <td>                            <input name='Ilce22' type='text' id='Ilce22' style="width:210px;"/>                                                    </td>
                        </tr>
                        <tr>
                          <td align="right">Telefonunuz:</td>
                          <td>                            <input name='Ilce23' type='text' id='Ilce23' style="width:210px;"/>                                                    </td>
                        </tr>
                        <tr>
                          <td align="right" valign="top">Mesajýnýz:</td>
                          <td>                            <textarea name="msg" rows="4" id="msg" style="width:360px;"></textarea>                                                    </td>
                        </tr>
                        <tr>
                          <td valign="top">&nbsp;</td>
                          <td><img src="images/buttons/gonder.png" width="97" height="27" /></td>
                        </tr>
                      </table>
                    </div>
                  </div>
                  <div class="p7ABtrig">
                    <h4><a href="javascript:;" id="p7ABt1_2">Þirketler</a></h4>
                  </div>
                  <div id="p7ABw1_2">
                    <div id="p7ABc1_2" class="p7ABcontent">
                      <table class="FormTable">
                        <tr>
                          <td align="right">Adýnýz Soyadýnýz:</td>
                          <td>                            <input name='Ilce24' type='text' id='Ilce24' style="width:210px;"/>                                                    </td>
                        </tr>
                        <tr>
                          <td align="right">Þirket adý: </td>
                          <td><input name='Ilce242' type='text' id='Ilce242' style="width:210px;"/></td>
                        </tr>
                        <tr>
                          <td align="right">E-posta adresiniz: </td>
                          <td>                            <input name='Ilce222' type='text' id='Ilce222' style="width:210px;"/>                                                    </td>
                        </tr>
                        <tr>
                          <td align="right">Telefonunuz:</td>
                          <td>                            <input name='Ilce232' type='text' id='Ilce232' style="width:210px;"/>                                                    </td>
                        </tr>
                        <tr>
                          <td align="right" valign="top">Mesajýnýz:</td>
                          <td>                            <textarea name="textarea" rows="4" id="textarea" style="width:360px;"></textarea>                                                    </td>
                        </tr>
                        <tr>
                          <td valign="top">&nbsp;</td>
                          <td><img src="images/buttons/corp_send.png" width="97" height="27" /></td>
                        </tr>
                      </table>
                    </div>
                  </div>
                </div>
				<script type="text/javascript">
			<!--
				P7_opAB(1,1,1,0,1);
			//-->
			</script>
                <p>&nbsp;</p>
                <p>&nbsp;</p>
                <p>&nbsp;</p>
                <p>&nbsp;</p>
              </td>
            </tr>
          </table>
        </div>
      </div>
      <div class="BoxContentBottom"></div>
      <!-- finish roundcornered box -->
      <p>&nbsp;</p>
    </div>
  </div>

        <uc2:uFooter ID="UFooter1" runat="server" />
    
    </div>
    </form>
</body>
</html>
