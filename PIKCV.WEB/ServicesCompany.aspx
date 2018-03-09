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

    <title> PIKCV | Perakende �nsan Kaynaklar� </title>

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
                  <h2 class="sIFRHeader">Renkli D�nyam�zda Neler Var?</h2>
                </div><div class="Services">
                  <ul class="Hilites">
                    <div>
                      <li class="Hilite5"><strong>Resimli tarama</strong><br />
                        Sizi temsil edecek adaylar�n b�y�k boy foto�raf ve bilgilerle g�r�nt�lenmesi.</li>
                      <li class="Hilite6"><strong>Ayr��t�rma</strong><br />
                        Y�netici ve uzman / eleman adaylar� i�in farkl� data bankalar�.</li>
                      <li class="Hilite7"><strong>Test �art�</strong><br />
                        Ba�vurularda genel yetenek ve yetkinlik test zorunlulu�u.</li>
                      <li class="Hilite8"><strong>G�ncel CV</strong><br />
                        6 ayda bir g�ncellenmeyen CV'lerin otomatik elenmesi.</li>
                    </div>
                    <div>
                      <li class="Hilite9"><strong>�� g�r��mesi �art�</strong><br />
                        Y�netici havuzunda yer alan adaylar�n P�K g�r��mesinden ge�mesi.</li>
                      <li class="Hilite10"><strong>�ncelik belirleme</strong><br />
                        Aran�lan �zellikleri puanlayarak ba�vurular� de�erlendirme.</li>
                      <li class="Hilite11"><strong>Pozisyon tan�mlar�</strong><br />
                        Aran�lan i�in tam anla��lmas� i�in i�lerin tan�mlanmas�.</li>
                      <li class="Hilite12"><strong>Kolay �deme</strong><br />
                        Yap�lan t�m i�lemler i�in kredi sistemi kullan�m�</li>
                    </div>
                  </ul>
                </div>
                <div class="brclear"></div></td>
            </tr>
          </table>
          <table width="100%">
            <tr>
              <td valign="top" style="width:32%"><div class="HeaderPB">
                  <h2 class="sIFRHeader">�cretsiz Servislerimiz</h2>
                </div>
                <ul class="List">
                  <li>Standart ilan</li>
                  <li>�lana gelen ba�vurular� tarama, �zge�mi� inceleme, test sonu�lar�n� g�rebilme*</li>
                  <li>P�Kcv veritaban�nda aday tarama, �zge�mi�  inceleme, test sonu�lar�n� g�rebilme*</li>
                  <li>P�K m�lakatl� y�netici adaylar�n m�lakat sonu�lar�n� g�rebilme*</li>
                </ul>
                <p class="mute">* P�Kcv veritaban� ve ba�vuru taramalar�nda adaylar�n ileti�im bilgilerine eri�ilemez, ileti�im bilgisine eri�im i�in P�K kredi kullan�l�r.</p>
                <p>&nbsp;</p>
                <p>&nbsp;</p>
                <div class="HeaderPR">
                  <h2 class="sIFRHeader">Pik Kredi Takibi</h2>
                </div><p>�al��man�z�n her an�nda ek PIK kredi alabilirsiniz. Al�nan hizmetler kapsam�nda P�K Kredi takibi sistem taraf�ndan otomatik olarak yap�l�r . �irketlerimiz alm�� olduklar� P�K kredileri bir y�l i�inde kullanmak zorundad�r, son al�nan kredi tarihi dikkate al�narak aktif edilmeyen krediler silinecektir.</p>
                <p>&nbsp;</p>
                <p>&nbsp;</p>
                <div class="HeaderPG">
                  <h2 class="sIFRHeader">�zel Projeler</h2>
                </div><p>�zel projeleriniz i�in eleman temini konusunda verdi�imiz dan��manl�k hizmetinden yaralanabilirsiniz. �htiya� duyulan pozisyon i�in i� tan�m� olu�turulmas�, uygun adaylar�n se�imi, test uygulamas�, i� g�r��mesi ve aday listesinin olu�turulmas�n� kapsamaktad�r.</p>
                <p>&nbsp;</p></td>
              <td style="width:2%">&nbsp;</td>
              <td valign="top" style="width:66%"><table width="100%">
                  <tr>
                    <td width="48%" valign="top"><div class="HeaderPB">
                        <h2 class="sIFRHeader">Pik Kredili Servislerimiz</h2>
                      </div>
                      <table class="TeaserPikKrediTable1" style="width:100%">
                        <tr>
                          <td valign="top">Uzman / eleman ileti�im bilgisine eri�im (P�K Veritaban� / �lan ba�vurular�)</td>
                          <td valign="top"><strong>1</strong> P�K kredi / aday</td>
                        </tr>
                        <tr>
                          <td valign="top">Y�netici ileti�im bilgisine eri�im (P�K Veritaban� / �lan ba�vurular�)</td>
                          <td valign="top"><strong>3</strong> P�K kredi / aday</td>
                        </tr>
                        <tr>
                          <td valign="top">P�K g�r��mesi olan y�netici adaylar�n�n i�e al�m�</td>
                          <td valign="top">Aday�n ayl�k maa��na ba�l� P�K Kredi �demesi * </td>
                        </tr>
                        <tr>
                          <td valign="top">�lk on aras�nda ilan verme</td>
                          <td valign="top"><strong>10</strong> P�K kredi / ilan</td>
                        </tr>
                        <tr>
                          <td valign="top">�kinci on aras�nda ilan verme</td>
                          <td valign="top"><strong>5</strong> P�K kredi / ilan</td>
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
                <p class="mute"><strong>* P�K M�lakatl� Y�neticinin ��e Al�m�nda 
                  �denmesi Gereken P�K Krediler</strong><br />
                  P�K taraf�ndan m�lakat� yap�lm�� olan y�neticilerin �irketler taraf�ndan i�e al�nmas� durumunda bir defaya mahsus olarak y�neticilerin ayl�k maa�lar� dikkate al�narak a�a��da belirtilen ayl�k maa� aral�klar�n�n kar��s�nda yer alan P�K kredi �demesi yap�l�r.</p>
                <p>&nbsp;</p>
                <table width="100%" class="BorderedTable">
                  <tr>
                    <td class="PikBlueDark" colspan="4" align="center"><strong>��e Al�m �deme Listesi</strong></td>
                  </tr>
                  <tr>
                    <td class="PikBlueLite" align="right"><strong>Ayl�k Maa�lar</strong></td>
                    <td align="right" class="PikBlueMiddle"><strong>P�K Kredi �demesi</strong></td>
                    <td class="PikBlueLite" align="right"><strong>Ayl�k Maa�lar</strong></td>
                    <td align="right" class="PikBlueMiddle"><strong>P�K Kredi �demesi</strong></td>
                  </tr>
                  <tr>
                    <td align="right"><strong>1000 - 1500 YTL</strong></td>
                    <td align="right" class="PikBlueLite">120 P�K Kredi - 1200 YTL</td>
                    <td align="right"><strong>6501 - 7000 YTL</strong></td>
                    <td align="right" class="PikBlueLite">867 P�K Kredi - 7800 YTL</td>
                  </tr>
                  <tr>
                    <td align="right"><strong>1501 - 2000 YTL</strong></td>
                    <td align="right" class="PikBlueLite">180 P�K Kredi - 1800 YTL</td>
                    <td align="right"><strong>7001 - 7500 YTL</strong></td>
                    <td align="right" class="PikBlueLite">933 P�K Kredi - 8400 YTL</td>
                  </tr>
                  <tr>
                    <td align="right"><strong>2001 - 2500 YTL</strong></td>
                    <td align="right" class="PikBlueLite">240 P�K Kredi - 2400 YTL</td>
                    <td align="right"><strong>7501 - 8000 YTL</strong></td>
                    <td align="right" class="PikBlueLite">1000 P�K Kredi - 9000 YTL</td>
                  </tr>
                  <tr>
                    <td align="right"><strong>2501 - 3000 YTL</strong></td>
                    <td align="right" class="PikBlueLite">316 P�K Kredi - 3000 YTL</td>
                    <td align="right"><strong>8001 - 8500 YTL</strong></td>
                    <td align="right" class="PikBlueLite">1067 P�K Kredi - 9600 YTL</td>
                  </tr>
                  <tr>
                    <td align="right"><strong>3001 - 3500 YTL</strong></td>
                    <td align="right" class="PikBlueLite">379 P�K Kredi - 3600 YTL</td>
                    <td align="right"><strong>8501 - 9000 YTL</strong></td>
                    <td align="right" class="PikBlueLite">1200 P�K Kredi - 10200 YTL</td>
                  </tr>
                  <tr>
                    <td align="right"><strong>3501 - 4000 YTL</strong></td>
                    <td align="right" class="PikBlueLite">442 P�K Kredi - 4200 YTL</td>
                    <td align="right"><strong>9001 - 9500 YTL</strong></td>
                    <td align="right" class="PikBlueLite">1271 P�K Kredi - 10800 YTL</td>
                  </tr>
                  <tr>
                    <td align="right"><strong>4001 - 4500 YTL</strong></td>
                    <td align="right" class="PikBlueLite">506 P�K Kredi - 4800 YTL</td>
                    <td align="right"><strong>9501 - 10000 YTL</strong></td>
                    <td align="right" class="PikBlueLite">1341 P�K Kredi - 11400 YTL</td>
                  </tr>
                  <tr>
                    <td align="right"><strong>4501 - 5000 YTL</strong></td>
                    <td align="right" class="PikBlueLite">600 P�K Kredi - 5400 YTL</td>
                    <td align="right"><strong>10001 - 10500 YTL</strong></td>
                    <td align="right" class="PikBlueLite">1412 P�K Kredi - 12000 YTL</td>
                  </tr>
                  <tr>
                    <td align="right"><strong>5001 - 5500 YTL</strong></td>
                    <td align="right" class="PikBlueLite">666 P�K Kredi - 6000 YTL</td>
                    <td align="right"><strong>10501 - 11000 YTL</strong></td>
                    <td align="right" class="PikBlueLite">1482 P�K Kredi - 12600 YTL</td>
                  </tr>
                  <tr>
                    <td align="right"><strong>5501 - 6000 YTL</strong></td>
                    <td align="right" class="PikBlueLite">733 P�K Kredi - 6600 YTL</td>
                    <td align="right"><strong>11001 - 11500 YTL</strong></td>
                    <td align="right" class="PikBlueLite">1553 P�K Kredi - 13200 YTL</td>
                  </tr>
                  <tr>
                    <td align="right"><strong>6001 - 6500 YTL</strong></td>
                    <td align="right" class="PikBlueLite">800 P�K Kredi - 7200 YTL</td>
                    <td align="right"><strong>11501 - 12000 YTL</strong></td>
                    <td align="right" class="PikBlueLite">1625 P�K Kredi - 13800 YTL</td>
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
