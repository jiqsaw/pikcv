<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uEducationUniversity0.ascx.cs" Inherits="UserControls_Employee_Membership_CV_uEducationUniversity0" %>
<%@ Register Src="~/UserControls/Employee/Membership/CV/uEducationNav.ascx" TagName="uEducationNav" TagPrefix="uc2" %>

<uc2:uEducationNav id="UEducationNav1" runat="server"></uc2:uEducationNav>

<div class="ContentColB">
    <h1>
        Meslek Yüksek Okulu bilgileri</h1>
        
        <asp:Panel runat="server" ID="pnlNoRecord" CssClass="infoMsg">
            <asp:Literal runat="server" ID="ltlNoRecord">
                <p> Þu an için meslekyüksek okulu kaydýnýz bulunmamaktadýr. </p>
            </asp:Literal>
        </asp:Panel>
        
        <asp:Panel runat="server" ID="pnlUniversity0List" Visible="false">
        
            <asp:Repeater runat="server" ID="rptUniversity0List" OnItemDataBound="rptUniversity0List_ItemDataBound" OnItemCommand="rptUniversity0List_ItemCommand">
                <HeaderTemplate>
                    <table width="100%" class="ItemGrid">
                        <tr>
                            <th> Tarihler </th>
                            <th> Üniversite </th>
                            <th> Bölüm </th>
                            <th> &nbsp; </th>
                        </tr>
                </HeaderTemplate>
                
                <ItemTemplate>

                    <tr>
                        <td> <strong> <%#DataBinder.Eval(Container.DataItem, "StartYear") %> - <%#DataBinder.Eval(Container.DataItem, "EndYear") %> </strong> </td>
                        <td> <strong> <%#DataBinder.Eval(Container.DataItem, "SchoolName") %> </strong> </td>
                        <td> <strong> <%#DataBinder.Eval(Container.DataItem, "DepartmentName") %> </strong> </td>
                        <td>
                            
                            <asp:HyperLink runat="server" ID="hlEditSchool" Text="Düzenle"
                            NavigateUrl=<%#DataBinder.Eval(Container.DataItem, "UserEducationID", "javascript:MM_openBrWindow('CVPopup.aspx?CVPage=EducationUniversityAdd&EducationType=||ST||&UserEducationID={0}','University','width=550,height=620');") %>
                            ></asp:HyperLink> / 

                            <asp:LinkButton runat="server" ID="lnkRemoveSchool" Text="Sil" 
                            CommandName="Delete"
                            CommandArgument='<%#DataBinder.Eval(Container.DataItem, "UserEducationID")%>'
                            OnClientClick="return confirm('Silmek istediðinizden emin misiniz?')">
                            </asp:LinkButton>
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
    ImageUrl="~/Images/buttons/add_school.png"
    NavigateUrl="javascript:MM_openBrWindow('CVPopup.aspx?CVPage=EducationUniversityAdd&EducationType=||ST||','','width=550,height=620');"
    ></asp:HyperLink>

</div>
