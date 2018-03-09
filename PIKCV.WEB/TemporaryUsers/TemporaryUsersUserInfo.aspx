<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TemporaryUsersUserInfo.aspx.cs" Inherits="TemporaryUsers_TemporaryUsersUserInfo" %>

<%@ Register Src="../UserControls/Employee/Membership/uUserInfo.ascx" TagName="uUserInfo"
    TagPrefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title> PIKCV | Perakende İnsan Kaynakları </title>
    <link href="../Styles/pikcv_print.css" rel="stylesheet" type="text/css" media="print" />
    <link href="../Styles/reset.css" rel="stylesheet" type="text/css" />
    <link href="../Styles/fonts.css" rel="stylesheet" type="text/css" />
    <link href="../Styles/Paging.css" rel="stylesheet" type="text/css" />
    <link href="../Styles/Custom.css" rel="stylesheet" type="text/css" />
    <link href="../Styles/pikcv_screen.css" rel="stylesheet" type="text/css" media="screen" />
    <script language="javascript" src="../Scripts/Custom.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div id="contentPad" style="padding: 20px; text-align: left;">
        <uc1:uUserInfo ID="UUserInfo1" runat="server" />
    
    </div>
    </form>
</body>
</html>
