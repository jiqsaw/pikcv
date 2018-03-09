<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uDetailJobSearch.ascx.cs" Inherits="UserControls_Employee_Jobs_uDetailJobSearch" %>
<%@ Register Src="../../Common/ModalPopup/ModalPopup.ascx" TagName="ModalPopup" TagPrefix="uc1" %>
   <div class="contentPad">
   
      <div class="HeaderPR floatLeft">
        <h2 class="sIFRHeader">Ýlan Arama</h2>
      </div>

        <div id="Tab">     
            <ul>
                <li id="li1">
                    <a href="#Employee-Jobs-EasyJobSearch"><span>Kolay arama</span></a>
                </li>
                <li class="TabActive" id="li2">
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
                <%--  <h3>Genel Seçim Kriterleri</h3>--%>
          <%--<div class="hr"><hr /></div>--%>
          <table class="FormTable">
            <tr>
              <td align="right"><p> <strong>Anahtar Kelimeler:<br /> </strong></p></td>
                <td>
                    <asp:TextBox runat="server" ID="txtKeyword" CssClass="cssInput" Width="180"></asp:TextBox>
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
            
            <tr>
              <td align="right" valign="top"><strong>Þirket</strong>
              <p class="mute">(En çok 10 tercih yapabilirsiniz)</p>
              </td>
                <td>
                    <table>
                        <tr>
                          <td valign="top"> <asp:ListBox SelectionMode="Multiple" Width="340" Height="80" runat="server" ID="lbCompanies"></asp:ListBox> </td>
                          
                          <td>
                            <p>
                                <asp:Image runat="server" ID="imgAddToListCompanies" ImageUrl="~/Images/buttons/add_to_list.png" /><br />
                                <br />
                                <asp:Image runat="server" ID="imgRemoveToListCompanies" ImageUrl="~/Images/buttons/remove_from_list.png" />
                            </p>                  
                          </td>
                          
                          <td valign="top">
                            <asp:ListBox Width="240" Height="80" runat="server" ID="lbSelectedCompanies" SelectionMode="Multiple"></asp:ListBox>                  
                          </td>
                        </tr>
                    </table>
                </td>
            </tr>            
            
            <tr>
                <td colspan="2" style="padding-left: 21px;">
                    <table width="100%">
                        <tr>
                            <td>
                                
                                <table cellpadding="3" cellspacing="3">
                                    <tr>
                                        <td valign="top"> <p><strong>Eðitim <br />Durumu</strong></p> </td>
                                        <td>
                                             <asp:CheckBoxList runat="server" ID="chEducationLevels">
                                             </asp:CheckBoxList>
                                        </td>
                                    </tr>
                                </table>

                            </td>
                            <td style="width: 180px;"></td>
                            <td>
                            
                                <table cellpadding="3" cellspacing="3">
                                    <tr>
                                        <td valign="top"> <p><strong>Yaþ <br />Aralýðý</strong></p> </td>
                                        <td>
                                            <asp:RadioButtonList RepeatDirection="Vertical" runat="server" ID="rdAgeRange">
                                                <asp:ListItem Text="18 - 24" Value=""></asp:ListItem>
                                                <asp:ListItem Text="25 - 29" Value=""></asp:ListItem>
                                                <asp:ListItem Text="30 - 34" Value=""></asp:ListItem>
                                                <asp:ListItem Text="35 - 39" Value=""></asp:ListItem>
                                                <asp:ListItem Text="40 - 44" Value=""></asp:ListItem>
                                                <asp:ListItem Text="45 - 55" Value=""></asp:ListItem>
                                                <asp:ListItem Text="56+" Value=""></asp:ListItem>
                                                <asp:ListItem Selected="True" Text="Tümü" Value=""></asp:ListItem>
                                            </asp:RadioButtonList>                                 
                                        </td>
                                    </tr>
                                </table>                              
                            
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>           
            
            <tr>
                <td colspan="2" style="padding-left: 21px;">
                    <table width="100%">
                        <tr>
                            <td valign="top">
                                
                                <table cellpadding="3" cellspacing="3">
                                    <tr>
                                        <td valign="top"> <p><strong>Çalýþma <br />Tipi</strong></p> </td>
                                        <td>
                                             <asp:CheckBoxList runat="server" ID="chListLabouringTypes">
                                             </asp:CheckBoxList>                                   
                                        </td>
                                    </tr>
                                </table>

                            </td>
                            <td style="width: 122px;"></td>
                            <td>
                            
                                <table cellpadding="3" cellspacing="3">
                                    <tr>
                                        <td valign="top"> <p><strong>Ýlan <br />Tarihi</strong></p> </td>
                                        <td>
                                            <asp:RadioButtonList RepeatDirection="Vertical" runat="server" ID="rdJobDate">
                                                <asp:ListItem Text="Bugün" Value="1"></asp:ListItem>
                                                <asp:ListItem Text="Son 15 gün" Value="15"></asp:ListItem>
                                                <asp:ListItem Text="Son 1 ay" Value="30"></asp:ListItem>
                                                <asp:ListItem Text="Son 2 ay" Value="60"></asp:ListItem>
                                                <asp:ListItem Selected="True" Text="Tümü" Value="-1"></asp:ListItem>
                                            </asp:RadioButtonList>
                                        </td>
                                    </tr>
                                </table>

                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            
            <tr id="trCustomJobs" runat="server">
              <td align="right"><p>&nbsp;</p></td>
                <td style="padding-left: 17px;"><p>
                    <asp:RadioButton runat="server" GroupName="rdGroupJobSearch" ID="rdAllJobs" Checked="true" Text="Tüm Ýlanlarda Arayýn" /><br />
                    <asp:RadioButton runat="server" GroupName="rdGroupJobSearch" ID="rdCustomJobs" Text="Size Uygun Ýlanlarda Arayýn" /></p>
                </td>
            </tr>
            <tr>
              <td>&nbsp;</td>
              <td>&nbsp;</td>
            </tr>            
            <tr id="trFilter" runat="server">
                <td>&nbsp;</td>
                <td>
                    <asp:CheckBox runat="server" ID="chIsFilterSave" Text="Bu Kriterlerimi Arama Filtresi Olarak Kaydet"/>
                    <br /><br />
                    <div id="dvFilterSave" style="display: none;">
                        <asp:Literal runat="server" ID="ltlFilterName">Filtre Ýsmi</asp:Literal>: 
                        <asp:TextBox runat="server" ID="txtFilterName"></asp:TextBox>
                    </div>
                
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
            <br />
            <br />
          <div class="brclear">
              
          </div>
        </div>
      </div>

    <div class="BoxContentBottom"></div>
      
    </div>
    <uc1:ModalPopup ID="ShowModal" runat="server" Visible="false" />