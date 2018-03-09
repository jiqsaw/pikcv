<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uCVPreview.ascx.cs" Inherits="UserControls_Employee_Membership_uCVPreview" %>
<%@ Register Src="../Common/uCVTabs.ascx" TagName="uCVTabs" TagPrefix="uc1" %>

    <div class="contentPad">
      <div class="HeaderPR floatLeft">
        <h2 class="sIFRHeader">
            <asp:Literal runat="server" ID="ltlNewUser" Text="Yeni Üyelik"></asp:Literal>
            <asp:Literal runat="server" ID="ltlEditUser" Text="" Visible="false"></asp:Literal>        
        </h2>
      </div>

        <uc1:uCVTabs ID="UCVTabs1" runat="server" />
      
      <div class="brclear"></div>

      <!-- start roundcornered box -->
      <div class="BoxContentTop"></div>
           
        <div class="BoxContent">
        <div class="BoxPadder">
          <table width="100%" class="FormTable">
            <tr>
              <td><p class="infoMsg"> Son güncellenme tarihi: 
                <asp:Literal runat="server" ID="ltlModifyDate"></asp:Literal>
              </p></td>
            </tr>
          </table>
          <p>&nbsp;</p>
            <table width="100%">
                <tr>
                    <td valign="top" align="center">
                        <asp:Image runat="server" ImageUrl="~/Images/UserImages/Small/" ID="imgUserPhoto" Width="150" />
                    </td>
                    <td style="padding-left: 70px;">
                        <table width="100%" class="GenericTable">
                            <tr>
                                <td width="25%" align="right">
                                    &nbsp;</td>
                                <td width="75%">
                                    <h2>
                                        Kiþisel bilgiler</h2>
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <p>
                                        Adý:</p>
                                </td>
                                <td>
                                    <p>
                                        <asp:Literal runat="server" ID="ltlFirstName"></asp:Literal>
                                    </p>
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <p>
                                        Soyadý:</p>
                                </td>
                                <td>
                                    <p>
                                        <asp:Literal runat="server" ID="ltlLastName"></asp:Literal>
                                    </p>
                                </td>
                            </tr>
                            <tr runat="server" id="trMail">
                                <td align="right">
                                    <p>
                                        Email:</p>
                                </td>
                                <td>
                                    <p>
                                        <asp:Literal runat="server" ID="ltlEmail"></asp:Literal>
                                    </p>
                                </td>
                            </tr>                             
                            <tr>
                                <td align="right">
                                    <p>
                                        Uyruðu:</p>
                                </td>
                                <td>
                                    <p>
                                        <asp:Literal runat="server" ID="ltlNation"></asp:Literal>
                                    </p>
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <p>
                                        Doðum Tarihi:</p>
                                </td>
                                <td>
                                    <p>
                                        <asp:Literal runat="server" ID="ltlBirthDate"></asp:Literal></p>
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <p>
                                        Doðum Yeri:
                                    </p>
                                </td>
                                <td>
                                    <p>
                                        <asp:Literal runat="server" ID="ltlBirthPlace"></asp:Literal></p>
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <p>
                                        Cinsiyet:</p>
                                </td>
                                <td>
                                    <p>
                                        <asp:Literal runat="server" ID="ltlSex"></asp:Literal> </p>
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <p>
                                        Medeni Hali:
                                    </p>
                                </td>
                                <td>
                                    <p>
                                        <asp:Literal runat="server" ID="ltlMarital"></asp:Literal></p>
                                </td>
                            </tr>
                            <tr id="trMilitary" runat="server" visible="false">
                                <td align="right">
                                    <p>
                                        Askerlik Durumu:</p>
                                </td>
                                <td>
                                    <p>
                                        <asp:Literal runat="server" ID="ltlMilitary"></asp:Literal> &nbsp;
                                        <asp:Literal runat="server" ID="ltlMilitaryYear"></asp:Literal>
                                    </p>
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <p>
                                        Özel Durumlar:
                                    </p>
                                </td>
                                <td>
                                    <p>
                                        <asp:Literal runat="server" ID="ltlDisabled" Text="Engelliyim, " Visible="false"></asp:Literal>
                                        <asp:Literal runat="server" ID="ltlOldConvicted" Text="Eski hükümlüyüm, " Visible="false"></asp:Literal>
                                        <asp:Literal runat="server" ID="ltlMartyrRelative" Text="Þehit yakýnýyým, " Visible="false"></asp:Literal>
                                        <asp:Literal runat="server" ID="ltlTerrorWronged" Text="Terör Maðduruyum" Visible="false"></asp:Literal>
                                    </p>
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <p>
                                        Kronik Hastalýðý:
                                    </p>
                                </td>
                                <td>
                                    <p>
                                        <asp:Literal runat="server" ID="ltlChronicIllness"></asp:Literal></p>
                                </td>
                            </tr>
                        </table>
                        <p>&nbsp;</p>
                        <div class="hr">
                            <hr />
                        </div>
                        <p>&nbsp;</p>
                        <table id="tContact" runat="server" width="100%" class="GenericTable">
                            <tr>
                                <td width="25%" align="right" valign="top">
                                    &nbsp;</td>
                                <td width="75%" valign="top">
                                    <h2>
                                        Ýletiþim bilgileri</h2>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" valign="top">
                                    <p>
                                        Yaþadýðý Ülke:</p>
                                </td>
                                <td valign="top">
                                    <p>
                                        <asp:Literal runat="server" ID="ltlHomeCountry"></asp:Literal> </p>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" valign="top">
                                    <p>
                                        Yaþadýðý Þehir:</p>
                                </td>
                                <td valign="top">
                                    <p>
                                        <asp:Literal runat="server" ID="ltlHomeCity"></asp:Literal></p>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" valign="top">
                                    <p>
                                        Adresi:</p>
                                </td>
                                <td valign="top">
                                    <p>
                                        <asp:Literal runat="server" ID="ltlAddress"></asp:Literal></p>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" valign="top">
                                    <p>
                                        Ev Telefonu:</p>
                                </td>
                                <td valign="top">
                                    <p>
                                        <asp:Literal runat="server" ID="ltlHomePhone"></asp:Literal></p>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" valign="top" style="height: 21px">
                                    <p>
                                        Ýþ telefonu:</p>
                                </td>
                                <td valign="top" style="height: 21px">
                                    <p>
                                       <asp:Literal runat="server" ID="ltlBusinessPhone"></asp:Literal>
                                    </p>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" valign="top">
                                    <p>
                                        Cep telefonu:</p>
                                </td>
                                <td valign="top">
                                    <p>
                                        <asp:Literal runat="server" ID="ltlGSM"></asp:Literal>
                                    </p>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" valign="top">
                                    <p>
                                        Cep telefonu (diðer):</p>
                                </td>
                                <td valign="top">
                                    <p>
                                        <asp:Literal runat="server" ID="ltlGSM2"></asp:Literal>
                                    </p>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" valign="top">
                                    <p>
                                        Alternatif E-Posta:</p>
                                </td>
                                <td valign="top">
                                    <p>
                                        <asp:Literal runat="server" ID="ltlAlternateEmail"></asp:Literal></p>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" valign="top">
                                    <p>
                                        Temasa Geçilecek Kiþinin Ýsmi:</p>
                                </td>
                                <td valign="top">
                                    <p>
                                        <asp:Literal runat="server" ID="ltlAlternateContactName"></asp:Literal></p>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" valign="top">
                                    <p>
                                        Temasa geçilecek kiþinin adý ve telefonu</p>
                                </td>
                                <td valign="top">
                                    <p>
                                        <asp:Literal runat="server" ID="ltlAlternateContactPhone"></asp:Literal></p>
                                </td>
                            </tr>
                        </table>
                        <p>&nbsp;</p>
                        <div class="hr">
                            <hr />
                        </div>
                        <p>&nbsp;</p>
                        <table width="100%" class="GenericTable">
                            <tr>
                                <td width="25%" align="right" valign="top">
                                    &nbsp;</td>
                                <td width="75%" valign="top">
                                    <h2>
                                        Eðitim bilgileri</h2>
                                </td>
                            </tr>
                            <tr id="trMiddleSchool" runat="server">
                                <td align="right" valign="top">
                                    <p>
                                        <asp:Literal runat="server" ID="ltlMiddleSchoolStatus"></asp:Literal> <br />
                                        <asp:Literal runat="server" ID="ltlMiddleSchoolEndDate"></asp:Literal>
                                    </p>
                                </td>
                                <td valign="top">
                                    <p>
                                        Ýlköðretim<br />
                                        <strong><asp:Literal runat="server" ID="ltlMiddleSchoolName"></asp:Literal></strong><br />
                                        <br />
                                    </p>
                                </td>
                            </tr>                            
                            <tr id="trHighSchool" runat="server">
                                <td align="right" valign="top">
                                    <p>
                                        <asp:Literal runat="server" ID="ltlHighSchoolStatus"></asp:Literal> <br />                                   
                                        <asp:Literal runat="server" ID="ltlHighSchoolEndDate"></asp:Literal></p>
                                </td>
                                <td valign="top">
                                    <p>
                                        Lise<br />
                                        <strong><asp:Literal runat="server" ID="ltlHighSchoolName"></asp:Literal></strong><br />
                                        <asp:Literal runat="server" ID="ltlHighSchoolType"></asp:Literal><br />
                                    </p>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" valign="top">
                                    <p>
                                        &nbsp;</p>
                                </td>
                                <td valign="top">
                                    <p>
                                        &nbsp;</p>
                                </td>
                            </tr>
                            <asp:Repeater runat="server" ID="rptUniversity0">
                            <ItemTemplate>
                            <tr>
                                <td align="right" valign="top">
                                    <p>
                                        <%#DataBinder.Eval(Container.DataItem, "StartYear") %> - 
                                        <%#DataBinder.Eval(Container.DataItem, "EndYear") %></p>
                                </td>
                                <td valign="top">
                                    <p>
                                        Meslek Yüksek Okulu<br />
                                        <strong> <%#DataBinder.Eval(Container.DataItem, "SchoolName") %> </strong>, 
                                                 <%#DataBinder.Eval(Container.DataItem, "DepartmentName") %>
                                        
                                        <%#DataBinder.Eval(Container.DataItem, "CityName") %>, 
                                        <%#DataBinder.Eval(Container.DataItem, "CountryName") %>
                                        <br />
                                        <div id="dvDegree" runat="server">
                                        Baþarý puaný:  <%#DataBinder.Eval(Container.DataItem, "Degree") %>
                                        </div>
                                    </p>
                                </td>
                            </tr>                            
                            </ItemTemplate>
                            <SeparatorTemplate>
                            <tr>
                                <td align="right" valign="top">
                                    <p>
                                        &nbsp;</p>
                                </td>
                                <td valign="top">
                                    <p>
                                        &nbsp;</p>
                                </td>
                            </tr>                            
                            </SeparatorTemplate>
                            </asp:Repeater>
                            <asp:Repeater runat="server" ID="rptUniversity1">
                            <ItemTemplate>
                            <tr>
                                <td align="right" valign="top">
                                    <p>
                                        <%#DataBinder.Eval(Container.DataItem, "StartYear") %> - 
                                        <%#DataBinder.Eval(Container.DataItem, "EndYear") %></p>
                                </td>
                                <td valign="top">
                                    <p>
                                        Meslek Yüksek Okulu<br />
                                        <strong> <%#DataBinder.Eval(Container.DataItem, "SchoolName") %> </strong>, 
                                                 <%#DataBinder.Eval(Container.DataItem, "DepartmentName") %>
                                        
                                        <%#DataBinder.Eval(Container.DataItem, "CityName") %>, 
                                        <%#DataBinder.Eval(Container.DataItem, "CountryName") %>
                                        <br />
                                        <div id="dvDegree" runat="server">
                                        Baþarý puaný:  <%#DataBinder.Eval(Container.DataItem, "Degree") %>
                                        </div>
                                    </p>
                                </td>
                            </tr>                            
                            </ItemTemplate>
                            <SeparatorTemplate>
                            <tr>
                                <td align="right" valign="top">
                                    <p>
                                        &nbsp;</p>
                                </td>
                                <td valign="top">
                                    <p>
                                        &nbsp;</p>
                                </td>
                            </tr>                            
                            </SeparatorTemplate>
                            </asp:Repeater>
                            <asp:Repeater runat="server" ID="rptUniversity2">
                            <ItemTemplate>
                            <tr>
                                <td align="right" valign="top">
                                    <p>
                                        <%#DataBinder.Eval(Container.DataItem, "StartYear") %> - 
                                        <%#DataBinder.Eval(Container.DataItem, "EndYear") %></p>
                                </td>
                                <td valign="top">
                                    <p>
                                        Meslek Yüksek Okulu<br />
                                        <strong> <%#DataBinder.Eval(Container.DataItem, "SchoolName") %> </strong>, 
                                                 <%#DataBinder.Eval(Container.DataItem, "DepartmentName") %>
                                        
                                        <%#DataBinder.Eval(Container.DataItem, "CityName") %>, 
                                        <%#DataBinder.Eval(Container.DataItem, "CountryName") %>
                                        <br />
                                        <div id="dvDegree" runat="server">
                                        Baþarý puaný:  <%#DataBinder.Eval(Container.DataItem, "Degree") %>
                                        </div>
                                    </p>
                                </td>
                            </tr>                            
                            </ItemTemplate>
                            <SeparatorTemplate>
                            <tr>
                                <td align="right" valign="top">
                                    <p>
                                        &nbsp;</p>
                                </td>
                                <td valign="top">
                                    <p>
                                        &nbsp;</p>
                                </td>
                            </tr>                            
                            </SeparatorTemplate>
                            </asp:Repeater>
                            <asp:Repeater runat="server" ID="rptDoktorate">
                            <ItemTemplate>
                            <tr>
                                <td align="right" valign="top">
                                    <p>
                                        <%#DataBinder.Eval(Container.DataItem, "StartYear") %> - 
                                        <%#DataBinder.Eval(Container.DataItem, "EndYear") %></p>
                                </td>
                                <td valign="top">
                                    <p>
                                        Meslek Yüksek Okulu<br />
                                        <strong> <%#DataBinder.Eval(Container.DataItem, "SchoolName") %> </strong>, 
                                                 <%#DataBinder.Eval(Container.DataItem, "DepartmentName") %>
                                        
                                        <%#DataBinder.Eval(Container.DataItem, "CityName") %>, 
                                        <%#DataBinder.Eval(Container.DataItem, "CountryName") %>
                                        <br />
                                        <div id="dvDegree" runat="server">
                                        Baþarý puaný:  <%#DataBinder.Eval(Container.DataItem, "Degree") %>
                                        </div>
                                    </p>
                                </td>
                            </tr>                            
                            </ItemTemplate>
                            <SeparatorTemplate>
                            <tr>
                                <td align="right" valign="top">
                                    <p>
                                        &nbsp;</p>
                                </td>
                                <td valign="top">
                                    <p>
                                        &nbsp;</p>
                                </td>
                            </tr>                            
                            </SeparatorTemplate>
                            </asp:Repeater>
                        </table>
                        <p>&nbsp;</p>
                        <div class="hr">
                            <hr />
                        </div>
                        <p>&nbsp;</p>
                        <p style="float: left; padding-left: 40px;">
                        Toplam Ýþ Deneyimi: 
                        <asp:Literal runat="server" ID="ltlTotalWorkExperience"></asp:Literal> Yýl</p>
                        <br /><br />
                        <asp:Repeater runat="server" ID="rptUserEmployment" OnItemDataBound="rptUserEmployment_ItemDataBound">
                            <HeaderTemplate>
                                <table width="100%" class="GenericTable">
                                    <tr>
                                        <td width="25%" align="right" valign="top">
                                            &nbsp;</td>
                                        <td width="75%" valign="top">
                                            <h2>
                                                Ýþ Deneyimleri
                                            </h2>
                                        </td>
                                    </tr>                            
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tr>
                                    <td align="right" valign="top">
                                        <p>
                                            <%#Convert.ToDateTime(DataBinder.Eval(Container.DataItem, "StartDate")).ToShortDateString() %> - 
                                            <asp:Literal runat="server" ID="ltlEndDate" Text='<%#DataBinder.Eval(Container.DataItem, "EndDate") %>'></asp:Literal>
                                        </p>
                                    </td>
                                    <td valign="top">
                                        <p>
                                            <strong><%#DataBinder.Eval(Container.DataItem, "CompanyName") %></strong><br />
                                            <%#DataBinder.Eval(Container.DataItem, "CityName") %>, 
                                            <%#DataBinder.Eval(Container.DataItem, "CountryName") %>
                                            <br />
                                            <%#DataBinder.Eval(Container.DataItem, "SectorName") %> <br />
                                            <%#DataBinder.Eval(Container.DataItem, "PositionName") %><br />
                                            </strong>
                                        </p>
                                        <br />
                                        <p>
                                            Kýsa Ýþ Tanýmý: 
                                            <%#DataBinder.Eval(Container.DataItem, "JobDescription") %>
                                        </p>
                                        <br />
                                        <p>
                                            Çalýþma Þekli: <%#DataBinder.Eval(Container.DataItem, "LabouringTypeName") %>
                                        </p>
                                        <asp:Panel ID="pnlReason" runat="server">
                                            <p> Ýþten Ayrýlma Nedeni:
                                            <asp:Literal runat="server" ID="ltlReasonOfResignation" 
                                            Text='<%#DataBinder.Eval(Container.DataItem, "ReasonOfResignation") %>'></asp:Literal>
                                            </p>
                                        </asp:Panel>
                                        <asp:Panel runat="server" ID="pnlPhone">
                                            <p> Firma Telefonu: 
                                                <%#DataBinder.Eval(Container.DataItem, "CompanyPhone") %>
                                            </p>
                                        </asp:Panel>
                                        <p>
                                            Referans Durumu:
                                            <asp:Literal runat="server" ID="ltlCanReference"
                                            Text='<%#DataBinder.Eval(Container.DataItem, "CanReference").ToString().Replace("True", "Alýnabilir").Replace("False", "Alýnamaz") %>'></asp:Literal>
                                        </p>
                                    </td>
                                </tr>
                            </ItemTemplate>
                            <SeparatorTemplate>
                                <tr>
                                    <td align="right" valign="top">
                                        <p>&nbsp;</p>
                                    </td>
                                    <td valign="top">
                                        <p>&nbsp;</p>
                                    </td>
                                </tr>                            
                            </SeparatorTemplate>
                            <FooterTemplate>
                                </table>
                            </FooterTemplate>
                        </asp:Repeater>
                        <p>&nbsp;</p>
                        <div class="hr">
                            <hr />
                        </div>
                        <p>&nbsp;</p>
                        <table width="100%" class="GenericTable">
                            <tr>
                                <td width="25%" align="right" valign="top">
                                    &nbsp;</td>
                                <td width="75%" valign="top">
                                    <h2>
                                        Nitelikler / Ýlgi Alanlarý</h2>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" valign="top">
                                    <p>
                                        Sürücü belgesi:
                                    </p>
                                </td>
                                <td valign="top">
                                    <p>
                                        <strong>
                                            <asp:Literal runat="server" ID="ltlDriverLicence"></asp:Literal> &nbsp;
                                            <asp:Literal runat="server" ID="ltlDriverLicenceYear"></asp:Literal>
                                        </strong></p>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" valign="top">
                                    <p>
                                        &nbsp;</p>
                                </td>
                                <td valign="top">
                                    <p>
                                        &nbsp;</p>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" valign="top">
                                    <p>
                                        Bildiði yabancý diller:
                                    </p>
                                </td>
                                <td valign="top">
                                
                                    <asp:Repeater runat="server" ID="rptUserLanguages" OnItemDataBound="rptUserLanguages_ItemDataBound">
                                        <ItemTemplate>
                                            <p>
                                                <strong><%#DataBinder.Eval(Container.DataItem, "ForeignLanguageName") %></strong><br /> 
                                                <%#DataBinder.Eval(Container.DataItem, "PlaceLearned") %><br />
                                                Okuma: <%#DataBinder.Eval(Container.DataItem, "Read") %> <br />
                                                Yazma: <%#DataBinder.Eval(Container.DataItem, "Write") %> <br />
                                                Konuþma: <%#DataBinder.Eval(Container.DataItem, "Speak") %> <br />
                                                
                                                <asp:Literal Visible="false" runat="server" ID="ltlExamID" Text='<%#DataBinder.Eval(Container.DataItem, "ForeignLanguageExamID") %>'></asp:Literal>
                                                <asp:Literal runat="server" ID="ltlExamTitle" Text='Sýnav:'></asp:Literal>
                                                <asp:Literal runat="server" ID="ltlExamName" Text='<%#DataBinder.Eval(Container.DataItem, "ForeignLanguageExamName") %>'></asp:Literal>
                                                <br />
                                                <asp:Literal runat="server" ID="ltlExamDegreeTitle" Text='Puan:'></asp:Literal>
                                                <asp:Literal runat="server" ID="ltlExamDegree" Text='<%#DataBinder.Eval(Container.DataItem, "ExamDegree") %>'></asp:Literal>
                                            </p>
                                        </ItemTemplate>
                                        <SeparatorTemplate>
                                            <p>&nbsp;</p>
                                        </SeparatorTemplate>
                                    </asp:Repeater>
                                    
                                </td>
                            </tr>
                            <tr>
                                <td align="right" valign="top">
                                    <p>
                                        Bilgisayar bilgisi:
                                    </p>
                                </td>
                                <td valign="top">
                                    <p>
                                    <asp:Repeater runat="server" ID="rptUserComputerKnowledge">
                                        <ItemTemplate>
                                                <%#DataBinder.Eval(Container.DataItem, "ComputerKnowledgeTypeName") %>
                                        </ItemTemplate>
                                        <SeparatorTemplate>-</SeparatorTemplate>
                                    </asp:Repeater>
                                    </p>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" valign="top">
                                    <p>
                                        Kurs ve Sertifikalar:
                                    </p>
                                </td>
                                <td valign="top">
                                    <p>
                                        <strong>
                                            <asp:Literal runat="server" ID="ltlCourseAndCertificates"></asp:Literal>
                                        </strong></p>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" valign="top">
                                    <p>
                                        Ýlgi Alanlarý:
                                    </p>
                                </td>
                                <td valign="top">
                                    <p>
                                        <strong>
                                            <asp:Literal runat="server" ID="ltlInterests"></asp:Literal>
                                        </strong></p>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" valign="top">
                                    <p>
                                        Kulüp ve Dernekler:
                                    </p>
                                </td>
                                <td valign="top">
                                    <p>
                                        <strong>
                                            <asp:Literal runat="server" ID="ltlClubs"></asp:Literal>
                                        </strong></p>
                                </td>
                            </tr>                              
                        </table>
                        <p><br /></p>
                        <div class="hr">
                            <hr />
                        </div>
                        <p>&nbsp;</p>
                        <table width="100%" class="GenericTable">
                            <tr>
                                <td width="25%" align="right" valign="top">
                                    &nbsp;</td>
                                <td width="75%" valign="top">
                                    <h2>
                                        Tercihler
                                    </h2>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" valign="top">
                                    <p>
                                        Çalýþmak istediðiniz sektörler</p>
                                </td>
                                <td valign="top">
                                    <p>
                                        <asp:Repeater runat="server" ID="rptUserSectors">
                                        <ItemTemplate><%#DataBinder.Eval(Container.DataItem, "SectorName") %></ItemTemplate>
                                        <SeparatorTemplate>, </SeparatorTemplate>
                                        </asp:Repeater>
                                    </p>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" valign="top">
                                    <p>
                                        Çalýþmak istediðiniz pozisyonlar</p>
                                </td>
                                <td valign="top">
                                    <p>
                                        <asp:Repeater runat="server" ID="rptUserPositions">
                                        <ItemTemplate><%#DataBinder.Eval(Container.DataItem, "PositionName") %></ItemTemplate>
                                        <SeparatorTemplate>, </SeparatorTemplate>
                                        </asp:Repeater>                                    
                                    </p>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" valign="top">
                                    <p>
                                        Çalýþmak istediðiniz ülkeler</p>
                                </td>
                                <td valign="top">
                                    <p>
                                        <asp:Repeater runat="server" ID="rptUserCountries">
                                        <ItemTemplate><%#DataBinder.Eval(Container.DataItem, "PlaceName") %></ItemTemplate>
                                        <SeparatorTemplate>, </SeparatorTemplate>
                                        </asp:Repeater>                                        
                                    </p>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" valign="top">
                                    <p>
                                        Çalýþmak istediðiniz iller
                                    </p>
                                </td>
                                <td valign="top">
                                    <p>
                                        <asp:Repeater runat="server" ID="rptUserCities">
                                        <ItemTemplate><%#DataBinder.Eval(Container.DataItem, "PlaceName") %></ItemTemplate>
                                        <SeparatorTemplate>, </SeparatorTemplate>
                                        </asp:Repeater>  
                                    </p>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" valign="top">
                                    <p>
                                        Tercih Ettiði Çalýþma Þekli
                                    </p>
                                </td>
                                <td valign="top">
                                    <p>
                                        <asp:Repeater runat="server" ID="rptUserLabouringTypes">
                                        <ItemTemplate><%#DataBinder.Eval(Container.DataItem, "LabouringTypeName") %></ItemTemplate>
                                        <SeparatorTemplate>, </SeparatorTemplate>
                                        </asp:Repeater>                                      
                                    </p>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" valign="top">
                                    <p>
                                        Sýk seyahat engeli var mý?</p>
                                </td>
                                <td valign="top">
                                    <p>
                                        <asp:Literal runat="server" ID="ltlHasTravelDifficulty"></asp:Literal></p>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" valign="top">
                                    <p>
                                        Sigara Kullanýmý
                                    </p>
                                </td>
                                <td valign="top">
                                    <p>
                                        <asp:Literal runat="server" ID="ltlSmoking"></asp:Literal></p>
                                </td>
                            </tr>
                            <tr id="trReferences" runat="server">
                                <td align="right" valign="top">
                                    <p>
                                        Referanslar
                                    </p>
                                </td>
                                <td valign="top">
                                    <p>
                                        <asp:Repeater runat="server" ID="rptUserUserReferences">
                                        <ItemTemplate>
                                            <%#DataBinder.Eval(Container.DataItem, "ReferenceName") %> (<%#DataBinder.Eval(Container.DataItem, "Position") %>)<br />
                                            <%#DataBinder.Eval(Container.DataItem, "Company") %> - 
                                            <%#DataBinder.Eval(Container.DataItem, "Phone") %>
                                        </ItemTemplate>
                                        <SeparatorTemplate><br /><br /></SeparatorTemplate>
                                        </asp:Repeater>                                      
                                    </p>
                                </td>
                            </tr>                            
                        </table>
                        <p>&nbsp;</p>
                        <div class="hr">
                            <hr />
                        </div>
                        <p>&nbsp;</p>
                        <table width="100%" class="GenericTable">
                            <tr>
                                <td width="25%" align="right" valign="top">
                                    &nbsp;</td>
                                <td width="60%" valign="top">
                                    <ul class="FamLinks">
                                        <li style="display: none;" class="SendToFriend"><a href="javascript:;">Arkadaþýma Gönder</a></li>
                                        <li class="Print"><a href="javascript:window.print();">Yazdýr</a></li>
                                    </ul>
                                </td>
                                <td width="15%" valign="top">
                                    <a href="javascript:;"></a>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
          <div class="brclear"></div>
        </div>
        </div>
        <div class="BoxContentBottom"></div>
      <!-- finish roundcornered box -->
      <p>&nbsp;</p>
      
    </div>