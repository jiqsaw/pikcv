<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uTests.ascx.cs" Inherits="UserControls_Employee_Membership_uTests" %>
<%@ Register Src="../Common/uCVTabs.ascx" TagName="uCVTabs" TagPrefix="uc1" %>

<script src="Scripts/p7APscripts.js" language="javascript" type="text/javascript"></script>

<div class="contentPad">
      <div class="HeaderPR floatLeft">
        <h2 class="sIFRHeader">
        <asp:Literal runat="server" ID="ltlTitleTest" Text="Testler"></asp:Literal>
        <asp:Literal runat="server" ID="ltlTitleTestPerfection" Text="Yetkinlik Testi" Visible="false"></asp:Literal>
        </h2>
      </div>
      
        <uc1:uCVTabs ID="UCVTabs1" runat="server" />
      
      <div class="brclear"></div>
      <!-- start roundcornered box -->
      <div class="BoxContentTop"></div>
      
    <div class="BoxContent">
      
         <asp:Panel runat="server" ID="pnlTest">   
   
            <div class="BoxPadder">
            <table class="GenericTable">
            <tr>
              <td>
                <div class="infoMsg">
                    <p>Say�n <strong><asp:Literal runat="server" ID="ltlFullName"></asp:Literal>,</strong><br />
                    Sitemizde ilanlara ba�vurabilmeniz ve veritaban� aramalar�nda yer alabilmeniz i�in bu b�l�mde yer alan  testleri alman�z gerekmektedir. 
                    Test sonu�lar�n�z i�e al�m kriterleri aras�nda de�erlendirilecek ve �irketler taraf�ndan g�r�nt�lenecektir.
                    </p>
                </div>
                <p>&nbsp;</p>
                <h3>Sizin i�in haz�rlad���m�z testler: </h3>
                <p>&nbsp;</p>
                <div id="p7ABW1" class="p7AB">
                  <div id="pnlMatLink" runat="server" class="p7ABtrig">
                    <h4>
                        <asp:LinkButton runat="server" ID="lbTestGeneral" Text="Genel Yetenek Testi  (P�KMAT)" OnClick="lbTestGeneral_Click"></asp:LinkButton>
                    <%--<a href="2_2_4_2_testler.htm" id="p7ABt1_1">Genel Yetenek Testi  (P�KMAT)</a>--%>
                    
                    </h4>
                  </div>
                  
                  <div id="pnlPerfectionLink" runat="server" class="p7ABtrig">
                    <h4>
                    <asp:LinkButton runat="server" ID="lbTestPerfection" Text="Yetkinlik Testi (P�KYET?)" OnClick="lbTestPerfection_Click"></asp:LinkButton>
                    </h4>
                  </div>
                
                </div>
              </td>
            </tr>
          </table>
        <div class="brclear"></div>
            
        </div>
      
        </asp:Panel>
        
        <asp:Panel runat="server" ID="pnlTestGeneral1" Visible="false">
        
            <div class="BoxPadder">
                    <p>
                        &nbsp;</p>
                    <ul class="SubTab">
                        <li class="selected">
                            <asp:LinkButton runat="server" ID="lnkTestGeneral1" Text="A��klay�c� Bilgiler" OnClick="lnkTestGeneral1_Click"></asp:LinkButton>
                        </li>
                        <li>
                            <asp:LinkButton runat="server" ID="lnkTestGeneral2" Text="Test Y�nergesi / �rnek Sorular" OnClick="lnkTestGeneral2_Click"></asp:LinkButton>
                        </li>
                    </ul>
                    <div class="brclear">
                    </div>
                    <p>
                        &nbsp;</p>
                    <table class="GenericTable">
                        <tr>
                            <td>
                                <h3>
                                    <strong>P�KMAT nedir?</strong></h3>
                                <p>
P�KMAT ki�ilerin belirli ili�kileri kavrayabilme, analiz edebilme, ��z�mleyebilme, sonuca varabilme gibi zihinsel �zelliklerini �l�ebilmek �zere Perakende �nsan Kaynaklar� i�in �zel olarak geli�tirilmi�tir. Ve testin t�m haklar� sadece Perakende �nsan Kaynaklar��na aittir.</p>
                                <p>
                                    &nbsp;</p>
                                <p>
                                    P�KMAT�da bireylerin genel zihinsel yeteneklerini de�erlendirmeye y�nelik alt� ayr�
                                    boyut kullan�lm��t�r.</p>
                                <p>
                                    &nbsp;</p>
                                <p>
                                    Bu boyutlar�n k�sa tan�mlar� a�a��da yer almaktad�r;</p>
                                <p>
                                    &nbsp;</p>
                                <div id="p7ABW1" class="p7AB">
                                    <div class="p7ABtrig">
                                        <h4>
                                            <a href="javascript:;" id="p7ABt1_1">Say�sal D���nme Boyutu</a></h4>
                                    </div>
                                    <div id="p7ABw1_1">
                                        <div id="p7ABc1_1" class="p7ABcontent">
                                            <p>
                                                Say�sal d���nme, bireyin, say�lar� etkin bir �ekilde kullanmas� olaylar�n olu�u
                                                hakk�nda yorum ve a��l�m getirmesi, ile ilgilidir.</p>
                                            <p>
                                                Say�sal d���nme yetene�i g��l� olan ki�iler, nesneleri belli kategorilere ay�rarak,
                                                olaylar aras�nda ba��nt�lar kurarak, belli �zellikleri niceliksel olarak say�salla�t�r�rlar.
                                                Kolayca hesap yapabilirler, bir tak�m soyut ili�kileri kavrayarak bu ili�kilere
                                                kafa yorabilirler.</p>
                                            <div class="brclear">
                                            </div>
                                        </div>
                                    </div>
                                    <div class="p7ABtrig">
                                        <h4>
                                            <a href="javascript:;" id="p7ABt1_2">Kavramsal Muhakeme Boyutu</a></h4>
                                    </div>
                                    <div id="p7ABw1_2">
                                        <div id="p7ABc1_2" class="p7ABcontent">
                                            <p>
                                                Kavram bilgisini ve kavramsal aras� ili�kileri g�rebilme yetene�ini �l�meye y�neliktir.
                                            </p>
                                            <p>
                                                Kavramlar insanlar� nesneleri, olaylar� s�n�fland�rmak ya da anlamland�rmak �zere
                                                kullan�lan kategorilerdir. Kavramlar arac�l���yla d���nme etkinli�imizi artt�rabiliriz.
                                                Kavramlar sayesinde �zerinde d���nd���m�z nesneler ve olaylara ili�kin ba�lant�lar
                                                kurmam�z kolayla��r.
                                            </p>
                                            <p>
                                                Kavramsal muhakeme di�er insanlarla s�k�a ve do�rudan ileti�im kuracak, s�zl� ve
                                                yaz�l� ileti�im becerisi gerektiren pozisyonlarda �nemlidir.</p>
                                            <div class="brclear">
                                            </div>
                                        </div>
                                    </div>
                                    <div class="p7ABtrig">
                                        <h4>
                                            <a href="javascript:;" id="p7ABt1_3">Temel Dil Yetene�i Boyutu</a></h4>
                                    </div>
                                    <div id="p7ABw1_3">
                                        <div id="p7ABc1_3" class="p7ABcontent">
                                            <p>
                                                bireyin i�inde ya�ad��� dil veya dil grubuna hakimiyetini anlamaya y�neliktir.
                                            </p>
                                            <p>
                                                Ak�c� ve iyi konu�ma, belirli bir alanda bilgi sahibi olma ve bunu ifade edebilme,
                                                okudu�unu anlama, iyi bir s�zc�k da�arc���na sahip olma, y�ksek bir anlay��la okuma,
                                                h�zl� ��renme, uyan�k olma, derin d���nme ile ilgilidir.</p>
                                            <p>
                                                Temel dil yetene�i s�zl� ve yaz�l� ileti�im becerisi gerektiren pozisyonlar i�in
                                                �nemlidir.</p>
                                        </div>
                                    </div>
                                    <div class="p7ABtrig">
                                        <h4>
                                            <a href="javascript:;" id="p7ABt1_4">Analitik Muhakeme Boyutu</a></h4>
                                    </div>
                                    <div id="p7ABw1_4">
                                        <div id="p7ABc1_4" class="p7ABcontent">
                                            <p>
                                                Belirli kurallara veya �nceki ��reti/deneyimlere dayal� ili�kiler kurulmas� gereken
                                                durumlarda karar verme, do�ru ili�kiyi kurabilme yetene�ini ve �ok boyutlu d���nmeyi
                                                �l�meye y�neliktir.</p>
                                            <p>
                                                Analitik d���nme yetene�i, mant�ksal ak�l y�r�me, fikirler aras�nda ba�lant�lar
                                                kurma, bir problemin t�m y�nlerini g�rebilme, a��k fikirli olma, Analitik Muhakeme
                                                yap�lacak i�in �ok boyutlu d���nebilmeyi gerektirdi�i pozisyonlar i�in �nemlidir.</p>
                                        </div>
                                    </div>
                                    <div class="p7ABtrig">
                                        <h4>
                                            <a href="javascript:;" id="p7ABt1_5">�ekil ve Uzay Yetene�i Boyutu</a></h4>
                                    </div>
                                    <div id="p7ABw1_5">
                                        <div id="p7ABc1_5" class="p7ABcontent">
                                            <p>
                                                ki�ilerin uzaysal ve �ekilsel kavrama yetene�ini, �ekiller aras� a�� ile d�nd�rme
                                                yapabilme yetene�ini, �� boyutlu d���nebilme yetene�ini, soyut d���nebilme yetene�ini
                                                �l�meye y�neliktir.</p>
                                            <p>
                                                Bireyin �evresini objektif olarak g�zlemlemesi, alg�lamas�, de�erlendirmesi, bunlara
                                                ba�l� olarak d�� �evreden edindi�i g�rsel uzaysal bilgileri, fikirleri grafiksel
                                                olarak sergilemesi kabiliyetini i�ermektedir. Bu yetenek a��s�ndan g��l� olan insanlar
                                                varl�klar�, olaylar�, veya olgular� g�rselle�tirerek ya da resimlerle, �izgilerle
                                                ve renklerle �al��arak aktarma e�ilimindedirler.</p>
                                        </div>
                                    </div>
                                    <div class="p7ABtrig">
                                        <h4>
                                            <a href="javascript:;" id="p7ABt1_6">�li�ki Kurabilme-Dikkat Yetene�i</a></h4>
                                    </div>
                                    <div id="p7ABw1_6">
                                        <div id="p7ABc1_6" class="p7ABcontent">
                                            <p>
                                                Ki�ilerin say�sal analitik muhakemelerini, hesaplama yeteneklerini ve temel matematik
                                                becerilerini kullanarak kurallara ili�kin ��kar�mda bulunabilme yeteneklerini ve
                                                konsantre dikkatlerini �l�meye y�neliktir.</p>
                                            <p>
                                                Verilere dikkat toplayabilme, konsantre olabilme, bir olgunun i� i�leyi�ini ��zebilme,
                                                olgular� a��klayan yasalar� h�zla kavrayabilme, bu yasalar�n devaml�l���n� sa�layabilme,
                                                mant�k zinciri kurabilme, kurulu mant�k zincirini devam ettirebilme, mant�ksal bir
                                                �er�eveyi farkl� durumlara uygulayabilme ile ilgilidir.</p>
                                        </div>
                                    </div>
                                </div>
                                <p align="center">
                                    &nbsp;</p>
                                <p align="center">
                                    <asp:Image runat="server" ID="imgBtnTest" ImageUrl="~/Images/buttons/begin_test.png" />
                                </p>

                                <script type="text/javascript">
			<!--
				P7_opAB(1,1,1,0,1);
			//-->
                                </script>

                            </td>
                        </tr>
                    </table>
                    <div class="brclear">
                    </div>
                </div>
        
        </asp:Panel>
        
        <asp:Panel runat="server" ID="pnlTestGeneral2" Visible="false">
        
            <div class="BoxPadder">
                    <p>
                        &nbsp;</p>
                    <ul class="SubTab">
                        <li>
                        <asp:LinkButton runat="server" ID="lnkTestGeneral1_1" Text="A��klay�c� Bilgiler" OnClick="lnkTestGeneral1_Click"></asp:LinkButton>
                        </li>
                        <li class="selected">
                            <asp:LinkButton runat="server" ID="lnkTestGeneral2_1" Text="Test Y�nergesi / �rnek Sorular" OnClick="lnkTestGeneral2_Click"></asp:LinkButton>
                        </li>
                    </ul>
                    <div class="brclear">
                    </div>
                    <p>
                        &nbsp;</p>
                    <table class="GenericTable">
                        <tr>
                            <td>
                <h3><strong>Genel Y�nerge</strong></h3>
                <p>Bu test,  sizin say�sal ve s�zel muhakeme yeteneklerinizi �l�meye y�nelik say� dizisi,  aritmetik, kavram ve s�zc�k bilgisi, analitik muhakeme, sentez kurma ve�ekilsel ili�kilerin kavranmas�&nbsp; &nbsp; &nbsp; sorular�n� i�ermektedir.</p>
                <ul class="List">
                  <li>Testin b�t�n� 30 sorudur. Testi yan�tlaman�z i�in 25 dakikan�z bulunmaktad�r.</li><li>Verilen se�enekler aras�ndan belirledi�iniz cevab�, cevap sayfas�ndaki uygun b�l�me  i�aretlemeniz gerekmektedir.</li><li>Her  sorunun de�eri bir puand�r.</li><li>Do�ru  cevaptan emin de�ilseniz, tahminde bulunarak en olas� se�ene�i i�aretleyebilirsiniz.  Yanl�� cevaplar toplam puan�n�z� etkilemeyecektir.</li><li>Hesap  makinesi kullanmay�n�z.</li></ul>
                <p>&nbsp;</p>
                <h5>A��klamalar</h5>
                <p>&nbsp;</p>
                <div id="p7ABW1" class="p7AB">
                  <div class="p7ABtrig">
                    <h4><a href="javascript:;" id="p7ABt1_1"><strong>�li�ki Kurabilme-Dikkat Boyutu</strong></a></h4>
                  </div>
                  <div id="p7ABw1_1">
                    <div id="p7ABc1_1" class="p7ABcontent">
                      <p class="TestExampleText">Verilen say�lar belli bir  kurala g�re s�ralanm��lard�r. Bu kural� tespit ederek say� dizisindeki bir  sonraki say�n�n ne olmas� gerekti�ini bulman�z gerekmektedir.</p>
                      <p class="TestExampleQuestion"><strong>�RNEK SORU:<br />
                        </strong>A�a��daki dizide �?� i�aretli yere  se�eneklerden hangisi gelmelidir?<br />
                        39&nbsp;&nbsp;&nbsp;30&nbsp;&nbsp;&nbsp;23&nbsp;&nbsp;&nbsp;18&nbsp;&nbsp;&nbsp;15&nbsp;&nbsp;&nbsp;<strong>?</strong><br />
  <br />
  <span><strong>a. </strong>14</span>&nbsp;&nbsp;&nbsp;&nbsp;<strong>b. </strong>12&nbsp;&nbsp;&nbsp;&nbsp;<strong>c. </strong>19&nbsp;&nbsp;&nbsp;&nbsp;<strong>d. </strong>10&nbsp;&nbsp;&nbsp;&nbsp;<strong>e. </strong>8</p>
                      <div class="brclear"></div>
                    </div>
                  </div>
                  <div class="p7ABtrig">
                    <h4><a href="javascript:;" id="p7ABt1_2"><strong>Say�sal D���nme Boyutu</strong></a></h4>
                  </div>
                  <div id="p7ABw1_2">
                    <div id="p7ABc1_2" class="p7ABcontent">
                      <p class="TestExampleText">Verilen problemi ��zmek i�in bir form�l belirlemeniz veya do�rudan sonucu bulman�z gerekmektedir.</p>
                      <p class="TestExampleQuestion"><strong>�RNEK SORU:<br />
                        </strong>�� karde� olan Kemal, Kamil ve Nusret�in ya�lar�n�n toplam� 72'dir. Alt� y�l sonra bu grubun ya�lar�n�n toplam� ka� olacakt�r?<br />
                        <br />
						<strong>a. </strong>86&nbsp;&nbsp;&nbsp;&nbsp;<strong>b. </strong>78&nbsp;&nbsp;&nbsp;&nbsp;<strong>c. </strong>84&nbsp;&nbsp;&nbsp;&nbsp;<span><strong>d. </strong>90</span>&nbsp;&nbsp;&nbsp;&nbsp;<strong>e. </strong>96</p>
                      <div class="brclear"></div>
                    </div>
                  </div>
                  <div class="p7ABtrig">
                    <h4><a href="javascript:;" id="p7ABt1_3"><strong>Kavramsal Muhakeme Boyutu</strong></a></h4>
                  </div>
                  <div id="p7ABw1_3">
                    <div id="p7ABc1_3" class="p7ABcontent">
                      <p class="TestExampleText">Verilen s�zc�k �iftlerinden hangisinde her iki s�zc���n de ayn� kavram�n �rne�i oldu�unu veya ayn� genel kavram�n i�inde yer ald���n� tespit etmeniz gerekmektedir.</p>
                      <p class="TestExampleQuestion"><strong>�RNEK SORU:<br />
                        </strong>A�a��daki kavram �iftlerinden hangisi ortak bir y�nleri ile di�erlerinden farkl�la�maktad�r?<br /><br />
						<strong>a. </strong>kep�e-mutfak&nbsp;&nbsp;&nbsp;&nbsp;<strong>b. </strong>makas-terzi&nbsp;&nbsp;&nbsp;&nbsp;<strong>c. </strong>kabin-disco<br />
						<strong>d. </strong>bardak-masa&nbsp;&nbsp;&nbsp;&nbsp;<strong>e. </strong>makine-fabrika</p>
                      <div class="brclear"></div>
                    </div>
                  </div>
                  <div class="p7ABtrig">
                    <h4><a href="javascript:;" id="p7ABt1_4"><strong>Temel Dil Yetene�i</strong></a></h4>
                  </div>
                  <div id="p7ABw1_4">
                    <div id="p7ABc1_4" class="p7ABcontent">
                      <p class="TestExampleText">Verilen s�zc�klerin,  ifadelerin, ve kavramlar�n anlamlar�n�, kar��t-anlamlar�n�, benzerliklerini,  veya aralar�ndaki ili�kiyi&nbsp; tespit etmeniz gerekmektedir.</p>
                      <p class="TestExampleQuestion"><strong>�RNEK SORU:</strong><br />
                        A�a��daki c�mlelerden hangisinde bir anlat�m  bozuklu�u vard�r?<br /><br />
                        <strong>a. </strong>Her i�in bir zaman� vard�r.<br />
                        <strong>b. </strong>Sakin at�n tekmesi pek olur.<br />
                        <strong>c. </strong>Bal�klar sessizce kaderlerini kabul ediyordu.<br />
                        <strong>d. </strong>Ku�, kafeslerin i�inde en b�y���n� tercih etti.<br />
                        <span><strong>e. </strong>Sen ve arkada��n neden buraya d�nd�n.</span><br />
                      </p>
                      <div class="brclear"></div>
                    </div>
                  </div>
                  <div class="p7ABtrig">
                    <h4><a href="javascript:;" id="p7ABt1_5"><strong>Analitik Muhakeme Boyutu</strong></a></h4>
                  </div>
                  <div id="p7ABw1_5">
                    <div id="p7ABc1_5" class="p7ABcontent">
                      <p class="TestExampleText">Bir i�le ilgili bir durum anlat�lmakta ve sizden bu durumda nas�l bir karar verilmesi, sorunu ��zmek i�in hangi ek bilgilere gerek var bunlardan nas�l sonu� ��kar�laca�� hakk�nda de�erlendirmeler yapman�z istenmektedir.</p>
                      <p class="TestExampleQuestion"><strong>�RNEK SORU:<br />
                        </strong>Bir �iftlikte toplam 110 ayak, 32 kafa bulunmaktad�r. Bunlar�n at, deveku�u ve kuzulara ait oldu�u bilinmektedir. Buna g�re ortamda bulunan at, deveku�u ve kuzular�n say�s�n� g�steren se�enek a�a��dakilerden hangisi olabilir?<br /><br />
                        <strong>a. </strong>18 kuzu, 8 at, 3 deveku�u.<br />
                        <strong>b. </strong>9 kuzu, 13 at, 10 deveku�u.<br />
                        <span><strong>c. </strong>16 kuzu, 7 at, 9 deveku�u.</span><br />
                        <strong>d. </strong>10 kuzu, 9 at, 13 deveku�u.<br />
                        <strong>e. </strong>11 kuzu, 11 at, 11 deveku�u.<br />
                      </p>
                    </div>
                  </div>
                  <div class="p7ABtrig">
                    <h4><a href="javascript:;" id="p7ABt1_6"><strong>�ekil ve Uzay Yetene�i Boyutu</strong></a></h4>
                  </div>
                  <div id="p7ABw1_6">
                    <div id="p7ABc1_6" class="p7ABcontent">
                      <p class="TestExampleText">�ekiller aras�ndaki m�nasebetin kavranmas� ve bu kurulacak ili�ki dahilinde bir sonraki �ekli belirlemeniz gerekmektedir.</p>
                      <p class="TestExampleQuestion"><strong>�RNEK SORU:<br />
                        </strong>A�a��daki �ekillerden hangisi di�erlerinden farkl�d�r?<br /><br />
                        <img src="images/misc/test_example.png" />
                      </p>
                    </div>
                  </div>
                </div>
                <p>&nbsp;</p>
                <p align="center">
                    <asp:Image runat="server" ID="imgBtnTest2" ImageUrl="~/Images/buttons/begin_test.png" />                
                </p>
              <p>
                    <script type="text/javascript">
			<!--
				P7_opAB(1,1,1,0,1);
			//-->
			        </script>
                </p></td>
                        </tr>
                    </table>
                    <div class="brclear">
                    </div>
                </div>
        
        </asp:Panel>

        <asp:Panel ID="pnlTestPerfection" runat="server" Visible="false">
            <div class="BoxPadder">
                <p>
                    &nbsp;</p>
                <ul class="SubTab">
                    <li class="selected">
                        <asp:LinkButton runat="server" ID="lnkTestPerfection1_1" Text="A��klay�c� Bilgiler" OnClick="lnkTestPerfection1_1_Click1"></asp:LinkButton>
                    </li>
                    <li>
                        <asp:LinkButton runat="server" ID="lnkTestPerfection2_1" Text="Test Y�nergesi / �rnek Sorular" OnClick="lnkTestPerfection2_1_Click"></asp:LinkButton>
                    </li>
                </ul>
                <div class="brclear">
                </div>
                <p>
                    &nbsp;</p>
                <table class="GenericTable">
                    <tbody>
                        <tr>
                            <td>
                                <h3>
                                    <strong>P�K Yetkinlik Testi nedir?</strong></h3>
                                <p>
                                    P�K Yetkinlik testi personel se�iminde yetkinlik bazl� bireysel de�erlendirme yapmaya
                                    yarayan bir �l�me arac�d�r. Test Perakende �nsan Kaynaklar� i�in �zel olarak geli�tirilmi�
                                    ve kullan�m hakk� sadece Perakende �nsan Kaynaklar��na aittir.</p>
                                <p>
                                    &nbsp;</p>
                                <p>
                                    P�K yetkinlik testi 6 yetkinli�i �l�mek �zere olu�turulmu�tur.</p>
                                <p>
                                    &nbsp;</p>
                                <p>
                                    Bu yetkinliklerin k�sa tan�mlar� a�a��da yer almaktad�r;</p>
                                <p>
                                    &nbsp;</p>
                                <div class="p7AB" id="p7ABW1">
                                    <div class="p7ABtrig">
                                        <h4>
                                            <a id="p7ABt1_1" href="javascript:;">Karar verme</a></h4>
                                    </div>
                                    <div id="p7ABw1_1">
                                        <div class="p7ABcontent" id="p7ABc1_1">
                                            <p>
                                                Bir problemin, engelin veya f�rsat�n tespiti ard�ndan hareket al�r. Gelecekte yap�lacak
                                                i�leri d���nmenin yan�nda; bu i�leri �nceden d���nerek proaktif olarak faaliyet
                                                planlamay� kapsar. Al�ncak �nlemin zaman boyutu, g�ncel bir problemin tespitinden
                                                ba�layarak gelecek durumlar ve stratejik tehditler �zerine eyleme ge�meyi i�erir.</p>
                                            <div class="brclear">
                                            </div>
                                        </div>
                                    </div>
                                    <div class="p7ABtrig">
                                        <h4>
                                            <a id="p7ABt1_2" href="javascript:;">�leti�im</a></h4>
                                    </div>
                                    <div id="p7ABw1_2">
                                        <div class="p7ABcontent" id="p7ABc1_2">
                                            <p>
                                                Hem yaz�l� hem de s�zl� olarak ki�inin kendisini anla��l�r ve etkin bir �ekilde
                                                ifade etme ve kar��s�ndaki ki�inin anlatmak istedi�ini, do�ru �ekilde anlamak i�in
                                                g�sterdi�i dinleme becerisidir. Ba�kalar�n�n dile getirmedi�i veya a��k�a ifade
                                                etmedi�i duygu, d���nce ve kayg�lar�n� anlama ve duyarl� olma yetene�idir.</p>
                                            <div class="brclear">
                                            </div>
                                        </div>
                                    </div>
                                    <div class="p7ABtrig">
                                        <h4>
                                            <a id="p7ABt1_3" href="javascript:;">Liderlik</a></h4>
                                    </div>
                                    <div id="p7ABw1_3">
                                        <div class="p7ABcontent" id="p7ABc1_3">
                                            <p>
                                                Bu yetkinlik, bir ekibin veya b�l�m�n lideri olarak rol almak / yol g�stermek ve
                                                di�erlerini i�birli�i i�inde y�netme becerisidir. Ekip liderli�i genellikle organizasyonda
                                                bir pozisyon taraf�ndan �stlenildi�i gibi, �Ekip�, bir b�t�n olarak �irketi de i�erebilecek,
                                                ayn� zamanda bir liderlik rol�n� y�klenmi� bir ki�inin bulundu�u herhangi bir grup
                                                olarak da anla��lmal�d�r.</p>
                                        </div>
                                    </div>
                                    <div class="p7ABtrig">
                                        <h4>
                                            <a id="p7ABt1_4" href="javascript:;">Planlama ve organizasyon</a></h4>
                                    </div>
                                    <div id="p7ABw1_4">
                                        <div class="p7ABcontent" id="p7ABc1_4">
                                            <p>
                                                Bireyin i� yap�� s�ras�nda d�zenli ve organize bi�imde hareket edip etmedi�i, d�zenleme,
                                                plan yapma ve bu plan� uygulama becerisi ile ilgilidir.</p>
                                        </div>
                                    </div>
                                    <div class="p7ABtrig">
                                        <h4>
                                            <a id="p7ABt1_5" href="javascript:;">Problem ��zme</a></h4>
                                    </div>
                                    <div id="p7ABw1_5">
                                        <div class="p7ABcontent" id="p7ABc1_5">
                                            <p>
                                                Bu yetkinlik, bir sorunu kendi i�inde par�alara ay�rarak veya ad�m ad�m mant�ksal
                                                bir s�ra takip ederek anlama ve ��zme becerisidir. Planlar�n/projelerin geli�tirilmesinde
                                                ve �nceliklerin mant�kl�/anlaml� bir �er�eveye oturtulmas�nda kullan�l�r. �ncelikleri
                                                belirleme, ge�mi� ili�kilerin incelenerek, sebep-sonu� ili�kilerinin veya etki-sonu�
                                                ili�kilerinin belirlenmesini i�erir.</p>
                                        </div>
                                    </div>
                                    <div class="p7ABtrig">
                                        <h4>
                                            <a id="p7ABt1_6" href="javascript:;">Ekip �al��mas�</a></h4>
                                    </div>
                                    <div id="p7ABw1_6">
                                        <div class="p7ABcontent" id="p7ABc1_6">
                                            <p>
                                                Bu yetkinlik, ayr� veya rekabet halinde �al��man�n aksine, birlikte ve i�birli�i
                                                i�inde �al��ma arzusudur. Ekip �al��mas�, �o�u kez bir grup veya ekip olarak astlar�na
                                                do�ru g�sterildi�i gibi, ayn� seviyedeki i� arkada�lar� veya �stlerle olu�turulmu�
                                                bir ekipte �al���l�rken de g�sterilmelidir.</p>
                                        </div>
                                    </div>
                                    <div class="p7ABtrig">
                                        <h4>
                                            <a id="p7ABt1_7" href="javascript:;">�kna ve M�zakere</a></h4>
                                    </div>
                                    <div id="p7ABw1_7">
                                        <div class="p7ABcontent" id="p7ABc1_7">
                                            <p>
                                                Bireylerin i� ve �zel ya�ant�lar� i�erisinde ba�kalar� ile kar��l�kl� g�r��erek
                                                ��zmek durumunda olduklar� anla�mazl�klar�n yap�c� ve etkin bir �ekilde ��z�p ��zemeyece�i
                                                ve bu s�re�te olumlu ili�kiyi g��lendirerek sonuca ba�lanmas�nda ne derece aktif
                                                rol oynayaca�� ile ilgilidir.</p>
                                        </div>
                                    </div>
                                    <div class="p7ABtrig">
                                        <h4>
                                            <a id="p7ABt1_8" href="javascript:;">Sorumluluk</a></h4>
                                    </div>
                                    <div id="p7ABw1_8">
                                        <div class="p7ABcontent" id="p7ABc1_8">
                                            <p>
                                                Bireyin �zerine y�kleri ve/veya i�leri ne derece ciddiye ald���; istenen standartlar�
                                                sa�lamaya ne derece azimli oldu�uyla ilgilidir. Kendi ilgi alan�na giren konularda
                                                pozisyon almas� ve bunun gereklerini yerine getirmesiyle ilgidir.</p>
                                        </div>
                                    </div>
                                    <div class="p7ABtrig">
                                        <h4>
                                            <a id="p7ABt1_9" href="javascript:;">M��teri odakl�l�k</a></h4>
                                    </div>
                                    <div id="p7ABw1_9">
                                        <div class="p7ABcontent" id="p7ABc1_9">
                                            <p>
                                                M��terilerinin ihtiya�lar�n� kar��layabilmek i�in, i�tenlikle yard�mc� olma ve hizmet
                                                verme iste�idir. Ki�inin t�m �abas�, m��terinin ihtiya�lar�n� tan�mlamaya, kar��lamaya
                                                ve hi�bir ayr�mda bulunmadan en iyi seviyede hizmet vermeye odakl�d�r.
                                            </p>
                                        </div>
                                    </div>
                                </div>
                                <p align="center">
                                    &nbsp;</p>
                                <p align="center">
                                    <asp:Image runat="server" ID="imgBtnTestPerfection" ImageUrl="~/Images/buttons/begin_test.png" />
                                </P>

                                <script type="text/javascript">
		                         P7_opAB(1,1,1,0,1);
		                        </script>

                            </td>
                        </tr>
                    </tbody>
                </table>
                <div class="brclear">
                </div>
            </div>      
        </asp:Panel>
        
        <asp:Panel runat="server" ID="pnlTestPerfection2" Visible="false">
            <div class="BoxPadder">
                <p>
                    &nbsp;</p>
                <ul class="SubTab">
                    <li>
                        <asp:LinkButton runat="server" ID="lnkTestPerfection1_2" Text="A��klay�c� Bilgiler" OnClick="lnkTestPerfection1_2_Click1"></asp:LinkButton>
                    </li>
                    <li class="selected">
                        <asp:LinkButton runat="server" ID="lnkTestPerfection2_2" Text="Test Y�nergesi / �rnek Sorular" OnClick="lnkTestPerfection2_2_Click2"></asp:LinkButton>
                    </li>
                </ul>
                <div class="brclear">
                </div>
                <p>
                    &nbsp;</p>
<TABLE class=GenericTable>
  <TBODY>
  <TR>
    <TD>
      <H3><STRONG>Genel Y�nerge</STRONG></H3>
      <P>P�K yetkinlik testinde 6 grup bulunmaktad�r. Her grupta 6 ifade test 
      toplam�nda ise 36 ifade yer almaktad�r.</P>
      <P>Test s�reli de�ildir.</P>
      <P>L�tfen a�a��daki gruplardaki t�m ifadeleri dikkatlice okuyunuz. Bu 6 
      ifadeyi sizi ne �l��de tan�mlad�klar�na g�re 6 ve 1 puan aras�nda 
      de�erlendiriniz. Her ifade grubunda sizin davran�� bi�imini en iyi 
      yans�tt���n� d���nd���n�ze 6 puan, en az yans�tt���n� d���nd���n�ze 1 puan 
      veriniz. Geriye kalan puanlar� (2, 3, 4, 5 ) sizin davran��lar�n�z� 
      yans�tma durumunuza g�re her ifadeye da��t�n�z. Her bir puan� sadece bir 
      kez kullan�n�z.</P>
      <P>&nbsp;</P>
      <H5>�rnek ifade grubu:</H5>
      <P>&nbsp;</P>
      <P>A�a��da �rnek bir ki�i taraf�ndan doldurulmu� bir tablo 
      bulunmaktad�r.</P>
      <P>&nbsp;</P>
      <TABLE class=dataGrid width="100%">
        <TBODY>
        <TR>
          <TH><STRONG>�fade</STRONG></TH>
          <TH align=middle><STRONG>Puan</STRONG></TH></TR>
        <TR>
          <TD>Hi� kimse taraf�ndan tecr�be edilmemi� deneyimleri ya�amaktan 
            ka��nmam.</TD>
          <TD align=middle><STRONG>2</STRONG></TD></TR>
        <TR>
          <TD>Kendime yat�r�m yapmak i�in �zel bir �aba harcar�m.</TD>
          <TD align=middle><STRONG>5</STRONG></TD></TR>
        <TR>
          <TD>�evremde ��renilecek yeni �eyler olmas� beni heyecanl� ve canl� 
            tutar.</TD>
          <TD align=middle><STRONG>1</STRONG></TD></TR>
        <TR>
          <TD>Her zaman en az iki alternatif cevap haz�rlar�m.</TD>
          <TD align=middle><STRONG>3</STRONG></TD></TR>
        <TR>
          <TD>Bir konuda sadece olgu hakk�nda bilgi edinmek bana yetmez, 
            mutlaka sebep-sonu� ili�kisini de ��renmek isterim.</TD>
          <TD align=middle><STRONG>6</STRONG></TD></TR>
        <TR>
          <TD>Yeni �eyler ��renmek hayat tarz�md�r.</TD>
          <TD align=middle><STRONG>4</STRONG></TD></TR></TBODY></TABLE>
      <P>Yukar�daki �rne�i dolduran ki�i "Bir konuda sadece olgu hakk�nda bilgi 
      edinmek bana yetmez, mutlaka sebep-sonu� ili�kisini de ��renmek isterim." 
      ifadesini kendi davran�� bi�imini en iyi yans�tan ifade olarak g�rm��t�r. 
      Dolay�s�yla bu ifadeye 6 puan vermi�tir. Bu ifadeden sonra ki�inin 
      kendisine en yak�n buldu�u ifade "Kendime yat�r�m yapmak i�in �zel bir 
      �aba harcar�m." �fadesi olmu�tur. Bu ifadeye de 5 puan vermi�tir. 
      Kendisine en uzak buldu�u ifade olan "�evremde ��renilecek yeni �eyler 
      olmas� beni heyecanl� ve canl� tutar." maddesine 1 puan vermi�tir. 
      Sonras�ndaki kendisine en uzak buldu�u ifade olan "Hi� kimse taraf�ndan 
      tecr�be edilmemi� deneyimleri ya�amaktan ka��nmam." maddesine 2 puan 
      vermi�tir. Geriye kalan ifadelerin her birisine, 6 ve 1 puan aras�ndaki 
      t�m puanlar da��t�lm��t�r.</P>
      <P>&nbsp;</P>
      <P>&nbsp;</P>
      <P align=center>
        <asp:Image runat="server" ID="imgBtnTestPerfection2" ImageUrl="~/Images/buttons/begin_test.png" />
      </P>
      </TD></TR></TBODY></TABLE>
      
                <div class="brclear">
                </div>
            </div>
        </asp:Panel> 

    </div>
  <div class="BoxContentBottom"></div>
  <!-- finish roundcornered box -->
  <p>&nbsp;</p>
</div>


 