<%@ Page Language="C#" AutoEventWireup="true" CodeFile="About.aspx.cs" Inherits="About" %>
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
              <td valign="top" style="width:34%"><img src="images/misc/about_us.jpg" /></td>
              <td style="width:66%"><div class="HeaderPR">
                  <h2 class="sIFRHeader">Hakkýmýzda</h2>
                </div>
                <p>&nbsp;</p>
                <p><strong>Þirketimiz Perakende sektöründe iþe alým danýþmanlýðý vermek amacýyla kurulmuþtur.</strong></p>
                <p>&nbsp;</p>
                <p><strong>Pikcv.com</strong> iþ arayan adaylarla eleman arayan iþverenleri bir   araya getirir ve iþverenlerin kýsa sürede doðru adaya ulaþmasýný saðlar.   Sitemizde yer alan adaylarýn özgeçmiþleri uygun olmasý durumunda danýþmanlýk   hizmeti verdiðimiz þirketlerimize yönlendirilir.</p>
                <p>&nbsp;</p>
                <p>Ýþ arayan bireysel kullanýcýlarýmýz PÝKcv.com’a üye olurken ve daha sonra yararlanacaklarý hizmetler için herhangi bir ücret ödemezler.</p>
                <p>&nbsp;</p>
                <p>Perakenden Ýnsan Kaynaklarý olarak hedefimiz bireysel ve kurumsal üyelerimize iþe alým sürecinde fark yaratarak sürecin kalitesini arttýrmaktýr; </p>
                <p>&nbsp;</p>
                <p>Sitemizde uygulanan testler <a href="http://www.insanbilim.com.tr" target="_blank">Ýnsanbilim Enstitüsü</a> tarafýndan bize özel olarak hazýrlanmýþtýr ve tüm kullaným haklarý þirketimize aittir. Testlerimiz bireysel kullanýcýlarýmýza kendilerini analiz etme, üye þirketlerimize ise adaylarý daha yakýndan tanýma ve deðerlendirme imkaný verir.</p>
                <p><strong>PÝKMAT Genel Yetenek Testi</strong>, kiþilerin belirli iliþkileri kavrayabilme, analiz edebilme, sonuca varabilme gibi   zihinsel özelliklerini ölçmektedir.</p>
                <p><strong>PÝK Yetkinlik Testi</strong>, personel seçiminde yetkinlik bazlý bireysel deðerlendirme yapmaya yarayan bir ölçme aracýdýr.</p>
                <p>&nbsp;</p>
                <p>PÝKcv.com veritabanýmýzda yer alan adaylar onlar için hazýrlamýþ olduðumuz kýsa iþ tanýmlarýný kullanabilir ve çalýþmak istedikleri pozisyon seçimini kendilerine uygun olanlar üzerinden yapabilirler.</p>
                <p>&nbsp;</p>
                <p>Sitemizde uzman/eleman ve yönetici adaylarý için farklý bilgi bankalarý bulunmaktadýr.</p>
                <p>&nbsp;</p>
                <p>PÝKcv.com’da iþ görüþmesi yapýlan adaylarýmýz, üye þirketlerimizin iþgücü ihtiyacýný en kýsa sürede ve hedeflenen kalitede teminini saðlar.</p>
                <p>&nbsp;</p>
                <p>&nbsp;</p>
                <a href="2_1_is_arayan_anasayfa.htm"><img src="images/home/search_job.png" alt="Ýþ Arýyorum..." border="0" /></a>&nbsp;&nbsp;&nbsp;&nbsp;<a href="3_1_isveren_anasayfa.htm"><img src="images/home/search_people.png" alt="Eleman arýyorum..." border="0" /></a>
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
