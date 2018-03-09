<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uContactInfo.ascx.cs" Inherits="UserControls_Employee_Membership_CV_uContactInfo" %>
<%@ Register Src="~/UserControls/Common/ModalPopup/ModalPopup.ascx" TagName="ModalPopup"
    TagPrefix="uc1" %>
    

<uc1:ModalPopup ID="ShowModal" runat="server" Visible="false" />

<div class="ContentColA">
    <ul class="SubTabNav">
        <li> <asp:HyperLink runat="server" ID="hlPersonalInfo" Text="Kiþisel Bilgiler"
            NavigateUrl="#Employee-Membership-CV&CVFocus=||FocusNo||"></asp:HyperLink> </li>
        <li class="selected"><a href="javascript:;">Ýletiþim Bilgileri</a></li>
    </ul>
</div>

<div class="ContentColB">
<table width="100%" class="FormTable">

    <tr>
      <td align="right" style="width: 25%;"> <p><strong>Yaþadýðýnýz Ülke</strong></p> </td>
      <td style="width: 75%;"> <asp:DropDownList runat="server" ID="ddlHomeCountry"></asp:DropDownList> 
          <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="ddlHomeCountry"
              CssClass="Error" ErrorMessage="Lütfen Yaþadýðýnýz Ülkeyi Seçiniz" SetFocusOnError="True"
              ValidationGroup="vgForm" InitialValue="-1"></asp:RequiredFieldValidator></td>
    </tr>
    <tr>
        <td align="right" valign="top" style="height: 24px"><p><strong>Yaþadýðýnýz Þehir</strong></p></td>
        <td valign="top" style="height: 24px"> 
            <asp:DropDownList runat="server" ID="ddlHomeCity">
                
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="ddlHomeCity"
                CssClass="Error" ErrorMessage="Lütfen Yaþadýðýnýz Þehri Seçiniz" InitialValue="-1"
                SetFocusOnError="True" ValidationGroup="vgForm"></asp:RequiredFieldValidator><%--<asp:TextBox Visible="false" ID="txtHomeCity" runat="server" MaxLength="128"></asp:TextBox> --%>
                
              
            <div id="dvOther" style="display: none;">
                <p class="mute">
                    Aþaðýdaki alaný doldurunuz.</p>
                <asp:TextBox runat="server" ID="txtOtherHomeCity" MaxLength="64" Width="175"></asp:TextBox>
            </div>                
                
        </td>
                
    </tr>
    <tr>
        <td align="right" valign="top"><p><strong>Adresiniz</strong></p></td>
        <td valign="top"> <asp:TextBox ID="txtAddress" TextMode="multiLine" Width="170" Height="40" runat="server" MaxLength="255"></asp:TextBox> 
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtAddress"
                CssClass="Error" ErrorMessage="Lütfen Adresinizi Giriniz" SetFocusOnError="True"
                ValidationGroup="vgForm"></asp:RequiredFieldValidator></td>
    </tr>

    <tr>
        <td align="right" valign="top"><p><strong>Ev Telefonunuz</strong></p></td>
        <td valign="top"> <asp:TextBox ID="txtHomePhone" runat="server" MaxLength="18"></asp:TextBox> 
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtHomePhone"
                CssClass="Error" ErrorMessage="Lütfen Ev Telefonunuzu Giriniz" SetFocusOnError="True"
                ValidationGroup="vgForm"></asp:RequiredFieldValidator></td>
    </tr>

    <tr>
        <td align="right" valign="top"><p><strong>Ýþ Telefonunuz</strong></p></td>
        <td valign="top"> <asp:TextBox ID="txtBusinessPhone" runat="server" MaxLength="18"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtBusinessPhone"
                CssClass="Error" ErrorMessage="Lütfen Ýþ Telefonunuzu Giriniz" SetFocusOnError="True"
                ValidationGroup="vgForm"></asp:RequiredFieldValidator></td>
    </tr>

    <tr>
        <td align="right" valign="top"><p><strong>Cep Telefonunuz</strong></p></td>
        <td valign="top"> <asp:TextBox ID="txtGSM" runat="server" MaxLength="17"></asp:TextBox> 
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtGSM"
                CssClass="Error" ErrorMessage="Lütfen Cep Telefonunuzu Giriniz" SetFocusOnError="True"
                ValidationGroup="vgForm"></asp:RequiredFieldValidator></td>
    </tr>

    <tr>
        <td align="right" valign="top"><p><strong>Cep Telefonunuz <br /> (diðer)</strong></p></td>
        <td valign="top"> <asp:TextBox ID="txtGSM2" runat="server" MaxLength="17"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtGSM2"
                CssClass="Error" ErrorMessage="Lütfen Diðer Cep Telefonunuzu Giriniz" SetFocusOnError="True"
                ValidationGroup="vgForm"></asp:RequiredFieldValidator></td>
    </tr>
    
    <tr>
        <td align="right" valign="top"><p><strong>Alternatif E-posta Adresiniz</strong></p></td>
        <td valign="top"> <asp:TextBox ID="txtContactEmail" runat="server" MaxLength="128"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtContactEmail"
                CssClass="Error" ErrorMessage="Doðru E-Posta Giriniz" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                ValidationGroup="vgForm"></asp:RegularExpressionValidator></td>
    </tr>
    
    <tr>
        <td align="right" valign="top"><p><strong>Size ulaþýlamadýðýnda temasa geçilecek <br /> kiþinin ismi </strong></p></td>
        <td valign="top"> <asp:TextBox ID="txtAlternateContactName" runat="server" MaxLength="128"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtAlternateContactName"
                CssClass="Error" ErrorMessage="Lütfen Temasa Geçilecek Kiþinin Ýsmini Giriniz" SetFocusOnError="True"
                ValidationGroup="vgForm"></asp:RequiredFieldValidator></td>
    </tr>
    
    <tr>
        <td align="right" valign="top"><p><strong>Size ulaþýlamadýðýnda Temasa geçilecek <br /> kiþinin telefonu </strong></p></td>
        <td valign="top"> <asp:TextBox ID="txtAlternateContactPhone" runat="server" MaxLength="18"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtAlternateContactPhone"
                CssClass="Error" ErrorMessage="Lütfen Temasa Geçilecek Kiþinin Telefonunu Giriniz" SetFocusOnError="True"
                ValidationGroup="vgForm"></asp:RequiredFieldValidator></td>
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

function ShowHideOtherHomeCity() {
    var ddl = '<%=ddlHomeCity.ClientID%>';
    var Value = '<%=((int)PIKCV.COM.EnumDB.Places.OtherPlaceID).ToString() %>';
    if (ddlSelectedValue(ddl)==Value) { $get('dvOther').style.display='block'; } 
    else { $get('dvOther').style.display='none'; }
}
ShowHideOtherHomeCity();

</script>

<div id="dvScript" runat="server"></div>