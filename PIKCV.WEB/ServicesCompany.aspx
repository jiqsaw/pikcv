<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ServicesCompany.aspx.cs" Inherits="ServicesCompany" %>
<%@ Register Src="~/UserControls/Common/uTop.ascx" TagName="uTop" TagPrefix="uc3" %>
<%@ Register Src="~/UserControls/Common/uFooter.ascx" TagName="uFooter" TagPrefix="uc2" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">

    <!-- #INCLUDE FILE="./Incs/Head.inc" -->

<!-- Import css/ -->
    <link href="./Styles/pikcv_print.css" rel="stylesheet" type="text/css" media="print" />
    <link href="./Styles/reset.css" rel="stylesheet" type="text/css" />
    <link href="./Styles/fonts.css" rel="stylesheet" type="text/css" />
    <link href="./Styles/Paging.css" rel="stylesheet" type="text/css" />
    <link href="./Styles/Custom.css" rel="stylesheet" type="text/css" />
    <link href="./Styles/pikcv_screen.css" rel="stylesheet" type="text/css" media="screen" />
    <link href="./Styles/custom.css" rel="stylesheet" type="text/css" media="screen" />
    <script type="text/javascript" src="./Scripts/Custom.js"></script>
    
    
    <!-- IE6 conditional comment -->
    <!--[if lte IE 6]>
    <link href="./Styles/pikcv_screen_ie6.css" rel="stylesheet" type="text/css" />
    <![endif]-->
    <!--[if IE 7]>
    <link href="./Styles/pikcv_screen_ie7.css" rel="stylesheet" type="text/css" />
    <![endif]-->
<!--// Import css/ -->

    <title> PIKCV | Perakende Ýnsan Kaynaklarý </title>

</head>
<body id="GenericPage">
    <!-- #INCLUDE FILE="./Incs/JSControl.inc" -->
    <form id="form1" runat="server">

    <asp:ScriptManager id="ScrMng1" runat="server" EnablePartialRendering="true">
    <%-- AsyncPostBackTimeout="3600" OnAsyncPostBackError="HandleError">--%>
        <Scripts>
            <asp:ScriptReference Path="~/Scripts/swfobject.js" />
            <asp:ScriptReference Path="~/Scripts/Util.js" />
            <asp:ScriptReference Path="~/Scripts/Custom.js" />
            <asp:ScriptReference Path="~/Scripts/ListboxHelper.js" />
            <asp:ScriptReference Path="~/Scripts/ModalPopup.js" />
        </Scripts>
    </asp:ScriptManager>
    
    <div id="wrapper">
    
        <%-- START HEADER --%>
        <uc3:uTop ID="uTop1" runat="server" />
        <%--END HEADER--%>
    
<div id="content">
    <div class="contentPad">
      <div class="brclear"></div>
      <!-- start roundcornered box -->
      <div class="BoxContentTop"></div>
      <div class="BoxContent">
        <div class="BoxPadder">
          <table width="100%">
            <tr>
              <td valign="top" style="width:32%"><img src="images/misc/about_us.jpg" /></td>
              <td valign="top" style="width:2%"></td>
              <td valign="top" style="width:66%"><div class="HeaderPR">
                  <h2 class="sIFRHeader">Renkli Dünyamýzda Neler Var?</h2>
                </div><div class="Services">
                  <ul class="Hilites">
                    <div>
                      <li class="Hilite5"><strong>Resimli tarama</strong><br />
                        Sizi temsil edecek adaylarýn büyük boy fotoðraf ve bilgilerle görüntülenmesi.</li>
                      <li class="Hilite6"><strong>Ayrýþtýrma</strong><br />
                        Yönetici ve uzman / eleman adaylarý için farklý data bankalarý.</li>
                      <li class="Hilite7"><strong>Test þartý</strong><br />
                        Baþvurularda genel yetenek ve yetkinlik test zorunluluðu.</li>
                      <li class="Hilite8"><strong>Güncel CV</strong><br />
                        6 ayda bir güncellenmeyen CV'lerin otomatik elenmesi.</li>
                    </div>
                    <div>
                      <li class="Hilite9"><strong>Ýþ görüþmesi þartý</strong><br />
                        Yönetici havuzunda yer alan adaylarýn PÝK görüþmesinden geçmesi.</li>
                      <li class="Hilite10"><strong>Öncelik belirleme</strong><br />
                        Aranýlan özellikleri puanlayarak baþvurularý deðerlendirme.</li>
                      <li class="Hilite11"><strong>Pozisyon tanýmlarý</strong><br />
                        Aranýlan iþin tam anlaþýlmasý için iþlerin tanýmlanmasý.</li>
                      <li class="Hilite12"><strong>Kolay Ödeme</strong><br />
                        Yapýlan tüm iþlemler için kredi sistemi kullanýmý</li>
                    </div>
                  </ul>
                </div>
                <div class="brclear"></div></td>
            </tr>
          </table>
          <table width="100%">
            <tr>
              <td valign="top" style="width:32%"><div class="HeaderPB">
                  <h2 class="sIFRHeader">Ücretsiz Servislerimiz</h2>
                </div>
                <ul class="List">
                  <li>Standart ilan</li>
                  <li>Ýlana gelen baþvurularý tarama, özgeçmiþ inceleme, test sonuçlarýný görebilme*</li>
                  <li>PÝKcv veritabanýnda aday tarama, özgeçmiþ  inceleme, test sonuçlarýný görebilme*</li>
                  <li>PÝK mülakatlý yönetici adaylarýn mülakat sonuçlarýný görebilme*</li>
                </ul>
                <p class="mute">* PÝKcv veritabaný ve baþvuru taramalarýnda adaylarýn iletiþim bilgilerine eriþilemez, iletiþim bilgisine eriþim için PÝK kredi kullanýlýr.</p>
                <p>&nbsp;</p>
                <p>&nbsp;</p>
                <div class="HeaderPR">
                  <h2 class="sIFRHeader">Pik Kredi Takibi</h2>
                </div><p>Çalýþmanýzýn her anýnda ek PIK kredi alabilirsiniz. Alýnan hizmetler kapsamýnda PÝK Kredi takibi sistem tarafýndan otomatik olarak yapýlýr . Þirketlerimiz almýþ olduklarý PÝK kredileri bir yýl içinde kullanmak zorundadýr, son alýnan kredi tarihi dikkate alýnarak aktif edilmeyen krediler silinecektir.</p>
                <p>&nbsp;</p>
                <p>&nbsp;</p>
                <div class="HeaderPG">
                  <h2 class="sIFRHeader">Özel Projeler</h2>
                </div><p>Özel projeleriniz için eleman temini konusunda verdiðimiz danýþmanlýk hizmetinden yaralanabilirsiniz. Ýhtiyaç duyulan pozisyon için iþ tanýmý oluþturulmasý, uygun adaylarýn seçimi, test uygulamasý, iþ görüþmesi ve aday listesinin oluþturulmasýný kapsamaktadýr.</p>
                <p>&nbsp;</p></td>
              <td style="width:2%">&nbsp;</td>
              <td valign="top" style="width:66%"><table width="100%">
                  <tr>
                    <td width="48%" valign="top"><div class="HeaderPB">
                        <h2 class="sIFRHeader">Pik Kredili Servislerimiz</h2>
                      </div>
                      <table class="TeaserPikKrediTable1" style="width:100%">
                        <tr>
                          <td valign="top">Uzman / eleman iletiþim bilgisine eriþim (PÝK Veritabaný / Ýlan baþvurularý)</td>
                          <td valign="top"><strong>1</strong> PÝK kredi / aday</td>
                        </tr>
                        <tr>
                          <td valign="top">Yönetici iletiþim bilgisine eriþim (PÝK Veritabaný / Ýlan baþvurularý)</td>
                          <td valign="top"><strong>3</strong> PÝK kredi / aday</td>
                        </tr>
                        <tr>
                          <td valign="top">PÝK görüþmesi olan yönetici adaylarýnýn iþe alýmý</td>
                          <td valign="top">Adayýn aylýk maaþýna baðlý PÝK Kredi ödemesi * </td>
                        </tr>
                        <tr>
                          <td valign="top">Ýlk on arasýnda ilan verme</td>
                          <td valign="top"><strong>10</strong> PÝK kredi / ilan</td>
                        </tr>
                        <tr>
                          <td valign="top">Ýkinci on arasýnda ilan verme</td>
                          <td valign="top"><strong>5</strong> PÝK kredi / ilan</td>
                        </tr>
                      </table></td>
                    <td>&nbsp;</td>
                    <td width="48%" valign="top"><div class="HeaderPB">
                        <h2 class="sIFRHeader">Pik Kredi Paketlerimiz</h2>
                      </div>
                      <table class="TeaserPikKrediTable2" style="width:100%">
                        <tr>
                          <td valign="top"><div class="PikKrediValue-Blue">25</div></td>
                          <td><strong><span class="Hilite1">Pik Kredi - 250 YTL</span></strong></td>
                        </tr>
                        <tr>
                          <td valign="top"><div class="PikKrediValue-Blue">50</div></td>
                          <td><strong><span class="Hilite2">Pik Kredi - 500 YTL</span></strong></td>
                        </tr>
                        <tr>
                          <td valign="top"><div class="PikKrediValue-Blue">150</div></td>
                          <td><strong><span class="Hilite3">Pik Kredi - 1500 YTL</span></strong></td>
                        </tr>
                        <tr>
                          <td valign="top"><div class="PikKrediValue-Blue">300</div></td>
                          <td><strong><span class="Hilite4">Pik Kredi - 2850 YTL</span></strong></td>
                        </tr>
                        <tr>
                          <td valign="top"><div class="PikKrediValue-Blue">600</div></td>
                          <td><strong><span class="Hilite1">Pik Kredi - 5400 YTL</span></strong></td>
                        </tr>
                        <tr>
                          <td valign="top"><div class="PikKrediValue-Blue">1200</div></td>
                          <td><strong><span class="Hilite1">Pik Kredi - 10200 YTL</span></strong></td>
                        </tr>
                        <tr>
                          <td valign="top"><div class="PikKrediValue-Blue">2500+</div></td>
                          <td><strong><span class="Hilite1">Pik Kredi - 8 YTL/kredi</span></strong></td>
                        </tr>
                      </table></td>
                  </tr>
                </table>
                <p>&nbsp;</p>
                <p class="mute"><strong>* PÝK Mülakatlý Yöneticinin Ýþe Alýmýnda 
                  Ödenmesi Gereken PÝK Krediler</strong><br />
                  PÝK tarafýndan mülakatý yapýlmýþ olan yöneticilerin þirketler tarafýndan iþe alýnmasý durumunda bir defaya mahsus olarak yöneticilerin aylýk maaþlarý dikkate alýnarak aþaðýda belirtilen aylýk maaþ aralýklarýnýn karþýsýnda yer alan PÝK kredi ödemesi yapýlýr.</p>
                <p>&nbsp;</p>
                <table width="100%" class="BorderedTable">
                  <tr>
                    <td class="PikBlueDark" colspan="4" align="center"><strong>Ýþe Alým Ödeme Listesi</strong></td>
                  </tr>
                  <tr>
                    <td class="PikBlueLite" align="right"><strong>Aylýk Maaþlar</strong></td>
                    <td align="right" class="PikBlueMiddle"><strong>PÝK Kredi Ödemesi</strong></td>
                    <td class="PikBlueLite" align="right"><strong>Aylýk Maaþlar</strong></td>
                    <td align="right" class="PikBlueMiddle"><strong>PÝK Kredi Ödemesi</strong></td>
                  </tr>
                  <tr>
                    <td align="right"><strong>1000 - 1500 YTL</strong></td>
                    <td align="right" class="PikBlueLite">120 PÝK Kredi - 1200 YTL</td>
                    <td align="right"><strong>6501 - 7000 YTL</strong></td>
                    <td align="right" class="PikBlueLite">867 PÝK Kredi - 7800 YTL</td>
                  </tr>
                  <tr>
                    <td align="right"><strong>1501 - 2000 YTL</strong></td>
                    <td align="right" class="PikBlueLite">180 PÝK Kredi - 1800 YTL</td>
                    <td align="right"><strong>7001 - 7500 YTL</strong></td>
                    <td align="right" class="PikBlueLite">933 PÝK Kredi - 8400 YTL</td>
                  </tr>
                  <tr>
                    <td align="right"><strong>2001 - 2500 YTL</strong></td>
                    <td align="right" class="PikBlueLite">240 PÝK Kredi - 2400 YTL</td>
                    <td align="right"><strong>7501 - 8000 YTL</strong></td>
                    <td align="right" class="PikBlueLite">1000 PÝK Kredi - 9000 YTL</td>
                  </tr>
                  <tr>
                    <td align="right"><strong>2501 - 3000 YTL</strong></td>
                    <td align="right" class="PikBlueLite">316 PÝK Kredi - 3000 YTL</td>
                    <td align="right"><strong>8001 - 8500 YTL</strong></td>
                    <td align="right" class="PikBlueLite">1067 PÝK Kredi - 9600 YTL</td>
                  </tr>
                  <tr>
                    <td align="right"><strong>3001 - 3500 YTL</strong></td>
                    <td align="right" class="PikBlueLite">379 PÝK Kredi - 3600 YTL</td>
                    <td align="right"><strong>8501 - 9000 YTL</strong></td>
                    <td align="right" class="PikBlueLite">1200 PÝK Kredi - 10200 YTL</td>
                  </tr>
                  <tr>
                    <td align="right"><strong>3501 - 4000 YTL</strong></td>
                    <td align="right" class="PikBlueLite">442 PÝK Kredi - 4200 YTL</td>
                    <td align="right"><strong>9001 - 9500 YTL</strong></td>
                    <td align="right" class="PikBlueLite">1271 PÝK Kredi - 10800 YTL</td>
                  </tr>
                  <tr>
                    <td align="right"><strong>4001 - 4500 YTL</strong></td>
                    <td align="right" class="PikBlueLite">506 PÝK Kredi - 4800 YTL</td>
                    <td align="right"><strong>9501 - 10000 YTL</strong></td>
                    <td align="right" class="PikBlueLite">1341 PÝK Kredi - 11400 YTL</td>
                  </tr>
                  <tr>
                    <td align="right"><strong>4501 - 5000 YTL</strong></td>
                    <td align="right" class="PikBlueLite">600 PÝK Kredi - 5400 YTL</td>
                    <td align="right"><strong>10001 - 10500 YTL</strong></td>
                    <td align="right" class="PikBlueLite">1412 PÝK Kredi - 12000 YTL</td>
                  </tr>
                  <tr>
                    <td align="right"><strong>5001 - 5500 YTL</strong></td>
                    <td align="right" class="PikBlueLite">666 PÝK Kredi - 6000 YTL</td>
                    <td align="right"><strong>10501 - 11000 YTL</strong></td>
                    <td align="right" class="PikBlueLite">1482 PÝK Kredi - 12600 YTL</td>
                  </tr>
                  <tr>
                    <td align="right"><strong>5501 - 6000 YTL</strong></td>
                    <td align="right" class="PikBlueLite">733 PÝK Kredi - 6600 YTL</td>
                    <td align="right"><strong>11001 - 11500 YTL</strong></td>
                    <td align="right" class="PikBlueLite">1553 PÝK Kredi - 13200 YTL</td>
                  </tr>
                  <tr>
                    <td align="right"><strong>6001 - 6500 YTL</strong></td>
                    <td align="right" class="PikBlueLite">800 PÝK Kredi - 7200 YTL</td>
                    <td align="right"><strong>11501 - 12000 YTL</strong></td>
                    <td align="right" class="PikBlueLite">1625 PÝK Kredi - 13800 YTL</td>
                  </tr>
                </table>
                <p>&nbsp;</p>
                <p class="mute">&nbsp;</p></td>
            </tr>
          </table>
        </div>
      </div>
      <div class="BoxContentBottom"></div>
      <!-- finish roundcornered box -->
      <p>&nbsp;</p>
    </div>
  </div>

        <uc2:uFooter ID="UFooter1" runat="server" />
    
    </div>
    </form>
</body>
</html>
