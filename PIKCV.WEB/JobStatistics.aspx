<%@ Page Language="C#" AutoEventWireup="true" CodeFile="JobStatistics.aspx.cs" Inherits="JobStatistics" %>

<%@ Register Src="UserControls/Company/Statistics/BarControl.ascx" TagName="BarControl"
    TagPrefix="uc1" %>
    
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <link href="./Styles/pikcv_print.css" rel="stylesheet" type="text/css" media="print" />
    <link href="./Styles/reset.css" rel="stylesheet" type="text/css" />
    <link href="./Styles/fonts.css" rel="stylesheet" type="text/css" />
    <link href="./Styles/Paging.css" rel="stylesheet" type="text/css" />
    <link href="./Styles/Custom.css" rel="stylesheet" type="text/css" />
    <link href="./Styles/pikcv_screen.css" rel="stylesheet" type="text/css" media="screen" />
    <title>Ýlan Ýstatistikleri</title>
</head>
<body>
    <form id="form1" runat="server">
        &nbsp;<!--------- START WRAPPER ------------><div id="wrapper">
            <div id="contentPad">
                <img height="70" src="http://www.djocko.com/pikcv/images/misc/pikcv_popup_logo.png"
                    width="230" alt="hebe" />
                <table class="StatTable">
                    <tr>
                        <td style="width: 100px">
                            &nbsp;</td>
                        <td>
                            <h2>
                                Ýlan istatistikleri</h2>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" nowrap="nowrap" valign="top" width="100" style="height: 64px">
                            &nbsp;</td>
                        <td style="height: 64px">
                            <h4>
                                <asp:Label ID="lbPosition" runat="server"></asp:Label></h4>
                            <p>
                                <br />
                                <asp:Label ID="lbJobDate" runat="server"></asp:Label></p>
                                <br />
                            <p>
                                Baþvuru sayýsý: <strong><asp:Label ID="lbJobApplicantCount" runat="server"></asp:Label></strong></p>
                        </td>
                    </tr>
                </table>
                <div class="hr">
                    <hr />
                </div>
                
               <table class="StatTable">
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            <h4>
                                Baþvuru statüsü</h4>
                        </td>
                    </tr>
                   <tr>
                       <td colspan="2">
                           <uc1:BarControl ID="BarControlWorking" runat="server" />
                           <uc1:BarControl ID="BarControlNotWorking" runat="server" />
                       </td>
                   </tr>
                </table>
                                
                
                <div class="hr">
                    <hr />
                </div>
                
                
                <table class="StatTable">
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            <h4>
                                Cinsiyet</h4>
                        </td>
                    </tr>
                   
                   <tr>
                       <td colspan="2">
                           <uc1:BarControl ID="BarControlMan" runat="server" Description="Bay"/>
                           <uc1:BarControl ID="BarControlWomen" runat="server" Description="Bayan"/>
                       </td>
                   </tr>
                </table>
                <div class="hr">
                    <hr />
                </div>
                <table class="StatTable">
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            <h4>
                                Yaþ daðýlýmý</h4>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <uc1:BarControl ID="BarControlage_18" runat="server" />
                            <uc1:BarControl ID="BarControlage_25" runat="server" />
                            <uc1:BarControl ID="BarControlage_30" runat="server" />
                            <uc1:BarControl ID="BarControlage_35" runat="server" />
                            <uc1:BarControl ID="BarControlage_40" runat="server" />
                            <uc1:BarControl ID="BarControlage_45" runat="server" />
                            <uc1:BarControl ID="BarControlage_60" runat="server" />
                        </td>
                    </tr>
                </table>
                <div class="hr">
                    <hr />
                </div>
                <table class="StatTable">
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            <h4>
                                Yaþadýðý þehir</h4>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Repeater ID="rptLivingPlace" runat="server">
                                <ItemTemplate>
                                    <uc1:BarControl ID="BarControlLivingPlace" runat="server" 
                                    Description='<%#DataBinder.Eval(Container.DataItem, "PlaceName")%>'
                                    Count='<%#DataBinder.Eval(Container.DataItem, "Count")%>'
                                    Percentage='<%#DataBinder.Eval(Container.DataItem, "Percentage")%>' />
                                </ItemTemplate>
                            </asp:Repeater>
                        </td>
                    </tr>
                </table>
                <div class="hr">
                    <hr />
                </div>
                <table class="StatTable">
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            <h4>
                                Askerlik durumu:</h4>
                        </td>
                    </tr>
                                        <tr>
                        <td colspan="2">
                            <uc1:BarControl ID="BarControlMilitaryDone" runat="server" />
                            <uc1:BarControl ID="BarControlMilitaryNotDone" runat="server" />
                            <uc1:BarControl ID="BarControlMilitaryPostponed" runat="server" />
                        </td>
                    </tr>
                </table>
                <div class="hr">
                    <hr />
                </div>
                <div class="brclear">
                </div>
            </div>
        </div>
        <!--------- END WRAPPER ------------>
        
    </form>
</body>
</html>
