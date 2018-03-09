<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uRightMenuTop.ascx.cs" Inherits="UserControls_Company_Search_SearchResults_uRightMenuTop" %>
<div class="browseResults">
<table width="100%">
    <tr>
        <td style="width: 33%">
            <p>
                <asp:Image runat="server" ID="imgLeft" ImageUrl="~/Images/buttons/prev_page.gif" />
                <asp:LinkButton ID="lbPreviousEmployee" runat="server" OnClick="lbPreviousEmployee_Click">
                Önceki aday</asp:LinkButton>
            </p>
        </td>
        <td align="center" style="width: 34%">
            <p>
                <asp:Label ID="lblEmployeeCount" runat="server" Text=""></asp:Label>&nbsp;</p>
        </td>
        <td align="right" style="width: 33%">
            <p>
                <asp:LinkButton ID="lbNextEmployee" runat="server" OnClick="lbNextEmployee_Click">
                Sonraki Aday</asp:LinkButton>
                <asp:Image runat="server" ID="imgRight" ImageUrl="~/Images/buttons/next_page.gif" />
            </p>
        </td>
    </tr>
</table>
</div>