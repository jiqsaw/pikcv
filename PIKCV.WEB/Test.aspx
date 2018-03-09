<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Test.aspx.cs" Inherits="Test" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <!-- #INCLUDE FILE="./Incs/Head.inc" -->

<!-- Import css/ -->
    <link href="./Styles/reset.css" rel="stylesheet" type="text/css" />
    <link href="./Styles/fonts.css" rel="stylesheet" type="text/css" />
    <link href="./Styles/Paging.css" rel="stylesheet" type="text/css" />
    <link href="./Styles/pikcv_screen.css" rel="stylesheet" type="text/css" media="screen" />
    <link href="./Styles/sIFR-screen.css" rel="stylesheet" type="text/css" media="screen" />
    <link href="./Styles/sIFR-print.css" rel="stylesheet" type="text/css" media="print" />
    <link href="./Styles/Custom.css" rel="stylesheet" type="text/css" />
    
    <!-- IE6 conditional comment -->
    <!--[if lte IE 6]>
    <link href="./Styles/pikcv_screen_ie6.css" rel="stylesheet" type="text/css" />
    <![endif]-->
    <!--[if IE 7]>
    <link href="./Styles/pikcv_screen_ie7.css" rel="stylesheet" type="text/css" />
    <![endif]-->
<!--// Import css/ -->

    <title> PIKCV | Perakende İnsan Kaynakları </title>
</head>
<body id="popupTest">
    <!-- #INCLUDE FILE="./Incs/JSControl.inc" -->
    <form id="form1" runat="server">
    <asp:ScriptManager id="ScrMng1" runat="server" EnablePartialRendering="true">
        <Scripts>
            <asp:ScriptReference Path="~/Scripts/Util.js" />
        </Scripts>
    </asp:ScriptManager>
<!--------- START WRAPPER ------------>
<div id="wrapper">
  <div id="content">
    <asp:Image runat="server" ID="imgLogo" ImageUrl="~/Images/logos/pikcv_popup_logo.png" />
        <asp:PlaceHolder runat="server" ID="PH1"></asp:PlaceHolder>
  </div>
</div>
<!--------- END WRAPPER ------------>

    </form>
</body>
</html>
