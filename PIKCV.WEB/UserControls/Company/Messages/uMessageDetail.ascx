<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uMessageDetail.ascx.cs" Inherits="UserControls_Company_Messages_uMessageDetail" %>

    <div class="contentPad">
      <div class="HeaderPR floatLeft">
        <h2 class="sIFRHeader" style="width:200px;">Mesaj Detayı</h2>
      </div>
      <div class="brclear"></div>
      <!-- start roundcornered box -->
      <div class="BoxContentTop"></div>
      <div class="BoxContent">
        <div class="BoxPadder">
          <table width="100%" class="GenericTable">
            <tr>
              <td style="width: 20%;" align="right" valign="top" nowrap="nowrap"><p><strong>Tarih:</strong></p></td>
              <td style="width: 80%;"><a href="javascript:;"></a>
                <p><asp:Label ID="lbMessageDate" runat="server"></asp:Label>
                    &nbsp;</p></td> 
            </tr>
            <tr>
              <td align="right" valign="top" nowrap="nowrap"><p><strong>Kimden:</strong></p></td>
              <td><p><asp:Label ID="lbMessageFrom" runat="server"></asp:Label></p></td>
            </tr>
            <tr> </tr>
            <tr>
              <td align="right" valign="top" nowrap="nowrap"><p><strong>Konu:</strong></p></td>
              <td><p><asp:Label ID="lbMessageTitle" runat="server"></asp:Label></p></td>
            </tr>
            <tr>
              <td align="right" valign="top" nowrap="nowrap"><p><strong>Mesaj:</strong></p></td>
              <td><p><asp:Label ID="lbMessageBody" runat="server"></asp:Label></p></td>
            </tr>
            <tr>
              <td>&nbsp;</td>
              <td><ul class="FamLinks">
                  <li style="display: none;" class="SendMessage"><a href="/pikcv/2_3_7_2_mesaj_yaz.htm">Cevap Yaz</a></li>
                  <li class="GoBack"><a href="#Company-Messages-Messages">Mesaj Listesine Geri Dön</a></li>
                  <li class="Print"><a href="javascript:window.print();">Yazdır</a></li>
                </ul></td>
            </tr>
          </table>
          <div class="brclear"></div>
        </div>
      </div>
      <div class="BoxContentBottom"></div>
      <!-- finish roundcornered box -->
    </div>