<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uCompanyInfo.ascx.cs"
    Inherits="UserControls_Company_Membership_uCompanyInfo" %>
<%@ Register Src="../../Common/uImageUpload.ascx" TagName="uImageUpload" TagPrefix="uc1" %>
<div class="contentPad">
    <div class="HeaderPR floatLeft">
        <h2 class="sIFRHeader">
            <asp:Literal runat="server" ID="ltlNewUser" Text="Yeni �yelik"></asp:Literal>
            <asp:Literal runat="server" ID="ltlEditUser" Text="�yelik Bilgilerim" Visible="false"></asp:Literal>
        </h2>
    </div>
    <div class="brclear">
    </div>
    <!-- start roundcornered box -->
    <asp:Panel runat="server" ID="pnlCompanyInformation" DefaultButton="imgContinue">
        <div class="BoxContentTop">
        </div>
        <div class="BoxContent">
            <div class="BoxPadder">
                <table width="100%" class="FormTable">
                    <tr>
                        <td colspan="3">
                            <p class="infoMsg">
                                <asp:Literal runat="server" ID="ltlDescription">
                      L�tfen t�m alanlar� doldurunuz. Bilgiler tamamland�ktan 
                      sonra taraf�n�za aktivasyon mesaj� g�nderilecektir.
                                </asp:Literal>
                                <asp:Literal runat="server" ID="ltlDescriptionEdit" Visible="false">
                                �yelik bilgilerinde yapmak istedi�iniz de�i�iklikler i�in m��teri temsilcinize e-mail g�ndermeniz gerekmektedir
                                </asp:Literal>
                            </p>
                            <asp:Panel runat="server" ID="pnlError" Visible="false">
                                <p class="infoMsg">
                                    <asp:Literal runat="server" ID="errTitleError" Text="HATA! "></asp:Literal>
                                    <asp:Label CssClass="Error" runat="server" ID="ltlError">
                                    </asp:Label>
                                </p>
                            </asp:Panel>
                            <asp:Panel runat="server" ID="pnlSuccess" Visible="false">
                                <p class="infoMsg">
                                    <asp:Label CssClass="Error" runat="server" ID="ltlSuccess">
                                    </asp:Label>
                                </p>
                            </asp:Panel>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <p>
                                <strong>Firman�z�n ad�:</strong></p>
                        </td>
                        <td>
                            <asp:TextBox runat="server" MaxLength="64" ID="txtCompanyName" CssClass="TextBox"
                                Width="220"></asp:TextBox>
                        </td>
                        <td>
                            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Display="None"
                                ErrorMessage="L�tfen �irket Ad�n� Giriniz" SetFocusOnError="True" ValidationGroup="vgCompanyInfo"
                                ControlToValidate="txtCompanyName"></asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td align="right">
                            <p>
                                <strong>Firman�z�n Logosu:</strong></p>
                        </td>
                        <td>
                            <uc1:uImageUpload ID="UImageUpload1" runat="server"></uc1:uImageUpload>
                        </td>
                        <td>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <p>
                                <strong>Firman�z�n sekt�r�:</strong></p>
                        </td>
                        <td>
                            <table width="100%">
                                <tr>
                                    <td valign="top">
                                        <asp:ListBox Width="200" Height="180" runat="server" ID="lbSectors" SelectionMode="Multiple">
                                        </asp:ListBox>
                                    </td>
                                    <td>
                                        <p>
                                            <asp:Image runat="server" ID="imgAddToListSector" ImageUrl="~/Images/buttons/add_to_list.png" /><br />
                                            <br />
                                            <asp:Image runat="server" ID="imgRemoveToListSector" ImageUrl="~/Images/buttons/remove_from_list.png" />
                                        </p>
                                    </td>
                                    <td valign="top">
                                        <asp:ListBox Width="200" Height="180" runat="server" ID="lbSelectedSectors" SelectionMode="Multiple">
                                        </asp:ListBox>
                                        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Display="None"
                                            ErrorMessage="L�tfen En Az Bir Sekt�r Se�iniz" SetFocusOnError="True" ValidationGroup="vgCompanyInfo"
                                            ControlToValidate="lbSelectedSectors"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                            </table>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td align="right">
                            <p>
                                <strong>Firman�z�n tan�m�:</strong></p>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtCompanyDescription" TextMode="MultiLine" Rows="3"
                                Width="420" MaxLength="1024"></asp:TextBox>
                        </td>
                        <td>
                            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" Display="None"
                                ErrorMessage="L�tfen �irket Tan�m�n� Giriniz" SetFocusOnError="True" ValidationGroup="vgCompanyInfo"
                                ControlToValidate="txtCompanyDescription"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <p>
                                <strong>�al��an say�s�:</strong></p>
                        </td>
                        <td>
                            <asp:TextBox runat="server" MaxLength="8" ID="txtNumberOfWorkers" CssClass="TextBox"
                                Width="80"></asp:TextBox>
                        </td>
                        <td>
                            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" Display="None"
                                ErrorMessage="L�tfen �al��an Say�s�n� Giriniz" SetFocusOnError="True" ValidationGroup="vgCompanyInfo"
                                ControlToValidate="txtNumberOfWorkers"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtNumberOfWorkers"
                                Display="None" ErrorMessage="L�tfen �al��an Say�s� Olarak Bir Say� Giriniz" SetFocusOnError="True"
                                ValidationExpression="[0-9]+" ValidationGroup="vgCompanyInfo"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <p>
                                <strong>Firma yetkilisi ad�:</strong></p>
                        </td>
                        <td>
                            <asp:TextBox runat="server" MaxLength="32" ID="txtContactName" CssClass="TextBox"
                                Width="220"></asp:TextBox>
                        </td>
                        <td>
                            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" Display="None"
                                ErrorMessage="L�tfen Firma Yetkilisini Giriniz" SetFocusOnError="True" ValidationGroup="vgCompanyInfo"
                                ControlToValidate="txtContactName"></asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td align="right">
                            <p>
                                <strong>Firma yetkilisi soyad�:</strong></p>
                        </td>
                        <td>
                            <asp:TextBox runat="server" MaxLength="32" ID="txtContactLastName" CssClass="TextBox"
                                Width="220"></asp:TextBox>
                        </td>
                        <td>
                            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" Display="None"
                                ErrorMessage="L�tfen Firma Yetkilisini Giriniz" SetFocusOnError="True" ValidationGroup="vgCompanyInfo"
                                ControlToValidate="txtContactLastName"></asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td align="right">
                            <p>
                                <strong>Telefon numaran�z:</strong></p>
                        </td>
                        <td>
                            <asp:TextBox runat="server" MaxLength="20" ID="txtPhoneNumber" CssClass="TextBox"
                                Width="220"></asp:TextBox>
                        </td>
                        <td>
                            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" Display="None"
                                ErrorMessage="L�tfen Telefon Numaras�n� Giriniz" SetFocusOnError="True" ValidationGroup="vgCompanyInfo"
                                ControlToValidate="txtPhoneNumber"></asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td align="right">
                            <p>
                                <strong>Fax numaran�z:</strong></p>
                        </td>
                        <td>
                            <asp:TextBox runat="server" MaxLength="20" ID="txtFaxNumber" CssClass="TextBox" Width="220"></asp:TextBox>
                        </td>
                        <td>
                            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" Display="None"
                                ErrorMessage="L�tfen Fax Numaras�n� Giriniz" SetFocusOnError="True" ValidationGroup="vgCompanyInfo"
                                ControlToValidate="txtFaxNumber"></asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td align="right">
                            <p>
                                <strong>E-posta adresiniz:</strong></p>
                        </td>
                        <td>
                            <asp:TextBox MaxLength="64" runat="server" ID="txtEMail" CssClass="TextBox" Width="220"></asp:TextBox>
                        </td>
                        <td>
                            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" Display="None"
                                ErrorMessage="L�tfen E-Posta Adresinizi Giriniz" SetFocusOnError="True" ValidationGroup="vgCompanyInfo"
                                ControlToValidate="txtEMail"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEMail"
                                Display="None" ErrorMessage="L�tfen E-Posta Adresini D�zg�n Giriniz" SetFocusOnError="True"
                                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="vgCompanyInfo"></asp:RegularExpressionValidator></td>
                    </tr>
                    <tr>
                        <td align="right">
                            <p>
                                <strong>Gizli Sorunuz:</strong></p>
                        </td>
                        <td>
                            <asp:TextBox runat="server" MaxLength="128" ID="txtSecretQuestion" CssClass="TextBox"
                                Width="220"></asp:TextBox>
                        </td>
                        <td>
                            &nbsp;<asp:RequiredFieldValidator ID="rqrSecretQuestion" runat="server" Display="None"
                                ErrorMessage="L�tfen Gizli Sorunuzu Giriniz" SetFocusOnError="True" ValidationGroup="vgCompanyInfo"
                                ControlToValidate="txtSecretQuestion"></asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td align="right">
                            <p>
                                <strong>Gizli Cevab�n�z:</strong></p>
                        </td>
                        <td>
                            <asp:TextBox runat="server" MaxLength="128" ID="txtSecretAnswer" CssClass="TextBox"
                                Width="220"></asp:TextBox>
                        </td>
                        <td>
                            &nbsp;<asp:RequiredFieldValidator ID="rqrSecretAnswer" runat="server" Display="None"
                                ErrorMessage="L�tfen Gizli Sorunuzun Cevab�n� Giriniz" SetFocusOnError="True"
                                ValidationGroup="vgCompanyInfo" ControlToValidate="txtSecretAnswer"></asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            &nbsp;<asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True"
                                ShowSummary="False" ValidationGroup="vgCompanyInfo" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td colspan="2">
                            <asp:ImageButton ValidationGroup="vgCompanyInfo" runat="server" ID="imgContinue"
                                AlternateText="Devam Et" BorderWidth="0" ImageUrl="~/Images/buttons/continue.png"
                                OnClick="imgContinue_Click" />
                        </td>
                    </tr>
                </table>
                <div class="brclear">
                </div>
            </div>
        </div>
        <div class="BoxContentBottom">
        </div>
    </asp:Panel>
    <asp:Panel runat="server" ID="pnlCompanyDetails" DefaultButton="imgContinue">
        <div class="BoxContentTop">
        </div>
        <div class="BoxContent">
            <div class="BoxPadder">
                <table width="100%" class="FormTable">
                    <tr>
                        <td colspan="3">
                            <p class="infoMsg">
                                <asp:Literal runat="server" ID="ltlCompanyDetailsDescription">
                                    �yelik bilgilerinde yapmak istedi�iniz de�i�iklikler i�in m��teri temsilcinize e-mail g�ndermeniz gerekmektedir
                                </asp:Literal>
                            </p>
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <p>
                                <strong>Firman�z�n ad�:</strong></p>
                        </td>
                        <td>
                            <asp:Label runat="server" ID="lblCompanyName"></asp:Label>
                        </td>
                        <td>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <p>
                                <strong>Firman�z�n Logosu:</strong></p>
                        </td>
                        <td>
                            <asp:Image ID="imgCompanyDetailLogo" runat="server" />
                        </td>
                        <td>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <p>
                                <strong>Firman�z�n sekt�r�:</strong></p>
                        </td>
                        <td>
                            <asp:Repeater ID="rptSectors" runat="server">
                                <ItemTemplate>
                                    <table width="100%">
                                        <tr>
                                            <td>
                                                <asp:Label ID="lbSectorName" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "SectorName")%>'></asp:Label>
                                            </td>
                                        </tr>
                                    </table>
                                </ItemTemplate>
                            </asp:Repeater>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td align="right">
                            <p>
                                <strong>Firman�z�n tan�m�:</strong></p>
                        </td>
                        <td>
                            <asp:Label ID="lblCompanyDescription" runat="server"></asp:Label>
                        </td>
                        <td>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <p>
                                <strong>�al��an say�s�:</strong></p>
                        </td>
                        <td>
                            <asp:Label ID="lblNumberOfWorkers" runat="server"></asp:Label>
                        </td>
                        <td>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <p>
                                <strong>Firma yetkilisi ad�:</strong></p>
                        </td>
                        <td>
                            <asp:Label ID="lblCompanyContactFirstName" runat="server"></asp:Label>
                        </td>
                        <td>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <p>
                                <strong>Firma yetkilisi soyad�:</strong></p>
                        </td>
                        <td>
                            <asp:Label ID="lblCompanyContactLastName" runat="server"></asp:Label>
                        </td>
                        <td>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <p>
                                <strong>Telefon numaran�z:</strong></p>
                        </td>
                        <td>
                            <asp:Label ID="lblCompanyPhoneNumber" runat="server"></asp:Label>
                        </td>
                        <td>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <p>
                                <strong>Fax numaran�z:</strong></p>
                        </td>
                        <td>
                            <asp:Label ID="lblCompanyFaxNumber" runat="server"></asp:Label>
                        </td>
                        <td>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <p>
                                <strong>E-posta adresiniz:</strong></p>
                        </td>
                        <td>
                            <asp:Label ID="lblEmail" runat="server"></asp:Label>
                        </td>
                        <td>
                        </td>
                    </tr>
                </table>
                <div class="brclear">
                </div>
            </div>
        </div>
        <div class="BoxContentBottom">
        </div>
    </asp:Panel>
    <!-- finish roundcornered box -->
    <p>
        &nbsp;</p>
</div>
