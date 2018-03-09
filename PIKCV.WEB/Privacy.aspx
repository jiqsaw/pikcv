<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Privacy.aspx.cs" Inherits="Privacy" %>
<%@ Register Src="UserControls/Common/uPrivacy.ascx" TagName="uPrivacy" TagPrefix="uc1" %>

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
<body id="Popup">
    <form id="form1" runat="server">
    <div style="text-align: left; padding: 10px 10px">
        <uc1:uPrivacy ID="UPrivacy1" runat="server" />
        
        
        <asp:Repeater ID="rptJobs" runat="server" OnItemDataBound="rptJobs_ItemDataBound">
        <HeaderTemplate>
            <table width="100%" class="dataGrid">
                <tr>
                    <th style="width: 35%;">
                        <strong>Pozisyon</strong></th>
                    <th style="width: 10%;">
                        <strong>Baþvuru</strong></th>
                    <th nowrap="nowrap" style="width: 20%;">
                        <strong>Bitiþ Tarihi</strong></th>
                    <th style="width: 10%;">
                        <div align="center">
                            <strong>Ýstatistik</strong></div>
                    </th>
                    <th style="width: 25%;">
                        <strong>Durum</strong></th>
                </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td style="width: 35%;">
                    <a href="javascript:;" onclick='<%#DataBinder.Eval(Container.DataItem, "JobID", "OpenJobPreview({0})")%>'>
                    Ref.No:<%#DataBinder.Eval(Container.DataItem, "ReferenceNumber")%> <br /> 
                    <%#DataBinder.Eval(Container.DataItem, "PositionName") %>
                    </a>
                </td>
                <td style="width: 10%;">
                    <asp:HyperLink ID="hplJobApplicantCount" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "ApplicantCount")%>'
                        NavigateUrl='<%#DataBinder.Eval(Container.DataItem, "JobID", "#Company-Jobs-JobApplicants&JobID={0}")%>'></asp:HyperLink>
                </td>
                <td style="width: 20%;">
                    <asp:Literal ID="ltrEndDate" runat="server" Text='<%# String.Format("{0:d}", DataBinder.Eval(Container.DataItem, "EndDate"))%>'></asp:Literal>
                </td>
                <td align="center" style="width: 10%;">
                    <img onclick='OpenJobStatistics(<%#DataBinder.Eval(Container.DataItem, "JobID")%>)' style="cursor: pointer;" src="images/misc/statistic.png" width="16" height="14" /></td>
                <td style="width: 25%;">
                    <asp:LinkButton ID="lnbUpdate" runat="server" CommandArgument='<%#DataBinder.Eval(Container.DataItem, "JobID")%>'
                         Text="Güncelle"></asp:LinkButton>
                    /
                    <asp:LinkButton ID="lnbArchive" runat="server" CommandArgument='<%#DataBinder.Eval(Container.DataItem, "JobID")%>'
                         Text="Arþivle"></asp:LinkButton>
                    
                    <asp:LinkButton ID="lnbDelete" runat="server" CommandArgument='<%#DataBinder.Eval(Container.DataItem, "JobID")%>'
                         Text="Sil" Visible="false"></asp:LinkButton>
                </td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>
    </div>
    </form>
</body>
</html>
