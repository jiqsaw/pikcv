<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uEducationUniversityAdd.ascx.cs"
    Inherits="UserControls_Employee_Membership_CV_uEducationUniversity0Add" %>
<%@ Register Src="~/UserControls/Common/uDate.ascx" TagName="uDate" TagPrefix="uc1" %>
<%@ Register Src="~/UserControls/Common/ModalPopup/ModalPopup.ascx" TagName="ModalPopup"
    TagPrefix="uc1" %>

<uc1:ModalPopup ID="ShowModal" runat="server" Visible="false" />


 <script type="text/javascript"> 

function ModalOK() 
{
    self.close();
    window.opener.location.reload();
}

function cvUniversityControl(source, args) 
{   
    args.IsValid = false;
    
    var ddlUniversityID = '<%=ddlUniversityNames.ClientID %>';
    var txtUniversityID = '<%=txtUniversityNames.ClientID %>';
    
    if ((document.getElementById(ddlUniversityID).value > 0) || ((ddlSelectedValue(ddlUniversityID) == 0) && (document.getElementById(txtUniversityID).value!=''))) {
        args.IsValid = true;
    }
}

function cvDepartmentControl(source, args) 
{   
    args.IsValid = false;
    
    var ddlUniversityDepartmentID = '<%=ddlUniversityDepartments.ClientID %>';
    var txtUniversityDepartmentID = '<%=txtUniversityDepartments.ClientID %>';
    
    if ((document.getElementById(ddlUniversityDepartmentID).value > 0) || ((ddlSelectedValue(ddlUniversityDepartmentID) == 0) && (document.getElementById(txtUniversityDepartmentID).value!=''))) {
        args.IsValid = true;
    }
}

function cvCityControl(source, args) 
{   
    args.IsValid = false;
    
    var ddlCityID = '<%=ddlCities.ClientID %>';
    var txtOtherCityID = '<%=txtOtherCity.ClientID %>';
    
    if ((document.getElementById(ddlCityID).value > 0) || ((ddlSelectedValue(ddlCityID) == 0) && (document.getElementById(txtOtherCityID).value!=''))) {
        args.IsValid = true;
    }    
    
//    if ((document.getElementById(ddlCityID).value != 0) || (document.getElementById(txtOtherCityID).value!='')) {
  //      args.IsValid = true;
   // }
}

function TrEducationVisible(ddl, Value) {
    ShowDate(ddl, Value);
    if (ddl.options[ddl.selectedIndex].value!=Value) { trDegree.style.display='none'; } 
    else { trDegree.style.display='block'; }
}

function OpenCloseSchool() {
    var ddlID = '<%=ddlUniversityNames.ClientID %>';
    if (ddlSelectedValue(ddlID) == 0) { dvOtherSchool.style.display='block'; }
    else dvOtherSchool.style.display='none';
}

function OpenCloseDepartment() {
    var ddlID = '<%=ddlUniversityDepartments.ClientID %>';
    if (ddlSelectedValue(ddlID) == 0) { dvOtherDepartment.style.display='block'; }
    else dvOtherDepartment.style.display='none';
}

function OpenCloseCity() {
    var ddlID = '<%=ddlCities.ClientID %>';
    if (ddlSelectedValue(ddlID) == 0) { dvOtherCity.style.display='block'; }
    else dvOtherCity.style.display='none';
}

</script>

<div class="contentPad">
    <div class="BoxPadder">
        <table style="text-align: left;" width="100%" class="FormTable">
            <tr>
                <td width="30%">
                    &nbsp;</td>
                <td width="70%">
                    <h1>
                        <asp:Literal runat="server" ID="ltlTitle">Üniversite Ekle</asp:Literal>
                    </h1>
                </td>
            </tr>
            <tr>
                <td align="right" valign="top">
                    <p>
                        <strong>Eðitim Tipi</strong></p>
                </td>
                <td>
                    <asp:DropDownList runat="server" ID="ddlEducationLevels"></asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator0" runat="server" ControlToValidate="ddlEducationLevels"
                        CssClass="Error" ErrorMessage="Lütfen Eðtim Tipini Seçiniz" InitialValue="-1"
                        SetFocusOnError="True" ValidationGroup="vgForm"></asp:RequiredFieldValidator>                    
                </td>
            </tr>            
            <tr>
                <td align="right" valign="top">
                    <p>
                        <strong>Üniversite</strong></p>
                </td>
                <td>
                    <asp:DropDownList runat="server" ID="ddlUniversityNames"></asp:DropDownList>
                    <br />
                    <asp:CustomValidator ID="CustomValidatorUniversity" runat="server" Display="Dynamic" 
                    ClientValidationFunction="cvUniversityControl" ValidationGroup="vgForm" 
                    ErrorMessage="Lütfen Üniversite Giriniz" CssClass="Error">
                    </asp:CustomValidator>                    
                    <div id="dvOtherSchool" style="display: none;">
                        <p class="mute">
                            Aþaðýdaki alaný doldurunuz.</p>
                        <asp:TextBox runat="server" ID="txtUniversityNames" Width="220"></asp:TextBox>
                    </div>
                </td>
            </tr>
            <tr>
                <td align="right" valign="top">
                    <p>
                        <strong>Bölümünüzün adý</strong></p>
                </td>
                <td>
                    <asp:DropDownList runat="server" ID="ddlUniversityDepartments"></asp:DropDownList>
                    <br />
                    <asp:CustomValidator ID="CustomValidatorDepartment" runat="server" Display="Dynamic" 
                    ClientValidationFunction="cvDepartmentControl" ValidationGroup="vgForm" 
                    ErrorMessage="Lütfen Bölüm Giriniz" CssClass="Error">
                    </asp:CustomValidator>             
                    <div id="dvOtherDepartment" style="display: none;">
                        <p class="mute">
                            Aþaðýdaki alaný doldurunuz.</p>
                        <asp:TextBox runat="server" ID="txtUniversityDepartments" Width="220"></asp:TextBox>
                    </div>
                </td>
            </tr>
            <tr>
                <td align="right" style="height: 24px">
                    <p>
                        <strong>Devam durumunuz</strong></p>
                </td>
                <td style="height: 24px">
                     <asp:DropDownList runat="server" ID="ddlEducationStates"></asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="ddlEducationStates"
                        CssClass="Error" ErrorMessage="Lütfen Devam Durumunuzu Giriniz" SetFocusOnError="True"
                        ValidationGroup="vgForm" InitialValue="0"></asp:RequiredFieldValidator></td>
            </tr>              
            <tr>
                <td align="right" style="height: 24px">
                    <p>
                        <strong>Baþlangýç tarihi</strong></p>
                </td>
                <td style="height: 24px">
                    <uc1:uDate ID="UDateStart" runat="server" />
                </td>
            </tr>          
            <tr id="trDate">
                <td align="right">
                    <p>
                        <strong>Bitiþ tarihi</strong></p>
                </td>
                <td>
                    <uc1:uDate ID="UDateEnd" runat="server" />
                </td>
            </tr>
            <tr id="trDegree">
                <td align="right" style="height: 26px">
                    <p>
                        <strong>Bitirme baþarýnýz</strong></p>
                </td>
                <td style="height: 26px">
                    <asp:TextBox runat="server" ID="txtDegree"></asp:TextBox>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Lütfen Sayý Giriniz"
                    ControlToValidate="txtDegree" MaximumValue="100" MinimumValue="0" SetFocusOnError="True" Type="Double" CssClass="Error" Display="Dynamic"></asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td align="right" style="height: 24px">
                    <p>
                        <strong>Ülke</strong></p>
                </td>
                <td style="height: 24px">
                    <asp:DropDownList runat="server" ID="ddlCountries"></asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="ddlCountries"
                        CssClass="Error" ErrorMessage="Lütfen Ülkeyi Seçiniz" SetFocusOnError="True"
                        ValidationGroup="vgForm" InitialValue="-1"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td align="right" style="vertical-align: top;">
                    <p>
                        <strong>Ýl</strong></p>
                </td>
                <td>
                    <asp:DropDownList runat="server" ID="ddlCities"></asp:DropDownList>
                    
                    <asp:CustomValidator ID="CustomValidatorCity" runat="server" Display="Dynamic" 
                    ClientValidationFunction="cvCityControl" ValidationGroup="vgForm" 
                    ErrorMessage="Lütfen Þehir Giriniz" CssClass="Error">
                    </asp:CustomValidator> 
                    <div id="dvOtherCity" style="display: none;">
                        <p class="mute">
                            Aþaðýdaki alaný doldurunuz.</p>
                        <asp:TextBox runat="server" ID="txtOtherCity" Width="220"></asp:TextBox>   
                    </div>                 
                </td>
            </tr>           
            <tr>
                <td align="right">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right" style="height: 29px">
                    &nbsp;</td>
                <td style="height: 29px">
                    <asp:ImageButton runat="server" ID="ImgBtnSave" ImageUrl="~/Images/buttons/save.png" OnClick="ImgBtnSave_Click" ValidationGroup="vgForm" />
                </td>
            </tr>
        </table>
    </div>
</div>

<div id="dvScript" runat="server"></div>

<script>
    OpenCloseCity();
    OpenCloseSchool();
    OpenCloseDepartment();
</script>