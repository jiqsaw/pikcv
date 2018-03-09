<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uProhibitedCompanies.ascx.cs" Inherits="UserControls_Employee_Membership_CV_uProhibitedCompanies" %>
<%@ Register Src="~/UserControls/Common/ModalPopup/ModalPopup.ascx" TagName="ModalPopup"
    TagPrefix="uc1" %>
    

<uc1:ModalPopup ID="ShowModal" runat="server" Visible="false" />

<div class="ContentColA">
    <ul class="SubTabNav">
        <li> <asp:HyperLink runat="server" ID="hlEmploymentChooices" Text="Çalýþma Tercihleri"
            NavigateUrl="#Employee-Membership-CV&CVFocus=||FocusNo||"></asp:HyperLink> </li>  
        
        <li> <asp:HyperLink runat="server" ID="hlPlacementPreferences" Text="Çalýþmak Ýstenen Yerler"
            NavigateUrl="#Employee-Membership-CV&CVFocus=||FocusNo||"></asp:HyperLink> </li>

        <li class="selected"><a href="javascript:;">Ambargolu Firmalar</a></li>  
                    
        <li> <asp:HyperLink runat="server" ID="hlReferences" Text="Referanslar"
        NavigateUrl="#Employee-Membership-CV&CVFocus=||FocusNo||"></asp:HyperLink> </li>
    </ul>
</div>

<div class="ContentColB">
    <h1>
        Ambargolu Firmalar</h1>
    <p>
        &nbsp;</p>
    <table class="FormTable">
        <tr>
            <td align="right" valign="top">
                <p>
                    <strong>Firmalar </strong>
                </p>
            </td>
            <td>
                <table width="100%">
                    <tr>
                        <td valign="top">
                            <asp:ListBox Width="200" Height="200" runat="server" ID="lbCompanies" SelectionMode="Multiple"></asp:ListBox >
                        </td>
                        <td>
                            <p>
                                <asp:Image runat="server" ID="imgAddToListCompany" ImageUrl="~/Images/buttons/add_to_list.png" /><br />
                                <br />
                                <asp:Image runat="server" ID="imgRemoveToListCompany" ImageUrl="~/Images/buttons/remove_from_list.png" />
                            </p>
                        </td>
                        <td valign="top">
                            <asp:ListBox Width="200" Height="180" runat="server" ID="lbSelectedCompanies" SelectionMode="Multiple"></asp:ListBox>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    
    <p class="floatRight">
        <asp:ImageButton runat="server" ID="ImgBtnContinue" AlternateText="Devam Et" 
        ImageUrl="~/Images/buttons/continue.png" BorderWidth="0" OnClick="ImgBtnContinue_Click" />
        <asp:ImageButton runat="server" ID="ImgBtnSave" AlternateText="Kaydet" Visible="false"
        ImageUrl="~/Images/buttons/corp_update_and_save_employee.png" BorderWidth="0" OnClick="ImgBtnContinue_Click" ValidationGroup="vgForm" />
    </p>
    
</div>
