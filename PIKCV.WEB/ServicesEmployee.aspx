<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ServicesEmployee.aspx.cs" Inherits="ServicesEmployee" %>

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
              <td style="width:2%">&nbsp;</td>
			  <td valign="top" style="width:66%"><div class="HeaderPR">
                  <h2 class="sIFRHeader">Renkli Dünyamýzda Neler Var?</h2>
                </div>
                <div class="Services">
                  <ul class="Hilites">
                    <div>
                      <li class="Hilite5"><strong>PÝKcv Veritabaný</strong><br />
                        PÝKcv veritabaný, üye þirketlerimizin ücretsiz olarak kullanýmýna açýktýr. Sitemizde yer alan özgeçmiþleriniz sadece ilanlara yapýlan baþvurular için deðil þirketlerimizin ihtiyaçlarý kapsamýna sürekli deðerlendirilir.</li>
                      <li class="Hilite1"><strong>Danýþmanlýk Hizmeti</strong><br />
                        Þirketimiz iþe alým danýþmanlýðý kapsamýnda verdiði hizmetler süresince sitemizin veri tabanýný kullanmakta ve PÝKcv.com’da yer alan sizlerin danýþmanlýk yaptýðýmýz þirketler için uygun olmasý durumunda gerekli yönlendirmeleri yapmaktadýr.</li>
                      <li class="Hilite11"><strong>Pozisyon tanýmlarý</strong><br />
                        Çalýþmayý tercih ettiðiniz pozisyon seçimini yaparken kýsa iþ tanýmýný okuyabilir, bilmediðiniz pozisyonlar konusunda bilgi edinebilirsiniz.</li>
                      <li class="Hilite8"><strong>Güncel Özgeçmiþ</strong><br />
                        Sitemizde yer alan tüm özgeçmiþ bilgilerinizin 6 ayda bir güncellenmesi gerekmektedir. Güncelleme mesajlarý sistem tarafýndan otomatik olarak sizlere iletilecektir. Güncel özgeçmiþler üye þirketlerimiz tarafýndan iþe alým aþamasýnda önemli bir deðerlendirme kriteridir.</li>
                    </div>
                    <div>
                      <li class="Hilite9"><strong>Size Uygun Ýlanlar</strong><br />
                        Özgeçmiþiniz ve çalýþmak istediðiniz pozisyonlarý dikkate alarak belirlediðimiz size özel ilanlar ile zamanýnýzý daha etkin kullanabilir ve kendinize uygun ilanlara hýzla ulaþabilirsiniz.</li>
                      <li class="Hilite6"><strong>Size Özel Filtrelemeleri Kayýt Ýmkaný</strong><br />
                        Ýstediðiniz ilan arama kriterlerini filtre olarak kaydedebilir ve zaman kaybetmeden hýzlý arama yapabilirsiniz.</li>
                      <li class="Hilite7"><strong>Kiþisel Keþif</strong><br />
                        Sitemizde genel yetenek ve yetkinlik testi uygulamasý yapýlmaktadýr. Bize özel olarak Ýnsanbilim Enstitüsü tarafýndan hazýrlanan testlerin tüm kullaným haklarý þirketimize aittir. Testlerimiz kiþisel farkýndalýk ve geliþiminize destek olmakla birlikte iþverenlerin sizi daha yakýndan tanýmasý ve iþe alým sürecini hýzlanlandýrmasý açýsýndan önem taþýmaktadýr.</li>
                      <li class="Hilite4"><strong>Kaldýðýnýz Bölümden Devam Etme Ýmkaný</strong><br />
                        Üyelik onayý öncesinde sitemize birden fazla giriþ yapmanýz durumunda iþlemlerinize kaldýðýnýz yerden devam edebilirsiniz.</li>
                    </div>
                  </ul>
                </div>
                <div class="brclear"></div>
                <p>&nbsp;</p>
                <p>&nbsp;</p></td>
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
