<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uFoldersMain.ascx.cs"
    Inherits="UserControls_Company_Folders_uFoldersMain" %>
    
<div class="contentPad">
    <div class="HeaderPB floatLeft">
        <h2 class="sIFRHeader">
            Klasörlerim</h2>
    </div>
    <div class="brclear">
    </div>
    <div class="BoxContentTop">
    </div>
    <div class="BoxContent">
        <div class="BoxPadder">
            <table width="100%" class="dataGrid">
                <tr>
                    <th>
                        <strong>Klasör adý</strong></th>
                    <th>
                        <strong>Aday sayýsý</strong></th>
                    <th>
                        <strong>Oluþturulma tarihi</strong></th>
                    <th>
                        &nbsp;
                    </th>
                </tr>
                
                <asp:Repeater ID="rptDefaulFolders" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td>
                                <b>
                                    <asp:HyperLink ID="hplDefaultFolderName" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "FolderName") %>'
                                        NavigateUrl='<%#DataBinder.Eval(Container.DataItem, "FolderID", "#Company-Folders-FolderDetail&FolderID={0}") %>'></asp:HyperLink></b>
                            </td>
                            <td>
                                <asp:Label ID="lbDefaultUserCount" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "UserCount") %>'></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lbDefaultCreateDate" runat="server" Text='<%# String.Format("{0:d}", DataBinder.Eval(Container.DataItem, "CreateDate")) %>'></asp:Label>
                            </td>
                            <td align="right">

                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
                <asp:Repeater ID="rptCreatedFolders" runat="server" OnItemDataBound="rptCreatedFolders_ItemDataBound">
                    <ItemTemplate>
                        <tr>
                            <td>
                                <b>
                                    <asp:HyperLink ID="hplFolderName" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "FolderName") %>'
                                        NavigateUrl='<%#DataBinder.Eval(Container.DataItem, "FolderID", "#Company-Folders-FolderDetail&FolderID={0}") %>'></asp:HyperLink></b>
                            </td>
                            <td>
                                <asp:Label ID="lbUserCount" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "UserCount") %>'></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lbCreateDate" runat="server" Text='<%# String.Format("{0:d}", DataBinder.Eval(Container.DataItem, "CreateDate")) %>'></asp:Label>
                            </td>
                            <td align="right">
                                <asp:HyperLink ID="hplShareFolder" runat="server" Text="Paylaþ"
                                    NavigateUrl='<%#DataBinder.Eval(Container.DataItem, "FolderID", "javascript:OpenAddTemporaryUsers({0})") %>'></asp:HyperLink>&nbsp;/ 
                                <asp:HyperLink ID="hplChangeName" runat="server" Text="tekrar isimlendir"
                                    NavigateUrl='<%# DataBinder.Eval(Container.DataItem, "FolderID", "javascript:OpenSaveFolder({0})") %>'></asp:HyperLink>&nbsp;/
                                <asp:LinkButton ID="lbDeleteFolder" runat="server" OnClick="lbnDeleteFolder_Click" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "FolderID") %>' Text="Sil"></asp:LinkButton> 
                           </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
            <p class="floatRight">
                <asp:HyperLink ID="hplAddFolder" runat="server" Text="tekrar isimlendir"
                NavigateUrl="javascript:OpenSaveFolder()" ImageUrl="~/Images/buttons/add_folder.png"></asp:HyperLink>
            </p>
            <div class="brclear">
            </div>
            <p class="infoMsg">Satýnalma istekleri ve Satýnalýnanlar Klasörü sistem tarafýndan oluþturulmuþtur. Tarafýnýzca oluþturulacak klasörlerden bu klasörlere bilgi aktarýmý yapýlamaz.
            </p>
        </div>
    </div>
    <div class="BoxContentBottom">
    </div>
</div>
