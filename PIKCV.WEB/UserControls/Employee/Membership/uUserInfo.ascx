<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uUserInfo.ascx.cs" Inherits="UserControls_Employee_Signup_uUserInfo" %>
<%@ Register Src="../Common/uCVTabs.ascx" TagName="uCVTabs" TagPrefix="uc1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

 <script type="text/javascript"> 
function cvAggreement(source, args) 
{   
    args.IsValid = false;
    if (theForm.chAggreement.checked) { args.IsValid = true; }
}

function cvPrivacy(source, args) 
{   
    args.IsValid = false;
    if (theForm.chPrivacy.checked) { args.IsValid = true; }
}

function cvPassword(source, args)
{   
    args.IsValid = false;
    if (document.getElementById('<%=txtPassword.ClientID %>').value.length>5) { args.IsValid = true; }
}

function cvIdentityNo(source, args) {
    args.IsValid= false;
    if (document.getElementById('<%=txtIdentityNo.ClientID %>').value.length==11) { args.IsValid = true; }
}

</script> 

<div class="contentPad">
  <div class="HeaderPR floatLeft">
    <h2 class="sIFRHeader">
    <asp:Literal ID="ltlTitle" runat="server">Yeni Üyelik</asp:Literal>
    <asp:Literal ID="ltlTitle2" runat="server" Visible="false"></asp:Literal>
    <asp:Literal ID="ltlTitle3" runat="server" Visible="false">Üyelik Güncelleme</asp:Literal>
    </h2>
  </div>
    <uc1:uCVTabs ID="UCVTabs1" runat="server" />
    
  <div class="brclear"></div>
  <!-- start roundcornered box -->
  
  <asp:Panel runat="server" ID="pnlForm" DefaultButton="imgContinue">
  
  <div class="BoxContentTop"></div>
  <div class="BoxContent">
    <div class="BoxPadder">
    
        <table width="100%">
            <tr runat="server" id="trMsg">
                <td colspan="2" style="padding-bottom: 10px;">
                        <div class="infoMsg">
                            <p>
                                <asp:Literal runat="server" ID="ltlDescription">
                                  Lütfen tüm alanlarý doldurunuz. 
                                  Sitemize bireysel üyelik tamamen ücretsizdir.
                                </asp:Literal>
                            </p>
                        </div>
                    <asp:Panel runat="server" ID="pnlError" Visible="false">
                        <div class="infoMsg">
                            <p>
                                <asp:Literal runat="server" ID="errTitleError" Text="HATA! "></asp:Literal>
                                <asp:Label CssClass="Error" runat="server" ID="ltlError">
                                </asp:Label>
                            </p>
                        </div>
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td valign="top" style="padding-right: 15px;">  <asp:Image ID="imgUserPhoto" runat="server" Width="349" /> </td>
                <td align="center">
                    <asp:Panel ID="pnlEmployee" runat="server">
                    <table style="width: 100%; text-align: left;" class="FormTable">
                        <tr>
                            <td style="width: 150;"> <p> <strong>Adýnýz:</strong> </p> </td>
                            <td style="width: 65%">
                                <asp:TextBox Width="80%" runat="server" MaxLength="32" ID="txtName" CssClass="TextBox"></asp:TextBox> &nbsp;
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Display="None"
                                    ErrorMessage="Lütfen Adýnýzý Giriniz" SetFocusOnError="True" ValidationGroup="vgUserInfo" ControlToValidate="txtName"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td><p><strong>Soyadýnýz:</strong></p></td>
                            <td> <asp:TextBox Width="80%" MaxLength="32" runat="server" ID="txtSurName" CssClass="TextBox"></asp:TextBox> &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Display="None"
                                  ErrorMessage="Lütfen Soy Adýnýzý Giriniz" SetFocusOnError="True" ValidationGroup="vgUserInfo" ControlToValidate="txtSurName"></asp:RequiredFieldValidator></td>
                        </tr>
                        <tr>
                            <td> <p><strong>E-postanýz:</strong></p> </td>
                            <td> <asp:TextBox Width="80%" MaxLength="64" runat="server" ID="txtEMail" CssClass="TextBox"></asp:TextBox> &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" Display="None"
                                  ErrorMessage="Lütfen E-Posta Adresinizi Giriniz" SetFocusOnError="True" ValidationGroup="vgUserInfo" 
                                  ControlToValidate="txtEMail"></asp:RequiredFieldValidator>
                              <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEMail"
                                  Display="None" ErrorMessage="Lütfen E-Posta Adresini Düzgün Giriniz" SetFocusOnError="True"
                                  ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="vgUserInfo"></asp:RegularExpressionValidator></td>
                        </tr>
                        <tr>
                            <td> 
                                <p><strong>TC Kimlik No:</strong></p> </td>
                            <td> <asp:TextBox Width="80%" MaxLength="11" runat="server" ID="txtIdentityNo" CssClass="TextBox"></asp:TextBox> </td>
                        </tr>        
                        <tr>
                            <td colspan="2">
                            
                            <span class="mute">(TC Vatandaþý olmayanlar pasaport numarasýný girmelidir)<br />
                            TC Kimlik numaranýzý öðrenmek için <a href="http://tckimlik.nvi.gov.tr" target="_blank">týklayýnýz</a></span>          
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3_" runat="server" Display="None"
                                ErrorMessage="Lütfen Kimlik Numaranýzý Giriniz" SetFocusOnError="True" ValidationGroup="vgUserInfo" 
                                ControlToValidate="txtIdentityNo"></asp:RequiredFieldValidator>
                            <asp:CustomValidator ID="CustomValidatorIdentity" runat="server" Display="None"
                            ClientValidationFunction="cvIdentityNo" ValidationGroup="vgUserInfo"
                            ErrorMessage="Lütfen Kimlik Numarasýnýz Düzgün Giriniz."></asp:CustomValidator>                
                            
                            </td>
                        </tr>
                        <tr>
                            <td> 
                                <p><strong>Þifre:</strong></p> </td>
                            <td> 
                                <asp:TextBox Width="80%" runat="server" MaxLength="20" TextMode="Password" ID="txtPassword" CssClass="TextBox"></asp:TextBox> </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                            
                                <span class="mute"> Þifre en az altý karakter olmalýdýr, karakterler için harf veya <br />numara kullanýlabilir </span>
                                
                                <asp:RequiredFieldValidator ID="rqrPass" runat="server"
                                Display="None" ErrorMessage="Lütfen Þifrenizi Giriniz" SetFocusOnError="True"
                                ValidationGroup="vgUserInfo" ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
                                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPassword"
                                ControlToValidate="txtPassword2" Display="None" ErrorMessage="Ýki þifre birbiri ile ayný olmalýdýr"
                                SetFocusOnError="True" ValidationGroup="vgUserInfo"></asp:CompareValidator>
                                                                
                                <asp:CustomValidator ID="CustomValidatorPassword" runat="server" Display="None"
                                ClientValidationFunction="cvPassword" ValidationGroup="vgUserInfo"
                                ErrorMessage="Þifreniz En Az 6 Karakter Olmalýdýr"></asp:CustomValidator>                
                            
                            </td>
                        </tr>
                        <tr>
                            <td> <p><strong>Þifre (tekrar):</strong></p> </td>
                            <td> <asp:TextBox Width="80%" MaxLength="20" runat="server" TextMode="Password" ID="txtPassword2" CssClass="TextBox"></asp:TextBox>
                                
                                <asp:RequiredFieldValidator ID="rqrPass2" runat="server" ControlToValidate="txtPassword2" Display="None" 
                                ErrorMessage="Lütfen Þifrenizi Tekrar Giriniz" SetFocusOnError="True"
                                ValidationGroup="vgUserInfo"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                        
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtPrivateQuestion"
                                Display="None" ErrorMessage="Lütfen Gizli Sorunuzu Giriniz" SetFocusOnError="True"
                                ValidationGroup="vgUserInfo"></asp:RequiredFieldValidator>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtPrivateAnswer"
                                Display="None" ErrorMessage="Lütfen Gizli Soru Cevabýnýzý Giriniz" SetFocusOnError="True"
                                ValidationGroup="vgUserInfo"></asp:RequiredFieldValidator>
                                <span class="mute">Þifrenizi unutmanýz durumunda bu bilgiler size sorulacak ve <br />þifreniz girmiþ olduðunuz e-posta adresinize sistem tarafýndan otomatik olarak gönderilecektir.</span>                
                            
                            </td>
                        </tr>
                        <tr>
                            <td> <p><strong>Gizli soru:</strong></p> </td>
                            <td> <asp:TextBox Width="80%" MaxLength="128" runat="server" ID="txtPrivateQuestion" CssClass="TextBox"></asp:TextBox> </td>
                        </tr>
                        <tr>
                            <td> <p><strong>Gizli soru cevabý:</strong></p> </td>
                            <td> <asp:TextBox Width="80%" runat="server" MaxLength="128" ID="txtPrivateAnswer" CssClass="TextBox"></asp:TextBox> </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:CheckBox runat="server" ID="chIsWantedSMS" Text="SMS Gönderimi Ýstermisiniz" /> <br /><br />
                                
                                <asp:Panel runat="server" ID="pnlPrivacy">
                                
                                <p class="mute"> Lütfen Üyelik sözleþmesini ve gizlilik ve kullaným þartlarý sözleþmesini  okuyunuz. </p>
                                <p>         
                                    <input type="checkbox" checked="checked" id="chAggreement" value="ON" />
                                    <asp:CustomValidator ID="CustomValidator1" runat="server" Display="None"
                                    ClientValidationFunction="cvAggreement" ValidationGroup="vgUserInfo"
                                    ErrorMessage="Üyelik Sözleþmesini Kabul Etmeniz Gerekmektedir"></asp:CustomValidator>

                                    <a href="javascript:OpenAgreement()">Üyelik Sözleþmesini</a> okudum ve kabul ediyorum.
                                </p>
                                    
                                <p>
                                    <input type="checkbox" checked="checked" id="chPrivacy" value="ON" />
                                    <asp:CustomValidator ID="CustomValidator2" runat="server" Display="None"
                                    ClientValidationFunction="cvPrivacy" ValidationGroup="vgUserInfo"
                                    ErrorMessage="Gizlilik Anlaþmasýný ve Kullaným Þartlarýný Kabul Etmeniz Gerekmektedir"></asp:CustomValidator>
                                 
                                    <a href="javascript:OpenPrivacy()">Gizlilik Anlaþmasý - Kullaným Þartlarýný</a> 
                                    okudum ve kabul ediyorum.
                                </p>
                                
                                </asp:Panel>
                                
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" ShowSummary="False" ValidationGroup="vgUserInfo" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" style="text-align: right; padding-right: 40px;">
                                <asp:ImageButton ValidationGroup="vgUserInfo" runat="server" ID="imgContinue" AlternateText="Devam Et" BorderWidth="0" ImageUrl="~/Images/buttons/continue.png" OnClick="imgContinue_Click" />
                            </td>
                        </tr>  
                          <tr runat="server" id="trRemoveUser">
                            <td colspan="2">
                                
                                <asp:HyperLink 
                                NavigateUrl=""
                                ID="hlRemoveUser" runat="server" Text="» Üyelikten çýkmak istiyorum"></asp:HyperLink>
                            </td>
                          </tr>                                              
                    </table>
                    </asp:Panel>
                    <asp:Panel ID="pnlCompany" runat="server" Visible="False">
                        <table width="100%" class="FormTable" style="text-align: left;">
                  <tr>
                    <td width="120" align="right"><p><strong><asp:Label ID="lblPersonnelNameHeader" runat="server" Text="Ad:"></asp:Label></strong></p></td>
                    <td>
                        <asp:Label ID="lblName" runat="server" Text=""></asp:Label></td>
                  </tr>
                  <tr>
                    <td align="right" style="height: 29px"><p><strong><asp:Label ID="lblPersonnelSurnameHeader" runat="server" Text="Soyad:"></asp:Label></strong></p></td>
                    <td style="height: 29px">
                        <asp:Label ID="lblSurName" runat="server" Text=""></asp:Label></td>
                  </tr>
                  
                  <tr>
                    <td align="right"><p><strong>Yaþ:</strong></p></td>
                    <td>
                        <asp:Label ID="lblAge" runat="server" Text=""></asp:Label></td>
                  </tr>
                  
                  <tr runat="server" id="trAddress" visible="false">
                    <td align="right" style="height: 29px" valign="top"><p><strong>Adres:</strong></p></td>
                    <td style="height: 29px">
                        <asp:Label ID="lblAddress" runat="server" Text=""></asp:Label></td>
                  </tr>
                  
                  <tr runat="server" id="trPhoto" visible="false">
                    <td align="right"><p><strong>Telefon:</strong></p></td>
                    <td>
                        <asp:Label ID="lblPhone" runat="server" Text=""></asp:Label></td>
                  </tr>                  
                  
                  <tr runat="server" id="trEmail" visible="false">
                    <td align="right"><p><strong>Eposta:</strong></p></td>
                    <td>
                        <asp:Label ID="lblEmail" runat="server" Text=""></asp:Label></td>
                  </tr>                   
                  
                  <tr>
                    <td align="right" style="height: 21px"><p><strong>Tecrübe:</strong></p></td>
                    <td style="height: 21px">
                        <asp:Literal ID="ltlTotalWorkExperience" runat="server"></asp:Literal>
                        Yýl</td>
                  </tr>
                  <tr>
                    <td align="right" valign="top"><p><strong>Pozisyon:</strong></p></td>
                    <td>
                        <asp:Repeater ID="rptUserPositions" runat="server">
                            <ItemTemplate>
                                <%#DataBinder.Eval(Container.DataItem, "PositionName") %>
                            </ItemTemplate>
                            <SeparatorTemplate>
                                <br />
                            </SeparatorTemplate>
                        </asp:Repeater>
                    </td>
                  </tr>
                  <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                  </tr>
                  <tr>
                    <td>&nbsp;</td>
                    <td>
                       <asp:ImageButton ID="imgBuyContactInfo" runat="server" ImageUrl="~/Images/buttons/corp_buy_info.png" OnClick="imgBuyContactInfo_Click" />
                      <ul class="FamLinks">    
                            <asp:DropDownList ID="ddlCompanyFolders" runat="server"></asp:DropDownList>
                            
                            <asp:ValidationSummary ID="vs1" runat="server" DisplayMode="SingleParagraph"
                                ShowMessageBox="True" ShowSummary="False" ValidationGroup="vgSelFolder" />
                            
                            <asp:RequiredFieldValidator ID="rqrSelFolder" runat="server" ControlToValidate="ddlCompanyFolders"
                                CssClass="Error" Display="None" ErrorMessage="Lütfen klasör seçiniz" InitialValue="0"
                                ValidationGroup="vgSelFolder"></asp:RequiredFieldValidator>
                                
                        <li class="SendToFile" id="liSentToFile" runat="server">
                            
                            <asp:LinkButton ID="lnkSendToFolder" runat="server" OnClick="lnkSendToFolder_Click" ValidationGroup="vgSelFolder">Seçili Klasöre Gönder</asp:LinkButton>                            
                            
                        </li>
                        <li class="Interview" id="liInterview" runat="server">
                            <asp:LinkButton ID="lbInterview" runat="server" OnClick="lbInterview_Click">Mülakata Çaðýr</asp:LinkButton>
                        </li>
                        <li class="SendMessage" id="liSendMessage" runat="server">
                            <asp:LinkButton ID="lbSendMessage" runat="server" OnClick="lbSendMessage_Click">Mesaj Gönder</asp:LinkButton>
                        </li>
  <%--                      <li class="Print">
                            <asp:LinkButton ID="lbPrint" runat="server" OnClick="lbPrint_Click">Yazdýr</asp:LinkButton>
                        </li>--%>
                      </ul>
                    </td>
                  </tr>
                  
                </table>
                    </asp:Panel>                    
                </td>
            </tr>
        </table>
    
      <div class="brclear"></div>
    </div>
  </div>
  <div class="BoxContentBottom"></div>
  
  </asp:Panel>
  <div id="dvScript" runat="server"></div>
  <!-- finish roundcornered box -->
  <p>&nbsp;</p>
</div>