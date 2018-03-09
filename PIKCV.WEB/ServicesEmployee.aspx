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
              <td style="width:2%">&nbsp;</td>
			  <td valign="top" style="width:66%"><div class="HeaderPR">
                  <h2 class="sIFRHeader">Renkli D�nyam�zda Neler Var?</h2>
                </div>
                <div class="Services">
                  <ul class="Hilites">
                    <div>
                      <li class="Hilite5"><strong>P�Kcv Veritaban�</strong><br />
                        P�Kcv veritaban�, �ye �irketlerimizin �cretsiz olarak kullan�m�na a��kt�r. Sitemizde yer alan �zge�mi�leriniz sadece ilanlara yap�lan ba�vurular i�in de�il �irketlerimizin ihtiya�lar� kapsam�na s�rekli de�erlendirilir.</li>
                      <li class="Hilite1"><strong>Dan��manl�k Hizmeti</strong><br />
                        �irketimiz i�e al�m dan��manl��� kapsam�nda verdi�i hizmetler s�resince sitemizin veri taban�n� kullanmakta ve P�Kcv.com�da yer alan sizlerin dan��manl�k yapt���m�z �irketler i�in uygun olmas� durumunda gerekli y�nlendirmeleri yapmaktad�r.</li>
                      <li class="Hilite11"><strong>Pozisyon tan�mlar�</strong><br />
                        �al��may� tercih etti�iniz pozisyon se�imini yaparken k�sa i� tan�m�n� okuyabilir, bilmedi�iniz pozisyonlar konusunda bilgi edinebilirsiniz.</li>
                      <li class="Hilite8"><strong>G�ncel �zge�mi�</strong><br />
                        Sitemizde yer alan t�m �zge�mi� bilgilerinizin 6 ayda bir g�ncellenmesi gerekmektedir. G�ncelleme mesajlar� sistem taraf�ndan otomatik olarak sizlere iletilecektir. G�ncel �zge�mi�ler �ye �irketlerimiz taraf�ndan i�e al�m a�amas�nda �nemli bir de�erlendirme kriteridir.</li>
                    </div>
                    <div>
                      <li class="Hilite9"><strong>Size Uygun �lanlar</strong><br />
                        �zge�mi�iniz ve �al��mak istedi�iniz pozisyonlar� dikkate alarak belirledi�imiz size �zel ilanlar ile zaman�n�z� daha etkin kullanabilir ve kendinize uygun ilanlara h�zla ula�abilirsiniz.</li>
                      <li class="Hilite6"><strong>Size �zel Filtrelemeleri Kay�t �mkan�</strong><br />
                        �stedi�iniz ilan arama kriterlerini filtre olarak kaydedebilir ve zaman kaybetmeden h�zl� arama yapabilirsiniz.</li>
                      <li class="Hilite7"><strong>Ki�isel Ke�if</strong><br />
                        Sitemizde genel yetenek ve yetkinlik testi uygulamas� yap�lmaktad�r. Bize �zel olarak �nsanbilim Enstit�s� taraf�ndan haz�rlanan testlerin t�m kullan�m haklar� �irketimize aittir. Testlerimiz ki�isel fark�ndal�k ve geli�iminize destek olmakla birlikte i�verenlerin sizi daha yak�ndan tan�mas� ve i�e al�m s�recini h�zlanland�rmas� a��s�ndan �nem ta��maktad�r.</li>
                      <li class="Hilite4"><strong>Kald���n�z B�l�mden Devam Etme �mkan�</strong><br />
                        �yelik onay� �ncesinde sitemize birden fazla giri� yapman�z durumunda i�lemlerinize kald���n�z yerden devam edebilirsiniz.</li>
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
