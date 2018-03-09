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
              <td valign="top" style="width:34%"><img src="images/misc/about_us.jpg" /></td>
              <td style="width:66%"><div class="HeaderPR">
                  <h2 class="sIFRHeader">Hakk�m�zda</h2>
                </div>
                <p>&nbsp;</p>
                <p><strong>�irketimiz Perakende sekt�r�nde i�e al�m dan��manl��� vermek amac�yla kurulmu�tur.</strong></p>
                <p>&nbsp;</p>
                <p><strong>Pikcv.com</strong> i� arayan adaylarla eleman arayan i�verenleri bir   araya getirir ve i�verenlerin k�sa s�rede do�ru adaya ula�mas�n� sa�lar.   Sitemizde yer alan adaylar�n �zge�mi�leri uygun olmas� durumunda dan��manl�k   hizmeti verdi�imiz �irketlerimize y�nlendirilir.</p>
                <p>&nbsp;</p>
                <p>�� arayan bireysel kullan�c�lar�m�z P�Kcv.com�a �ye olurken ve daha sonra yararlanacaklar� hizmetler i�in herhangi bir �cret �demezler.</p>
                <p>&nbsp;</p>
                <p>Perakenden �nsan Kaynaklar� olarak hedefimiz bireysel ve kurumsal �yelerimize i�e al�m s�recinde fark yaratarak s�recin kalitesini artt�rmakt�r; </p>
                <p>&nbsp;</p>
                <p>Sitemizde uygulanan testler <a href="http://www.insanbilim.com.tr" target="_blank">�nsanbilim Enstit�s�</a> taraf�ndan bize �zel olarak haz�rlanm��t�r ve t�m kullan�m haklar� �irketimize aittir. Testlerimiz bireysel kullan�c�lar�m�za kendilerini analiz etme, �ye �irketlerimize ise adaylar� daha yak�ndan tan�ma ve de�erlendirme imkan� verir.</p>
                <p><strong>P�KMAT Genel Yetenek Testi</strong>, ki�ilerin belirli ili�kileri kavrayabilme, analiz edebilme, sonuca varabilme gibi   zihinsel �zelliklerini �l�mektedir.</p>
                <p><strong>P�K Yetkinlik Testi</strong>, personel se�iminde yetkinlik bazl� bireysel de�erlendirme yapmaya yarayan bir �l�me arac�d�r.</p>
                <p>&nbsp;</p>
                <p>P�Kcv.com veritaban�m�zda yer alan adaylar onlar i�in haz�rlam�� oldu�umuz k�sa i� tan�mlar�n� kullanabilir ve �al��mak istedikleri pozisyon se�imini kendilerine uygun olanlar �zerinden yapabilirler.</p>
                <p>&nbsp;</p>
                <p>Sitemizde uzman/eleman ve y�netici adaylar� i�in farkl� bilgi bankalar� bulunmaktad�r.</p>
                <p>&nbsp;</p>
                <p>P�Kcv.com�da i� g�r��mesi yap�lan adaylar�m�z, �ye �irketlerimizin i�g�c� ihtiyac�n� en k�sa s�rede ve hedeflenen kalitede teminini sa�lar.</p>
                <p>&nbsp;</p>
                <p>&nbsp;</p>
                <a href="2_1_is_arayan_anasayfa.htm"><img src="images/home/search_job.png" alt="�� Ar�yorum..." border="0" /></a>&nbsp;&nbsp;&nbsp;&nbsp;<a href="3_1_isveren_anasayfa.htm"><img src="images/home/search_people.png" alt="Eleman ar�yorum..." border="0" /></a>
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
