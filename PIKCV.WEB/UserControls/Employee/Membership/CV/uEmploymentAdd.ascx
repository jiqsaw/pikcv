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
            <td width="70%"><h1>�� Deneyimi</h1></td>
          </tr>
          <tr>
            <td align="right"><p><strong>��yeri ad�</strong></p></td>
            <td>
                <asp:TextBox runat="server" ID="txtCompanyName"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtCompanyName"
                    CssClass="Error" ErrorMessage="L�tfen ��yeri Ad�n� Giriniz" SetFocusOnError="True"
                    ValidationGroup="vgForm"></asp:RequiredFieldValidator></td>
          </tr>
          <tr>
            <td align="right" style="height: 24px"><p><strong>Sekt�r</strong></p></td>
            <td style="height: 24px">
                <asp:DropDownList runat="server" ID="ddlSectors"></asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="ddlSectors"
                    CssClass="Error" ErrorMessage="L�tfen Sekt�r Se�iniz" SetFocusOnError="True"
                    ValidationGroup="vgForm" InitialValue="-1"></asp:RequiredFieldValidator></td>
          </tr>
          <tr>
            <td align="right"><p><strong>Pozisyon</strong></p></td>
            <td>
                <asp:DropDownList runat="server" ID="ddlPositions" Width="200"></asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="ddlPositions"
                    CssClass="Error" ErrorMessage="L�tfen Pozisyon Se�iniz" SetFocusOnError="True"
                    ValidationGroup="vgForm" InitialValue="0"></asp:RequiredFieldValidator></td>
          </tr>
          <tr>
            <td align="right" style="height: 40px"><p><strong>K�sa �� Tan�m�</strong></p></td>
            <td style="height: 40px">
                <asp:TextBox runat="server" ID="txtJobDefinition" TextMode="MultiLine"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtJobDefinition"
                    CssClass="Error" ErrorMessage="L�tfen K�sa �� Tan�m�n� Giriniz" SetFocusOnError="True"
                    ValidationGroup="vgForm"></asp:RequiredFieldValidator></td>
          </tr>
          <tr>
            <td align="right" style="height: 24px"><p><strong>�al��ma �ekli</strong></p></td>
            <td style="height: 24px">
                <asp:DropDownList runat="server" ID="ddlLabouringTypes"></asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="ddlLabouringTypes"
                    CssClass="Error" ErrorMessage="L�tfen �al��ma �eklini Giriniz" SetFocusOnError="True"
                    ValidationGroup="vgForm" InitialValue="0"></asp:RequiredFieldValidator></td>
          </tr>          
          <tr>
            <td align="right"><p><strong>�al��t���n�z �lke</strong></p></td>
            <td>
                <asp:DropDownList runat="server" ID="ddlCountries"></asp:DropDownList> 
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="ddlCountries"
                    CssClass="Error" ErrorMessage="L�tfen �lke Se�iniz" InitialValue="-1" SetFocusOnError="True"
                    ValidationGroup="vgForm"></asp:RequiredFieldValidator><br />
            </td>
          </tr>
          <tr>
            <td align="right" style="height: 24px"><p><strong>�al��t���n�z �ehir</strong></p></td>
            <td style="height: 24px">
                <asp:DropDownList runat="server" ID="ddlCities"></asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="ddlCities"
                    CssClass="Error" ErrorMessage="L�tfen �ehir Se�iniz" InitialValue="-1" SetFocusOnError="True"
                    ValidationGroup="vgForm"></asp:RequiredFieldValidator>
                    
                <div id="dvOther" style="display: none;">
                    <p class="mute">
                        A�a��daki alan� doldurunuz.</p>
                    <asp:TextBox runat="server" ID="txtOtherCityName" MaxLength="64" Width="175"></asp:TextBox>
                </div>
                    
            </td>
          </tr>          
            <tr>
                <td align="right">
                    <p>
                        <strong>��e Ba�lama tarihi</strong></p>
                </td>
                <td>
                    <uc1:uDate ID="UDateStart" runat="server" />
                </td>
            </tr>
            <tr>
                <td align="right"> <p><strong>�al��ma durumunuz</strong></p> </td>
                <td> 
                    <asp:RadioButton ID="rdIsWorkingYES" runat="server" GroupName="rdIsWorking" Text="Devam ediyor" />
                    <asp:RadioButton Checked="true" ID="rdIsWorkingNO" runat="server" GroupName="rdIsWorking" Text="Ayr�ld�" />
                </td>
            </tr>            
            <tr id="trDate">
                <td align="right">
                    <p>
                        <strong>��ten Ayr�lma tarihi</strong></p>
                </td>
                <td>
                    <uc1:uDate ID="UDateEnd" runat="server" />
                </td>
            </tr>
          <tr id="trReason">
            <td align="right"><p><strong>��ten Ayr�lma Nedeniniz</strong></p></td>
            <td>
                <asp:TextBox runat="server" ID="txtReasonOfResignation" TextMode="MultiLine"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtReasonOfResignation"
                    CssClass="Error" ErrorMessage="L�tfen ��ten Ayr�lma Nedenini Giriiniz" SetFocusOnError="True"
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
                <asp:RadioButton runat="server" GroupName="rdGroupCanReference" ID="rdCanReferenceYES" Text="Al�nabilir" Checked="true" />
                <asp:RadioButton runat="server" GroupName="rdGroupCanReference" ID="rdCanReferenceNO" Text="Al�namaz" />
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

