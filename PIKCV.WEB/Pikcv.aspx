<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Pikcv.aspx.cs" Inherits="Pikcv" enableEventValidation="false" ValidateRequest="false" %>

<%@ Register Src="UserControls/Common/uNotice.ascx" TagName="uNotice" TagPrefix="uc6" %>
<%@ Register Src="~/UserControls/Common/uLogin.ascx" TagName="uLogin" TagPrefix="uc1" %>
<%@ Register Src="~/UserControls/Common/uFooter.ascx" TagName="uFooter" TagPrefix="uc2" %>
<%@ Register Src="~/UserControls/Common/uTop.ascx" TagName="uTop" TagPrefix="uc3" %>
<%@ Register Src="~/UserControls/Common/uMyMenu.ascx" TagName="uMyMenu" TagPrefix="uc4" %>
<%@ Register Src="~/UserControls/Common/uArticles.ascx" TagName="uArticles" TagPrefix="uc5" %>
<%@ Register Src="~/UserControls/Company/Search/SearchResults/uLeftMenu.ascx" TagName="uLeftMenu" TagPrefix="uc0" %>

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
    <link href="./Styles/ModalPopup.css" rel="stylesheet" type="text/css" />
    
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

<body>

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
        
        <%-- START LEFTNAV --%>
        <div id="LeftNav">
        
        <asp:Panel runat="server" ID="pnlStandart">
        
        <uc1:uLogin ID="ULogin1" runat="server" />
        <uc4:uMyMenu ID="uMyMenu1" runat="server" />
        <uc6:uNotice id="UNotice1" runat="server" />
        <uc5:uArticles ID="uArticles1" runat="server" />
    
        </asp:Panel>

        <asp:PlaceHolder id="PHEmployeeSearch" runat="server"> </asp:PlaceHolder>
        
        </div>
        <%-- END LEFTNAV --%>
        
        <div id="content">

        <asp:PlaceHolder id="PH1" runat="server"> </asp:PlaceHolder>

        </div>
        
        <uc2:uFooter ID="UFooter1" runat="server" />
    
    </div>

    </form>

<script type="text/javascript" src="./Scripts/SwfReplace.js"></script>
<script type="text/javascript" src="./Scripts/URLManagement.js"></script>
    
</body>
</html>
