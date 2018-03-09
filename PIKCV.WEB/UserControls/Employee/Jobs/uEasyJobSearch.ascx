<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uEasyJobSearch.ascx.cs" Inherits="UserControls_Employee_Jobs_uEasyJobSearch" %>
   <div class="contentPad">
   
      <div class="HeaderPR floatLeft">
        <h2 class="sIFRHeader">Ýlan Arama</h2>
      </div>

        <div id="Tab">     
            <ul>
                <li class="TabActive" id="li1">
                    <a href="#Employee-Jobs-EasyJobSearch"><span>Kolay arama</span></a>
                </li>
                <li id="li2">
                    <a href="#Employee-Jobs-DetailJobSearch"><span>Detaylý arama</span></a>
                </li>
                <li id="liFilters" runat="server">
                     <a href="#Employee-Jobs-FiltersJobSearch"><span>Kayýtlý Filtreler</span></a>
                </li>
            </ul>
        </div>

      <div class="brclear"></div>

    <div class="BoxContent">
        <div class="BoxPadder">
          <table class="FormTable">
            <tr>
              <td align="right"><p> <strong>Anahtar Kelimeler:<br /> </strong></p></td>
                <td>
                    <asp:TextBox runat="server" ID="txtKeyword" CssClass="cssInput" Width="280"></asp:TextBox>
                </td>
            </tr>
            
            <tr>
              <td align="right" valign="top"><strong>Pozisyon</strong>
              <p class="mute">(En çok 10 tercih yapabilirsiniz)</p>
              </td>
              <td><table>
                <tr>
                  <td valign="top">
                    <asp:ListBox SelectionMode="Multiple" Height="80" Width="340" runat="server" ID="lbPositions"></asp:ListBox>
                  </td>
                    <td>
                        <p>
                            <asp:Image runat="server" ID="imgAddToListPositions" ImageUrl="~/Images/buttons/add_to_list.png" /><br />
                            <br />
                            <asp:Image runat="server" ID="imgRemoveToListPositions" ImageUrl="~/Images/buttons/remove_from_list.png" />                  
                        </p>
                    </td>
                  <td valign="top">
                    <asp:ListBox Width="240" Height="80" runat="server" ID="lbSelectedPositions" SelectionMode="Multiple">
                    </asp:ListBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="lbSelectedPositions"
                      CssClass="Error" ErrorMessage="Lütfen Pozisyon Seçiniz" SetFocusOnError="True"
                      ValidationGroup="vgSearch"></asp:RequiredFieldValidator>              
                  </td>
                </tr>
              </table>
                </td>
            </tr>
            <tr>
              <td align="right" valign="top"><strong>Sektör</strong>
              <p class="mute">(En çok 10 tercih yapabilirsiniz)</p>
              </td>
              <td><table>
                <tr>
                  <td valign="top">
                    <asp:ListBox SelectionMode="Multiple" Width="340" Height="80" runat="server" ID="lbSectors"></asp:ListBox>
                  </td>
                  <td>
                    <p>
                        <asp:Image runat="server" ID="imgAddToListSector" ImageUrl="~/Images/buttons/add_to_list.png" /><br />
                        <br />
                        <asp:Image runat="server" ID="imgRemoveToListSector" ImageUrl="~/Images/buttons/remove_from_list.png" />
                    </p>                    
                  </td>
                  <td valign="top">
                    <asp:ListBox Width="240" Height="80" runat="server" ID="lbSelectedSectors" SelectionMode="Multiple">
                    </asp:ListBox>                   
<%--                      <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="lbSelectedSectors"
                          CssClass="Error" ErrorMessage="Lütfen Sektör Seçiniz" SetFocusOnError="True"
                          ValidationGroup="vgSearch"></asp:RequiredFieldValidator>--%>
                  </td>
                </tr>
              </table></td>
            </tr>
            <tr>
              <td align="right" valign="top"><strong>Ülke</strong>
              <p class="mute">(En çok 10 tercih yapabilirsiniz)</p>
              </td>
              <td><table>
                <tr>
                  <td valign="top"> <asp:ListBox SelectionMode="Multiple" Width="340" Height="80" runat="server" ID="lbCountries"></asp:ListBox> </td>
                  
                  <td>
                    <p>
                        <asp:Image runat="server" ID="imgAddToListCountries" ImageUrl="~/Images/buttons/add_to_list.png" /><br />
                        <br />
                        <asp:Image runat="server" ID="imgRemoveToListCountries" ImageUrl="~/Images/buttons/remove_from_list.png" />
                    </p>                  
                  </td>
                  
                  <td valign="top">
                    <asp:ListBox Width="240" Height="80" runat="server" ID="lbSelectedCountries" SelectionMode="Multiple">
                    </asp:ListBox>                  
                  </td>
                </tr>
              </table></td>
            </tr>            
            <tr>
              <td align="right" valign="top"><strong>Þehir</strong>
              <p class="mute">(En çok 10 tercih yapabilirsiniz)</p>
              </td>
              <td><table>
                <tr>
                  <td valign="top"> <asp:ListBox SelectionMode="Multiple" Width="340" Height="80" runat="server" ID="lbCities"></asp:ListBox> </td>
                  
                  <td>
                    <p>
                        <asp:Image runat="server" ID="imgAddToListCities" ImageUrl="~/Images/buttons/add_to_list.png" /><br />
                        <br />
                        <asp:Image runat="server" ID="imgRemoveToListCities" ImageUrl="~/Images/buttons/remove_from_list.png" />
                    </p>                  
                  </td>
                  
                  <td valign="top">
                    <asp:ListBox Width="240" Height="80" runat="server" ID="lbSelectedCities" SelectionMode="Multiple">
                    </asp:ListBox>                  
                  </td>
                </tr>
              </table></td>
            </tr>
            
            <tr id="trCustomJobs" runat="server">
              <td align="right"><p>&nbsp;</p></td>
                <td><p>
                    <asp:RadioButton runat="server" GroupName="rdGroupJobSearch" ID="rdAllJobs" Checked="true" Text="Tüm Ýlanlarda Arayýn" /><br />
                    <asp:RadioButton runat="server" GroupName="rdGroupJobSearch" ID="rdCustomJobs" Text="Size Uygun Ýlanlarda Arayýn" /></p>
                </td>
            </tr>
            <tr>
              <td>&nbsp;</td>
              <td>&nbsp;</td>
            </tr>
            <tr>
              <td>&nbsp;</td>
              <td> <asp:ImageButton runat="server" ID="BtnSearch" ImageUrl="~/Images/buttons/Search.png" OnClick="BtnSearch_Click" ValidationGroup="vgSearch" /> </td>
            </tr>
          </table>
          <div class="brclear"></div>
        </div>
      </div>

    <div class="BoxContentBottom"></div>
      
    </div>