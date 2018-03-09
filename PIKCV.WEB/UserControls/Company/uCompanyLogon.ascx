<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uCompanyLogon.ascx.cs"
    Inherits="UserControls_Company_uCompanyLogon" %>
<div id="content">

    <table width="755" style="margin-bottom:10px;">
      <tr>
        <td valign="top" class="TeaserTable" style="width:452px;"><div>
            <div class="BoxPadder">
              <h2 class="TeaserHeaderTaglined">PÝK Kredi Kullanýmý</h2>
              <table class="TeaserPikKrediTable1" style="width:100%">
                <tr>
                  <td valign="top" style="padding:7px 0 0 8px;"><img src="images/bg/puzzle_blue_small.png" /></td>
                  <td>Uzman / eleman iletiþim bilgisine eriþim<br />
                    <span>(PÝK Veritabaný / Ýlan baþvurularý)</span></td>
                  <td><strong>1</strong> PÝK kredi / aday</td>
                </tr>
                <tr>
                  <td valign="top" style="padding:7px 0 0 8px;"><img src="images/bg/puzzle_red_small.png" /></td>
                  <td>Yönetici iletiþim bilgisine eriþim<br />
                    <span>(PÝK Veritabaný / Ýlan baþvurularý)</span></td>
                  <td><strong>3</strong> PÝK kredi / aday</td>
                </tr>
                <tr>
                  <td valign="top" style="padding:7px 0 0 8px;"><img src="images/bg/puzzle_green_small.png" /></td>
                  <td>PÝK görüþmesi olan yönetici<br />
                    adaylarýnýn iþe alýmý</td>
                  <td>Adayýn aylýk maaþýna<br />baðlý PÝK Kredi ödemesi</td>
                </tr>
                <tr>
                  <td valign="top" style="padding:7px 0 0 8px;"><img src="images/bg/puzzle_orange_small.png" /></td>
                  <td>Ýlk on arasýnda ilan verme</td>
                  <td><strong>10</strong> PÝK kredi / ilan</td>
                </tr>
                <tr>
                  <td valign="top" style="padding:7px 0 0 8px;"><img src="images/bg/puzzle_blue_small.png" /></td>
                  <td>Ýkinci on arasýnda ilan verme</td>
                  <td><strong>5</strong> PÝK kredi / ilan</td>
                </tr>
              </table>
            </div>
          </div></td>
        <td style="width:17px;">&nbsp;</td>
          <td valign="top" class="TeaserTable" style="width: 291px;">
              <div class="BoxPadder">
                  <h2 class="TeaserHeaderTaglined">
                      PÝK Kredili Hizmetlerimiz</h2>
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
          <p style="margin:0 0 0 30px;">Çalýþmanýzýn her anýnda PÝK kredi alabilirsiniz. PÝK kredi takibini sistem tarafýndan otomatik olarak yapýlýr. Kredilerinizi bir yýl içinde kullanmak zorundasýnýz, kullanýlmayan krediler silinecektir.</p></td>
        <td>&nbsp;</td>
        <td style="border:1px solid #BACDE2;padding:5px;">
			<p style="padding:4px 10px;"><strong>PÝK Kredi Durumu:</strong></p>
          	<p style="background:#E5EDF4;padding:4px 10px;">Kalan Pik krediniz: <span style="font-weight:bold;font-size:130%;"><asp:Label ID="lbRemainingCredits" runat="server"></asp:Label></span></p>
          	<p style="padding:4px 10px;">Son kredi alým tarihi: <asp:Label ID="lbLastCreditTakenDate" runat="server"></asp:Label></p></td>
      </tr>
    </table>
    
    <asp:Panel runat="server" ID="pnlFolders">
    
    <div class="HeaderPB">
      <h2 class="sIFRHeader">Klasörlerim</h2>
    </div>
    <div class="CorpMainPageFolderInfo1"><img src="images/bg/corp_mainpage_folder_hd1.png" /><p><strong><asp:HyperLink ID="hplUsersToTake" runat="server" Text=" adet aday özgeçmiþ mevcut" NavigateUrl="#Company-Folders-FolderDetail&FolderID="></asp:HyperLink></strong></p>
    </div>
    <div class="CorpMainPageFolderInfo2"><img src="images/bg/corp_mainpage_folder_hd2.png" /><p><strong><asp:HyperLink ID="hplUsersTaken" runat="server" Text=" adet açýk özgeçmiþ mevcut" NavigateUrl="#Company-Folders-FolderDetail&FolderID="></asp:HyperLink></strong></p>
    </div>
    <p>
    <asp:Label ID="lbFolderInformation" runat="server" Text="Sadece Ýletiþim Bilgisi Satýnalma istekleri  ve Ýletiþim bilgisi Satýn Alýnanlar klasörleri sizlere sitem tarafýndan atanmýþtýr."></asp:Label>
    </asp:Panel>
    </p>
    <br />
    <asp:Panel runat="server" ID="pnlJobs">
    
    <div class="HeaderPB floatLeft">
        <h2 class="sIFRHeader">
            Güncel Ýlanlarým</h2>
    </div>
    <div id="Tab">
        <ul>
            <li class="NoTab"><a href="#Company-Jobs-PublicJobs&JobStatus=1">Tüm Ýlanlar...</a></li>
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
                        <strong>Baþvuru</strong></th>
                    <th nowrap="nowrap" style="width: 20%;">
                        <strong>Bitiþ Tarihi</strong></th>
                    <th style="width: 10%;">
                        <div align="center">
                            <strong>Ýstatistik</strong></div>
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
                        OnClick="lnbUpdate_Click" Text="Güncelle"></asp:LinkButton>
                    /
                    <asp:LinkButton ID="lnbArchive" runat="server" CommandArgument='<%#DataBinder.Eval(Container.DataItem, "JobID")%>'
                        OnClick="lnbArchive_Click" Text="Arþivle"></asp:LinkButton>
                    
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


