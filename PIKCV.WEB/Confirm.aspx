<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Confirm.aspx.cs" Inherits="Confirm" %>
<%@ Register Src="~/UserControls/Common/uConfirm.ascx" TagName="uConfirm" TagPrefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <!-- #INCLUDE FILE="./Incs/Head.inc" -->
<link href="./Styles/ModalPopup.css" rel="stylesheet" type="text/css" />

    <title> PIKCV | Perakende İnsan Kaynakları </title>
    
    <base target="_self">
    
</head>
<body style="margin: 2px 4px 2px 2px;">
    <form id="form1" runat="server">
        <uc1:uConfirm ID="uConfirm1" runat="server" />
    </form>
</body>
</html>