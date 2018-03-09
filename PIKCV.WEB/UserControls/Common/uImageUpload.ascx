<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uImageUpload.ascx.cs"
    Inherits="UserControls_Common_uImageUpload" %>
<table>
    <tr>
        <td>
            <asp:FileUpload ID="fupImg" runat="server" Width="220" /><br />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Lütfen Bir Resim Giriniz"
                ValidationExpression="^(([a-zA-Z]:)|(\\{2}\w+)\$?)(\\(\w[\w].*))(.jpg|.JPG|.jpeg|.JPEG|.gif|.GIF|.bmp|.BMP)$"
                ControlToValidate="fupImg" Display="Dynamic" SetFocusOnError="True"></asp:RegularExpressionValidator></td>
    </tr>
    <tr>
        <td>
            <asp:ImageButton ID="btnSubmit" runat="server" ImageUrl="~/Images/buttons/upload.png"
                Width="109" Height="27" border="0" OnClick="btnSubmit_Click" />
        </td>
    </tr>
</table>
