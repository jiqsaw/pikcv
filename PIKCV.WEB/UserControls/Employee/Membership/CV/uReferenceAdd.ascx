<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uReferenceAdd.ascx.cs" Inherits="UserControls_Employee_Membership_CV_uReferenceAdd" %>
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

<div class="contentPad">
    <div class="BoxPadder">
        <table width="100%" class="FormTable" style="text-align: left;">
          <tr>
            <td width="30%">&nbsp;</td>
            <td width="70%"><h1>Referanslar</h1></td>
          </tr>
          <tr>
            <td align="right"><p><strong>Referans Adý Soyadý</strong></p></td>
            <td>
                <asp:TextBox runat="server" ID="txtReferenceName" MaxLength="512"></asp:TextBox></td>
          </tr>
          <tr>
            <td align="right"><p><strong>Çalýþtýðý Firma</strong></p></td>
            <td>    
                <asp:TextBox runat="server" ID="txtCompany" MaxLength="512"></asp:TextBox></td>
          </tr>
          <tr>
            <td align="right"><p><strong>Pozisyonu</strong></p></td>
            <td>
                <asp:TextBox runat="server" ID="txtPosition" MaxLength="512"></asp:TextBox></td>
          </tr>
          <tr>
            <td align="right"><p><strong>Telefonu</strong></p></td>
            <td>
                <asp:TextBox runat="server" ID="txtPhone" MaxLength="18"></asp:TextBox></td>
          </tr>           
          <tr>
            <td align="right">&nbsp;</td>
            <td>&nbsp;</td>
          </tr>
          <tr>
            <td align="right">&nbsp;</td>
            <td>
                <asp:ImageButton runat="server" ID="ImgBtnSave" ImageUrl="~/Images/buttons/save.png" OnClick="ImgBtnSave_Click" />
            </td>
          </tr>
        </table>
      </div>
</div>          