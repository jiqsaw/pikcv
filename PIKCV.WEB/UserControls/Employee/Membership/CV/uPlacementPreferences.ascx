<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uPlacementPreferences.ascx.cs" Inherits="UserControls_Employee_Membership_CV_uPlacementPreferences" %>
<%@ Register Src="~/UserControls/Common/ModalPopup/ModalPopup.ascx" TagName="ModalPopup"
    TagPrefix="uc1" %>
    

<uc1:ModalPopup ID="ShowModal" runat="server" Visible="false" />

<script type="text/javascript">
    function OpenCloseOther(OtherID) {
        var ddlID = '<%=lbCities.ClientID %>';
        if (ddlSelectedValue(ddlID) == OtherID) { $get('dvOther').style.display='block'; $get(ddlID).selectedIndex = -1; }
        else $get('dvOther').style.display='none';
    }
</script>

<div class="ContentColA">
    <ul class="SubTabNav">
        <li> <asp:HyperLink runat="server" ID="hlEmploymentChooices" Text="Çalýþma Tercihleri"
            NavigateUrl="#Employee-Membership-CV&CVFocus=||FocusNo||"></asp:HyperLink> </li>
            
        <li class="selected"><a href="javascript:;">Çalýþmak Ýstenen Yerler</a></li>
        
        <li> <asp:HyperLink runat="server" ID="hlProhibitedCompanies" Text="Ambargolu Firmalar"
            NavigateUrl="#Employee-Membership-CV&CVFocus=||FocusNo||"></asp:HyperLink> </li>         
        
        <li> <asp:HyperLink runat="server" ID="hlReferences" Text="Referanslar"
        NavigateUrl="#Employee-Membership-CV&CVFocus=||FocusNo||"></asp:HyperLink> </li>
    </ul>
</div>

<div class="ContentColB">
    <h1>
        Çalýþmak istediðiniz ülke ve þehirler</h1>
    <p>
        &nbsp;</p>
    <table class="FormTable">
        <tr>
            <td align="right" valign="top">
                <p>
                    <strong>Çalýþmak istediðiniz ülkeler</strong><p class="mute">(En çok 10 tercih yapabilirsiniz)</p>
                </p>
            </td>
            <td>
                <table width="100%">
                    <tr>
                        <td valign="top">
                            <asp:ListBox Width="200" Height="140" runat="server" ID="lbCountries" SelectionMode="Multiple"></asp:ListBox >
                        </td>
                        <td>
                            <p>
                                <asp:Image runat="server" ID="imgAddToListCountries" ImageUrl="~/Images/buttons/add_to_list.png" /><br />
                                <br />
                                <asp:Image runat="server" ID="imgRemoveToListCountries" ImageUrl="~/Images/buttons/remove_from_list.png" />
                            </p>
                        </td>
                        <td valign="top">
                            <asp:ListBox Width="200" Height="140" runat="server" ID="lbSelectedCountries" SelectionMode="Multiple"></asp:ListBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="lbSelectedCountries"
                            CssClass="Error" ErrorMessage="Lütfen En Az 1 Ülke Seçiniz" SetFocusOnError="True"
                            ValidationGroup="vgForm"></asp:RequiredFieldValidator>                            
                        </td>
                    </tr>
                </table>
            </td>
        </tr>       
        <tr>
            <td align="right" valign="top">
                <strong>Çalýþmak istediðiniz þehirler</strong><p class="mute">(En çok 10 tercih yapabilirsiniz)</p>
            </td>
            <td>
                <table width="100%">
                    <tr>
                        <td valign="top">
                            <asp:ListBox Width="200" Height="140" runat="server" ID="lbCities" SelectionMode="Multiple"></asp:ListBox >
                            <div id="dvOther" style="display: none;">
                                <p class="mute">
                                    Lütfen aþaðýdaki alaný doldurunuz.</p>
                                <asp:TextBox runat="server" ID="txtOtherPlace" MaxLength="64" Width="175"></asp:TextBox>
                            </div>                            
                        </td>
                        <td>
                            <p>
                                <asp:Image runat="server" ID="imgAddToListCities" ImageUrl="~/Images/buttons/add_to_list.png" /><br />
                                <br />
                                <asp:Image runat="server" ID="imgRemoveToListCities" ImageUrl="~/Images/buttons/remove_from_list.png" />
                            </p>
                        </td>
                        <td valign="top">
                            <asp:ListBox Width="200" Height="140" runat="server" ID="lbSelectedCities" SelectionMode="Multiple"></asp:ListBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="lbSelectedCities"
                                CssClass="Error" ErrorMessage="Lütfen En Az 1 Þehir Seçiniz" SetFocusOnError="True"
                                ValidationGroup="vgForm"></asp:RequiredFieldValidator>                            
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <p><strong>Tercih ettiðiniz çalýþma þekli</strong></p> <br />
                <asp:CheckBoxList runat="server" ID="chLabouringTypes" RepeatDirection="Horizontal">
                </asp:CheckBoxList>&nbsp;
            </td>
        </tr>
        <tr><td>&nbsp;</td></tr>
        <tr>
            <td colspan="2">
                <p><strong>Sýk seyahat etmenizde bir engel var mý?</strong> &nbsp;
                <asp:RadioButton runat="server" ID="rdHasTravelDifficultyYes" GroupName="rdListGrup" Text="Evet" />
                <asp:RadioButton runat="server" ID="rdHasTravelDifficultyNo" Checked="true" GroupName="rdListGrup" Text="Hayýr" />
                </p>
            </td>
        </tr>
        <tr><td>&nbsp;</td></tr>
        <tr>
            <td colspan="2">
                <p><strong>Sigara kullanýmý?</strong> &nbsp;
                <asp:RadioButton runat="server" ID="rdIsSmokingYes" GroupName="rdSmoking" Text="Evet" />
                <asp:RadioButton runat="server" ID="rdIsSmokingNo" Checked="true" GroupName="rdSmoking" Text="Hayýr" />
                </p>
            </td>
        </tr>
    </table>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    
    <p class="floatRight">
        <asp:ImageButton runat="server" ID="ImgBtnContinue" AlternateText="Devam Et" 
        ImageUrl="~/Images/buttons/continue.png" BorderWidth="0" OnClick="ImgBtnContinue_Click" ValidationGroup="vgForm" />
        <asp:ImageButton runat="server" ID="ImgBtnSave" AlternateText="Kaydet" 
        ImageUrl="~/Images/buttons/corp_update_and_save_employee.png" BorderWidth="0" OnClick="ImgBtnContinue_Click" ValidationGroup="vgForm" />
    </p>
    
</div>

<div id="dvScript" runat="server"></div>