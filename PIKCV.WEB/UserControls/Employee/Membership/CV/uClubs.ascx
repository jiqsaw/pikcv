<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uClubs.ascx.cs" Inherits="UserControls_Employee_Membership_CV_uClubs" %>
<%@ Register Src="~/UserControls/Employee/Membership/CV/uCharacteristicAndSocialLifeNav.ascx" TagName="uCharacteristicAndSocialLifeNav" TagPrefix="uc2" %>
<uc2:uCharacteristicAndSocialLifeNav id="UCharacteristicAndSocialLifeNav1" runat="server"></uc2:uCharacteristicAndSocialLifeNav>
<%@ Register Src="~/UserControls/Common/ModalPopup/ModalPopup.ascx" TagName="ModalPopup"
    TagPrefix="uc1" %>
    

<uc1:ModalPopup ID="ShowModal" runat="server" Visible="false" />

<div class="ContentColB">
    <h1>
        Kul�p ve Dernekler</h1>
    <table width="100%" class="FormTable">
        <tr>
            <td colspan="2">
                <p>
                    �ye oldu�unuz kul�p ve dernekleri detayl� yaz�n�z.</p> <br />

                <asp:TextBox runat="server" ID="txtClubs" TextMode="multiLine" Width="480" Rows="6" MaxLength="2048"></asp:TextBox>           
                    
            </td>
        </tr>
    </table>
    <p>
        &nbsp;</p>
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