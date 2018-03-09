<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uInterviewPikcv.ascx.cs"
    Inherits="UserControls_Employee_Membership_uInterviewPikcv" %>
<div class="BoxPadder">
    <p class="floatRight">
        G�r��me Tarihi:&nbsp;
        <asp:Label ID="lbInterviewDate" runat="server"></asp:Label></p>
    <h3>
        M�lakat De�erlendirmesi</h3>
    <p>
        &nbsp;</p>
    <div class="infoMsg">
        <p>
            De�erlendirme Kriterleri</p>
        <p>
            �ok iyi:5&nbsp;&nbsp;/&nbsp;&nbsp;�yi:4&nbsp;&nbsp;/&nbsp;&nbsp;Yeterli:3&nbsp;&nbsp;/&nbsp;&nbsp;Geli�tirilmesi
            gerekir:2&nbsp;&nbsp;/&nbsp;&nbsp;Yetersiz:1</p>
    </div>
    <p>
        &nbsp;</p>
    <asp:Panel ID="pnlNoRecord" runat="server" Visible="false">
        <table>
            <tr>
                <td>
                    <asp:Label ID="lbMessages" runat="server" Text="Hen�z bir m�lakat�n�z bulunmamaktad�r"></asp:Label>
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
                            <strong>�zellikler</strong></th>
                        <th>
                            <strong>Puan</strong></th>
                        <th style="width: 50%">
                            <strong>G�r��ler</strong></th>
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
                    <strong>�al��t��� yerden ayr�lma nedenleri:</strong></td>
                <td align="center">
                    &nbsp;</td>
                <td>
                    <asp:Label ID="lbWorkLeaveReason" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>
                    <strong>Ald��� �cret / Talep Etti�i �cret:</strong></td>
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
