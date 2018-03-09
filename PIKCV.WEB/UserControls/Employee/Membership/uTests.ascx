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
                    <p>Sayýn <strong><asp:Literal runat="server" ID="ltlFullName"></asp:Literal>,</strong><br />
                    Sitemizde ilanlara baþvurabilmeniz ve veritabaný aramalarýnda yer alabilmeniz için bu bölümde yer alan  testleri almanýz gerekmektedir. 
                    Test sonuçlarýnýz iþe alým kriterleri arasýnda deðerlendirilecek ve þirketler tarafýndan görüntülenecektir.
                    </p>
                </div>
                <p>&nbsp;</p>
                <h3>Sizin için hazýrladýðýmýz testler: </h3>
                <p>&nbsp;</p>
                <div id="p7ABW1" class="p7AB">
                  <div id="pnlMatLink" runat="server" class="p7ABtrig">
                    <h4>
                        <asp:LinkButton runat="server" ID="lbTestGeneral" Text="Genel Yetenek Testi  (PÝKMAT)" OnClick="lbTestGeneral_Click"></asp:LinkButton>
                    <%--<a href="2_2_4_2_testler.htm" id="p7ABt1_1">Genel Yetenek Testi  (PÝKMAT)</a>--%>
                    
                    </h4>
                  </div>
                  
                  <div id="pnlPerfectionLink" runat="server" class="p7ABtrig">
                    <h4>
                    <asp:LinkButton runat="server" ID="lbTestPerfection" Text="Yetkinlik Testi (PÝKYET?)" OnClick="lbTestPerfection_Click"></asp:LinkButton>
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
                            <asp:LinkButton runat="server" ID="lnkTestGeneral1" Text="Açýklayýcý Bilgiler" OnClick="lnkTestGeneral1_Click"></asp:LinkButton>
                        </li>
                        <li>
                            <asp:LinkButton runat="server" ID="lnkTestGeneral2" Text="Test Yönergesi / Örnek Sorular" OnClick="lnkTestGeneral2_Click"></asp:LinkButton>
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
                                    <strong>PÝKMAT nedir?</strong></h3>
                                <p>
PÝKMAT kiþilerin belirli iliþkileri kavrayabilme, analiz edebilme, çözümleyebilme, sonuca varabilme gibi zihinsel özelliklerini ölçebilmek üzere Perakende Ýnsan Kaynaklarý için özel olarak geliþtirilmiþtir. Ve testin tüm haklarý sadece Perakende Ýnsan Kaynaklarý’na aittir.</p>
                                <p>
                                    &nbsp;</p>
                                <p>
                                    PÝKMAT’da bireylerin genel zihinsel yeteneklerini deðerlendirmeye yönelik altý ayrý
                                    boyut kullanýlmýþtýr.</p>
                                <p>
                                    &nbsp;</p>
                                <p>
                                    Bu boyutlarýn kýsa tanýmlarý aþaðýda yer almaktadýr;</p>
                                <p>
                                    &nbsp;</p>
                                <div id="p7ABW1" class="p7AB">
                                    <div class="p7ABtrig">
                                        <h4>
                                            <a href="javascript:;" id="p7ABt1_1">Sayýsal Düþünme Boyutu</a></h4>
                                    </div>
                                    <div id="p7ABw1_1">
                                        <div id="p7ABc1_1" class="p7ABcontent">
                                            <p>
                                                Sayýsal düþünme, bireyin, sayýlarý etkin bir þekilde kullanmasý olaylarýn oluþu
                                                hakkýnda yorum ve açýlým getirmesi, ile ilgilidir.</p>
                                            <p>
                                                Sayýsal düþünme yeteneði güçlü olan kiþiler, nesneleri belli kategorilere ayýrarak,
                                                olaylar arasýnda baðýntýlar kurarak, belli özellikleri niceliksel olarak sayýsallaþtýrýrlar.
                                                Kolayca hesap yapabilirler, bir takým soyut iliþkileri kavrayarak bu iliþkilere
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
                                                Kavram bilgisini ve kavramsal arasý iliþkileri görebilme yeteneðini ölçmeye yöneliktir.
                                            </p>
                                            <p>
                                                Kavramlar insanlarý nesneleri, olaylarý sýnýflandýrmak ya da anlamlandýrmak üzere
                                                kullanýlan kategorilerdir. Kavramlar aracýlýðýyla düþünme etkinliðimizi arttýrabiliriz.
                                                Kavramlar sayesinde üzerinde düþündüðümüz nesneler ve olaylara iliþkin baðlantýlar
                                                kurmamýz kolaylaþýr.
                                            </p>
                                            <p>
                                                Kavramsal muhakeme diðer insanlarla sýkça ve doðrudan iletiþim kuracak, sözlü ve
                                                yazýlý iletiþim becerisi gerektiren pozisyonlarda önemlidir.</p>
                                            <div class="brclear">
                                            </div>
                                        </div>
                                    </div>
                                    <div class="p7ABtrig">
                                        <h4>
                                            <a href="javascript:;" id="p7ABt1_3">Temel Dil Yeteneði Boyutu</a></h4>
                                    </div>
                                    <div id="p7ABw1_3">
                                        <div id="p7ABc1_3" class="p7ABcontent">
                                            <p>
                                                bireyin içinde yaþadýðý dil veya dil grubuna hakimiyetini anlamaya yöneliktir.
                                            </p>
                                            <p>
                                                Akýcý ve iyi konuþma, belirli bir alanda bilgi sahibi olma ve bunu ifade edebilme,
                                                okuduðunu anlama, iyi bir sözcük daðarcýðýna sahip olma, yüksek bir anlayýþla okuma,
                                                hýzlý öðrenme, uyanýk olma, derin düþünme ile ilgilidir.</p>
                                            <p>
                                                Temel dil yeteneði sözlü ve yazýlý iletiþim becerisi gerektiren pozisyonlar için
                                                önemlidir.</p>
                                        </div>
                                    </div>
                                    <div class="p7ABtrig">
                                        <h4>
                                            <a href="javascript:;" id="p7ABt1_4">Analitik Muhakeme Boyutu</a></h4>
                                    </div>
                                    <div id="p7ABw1_4">
                                        <div id="p7ABc1_4" class="p7ABcontent">
                                            <p>
                                                Belirli kurallara veya önceki öðreti/deneyimlere dayalý iliþkiler kurulmasý gereken
                                                durumlarda karar verme, doðru iliþkiyi kurabilme yeteneðini ve çok boyutlu düþünmeyi
                                                ölçmeye yöneliktir.</p>
                                            <p>
                                                Analitik düþünme yeteneði, mantýksal akýl yürüme, fikirler arasýnda baðlantýlar
                                                kurma, bir problemin tüm yönlerini görebilme, açýk fikirli olma, Analitik Muhakeme
                                                yapýlacak iþin çok boyutlu düþünebilmeyi gerektirdiði pozisyonlar için önemlidir.</p>
                                        </div>
                                    </div>
                                    <div class="p7ABtrig">
                                        <h4>
                                            <a href="javascript:;" id="p7ABt1_5">Þekil ve Uzay Yeteneði Boyutu</a></h4>
                                    </div>
                                    <div id="p7ABw1_5">
                                        <div id="p7ABc1_5" class="p7ABcontent">
                                            <p>
                                                kiþilerin uzaysal ve þekilsel kavrama yeteneðini, þekiller arasý açý ile döndürme
                                                yapabilme yeteneðini, üç boyutlu düþünebilme yeteneðini, soyut düþünebilme yeteneðini
                                                ölçmeye yöneliktir.</p>
                                            <p>
                                                Bireyin çevresini objektif olarak gözlemlemesi, algýlamasý, deðerlendirmesi, bunlara
                                                baðlý olarak dýþ çevreden edindiði görsel uzaysal bilgileri, fikirleri grafiksel
                                                olarak sergilemesi kabiliyetini içermektedir. Bu yetenek açýsýndan güçlü olan insanlar
                                                varlýklarý, olaylarý, veya olgularý görselleþtirerek ya da resimlerle, çizgilerle
                                                ve renklerle çalýþarak aktarma eðilimindedirler.</p>
                                        </div>
                                    </div>
                                    <div class="p7ABtrig">
                                        <h4>
                                            <a href="javascript:;" id="p7ABt1_6">Ýliþki Kurabilme-Dikkat Yeteneði</a></h4>
                                    </div>
                                    <div id="p7ABw1_6">
                                        <div id="p7ABc1_6" class="p7ABcontent">
                                            <p>
                                                Kiþilerin sayýsal analitik muhakemelerini, hesaplama yeteneklerini ve temel matematik
                                                becerilerini kullanarak kurallara iliþkin çýkarýmda bulunabilme yeteneklerini ve
                                                konsantre dikkatlerini ölçmeye yöneliktir.</p>
                                            <p>
                                                Verilere dikkat toplayabilme, konsantre olabilme, bir olgunun iç iþleyiþini çözebilme,
                                                olgularý açýklayan yasalarý hýzla kavrayabilme, bu yasalarýn devamlýlýðýný saðlayabilme,
                                                mantýk zinciri kurabilme, kurulu mantýk zincirini devam ettirebilme, mantýksal bir
                                                çerçeveyi farklý durumlara uygulayabilme ile ilgilidir.</p>
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
                        <asp:LinkButton runat="server" ID="lnkTestGeneral1_1" Text="Açýklayýcý Bilgiler" OnClick="lnkTestGeneral1_Click"></asp:LinkButton>
                        </li>
                        <li class="selected">
                            <asp:LinkButton runat="server" ID="lnkTestGeneral2_1" Text="Test Yönergesi / Örnek Sorular" OnClick="lnkTestGeneral2_Click"></asp:LinkButton>
                        </li>
                    </ul>
                    <div class="brclear">
                    </div>
                    <p>
                        &nbsp;</p>
                    <table class="GenericTable">
                        <tr>
                            <td>
                <h3><strong>Genel Yönerge</strong></h3>
                <p>Bu test,  sizin sayýsal ve sözel muhakeme yeteneklerinizi ölçmeye yönelik sayý dizisi,  aritmetik, kavram ve sözcük bilgisi, analitik muhakeme, sentez kurma veþekilsel iliþkilerin kavranmasý&nbsp; &nbsp; &nbsp; sorularýný içermektedir.</p>
                <ul class="List">
                  <li>Testin bütünü 30 sorudur. Testi yanýtlamanýz için 25 dakikanýz bulunmaktadýr.</li><li>Verilen seçenekler arasýndan belirlediðiniz cevabý, cevap sayfasýndaki uygun bölüme  iþaretlemeniz gerekmektedir.</li><li>Her  sorunun deðeri bir puandýr.</li><li>Doðru  cevaptan emin deðilseniz, tahminde bulunarak en olasý seçeneði iþaretleyebilirsiniz.  Yanlýþ cevaplar toplam puanýnýzý etkilemeyecektir.</li><li>Hesap  makinesi kullanmayýnýz.</li></ul>
                <p>&nbsp;</p>
                <h5>Açýklamalar</h5>
                <p>&nbsp;</p>
                <div id="p7ABW1" class="p7AB">
                  <div class="p7ABtrig">
                    <h4><a href="javascript:;" id="p7ABt1_1"><strong>Ýliþki Kurabilme-Dikkat Boyutu</strong></a></h4>
                  </div>
                  <div id="p7ABw1_1">
                    <div id="p7ABc1_1" class="p7ABcontent">
                      <p class="TestExampleText">Verilen sayýlar belli bir  kurala göre sýralanmýþlardýr. Bu kuralý tespit ederek sayý dizisindeki bir  sonraki sayýnýn ne olmasý gerektiðini bulmanýz gerekmektedir.</p>
                      <p class="TestExampleQuestion"><strong>ÖRNEK SORU:<br />
                        </strong>Aþaðýdaki dizide “?” iþaretli yere  seçeneklerden hangisi gelmelidir?<br />
                        39&nbsp;&nbsp;&nbsp;30&nbsp;&nbsp;&nbsp;23&nbsp;&nbsp;&nbsp;18&nbsp;&nbsp;&nbsp;15&nbsp;&nbsp;&nbsp;<strong>?</strong><br />
  <br />
  <span><strong>a. </strong>14</span>&nbsp;&nbsp;&nbsp;&nbsp;<strong>b. </strong>12&nbsp;&nbsp;&nbsp;&nbsp;<strong>c. </strong>19&nbsp;&nbsp;&nbsp;&nbsp;<strong>d. </strong>10&nbsp;&nbsp;&nbsp;&nbsp;<strong>e. </strong>8</p>
                      <div class="brclear"></div>
                    </div>
                  </div>
                  <div class="p7ABtrig">
                    <h4><a href="javascript:;" id="p7ABt1_2"><strong>Sayýsal Düþünme Boyutu</strong></a></h4>
                  </div>
                  <div id="p7ABw1_2">
                    <div id="p7ABc1_2" class="p7ABcontent">
                      <p class="TestExampleText">Verilen problemi çözmek için bir formül belirlemeniz veya doðrudan sonucu bulmanýz gerekmektedir.</p>
                      <p class="TestExampleQuestion"><strong>ÖRNEK SORU:<br />
                        </strong>Üç kardeþ olan Kemal, Kamil ve Nusret’in yaþlarýnýn toplamý 72'dir. Altý yýl sonra bu grubun yaþlarýnýn toplamý kaç olacaktýr?<br />
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
                      <p class="TestExampleText">Verilen sözcük çiftlerinden hangisinde her iki sözcüðün de ayný kavramýn örneði olduðunu veya ayný genel kavramýn içinde yer aldýðýný tespit etmeniz gerekmektedir.</p>
                      <p class="TestExampleQuestion"><strong>ÖRNEK SORU:<br />
                        </strong>Aþaðýdaki kavram çiftlerinden hangisi ortak bir yönleri ile diðerlerinden farklýlaþmaktadýr?<br /><br />
						<strong>a. </strong>kepçe-mutfak&nbsp;&nbsp;&nbsp;&nbsp;<strong>b. </strong>makas-terzi&nbsp;&nbsp;&nbsp;&nbsp;<strong>c. </strong>kabin-disco<br />
						<strong>d. </strong>bardak-masa&nbsp;&nbsp;&nbsp;&nbsp;<strong>e. </strong>makine-fabrika</p>
                      <div class="brclear"></div>
                    </div>
                  </div>
                  <div class="p7ABtrig">
                    <h4><a href="javascript:;" id="p7ABt1_4"><strong>Temel Dil Yeteneði</strong></a></h4>
                  </div>
                  <div id="p7ABw1_4">
                    <div id="p7ABc1_4" class="p7ABcontent">
                      <p class="TestExampleText">Verilen sözcüklerin,  ifadelerin, ve kavramlarýn anlamlarýný, karþýt-anlamlarýný, benzerliklerini,  veya aralarýndaki iliþkiyi&nbsp; tespit etmeniz gerekmektedir.</p>
                      <p class="TestExampleQuestion"><strong>ÖRNEK SORU:</strong><br />
                        Aþaðýdaki cümlelerden hangisinde bir anlatým  bozukluðu vardýr?<br /><br />
                        <strong>a. </strong>Her iþin bir zamaný vardýr.<br />
                        <strong>b. </strong>Sakin atýn tekmesi pek olur.<br />
                        <strong>c. </strong>Balýklar sessizce kaderlerini kabul ediyordu.<br />
                        <strong>d. </strong>Kuþ, kafeslerin içinde en büyüðünü tercih etti.<br />
                        <span><strong>e. </strong>Sen ve arkadaþýn neden buraya döndün.</span><br />
                      </p>
                      <div class="brclear"></div>
                    </div>
                  </div>
                  <div class="p7ABtrig">
                    <h4><a href="javascript:;" id="p7ABt1_5"><strong>Analitik Muhakeme Boyutu</strong></a></h4>
                  </div>
                  <div id="p7ABw1_5">
                    <div id="p7ABc1_5" class="p7ABcontent">
                      <p class="TestExampleText">Bir iþle ilgili bir durum anlatýlmakta ve sizden bu durumda nasýl bir karar verilmesi, sorunu çözmek için hangi ek bilgilere gerek var bunlardan nasýl sonuç çýkarýlacaðý hakkýnda deðerlendirmeler yapmanýz istenmektedir.</p>
                      <p class="TestExampleQuestion"><strong>ÖRNEK SORU:<br />
                        </strong>Bir çiftlikte toplam 110 ayak, 32 kafa bulunmaktadýr. Bunlarýn at, devekuþu ve kuzulara ait olduðu bilinmektedir. Buna göre ortamda bulunan at, devekuþu ve kuzularýn sayýsýný gösteren seçenek aþaðýdakilerden hangisi olabilir?<br /><br />
                        <strong>a. </strong>18 kuzu, 8 at, 3 devekuþu.<br />
                        <strong>b. </strong>9 kuzu, 13 at, 10 devekuþu.<br />
                        <span><strong>c. </strong>16 kuzu, 7 at, 9 devekuþu.</span><br />
                        <strong>d. </strong>10 kuzu, 9 at, 13 devekuþu.<br />
                        <strong>e. </strong>11 kuzu, 11 at, 11 devekuþu.<br />
                      </p>
                    </div>
                  </div>
                  <div class="p7ABtrig">
                    <h4><a href="javascript:;" id="p7ABt1_6"><strong>Þekil ve Uzay Yeteneði Boyutu</strong></a></h4>
                  </div>
                  <div id="p7ABw1_6">
                    <div id="p7ABc1_6" class="p7ABcontent">
                      <p class="TestExampleText">Þekiller arasýndaki münasebetin kavranmasý ve bu kurulacak iliþki dahilinde bir sonraki þekli belirlemeniz gerekmektedir.</p>
                      <p class="TestExampleQuestion"><strong>ÖRNEK SORU:<br />
                        </strong>Aþaðýdaki þekillerden hangisi diðerlerinden farklýdýr?<br /><br />
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
                        <asp:LinkButton runat="server" ID="lnkTestPerfection1_1" Text="Açýklayýcý Bilgiler" OnClick="lnkTestPerfection1_1_Click1"></asp:LinkButton>
                    </li>
                    <li>
                        <asp:LinkButton runat="server" ID="lnkTestPerfection2_1" Text="Test Yönergesi / Örnek Sorular" OnClick="lnkTestPerfection2_1_Click"></asp:LinkButton>
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
                                    <strong>PÝK Yetkinlik Testi nedir?</strong></h3>
                                <p>
                                    PÝK Yetkinlik testi personel seçiminde yetkinlik bazlý bireysel deðerlendirme yapmaya
                                    yarayan bir ölçme aracýdýr. Test Perakende Ýnsan Kaynaklarý için özel olarak geliþtirilmiþ
                                    ve kullaným hakký sadece Perakende Ýnsan Kaynaklarý’na aittir.</p>
                                <p>
                                    &nbsp;</p>
                                <p>
                                    PÝK yetkinlik testi 6 yetkinliði ölçmek üzere oluþturulmuþtur.</p>
                                <p>
                                    &nbsp;</p>
                                <p>
                                    Bu yetkinliklerin kýsa tanýmlarý aþaðýda yer almaktadýr;</p>
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
                                                Bir problemin, engelin veya fýrsatýn tespiti ardýndan hareket alýr. Gelecekte yapýlacak
                                                iþleri düþünmenin yanýnda; bu iþleri önceden düþünerek proaktif olarak faaliyet
                                                planlamayý kapsar. Alýncak önlemin zaman boyutu, güncel bir problemin tespitinden
                                                baþlayarak gelecek durumlar ve stratejik tehditler üzerine eyleme geçmeyi içerir.</p>
                                            <div class="brclear">
                                            </div>
                                        </div>
                                    </div>
                                    <div class="p7ABtrig">
                                        <h4>
                                            <a id="p7ABt1_2" href="javascript:;">Ýletiþim</a></h4>
                                    </div>
                                    <div id="p7ABw1_2">
                                        <div class="p7ABcontent" id="p7ABc1_2">
                                            <p>
                                                Hem yazýlý hem de sözlü olarak kiþinin kendisini anlaþýlýr ve etkin bir þekilde
                                                ifade etme ve karþýsýndaki kiþinin anlatmak istediðini, doðru þekilde anlamak için
                                                gösterdiði dinleme becerisidir. Baþkalarýnýn dile getirmediði veya açýkça ifade
                                                etmediði duygu, düþünce ve kaygýlarýný anlama ve duyarlý olma yeteneðidir.</p>
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
                                                Bu yetkinlik, bir ekibin veya bölümün lideri olarak rol almak / yol göstermek ve
                                                diðerlerini iþbirliði içinde yönetme becerisidir. Ekip liderliði genellikle organizasyonda
                                                bir pozisyon tarafýndan üstlenildiði gibi, “Ekip”, bir bütün olarak þirketi de içerebilecek,
                                                ayný zamanda bir liderlik rolünü yüklenmiþ bir kiþinin bulunduðu herhangi bir grup
                                                olarak da anlaþýlmalýdýr.</p>
                                        </div>
                                    </div>
                                    <div class="p7ABtrig">
                                        <h4>
                                            <a id="p7ABt1_4" href="javascript:;">Planlama ve organizasyon</a></h4>
                                    </div>
                                    <div id="p7ABw1_4">
                                        <div class="p7ABcontent" id="p7ABc1_4">
                                            <p>
                                                Bireyin iþ yapýþ sýrasýnda düzenli ve organize biçimde hareket edip etmediði, düzenleme,
                                                plan yapma ve bu planý uygulama becerisi ile ilgilidir.</p>
                                        </div>
                                    </div>
                                    <div class="p7ABtrig">
                                        <h4>
                                            <a id="p7ABt1_5" href="javascript:;">Problem Çözme</a></h4>
                                    </div>
                                    <div id="p7ABw1_5">
                                        <div class="p7ABcontent" id="p7ABc1_5">
                                            <p>
                                                Bu yetkinlik, bir sorunu kendi içinde parçalara ayýrarak veya adým adým mantýksal
                                                bir sýra takip ederek anlama ve çözme becerisidir. Planlarýn/projelerin geliþtirilmesinde
                                                ve önceliklerin mantýklý/anlamlý bir çerçeveye oturtulmasýnda kullanýlýr. Öncelikleri
                                                belirleme, geçmiþ iliþkilerin incelenerek, sebep-sonuç iliþkilerinin veya etki-sonuç
                                                iliþkilerinin belirlenmesini içerir.</p>
                                        </div>
                                    </div>
                                    <div class="p7ABtrig">
                                        <h4>
                                            <a id="p7ABt1_6" href="javascript:;">Ekip çalýþmasý</a></h4>
                                    </div>
                                    <div id="p7ABw1_6">
                                        <div class="p7ABcontent" id="p7ABc1_6">
                                            <p>
                                                Bu yetkinlik, ayrý veya rekabet halinde çalýþmanýn aksine, birlikte ve iþbirliði
                                                içinde çalýþma arzusudur. Ekip Çalýþmasý, çoðu kez bir grup veya ekip olarak astlarýna
                                                doðru gösterildiði gibi, ayný seviyedeki iþ arkadaþlarý veya üstlerle oluþturulmuþ
                                                bir ekipte çalýþýlýrken de gösterilmelidir.</p>
                                        </div>
                                    </div>
                                    <div class="p7ABtrig">
                                        <h4>
                                            <a id="p7ABt1_7" href="javascript:;">Ýkna ve Müzakere</a></h4>
                                    </div>
                                    <div id="p7ABw1_7">
                                        <div class="p7ABcontent" id="p7ABc1_7">
                                            <p>
                                                Bireylerin iþ ve özel yaþantýlarý içerisinde baþkalarý ile karþýlýklý görüþerek
                                                çözmek durumunda olduklarý anlaþmazlýklarýn yapýcý ve etkin bir þekilde çözüp çözemeyeceði
                                                ve bu süreçte olumlu iliþkiyi güçlendirerek sonuca baðlanmasýnda ne derece aktif
                                                rol oynayacaðý ile ilgilidir.</p>
                                        </div>
                                    </div>
                                    <div class="p7ABtrig">
                                        <h4>
                                            <a id="p7ABt1_8" href="javascript:;">Sorumluluk</a></h4>
                                    </div>
                                    <div id="p7ABw1_8">
                                        <div class="p7ABcontent" id="p7ABc1_8">
                                            <p>
                                                Bireyin üzerine yükleri ve/veya iþleri ne derece ciddiye aldýðý; istenen standartlarý
                                                saðlamaya ne derece azimli olduðuyla ilgilidir. Kendi ilgi alanýna giren konularda
                                                pozisyon almasý ve bunun gereklerini yerine getirmesiyle ilgidir.</p>
                                        </div>
                                    </div>
                                    <div class="p7ABtrig">
                                        <h4>
                                            <a id="p7ABt1_9" href="javascript:;">Müþteri odaklýlýk</a></h4>
                                    </div>
                                    <div id="p7ABw1_9">
                                        <div class="p7ABcontent" id="p7ABc1_9">
                                            <p>
                                                Müþterilerinin ihtiyaçlarýný karþýlayabilmek için, içtenlikle yardýmcý olma ve hizmet
                                                verme isteðidir. Kiþinin tüm çabasý, müþterinin ihtiyaçlarýný tanýmlamaya, karþýlamaya
                                                ve hiçbir ayrýmda bulunmadan en iyi seviyede hizmet vermeye odaklýdýr.
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
                        <asp:LinkButton runat="server" ID="lnkTestPerfection1_2" Text="Açýklayýcý Bilgiler" OnClick="lnkTestPerfection1_2_Click1"></asp:LinkButton>
                    </li>
                    <li class="selected">
                        <asp:LinkButton runat="server" ID="lnkTestPerfection2_2" Text="Test Yönergesi / Örnek Sorular" OnClick="lnkTestPerfection2_2_Click2"></asp:LinkButton>
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
      <H3><STRONG>Genel Yönerge</STRONG></H3>
      <P>PÝK yetkinlik testinde 6 grup bulunmaktadýr. Her grupta 6 ifade test 
      toplamýnda ise 36 ifade yer almaktadýr.</P>
      <P>Test süreli deðildir.</P>
      <P>Lütfen aþaðýdaki gruplardaki tüm ifadeleri dikkatlice okuyunuz. Bu 6 
      ifadeyi sizi ne ölçüde tanýmladýklarýna göre 6 ve 1 puan arasýnda 
      deðerlendiriniz. Her ifade grubunda sizin davranýþ biçimini en iyi 
      yansýttýðýný düþündüðünüze 6 puan, en az yansýttýðýný düþündüðünüze 1 puan 
      veriniz. Geriye kalan puanlarý (2, 3, 4, 5 ) sizin davranýþlarýnýzý 
      yansýtma durumunuza göre her ifadeye daðýtýnýz. Her bir puaný sadece bir 
      kez kullanýnýz.</P>
      <P>&nbsp;</P>
      <H5>Örnek ifade grubu:</H5>
      <P>&nbsp;</P>
      <P>Aþaðýda örnek bir kiþi tarafýndan doldurulmuþ bir tablo 
      bulunmaktadýr.</P>
      <P>&nbsp;</P>
      <TABLE class=dataGrid width="100%">
        <TBODY>
        <TR>
          <TH><STRONG>Ýfade</STRONG></TH>
          <TH align=middle><STRONG>Puan</STRONG></TH></TR>
        <TR>
          <TD>Hiç kimse tarafýndan tecrübe edilmemiþ deneyimleri yaþamaktan 
            kaçýnmam.</TD>
          <TD align=middle><STRONG>2</STRONG></TD></TR>
        <TR>
          <TD>Kendime yatýrým yapmak için özel bir çaba harcarým.</TD>
          <TD align=middle><STRONG>5</STRONG></TD></TR>
        <TR>
          <TD>Çevremde öðrenilecek yeni þeyler olmasý beni heyecanlý ve canlý 
            tutar.</TD>
          <TD align=middle><STRONG>1</STRONG></TD></TR>
        <TR>
          <TD>Her zaman en az iki alternatif cevap hazýrlarým.</TD>
          <TD align=middle><STRONG>3</STRONG></TD></TR>
        <TR>
          <TD>Bir konuda sadece olgu hakkýnda bilgi edinmek bana yetmez, 
            mutlaka sebep-sonuç iliþkisini de öðrenmek isterim.</TD>
          <TD align=middle><STRONG>6</STRONG></TD></TR>
        <TR>
          <TD>Yeni þeyler öðrenmek hayat tarzýmdýr.</TD>
          <TD align=middle><STRONG>4</STRONG></TD></TR></TBODY></TABLE>
      <P>Yukarýdaki örneði dolduran kiþi "Bir konuda sadece olgu hakkýnda bilgi 
      edinmek bana yetmez, mutlaka sebep-sonuç iliþkisini de öðrenmek isterim." 
      ifadesini kendi davranýþ biçimini en iyi yansýtan ifade olarak görmüþtür. 
      Dolayýsýyla bu ifadeye 6 puan vermiþtir. Bu ifadeden sonra kiþinin 
      kendisine en yakýn bulduðu ifade "Kendime yatýrým yapmak için özel bir 
      çaba harcarým." Ýfadesi olmuþtur. Bu ifadeye de 5 puan vermiþtir. 
      Kendisine en uzak bulduðu ifade olan "Çevremde öðrenilecek yeni þeyler 
      olmasý beni heyecanlý ve canlý tutar." maddesine 1 puan vermiþtir. 
      Sonrasýndaki kendisine en uzak bulduðu ifade olan "Hiç kimse tarafýndan 
      tecrübe edilmemiþ deneyimleri yaþamaktan kaçýnmam." maddesine 2 puan 
      vermiþtir. Geriye kalan ifadelerin her birisine, 6 ve 1 puan arasýndaki 
      tüm puanlar daðýtýlmýþtýr.</P>
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


 