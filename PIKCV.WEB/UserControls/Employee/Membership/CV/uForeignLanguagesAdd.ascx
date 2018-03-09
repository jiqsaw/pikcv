<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uForeignLanguagesAdd.ascx.cs" Inherits="UserControls_Employee_Membership_CV_uForeignLanguagesAdd" %>
<%@ Register Src="~/UserControls/Common/ModalPopup/ModalPopup.ascx" TagName="ModalPopup"
    TagPrefix="uc1" %>

<uc1:ModalPopup ID="ShowModal" runat="server" Visible="false" />


<script type="text/javascript">

function ModalOK() 
{
    self.close();
    window.opener.location.reload();
}


function cvCustomValidatorLng(source, args) 
{   
    args.IsValid = false;
    
    var ddlFrgExamID = '<%=ddlForeignLanguageExams.ClientID %>';
    var txtPoint = '<%=txtExamDegree.ClientID %>';
    
    if (($get(ddlFrgExamID).options[$get(ddlFrgExamID).selectedIndex].value == 0) || ($get(txtPoint).value.length>0)) {
        args.IsValid = true;
    }
}
    
</script>

<div class="BoxPadder">
    <table width="100%" class="FormTable" style="text-align: left;">
          <tr>
            <td width="30%">&nbsp;</td>
            <td width="70%"><h1>Yabancý dil bilgisi</h1></td>
          </tr>
          <tr>
            <td align="right"><p><strong>Yabancý dil</strong></p></td>
            <td>
                <asp:DropDownList runat="server" ID="ddlForeignLanguages"></asp:DropDownList>                
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="ddlForeignLanguages"
                    CssClass="Error" ErrorMessage="Lütfen Yabancý Dili Seçiniz" InitialValue="-1"
                    SetFocusOnError="True" ValidationGroup="vgForm"></asp:RequiredFieldValidator></td>
          </tr>
          <tr>
            <td align="right" valign="top"><p><strong>Okuma</strong></p></td>
            <td>
                <asp:DropDownList runat="server" ID="ddlRead"></asp:DropDownList>
            </td>
          </tr>
          <tr>
            <td align="right"><p><strong>Yazma</strong></p></td>
            <td><asp:DropDownList runat="server" ID="ddlWrite"></asp:DropDownList></td>
          </tr>
          <tr>
            <td align="right"><p><strong>Konuþma</strong></p></td>
            <td><asp:DropDownList runat="server" ID="ddlSpeak"></asp:DropDownList></td>
          </tr>
          <tr>
            <td align="right"><p><strong>Öðrendiðiniz yer</strong></p></td>
            <td>
                <asp:TextBox runat="server" ID="txtPlaceLearned" MaxLength="32"></asp:TextBox>
            </td>
          </tr>
          <tr>
            <td align="right"><p><strong>Girilen Sýnav</strong></p></td>
            <td>
                <asp:DropDownList runat="server" ID="ddlForeignLanguageExams"></asp:DropDownList>
            </td>
          </tr>
          <tr id="trExamDegree">
            <td align="right"><p><strong>Sýnav Puaný</strong></p></td>
            <td>
                <asp:TextBox runat="server" ID="txtExamDegree" MaxLength="4"></asp:TextBox>
                
                <asp:CustomValidator ID="CustomValidatorLng" runat="server" Display="Dynamic" 
                ClientValidationFunction="cvCustomValidatorLng" ValidationGroup="vgForm" 
                ErrorMessage="Lütfen Sýnav Puanýnýzý Giriniz" CssClass="Error">
                </asp:CustomValidator>      
                                    
                <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtExamDegree"
                    Display="Dynamic" ErrorMessage="Lütfen Rakam Giriniz" MaximumValue="1000" MinimumValue="0"
                    SetFocusOnError="True" Type="Double" CssClass="Error" ValidationGroup="vgForm"></asp:RangeValidator></td>
          </tr>          
          <tr>
            <td align="right">&nbsp;</td>
            <td>&nbsp;</td>
          </tr>
          <tr>
            <td align="right">&nbsp;</td>
            <td> <asp:ImageButton runat="server" ID="ImgBtnSave" ImageUrl="~/Images/buttons/save.png" OnClick="ImgBtnSave_Click" ValidationGroup="vgForm" /> </td>
          </tr>
        </table>
</div>