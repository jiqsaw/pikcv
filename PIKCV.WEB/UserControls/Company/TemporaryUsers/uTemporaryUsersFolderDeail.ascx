<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uTemporaryUsersFolderDeail.ascx.cs" Inherits="UserControls_Company_TemporaryUsers_uTemporaryUsersFolderDeail" %>

  <img src="images/misc/pikcv_popup_logo.png" width="230" height="70" />

        <h2><asp:Label ID="lbFolderName" runat="server"></asp:Label></h2><br />
        <asp:Label ID="lbMessage" runat="server"></asp:Label>
        <p>&nbsp;</p>

<table width="100%">
    <tr>
        <td align="center">

        <table width="800" class="dataGrid" style="text-align: left;">
            <asp:Repeater ID="rptFolders" runat="server" OnItemCommand="rptFolders_ItemCommand"
                    OnItemDataBound="rptFolders_ItemDataBound">
                    <HeaderTemplate>
                        <tr>
                            <th nowrap="nowrap">
                                <strong>Adý Soyadý</strong></th>
                            <th nowrap="nowrap">
                                <strong>Eðitim</strong>
                            </th>
                            <th nowrap="nowrap">
                                <strong>Ýþ Deneyimi</strong><br />
                            </th>
                        </tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr class="odd">
                            <td>
                                <input type="checkbox" id="chFolders" name="chFolders" value='<%#DataBinder.Eval(Container.DataItem, "UserID") %>'>
                                <asp:LinkButton runat="server" ID="lnkUserDetail" 
                                CommandArgument='<%#DataBinder.Eval(Container.DataItem, "UserID") %>' CommandName="UserDetail">
                                <%#DataBinder.Eval(Container.DataItem, "FirstName") %>&nbsp;<%#DataBinder.Eval(Container.DataItem, "LastName") %>
                                </asp:LinkButton>
                            </td>
                            <td>
                                <asp:Label ID="lbEducationLevel" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "EducationLevelName") %>'></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lbTotalWorkExperiance" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "TotalWorkExperience") %>'></asp:Label>
                            </td>
                        </tr>
                    </ItemTemplate>
                    <FooterTemplate>
                        <tr>
                            <td colspan="4">
                                <ul class="FamLinks" style="margin-left: 6px">
                                    <li>
                                        <input type="checkbox" id="chAll" onclick="CheckAll(this.checked, 'chFolders')" />
                                        Tümünü Seç </li>
                                    <asp:Panel ID="pnlSendToFolder" runat="server">
                                    <li class="Buy">
                                            <asp:LinkButton ID="btnSendToFolder" runat="server" CommandName="SendToFolder"
                                            Text="Satýnalma isteklerine gönder"></asp:LinkButton>
                                            </li>
                                    </asp:Panel>
                                    <li class="Delete">
                                        <asp:LinkButton ID="btnDelete" runat="server" CommandName="Delete" Text="Sil"></asp:LinkButton></li>
                                </ul>
                            </td>
                        </tr>
                    </FooterTemplate>
                </asp:Repeater>
        </table>
        
        </td>
    </tr>
</table>        
