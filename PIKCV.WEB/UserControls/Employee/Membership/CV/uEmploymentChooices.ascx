<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uEmploymentChooices.ascx.cs" Inherits="UserControls_Employee_Membership_CV_uEmploymentChooices" %>
<%@ Register Src="~/UserControls/Common/ModalPopup/ModalPopup.ascx" TagName="ModalPopup"
    TagPrefix="uc1" %>
    

<uc1:ModalPopup ID="ShowModal" runat="server" Visible="false" />

<div class="ContentColA">
    <ul class="SubTabNav">
        <li class="selected"><a href="javascript:;">Çalýþma Tercihleri</a></li>    
        <li> <asp:HyperLink runat="server" ID="hlPlacementPreferences" Text="Çalýþmak Ýstenen Yerler"
            NavigateUrl="#Employee-Membership-CV&CVFocus=||FocusNo||"></asp:HyperLink> </li>
        <li> <asp:HyperLink runat="server" ID="hlProhibitedCompanies" Text="Ambargolu Firmalar"
            NavigateUrl="#Employee-Membership-CV&CVFocus=||FocusNo||"></asp:HyperLink> </li>             
        <li> <asp:HyperLink runat="server" ID="hlReferences" Text="Referanslar"
        NavigateUrl="#Employee-Membership-CV&CVFocus=||FocusNo||"></asp:HyperLink> </li>
    </ul>
</div>

<div class="ContentColB">
    <h1>
        Çalýþmak istediðiniz sektörler ve pozisyonlar</h1>
    <p>
        &nbsp;</p>
    <table class="FormTable">
        <tr>
            <td align="right" valign="top">
                <strong>Çalýþmak istediðiniz sektörler</strong><p class="mute">(En çok 10 tercih yapabilirsiniz)</p>
            </td>
            <td>
                <table width="100%">
                    <tr>
                        <td valign="top">
                            <asp:ListBox Width="200" Height="180" runat="server" ID="lbSectors" SelectionMode="Multiple"></asp:ListBox >
                        </td>
                        <td>
                            <p>
                                <asp:Image runat="server" ID="imgAddToListSector" ImageUrl="~/Images/buttons/add_to_list.png" /><br />
                                <br />
                                <asp:Image runat="server" ID="imgRemoveToListSector" ImageUrl="~/Images/buttons/remove_from_list.png" />
                            </p>
                        </td>
                        <td valign="top">
                            <asp:ListBox Width="200" Height="180" runat="server" ID="lbSelectedSectors" SelectionMode="Multiple"></asp:ListBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="lbSelectedSectors"
                            CssClass="Error" ErrorMessage="Lütfen En Az 1 Sektör Seçiniz" SetFocusOnError="True"
                            ValidationGroup="vgForm"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td align="right" valign="top">
                <strong>Çalýþmak istediðiniz pozisyonlar</strong><p class="mute">(En çok 10 tercih yapabilirsiniz)</p>
            </td>
            <td>
                <table width="100%">
                    <tr>
                        <td valign="top">
                            <asp:ListBox runat="server" Height="180" ID="lbPositions" Width="200" SelectionMode="Multiple"></asp:ListBox >
                        </td>
                        <td>
                            <p>
                                <asp:Image runat="server" ID="imgAddToListPositons" ImageUrl="~/Images/buttons/add_to_list.png" /><br />
                                <br />
                                <asp:Image runat="server" ID="imgRemoveToListPositions" ImageUrl="~/Images/buttons/remove_from_list.png" />
                            </p>
                        </td>
                        <td valign="top">
                            <asp:ListBox Width="200" Height="180" runat="server" ID="lbSelectedPositions" SelectionMode="Multiple"></asp:ListBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="lbSelectedPositions"
                            CssClass="Error" ErrorMessage="Lütfen En Az 1 Pozisyon Seçiniz" SetFocusOnError="True"
                            ValidationGroup="vgForm"></asp:RequiredFieldValidator>                            
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
        ImageUrl="~/Images/buttons/continue.png" BorderWidth="0" OnClick="ImgBtnContinue_Click" ValidationGroup="vgForm" />
        <asp:ImageButton runat="server" ID="ImgBtnSave" AlternateText="Kaydet" Visible="false"
        ImageUrl="~/Images/buttons/corp_update_and_save_employee.png" BorderWidth="0" OnClick="ImgBtnContinue_Click" ValidationGroup="vgForm" />
    </p>
    
</div>
