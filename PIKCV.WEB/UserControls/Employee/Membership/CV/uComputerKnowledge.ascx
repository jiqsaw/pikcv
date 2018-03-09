<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uComputerKnowledge.ascx.cs" Inherits="UserControls_Employee_Membership_CV_uComputerKnowledge" %>
<%@ Register Src="~/UserControls/Employee/Membership/CV/uCharacteristicAndSocialLifeNav.ascx" TagName="uCharacteristicAndSocialLifeNav" TagPrefix="uc2" %>
<uc2:uCharacteristicAndSocialLifeNav id="UCharacteristicAndSocialLifeNav1" runat="server"></uc2:uCharacteristicAndSocialLifeNav>
<%@ Register Src="~/UserControls/Common/ModalPopup/ModalPopup.ascx" TagName="ModalPopup"
    TagPrefix="uc1" %>
    

<uc1:ModalPopup ID="ShowModal" runat="server" Visible="false" />

<script type="text/javascript">
    function OpenCloseOther(OtherID) {
        var ddlID = '<%=lbComputerKnowledgeTypes.ClientID %>';
        if (ddlSelectedValue(ddlID) == OtherID) { $get('dvOther').style.display='block'; $get(ddlID).selectedIndex = -1; }
        else $get('dvOther').style.display='none';
    }
</script>

<div class="ContentColB">
    <h1>
        Bilgisayar bilgisi</h1>
    <p>
        Lütfen bildiðiniz bilgisayar programlarýný belirtin.
    </p>
    <p>
        &nbsp;</p>
    <table class="FormTable">
        <tr>
            <td align="right" valign="top">
                <p>
                    <strong>Bildiðiniz programlar </strong>
                </p>
            </td>
            <td>
                <table width="100%">
                    <tr>
                        <td valign="top">
                            <asp:ListBox Width="175" Height="160" runat="server" ID="lbComputerKnowledgeTypes" SelectionMode="Multiple"></asp:ListBox>
                            <div id="dvOther" style="display: none;">
                                <p class="mute">
                                    Aþaðýdaki alaný doldurunuz.</p>
                                <asp:TextBox runat="server" ID="txtOtherType" MaxLength="64" Width="175"></asp:TextBox>
                            </div>
                        </td>
                        <td valign="top">
                            <p>
                                <asp:Image runat="server" ID="imgAddToList" ImageUrl="~/Images/buttons/add_to_list.png" /><br />
                                <br />
                                <asp:Image runat="server" ID="imgRemoveToList" ImageUrl="~/Images/buttons/remove_from_list.png" />
                            </p>
                        </td>
                        <td valign="top">
                            <asp:ListBox Width="200" Height="210" runat="server" ID="lbSelectedComputerKnowledgeTypes" SelectionMode="Multiple"></asp:ListBox>
                        </td>
                    </tr>
                </table>
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
        ImageUrl="~/Images/buttons/continue.png" BorderWidth="0" OnClick="ImgBtnContinue_Click" />
        <asp:ImageButton runat="server" ID="ImgBtnSave" AlternateText="Kaydet" 
        ImageUrl="~/Images/buttons/corp_update_and_save_employee.png" BorderWidth="0" OnClick="ImgBtnContinue_Click" ValidationGroup="vgForm" />
    </p>
</div>

<div id="dvScript" runat="server"></div>