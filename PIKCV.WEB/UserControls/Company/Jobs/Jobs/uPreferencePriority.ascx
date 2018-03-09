<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uPreferencePriority.ascx.cs"
    Inherits="UserControls_Company_Jobs_Jobs_uPreferencePriority" %>
    
<script type="text/javascript">

    function CompareCtrl(Value1, Value2, Value3) {
        return ((Value1 == 0) || ((Value1 != Value2) && (Value1 != Value3)) && ((Value2 != Value3) || ((Value2 == 0) && (Value3 == 0))));
    }

    function cvPreferenceEducationCtrl(source, args)  {    
        var ddlEd1 = ddlSelectedValue('<%=drpEducationLevel1.ClientID %>');
        var ddlEd2 = ddlSelectedValue('<%=drpEducationLevel2.ClientID %>');
        var ddlEd3 = ddlSelectedValue('<%=drpEducationLevel3.ClientID %>');
        args.IsValid = CompareCtrl(ddlEd1, ddlEd2, ddlEd3);
    }
    function cvPreferenceEducationLevelCtrl(source, args)  {    
        var ddlEd1 = ddlSelectedValue('<%=drpEducationLevel1ChoiceLevel1.ClientID %>');
        var ddlEd2 = ddlSelectedValue('<%=drpEducationLevel1ChoiceLevel2.ClientID %>');
        var ddlEd3 = ddlSelectedValue('<%=drpEducationLevel1ChoiceLevel3.ClientID %>');
        args.IsValid = CompareCtrl(ddlEd1, ddlEd2, ddlEd3);
    }

    
    function cvPreferencePositionsCtrl(source, args)  {
        var ddlPos1 = ddlSelectedValue('<%=drpPositions1.ClientID %>');
        var ddlPos2 = ddlSelectedValue('<%=drpPositions2.ClientID %>');
        var ddlPos3 = ddlSelectedValue('<%=drpPositions3.ClientID %>');
        args.IsValid = CompareCtrl(ddlPos1, ddlPos2, ddlPos3);
    }
    function cvPreferencePositionsLevelCtrl(source, args)  {    
        var ddlPos1 = ddlSelectedValue('<%=drpWorkExperianceChoiceLevel1.ClientID %>');
        var ddlPos2 = ddlSelectedValue('<%=drpWorkExperianceChoiceLevel2.ClientID %>');
        var ddlPos3 = ddlSelectedValue('<%=drpWorkExperianceChoiceLevel3.ClientID %>');
        args.IsValid = CompareCtrl(ddlPos1, ddlPos2, ddlPos3);
    }


    function cvPreferenceForeignLangCtrl(source, args)  {
        var ddlLang1 = ddlSelectedValue('<%=drpForeignLanguage1.ClientID %>');
        var ddlLang2 = ddlSelectedValue('<%=drpForeignLanguage2.ClientID %>');
        var ddlLang3 = ddlSelectedValue('<%=drpForeignLanguage3.ClientID %>');
        args.IsValid = CompareCtrl(ddlLang1, ddlLang2, ddlLang3);
    }
    function cvPreferenceForeignLangLevelCtrl(source, args)  {
        var ddlLang1 = ddlSelectedValue('<%=drpForeignLanguageChoiceLevel1.ClientID %>');
        var ddlLang2 = ddlSelectedValue('<%=drpForeignLanguageChoiceLevel2.ClientID %>');
        var ddlLang3 = ddlSelectedValue('<%=drpForeignLanguageChoiceLevel3.ClientID %>');
        args.IsValid = CompareCtrl(ddlLang1, ddlLang2, ddlLang3);
    }
    
    function cvPreferenceForeignLangReadWriteTalkCtrl(source, args)  { 
        args.IsValid = fnPreferenceForeignLangReadWriteTalkCtrl();
    }
    
    function fnPreferenceForeignLangReadWriteTalkCtrl()  {
        var ddlLang1 = ddlSelectedValue('<%=drpForeignLanguage1.ClientID %>');
        var ddlLang1Read = ddlSelectedValue('<%=drpReadLevel1.ClientID %>');
        var ddlLang1Write = ddlSelectedValue('<%=drpWriteLevel1.ClientID %>');
        var ddlLang1Talk = ddlSelectedValue('<%=drpTalkLevel1.ClientID %>');

        var ddlLang2 = ddlSelectedValue('<%=drpForeignLanguage2.ClientID %>');
        var ddlLang2Read = ddlSelectedValue('<%=drpReadLevel2.ClientID %>');
        var ddlLang2Write = ddlSelectedValue('<%=drpWriteLevel2.ClientID %>');
        var ddlLang2Talk = ddlSelectedValue('<%=drpTalkLevel2.ClientID %>');
                
        var ddlLang3 = ddlSelectedValue('<%=drpForeignLanguage3.ClientID %>');
        var ddlLang3Read = ddlSelectedValue('<%=drpReadLevel3.ClientID %>');
        var ddlLang3Write = ddlSelectedValue('<%=drpWriteLevel3.ClientID %>');
        var ddlLang3Talk = ddlSelectedValue('<%=drpTalkLevel3.ClientID %>');

        if (ddlLang1 != 0) {
            if ((ddlLang1Read == "-1") || (ddlLang1Write == "-1") || (ddlLang1Talk == "-1")) {
                return false;
            }
        }
        if (ddlLang2 != 0) { 
            if ((ddlLang2Read == "-1") || (ddlLang2Write == "-1") || (ddlLang2Talk == "-1")) {
                return false;
            }
        }
        if (ddlLang3 != 0) { 
            if ((ddlLang3Read == "-1") || (ddlLang3Write == "-1") || (ddlLang3Talk == "-1")) {
                return false;
            }
        }
        return true;        
    }
    
</script>   
    
<table width="100%" class="FormTable">
    <tr>
        <td colspan="2">
            <div class="infoMsg">
                <p>
                    <asp:Literal runat="server" ID="ltlDescription">
�sterseniz a�a��da yer alan kriterleri puanlayarak ba�vurular�n�z� ald�klar� puana g�re de�erlendirebilirsiniz. <br />
Kriterlere puan verilmemesi durumunda ilgili kriter i�in puan de�erlendirmesi yap�lmayacakt�r. <br />
Puanlama: <b>3</b>-En �nemli <b>2</b>-�ok �nemli <b>1</b>- �nemli  
                    </asp:Literal>
                </p>
            </div>        
        </td>
    </tr>
    <tr>
        <td align="right" valign="top">
            &nbsp;</td>
        <td>
            <h1>
                Tercih puanlamas�
            </h1>
        </td>
    </tr>
    <tr>
        <td align="right" valign="top">
            <p>
                <strong>E�itim</strong></p>
        </td>
        <td>
            <table>
                <tr>
                    <td>
                        E�itim durumu</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        Puan</td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="drpEducationLevel1" runat="server"></asp:DropDownList>
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:DropDownList ID="drpEducationLevel1ChoiceLevel1" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="drpEducationLevel2" runat="server"></asp:DropDownList>
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:DropDownList ID="drpEducationLevel1ChoiceLevel2" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="drpEducationLevel3" runat="server"></asp:DropDownList>
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:DropDownList ID="drpEducationLevel1ChoiceLevel3" runat="server"></asp:DropDownList>
                    </td>
                </tr>
            </table>
        </td>
    </tr> 
    <tr>
        <td align="right" valign="top">
            <p>
                <asp:ValidationSummary runat="server" ID="vlsmryPreferencePriority" ShowMessageBox="true" ShowSummary="False" ValidationGroup="vgGroup" />

                <asp:CustomValidator ID="CustomValidatorEducation" runat="server" Display="none" 
                ClientValidationFunction="cvPreferenceEducationCtrl" ValidationGroup="vgGroup" 
                ErrorMessage="L�tfen E�itim Bilgilerini Farkl� Se�iniz" CssClass="Error">
                </asp:CustomValidator>
                <asp:CustomValidator ID="CustomValidatorEducationLevel" runat="server" Display="none" 
                ClientValidationFunction="cvPreferenceEducationLevelCtrl" ValidationGroup="vgGroup" 
                ErrorMessage="L�tfen Se�ti�iniz E�itim Bilgilerinin S�ralamalar�n� Farkl� Se�iniz" CssClass="Error">
                </asp:CustomValidator>
                
                <asp:CustomValidator ID="CustomValidatorPositions" runat="server" Display="none" 
                ClientValidationFunction="cvPreferencePositionsCtrl" ValidationGroup="vgGroup" 
                ErrorMessage="L�tfen Pozisyon Bilgilerini Farkl� Se�iniz" CssClass="Error">
                </asp:CustomValidator>
                <asp:CustomValidator ID="CustomValidatorPositionLevel" runat="server" Display="none" 
                ClientValidationFunction="cvPreferencePositionsLevelCtrl" ValidationGroup="vgGroup" 
                ErrorMessage="L�tfen Se�ti�iniz Pozisyon Bilgilerinin S�ralamalar�n� Farkl� Se�iniz" CssClass="Error">
                </asp:CustomValidator>
                
                <asp:CustomValidator ID="CustomValidatorForeignLang" runat="server" Display="none" 
                ClientValidationFunction="cvPreferenceForeignLangCtrl" ValidationGroup="vgGroup" 
                ErrorMessage="L�tfen Yabanc� Dilleri Farkl� Se�iniz" CssClass="Error">
                </asp:CustomValidator>
                <asp:CustomValidator ID="cvPreferenceForeignLangLevel" runat="server" Display="none" 
                ClientValidationFunction="cvPreferenceForeignLangLevelCtrl" ValidationGroup="vgGroup" 
                ErrorMessage="L�tfen Se�ti�iniz Yabanc� Dil Bilgilerinin S�ralamalar�n� Farkl� Se�iniz" CssClass="Error">
                </asp:CustomValidator>
                <asp:CustomValidator ID="cvPreferenceForeignLangReadWriteTalk" runat="server" Display="none" 
                ClientValidationFunction="cvPreferenceForeignLangReadWriteTalkCtrl" ValidationGroup="vgGroup" 
                ErrorMessage="L�tfen Se�ti�iniz Yabanc� Dilin Okuma Yazma ve Konu�ma S�ralamalar�n� Se�iniz" CssClass="Error">
                </asp:CustomValidator>
                
            <strong>�� Deneyimi</strong></p>
        </td>
        <td>
            <table>
                <tr>
                    <td>
                        Pozisyon
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        Puan</td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="drpPositions1" runat="server" Width="300"></asp:DropDownList></td>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:DropDownList ID="drpWorkExperianceChoiceLevel1" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="drpPositions2" runat="server" Width="300"></asp:DropDownList></td>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:DropDownList ID="drpWorkExperianceChoiceLevel2" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="drpPositions3" runat="server" Width="300"></asp:DropDownList></td>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:DropDownList ID="drpWorkExperianceChoiceLevel3" runat="server"></asp:DropDownList>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td align="right" valign="top">
            <p>
                <strong>Yabanc� dil bilgisi</strong></p>
        </td>
        <td>
            <table>
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
                    <td>
                        &nbsp;</td>
                    <td>
                        Puan</td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="drpForeignLanguage1" runat="server"></asp:DropDownList>
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:DropDownList ID="drpReadLevel1" runat="server"></asp:DropDownList>
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:DropDownList ID="drpWriteLevel1" runat="server"></asp:DropDownList>
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:DropDownList ID="drpTalkLevel1" runat="server"></asp:DropDownList>
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:DropDownList ID="drpForeignLanguageChoiceLevel1" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="drpForeignLanguage2" runat="server"></asp:DropDownList>
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:DropDownList ID="drpReadLevel2" runat="server"></asp:DropDownList>
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:DropDownList ID="drpWriteLevel2" runat="server"></asp:DropDownList>
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:DropDownList ID="drpTalkLevel2" runat="server"></asp:DropDownList>
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:DropDownList ID="drpForeignLanguageChoiceLevel2" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="drpForeignLanguage3" runat="server"></asp:DropDownList>
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:DropDownList ID="drpReadLevel3" runat="server"></asp:DropDownList>
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:DropDownList ID="drpWriteLevel3" runat="server"></asp:DropDownList>
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:DropDownList ID="drpTalkLevel3" runat="server"></asp:DropDownList>
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:DropDownList ID="drpForeignLanguageChoiceLevel3" runat="server"></asp:DropDownList>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td align="right">
            &nbsp;</td>
        <td>
                <asp:ImageButton ID="imgContinue" runat="server" ImageUrl="~/images/buttons/corp_continue.png"
                OnClick="imgContinue_Click" ValidationGroup="vgGroup" Visible="false" />
               <asp:ImageButton ID="imgSave" runat="server" ImageUrl="~/images/buttons/corp_update_and_save.png"
                OnClick="imgContinue_Click" ValidationGroup="vgGroup" Visible="false" />
        </td>
    </tr>
</table>
