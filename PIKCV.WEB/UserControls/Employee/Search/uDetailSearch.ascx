<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uDetailSearch.ascx.cs" Inherits="UserControls_Employee_Search_uDetailSearch" %>

<div class="contentPad">
      <div class="HeaderPR floatLeft">
        <h2 class="sIFRHeader" style="width:200px;">Detaylý Ýlan Arama</h2>
      </div>
      <div id="Tab">
        <ul>
          <li><a href="#Employee-Search-EasySearch"><span>Kolay arama</span></a></li>
          <li class="TabActive"><a href="javascript:void(0);"><span>Detaylý arama</span></a></li>
          <li><a href="#Employee-Search-Filters"><span>Arama Fitreleriniz</span></a></li>
        </ul>
      </div>
      <div class="brclear"></div>
      <!-- start roundcornered box -->
      <div class="BoxContentTop"></div>
      <div class="BoxContent">
        <div class="BoxPadder">
          <table class="FormTable">
            <tr>
              <td width="85" align="right"><p><strong>Kelime</strong></p></td>
              <td colspan="3"><input name='keyword' type='text' id='keyword' style="width:220px;" class="cssInput" /></td>
            </tr>
          </table>
		  <div class="hr"><hr /></div>
          <div class="HeaderPR floatLeft">
            <h2 class="sIFRHeader" style="width:200px;">Genel Seçim Kriterleri</h2>
          </div>
		  <div class="hr"><hr /></div>
          <table width="100%" class="FormTable">
            <tr>
              <td width="85" align="right">&nbsp;</td>
                <td colspan="3">
                    <div class="infoMsg">
                        <p>Birden fazla seçenek iþaretlemek için Ctrl tuþunu basýlý tutarak týklayýn.<br />
                        Her listeden en fazla 5 kriter seçebilirsiniz.</p>
                    </div>
                </td>
            </tr>
            <tr>
              <td align="right" valign="top"><p><strong>Sektör</strong></p></td>
              <td valign="top"><select name="select2" id="sektor" multiple="multiple" style="width:230px;" size="5" title="Ctrl tuþuna basýlý tutarak en fazla 5 seçim yapabilirsiniz">
                  <option value="2">Ambalaj ve Kaðýt</option>
                  <option value="64">Bankacýlýk / Finans</option>
                  <option value="3">Beyaz Eþya</option>
                  <option value="4">Bilgisayar / BT / Internet</option>
                  <option value="5">Cam ve Seramik</option>
                  <option value="6">Daðýtým</option>
                  <option value="7">Danýþmanlýk</option>
                  <option value="8">Dayanýklý Tüketim Mallarý</option>
                  <option value="9">Demir-Çelik</option>
                  <option value="10">Denizcilik</option>
                  <option value="11">Deri</option>
                  <option value="12">Dernek ve Vakýf</option>
                  <option value="13">Dýþ Ticaret</option>
                  <option value="14">Eðitim</option>
                  <option value="15">Eðlence</option>
                  <option value="16">Endüstri</option>
                  <option value="1">Elektrik ve Elektronik</option>
                  <option value="17">Faktoring</option>
                  <option value="18">Gayrimenkul</option>
                  <option value="19">Gýda</option>
                  <option value="20">Halkla Ýliþkiler</option>
                  <option value="21">Havacýlýk</option>
                  <option value="63">Hýzlý Tüketim Mallarý</option>
                  <option value="22">Hayvancýlýk</option>
                  <option value="23">Hizmet / Ýþletme Servisi</option>
                  <option value="24">Holding</option>
                  <option value="25">Hukuk</option>
                  <option value="26">Ýlaç</option>
                  <option value="27">Ýmalat</option>
                  <option value="28">Ýnþaat</option>
                  <option value="29">Ýthalat/Ýhracat</option>
                  <option value="30">Kamu</option>
                  <option value="31">Kimya</option>
                  <option value="32">Kozmetik</option>
                  <option value="33">Leasing</option>
                  <option value="40">Lojistik</option>
                  <option value="34">Madencilik</option>
                  <option value="35">Maðazacýlýk / Perakendecilik</option>
                  <option value="36">Mali Denetim-Vergi</option>
                  <option value="37">Mali Müþavirlik</option>
                  <option value="38">Medya</option>
                  <option value="39">Mimarlýk</option>
                  <option value="41">Otelcilik</option>
                  <option value="42">Otomotiv</option>
                  <option value="43">Petrol ve Petrol ürünleri</option>
                  <option value="44">Reklamcýlýk</option>
                  <option value="45">Restorancýlýk</option>
                  <option value="46">Saðlýk/Hastane</option>
                  <option value="47">Sanat</option>
                  <option value="48">Savunma/Güvenlik</option>
                  <option value="49">Sigortacýlýk</option>
                  <option value="50">Sosyal Servisler</option>
                  <option value="51">Tarým ve Orman Ürünleri</option>
                  <option value="52">Tekstil</option>
                  <option value="53">Telekomünikasyon ve Network</option>
                  <option value="54">Týbbi Malzeme</option>
                  <option value="55">Toptancýlýk</option>
                  <option value="56">Turizm</option>
                  <option value="57">Ulaþým</option>
                  <option value="58">Yapý Malzemeleri</option>
                  <option value="59">Yatýrým / Menkul Deðerler</option>
                  <option value="62">Yatýrým /Menkul D. /Borsacýlýk</option>
                  <option value="60">Yayýncýlýk</option>
                  <option value="61">Diðer</option>
              </select></td>
              <td align="right" valign="top"><p><strong>Pozisyon</strong></p></td>
              <td valign="top"><select name="select3" multiple="multiple" id="select" style="width:230px;" size="5" title="Ctrl tuþuna basýlý tutarak en fazla 5 seçim yapabilirsiniz">
                  <option value="2">Acente</option>
                  <option value="3">Aðýr Vasýta Þoförü</option>
                  <option value="4">Ahçý/Aþçý</option>
                  <option value="5">Akademisyen</option>
                  <option value="6">Akaryakýt Ýstasyon</option>
                  <option value="7">Aktif Pazarlama</option>
                  <option value="8">Aktif Satýþ</option>
                  <option value="9">Aktivasyon</option>
                  <option value="10">Ambar</option>
                  <option value="12">Analist</option>
                  <option value="13">Analist Programcý</option>
                  <option value="15">Analiz</option>
                  <option value="16">Animatör</option>
                  <option value="431">Anketör</option>
                  <option value="433">Antrenör</option>
                  <option value="17">Antrepo</option>
                  <option value="18">Apre</option>
                  <option value="19">Araþtýrma</option>
                  <option value="20">Araþtýrma Geliþtirme</option>
                  <option value="423">Avukat</option>
                  <option value="22">Bakým</option>
                  <option value="23">Bakým Onarým</option>
                  <option value="24">Banka</option>
                  <option value="25">Banka Ýhracat/Ýthalat</option>
                  <option value="26">Banka Kredi Pazarlama</option>
                  <option value="27">Banka Operasyon</option>
                  <option value="29">Bar</option>
                  <option value="30">Basýn</option>
                  <option value="31">Basýn ve Halkla Ýliþkiler</option>
                  <option value="32">Baský</option>
                  <option value="33">Baský Nakýþ</option>
                  <option value="34">Baþhekim</option>
                  <option value="35">Baþhemþire</option>
                  <option value="36">Bayi Kanalý</option>
                  <option value="37">Bilgi Giriþ</option>
                  <option value="39">Bilgi Ýþlem</option>
                  <option value="40">Bilgi Sistemleri</option>
                  <option value="41">Bilgi Teknolojileri</option>
                  <option value="42">Bilgisayar</option>
                  <option value="44">Bireysel Pazarlama</option>
                  <option value="45">Birim</option>
                  <option value="432">Birim/Departman</option>
                  <option value="46">Biyokimya</option>
                  <option value="47">Biyolog</option>
                  <option value="48">Biyoloji</option>
                  <option value="49">Biyomedikal</option>
                  <option value="50">Bordro</option>
                  <option value="51">Borsa</option>
                  <option value="52">Bölge</option>
                  <option value="53">Bölge Satýþ</option>
                  <option value="54">Bütçe</option>
                  <option value="55">Bütçe Raporlama</option>
                  <option value="56">Büyük Müþteriler</option>
                  <option value="57">Cad/Cam</option>
                  <option value="439">CNC</option>
                  <option value="58">Çaðrý Merkezi</option>
                  <option value="59">Çevirmen</option>
                  <option value="60">Çevre</option>
                  <option value="61">Daðýtým</option>
                  <option value="65">Denetçi</option>
                  <option value="66">Denetim/Denetleme</option>
                  <option value="67">Deniz Bilimleri</option>
                  <option value="68">Depo</option>
                  <option value="69">Destek</option>
                  <option value="70">Dýþ Ýliþkiler</option>
                  <option value="71">Dýþ pazarlama</option>
                  <option value="72">Dýþ Satýnalma</option>
                  <option value="73">Dýþ Ticaret</option>
                  <option value="76">Diyetisyen</option>
                  <option value="77">Doktor</option>
                  <option value="78">Dokuma</option>
                  <option value="79">Dokümantasyon</option>
                  <option value="80">Donaným</option>
                  <option value="81">Eczacý</option>
                  <option value="82">Editör</option>
                  <option value="84">Eðitim</option>
                  <option value="86">Elektrik</option>
                  <option value="88">Elektrik/Elektronik</option>
                  <option value="89">Elektronik</option>
                  <option value="91">Emlak</option>
                  <option value="92">Endüstri</option>
                  <option value="94">Enerji</option>
                  <option value="95">ERP</option>
                  <option value="96">E-Ticaret</option>
                  <option value="97">Fabrika</option>
                  <option value="99">Finans</option>
                  <option value="444">Finans Kontrolörü</option>
                  <option value="101">Finansal Analist</option>
                  <option value="428">Firma Ortaðý</option>
                  <option value="427">Firma Sahibi</option>
                  <option value="102">Fizik</option>
                  <option value="103">Fon</option>
                  <option value="106">Garson</option>
                  <option value="108">Gazeteci</option>
                  <option value="109">Genel Müdür</option>
                  <option value="110">Genel Satýþ</option>
                  <option value="111">Gerber Operatörü</option>
                  <option value="112">Gýda</option>
                  <option value="113">Giþe</option>
                  <option value="115">Görsel Düzenleme/Sunum/Tasarým</option>
                  <option value="116">Gözetim</option>
                  <option value="117">Grafiker</option>
                  <option value="118">Grup</option>
                  <option value="120">Grup Ürün</option>
                  <option value="121">Gümrük</option>
                  <option value="122">Güvenlik</option>
                  <option value="123">Haber</option>
                  <option value="124">Haber Spikeri</option>
                  <option value="125">Haberleþme</option>
                  <option value="126">Halkla Ýliþkiler</option>
                  <option value="129">Harita</option>
                  <option value="130">Hasar</option>
                  <option value="131">Hasar Analisti</option>
                  <option value="132">Hastane</option>
                  <option value="133">Hayat Sigortasý</option>
                  <option value="134">Hazine</option>
                  <option value="135">Hemþire</option>
                  <option value="139">Hukuk</option>
                  <option value="142">Internet Hizmetleri</option>
                  <option value="143">Ýcra</option>
                  <option value="144">Ýç Hizmetler</option>
                  <option value="145">Ýç Mimar</option>
                  <option value="146">Ýç Satýnalma</option>
                  <option value="147">Ýçerik</option>
                  <option value="148">Ýdari Ýþler</option>
                  <option value="150">Ýhale</option>
                  <option value="151">Ýhracat</option>
                  <option value="153">Ýkmal </option>
                  <option value="155">Ýletiþim</option>
                  <option value="156">Ýmalat</option>
                  <option value="157">Ýnsan Kaynaklarý</option>
                  <option value="159">Ýnþaat</option>
                  <option value="161">Ýplik Boyama </option>
                  <option value="162">Ýplik Üretim</option>
                  <option value="163">Ýstasyon</option>
                  <option value="164">Ýstatistik</option>
                  <option value="165">Ýþ Geliþtirme</option>
                  <option value="166">Ýþletme</option>
                  <option value="167">Ýþyeri Hekimi</option>
                  <option value="168">Ýthalat</option>
                  <option value="169">Ýthalat/Ýhracat</option>
                  <option value="171">Jeoloji</option>
                  <option value="172">Kabin</option>
                  <option value="174">Kalýp</option>
                  <option value="175">Kalýp Tasarým</option>
                  <option value="176">Kalýphane</option>
                  <option value="177">Kalibrasyon</option>
                  <option value="178">Kalite</option>
                  <option value="180">Kalite Güvence</option>
                  <option value="181">Kalite Kontrol</option>
                  <option value="182">Kambiyo</option>
                  <option value="183">Kameraman</option>
                  <option value="184">Kamu</option>
                  <option value="185">Kanal</option>
                  <option value="186">Kanal Geliþtirme</option>
                  <option value="187">Kanal Satýþ</option>
                  <option value="188">Kargo</option>
                  <option value="189">Kart Satýþ Pazarlama</option>
                  <option value="190">Kasa </option>
                  <option value="191">Kasiyer</option>
                  <option value="192">Kategori</option>
                  <option value="486">Kaynak</option>
                  <option value="193">Kesim</option>
                  <option value="194">Kesimhane</option>
                  <option value="195">Kimya</option>
                  <option value="287">Klinik Araþtýrma</option>
                  <option value="197">Konfeksiyon Planlama</option>
                  <option value="198">Kontrol</option>
                  <option value="201">Kredi Pazarlama</option>
                  <option value="202">Kredi Risk</option>
                  <option value="203">Kredi Tahsis</option>
                  <option value="204">Kumaþ</option>
                  <option value="205">Kumaþ Depo</option>
                  <option value="206">Kumaþ Ýmalat</option>
                  <option value="207">Kurs </option>
                  <option value="208">Kurs Öðretmeni</option>
                  <option value="209">Kurumsal Ýletiþim </option>
                  <option value="210">Kurumsal Müþteriler</option>
                  <option value="211">Kurumsal Pazarlama</option>
                  <option value="213">Kütüphane</option>
                  <option value="214">Laborant</option>
                  <option value="215">Laboratuvar</option>
                  <option value="216">Lectra Operatörü</option>
                  <option value="218">Lojistik</option>
                  <option value="220">Maden</option>
                  <option value="222">Maðaza</option>
                  <option value="223">Maðaza Satýþ</option>
                  <option value="225">Makina</option>
                  <option value="226">Makina Bakým</option>
                  <option value="227">Mali Analist</option>
                  <option value="228">Mali Danýþman</option>
                  <option value="229">Mali Denetçi</option>
                  <option value="230">Mali Ýþler</option>
                  <option value="231">Mali Müþavir</option>
                  <option value="232">Mali Raporlama</option>
                  <option value="233">Maliyet Kontrol</option>
                  <option value="234">Maliyet Muhasebesi</option>
                  <option value="235">Malzeme</option>
                  <option value="236">Malzeme Planlama</option>
                  <option value="237">Marka</option>
                  <option value="238">Marka Ýletiþim</option>
                  <option value="240">Matematik</option>
                  <option value="241">Medikal </option>
                  <option value="242">Medya</option>
                  <option value="244">Mekanik</option>
                  <option value="245">Mekanik Bakým</option>
                  <option value="247">Merchandiser</option>
                  <option value="248">Metalurji</option>
                  <option value="249">Meteoroloji</option>
                  <option value="250">Metod</option>
                  <option value="251">MIS</option>
                  <option value="252">Mimar</option>
                  <option value="253">Misafir iliþkileri</option>
                  <option value="255">Modelhane</option>
                  <option value="256">Modelist</option>
                  <option value="257">Montaj</option>
                  <option value="258">Muhaberat</option>
                  <option value="259">Muhasebe</option>
                  <option value="263">Müfettiþ</option>
                  <option value="441">Müþteri</option>
                  <option value="265">Müþteri Hizmetleri</option>
                  <option value="266">Müþteri Temsilcisi</option>
                  <option value="267">Müteaahit</option>
                  <option value="268">Mütercim Tercüman</option>
                  <option value="269">Nakliyat</option>
                  <option value="270">Nakliye Ýthalat</option>
                  <option value="271">Nakliye Pazarlama</option>
                  <option value="272">Network</option>
                  <option value="273">Numune </option>
                  <option value="274">Nükleer Fizik</option>
                  <option value="275">Ofis</option>
                  <option value="276">Operasyon</option>
                  <option value="278">Organizasyon</option>
                  <option value="279">Otel</option>
                  <option value="438">Oyuncu</option>
                  <option value="281">Öðretim Görevlisi</option>
                  <option value="282">Öðretmen</option>
                  <option value="283">Ön Büro</option>
                  <option value="284">Ön Muhasebe</option>
                  <option value="285">Örme Ýmalat</option>
                  <option value="286">Örme Takip</option>
                  <option value="288">Pazar Araþtýrma</option>
                  <option value="289">Pazar Geliþtirme</option>
                  <option value="290">Pazarlama</option>
                  <option value="292">Perakende</option>
                  <option value="294">Personel</option>
                  <option value="297">Petrol</option>
                  <option value="299">Peyzaj Mimarý</option>
                  <option value="300">Planlama</option>
                  <option value="303">Portföy</option>
                  <option value="304">Program</option>
                  <option value="305">Proje</option>
                  <option value="306">Proses</option>
                  <option value="307">Psikolog</option>
                  <option value="308">Radyoloji</option>
                  <option value="309">Reklam</option>
                  <option value="311">Resepsiyon</option>
                  <option value="312">Restoran</option>
                  <option value="436">Reyon</option>
                  <option value="313">Rezervasyon</option>
                  <option value="314">Risk</option>
                  <option value="315">Ruhsatlandýrma</option>
                  <option value="316">Saðlýk</option>
                  <option value="318">Saha</option>
                  <option value="319">Santral</option>
                  <option value="320">SAP</option>
                  <option value="321">Satýnalma</option>
                  <option value="323">Satýþ</option>
                  <option value="435">Satýþ Destek</option>
                  <option value="434">Satýþ Sonrasý Hizmetler</option>
                  <option value="325">Sekreter</option>
                  <option value="326">Servis</option>
                  <option value="327">Sigorta</option>
                  <option value="329">Sistem</option>
                  <option value="330">Sistem Destek</option>
                  <option value="331">Sistem Geliþtirme</option>
                  <option value="332">Sistem Güvenlik</option>
                  <option value="333">Sistem operasyon</option>
                  <option value="334">Solid Ýmalat</option>
                  <option value="336">Sosyolog</option>
                  <option value="440">Sporcu</option>
                  <option value="337">Stajyer</option>
                  <option value="338">Stilist</option>
                  <option value="437">Stok Kontrol</option>
                  <option value="339">Strateji</option>
                  <option value="340">Stratejik Planlama</option>
                  <option value="341">Þantiye</option>
                  <option value="344">Þoför</option>
                  <option value="345">Þube</option>
                  <option value="346">Tahsilat</option>
                  <option value="347">Tanýtým</option>
                  <option value="348">Tasarým</option>
                  <option value="350">Tedarik</option>
                  <option value="351">Teknik</option>
                  <option value="353">Teknik Destek</option>
                  <option value="354">Teknik Ressam</option>
                  <option value="426">Teknik Servis</option>
                  <option value="357">Tekstil</option>
                  <option value="359">Telefon </option>
                  <option value="360">Telekomünikasyon</option>
                  <option value="362">Temizlik</option>
                  <option value="364">Tercüman</option>
                  <option value="365">Tezgahtar</option>
                  <option value="366">Týbbi Mümessil</option>
                  <option value="367">Týp Doktoru</option>
                  <option value="368">Týr Þoförü</option>
                  <option value="369">Ticaret</option>
                  <option value="371">Toptan Satýþ</option>
                  <option value="372">Tur </option>
                  <option value="373">Tur Rehberi</option>
                  <option value="377">Underwriter</option>
                  <option value="429">Ustabaþý</option>
                  <option value="378">Uygulama</option>
                  <option value="381">Üretim</option>
                  <option value="383">Üretim Kontrol</option>
                  <option value="384">Üretim Planlama</option>
                  <option value="385">Üretim Vardiya</option>
                  <option value="387">Ürün</option>
                  <option value="430">Ürün Geliþtirme</option>
                  <option value="388">Ürün Pazarlama</option>
                  <option value="389">Ürün Tanýtým</option>
                  <option value="391">Vardiya</option>
                  <option value="392">Vergi</option>
                  <option value="393">Veri Giriþ</option>
                  <option value="394">Veritabaný</option>
                  <option value="395">Veteriner</option>
                  <option value="396">Veznedar</option>
                  <option value="397">Vitrin tasarým</option>
                  <option value="398">Vize</option>
                  <option value="399">Web Programcýsý</option>
                  <option value="400">Web Tasarýmcýsý</option>
                  <option value="401">Yapýmcý</option>
                  <option value="402">Yatýrým</option>
                  <option value="424">Yazar</option>
                  <option value="403">Yazýlým</option>
                  <option value="404">Yazýlým Destek</option>
                  <option value="405">Yazýlým Geliþtirme</option>
                  <option value="406">Yazýlým Tasarým</option>
                  <option value="409">Yýkama Boyama</option>
                  <option value="410">Yiyecek/Ýçecek</option>
                  <option value="411">Yönetici Adayý</option>
                  <option value="412">Yönetici Asistaný</option>
                  <option value="413">Yönetici Sekreteri</option>
                  <option value="417">Yönetim Danýþmaný</option>
                  <option value="425">Yönetim Kurulu</option>
                  <option value="418">Zincir Maðazalar</option>
                  <option value="419">Ziraat</option>
                  <option value="420">Ziyafet</option>
              </select></td>
            </tr>
            <tr>
              <td align="right" valign="top">&nbsp;</td>
              <td valign="top">&nbsp;</td>
              <td align="right" valign="top">&nbsp;</td>
              <td valign="top">&nbsp;</td>
            </tr>
            <tr>
              <td align="right" valign="top"><p><strong>Þehir</strong></p></td>
              <td valign="top"><select name="pozisyon" id="pozisyon" multiple="multiple" style="width:230px;" size="5" title="Ctrl tuþuna basýlý tutarak en fazla 5 seçim yapabilirsiniz">
                  <option value="001">Adana</option>
                  <option value="085">Adýyaman</option>
                  <option value="086">Afyon</option>
                  <option value="087">Aðrý</option>
                  <option value="079">Aksaray</option>
                  <option value="089">Amasya</option>
                  <option value="002">Ankara</option>
                  <option value="003">Antalya</option>
                  <option value="090">Ardahan</option>
                  <option value="091">Artvin</option>
                  <option value="004">Aydýn</option>
                  <option value="005">Balýkesir</option>
                  <option value="092">Bartýn</option>
                  <option value="093">Batman</option>
                  <option value="094">Bayburt</option>
                  <option value="006">Bilecik</option>
                  <option value="095">Bingöl</option>
                  <option value="096">Bitlis</option>
                  <option value="007">Bolu</option>
                  <option value="097">Burdur</option>
                  <option value="008">Bursa</option>
                  <option value="009">Çanakkale</option>
                  <option value="010">Çankýrý</option>
                  <option value="098">Çorum</option>
                  <option value="011">Denizli</option>
                  <option value="012">Diyarbakýr</option>
                  <option value="126">Düzce</option>
                  <option value="013">Edirne</option>
                  <option value="099">Elazýð</option>
                  <option value="014">Erzincan</option>
                  <option value="015">Erzurum</option>
                  <option value="016">Eskiþehir</option>
                  <option value="017">Gaziantep</option>
                  <option value="100">Giresun</option>
                  <option value="101">Gümüþhane</option>
                  <option value="102">Hakkari</option>
                  <option value="018">Hatay</option>
                  <option value="103">Iðdýr</option>
                  <option value="019">Isparta</option>
                  <option value="021">Ýstanbul</option>
                  <option value="022">Ýzmir</option>
                  <option value="104">K.Maraþ</option>
                  <option value="023">Karabük</option>
                  <option value="105">Karaman</option>
                  <option value="106">Kars</option>
                  <option value="107">Kastamonu</option>
                  <option value="024">Kayseri</option>
                  <option value="080">Kýrýkkale</option>
                  <option value="084">Kýrklareli</option>
                  <option value="109">Kýrþehir</option>
                  <option value="110">Kilis</option>
                  <option value="026">Kocaeli</option>
                  <option value="190">Kocaeli-Gebze</option>
                  <option value="025">Konya</option>
                  <option value="081">Kütahya</option>
                  <option value="112">Malatya</option>
                  <option value="027">Manisa</option>
                  <option value="113">Mardin</option>
                  <option value="020">Mersin</option>
                  <option value="028">Muðla</option>
                  <option value="114">Muþ</option>
                  <option value="029">Nevþehir</option>
                  <option value="030">Niðde</option>
                  <option value="115">Ordu</option>
                  <option value="116">Osmaniye</option>
                  <option value="031">Rize</option>
                  <option value="032">Sakarya</option>
                  <option value="033">Samsun</option>
                  <option value="117">Siirt</option>
                  <option value="118">Sinop</option>
                  <option value="119">Sivas</option>
                  <option value="120">Þanlýurfa</option>
                  <option value="108">Þýrnak</option>
                  <option value="034">Tekirdað</option>
                  <option value="121">Tokat</option>
                  <option value="035">Trabzon</option>
                  <option value="122">Tunceli</option>
                  <option value="123">Uþak</option>
                  <option value="124">Van</option>
                  <option value="036">Yalova</option>
                  <option value="125">Yozgat</option>
                  <option value="037">Zonguldak</option>
              </select></td>
              <td align="right" valign="top"><p><strong>Þirket</strong></p></td>
              <td valign="top">                <select name="select5" id="select2" multiple="multiple" style="width:230px;" size="5" title="Ctrl tuþuna basýlý tutarak en fazla 5 seçim yapabilirsiniz">
                  <option value="001">Adnanoðullarý Ltd.</option>
                  <option value="085">Ademcevahirler</option>
                  <option value="086">Arkas Nakliyat</option>
                  <option value="087">Aynen Donaným</option>
                  <option value="079">Baytar Lustro Salonu</option>
                  <option value="089">Bereket Döner</option>
                  <option>Celibirþirket</option>
                  </select>              </td>
            </tr>
            <tr>
              <td align="right" valign="top">&nbsp;</td>
              <td valign="top">&nbsp;</td>
              <td align="right" valign="top">&nbsp;</td>
              <td valign="top">&nbsp;</td>
            </tr>
            <tr>
              <td align="right" valign="top"><p><strong>Eðitim<br />
                durumu</strong></p></td>
              <td valign="top"><p>
                  <input type="checkbox" name="checkbox322223" value="checkbox" />
                  &nbsp;Doktora </p>
                <p>
                  <input type="checkbox" name="checkbox42223" value="checkbox" />
                  &nbsp;Master </p>
                <p>
                  <input type="checkbox" name="checkbox232223" value="checkbox" />
                  &nbsp;Lisans </p>
                <p>
                  <input type="checkbox" name="checkbox322223" value="checkbox" />
                  &nbsp;Meslek Yüksekokulu</p>
                <p>
                  <input type="checkbox" name="checkbox2222222" value="checkbox" />
                  &nbsp;Lise</p>
                <p>
                  <input type="checkbox" name="checkbox22222222" value="checkbox" />
              &nbsp;Ýlkokul</p></td>
              <td align="right" valign="top"><p><strong>Yaþ aralýðý</strong></p></td>
              <td valign="top"><p>
                  <input type="checkbox" name="checkbox32222" value="checkbox" />
                  &nbsp;18-25 arasý </p>
                <p>
                  <input type="checkbox" name="checkbox4222" value="checkbox" />
                  &nbsp;25-31 arasý </p>
                <p>
                  <input type="checkbox" name="checkbox23222" value="checkbox" />
                  &nbsp;31-41 arasý </p>
                <p>
                  <input type="checkbox" name="checkbox32222" value="checkbox" />
                  &nbsp;41-51</p>
                <p>
                  <input type="checkbox" name="checkbox222222" value="checkbox" />
              &nbsp;51 ve üstü</p></td>
            </tr>
            <tr>
              <td align="right" valign="top">&nbsp;</td>
              <td valign="top">&nbsp;</td>
              <td align="right" valign="top">&nbsp;</td>
              <td valign="top">&nbsp;</td>
            </tr>
            <tr>
              <td align="right" valign="top"><p><strong>Çalýþma tipi</strong></p></td>
              <td valign="top"><p>
                  <input type="checkbox" name="checkbox4" value="checkbox" />
                  Sürekli / Tam Zamanlý</p>
                <p>
                  <input type="checkbox" name="checkbox23" value="checkbox" />
                  Dönemsel / Proje Bazlý</p>
                <p>
                  <input type="checkbox" name="checkbox32" value="checkbox" />
                  Yarý Zamanlý</p>
                <p>
                  <input type="checkbox" name="checkbox222" value="checkbox" />
              Stajer</p></td>
              <td align="right" valign="top"><p><strong>Ýlan tarihi</strong></p></td>
              <td valign="top"><p>
                  <input name="checkbox322222" type="checkbox" value="checkbox" checked="checked" />
                  &nbsp;Son 15 gün </p>
                <p>
                  <input type="checkbox" name="checkbox42222" value="checkbox" />
                  &nbsp;Son 1 ay </p>
                <p>
                  <input type="checkbox" name="checkbox232222" value="checkbox" />
              &nbsp;Son 2 ay</p></td>
            </tr>
            <tr>
              <td align="right" valign="top">&nbsp;</td>
              <td valign="top">&nbsp;</td>
              <td align="right" valign="top">&nbsp;</td>
              <td valign="top">&nbsp;</td>
            </tr>
            <tr>
              <td align="right" valign="top"><p><strong>Ýlan türü</strong></p></td>
              <td valign="top"><p>
                  <input type="checkbox" name="checkbox3223" value="checkbox" />
                  &nbsp;Engelli</p>
                <p>
                  <input type="checkbox" name="checkbox22223" value="checkbox" />
                  &nbsp;Þehit Yakýný / Terör Maðduru</p>
                <p>
                  <input type="checkbox" name="checkbox3223" value="checkbox" />
              &nbsp;Eski Hükümlü</p></td>
              <td align="right" valign="top">&nbsp;</td>
              <td valign="top"><p>&nbsp;</p></td>
            </tr>
          </table>
          <p>&nbsp;</p>
          <div class="HeaderPR floatLeft">
            <h2 class="sIFRHeader" style="width:200px;">Ýþ Deneyimi</h2>
          </div>
		  <div class="hr"><hr /></div>
          <table width="100%" class="FormTable">
            <tr>
              <td width="85" align="right" valign="top"><p><strong>Sektör</strong></p></td>
              <td valign="top"><select name="select4" id="select6" multiple="multiple" style="width:230px;" size="5" title="Ctrl tuþuna basýlý tutarak en fazla 5 seçim yapabilirsiniz">
                  <option value="2">Ambalaj ve Kaðýt</option>
                  <option value="64">Bankacýlýk / Finans</option>
                  <option value="3">Beyaz Eþya</option>
                  <option value="4">Bilgisayar / BT / Internet</option>
                  <option value="5">Cam ve Seramik</option>
                  <option value="6">Daðýtým</option>
                  <option value="7">Danýþmanlýk</option>
                  <option value="8">Dayanýklý Tüketim Mallarý</option>
                  <option value="9">Demir-Çelik</option>
                  <option value="10">Denizcilik</option>
                  <option value="11">Deri</option>
                  <option value="12">Dernek ve Vakýf</option>
                  <option value="13">Dýþ Ticaret</option>
                  <option value="14">Eðitim</option>
                  <option value="15">Eðlence</option>
                  <option value="16">Endüstri</option>
                  <option value="1">Elektrik ve Elektronik</option>
                  <option value="17">Faktoring</option>
                  <option value="18">Gayrimenkul</option>
                  <option value="19">Gýda</option>
                  <option value="20">Halkla Ýliþkiler</option>
                  <option value="21">Havacýlýk</option>
                  <option value="63">Hýzlý Tüketim Mallarý</option>
                  <option value="22">Hayvancýlýk</option>
                  <option value="23">Hizmet / Ýþletme Servisi</option>
                  <option value="24">Holding</option>
                  <option value="25">Hukuk</option>
                  <option value="26">Ýlaç</option>
                  <option value="27">Ýmalat</option>
                  <option value="28">Ýnþaat</option>
                  <option value="29">Ýthalat/Ýhracat</option>
                  <option value="30">Kamu</option>
                  <option value="31">Kimya</option>
                  <option value="32">Kozmetik</option>
                  <option value="33">Leasing</option>
                  <option value="40">Lojistik</option>
                  <option value="34">Madencilik</option>
                  <option value="35">Maðazacýlýk / Perakendecilik</option>
                  <option value="36">Mali Denetim-Vergi</option>
                  <option value="37">Mali Müþavirlik</option>
                  <option value="38">Medya</option>
                  <option value="39">Mimarlýk</option>
                  <option value="41">Otelcilik</option>
                  <option value="42">Otomotiv</option>
                  <option value="43">Petrol ve Petrol ürünleri</option>
                  <option value="44">Reklamcýlýk</option>
                  <option value="45">Restorancýlýk</option>
                  <option value="46">Saðlýk/Hastane</option>
                  <option value="47">Sanat</option>
                  <option value="48">Savunma/Güvenlik</option>
                  <option value="49">Sigortacýlýk</option>
                  <option value="50">Sosyal Servisler</option>
                  <option value="51">Tarým ve Orman Ürünleri</option>
                  <option value="52">Tekstil</option>
                  <option value="53">Telekomünikasyon ve Network</option>
                  <option value="54">Týbbi Malzeme</option>
                  <option value="55">Toptancýlýk</option>
                  <option value="56">Turizm</option>
                  <option value="57">Ulaþým</option>
                  <option value="58">Yapý Malzemeleri</option>
                  <option value="59">Yatýrým / Menkul Deðerler</option>
                  <option value="62">Yatýrým /Menkul D. /Borsacýlýk</option>
                  <option value="60">Yayýncýlýk</option>
                  <option value="61">Diðer</option>
              </select></td>
              <td align="right" valign="top"><p><strong>Pozisyon</strong></p></td>
              <td valign="top"><select name="select4" id="select5" multiple="multiple" style="width:230px;" size="5" title="Ctrl tuþuna basýlý tutarak en fazla 5 seçim yapabilirsiniz">
                  <option value="2">Acente</option>
                  <option value="3">Aðýr Vasýta Þoförü</option>
                  <option value="4">Ahçý/Aþçý</option>
                  <option value="5">Akademisyen</option>
                  <option value="6">Akaryakýt Ýstasyon</option>
                  <option value="7">Aktif Pazarlama</option>
                  <option value="8">Aktif Satýþ</option>
                  <option value="9">Aktivasyon</option>
                  <option value="10">Ambar</option>
                  <option value="12">Analist</option>
                  <option value="13">Analist Programcý</option>
                  <option value="15">Analiz</option>
                  <option value="16">Animatör</option>
                  <option value="431">Anketör</option>
                  <option value="433">Antrenör</option>
                  <option value="17">Antrepo</option>
                  <option value="18">Apre</option>
                  <option value="19">Araþtýrma</option>
                  <option value="20">Araþtýrma Geliþtirme</option>
                  <option value="423">Avukat</option>
                  <option value="22">Bakým</option>
                  <option value="23">Bakým Onarým</option>
                  <option value="24">Banka</option>
                  <option value="25">Banka Ýhracat/Ýthalat</option>
                  <option value="26">Banka Kredi Pazarlama</option>
                  <option value="27">Banka Operasyon</option>
                  <option value="29">Bar</option>
                  <option value="30">Basýn</option>
                  <option value="31">Basýn ve Halkla Ýliþkiler</option>
                  <option value="32">Baský</option>
                  <option value="33">Baský Nakýþ</option>
                  <option value="34">Baþhekim</option>
                  <option value="35">Baþhemþire</option>
                  <option value="36">Bayi Kanalý</option>
                  <option value="37">Bilgi Giriþ</option>
                  <option value="39">Bilgi Ýþlem</option>
                  <option value="40">Bilgi Sistemleri</option>
                  <option value="41">Bilgi Teknolojileri</option>
                  <option value="42">Bilgisayar</option>
                  <option value="44">Bireysel Pazarlama</option>
                  <option value="45">Birim</option>
                  <option value="432">Birim/Departman</option>
                  <option value="46">Biyokimya</option>
                  <option value="47">Biyolog</option>
                  <option value="48">Biyoloji</option>
                  <option value="49">Biyomedikal</option>
                  <option value="50">Bordro</option>
                  <option value="51">Borsa</option>
                  <option value="52">Bölge</option>
                  <option value="53">Bölge Satýþ</option>
                  <option value="54">Bütçe</option>
                  <option value="55">Bütçe Raporlama</option>
                  <option value="56">Büyük Müþteriler</option>
                  <option value="57">Cad/Cam</option>
                  <option value="439">CNC</option>
                  <option value="58">Çaðrý Merkezi</option>
                  <option value="59">Çevirmen</option>
                  <option value="60">Çevre</option>
                  <option value="61">Daðýtým</option>
                  <option value="65">Denetçi</option>
                  <option value="66">Denetim/Denetleme</option>
                  <option value="67">Deniz Bilimleri</option>
                  <option value="68">Depo</option>
                  <option value="69">Destek</option>
                  <option value="70">Dýþ Ýliþkiler</option>
                  <option value="71">Dýþ pazarlama</option>
                  <option value="72">Dýþ Satýnalma</option>
                  <option value="73">Dýþ Ticaret</option>
                  <option value="76">Diyetisyen</option>
                  <option value="77">Doktor</option>
                  <option value="78">Dokuma</option>
                  <option value="79">Dokümantasyon</option>
                  <option value="80">Donaným</option>
                  <option value="81">Eczacý</option>
                  <option value="82">Editör</option>
                  <option value="84">Eðitim</option>
                  <option value="86">Elektrik</option>
                  <option value="88">Elektrik/Elektronik</option>
                  <option value="89">Elektronik</option>
                  <option value="91">Emlak</option>
                  <option value="92">Endüstri</option>
                  <option value="94">Enerji</option>
                  <option value="95">ERP</option>
                  <option value="96">E-Ticaret</option>
                  <option value="97">Fabrika</option>
                  <option value="99">Finans</option>
                  <option value="444">Finans Kontrolörü</option>
                  <option value="101">Finansal Analist</option>
                  <option value="428">Firma Ortaðý</option>
                  <option value="427">Firma Sahibi</option>
                  <option value="102">Fizik</option>
                  <option value="103">Fon</option>
                  <option value="106">Garson</option>
                  <option value="108">Gazeteci</option>
                  <option value="109">Genel Müdür</option>
                  <option value="110">Genel Satýþ</option>
                  <option value="111">Gerber Operatörü</option>
                  <option value="112">Gýda</option>
                  <option value="113">Giþe</option>
                  <option value="115">Görsel Düzenleme/Sunum/Tasarým</option>
                  <option value="116">Gözetim</option>
                  <option value="117">Grafiker</option>
                  <option value="118">Grup</option>
                  <option value="120">Grup Ürün</option>
                  <option value="121">Gümrük</option>
                  <option value="122">Güvenlik</option>
                  <option value="123">Haber</option>
                  <option value="124">Haber Spikeri</option>
                  <option value="125">Haberleþme</option>
                  <option value="126">Halkla Ýliþkiler</option>
                  <option value="129">Harita</option>
                  <option value="130">Hasar</option>
                  <option value="131">Hasar Analisti</option>
                  <option value="132">Hastane</option>
                  <option value="133">Hayat Sigortasý</option>
                  <option value="134">Hazine</option>
                  <option value="135">Hemþire</option>
                  <option value="139">Hukuk</option>
                  <option value="142">Internet Hizmetleri</option>
                  <option value="143">Ýcra</option>
                  <option value="144">Ýç Hizmetler</option>
                  <option value="145">Ýç Mimar</option>
                  <option value="146">Ýç Satýnalma</option>
                  <option value="147">Ýçerik</option>
                  <option value="148">Ýdari Ýþler</option>
                  <option value="150">Ýhale</option>
                  <option value="151">Ýhracat</option>
                  <option value="153">Ýkmal </option>
                  <option value="155">Ýletiþim</option>
                  <option value="156">Ýmalat</option>
                  <option value="157">Ýnsan Kaynaklarý</option>
                  <option value="159">Ýnþaat</option>
                  <option value="161">Ýplik Boyama </option>
                  <option value="162">Ýplik Üretim</option>
                  <option value="163">Ýstasyon</option>
                  <option value="164">Ýstatistik</option>
                  <option value="165">Ýþ Geliþtirme</option>
                  <option value="166">Ýþletme</option>
                  <option value="167">Ýþyeri Hekimi</option>
                  <option value="168">Ýthalat</option>
                  <option value="169">Ýthalat/Ýhracat</option>
                  <option value="171">Jeoloji</option>
                  <option value="172">Kabin</option>
                  <option value="174">Kalýp</option>
                  <option value="175">Kalýp Tasarým</option>
                  <option value="176">Kalýphane</option>
                  <option value="177">Kalibrasyon</option>
                  <option value="178">Kalite</option>
                  <option value="180">Kalite Güvence</option>
                  <option value="181">Kalite Kontrol</option>
                  <option value="182">Kambiyo</option>
                  <option value="183">Kameraman</option>
                  <option value="184">Kamu</option>
                  <option value="185">Kanal</option>
                  <option value="186">Kanal Geliþtirme</option>
                  <option value="187">Kanal Satýþ</option>
                  <option value="188">Kargo</option>
                  <option value="189">Kart Satýþ Pazarlama</option>
                  <option value="190">Kasa </option>
                  <option value="191">Kasiyer</option>
                  <option value="192">Kategori</option>
                  <option value="486">Kaynak</option>
                  <option value="193">Kesim</option>
                  <option value="194">Kesimhane</option>
                  <option value="195">Kimya</option>
                  <option value="287">Klinik Araþtýrma</option>
                  <option value="197">Konfeksiyon Planlama</option>
                  <option value="198">Kontrol</option>
                  <option value="201">Kredi Pazarlama</option>
                  <option value="202">Kredi Risk</option>
                  <option value="203">Kredi Tahsis</option>
                  <option value="204">Kumaþ</option>
                  <option value="205">Kumaþ Depo</option>
                  <option value="206">Kumaþ Ýmalat</option>
                  <option value="207">Kurs </option>
                  <option value="208">Kurs Öðretmeni</option>
                  <option value="209">Kurumsal Ýletiþim </option>
                  <option value="210">Kurumsal Müþteriler</option>
                  <option value="211">Kurumsal Pazarlama</option>
                  <option value="213">Kütüphane</option>
                  <option value="214">Laborant</option>
                  <option value="215">Laboratuvar</option>
                  <option value="216">Lectra Operatörü</option>
                  <option value="218">Lojistik</option>
                  <option value="220">Maden</option>
                  <option value="222">Maðaza</option>
                  <option value="223">Maðaza Satýþ</option>
                  <option value="225">Makina</option>
                  <option value="226">Makina Bakým</option>
                  <option value="227">Mali Analist</option>
                  <option value="228">Mali Danýþman</option>
                  <option value="229">Mali Denetçi</option>
                  <option value="230">Mali Ýþler</option>
                  <option value="231">Mali Müþavir</option>
                  <option value="232">Mali Raporlama</option>
                  <option value="233">Maliyet Kontrol</option>
                  <option value="234">Maliyet Muhasebesi</option>
                  <option value="235">Malzeme</option>
                  <option value="236">Malzeme Planlama</option>
                  <option value="237">Marka</option>
                  <option value="238">Marka Ýletiþim</option>
                  <option value="240">Matematik</option>
                  <option value="241">Medikal </option>
                  <option value="242">Medya</option>
                  <option value="244">Mekanik</option>
                  <option value="245">Mekanik Bakým</option>
                  <option value="247">Merchandiser</option>
                  <option value="248">Metalurji</option>
                  <option value="249">Meteoroloji</option>
                  <option value="250">Metod</option>
                  <option value="251">MIS</option>
                  <option value="252">Mimar</option>
                  <option value="253">Misafir iliþkileri</option>
                  <option value="255">Modelhane</option>
                  <option value="256">Modelist</option>
                  <option value="257">Montaj</option>
                  <option value="258">Muhaberat</option>
                  <option value="259">Muhasebe</option>
                  <option value="263">Müfettiþ</option>
                  <option value="441">Müþteri</option>
                  <option value="265">Müþteri Hizmetleri</option>
                  <option value="266">Müþteri Temsilcisi</option>
                  <option value="267">Müteaahit</option>
                  <option value="268">Mütercim Tercüman</option>
                  <option value="269">Nakliyat</option>
                  <option value="270">Nakliye Ýthalat</option>
                  <option value="271">Nakliye Pazarlama</option>
                  <option value="272">Network</option>
                  <option value="273">Numune </option>
                  <option value="274">Nükleer Fizik</option>
                  <option value="275">Ofis</option>
                  <option value="276">Operasyon</option>
                  <option value="278">Organizasyon</option>
                  <option value="279">Otel</option>
                  <option value="438">Oyuncu</option>
                  <option value="281">Öðretim Görevlisi</option>
                  <option value="282">Öðretmen</option>
                  <option value="283">Ön Büro</option>
                  <option value="284">Ön Muhasebe</option>
                  <option value="285">Örme Ýmalat</option>
                  <option value="286">Örme Takip</option>
                  <option value="288">Pazar Araþtýrma</option>
                  <option value="289">Pazar Geliþtirme</option>
                  <option value="290">Pazarlama</option>
                  <option value="292">Perakende</option>
                  <option value="294">Personel</option>
                  <option value="297">Petrol</option>
                  <option value="299">Peyzaj Mimarý</option>
                  <option value="300">Planlama</option>
                  <option value="303">Portföy</option>
                  <option value="304">Program</option>
                  <option value="305">Proje</option>
                  <option value="306">Proses</option>
                  <option value="307">Psikolog</option>
                  <option value="308">Radyoloji</option>
                  <option value="309">Reklam</option>
                  <option value="311">Resepsiyon</option>
                  <option value="312">Restoran</option>
                  <option value="436">Reyon</option>
                  <option value="313">Rezervasyon</option>
                  <option value="314">Risk</option>
                  <option value="315">Ruhsatlandýrma</option>
                  <option value="316">Saðlýk</option>
                  <option value="318">Saha</option>
                  <option value="319">Santral</option>
                  <option value="320">SAP</option>
                  <option value="321">Satýnalma</option>
                  <option value="323">Satýþ</option>
                  <option value="435">Satýþ Destek</option>
                  <option value="434">Satýþ Sonrasý Hizmetler</option>
                  <option value="325">Sekreter</option>
                  <option value="326">Servis</option>
                  <option value="327">Sigorta</option>
                  <option value="329">Sistem</option>
                  <option value="330">Sistem Destek</option>
                  <option value="331">Sistem Geliþtirme</option>
                  <option value="332">Sistem Güvenlik</option>
                  <option value="333">Sistem operasyon</option>
                  <option value="334">Solid Ýmalat</option>
                  <option value="336">Sosyolog</option>
                  <option value="440">Sporcu</option>
                  <option value="337">Stajyer</option>
                  <option value="338">Stilist</option>
                  <option value="437">Stok Kontrol</option>
                  <option value="339">Strateji</option>
                  <option value="340">Stratejik Planlama</option>
                  <option value="341">Þantiye</option>
                  <option value="344">Þoför</option>
                  <option value="345">Þube</option>
                  <option value="346">Tahsilat</option>
                  <option value="347">Tanýtým</option>
                  <option value="348">Tasarým</option>
                  <option value="350">Tedarik</option>
                  <option value="351">Teknik</option>
                  <option value="353">Teknik Destek</option>
                  <option value="354">Teknik Ressam</option>
                  <option value="426">Teknik Servis</option>
                  <option value="357">Tekstil</option>
                  <option value="359">Telefon </option>
                  <option value="360">Telekomünikasyon</option>
                  <option value="362">Temizlik</option>
                  <option value="364">Tercüman</option>
                  <option value="365">Tezgahtar</option>
                  <option value="366">Týbbi Mümessil</option>
                  <option value="367">Týp Doktoru</option>
                  <option value="368">Týr Þoförü</option>
                  <option value="369">Ticaret</option>
                  <option value="371">Toptan Satýþ</option>
                  <option value="372">Tur </option>
                  <option value="373">Tur Rehberi</option>
                  <option value="377">Underwriter</option>
                  <option value="429">Ustabaþý</option>
                  <option value="378">Uygulama</option>
                  <option value="381">Üretim</option>
                  <option value="383">Üretim Kontrol</option>
                  <option value="384">Üretim Planlama</option>
                  <option value="385">Üretim Vardiya</option>
                  <option value="387">Ürün</option>
                  <option value="430">Ürün Geliþtirme</option>
                  <option value="388">Ürün Pazarlama</option>
                  <option value="389">Ürün Tanýtým</option>
                  <option value="391">Vardiya</option>
                  <option value="392">Vergi</option>
                  <option value="393">Veri Giriþ</option>
                  <option value="394">Veritabaný</option>
                  <option value="395">Veteriner</option>
                  <option value="396">Veznedar</option>
                  <option value="397">Vitrin tasarým</option>
                  <option value="398">Vize</option>
                  <option value="399">Web Programcýsý</option>
                  <option value="400">Web Tasarýmcýsý</option>
                  <option value="401">Yapýmcý</option>
                  <option value="402">Yatýrým</option>
                  <option value="424">Yazar</option>
                  <option value="403">Yazýlým</option>
                  <option value="404">Yazýlým Destek</option>
                  <option value="405">Yazýlým Geliþtirme</option>
                  <option value="406">Yazýlým Tasarým</option>
                  <option value="409">Yýkama Boyama</option>
                  <option value="410">Yiyecek/Ýçecek</option>
                  <option value="411">Yönetici Adayý</option>
                  <option value="412">Yönetici Asistaný</option>
                  <option value="413">Yönetici Sekreteri</option>
                  <option value="417">Yönetim Danýþmaný</option>
                  <option value="425">Yönetim Kurulu</option>
                  <option value="418">Zincir Maðazalar</option>
                  <option value="419">Ziraat</option>
                  <option value="420">Ziyafet</option>
              </select></td>
            </tr>
            <tr>
              <td align="right">&nbsp;</td>
              <td colspan="3">&nbsp;</td>
            </tr>
            <tr>
              <td align="right">&nbsp;</td>
              <td colspan="3"><p>
                  <input name="radiobutton" type="radio" value="radiobutton" checked="checked" />
                  Tüm ilanlarda arayýn</p>
                <p>
                  <input name="radiobutton" type="radio" value="radiobutton" />
                  Size uygun ilanlarda arayýn</p></td>
            </tr>
            <tr>
              <td align="right">&nbsp;</td>
              <td colspan="3">&nbsp;</td>
            </tr>
            <tr>
              <td align="right">&nbsp;</td>
              <td colspan="3"><a href="/pikcv/2_3_8_2_ilan_arama_sonucu.htm">
                <asp:ImageButton ImageUrl="~/Images/buttons/Search.png" runat="server" ID="imgSearch" BorderWidth="0" /></td>
            </tr>
            <tr>
              <td align="right">&nbsp;</td>
              <td colspan="3">&nbsp;</td>
            </tr>
          </table>
          <div class="brclear"></div>
        </div>
      </div>
      <div class="BoxContentBottom"></div>
      <!-- finish roundcornered box -->
    </div>