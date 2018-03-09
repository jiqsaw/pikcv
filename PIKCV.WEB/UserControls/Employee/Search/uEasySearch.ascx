<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uEasySearch.ascx.cs" Inherits="UserControls_Employee_Search_uEasySearch" %>

<div class="contentPad">
      <div class="HeaderPR floatLeft">
        <h2 class="sIFRHeader" style="width:200px;">�lan Arama</h2>
      </div>
      <div id="Tab">
        <ul>
          <li class="TabActive"><a href="javascript:void(0);"><span>Kolay arama</span></a></li>
          <li><a href="#Employee-Search-DetailSearch"><span>Detayl� arama</span></a></li>
          <li><a href="#Employee-Search-Filters"><span>Arama Fitreleriniz</span></a></li>
        </ul>
      </div>
      <div class="brclear"></div>
      <!-- start roundcornered box -->
      <div class="BoxContentTop"></div>
      <div class="BoxContent">
        <div class="BoxPadder">
          <table class="FormTable">
            <tr>
              <td align="right"><p><strong>Kelime:<br />
                  </strong></p></td>
              <td><input name='keyword' type='text' id='keyword' style="width:220px;" class="cssInput"/></td>
              <td>&nbsp;</td>
              <td>&nbsp;</td>
            </tr>
            <tr>
              <td align="right">&nbsp;</td>
                <td colspan="3">
                    <div class="infoMsg">
                        <p>Birden fazla se�enek i�aretlemek i�in Ctrl tu�unu bas�l� tutarak t�klay�n.<br />
                        Her listeden en fazla 5 kriter se�ebilirsiniz.</p>
                    </div>
                </td>
            </tr>
            <tr>
              <td align="right" valign="top"><p><strong>Pozisyon</strong></p></td>
              <td> <asp:ListBox runat="server" ID="lbPositions" SelectionMode="Multiple"></asp:ListBox> </td>
              <td align="right" valign="top"><p><strong>Sekt�r</strong></p></td>
              <td> <asp:ListBox runat="server" ID="lbSectors" SelectionMode="Multiple"></asp:ListBox> </td>
            </tr>
            <tr>
              <td align="right">&nbsp;</td>
              <td>&nbsp;</td>
              <td>&nbsp;</td>
              <td>&nbsp;</td>
            </tr>
            <tr>
              <td align="right" valign="top"><p><strong>�lke</strong></p></td>
              <td>  <asp:ListBox runat="server" ID="lbCountries" SelectionMode="Multiple"></asp:ListBox> </td>
              <td align="right" valign="top"><p><strong>�ehir</strong></p></td>
              <td> <asp:ListBox runat="server" ID="lbCities" SelectionMode="Multiple"></asp:ListBox> </td>
            </tr>
            <tr>
              <td align="right">&nbsp;</td>
              <td colspan="3">&nbsp;</td>
            </tr>
            <tr>
              <td align="right"><p>&nbsp;</p></td>
              <td colspan="3"><p>
                  <input name="radiobutton" type="radio" value="radiobutton" checked="checked" />
                  T�m ilanlarda aray�n</p>
                <p>
                  <input name="radiobutton" type="radio" value="radiobutton" />
                  Size uygun ilanlarda aray�n</p></td>
            </tr>
            <tr>
              <td>&nbsp;</td>
              <td colspan="3">&nbsp;</td>
            </tr>
            <tr>
              <td>&nbsp;</td>
              <td colspan="3">
                <asp:ImageButton ImageUrl="~/Images/buttons/Search.png" runat="server" ID="imgSearch" BorderWidth="0" />
            </tr>
          </table>
          <div class="brclear"></div>
        </div>
      </div>
      <div class="BoxContentBottom"></div>
      <!-- finish roundcornered box -->
    </div>