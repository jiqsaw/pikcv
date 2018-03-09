<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uApproval.ascx.cs" Inherits="UserControls_Company_Jobs_Jobs_uApproval" %>

<table width="100%" class="FormTable">
    <tr>
        <td align="right" valign="top">
            &nbsp;</td>
        <td>
            <h1>
                Ýlan onayý
            </h1>
        </td>
    </tr>
    <tr>
        <td width="25%" align="right" valign="top">
            <p>
                <strong>Gizlilik</strong></p>
        </td>
        <td width="75%">
            <ul>
                <li>
                    <asp:CheckBox ID="chkisCompanySecret" runat="server" Text="Ýlanýmda firma ismini saklý tut"/>
                    </li>
            </ul>
        </td>
    </tr>
    <tr>
        <td align="right" valign="top">
            <p>
                <strong>Ýlan durumu</strong></p>
        </td>
        <td>
            <asp:RadioButtonList ID="rblJobBroadcastType" runat="server">
            <asp:ListItem Text="Ýlanýmý hemen yayýnla" Value="" Selected="True"></asp:ListItem>
            <asp:ListItem Text="Ýlanýmý taslak olarak kaydet" Value=""></asp:ListItem>
            </asp:RadioButtonList>
            </td>
    </tr>
    <tr>
        <td align="right" valign="top">
            <p>
                <strong>Notlar</strong></p>
        </td>
        <td>
            <asp:TextBox ID="txtNotes" runat="server" Width="360" Rows="4" TextMode="MultiLine"></asp:TextBox>
            </td>
    </tr>
    <tr>
        <td align="right">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td align="right">

        </td>
        <td>
            
            <table cellpadding="2" cellspacing="2">
                <tr>
                    <td>
                        <a href="javascript:OpenJobPreview('<%=this.smJobID %>')">
                            <img alt="" src="Images/buttons/preview_ad.png" />
                        </a>                    
                    </td>
                    <td style="padding-left: 10px;">
                        <asp:ImageButton ID="btnSubmit" runat="server" ImageUrl="~/images/buttons/corp_approve.png" 
                        OnClick="btnSubmit_Click" />
                    </td>
                </tr>
            </table>

        </td>
    </tr>
</table>
