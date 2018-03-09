<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uEmployment.ascx.cs" Inherits="UserControls_Employee_Membership_CV_uEmployment" %>

<div class="ContentColB2">
    <h1>
        Ýþyeri bilgileriniz</h1>
        
        <table width="100%" class="FormTable">
            <tr>
                <td><br />
                    <p>
                        Toplam Ýþ Deneyiminizi Seçiniz: 
                        <asp:DropDownList runat="server" ID="ddlTotalWorkExperience" AutoPostBack="True" OnSelectedIndexChanged="ddlTotalWorkExperience_SelectedIndexChanged" ValidationGroup="vgForm"></asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="ddlTotalWorkExperience"
                            CssClass="Error" ErrorMessage="Lütfen Toplam Ýþ Deneyiminizi Seçiniz" InitialValue="-1"
                            ValidationGroup="vgForm"></asp:RequiredFieldValidator></p>
                </td>
            </tr>
        </table>
        
        <asp:Panel runat="server" ID="pnlNoRecord" CssClass="infoMsg">
            <asp:Literal runat="server" ID="ltlNoRecord">
                <p> Þu an için iþyeri bilgileri bulunmamaktadýr. </p>
            </asp:Literal>
        </asp:Panel>
        
        <asp:Panel runat="server" ID="pnlEmployment" Visible="false">
        
            <asp:Repeater runat="server" ID="rptEmployment" OnItemCommand="rptEmployment_ItemCommand" OnItemDataBound="rptEmployment_ItemDataBound">
                <HeaderTemplate>
                    <table width="100%" class="ItemGrid">
                        <tr>
                            <th> <strong> Tarihler</strong> </th>
                            <th> <strong>Ýþyeri Adý </strong></th>
                            <th> <strong>Pozisyon</strong> </th>
                            <th> &nbsp; </th>
                        </tr>
                </HeaderTemplate>
                
                <ItemTemplate>

                    <tr>
                        <td> 
                             <%#Convert.ToDateTime(DataBinder.Eval(Container.DataItem, "StartDate")).ToShortDateString() %> - 
                            <asp:Literal runat="server" ID="ltlEndDate" Text='
                            <%#Convert.ToDateTime(DataBinder.Eval(Container.DataItem, "EndDate")).ToShortDateString() %>
                            ' />
                            
                        </td>
                        <td> <%#DataBinder.Eval(Container.DataItem, "CompanyName") %> </td>
                        <td> <%#DataBinder.Eval(Container.DataItem, "PositionName")%> </td>
                        <td>
                            
                            <asp:HyperLink runat="server" ID="hlEditEmployment" Text="Düzenle"
                            NavigateUrl=<%#DataBinder.Eval(Container.DataItem, "UserEmploymentID", "javascript:MM_openBrWindow('CVPopup.aspx?CVPage=EmploymentAdd&UserEmploymentID={0}','Employment','width=550,height=620');") %>
                            ></asp:HyperLink> / 

                            <asp:HyperLink runat="server" ID="hlRemoveEmployment" Text="Sil" 
                            NavigateUrl='<%#DataBinder.Eval(Container.DataItem, "UserEmploymentID")%>'>
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
        ImageUrl="~/Images/buttons/continue.png" BorderWidth="0" OnClick="ImgBtnContinue_Click" ValidationGroup="vgForm" />
    </p>
       
    <asp:HyperLink runat="server" ID="hlAddEmployment"
    ImageUrl="~/Images/buttons/add_employer.png"
    NavigateUrl="javascript:MM_openBrWindow('CVPopup.aspx?CVPage=EmploymentAdd','','width=550,height=620');"
    ></asp:HyperLink>

</div>