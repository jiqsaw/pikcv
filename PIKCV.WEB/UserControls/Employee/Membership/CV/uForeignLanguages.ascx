<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uForeignLanguages.ascx.cs" Inherits="UserControls_Employee_Membership_CV_uForeignLanguages" %>
<%@ Register Src="~/UserControls/Employee/Membership/CV/uCharacteristicAndSocialLifeNav.ascx" TagName="uCharacteristicAndSocialLifeNav" TagPrefix="uc2" %>

<uc2:uCharacteristicAndSocialLifeNav id="UCharacteristicAndSocialLifeNav1" runat="server"></uc2:uCharacteristicAndSocialLifeNav>

<div class="ContentColB">
    <h1>
        Yabancý Dil Bilgileri</h1>
        
        <asp:Panel runat="server" ID="pnlNoRecord" CssClass="infoMsg">
            <asp:Literal runat="server" ID="ltlNoRecord">
                <p> Þu an için yabandý dil kaydýnýz bulunmamaktadýr. </p>
            </asp:Literal>
        </asp:Panel>
        
        <asp:Panel runat="server" ID="pnlForeignLanguages" Visible="false">
        
            <asp:Repeater runat="server" ID="rptForeignLanguages" OnItemCommand="rptForeignLanguages_ItemCommand" OnItemDataBound="rptForeignLanguages_ItemDataBound">
                <HeaderTemplate>
                    <table width="100%" class="ItemGrid">
                        <tr>
                            <th> Dil </th>
                            <th> Okuma </th>
                            <th> Yazma </th>
                            <th> Konuþma </th>
                            <th> &nbsp; </th>
                        </tr>
                </HeaderTemplate>
                
                <ItemTemplate>

                    <tr>
                        <td> <strong> <%#DataBinder.Eval(Container.DataItem, "ForeignLanguageName")%> </strong> </td>
                        <td> <strong> <%#DataBinder.Eval(Container.DataItem, "Read")%> </strong> </td>
                        <td> <strong> <%#DataBinder.Eval(Container.DataItem, "Write")%> </strong> </td>
                        <td> <strong> <%#DataBinder.Eval(Container.DataItem, "Speak")%> </strong> </td>
                        <td>
                            
                            <asp:HyperLink runat="server" ID="hlEditLanguage" Text="Düzenle"
                            NavigateUrl=<%#DataBinder.Eval(Container.DataItem, "UserLanguageID", "javascript:MM_openBrWindow('CVPopup.aspx?CVPage=ForeignLanguagesAdd&UserLanguageID={0}','ForeignLanguages','width=550,height=620');") %>
                            ></asp:HyperLink> / 

                            <asp:HyperLink runat="server" ID="hlRemoveLanguage" Text="Sil" 
                            NavigateUrl='<%#DataBinder.Eval(Container.DataItem, "UserLanguageID")%>'>
                            </asp:HyperLink>
                        </td>
                    </tr>
                    
                </ItemTemplate>
                
                <FooterTemplate>
                    </table>
                </FooterTemplate>
            </asp:Repeater>

        </asp:Panel>
        
    <p>&nbsp;</p>
       
    <p class="floatRight">
        <asp:ImageButton runat="server" ID="ImgBtnContinue" AlternateText="Devam Et" 
        ImageUrl="~/Images/buttons/continue.png" BorderWidth="0" OnClick="ImgBtnContinue_Click" />
    </p>
       
    <asp:HyperLink runat="server" ID="hlAddSchool" 
    ImageUrl="~/Images/buttons/add_language.png"
    NavigateUrl="javascript:MM_openBrWindow('CVPopup.aspx?CVPage=ForeignLanguagesAdd','','width=550,height=620');"
    ></asp:HyperLink>

</div>