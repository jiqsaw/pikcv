<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uCompanyLogon.ascx.cs"
    Inherits="UserControls_Company_uCompanyLogon" %>
<div id="content">

    <table width="755" style="margin-bottom:10px;">
      <tr>
        <td valign="top" class="TeaserTable" style="width:452px;"><div>
            <div class="BoxPadder">
              <h2 class="TeaserHeaderTaglined">P�K Kredi Kullan�m�</h2>
              <table class="TeaserPikKrediTable1" style="width:100%">
                <tr>
                  <td valign="top" style="padding:7px 0 0 8px;"><img src="images/bg/puzzle_blue_small.png" /></td>
                  <td>Uzman / eleman ileti�im bilgisine eri�im<br />
                    <span>(P�K Veritaban� / �lan ba�vurular�)</span></td>
                  <td><strong>1</strong> P�K kredi / aday</td>
                </tr>
                <tr>
                  <td valign="top" style="padding:7px 0 0 8px;"><img src="images/bg/puzzle_red_small.png" /></td>
                  <td>Y�netici ileti�im bilgisine eri�im<br />
                    <span>(P�K Veritaban� / �lan ba�vurular�)</span></td>
                  <td><strong>3</strong> P�K kredi / aday</td>
                </tr>
                <tr>
                  <td valign="top" style="padding:7px 0 0 8px;"><img src="images/bg/puzzle_green_small.png" /></td>
                  <td>P�K g�r��mesi olan y�netici<br />
                    adaylar�n�n i�e al�m�</td>
                  <td>Aday�n ayl�k maa��na<br />ba�l� P�K Kredi �demesi</td>
                </tr>
                <tr>
                  <td valign="top" style="padding:7px 0 0 8px;"><img src="images/bg/puzzle_orange_small.png" /></td>
                  <td>�lk on aras�nda ilan verme</td>
                  <td><strong>10</strong> P�K kredi / ilan</td>
                </tr>
                <tr>
                  <td valign="top" style="padding:7px 0 0 8px;"><img src="images/bg/puzzle_blue_small.png" /></td>
                  <td>�kinci on aras�nda ilan verme</td>
                  <td><strong>5</strong> P�K kredi / ilan</td>
                </tr>
              </table>
            </div>
          </div></td>
        <td style="width:17px;">&nbsp;</td>
          <td valign="top" class="TeaserTable" style="width: 291px;">
              <div class="BoxPadder">
                  <h2 class="TeaserHeaderTaglined">
                      P�K Kredili Hizmetlerimiz</h2>
                  <asp:Repeater ID="rptCredits" runat="server">
                      <HeaderTemplate>
                          <table class="TeaserPikKrediTable2" style="width: 100%">
                      </HeaderTemplate>
                      <ItemTemplate>
                          <tr onclick='javascript:window.location = "<%#DataBinder.Eval(Container.DataItem, "CreditPackageID", "Pikcv.aspx?Pik=Company-Credits-SelectCreditPackage&CreditPackageID={0}")%>";'
                            style="cursor:pointer;">
                              <td valign="top">
                                  <div class="PikKrediValue-Green">
                                      <asp:Label ID="lbCredits" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "Credits") %>'></asp:Label></div>
                              </td>
                              <td>
                                  <strong><span class="Hilite1">Pik Kredi -
                                      <asp:Label ID="lbPrice" runat="server" Text='<%# Convert.ToInt32(DataBinder.Eval(Container.DataItem, "Multiplier")) * Convert.ToInt32(DataBinder.Eval(Container.DataItem, "Credits")) %>'></asp:Label>
                                      YTL</span></strong></td>
                              <td>
                                     <img src="images/buttons/buy_pikkredi.png"/>
                                      </td>
                          </tr>
                      </ItemTemplate>
                      <FooterTemplate>
                          </table>
                      </FooterTemplate>
                  </asp:Repeater>
              </div>
          </td>
      </tr>
      <tr>
        <td><div class="TeaserShadow2"></div></td>
        <td>&nbsp;</td>
        <td><div class="TeaserShadow2"></div></td>
      </tr>
      <tr>
        <td valign="top"><div class="HeaderPB">
            <h2 class="sIFRHeader">Pik Kredi Takibi</h2>
          </div>
          <p style="margin:0 0 0 30px;">�al��man�z�n her an�nda P�K kredi alabilirsiniz. P�K kredi takibini sistem taraf�ndan otomatik olarak yap�l�r. Kredilerinizi bir y�l i�inde kullanmak zorundas�n�z, kullan�lmayan krediler silinecektir.</p></td>
        <td>&nbsp;</td>
        <td style="border:1px solid #BACDE2;padding:5px;">
			<p style="padding:4px 10px;"><strong>P�K Kredi Durumu:</strong></p>
          	<p style="background:#E5EDF4;padding:4px 10px;">Kalan Pik krediniz: <span style="font-weight:bold;font-size:130%;"><asp:Label ID="lbRemainingCredits" runat="server"></asp:Label></span></p>
          	<p style="padding:4px 10px;">Son kredi al�m tarihi: <asp:Label ID="lbLastCreditTakenDate" runat="server"></asp:Label></p></td>
      </tr>
    </table>
    
    <asp:Panel runat="server" ID="pnlFolders">
    
    <div class="HeaderPB">
      <h2 class="sIFRHeader">Klas�rlerim</h2>
    </div>
    <div class="CorpMainPageFolderInfo1"><img src="images/bg/corp_mainpage_folder_hd1.png" /><p><strong><asp:HyperLink ID="hplUsersToTake" runat="server" Text=" adet aday �zge�mi� mevcut" NavigateUrl="#Company-Folders-FolderDetail&FolderID="></asp:HyperLink></strong></p>
    </div>
    <div class="CorpMainPageFolderInfo2"><img src="images/bg/corp_mainpage_folder_hd2.png" /><p><strong><asp:HyperLink ID="hplUsersTaken" runat="server" Text=" adet a��k �zge�mi� mevcut" NavigateUrl="#Company-Folders-FolderDetail&FolderID="></asp:HyperLink></strong></p>
    </div>
    <p>
    <asp:Label ID="lbFolderInformation" runat="server" Text="Sadece �leti�im Bilgisi Sat�nalma istekleri  ve �leti�im bilgisi Sat�n Al�nanlar klas�rleri sizlere sitem taraf�ndan atanm��t�r."></asp:Label>
    </asp:Panel>
    </p>
    <br />
    <asp:Panel runat="server" ID="pnlJobs">
    
    <div class="HeaderPB floatLeft">
        <h2 class="sIFRHeader">
            G�ncel �lanlar�m</h2>
    </div>
    <div id="Tab">
        <ul>
            <li class="NoTab"><a href="#Company-Jobs-PublicJobs&JobStatus=1">T�m �lanlar...</a></li>
        </ul>
    </div>
    <div class="brclear">
    </div>
    <div runat="server" id="dvNoJobs" class="alertMsg">
        <p>
            <asp:Label ID="lbNoJobs" runat="server"></asp:Label>
        </p>
    </div>
    <asp:Repeater ID="rptJobs" runat="server" OnItemDataBound="rptJobs_ItemDataBound">
        <HeaderTemplate>
            <table width="100%" class="dataGrid">
                <tr>
                    <th style="width: 35%;">
                        <strong>Pozisyon</strong></th>
                    <th style="width: 10%;">
                        <strong>Ba�vuru</strong></th>
                    <th nowrap="nowrap" style="width: 20%;">
                        <strong>Biti� Tarihi</strong></th>
                    <th style="width: 10%;">
                        <div align="center">
                            <strong>�statistik</strong></div>
                    </th>
                    <th style="width: 25%;">
                        <strong>Durum</strong></th>
                </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td style="width: 35%;">
                    <a href="javascript:;" onclick='<%#DataBinder.Eval(Container.DataItem, "JobID", "OpenJobPreview({0})")%>'>
                    Ref.No:<%#DataBinder.Eval(Container.DataItem, "ReferenceNumber")%> <br /> 
                    <%#DataBinder.Eval(Container.DataItem, "PositionName") %>
                    </a>
                </td>
                <td style="width: 10%;">
                    <asp:HyperLink ID="hplJobApplicantCount" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "ApplicantCount")%>'
                        NavigateUrl='<%#DataBinder.Eval(Container.DataItem, "JobID", "#Company-Jobs-JobApplicants&JobID={0}")%>'></asp:HyperLink>
                </td>
                <td style="width: 20%;">
                    <asp:Literal ID="ltrEndDate" runat="server" Text='<%# String.Format("{0:d}", DataBinder.Eval(Container.DataItem, "EndDate"))%>'></asp:Literal>
                </td>
                <td align="center" style="width: 10%;">
                    <img onclick='OpenJobStatistics(<%#DataBinder.Eval(Container.DataItem, "JobID")%>)' style="cursor: pointer;" src="images/misc/statistic.png" width="16" height="14" /></td>
                <td style="width: 25%;">
                    <asp:LinkButton ID="lnbUpdate" runat="server" CommandArgument='<%#DataBinder.Eval(Container.DataItem, "JobID")%>'
                        OnClick="lnbUpdate_Click" Text="G�ncelle"></asp:LinkButton>
                    /
                    <asp:LinkButton ID="lnbArchive" runat="server" CommandArgument='<%#DataBinder.Eval(Container.DataItem, "JobID")%>'
                        OnClick="lnbArchive_Click" Text="Ar�ivle"></asp:LinkButton>
                    
                    <asp:LinkButton ID="lnbDelete" runat="server" CommandArgument='<%#DataBinder.Eval(Container.DataItem, "JobID")%>'
                        OnClick="lnbDelete_Click" Text="Sil" Visible="false"></asp:LinkButton>
                </td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>
    
    </asp:Panel>
</div>


