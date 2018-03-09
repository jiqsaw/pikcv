<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uSendMessage.ascx.cs" Inherits="UserControls_Company_Messages_uSendMessage" %>


<div class="contentPad">
      <div class="HeaderPR floatLeft">
        <h2 class="sIFRHeader">
            <asp:Literal runat="server" ID="ltlSendMessage" Text="Mesaj Gönderme" Visible="false"></asp:Literal>
            <asp:Literal runat="server" ID="ltlDraftMessage" Text="Kayýtlý Mesaj" Visible="false"></asp:Literal>
        </h2>
      </div>
        <div class="SectionCombo">
        <asp:DropDownList ID="ddlSystemDraftMessages" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlSystemDraftMessages_SelectedIndexChanged">
        </asp:DropDownList>
      </div>
      <div class="brclear"></div>
      <div class="BoxContentTop"></div>
      <div class="BoxContent">
        <div class="BoxPadder">
          <p class="infoMsg"><asp:Label ID="lbSystemDraftMessageInfo" Text="Örnek mesajlarý seçip deðiþtirmeden veya veya deðiþtirerek size özel mesajýnýzý oluþturabilirsiniz" runat="server"></asp:Label></p>
          <table width="100%" class="FormTable">
            <tr> </tr>
            <tr>
              <td align="right" valign="top" nowrap="nowrap">&nbsp;</td>
              <td>
                  <asp:Label ID="lbMessage" runat="server" Visible="false"></asp:Label>
              </td>
            </tr>
            <tr id="trTo" runat="server">
              <td align="right" valign="top" nowrap="nowrap"><strong>Gönderilen:</strong></td>
              <td>
                    <asp:Label ID="lbUserNames" runat="server"></asp:Label>
              </td>
            </tr>
            <tr id="trDrafts" runat="server">
                <td width="100" align="right" valign="top" nowrap="nowrap"><strong>Taslaklar:</strong></td>
                <td>
                  <asp:DropDownList AutoPostBack="true" runat="server" ID="ddlMessageDrafts" OnSelectedIndexChanged="ddlMessageDrafts_SelectedIndexChanged"></asp:DropDownList>
                </td>
            </tr>
            <tr runat="server" id="trMessageName" visible="false">

              <td width="100" align="right" valign="top" nowrap="nowrap"><strong>Mesaj Ýsmi:</strong></td>
              <td>
                  <asp:TextBox ID="txtMessageName" runat="server" Width="350" MaxLength="255"></asp:TextBox>
                  <asp:Literal ID="ltlMessageName" runat="server"></asp:Literal>
                  <asp:RequiredFieldValidator ID="errMessageName" runat="server" ControlToValidate="txtMessageName" ErrorMessage="Lütfen Bir Mesaj Ýsmi Giriniz" Display="Dynamic" ValidationGroup="vgMessage"></asp:RequiredFieldValidator></td>
            </tr>          
            <tr>

              <td width="100" align="right" valign="top" nowrap="nowrap"><strong>Konu:</strong></td>
              <td>
                  <asp:TextBox ID="txtMessageTitle" runat="server" Width="350" MaxLength="255"></asp:TextBox>
                  <asp:Literal ID="ltlMessageTitle" runat="server"></asp:Literal>
                  <asp:RequiredFieldValidator ID="errMessageSubject" runat="server" ControlToValidate="txtMessageTitle" ErrorMessage="Lütfen Bir Mesaj Konusu Giriniz" Display="Dynamic" ValidationGroup="vgMessage"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
              <td align="right" valign="top" nowrap="nowrap"><strong>Mesaj:</strong></td>
              <td>
                 <asp:TextBox ID="txtMessage" runat="server" Width="500" TextMode="MultiLine" Rows="8"></asp:TextBox>
                 <asp:Literal ID="ltlMessage" runat="server"></asp:Literal>
                 <asp:RequiredFieldValidator ID="errMessage" runat="server" ControlToValidate="txtMessage" ErrorMessage="Lütfen Bir Mesaj Giriniz" Display="Dynamic" ValidationGroup="vgMessage"></asp:RequiredFieldValidator></td>
            </tr>
            <tr id="trChDraft" runat="server" visible="false">
                <td align="right" valign="top" nowrap="nowrap">
                    <asp:CheckBox runat="server" ID="chDraft" />
                </td>
                <td>
                    Taslak olarak kaydet
                </td>
            </tr>            
            <tr>
              <td>&nbsp;</td>
              <td>&nbsp;</td>

            </tr>
            <tr>
              <td>&nbsp;</td>
              <td>
                   <asp:ImageButton ID="imgSend" runat="server" ImageUrl="~/images/buttons/gonder.png" OnClick="imgSend_Click" ValidationGroup="vgMessage"/>
                   <asp:ImageButton ID="imgSave" runat="server" ImageUrl="~/images/buttons/save.png" OnClick="imgSave_Click" ValidationGroup="vgMessage"/>
              </td>
            </tr>
            <tr>
              <td>&nbsp;</td>
              <td>&nbsp;</td>
            </tr>

          </table>
          <div class="brclear"></div>
        </div>
      </div>
      <div class="BoxContentBottom"></div>
    </div>