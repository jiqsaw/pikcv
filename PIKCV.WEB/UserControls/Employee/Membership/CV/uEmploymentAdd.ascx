<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uEmploymentAdd.ascx.cs" Inherits="UserControls_Employee_Membership_CV_uEmploymentAdd" %>
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

</script>


<script type="text/javascript">
    function ShowDateChRd(ElementID) {
        if (!document.getElementById(ElementID).checked) { 
            trDate.style.display='block'; 
            trReason.style.display='block';
        } 
        else {
            trDate.style.display='none'; 
            trReason.style.display='none'; 
            SetMinDate();
        }
    }
</script>

<div class="contentPad">
      <div class="BoxPadder">
        <table width="100%" class="FormTable" style="text-align: left;">
          <tr>
            <td width="30%">&nbsp;</td>
            <td width="70%"><h1>Ýþ Deneyimi</h1></td>
          </tr>
          <tr>
            <td align="right"><p><strong>Ýþyeri adý</strong></p></td>
            <td>
                <asp:TextBox runat="server" ID="txtCompanyName"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtCompanyName"
                    CssClass="Error" ErrorMessage="Lütfen Ýþyeri Adýný Giriniz" SetFocusOnError="True"
                    ValidationGroup="vgForm"></asp:RequiredFieldValidator></td>
          </tr>
          <tr>
            <td align="right" style="height: 24px"><p><strong>Sektör</strong></p></td>
            <td style="height: 24px">
                <asp:DropDownList runat="server" ID="ddlSectors"></asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="ddlSectors"
                    CssClass="Error" ErrorMessage="Lütfen Sektör Seçiniz" SetFocusOnError="True"
                    ValidationGroup="vgForm" InitialValue="-1"></asp:RequiredFieldValidator></td>
          </tr>
          <tr>
            <td align="right"><p><strong>Pozisyon</strong></p></td>
            <td>
                <asp:DropDownList runat="server" ID="ddlPositions" Width="200"></asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="ddlPositions"
                    CssClass="Error" ErrorMessage="Lütfen Pozisyon Seçiniz" SetFocusOnError="True"
                    ValidationGroup="vgForm" InitialValue="0"></asp:RequiredFieldValidator></td>
          </tr>
          <tr>
            <td align="right" style="height: 40px"><p><strong>Kýsa Ýþ Tanýmý</strong></p></td>
            <td style="height: 40px">
                <asp:TextBox runat="server" ID="txtJobDefinition" TextMode="MultiLine"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtJobDefinition"
                    CssClass="Error" ErrorMessage="Lütfen Kýsa Ýþ Tanýmýný Giriniz" SetFocusOnError="True"
                    ValidationGroup="vgForm"></asp:RequiredFieldValidator></td>
          </tr>
          <tr>
            <td align="right" style="height: 24px"><p><strong>Çalýþma Þekli</strong></p></td>
            <td style="height: 24px">
                <asp:DropDownList runat="server" ID="ddlLabouringTypes"></asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="ddlLabouringTypes"
                    CssClass="Error" ErrorMessage="Lütfen Çalýþma Þeklini Giriniz" SetFocusOnError="True"
                    ValidationGroup="vgForm" InitialValue="0"></asp:RequiredFieldValidator></td>
          </tr>          
          <tr>
            <td align="right"><p><strong>Çalýþtýðýnýz ülke</strong></p></td>
            <td>
                <asp:DropDownList runat="server" ID="ddlCountries"></asp:DropDownList> 
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="ddlCountries"
                    CssClass="Error" ErrorMessage="Lütfen Ülke Seçiniz" InitialValue="-1" SetFocusOnError="True"
                    ValidationGroup="vgForm"></asp:RequiredFieldValidator><br />
            </td>
          </tr>
          <tr>
            <td align="right" style="height: 24px"><p><strong>Çalýþtýðýnýz þehir</strong></p></td>
            <td style="height: 24px">
                <asp:DropDownList runat="server" ID="ddlCities"></asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="ddlCities"
                    CssClass="Error" ErrorMessage="Lütfen Þehir Seçiniz" InitialValue="-1" SetFocusOnError="True"
                    ValidationGroup="vgForm"></asp:RequiredFieldValidator>
                    
                <div id="dvOther" style="display: none;">
                    <p class="mute">
                        Aþaðýdaki alaný doldurunuz.</p>
                    <asp:TextBox runat="server" ID="txtOtherCityName" MaxLength="64" Width="175"></asp:TextBox>
                </div>
                    
            </td>
          </tr>          
            <tr>
                <td align="right">
                    <p>
                        <strong>Ýþe Baþlama tarihi</strong></p>
                </td>
                <td>
                    <uc1:uDate ID="UDateStart" runat="server" />
                </td>
            </tr>
            <tr>
                <td align="right"> <p><strong>Çalýþma durumunuz</strong></p> </td>
                <td> 
                    <asp:RadioButton ID="rdIsWorkingYES" runat="server" GroupName="rdIsWorking" Text="Devam ediyor" />
                    <asp:RadioButton Checked="true" ID="rdIsWorkingNO" runat="server" GroupName="rdIsWorking" Text="Ayrýldý" />
                </td>
            </tr>            
            <tr id="trDate">
                <td align="right">
                    <p>
                        <strong>Ýþten Ayrýlma tarihi</strong></p>
                </td>
                <td>
                    <uc1:uDate ID="UDateEnd" runat="server" />
                </td>
            </tr>
          <tr id="trReason">
            <td align="right"><p><strong>Ýþten Ayrýlma Nedeniniz</strong></p></td>
            <td>
                <asp:TextBox runat="server" ID="txtReasonOfResignation" TextMode="MultiLine"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtReasonOfResignation"
                    CssClass="Error" ErrorMessage="Lütfen Ýþten Ayrýlma Nedenini Giriiniz" SetFocusOnError="True"
                    ValidationGroup="vgForm"></asp:RequiredFieldValidator></td>
          </tr>   
          <tr>
            <td align="right"><p><strong>Firma Telefonu</strong></p></td>
            <td>
                <asp:TextBox runat="server" ID="txtCompanyPhone"></asp:TextBox>
            </td>
          </tr>          

          <tr>
            <td align="right"><p><strong>Referans Durmu</strong></p></td>
            <td>
                <asp:RadioButton runat="server" GroupName="rdGroupCanReference" ID="rdCanReferenceYES" Text="Alýnabilir" Checked="true" />
                <asp:RadioButton runat="server" GroupName="rdGroupCanReference" ID="rdCanReferenceNO" Text="Alýnamaz" />
            </td>
          </tr>  

          <tr>
            <td align="right">&nbsp;</td>
            <td>&nbsp;</td>
          </tr>
          <tr>
            <td align="right">&nbsp;</td>
            <td>
                <asp:ImageButton runat="server" ID="ImgBtnSave" ImageUrl="~/Images/buttons/save.png" OnClick="ImgBtnSave_Click" ValidationGroup="vgForm" />
            </td>
          </tr>
        </table>
      </div>
    </div>
    
<script type="text/javascript">

function ShowHideOtherCity() {
    var ddl = '<%=ddlCities.ClientID%>';
    var Value = '<%=((int)PIKCV.COM.EnumDB.Places.OtherPlaceID).ToString() %>';
    if (ddlSelectedValue(ddl)==Value) { $get('dvOther').style.display='block'; } 
    else { $get('dvOther').style.display='none'; }
}
ShowHideOtherCity();

</script>
    
<div id="dvScript" runat="server"></div>

