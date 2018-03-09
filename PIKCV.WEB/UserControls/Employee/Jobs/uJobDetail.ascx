<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uJobDetail.ascx.cs" Inherits="UserControls_Employee_Jobs_uJobDetail" %>
<%@ Register Src="../../Common/ModalPopup/ModalPopup.ascx" TagName="ModalPopup" TagPrefix="uc1" %>

<div class="contentPad">
      <div class="HeaderPR floatLeft">
        <h2 class="sIFRHeader">Ýlan Detayý</h2>
      </div>
      <div class="brclear"></div>
      <!-- start roundcornered box -->
      <div class="BoxContentTop"></div>
      <div class="BoxContent">
        <div class="BoxPadder">
          <table width="100%" class="adDetail">
            <tr>
              <td colspan="2" width="50%">
              <h2>
              <strong> <asp:Literal runat="server" ID="ltlCompanyName"></asp:Literal> </strong> </h2>
              <br />
              <h3><b>
                <asp:Literal runat="server" ID="ltlPositionName"></asp:Literal><br /> (Ref: <asp:Literal runat="server" ID="ltlRefNo"></asp:Literal>)</b></h3>
                <p><br />

                    <asp:Image runat="server" ID="imgLogo"  />
                
                </p>
                <p><b><asp:Literal runat="server" ID="ltlJobTitle"></asp:Literal></b> </p></td>
              <td width="30%" valign="top"><div class="Hilite">
                  <p>Alýnacak personel sayýsý: <asp:Literal runat="server" ID="ltlNumberOfWorkers"></asp:Literal> </p>
                  <p>Ýlan tarihi: <asp:Literal runat="server" ID="ltlStartDate"></asp:Literal> </p>
                  <p>Son Baþvuru tarihi:<asp:Literal runat="server" ID="ltlEndDate"></asp:Literal></p>
                  
                  <div runat="server" id="dvJobProperties">
                  <p>Ýlan durumu:
                    <asp:Literal runat="server" ID="ltlDisabled" Visible="false">Engelli,</asp:Literal>
                    <asp:Literal runat="server" ID="ltlOldConvicted" Visible="false">Eski Hükümlü,</asp:Literal>
                    <asp:Literal runat="server" ID="ltlMartyrRelative" Visible="false">Þehit Yakýný,</asp:Literal>
                    <asp:Literal runat="server" ID="ltlTerrorWronged" Visible="false">Terör Maðduru</asp:Literal>
                  </p>
                  </div>
                  
                  <p>Çalýþýlacak ülke: 
                    <asp:Repeater runat="server" ID="rptJobCountries">
                        <ItemTemplate>
                            <%#DataBinder.Eval(Container.DataItem, "PlaceName") %>
                        </ItemTemplate>
                        <SeparatorTemplate>, 
                        </SeparatorTemplate>
                    </asp:Repeater>
                    </p>
                    
                  <p>Çalýþýlacak yer: 
                    <asp:Repeater runat="server" ID="rptJobPlaces">
                        <ItemTemplate>
                            <%#DataBinder.Eval(Container.DataItem, "PlaceName") %>
                        </ItemTemplate>
                        <SeparatorTemplate>, 
                        </SeparatorTemplate>
                    </asp:Repeater>
                    </p>                    
                </div></td>
            </tr>
          </table>
          <table width="100%" class="adDetail">
            <tr>
              <td width="20%" align="right" valign="top" nowrap="nowrap"><p><strong>Ýþ Tanýmý:</strong></p></td>
              <td width="80%"><p>
                <asp:Literal runat="server" ID="ltlJobDescription"></asp:Literal>
              </p></td>
            </tr>
              <tr>
                  <td align="right" valign="top" nowrap="nowrap">
                      <p>
                          <strong>Sektör:</strong><br /></p>
                  </td>
                  <td>
                      <p>
                          <asp:Repeater runat="server" ID="rptJobSectors">
                              <ItemTemplate>
                                  <%#DataBinder.Eval(Container.DataItem, "SectorName") %>
                              </ItemTemplate>
                              <SeparatorTemplate>
                                  ,</SeparatorTemplate>
                          </asp:Repeater>
                      </p>
                  </td>
              </tr>
              <tr>
              <td align="right" valign="top" nowrap="nowrap"><p><strong> Eðitim durumu:</strong></p></td>
              <td><p>
                <asp:Repeater runat="server" ID="rptEducationLevels">
                    <ItemTemplate>
                    <%#DataBinder.Eval(Container.DataItem, "EducationLevelName")%>
                    </ItemTemplate>
                    <SeparatorTemplate>, </SeparatorTemplate>
                </asp:Repeater>
              </p></td>
            </tr>
            <tr>
              <td align="right" valign="top" nowrap="nowrap"><p><strong>Ýþ Deneyimi:</strong><br />
              (sektör - pozisyon)</p>
              </td>
              <td><p>
                <asp:Repeater runat="server" ID="rptJobQualitySectors">
                <ItemTemplate><%#DataBinder.Eval(Container.DataItem, "SectorName") %></ItemTemplate>
                <SeparatorTemplate>, </SeparatorTemplate>
                </asp:Repeater>
                <br />
                <asp:Repeater runat="server" ID="rptJobQualityPositions">
                <ItemTemplate>
                    <asp:Literal runat="server" ID="ltlPositionName" Text='<%#DataBinder.Eval(Container.DataItem, "PositionName") %>'>
                    </asp:Literal>
                </ItemTemplate>
                <SeparatorTemplate>,</SeparatorTemplate>
                </asp:Repeater>
              </p></td>
            </tr>
            <tr>
              <td align="right" valign="top" nowrap="nowrap"><p><strong> Aranan Yetkinlikler:</strong></p></td>
              <td><ul type="disc">
                <asp:Repeater runat="server" ID="rptPerfections">
                    <ItemTemplate>
                        <li><%#DataBinder.Eval(Container.DataItem, "PerfectionName")%></li>                    
                    </ItemTemplate>
                </asp:Repeater>                  
                </ul></td>
            </tr>
            <tr>
              <td align="right" valign="top" nowrap="nowrap"><p><strong>Aranan Nitelikler:</strong></p></td>
              <td><ul type="disc">
                  <li>Çalýþma tipi: <asp:Literal runat="server" ID="ltlJobLabouringTypeName"></asp:Literal></li>
                  <li>Cinsiyet: <asp:Literal runat="server" ID="ltlSex"></asp:Literal> </li>
                  <li> Yaþ: <asp:Literal runat="server" ID="ltlAgeRange"></asp:Literal> </li>
                  <li>Yabancý dil ve teknik beceriler: 
                    <asp:Repeater runat="server" ID="rptForeignLanguages">
                    <ItemTemplate><%#DataBinder.Eval(Container.DataItem, "ForeignLanguageName") %></ItemTemplate>
                    <SeparatorTemplate>/</SeparatorTemplate>
                    </asp:Repeater>
                    - 
                    <asp:Repeater runat="server" ID="rptComputerKnowledges">
                    <ItemTemplate><%#DataBinder.Eval(Container.DataItem, "ComputerKnowledgeTypeName")%></ItemTemplate>
                    <SeparatorTemplate>/</SeparatorTemplate>
                    </asp:Repeater>                  
                  
                  </li>
                </ul></td>
            </tr>
            <tr>
              <td>&nbsp;</td>
              <td>
                <asp:ImageButton CommandArgument="-1" runat="server" ID="ImgBtnApply" ImageUrl="~/Images/buttons/Apply.png" OnClick="ImgBtnApply_Click" />
                <p><b>
                <asp:Literal runat="server" ID="ltlNoButtonMessage" Visible="false">
                    Bu ilana daha önce baþvurmuþtunuz.
                </asp:Literal>
                </p></b>
                <asp:Panel runat="server" ID="pnlApplicantCtrlLogin" Visible="false">
                <p><b>
                    <asp:Literal runat="server" ID="ltlApplicantCtrlLogin" >
                        Bu ilana baþvurabilmek için üye olmanýz gerekmektedir
                    </asp:Literal> <br />
                    
                    <asp:HyperLink runat="server" NavigateUrl="#Employee-Membership-UserInfo">Üye olmak için týklayýnýz</asp:HyperLink>
                </p></b>
                </asp:Panel>
                
                <ul class="FamLinks">
                  <li runat="server" id="liSendFriend" class="SendToFriend">
                    <asp:HyperLink runat="server" ID="hlSendFriend" Text="Arkadaþýna Gönder"></asp:HyperLink></li>
                    <li class="Print"><a href="javascript:window.print();">Yazdýr</a></li>
                </ul>
                </td>
            </tr>
          </table>
          <div class="brclear"></div>
        </div>
      </div>
      <div class="BoxContentBottom"></div>
      <!-- finish roundcornered box -->
    </div>
    <div id="dvScript" runat="server">
        <br />
        &nbsp;</div>
                <uc1:ModalPopup ID="ShowModal" runat="server" Visible="true" />
