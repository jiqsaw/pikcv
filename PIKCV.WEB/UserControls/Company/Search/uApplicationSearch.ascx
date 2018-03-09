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
                <li><a href="#Company-Search-Filters"><span>Kay�tl� filtreler</span></a></li>
                <li><a href="#Company-Search-EmployeeSearch&Type=2"><span>Y�netici arama</span></a></li>
                <li><a href="#Company-Search-EmployeeSearch&Type=1"><span>Eleman / Uzman arama</span></a>
                </li>
                <li class="TabActive"><a href="#Company-Search-ApplicationSearch"><span>Ba�vuru arama</span></a></li>
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
                            <a href="javascript:;" id="p7ABt1_1">�lanlar</a></h4>
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
                                                <strong>Aday �smi</strong></th>
                                            <th width="20%" nowrap="nowrap">
                                                <strong>Biti� Tarihi</strong></th>
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
                                            T�m ilanlarda ara
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
                            <a href="javascript:;" id="p7ABt1_2">Ba�vuru stat�leri</a></h4>
                    </div>
                    <div id="p7ABw1_2">
                        <div id="p7ABc1_2" class="p7ABcontent">
                            <table width="100%" class="FormTable">
                                <tr>
                                    <td valign="top" style="height: 102px">
                                        <asp:CheckBoxList ID="chkEvaluation" runat="server">
                                            <asp:ListItem Text="�ncelenmedi"></asp:ListItem>
                                            <asp:ListItem Text="�ncelendi"></asp:ListItem>
                                            <asp:ListItem Text="M�lakata �a�r�ld�"></asp:ListItem>
                                            <asp:ListItem Text="Uygun g�r�lmedi"></asp:ListItem>
                                            <asp:ListItem Text="T�m ba�vurular" Selected="True"></asp:ListItem>
                                        </asp:CheckBoxList></td>
                                </tr>
                            </table>
                        </div>
                    </div>
                    <!-- accordeon 3 starts -->
                    <div class="p7ABtrig">
                        <h4>
                            <a href="javascript:;" id="p7ABt1_3">Ki�isel bilgiler</a></h4>
                    </div>
                    <div id="p7ABw1_3">
                        <div id="p7ABc1_3" class="p7ABcontent">
                            <table width="100%" class="FormTable">
                                <tr>
                                    <td width="20%" align="right" valign="top">
                                        <strong>Cinsiyet</strong></td>
                                    <td valign="top">
                                        <asp:CheckBoxList ID="chkGenders" runat="server" RepeatDirection="Horizontal">
                                            <asp:ListItem Text="Kad�n"></asp:ListItem>
                                            <asp:ListItem Text="Erkek"></asp:ListItem>
                                            <asp:ListItem Text="Farketmez"></asp:ListItem>
                                        </asp:CheckBoxList>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" valign="top">
                                        <strong>Ya� aral���</strong></td>
                                    <td valign="top">
                                        <asp:CheckBoxList RepeatDirection="Vertical" runat="server" ID="chkAgeRange">
                                            <asp:ListItem Selected="True" Text="T�m�" Value=""></asp:ListItem>
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
                                        <strong>S�r�c� belgesi</strong></td>
                                    <td valign="top">
                                        <asp:DropDownList ID="ddlDrvLicense1" runat="server" />
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" valign="top">
                                        <strong>�zel durum</strong></td>
                                    <td valign="top">
                                        <asp:CheckBox ID="chkHandicapped" runat="server" Text="Engelli" />
                                        <asp:CheckBox ID="chkConvicted" runat="server" Text="Eski h�k�ml�" />
                                        <asp:CheckBox ID="chkMartyrRelative" runat="server" Text="�ehit yak�n�" />
                                        <asp:CheckBox ID="chkTerrorAggrieved" runat="server" Text="Ter�r ma�duru" />
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
                            <a href="javascript:;" id="p7ABt1_4">�leti�im bilgileri</a></h4>
                    </div>
                    <div id="p7ABw1_4">
                        <div id="p7ABc1_4" class="p7ABcontent">
                            <table width="100%" class="FormTable">
                                <tr>
                                    <td width="20%" align="right" valign="top">
                                        <strong>Ya�ad��� �lke</strong><br />
                                        <span class="mute">En �ok 5 se�im yap�labilir</span></td>
                                    <td valign="top">
                                        <table>
                                            <tr>
                                                <td valign="top">
                                                    <asp:ListBox ID="lbCountries" Style="width: 230px;" runat="server" ToolTip="Ctrl tu�una bas�l� tutarak en fazla 5 se�im yapabilirsiniz"
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
                                                    <asp:ListBox ID="lbSelectedCountries" Style="width: 230px;" runat="server" ToolTip="Ctrl tu�una bas�l� tutarak en fazla 5 se�im yapabilirsiniz"
                                                        Rows="5" SelectionMode="Multiple"></asp:ListBox>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" valign="top">
                                        <strong>Ya�ad��� �ehir</strong><span class="mute"><br />
                                            En �ok 5 se�im yap�labilir</span></td>
                                    <td valign="top">
                                        <table>
                                            <tr>
                                                <td valign="top">
                                                    <asp:ListBox ID="lbCities" Style="width: 230px;" runat="server" ToolTip="Ctrl tu�una bas�l� tutarak en fazla 5 se�im yapabilirsiniz"
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
                                                    <asp:ListBox ID="lbSelectedCities" Style="width: 230px;" runat="server" ToolTip="Ctrl tu�una bas�l� tutarak en fazla 5 se�im yapabilirsiniz"
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
                            <a href="javascript:;" id="p7ABt1_5">E�itim durumu</a></h4>
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
                            <a href="javascript:;" id="p7ABt1_6">�� tecr�besi</a></h4>
                    </div>
                    <div id="p7ABw1_6">
                        <div id="p7ABc1_6" class="p7ABcontent">
                            <table width="100%" class="FormTable">
                                <tr>
                                    <td width="20%" align="right" valign="top">
                                        <strong>Sekt�r</strong><span class="mute"><br />
                                            En �ok 5 se�im yap�labilir</span></td>
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
                                        <span class="mute">En �ok 5 se�im yap�labilir</span></td>
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
                                        <strong>Tecr�be s�resi</strong></td>
                                    <td valign="top">
                                        <asp:CheckBoxList ID="chkExperience" runat="server" RepeatDirection="Horizontal"
                                            Width="500">
                                            <asp:ListItem Text="0-1 y�l"></asp:ListItem>
                                            <asp:ListItem Text="2-5 y�l"></asp:ListItem>
                                            <asp:ListItem Text="6-10 y�l"></asp:ListItem>
                                            <asp:ListItem Text="10 y�l ve �st�"></asp:ListItem>
                                        </asp:CheckBoxList>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" valign="top">
                                        <strong>�al��ma �ekli</strong></td>
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
                            <a href="javascript:;" id="p7ABt1_7">Yabanc� dil</a></h4>
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
                                        Konu�ma</td>
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
                            <a href="javascript:;" id="p7ABt1_9">�al��ma tercihleri</a></h4>
                    </div>
                    <div id="p7ABw1_9">
                        <div id="p7ABc1_9" class="p7ABcontent">
                            <table width="100%" class="FormTable">
                                <tr>
                                    <td align="right" valign="top">
                                        <strong>�al��mak istedi�i sekt�r</strong><span class="mute"><br />
                                            En �ok 5 se�im yap�labilir</span></td>
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
                                        <strong>�al��mak istedi�i pozisyon</strong><span class="mute"><br />
                                            En �ok 5 se�im yap�labilir</span></td>
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
                                        <strong>�al��mak istedi�i �lkeler</strong><span class="mute"><br />
                                            En �ok 5 se�im yap�labilir</span></td>
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
                                        <strong>�al��mak istedi�i �ehirler</strong><span class="mute"><br />
                                            En �ok 5 se�im yap�labilir</span></td>
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
                                        <strong>�al��ma �ekli</strong></td>
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
                    <asp:Image ID="btn_search" ImageUrl="~/images/buttons/corp_search.png" alt="Teste ba�la..."
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
            <a href="javascript:;">�leti�im</a>&nbsp;&nbsp;|&nbsp;&nbsp;<a href="javascript:;">Site
                Haritas�</a>&nbsp;&nbsp;|&nbsp;&nbsp;<a href="javascript:;">Yard�m</a>&nbsp;&nbsp;|&nbsp;&nbsp;<a
                    href="javascript:;">Ki�isel Sayfa</a>&nbsp;&nbsp;|&nbsp;&nbsp;<a href="javascript:;">English</a></p>
        <p>
            <a href="javascript:;">Gizlilik Anla�mas�</a> - <a href="javascript:;">Kullan�m �artlar�</a></p>
        <p class="mute">
            &copy; 2007 Perakende �nsan Kaynaklar�</p>
    </div>
    <!-- END FOOTER -->
</div>
