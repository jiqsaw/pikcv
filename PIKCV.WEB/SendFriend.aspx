<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SendFriend.aspx.cs" Inherits="SendFriend" %>

<%@ Register Src="UserControls/Employee/Messages/uSendFriend.ascx" TagName="uSendFriend"
    TagPrefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <link href="./Styles/reset.css" rel="stylesheet" type="text/css" />
    <link href="./Styles/fonts.css" rel="stylesheet" type="text/css" />
    <link href="./Styles/Paging.css" rel="stylesheet" type="text/css" />
    <link href="./Styles/Custom.css" rel="stylesheet" type="text/css" />
    <link href="./Styles/pikcv_screen.css" rel="stylesheet" type="text/css" media="screen" />
    <title>PIKCV Arkadaþýna Gönder</title>
</head>
<body id="popup">
    <form id="form1" runat="server">
    <div>
        <uc1:uSendFriend ID="USendFriend1" runat="server" />
    
    </div>
    </form>
</body>
</html>
