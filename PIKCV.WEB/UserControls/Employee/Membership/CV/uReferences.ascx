<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uReferences.ascx.cs" Inherits="UserControls_Employee_Membership_CV_uReferences" %>

<div class="ContentColA">
    <ul class="SubTabNav">
        <li> <asp:HyperLink runat="server" ID="hlEmploymentChooices" Text="Çalýþma Tercihleri"
            NavigateUrl="#Employee-Membership-CV&CVFocus=||FocusNo||"></asp:HyperLink> </li>
            
        <li> <asp:HyperLink runat="server" ID="hlPlacementPreferences" Text="Çalýþmak Ýstenen Yerler"
        NavigateUrl="#Employee-Membership-CV&CVFocus=||FocusNo||"></asp:HyperLink> </li>            

        <li> <asp:HyperLink runat="server" ID="hlProhibitedCompanies" Text="Ambargolu Firmalar"
            NavigateUrl="#Employee-Membership-CV&CVFocus=||FocusNo||"></asp:HyperLink> </li> 
            
        <li class="selected"><a href="javascript:;">Referanslar</a></li>
    </ul>
</div>

<div class="ContentColB">
    <h1>
        Referans bilgileri</h1>
        
        <asp:Panel runat="server" ID="pnlNoRecord" CssClass="infoMsg">
            <asp:Literal runat="server" ID="ltlNoRecord">
                <p> Þu an için referans bilgileriniz bulunmamaktadýr. </p>
            </asp:Literal>
        </asp:Panel>
        
        <asp:Panel runat="server" ID="pnlReferences" Visible="false">
        
            <asp:Repeater runat="server" ID="rptReferences" OnItemCommand="rptReferences_ItemCommand" OnItemDataBound="rptReferences_ItemDataBound">
                <HeaderTemplate>
                    <table width="100%" class="ItemGrid">
                        <tr>
                            <th> Adý Soyadý </th>
                            <th> Firma </th>
                            <th> Pozisyon </th>
                            <th> &nbsp; </th>
                        </tr>
                </HeaderTemplate>
                
                <ItemTemplate>

                    <tr>
                        <td> 
                            <strong> <%#DataBinder.Eval(Container.DataItem, "ReferenceName")%> </strong> 
                        </td>
                        <td> <strong> <%#DataBinder.Eval(Container.DataItem, "Company") %> </strong> </td>
                        <td> <strong> <%#DataBinder.Eval(Container.DataItem, "Position")%> </strong> </td>
                        <td>
                            
                            <asp:HyperLink runat="server" ID="hlEditReferences" Text="Düzenle"
                            NavigateUrl=<%#DataBinder.Eval(Container.DataItem, "UserReferenceID", "javascript:MM_openBrWindow('CVPopup.aspx?CVPage=ReferenceAdd&UserReferenceID={0}','References','width=550,height=620');") %>
                            ></asp:HyperLink> / 

                            <asp:HyperLink runat="server" ID="hlRemoveReferences" Text="Sil" 
                            NavigateUrl='<%#DataBinder.Eval(Container.DataItem, "UserReferenceID")%>'>
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
       
    <asp:HyperLink runat="server" ID="hlAddReferences"
    ImageUrl="~/Images/buttons/add_reference.png"
    NavigateUrl="javascript:MM_openBrWindow('CVPopup.aspx?CVPage=ReferenceAdd','','width=550,height=620');"
    ></asp:HyperLink>

</div>