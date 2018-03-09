<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uFolderDetail.ascx.cs"
    Inherits="UserControls_Company_Folders_uFolderDetail" %>
<div class="contentPad">
    <div class="HeaderPB floatLeft">
        <h2 class="sIFRHeader">
            Klasörlerim  / 
            <asp:Literal runat="server" ID="ltlSubFolderName" Text=""></asp:Literal>
        </h2>
    </div>
    <div class="SectionCombo">
        <asp:DropDownList ID="drpCompanyFolders" runat="server" OnSelectedIndexChanged="drpCompanyFolders_SelectedIndexChanged" AutoPostBack="true">
        </asp:DropDownList>
        </div>
    <div class="brclear">
    </div>
    <div class="BoxContentTop">
    </div>
    <div class="BoxContent">
        <div class="BoxPadder">
<%--            <asp:Label ID="lbMessage" runat="server" Text="Herhangi bir kullanýcý bulunamamýþtýr." Visible="false"></asp:Label>
--%>            <h2>
                <asp:Label ID="lbFolderName" runat="server"></asp:Label></h2>
            <p>
                &nbsp;</p>
            <asp:Label ID="lbMessage" runat="server" Text="Klasörün içinde aday bulunmamaktadýr."
                Visible="false"></asp:Label>
                
            <asp:Panel runat="server" ID="pnlFolderDetail">
                
            <table class="dataGrid" width="100%">
                    <tr>
                        <th nowrap="nowrap">
                            &nbsp;</th>
                        <th nowrap="nowrap">
                            <strong>Adý Soyadý</strong></th>
                        <th id="thTemporaryUserEmailHeader" runat="server" nowrap="nowrap">
                            <strong>Ýstek E-Posta</strong></th>
                        <th nowrap="nowrap">
                            <strong>Eðitim</strong>
                        </th>
                        <th nowrap="nowrap">
                            <strong>Ýþ Deneyimi</strong><br />
                        </th>
                        <th nowrap="nowrap">
                            <strong>Yer aldýðý klasörler</strong><br />
                        </th>
                    </tr>            
                <asp:Repeater ID="rptFolders" runat="server" OnItemCommand="rptFolders_ItemCommand"
                    OnItemDataBound="rptFolders_ItemDataBound">
                    <ItemTemplate>
                        <tr class="odd">
                            <td>
                                <input type="checkbox" id="chFolders" name="chFolders" value='<%#DataBinder.Eval(Container.DataItem, "UserID") %>'>
                            </td>
                            <td>
                                <asp:LinkButton runat="server" ID="lnkUserDetail" 
                                CommandArgument='<%#DataBinder.Eval(Container.DataItem, "UserID") %>' CommandName="UserDetail">
                                <%#DataBinder.Eval(Container.DataItem, "FirstName") %>&nbsp;<%#DataBinder.Eval(Container.DataItem, "LastName") %>
                                </asp:LinkButton>
                                <asp:Panel runat="server" ID="pnlContactInfo" Visible="false"><br />
                                <asp:Literal runat="server" ID="ltlIsOwned" Text='<%#DataBinder.Eval(Container.DataItem, "IsOwned") %>' Visible="false"></asp:Literal>
                                <%#DataBinder.Eval(Container.DataItem, "Email") %><br />
                                Cep: <%#DataBinder.Eval(Container.DataItem, "GSM") %>
                                </asp:Panel>
                            </td>
                            <asp:Panel ID="pnlTemporaryUserEmail" runat="server">
                            <td>
                                <asp:Label ID="lblTemporaryUserEmail" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "TemporaryUserEmail") %>'></asp:Label>
                                <asp:Literal ID="ltlIsFolderDefault" runat="server" Visible="false" Text='<%#DataBinder.Eval(Container.DataItem, "IsDefault") %>'></asp:Literal>
                            </td>
                            </asp:Panel>
                            <td>
                                <asp:Label ID="lbEducationLevel" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "EducationLevelName") %>'></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lbTotalWorkExperiance" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "TotalWorkExperience") %>'></asp:Label>
                            </td>
                            <td>
                                <asp:Literal runat="server" ID="ltlUserID" Text='<%#DataBinder.Eval(Container.DataItem, "UserID") %>' Visible="false"></asp:Literal>
                                <asp:Repeater ID="rptFolderNames" runat="server">
                                    <ItemTemplate><%#DataBinder.Eval(Container.DataItem, "FolderName") %></ItemTemplate>
                                    <SeparatorTemplate>, </SeparatorTemplate>
                                </asp:Repeater>
                                </a>
                            </td>
                        </tr>
                    </ItemTemplate>
                    <FooterTemplate>
                        <tr>
                            <td colspan="5">
                                <ul class="FamLinks" style="margin-left: 6px">
                                    <li>
                                        <input type="checkbox" id="chAll" onclick="CheckAll(this.checked, 'chFolders')" />
                                        Tümünü Seç </li>
                                    <li class="SendToFile">
                                        <div style="margin: 5px 0;">
                                            <asp:DropDownList ValidationGroup="vgSendFolder" ID="drpCopyCutFolderNames" runat="server">
                                            </asp:DropDownList>
                                            
                                        <asp:RequiredFieldValidator ControlToValidate="drpCopyCutFolderNames" InitialValue="-1" CssClass="Error" 
                                        ValidationGroup="vgSendFolder" ID="RequiredFieldValidator1" runat="server" 
                                        ErrorMessage="Lütfen Klasör Seçiniz">
                                        </asp:RequiredFieldValidator>                                            
                                            
                                            <br />
                                            <asp:ImageButton ValidationGroup="vgSendFolder" ID="btnCopyToFolder" runat="server" ImageUrl="~/images/buttons/copy_and_move_to_folder.png"
                                                Style="margin-top: 5px" CommandName="CopyToFolder" />&nbsp;&nbsp;
                                            <asp:ImageButton ValidationGroup="vgSendFolder" ID="btnCutToFolder" runat="server" ImageUrl="~/images/buttons/move_to_folder.png"
                                                Style="margin-top: 5px" CommandName="CutToFolder" />
                                        </div>
                                    </li>
                                    <asp:Panel ID="pnlBuyCommunicationInformation" runat="server">
                                    <li class="Buy">
                                            <asp:LinkButton ID="btnBuyCommunicationInformation" runat="server" CommandName="BuyCommunicationInformation"
                                            Text="Ýletiþim Bilgisini Satýn Al"></asp:LinkButton>
                                            </li>
                                    </asp:Panel>
                                    <li class="Interview">
                                        <asp:LinkButton ID="btnAddInterview" runat="server" CommandName="OpenInterviewPage"
                                            Text="Mülakata Çaðýr"></asp:LinkButton></li>
                                    <li class="SendMessage">
                                        <asp:LinkButton ID="btnSendMessage" runat="server" CommandName="SendMessage" Text="Mesaj Gönder"></asp:LinkButton></li>
                                    <li class="Delete">
                                        <asp:LinkButton ID="btnDelete" runat="server" CommandName="Delete" Text="Sil"></asp:LinkButton></li>
                                </ul>
                            </td>
                        </tr>
                    </FooterTemplate>
                </asp:Repeater>
            </table>
            </asp:Panel>
            
            <div class="brclear">
            </div>
        </div>
    </div>
    <div class="BoxContentBottom">
    </div>
</div>
<div id="dvScript" runat="server"></div>