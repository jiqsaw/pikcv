<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uInterviewPikcv.ascx.cs"
    Inherits="UserControls_Employee_Membership_uInterviewPikcv" %>
<div class="BoxPadder">
    <p class="floatRight">
        Görüþme Tarihi:&nbsp;
        <asp:Label ID="lbInterviewDate" runat="server"></asp:Label></p>
    <h3>
        Mülakat Deðerlendirmesi</h3>
    <p>
        &nbsp;</p>
    <div class="infoMsg">
        <p>
            Deðerlendirme Kriterleri</p>
        <p>
            Çok iyi:5&nbsp;&nbsp;/&nbsp;&nbsp;Ýyi:4&nbsp;&nbsp;/&nbsp;&nbsp;Yeterli:3&nbsp;&nbsp;/&nbsp;&nbsp;Geliþtirilmesi
            gerekir:2&nbsp;&nbsp;/&nbsp;&nbsp;Yetersiz:1</p>
    </div>
    <p>
        &nbsp;</p>
    <asp:Panel ID="pnlNoRecord" runat="server" Visible="false">
        <table>
            <tr>
                <td>
                    <asp:Label ID="lbMessages" runat="server" Text="Henüz bir mülakatýnýz bulunmamaktadýr"></asp:Label>
                </td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="pnlRecord" runat="server" Visible="true">
        <table width="100%" class="dataGrid">
            <asp:Repeater ID="rptIntervies" runat="server">
                <HeaderTemplate>
                    <tr>
                        <th style="width: 40%">
                            <strong>Özellikler</strong></th>
                        <th>
                            <strong>Puan</strong></th>
                        <th style="width: 50%">
                            <strong>Görüþler</strong></th>
                    </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        
                        <td style="width: 40%">
                            <strong>
                                <asp:Label ID="lbInterviewProperties" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "InterviewPikcvPropertiesNames") %>'></asp:Label></strong>
                        </td>
                        <td>
                            
                                <asp:Label ID="lbInterviewPropertiesPoints" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Points") %>'></asp:Label>
                        </td>
                        <td style="width: 50%">
                           
                                <asp:Label ID="lbInterviewOpinion" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Opinion") %>'></asp:Label>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
            <tr>
                <td style="width: 40%">
                    <strong>Toplam puan: </strong>
                </td>
                <td>
                    <asp:Label ID="lbAveragePoints" runat="server"></asp:Label></td>
                <td style="width: 50%">
                    <asp:Label ID="lbInterviewResult" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td align="center">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    <strong>Çalýþtýðý yerden ayrýlma nedenleri:</strong></td>
                <td align="center">
                    &nbsp;</td>
                <td>
                    <asp:Label ID="lbWorkLeaveReason" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>
                    <strong>Aldýðý Ücret / Talep Ettiði Ücret:</strong></td>
                <td align="center">
                    &nbsp;</td>
                <td>
                    <asp:Label ID="lbTakingWage" runat="server"></asp:Label>
                    &nbsp;/
                    <asp:Label ID="lbRequestedWage" runat="server"></asp:Label></td>
            </tr>
        </table>
    </asp:Panel>
    <div class="brclear">
    </div>
</div>
