<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SaveFolder.aspx.cs" Inherits="SaveFolder" %>

<%@ Register Src="UserControls/Company/Folders/uSaveFolder.ascx" TagName="uSaveFolder"
    TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="./Styles/reset.css" rel="stylesheet" type="text/css" />
    <link href="./Styles/fonts.css" rel="stylesheet" type="text/css" />
    <link href="./Styles/pikcv_screen.css" rel="stylesheet" type="text/css" media="screen" />
    <link href="./Styles/sIFR-screen.css" rel="stylesheet" type="text/css" media="screen" />
    <link href="./Styles/sIFR-print.css" rel="stylesheet" type="text/css" media="print" />
    <link href="./Styles/Custom.css" rel="stylesheet" type="text/css" />
    <title>Klasör Kaydet</title>
</head>
<body>
    <form id="form1" runat="server">
        <uc1:uSaveFolder ID="USaveFolder1" runat="server"></uc1:uSaveFolder>
    </form>
</body>
</html>
