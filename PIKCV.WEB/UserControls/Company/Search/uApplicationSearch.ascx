<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uApplicationSearch.ascx.cs"
    Inherits="UserControls_Company_Search_uApplicationSearch" %>
<div id="content">
    <div class="contentPad">
        <div class="HeaderPR floatLeft">
            <h2 class="sIFRHeader">
                Arama</h2>
        </div>
        <div id="Tab">
            <ul>
                <li><a href="#Company-Search-Filters"><span>Kayýtlý filtreler</span></a></li>
                <li><a href="#Company-Search-EmployeeSearch&Type=2"><span>Yönetici arama</span></a></li>
                <li><a href="#Company-Search-EmployeeSearch&Type=1"><span>Eleman / Uzman arama</span></a>
                </li>
                <li class="TabActive"><a href="#Company-Search-ApplicationSearch"><span>Baþvuru arama</span></a></li>
            </ul>
        </div>
        <div class="brclear">
        </div>
        <!-- start roundcornered box -->
        <div class="BoxContentTop">
        </div>
        <div class="BoxContent">
            <div class="BoxPadder">
                <div class="infoMsg">
                    <p>
                        Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Ut ut nulla at odio convallis
                        fermentum.</p>
                </div>
                <p>
                    &nbsp;</p>
                <div id="p7ABW1" class="p7AB">
                    <!-- accordeon 1 starts -->
                    <div class="p7ABtrig">
                        <h4>
                            <a href="javascript:;" id="p7ABt1_1">Ýlanlar</a></h4>
                    </div>
                    <div id="p7ABw1_1">
                        <div id="p7ABc1_1" class="p7ABcontent">
                            <asp:Repeater ID="rptAds" runat="server">
                                <HeaderTemplate>
                                    <table width="100%" class="dataGrid">
                                        <tr>
                                            <th>
                                            </th>
                                            <th width="40%">
                                                <strong>Pozisyon</strong></th>
                                             <th width="40%" nowrap="nowrap">
                                                <strong>Aday Ýsmi</strong></th>
                                            <th width="20%" nowrap="nowrap">
                                                <strong>Bitiþ Tarihi</strong></th>
                                        </tr>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <tr class="odd">
                                        <td>
                                            <asp:CheckBox ID="rptCheckBox1" runat="server" />
                                        </td>
                                        <td>
                                            <a href="javascript:;"><strong>
                                                <%# Eval("PositionName") %>
                                            </strong></a>
                                        </td>
                                        <td>
                                            <%# Eval("ApplicationDate") %>
                                        </td>
                                        <td>
                                            <%# Eval("UserName") %>
                                        </td>
                                    </tr>
                                </ItemTemplate>
                                <AlternatingItemTemplate>
                                    <tr class="even">
                                        <td>
                                            <input type="checkbox" name="checkbox15" value="checkbox" /></td>
                                        <td>
                                            <a href="javascript:;"><strong>
                                                <%# Eval("PositionName") %>
                                            </strong></a>
                                        </td>
                                        <td>
                                            <%# Eval("ApplicationDate") %>
                                        </td>
                                    </tr>
                                </AlternatingItemTemplate>
                                <FooterTemplate>
                                    <tr class="even">
                                        <td colspan="3">
                                            <input type="checkbox" name="checkbox172" value="checkbox" />
                                            Tüm ilanlarda ara
                                        </td>
                                    </tr>
                                    </table>
                                </FooterTemplate>
                            </asp:Repeater>
                        </div>
                    </div>
                    <!-- accordeon 2 starts -->
                    <div class="p7ABtrig">
                        <h4>
                            <a href="javascript:;" id="p7ABt1_2">Baþvuru statüleri</a></h4>
                    </div>
                    <div id="p7ABw1_2">
                        <div id="p7ABc1_2" class="p7ABcontent">
                            <table width="100%" class="FormTable">
                                <tr>
                                    <td valign="top" style="height: 102px">
                                        <asp:CheckBoxList ID="chkEvaluation" runat="server">
                                            <asp:ListItem Text="Ýncelenmedi"></asp:ListItem>
                                            <asp:ListItem Text="Ýncelendi"></asp:ListItem>
                                            <asp:ListItem Text="Mülakata çaðrýldý"></asp:ListItem>
                                            <asp:ListItem Text="Uygun görülmedi"></asp:ListItem>
                                            <asp:ListItem Text="Tüm baþvurular" Selected="True"></asp:ListItem>
                                        </asp:CheckBoxList></td>
                                </tr>
                            </table>
                        </div>
                    </div>
                    <!-- accordeon 3 starts -->
                    <div class="p7ABtrig">
                        <h4>
                            <a href="javascript:;" id="p7ABt1_3">Kiþisel bilgiler</a></h4>
                    </div>
                    <div id="p7ABw1_3">
                        <div id="p7ABc1_3" class="p7ABcontent">
                            <table width="100%" class="FormTable">
                                <tr>
                                    <td width="20%" align="right" valign="top">
                                        <strong>Cinsiyet</strong></td>
                                    <td valign="top">
                                        <asp:CheckBoxList ID="chkGenders" runat="server" RepeatDirection="Horizontal">
                                            <asp:ListItem Text="Kadýn"></asp:ListItem>
                                            <asp:ListItem Text="Erkek"></asp:ListItem>
                                            <asp:ListItem Text="Farketmez"></asp:ListItem>
                                        </asp:CheckBoxList>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" valign="top">
                                        <strong>Yaþ aralýðý</strong></td>
                                    <td valign="top">
                                        <asp:CheckBoxList RepeatDirection="Vertical" runat="server" ID="chkAgeRange">
                                            <asp:ListItem Selected="True" Text="Tümü" Value=""></asp:ListItem>
                                            <asp:ListItem Text="18 - 24" Value=""></asp:ListItem>
                                            <asp:ListItem Text="25 - 29" Value=""></asp:ListItem>
                                            <asp:ListItem Text="30 - 34" Value=""></asp:ListItem>
                                            <asp:ListItem Text="35 - 39" Value=""></asp:ListItem>
                                            <asp:ListItem Text="40 - 44" Value=""></asp:ListItem>
                                            <asp:ListItem Text="45 - 55" Value=""></asp:ListItem>
                                            <asp:ListItem Text="56+" Value=""></asp:ListItem>
                                        </asp:CheckBoxList>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" valign="top">
                                        <strong>Medeni Hali</strong></td>
                                    <td valign="top">
                                        <asp:CheckBoxList ID="chkMaritalStatus" runat="server" RepeatDirection="Horizontal"
                                            Width="120">
                                        </asp:CheckBoxList>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" valign="top">
                                        <strong>Askerlik durumu</strong></td>
                                    <td valign="top">
                                        <asp:CheckBoxList ID="chkMilitaryStates" runat="server" RepeatDirection="Horizontal"
                                            Width="120">
                                        </asp:CheckBoxList>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" valign="top">
                                        <strong>Sürücü belgesi</strong></td>
                                    <td valign="top">
                                        <asp:DropDownList ID="ddlDrvLicense1" runat="server" />
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" valign="top">
                                        <strong>Özel durum</strong></td>
                                    <td valign="top">
                                        <asp:CheckBox ID="chkHandicapped" runat="server" Text="Engelli" />
                                        <asp:CheckBox ID="chkConvicted" runat="server" Text="Eski hükümlü" />
                                        <asp:CheckBox ID="chkMartyrRelative" runat="server" Text="Þehit yakýný" />
                                        <asp:CheckBox ID="chkTerrorAggrieved" runat="server" Text="Terör maðduru" />
                                    </td>
                                </tr>
                            </table>
                            <div class="brclear">
                            </div>
                        </div>
                    </div>
                    <!-- accordeon 4 starts -->
                    <div class="p7ABtrig">
                        <h4>
                            <a href="javascript:;" id="p7ABt1_4">Ýletiþim bilgileri</a></h4>
                    </div>
                    <div id="p7ABw1_4">
                        <div id="p7ABc1_4" class="p7ABcontent">
                            <table width="100%" class="FormTable">
                                <tr>
                                    <td width="20%" align="right" valign="top">
                                        <strong>Yaþadýðý ülke</strong><br />
                                        <span class="mute">En çok 5 seçim yapýlabilir</span></td>
                                    <td valign="top">
                                        <table>
                                            <tr>
                                                <td valign="top">
                                                    <asp:ListBox ID="lbCountries" Style="width: 230px;" runat="server" ToolTip="Ctrl tuþuna basýlý tutarak en fazla 5 seçim yapabilirsiniz"
                                                        Rows="5" SelectionMode="Multiple"></asp:ListBox>
                                                </td>
                                                <td>
                                                    <asp:Image ID="add_to_list1" ImageUrl="~/images/buttons/add_to_list.png" Width="60"
                                                        Height="27" runat="server" />
                                                    <br />
                                                    <br />
                                                    <asp:Image ID="remove_from_list1" ImageUrl="~/images/buttons/remove_from_list.png"
                                                        Width="60" Height="27" runat="server" /></td>
                                                <td valign="top">
                                                    <asp:ListBox ID="lbSelectedCountries" Style="width: 230px;" runat="server" ToolTip="Ctrl tuþuna basýlý tutarak en fazla 5 seçim yapabilirsiniz"
                                                        Rows="5" SelectionMode="Multiple"></asp:ListBox>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" valign="top">
                                        <strong>Yaþadýðý þehir</strong><span class="mute"><br />
                                            En çok 5 seçim yapýlabilir</span></td>
                                    <td valign="top">
                                        <table>
                                            <tr>
                                                <td valign="top">
                                                    <asp:ListBox ID="lbCities" Style="width: 230px;" runat="server" ToolTip="Ctrl tuþuna basýlý tutarak en fazla 5 seçim yapabilirsiniz"
                                                        Rows="5" SelectionMode="Multiple"></asp:ListBox>
                                                </td>
                                                <td>
                                                    <asp:Image ID="add_to_list2" ImageUrl="~/images/buttons/add_to_list.png" Width="60"
                                                        Height="27" runat="server" />
                                                    <br />
                                                    <br />
                                                    <asp:Image ID="remove_from_list2" ImageUrl="~/images/buttons/remove_from_list.png"
                                                        Width="60" Height="27" runat="server" /></td>
                                                <td valign="top">
                                                    <asp:ListBox ID="lbSelectedCities" Style="width: 230px;" runat="server" ToolTip="Ctrl tuþuna basýlý tutarak en fazla 5 seçim yapabilirsiniz"
                                                        Rows="5" SelectionMode="Multiple"></asp:ListBox>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                            <div class="brclear">
                            </div>
                        </div>
                    </div>
                    <!-- accordeon 5 starts -->
                    <div class="p7ABtrig">
                        <h4>
                            <a href="javascript:;" id="p7ABt1_5">Eðitim durumu</a></h4>
                    </div>
                    <div id="p7ABw1_5">
                        <div id="p7ABc1_5" class="p7ABcontent">
                            <table width="100%" class="FormTable">
                                <tr>
                                    <td valign="top">
                                        <table width="100%" class="FormTable">
                                            <tr>
                                                <td rowspan="6">
                                                    <asp:CheckBoxList runat="server" ID="chkEducationLevels">
                                                    </asp:CheckBoxList></td>
                                                <td>
                                                </td>
                                                <td>
                                                </td>
                                                <td>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:CheckBoxList ID="chkEducationStates1" runat="server" RepeatDirection="Horizontal" />
                                                </td>
                                                <td>
                                                    <asp:DropDownList ID="ddlSchools1" runat="server" Width="200" /></td>
                                                <td>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                </td>
                                                <td>
                                                </td>
                                                <td>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:CheckBoxList ID="chkEducationStates2" runat="server" RepeatDirection="Horizontal" />
                                                </td>
                                                <td>
                                                    <asp:DropDownList ID="ddlSchools2" runat="server" Width="200" /></td>
                                                <td>
                                                    <asp:DropDownList ID="ddlSchools3" runat="server" Width="200" /></td>
                                            </tr>
                                            <tr>
                                                <td>
                                                </td>
                                                <td>
                                                </td>
                                                <td>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                </td>
                                                <td>
                                                </td>
                                                <td>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </div>
                    <!-- accordeon 6 starts -->
                    <div class="p7ABtrig">
                        <h4>
                            <a href="javascript:;" id="p7ABt1_6">Ýþ tecrübesi</a></h4>
                    </div>
                    <div id="p7ABw1_6">
                        <div id="p7ABc1_6" class="p7ABcontent">
                            <table width="100%" class="FormTable">
                                <tr>
                                    <td width="20%" align="right" valign="top">
                                        <strong>Sektör</strong><span class="mute"><br />
                                            En çok 5 seçim yapýlabilir</span></td>
                                    <td valign="top">
                                        <table>
                                            <tr>
                                                <td valign="top">
                                                    <asp:ListBox ID="lbSectors" Style="width: 230px;" runat="server" size="5" Rows="5"
                                                        SelectionMode="Multiple"></asp:ListBox>
                                                </td>
                                                <td>
                                                    <asp:Image ID="add_to_list3" ImageUrl="~/images/buttons/add_to_list.png" Width="60"
                                                        Height="27" runat="server" />
                                                    <br />
                                                    <br />
                                                    <asp:Image ID="remove_from_list3" ImageUrl="~/images/buttons/remove_from_list.png"
                                                        Width="60" Height="27" runat="server" /></td>
                                                <td>
                                                    <asp:ListBox ID="lbSelectedSectors" Style="width: 230px;" runat="server" size="5"
                                                        Rows="5" SelectionMode="Multiple"></asp:ListBox>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" valign="top">
                                        <strong>Pozisyon</strong><br />
                                        <span class="mute">En çok 5 seçim yapýlabilir</span></td>
                                    <td valign="top">
                                        <table>
                                            <tr>
                                                <td valign="top">
                                                    <asp:ListBox ID="lbPositions" Style="width: 230px;" runat="server" Rows="5" SelectionMode="Multiple">
                                                    </asp:ListBox>
                                                </td>
                                                <td>
                                                    <asp:Image ID="add_to_list4" ImageUrl="~/images/buttons/add_to_list.png" Width="60"
                                                        Height="27" runat="server" />
                                                    <br />
                                                    <br />
                                                    <asp:Image ID="remove_from_list4" ImageUrl="~/images/buttons/remove_from_list.png"
                                                        Width="60" Height="27" runat="server" /></td>
                                                <td valign="top">
                                                    <asp:ListBox ID="lbSelectedPositions" Style="width: 230px;" runat="server" Rows="5"
                                                        SelectionMode="Multiple"></asp:ListBox>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" valign="top">
                                        <strong>Tecrübe süresi</strong></td>
                                    <td valign="top">
                                        <asp:CheckBoxList ID="chkExperience" runat="server" RepeatDirection="Horizontal"
                                            Width="500">
                                            <asp:ListItem Text="0-1 yýl"></asp:ListItem>
                                            <asp:ListItem Text="2-5 yýl"></asp:ListItem>
                                            <asp:ListItem Text="6-10 yýl"></asp:ListItem>
                                            <asp:ListItem Text="10 yýl ve üstü"></asp:ListItem>
                                        </asp:CheckBoxList>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" valign="top">
                                        <strong>Çalýþma þekli</strong></td>
                                    <td valign="top">
                                        <asp:CheckBoxList ID="chkLabouringTypes1" runat="server">
                                        </asp:CheckBoxList></td>
                                </tr>
                            </table>
                        </div>
                    </div>
                    <!-- accordeon 7 starts -->
                    <div class="p7ABtrig">
                        <h4>
                            <a href="javascript:;" id="p7ABt1_7">Yabancý dil</a></h4>
                    </div>
                    <div id="p7ABw1_7">
                        <div id="p7ABc1_7" class="p7ABcontent">
                            <table class="FormTable">
                                <tr>
                                    <td>
                                        Dil</td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        Okuma</td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        Yazma</td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        Konuþma</td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:DropDownList ID="ddlLanguage1" runat="server" />
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        <asp:DropDownList ID="ddlLanguage11" runat="server" />
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        <asp:DropDownList ID="ddlLanguage111" runat="server" />
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        <asp:DropDownList ID="ddlLanguage1111" runat="server" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:DropDownList ID="ddlLanguage2" runat="server" />
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        <asp:DropDownList ID="ddlLanguage22" runat="server" />
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        <asp:DropDownList ID="ddlLanguage222" runat="server" />
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        <asp:DropDownList ID="ddlLanguage2222" runat="server" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:DropDownList ID="ddlLanguage3" runat="server" />
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        <asp:DropDownList ID="ddlLanguage33" runat="server" />
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        <asp:DropDownList ID="ddlLanguage333" runat="server" />
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        <asp:DropDownList ID="ddlLanguage3333" runat="server" />
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </div>
                    <!-- accordeon 8 starts -->
                    <div class="p7ABtrig">
                        <h4>
                            <a href="javascript:;" id="p7ABt1_8">Bilgisayar bilgisi</a></h4>
                    </div>
                    <div id="p7ABw1_8">
                        <div id="p7ABc1_8" class="p7ABcontent">
                            <table class="FormTable">
                                <tr>
                                    <td valign="top">
                                        <asp:ListBox ID="lbComputerSkill" Style="width: 220px;" runat="server" Rows="5" SelectionMode="Multiple" />
                                    </td>
                                    <td>
                                        <asp:Image ID="add_to_list5" ImageUrl="~/images/buttons/add_to_list.png" Width="60"
                                            Height="27" runat="server" />
                                        <br />
                                        <br />
                                        <asp:Image ID="remove_from_list5" ImageUrl="~/images/buttons/remove_from_list.png"
                                            Width="60" Height="27" runat="server" /></td>
                                    <td valign="top">
                                        <asp:ListBox ID="lbSelectedComputerSkill" Style="width: 220px;" runat="server" Rows="5"
                                            SelectionMode="Multiple" />
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </div>
                    <!-- accordeon 9 starts -->
                    <div class="p7ABtrig">
                        <h4>
                            <a href="javascript:;" id="p7ABt1_9">Çalýþma tercihleri</a></h4>
                    </div>
                    <div id="p7ABw1_9">
                        <div id="p7ABc1_9" class="p7ABcontent">
                            <table width="100%" class="FormTable">
                                <tr>
                                    <td align="right" valign="top">
                                        <strong>Çalýþmak istediði sektör</strong><span class="mute"><br />
                                            En çok 5 seçim yapýlabilir</span></td>
                                    <td valign="top">
                                        <table>
                                            <tr>
                                                <td valign="top">
                                                    <asp:ListBox ID="lbSectorDesired" runat="server" Style="width: 230px;" Rows="5" SelectionMode="Multiple" />
                                                </td>
                                                <td>
                                                    <asp:Image ID="add_to_list6" ImageUrl="~/images/buttons/add_to_list.png" Width="60"
                                                        Height="27" runat="server" />
                                                    <br />
                                                    <br />
                                                    <asp:Image ID="remove_from_list6" ImageUrl="~/images/buttons/remove_from_list.png"
                                                        Width="60" Height="27" runat="server" /></td>
                                                <td valign="top">
                                                    <asp:ListBox ID="lbSelectedSectorDesired" runat="server" Style="width: 230px;" Rows="5"
                                                        SelectionMode="Multiple" />
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" valign="top">
                                        <strong>Çalýþmak istediði pozisyon</strong><span class="mute"><br />
                                            En çok 5 seçim yapýlabilir</span></td>
                                    <td valign="top">
                                        <table>
                                            <tr>
                                                <td valign="top">
                                                    <asp:ListBox ID="lbPositionDesired" runat="server" Style="width: 230px;" Rows="5"
                                                        SelectionMode="Multiple" />
                                                </td>
                                                <td>
                                                    <asp:Image ID="add_to_list7" ImageUrl="~/images/buttons/add_to_list.png" Width="60"
                                                        Height="27" runat="server" />
                                                    <br />
                                                    <br />
                                                    <asp:Image ID="remove_from_list7" ImageUrl="~/images/buttons/remove_from_list.png"
                                                        Width="60" Height="27" runat="server" /></td>
                                                <td valign="top">
                                                    <asp:ListBox ID="lbSelectedPositionDesired" runat="server" Style="width: 230px;"
                                                        Rows="5" SelectionMode="Multiple" />
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td width="20%" align="right" valign="top">
                                        <strong>Çalýþmak istediði ülkeler</strong><span class="mute"><br />
                                            En çok 5 seçim yapýlabilir</span></td>
                                    <td valign="top">
                                        <table>
                                            <tr>
                                                <td valign="top">
                                                    <asp:ListBox ID="lbCountriesDesired" runat="server" Style="width: 230px;" Rows="5"
                                                        SelectionMode="Multiple" />
                                                </td>
                                                <td>
                                                    <asp:Image ID="add_to_list8" ImageUrl="~/images/buttons/add_to_list.png" Width="60"
                                                        Height="27" runat="server" />
                                                    <br />
                                                    <br />
                                                    <asp:Image ID="remove_from_list8" ImageUrl="~/images/buttons/remove_from_list.png"
                                                        Width="60" Height="27" runat="server" /></td>
                                                <td valign="top">
                                                    <asp:ListBox ID="lbSelectedCountriesDesired" runat="server" Style="width: 230px;"
                                                        Rows="5" SelectionMode="Multiple" />
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" valign="top">
                                        <strong>Çalýþmak istediði þehirler</strong><span class="mute"><br />
                                            En çok 5 seçim yapýlabilir</span></td>
                                    <td valign="top">
                                        <table>
                                            <tr>
                                                <td valign="top">
                                                    <asp:ListBox ID="lbCitiesDesired" runat="server" Style="width: 230px;" Rows="5" SelectionMode="Multiple" />
                                                </td>
                                                <td>
                                                    <asp:Image ID="add_to_list9" ImageUrl="~/images/buttons/add_to_list.png" Width="60"
                                                        Height="27" runat="server" />
                                                    <br />
                                                    <br />
                                                    <asp:Image ID="remove_from_list9" ImageUrl="~/images/buttons/remove_from_list.png"
                                                        Width="60" Height="27" runat="server" /></td>
                                                <td valign="top">
                                                    <asp:ListBox ID="lbSelectedCitiesDesired" runat="server" Style="width: 230px;" Rows="5"
                                                        SelectionMode="Multiple" />
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" valign="top">
                                        <strong>Çalýþma þekli</strong></td>
                                    <td valign="top">
                                        <asp:CheckBoxList ID="chkLabouringTypes2" runat="server" />
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </div>
                </div>
                <p align="center">
                    &nbsp;</p>
                <p align="center">
                    <asp:Image ID="btn_search" ImageUrl="~/images/buttons/corp_search.png" alt="Teste baþla..."
                        Width="88" Height="27" runat="server" /></p>
                <p align="center">
                    &nbsp;</p>
                <p align="center">
                    <a href="/pikcv/2_2_4_4_test_popup.htm"></a>
                </p>

                <script type="text/javascript">
			<!--
				P7_opAB(1,1,1,0,1);
			//-->
                </script>

                <div class="brclear">
                </div>
            </div>
        </div>
        <div class="BoxContentBottom">
        </div>
        <!-- finish roundcornered box -->
    </div>
    <!-- START FOOTER -->
    <div id="footer">
        <p>
            <a href="javascript:;">Ýletiþim</a>&nbsp;&nbsp;|&nbsp;&nbsp;<a href="javascript:;">Site
                Haritasý</a>&nbsp;&nbsp;|&nbsp;&nbsp;<a href="javascript:;">Yardým</a>&nbsp;&nbsp;|&nbsp;&nbsp;<a
                    href="javascript:;">Kiþisel Sayfa</a>&nbsp;&nbsp;|&nbsp;&nbsp;<a href="javascript:;">English</a></p>
        <p>
            <a href="javascript:;">Gizlilik Anlaþmasý</a> - <a href="javascript:;">Kullaným Þartlarý</a></p>
        <p class="mute">
            &copy; 2007 Perakende Ýnsan Kaynaklarý</p>
    </div>
    <!-- END FOOTER -->
</div>
