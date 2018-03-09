<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CVPopup.aspx.cs" Inherits="CVPopup" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">

    <!-- #INCLUDE FILE="./Incs/Head.inc" -->

<!-- Import css/ -->
    <link href="./Styles/reset.css" rel="stylesheet" type="text/css" />
    <link href="./Styles/fonts.css" rel="stylesheet" type="text/css" />
    <link href="./Styles/pikcv_screen.css" rel="stylesheet" type="text/css" media="screen" />
    <link href="./Styles/sIFR-screen.css" rel="stylesheet" type="text/css" media="screen" />
    <link href="./Styles/sIFR-print.css" rel="stylesheet" type="text/css" media="print" />
    <link href="./Styles/Custom.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="./Scripts/ListboxHelper.js"></script>
    <script type="text/javascript" src="./Scripts/Custom.js"></script>
    
    
    <!-- IE6 conditional comment -->
    <!--[if lte IE 6]>
    <link href="./Styles/pikcv_screen_ie6.css" rel="stylesheet" type="text/css" />
    <![endif]-->
    <!--[if IE 7]>
    <link href="./Styles/pikcv_screen_ie7.css" rel="stylesheet" type="text/css" />
    <![endif]-->
<!--// Import css/ -->

    <link href="./Styles/ModalPopup.css" rel="stylesheet" type="text/css" />

    <title> PIKCV | Perakende İnsan Kaynakları </title>

</head>

<body id="popup">
    <!-- #INCLUDE FILE="./Incs/JSControl.inc" -->
    <form id="form1" runat="server">
    <asp:ScriptManager id="ScrMng1" runat="server" EnablePartialRendering="true">
        <Scripts>
            <asp:ScriptReference Path="~/Scripts/Custom.js" />
            <asp:ScriptReference Path="~/Scripts/Util.js" />
        </Scripts>
    </asp:ScriptManager>
        
        <asp:Image runat="server" ID="imgLogo" ImageUrl="~/Images/logos/pikcv_popup_logo.png" /> <br />
        <asp:PlaceHolder runat="server" ID="PH1">
        
        </asp:PlaceHolder>
    </form>
</body>
</html>
