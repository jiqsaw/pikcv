<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uPersonalInfo.ascx.cs" Inherits="UserControls_Employee_Membership_CV_uPersonalInfo" %>
<%@ Register Src="../../../Common/ModalPopup/ModalPopup.ascx" TagName="ModalPopup"
    TagPrefix="uc1" %>
<%@ Register src="~/UserControls/Common/uDate.ascx" TagName="uDate" tagprefix="uc2" %>

 <script type="text/javascript"> 
function cvMilitary(source, args) 
{   
    args.IsValid = false;
    if (document.getElementById('trMilitaryStates').style.display=='none') {
        args.IsValid = true;
    } else {
         var ddlMilitaryStatesID = '<%=ddlMilitaryStates.ClientID %>';
         if (document.getElementById(ddlMilitaryStatesID).value > 0) {
            args.IsValid = true;
         }
    }

}
</script>

<div class="ContentColA">
    <ul class="SubTabNav">
        <li class="selected"><a href="javascript:;">Kiþisel Bilgiler</a></li>
        <li> <asp:HyperLink runat="server" ID="hlContactInfo" Text="Ýletiþim Bilgileri"
            NavigateUrl="#Employee-Membership-CV&CVFocus=||FocusNo||"></asp:HyperLink> </li>
    </ul>
</div>

<div class="ContentColB">

    <table width="100%" class="FormTable">

            <tr>
              <td align="right"><p><strong>Uyruðunuz</strong></p></td>
              <td>
                <asp:DropDownList runat="server" ID="ddlNation"></asp:DropDownList>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="ddlNation"
                      CssClass="Error" ErrorMessage="Lütfen Uyruðunuzu Seçiniz" SetFocusOnError="True"
                      ValidationGroup="vgForm" InitialValue="-1"></asp:RequiredFieldValidator></td>
            </tr>                        
            <tr>
                <td width="25%" align="right"><p><strong>Doðum tarihiniz</strong></p></td>
                <td>
                    <uc2:uDate id="UDate1" runat="server"></uc2:uDate>
                </td>
            </tr>
            <tr>
              <td align="right"><p><strong>Doðum Yeriniz</strong></p></td>
              <td>
                <asp:DropDownList runat="server" ID="ddlBirthPlace"></asp:DropDownList>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="ddlBirthPlace"
                      CssClass="Error" ErrorMessage="Lütfen Doðum Yerinizi Seçiniz" InitialValue="-1"
                      SetFocusOnError="True" ValidationGroup="vgForm"></asp:RequiredFieldValidator>
                      
                    <div id="dvOther" style="display: none;">
                        <p class="mute">
                            Aþaðýdaki alaný doldurunuz.</p>
                        <asp:TextBox runat="server" ID="txtOtherBirthPlace" MaxLength="64" Width="175"></asp:TextBox>
                    </div>                      
                      
                </td>
            </tr>              
            <tr>
                <td align="right" valign="top"><p><strong>Cinsiyetiniz</strong></p></td>
                <td valign="top">
                <asp:RadioButtonList runat="server" ID="rdSexCode" RepeatDirection="Horizontal">
                    <asp:ListItem Text="Erkek" Selected="True" Value="0"></asp:ListItem>
                    <asp:ListItem Text="Kadýn" Value="1"></asp:ListItem>
                </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
              <td align="right" valign="top"><p><strong>Medeni haliniz</strong></p></td>
              <td valign="top">
                <asp:DropDownList runat="server" ID="ddlMaritalStates"></asp:DropDownList>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="ddlMaritalStates"
                      CssClass="Error" ErrorMessage="Lütfen Medeni Halinizi Seçiniz" SetFocusOnError="True"
                      ValidationGroup="vgForm" InitialValue="0"></asp:RequiredFieldValidator></td>
            </tr>
            <tr id="trMilitaryStates">
              <td valign="top" align="right"><p><strong>Askerlik durumunuz</strong></p></td>
                <td>                
                    <asp:DropDownList runat="server" ID="ddlMilitaryStates"></asp:DropDownList>
                    <asp:CustomValidator ID="CustomValidatorIdentity" runat="server" Display="static" 
                    ClientValidationFunction="cvMilitary" ValidationGroup="vgForm" 
                    ErrorMessage="Lütfen Askerlik Durumunuzu Seçiniz" CssClass="Error">
                    </asp:CustomValidator>
                </td>
            </tr>
            <tr id="trMilitaryYear" style="display: none;">
                <td align="right"><p><strong>Tecil Yýlý</strong></p></td>
                <td align="left"> <asp:DropDownList runat="server" ID="ddlMilitaryYear"></asp:DropDownList> </td>
            </tr>
            <tr>
                <td align="right" valign="top"><p><strong>Özel durum</strong></p></td>
                <td>
                    <asp:CheckBox runat="server" ID="chIsDisabled" Text="Engelliyim" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:CheckBox runat="server" ID="chIsOldConvicted" Text="Eski hükümlüyüm" /> <br /><br />
                    <asp:CheckBox runat="server" ID="chIsMartyrRelative" Text="Þehit yakýnýyým" />&nbsp;&nbsp;&nbsp;
                    <asp:CheckBox runat="server" ID="chIsTerrorWronged" Text="Terör Maðduruyum" />
                </td>
            </tr>
            <tr>
                <td align="right" valign="top"><p><strong>Varsa Kronik Hastalýðýnýz</strong></p></td>
                <td valign="top">
                    <asp:TextBox ID="txtChronicIllness" runat="server" Width="270" MaxLength="1024" TextMode="MultiLine"></asp:TextBox>
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

<script type="text/javascript">
function ShowSexCode() {
    document.getElementById('trMilitaryStates').style.display='block';
    document.getElementById('trMilitaryYear').style.display='block';
}

function HideSexCode() {
    document.getElementById('trMilitaryStates').style.display='none';
    document.getElementById('trMilitaryYear').style.display='none';
}

function ShowHideMilitaryYear() {
    var ddl = '<%=ddlMilitaryStates.ClientID %>';
    var Value = '<%=((int)PIKCV.COM.EnumDB.MilitaryStates.Postponement).ToString() %>'
    if (ddlSelectedValue(ddl)==Value) { trMilitaryYear.style.display='block'; } 
    else { trMilitaryYear.style.display='none'; }
}
function ShowHideOtherPlace() {
    var ddl = '<%=ddlBirthPlace.ClientID%>'
    if (ddlSelectedValue(ddl)==0) { $get('dvOther').style.display='block'; } 
    else { $get('dvOther').style.display='none'; }
}
ShowHideMilitaryYear();
ShowHideOtherPlace();
</script>

<div id="dvScript" runat="server"></div>

<uc1:ModalPopup ID="ShowModal" runat="server" Visible="false" />
