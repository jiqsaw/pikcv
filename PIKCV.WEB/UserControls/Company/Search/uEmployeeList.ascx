<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uEmployeeList.ascx.cs" Inherits="UserControls_Company_Search_uEmployeeList" %>

<div class="contentPad">
    <div class="HeaderPR floatLeft">
        <h2 class="sIFRHeader" style="width: 200px;">
            Baþvuranlar</h2>
    </div>
    <div class="brclear">
    </div>
    
    <div id="ctl26_UList1_pnlList">
	
    <div class="BoxContentTop"></div>
    <div class="BoxContent">
        <div class="BoxPadder">

        <asp:Repeater ID="rptAds" runat="server" OnItemCommand="rptAds_ItemCommand">
            <HeaderTemplate>
                <table class="dataGrid" width="100%">
                    <tr>
                        <th width="40%">
                            <strong>Baþvuran Kiþi</strong></th>
                        <th nowrap="nowrap" width="20%">
                            <strong>Puaný</strong></th>
                    </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr class="odd">
                    <td>
                        <strong>
                             <asp:LinkButton ID="lbName" runat="server" CommandName="Select"></asp:LinkButton>
                             <asp:Literal ID="liUserID" runat="server" Visible="false"></asp:Literal>
                        </strong>
                    </td>
                    <td>
                        <%# Eval("Rate") %>
                    </td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
            </table>
            </FooterTemplate>
        </asp:Repeater>
        
        </div>
    </div>
    <div class="BoxContentBottom"></div>

</div>