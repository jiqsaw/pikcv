<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TemporaryUserLogin.aspx.cs" Inherits="TemporaryUserLogin" %>

<%@ Register Src="UserControls/Company/TemporaryUsers/uTemporaryUserLogin.ascx" TagName="uTemporaryUserLogin"
    TagPrefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Pikcv Ge�ici Kullan�c� Giri�i</title>
    <link href="./Styles/pikcv_print.css" rel="stylesheet" type="text/css" media="print" />
    <link href="./Styles/reset.css" rel="stylesheet" type="text/css" />
    <link href="./Styles/fonts.css" rel="stylesheet" type="text/css" />
    <link href="./Styles/Paging.css" rel="stylesheet" type="text/css" />
    <link href="./Styles/Custom.css" rel="stylesheet" type="text/css" />
    <link href="./Styles/pikcv_screen.css" rel="stylesheet" type="text/css" media="screen" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:uTemporaryUserLogin ID="UTemporaryUserLogin1" runat="server" />
    
    </div>
    </form>
</body>
</html>
