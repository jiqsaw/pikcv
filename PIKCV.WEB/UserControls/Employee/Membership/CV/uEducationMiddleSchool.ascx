<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uEducationMiddleSchool.ascx.cs" Inherits="UserControls_Employee_Membership_CV_uEducationMiddleSchool" %>
<%@ Register src="~/UserControls/Common/uDate.ascx" TagName="uDate" TagPrefix="uc1" %>
<%@ Register Src="~/UserControls/Employee/Membership/CV/uEducationNav.ascx" TagName="uEducationNav" TagPrefix="uc2" %>

<uc2:uEducationNav Visible="false" ID="UEducationNav1" runat="server"></uc2:uEducationNav>

<div class="ContentColB">
    <table width="100%" class="FormTable">
            <tr>
                <td width="30%">
                    &nbsp;</td>
                <td width="70%">
                    <h1>
                        <asp:Literal runat="server" ID="ltlTitle">Ýlköðretim Ekle</asp:Literal>
                    </h1>
                </td>
            </tr>
    <tr>
        <td align="right" valign="top"><p><strong>Okul Adý</strong></p></td>
        <td valign="top"> <asp:TextBox ID="txtMiddleSchoolName" runat="server" MaxLength="512"></asp:TextBox> 
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtMiddleSchoolName"
                CssClass="Error" ErrorMessage="Lütfen Okul Adýný Giriniz" SetFocusOnError="True"
                ValidationGroup="vgForm"></asp:RequiredFieldValidator></td>
    </tr>

    <tr>
        <td align="right" style="height: 24px">
            <p>
                <strong>Devam durumu</strong></p>
        </td>
        <td style="height: 24px">
            <asp:DropDownList runat="server" ID="ddlEducationStates"></asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="ddlEducationStates"
                CssClass="Error" ErrorMessage="Lütfen Devam Durumunuzu Giriniz" SetFocusOnError="True"
                ValidationGroup="vgForm" InitialValue="0"></asp:RequiredFieldValidator></td>
    </tr>
    
    <tr id="trDate" style="display: none;">
        <td align="right"><p><strong>Mezuniyet tarihi</strong></p></td>
        <td>
            <uc1:uDate id="UDate1" runat="server"></uc1:uDate>
        </td>
    </tr>

    <tr>
      <td align="right" valign="top">&nbsp;</td>
      <td>&nbsp;</td>
    </tr>
    
    <tr>
        <td align="right" valign="top">&nbsp;</td>
        <td>
            <asp:ImageButton runat="server" ID="ImgBtnContinue" AlternateText="Devam Et" 
            ImageUrl="~/Images/buttons/continue.png" BorderWidth="0" OnClick="ImgBtnContinue_Click" ValidationGroup="vgForm" />
            <asp:ImageButton runat="server" ID="ImgBtnSave" AlternateText="Kaydet" Visible="false"
            ImageUrl="~/Images/buttons/corp_update_and_save_employee.png" BorderWidth="0" OnClick="ImgBtnContinue_Click" ValidationGroup="vgForm" />
        </td>
    </tr>
    
</table>

</div>

<div id="dvScript" runat="server"></div>