<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uDriverLicense.ascx.cs" Inherits="UserControls_Employee_Membership_CV_uDriverLicense" %>
<%@ Register Src="~/UserControls/Employee/Membership/CV/uCharacteristicAndSocialLifeNav.ascx" TagName="uCharacteristicAndSocialLifeNav" TagPrefix="uc2" %>
<%@ Register Src="~/UserControls/Common/ModalPopup/ModalPopup.ascx" TagName="ModalPopup"
    TagPrefix="uc1" %>
    

<uc1:ModalPopup ID="ShowModal" runat="server" Visible="false" />

<script type="text/javascript">
    function ShowHideLicenceYear(ElementID, Value, ddlYearID) {
        var ddl = document.getElementById(ElementID);
        var ddlYear = document.getElementById(ddlYearID);
        if (ddl.options[ddl.selectedIndex].value!=Value) { 
            TrLicenceYear.style.display='block';
             ddlYear.options[0].selected = true;
        } 
        else {
            TrLicenceYear.style.display='none';
            ddlYear.options[1].selected = true;
        }
    }
</script>

<uc2:uCharacteristicAndSocialLifeNav id="UCharacteristicAndSocialLifeNav1" runat="server"></uc2:uCharacteristicAndSocialLifeNav>

<div class="ContentColB">
    <h1>
        Sürücü Belgesi</h1>
    <table width="100%" class="FormTable">
        <tr>
            <td width="25%" align="right">
                <p>
                    <strong>Ehliyet Sýnýfý</strong></p>
            </td>
            <td width="75%">
                <%--<asp:DropDownList runat="server" ID="ddlDriverLicenseTypes"></asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="ddlDriverLicenseTypes"
                    CssClass="Error" ErrorMessage="Lütfen Ehliyet Sýnýfýný Seçiniz" SetFocusOnError="True"
                    ValidationGroup="vgForm" InitialValue="0"></asp:RequiredFieldValidator>--%>
                    <asp:CheckBoxList runat="server" ID="chDriverLicenses" RepeatDirection="Horizontal">
                    </asp:CheckBoxList>
            </td>
        </tr>
<%--        <tr id="TrLicenceYear">
            <td width="25%" align="right">
                <p>
                    <strong>Veriliþ Yýlý</strong></p>
            </td>
            <td width="75%">
                <asp:DropDownList runat="server" ID="ddlDriverLicenseYear"></asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="ddlDriverLicenseYear"
                    CssClass="Error" ErrorMessage="Lütfen Ehliyet Yýlýný Seçiniz" InitialValue="0"
                    SetFocusOnError="True" ValidationGroup="vgForm"></asp:RequiredFieldValidator>
            </td>
        </tr>   --%>     
    </table>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p class="floatRight">
        <asp:ImageButton runat="server" ValidationGroup="vgForm" ID="ImgBtnContinue" AlternateText="Devam Et" 
        ImageUrl="~/Images/buttons/continue.png" BorderWidth="0" OnClick="ImgBtnContinue_Click" />
        <asp:ImageButton runat="server" ID="ImgBtnSave" AlternateText="Kaydet" Visible="false"
        ImageUrl="~/Images/buttons/corp_update_and_save_employee.png" BorderWidth="0" OnClick="ImgBtnContinue_Click" ValidationGroup="vgForm" />
    </p>
</div>

<%--<script type="text/javascript">
var ddl = '<%=ddlDriverLicenseTypes.ClientID %>';
var Value = '<%=(int)PIKCV.COM.EnumDB.LicenceTypes.NoneID %>'
if ($get(ddl).options[$get(ddl).selectedIndex].value==Value) { 
    TrLicenceYear.style.display='none';
} 
else { 
    TrLicenceYear.style.display='block'; 
}
</script>--%>