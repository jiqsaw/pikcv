<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uEducation.ascx.cs" Inherits="UserControls_Employee_Membership_CV_uEducation" %>
<div class="ContentColB2" style="padding-left: 20px;">
    <h1>
        Eðitim Durumu</h1>
    <table width="100%" class="FormTable">
        <tr>
            <td style="width: 150px">
                <p>
                    <strong>Mezuniyet Durumunuz</strong></p>
            </td>
            <td>
                <asp:DropDownList runat="server" ID="ddlEducationTypes">
                    <asp:ListItem Text="Doktora" Value="6"></asp:ListItem>
                    <asp:ListItem Text="Lisans Üstü" Value="5"></asp:ListItem>
                    <asp:ListItem Text="Lisans" Value="4"></asp:ListItem>
                    <asp:ListItem Text="Meslek Yüksek Okulu" Value="3"></asp:ListItem>
                    <asp:ListItem Text="Lise" Value="2"></asp:ListItem>
                    <asp:ListItem Text="Ýlköðretim" Value="1"></asp:ListItem>
                    <asp:ListItem Selected="True" Text="Lütfen Seçiniz" Value="0"></asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="ddlEducationTypes"
                    CssClass="Error" ErrorMessage="Lütfen Mezuniyet Durumunuzu Giriniz" InitialValue="0"
                    SetFocusOnError="True" ValidationGroup="vgForm"></asp:RequiredFieldValidator></td>
        </tr>
    </table>

    <p class="infoMsg" style="display: none;">
        <asp:Literal runat="server" ID="ltlPleaseSelectSchool">
        Lütfen son mezun olduðunuz okula göre seçim yapýnýz
        </asp:Literal>
        &nbsp;</p>
        
        <asp:Panel runat="server" ID="pnlNoRecord" CssClass="infoMsg">
            <asp:Literal runat="server" ID="ltlNoRecord">
                <p> Þu an için okul kaydýnýz bulunmamaktadýr. </p>
            </asp:Literal>
        </asp:Panel>        
        
        <asp:Panel runat="server" ID="pnlEducationList" Visible="false">
        
        <asp:Repeater runat="server" ID="rptEducationList" OnItemCommand="rptEducationList_ItemCommand" OnItemDataBound="rptEducationList_ItemDataBound">
                <HeaderTemplate>
                    <table width="100%" class="ItemGrid">
                        <tr>
                            <th> Eðitim Tipi </th>
                            <th> Okul Adý </th>
                            <th> Mezuniyet </th>
                            <th> &nbsp; </th>
                        </tr>
                </HeaderTemplate>
                
                <ItemTemplate>

                    <tr>
                        <td> <strong> <%#Eval("EducationLevelName") %> </strong> </td>
                        <td> <strong> <%#DataBinder.Eval(Container.DataItem, "SchoolName") %> </strong> </td>
                        <td> <strong> <%#DataBinder.Eval(Container.DataItem, "EndYear") %> </strong> </td>
                        <td>
                            
                            <asp:HiddenField runat="server" ID="hdEducationLevelID" Value='<%#DataBinder.Eval(Container.DataItem, "EducationLevelID") %>' />
                            
                            <asp:HyperLink runat="server" ID="hlEditSchool" Text="Düzenle"
                            NavigateUrl=<%#DataBinder.Eval(Container.DataItem, "UserOREducationID", "javascript:MM_openBrWindow('CVPopup.aspx?CVPage=||Popup||&EducationType=||ET||&UserOREducationID={0}','University','width=550,height=620');") %>
                            ></asp:HyperLink> / 

                            <asp:HyperLink runat="server" ID="hlRemoveSchool" Text="Sil" 
                            NavigateUrl='<%#DataBinder.Eval(Container.DataItem, "UserOREducationID")%>'>
                            </asp:HyperLink>
                        </td>
                    </tr>
                    
                </ItemTemplate>
                
                <FooterTemplate>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
         
        </asp:Panel>
        
       
    <asp:HyperLink runat="server" ID="hlAddSchool" 
    ImageUrl="~/Images/buttons/add_school.png"
    NavigateUrl="javascript:MM_openBrWindow('CVPopup.aspx?CVPage=EducationUniversityAdd&EducationType=||ST||','','width=550,height=620');"
    ></asp:HyperLink>        
    &nbsp;&nbsp;
    <asp:HyperLink runat="server" ID="hlAddHighSchool"
    ImageUrl="~/Images/buttons/add_highschool.png"
    NavigateUrl="javascript:MM_openBrWindow('CVPopup.aspx?CVPage=EducationHighSchool&EducationType=||ST||','','width=550,height=620');"
    ></asp:HyperLink>   
    &nbsp;&nbsp;
    <asp:HyperLink runat="server" ID="hlAddMiddleSchool"
    ImageUrl="~/Images/buttons/add_middleschool.png"
    NavigateUrl="javascript:MM_openBrWindow('CVPopup.aspx?CVPage=EducationMiddleSchool&EducationType=||ST||','','width=550,height=620');"
    ></asp:HyperLink> 
            
    <p>
        &nbsp;</p>
    <p class="floatRight">
        <asp:ImageButton runat="server" ID="ImgBtnContinue" AlternateText="Devam Et" 
        ImageUrl="~/Images/buttons/continue.png" BorderWidth="0" OnClick="ImgBtnContinue_Click" ValidationGroup="vgForm" />
    </p>
</div>
