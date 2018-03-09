<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uEducationHighSchool.ascx.cs" Inherits="UserControls_Employee_Membership_CV_uEducationHighSchool" %>
<%@ Register Src="~/UserControls/Common/uDate.ascx" TagName="uDate" TagPrefix="uc1" %>
<%@ Register Src="~/UserControls/Employee/Membership/CV/uEducationNav.ascx" TagName="uEducationNav" TagPrefix="uc2" %>

<uc2:uEducationNav Visible="false" id="UEducationNav1" runat="server"></uc2:uEducationNav>

<div class="ContentColB">
    <table width="100%" class="FormTable">
            <tr>
                <td width="30%">
                    &nbsp;</td>
                <td width="70%">
                    <h1>
                        <asp:Literal runat="server" ID="ltlTitle">Lise Ekle</asp:Literal>
                    </h1>
                </td>
            </tr>
    <tr>
        <td align="right" valign="top"><p><strong>Okul Tipi</strong></p></td>
        <td valign="top"> <asp:DropDownList runat="server" ID="ddlHighSchoolTypes"></asp:DropDownList> 
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="ddlHighSchoolTypes"
                CssClass="Error" ErrorMessage="Lütfen Okul Tipini Giriniz" SetFocusOnError="True"
                ValidationGroup="vgForm" InitialValue="0"></asp:RequiredFieldValidator></td>
    </tr>
        
    <tr>
        <td align="right" valign="top" style="height: 26px"><p><strong>Okul Adý</strong></p></td>
        <td valign="top" style="height: 26px"> <asp:TextBox ID="txtHighSchoolName" runat="server" MaxLength="512"></asp:TextBox> 
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtHighSchoolName"
                CssClass="Error" ErrorMessage="Lütfen Okul Adýný Giriniz" SetFocusOnError="True"
                ValidationGroup="vgForm"></asp:RequiredFieldValidator></td>
    </tr>

    <tr>
        <td align="right">
            <p>
                <strong>Devam durumu</strong></p>
        </td>
        <td>
            <asp:DropDownList runat="server" ID="ddlEducationStates"></asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="ddlEducationStates"
                CssClass="Error" ErrorMessage="Lütfen Mezuniyet Durumunuzu Giriniz" SetFocusOnError="True"
                ValidationGroup="vgForm" InitialValue="0"></asp:RequiredFieldValidator></td>
    </tr>
    
    <tr id="trDate">
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
            <asp:ImageButton runat="server" ID="ImgBtnSave" AlternateText="Kaydet"
            ImageUrl="~/Images/buttons/corp_update_and_save_employee.png" BorderWidth="0" OnClick="ImgBtnContinue_Click" ValidationGroup="vgForm" />
        </td>
    </tr>
    
</table>

</div>

<div id="dvScript" runat="server"></div>