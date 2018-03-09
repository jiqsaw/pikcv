<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uDetailSearch.ascx.cs" Inherits="UserControls_Employee_Search_uDetailSearch" %>

<div class="contentPad">
      <div class="HeaderPR floatLeft">
        <h2 class="sIFRHeader" style="width:200px;">Detayl� �lan Arama</h2>
      </div>
      <div id="Tab">
        <ul>
          <li><a href="#Employee-Search-EasySearch"><span>Kolay arama</span></a></li>
          <li class="TabActive"><a href="javascript:void(0);"><span>Detayl� arama</span></a></li>
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
            <h2 class="sIFRHeader" style="width:200px;">Genel Se�im Kriterleri</h2>
          </div>
		  <div class="hr"><hr /></div>
          <table width="100%" class="FormTable">
            <tr>
              <td width="85" align="right">&nbsp;</td>
                <td colspan="3">
                    <div class="infoMsg">
                        <p>Birden fazla se�enek i�aretlemek i�in Ctrl tu�unu bas�l� tutarak t�klay�n.<br />
                        Her listeden en fazla 5 kriter se�ebilirsiniz.</p>
                    </div>
                </td>
            </tr>
            <tr>
              <td align="right" valign="top"><p><strong>Sekt�r</strong></p></td>
              <td valign="top"><select name="select2" id="sektor" multiple="multiple" style="width:230px;" size="5" title="Ctrl tu�una bas�l� tutarak en fazla 5 se�im yapabilirsiniz">
                  <option value="2">Ambalaj ve Ka��t</option>
                  <option value="64">Bankac�l�k / Finans</option>
                  <option value="3">Beyaz E�ya</option>
                  <option value="4">Bilgisayar / BT / Internet</option>
                  <option value="5">Cam ve Seramik</option>
                  <option value="6">Da��t�m</option>
                  <option value="7">Dan��manl�k</option>
                  <option value="8">Dayan�kl� T�ketim Mallar�</option>
                  <option value="9">Demir-�elik</option>
                  <option value="10">Denizcilik</option>
                  <option value="11">Deri</option>
                  <option value="12">Dernek ve Vak�f</option>
                  <option value="13">D�� Ticaret</option>
                  <option value="14">E�itim</option>
                  <option value="15">E�lence</option>
                  <option value="16">End�stri</option>
                  <option value="1">Elektrik ve Elektronik</option>
                  <option value="17">Faktoring</option>
                  <option value="18">Gayrimenkul</option>
                  <option value="19">G�da</option>
                  <option value="20">Halkla �li�kiler</option>
                  <option value="21">Havac�l�k</option>
                  <option value="63">H�zl� T�ketim Mallar�</option>
                  <option value="22">Hayvanc�l�k</option>
                  <option value="23">Hizmet / ��letme Servisi</option>
                  <option value="24">Holding</option>
                  <option value="25">Hukuk</option>
                  <option value="26">�la�</option>
                  <option value="27">�malat</option>
                  <option value="28">�n�aat</option>
                  <option value="29">�thalat/�hracat</option>
                  <option value="30">Kamu</option>
                  <option value="31">Kimya</option>
                  <option value="32">Kozmetik</option>
                  <option value="33">Leasing</option>
                  <option value="40">Lojistik</option>
                  <option value="34">Madencilik</option>
                  <option value="35">Ma�azac�l�k / Perakendecilik</option>
                  <option value="36">Mali Denetim-Vergi</option>
                  <option value="37">Mali M��avirlik</option>
                  <option value="38">Medya</option>
                  <option value="39">Mimarl�k</option>
                  <option value="41">Otelcilik</option>
                  <option value="42">Otomotiv</option>
                  <option value="43">Petrol ve Petrol �r�nleri</option>
                  <option value="44">Reklamc�l�k</option>
                  <option value="45">Restoranc�l�k</option>
                  <option value="46">Sa�l�k/Hastane</option>
                  <option value="47">Sanat</option>
                  <option value="48">Savunma/G�venlik</option>
                  <option value="49">Sigortac�l�k</option>
                  <option value="50">Sosyal Servisler</option>
                  <option value="51">Tar�m ve Orman �r�nleri</option>
                  <option value="52">Tekstil</option>
                  <option value="53">Telekom�nikasyon ve Network</option>
                  <option value="54">T�bbi Malzeme</option>
                  <option value="55">Toptanc�l�k</option>
                  <option value="56">Turizm</option>
                  <option value="57">Ula��m</option>
                  <option value="58">Yap� Malzemeleri</option>
                  <option value="59">Yat�r�m / Menkul De�erler</option>
                  <option value="62">Yat�r�m /Menkul D. /Borsac�l�k</option>
                  <option value="60">Yay�nc�l�k</option>
                  <option value="61">Di�er</option>
              </select></td>
              <td align="right" valign="top"><p><strong>Pozisyon</strong></p></td>
              <td valign="top"><select name="select3" multiple="multiple" id="select" style="width:230px;" size="5" title="Ctrl tu�una bas�l� tutarak en fazla 5 se�im yapabilirsiniz">
                  <option value="2">Acente</option>
                  <option value="3">A��r Vas�ta �of�r�</option>
                  <option value="4">Ah��/A���</option>
                  <option value="5">Akademisyen</option>
                  <option value="6">Akaryak�t �stasyon</option>
                  <option value="7">Aktif Pazarlama</option>
                  <option value="8">Aktif Sat��</option>
                  <option value="9">Aktivasyon</option>
                  <option value="10">Ambar</option>
                  <option value="12">Analist</option>
                  <option value="13">Analist Programc�</option>
                  <option value="15">Analiz</option>
                  <option value="16">Animat�r</option>
                  <option value="431">Anket�r</option>
                  <option value="433">Antren�r</option>
                  <option value="17">Antrepo</option>
                  <option value="18">Apre</option>
                  <option value="19">Ara�t�rma</option>
                  <option value="20">Ara�t�rma Geli�tirme</option>
                  <option value="423">Avukat</option>
                  <option value="22">Bak�m</option>
                  <option value="23">Bak�m Onar�m</option>
                  <option value="24">Banka</option>
                  <option value="25">Banka �hracat/�thalat</option>
                  <option value="26">Banka Kredi Pazarlama</option>
                  <option value="27">Banka Operasyon</option>
                  <option value="29">Bar</option>
                  <option value="30">Bas�n</option>
                  <option value="31">Bas�n ve Halkla �li�kiler</option>
                  <option value="32">Bask�</option>
                  <option value="33">Bask� Nak��</option>
                  <option value="34">Ba�hekim</option>
                  <option value="35">Ba�hem�ire</option>
                  <option value="36">Bayi Kanal�</option>
                  <option value="37">Bilgi Giri�</option>
                  <option value="39">Bilgi ��lem</option>
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
                  <option value="52">B�lge</option>
                  <option value="53">B�lge Sat��</option>
                  <option value="54">B�t�e</option>
                  <option value="55">B�t�e Raporlama</option>
                  <option value="56">B�y�k M��teriler</option>
                  <option value="57">Cad/Cam</option>
                  <option value="439">CNC</option>
                  <option value="58">�a�r� Merkezi</option>
                  <option value="59">�evirmen</option>
                  <option value="60">�evre</option>
                  <option value="61">Da��t�m</option>
                  <option value="65">Denet�i</option>
                  <option value="66">Denetim/Denetleme</option>
                  <option value="67">Deniz Bilimleri</option>
                  <option value="68">Depo</option>
                  <option value="69">Destek</option>
                  <option value="70">D�� �li�kiler</option>
                  <option value="71">D�� pazarlama</option>
                  <option value="72">D�� Sat�nalma</option>
                  <option value="73">D�� Ticaret</option>
                  <option value="76">Diyetisyen</option>
                  <option value="77">Doktor</option>
                  <option value="78">Dokuma</option>
                  <option value="79">Dok�mantasyon</option>
                  <option value="80">Donan�m</option>
                  <option value="81">Eczac�</option>
                  <option value="82">Edit�r</option>
                  <option value="84">E�itim</option>
                  <option value="86">Elektrik</option>
                  <option value="88">Elektrik/Elektronik</option>
                  <option value="89">Elektronik</option>
                  <option value="91">Emlak</option>
                  <option value="92">End�stri</option>
                  <option value="94">Enerji</option>
                  <option value="95">ERP</option>
                  <option value="96">E-Ticaret</option>
                  <option value="97">Fabrika</option>
                  <option value="99">Finans</option>
                  <option value="444">Finans Kontrol�r�</option>
                  <option value="101">Finansal Analist</option>
                  <option value="428">Firma Orta��</option>
                  <option value="427">Firma Sahibi</option>
                  <option value="102">Fizik</option>
                  <option value="103">Fon</option>
                  <option value="106">Garson</option>
                  <option value="108">Gazeteci</option>
                  <option value="109">Genel M�d�r</option>
                  <option value="110">Genel Sat��</option>
                  <option value="111">Gerber Operat�r�</option>
                  <option value="112">G�da</option>
                  <option value="113">Gi�e</option>
                  <option value="115">G�rsel D�zenleme/Sunum/Tasar�m</option>
                  <option value="116">G�zetim</option>
                  <option value="117">Grafiker</option>
                  <option value="118">Grup</option>
                  <option value="120">Grup �r�n</option>
                  <option value="121">G�mr�k</option>
                  <option value="122">G�venlik</option>
                  <option value="123">Haber</option>
                  <option value="124">Haber Spikeri</option>
                  <option value="125">Haberle�me</option>
                  <option value="126">Halkla �li�kiler</option>
                  <option value="129">Harita</option>
                  <option value="130">Hasar</option>
                  <option value="131">Hasar Analisti</option>
                  <option value="132">Hastane</option>
                  <option value="133">Hayat Sigortas�</option>
                  <option value="134">Hazine</option>
                  <option value="135">Hem�ire</option>
                  <option value="139">Hukuk</option>
                  <option value="142">Internet Hizmetleri</option>
                  <option value="143">�cra</option>
                  <option value="144">�� Hizmetler</option>
                  <option value="145">�� Mimar</option>
                  <option value="146">�� Sat�nalma</option>
                  <option value="147">��erik</option>
                  <option value="148">�dari ��ler</option>
                  <option value="150">�hale</option>
                  <option value="151">�hracat</option>
                  <option value="153">�kmal </option>
                  <option value="155">�leti�im</option>
                  <option value="156">�malat</option>
                  <option value="157">�nsan Kaynaklar�</option>
                  <option value="159">�n�aat</option>
                  <option value="161">�plik Boyama </option>
                  <option value="162">�plik �retim</option>
                  <option value="163">�stasyon</option>
                  <option value="164">�statistik</option>
                  <option value="165">�� Geli�tirme</option>
                  <option value="166">��letme</option>
                  <option value="167">��yeri Hekimi</option>
                  <option value="168">�thalat</option>
                  <option value="169">�thalat/�hracat</option>
                  <option value="171">Jeoloji</option>
                  <option value="172">Kabin</option>
                  <option value="174">Kal�p</option>
                  <option value="175">Kal�p Tasar�m</option>
                  <option value="176">Kal�phane</option>
                  <option value="177">Kalibrasyon</option>
                  <option value="178">Kalite</option>
                  <option value="180">Kalite G�vence</option>
                  <option value="181">Kalite Kontrol</option>
                  <option value="182">Kambiyo</option>
                  <option value="183">Kameraman</option>
                  <option value="184">Kamu</option>
                  <option value="185">Kanal</option>
                  <option value="186">Kanal Geli�tirme</option>
                  <option value="187">Kanal Sat��</option>
                  <option value="188">Kargo</option>
                  <option value="189">Kart Sat�� Pazarlama</option>
                  <option value="190">Kasa </option>
                  <option value="191">Kasiyer</option>
                  <option value="192">Kategori</option>
                  <option value="486">Kaynak</option>
                  <option value="193">Kesim</option>
                  <option value="194">Kesimhane</option>
                  <option value="195">Kimya</option>
                  <option value="287">Klinik Ara�t�rma</option>
                  <option value="197">Konfeksiyon Planlama</option>
                  <option value="198">Kontrol</option>
                  <option value="201">Kredi Pazarlama</option>
                  <option value="202">Kredi Risk</option>
                  <option value="203">Kredi Tahsis</option>
                  <option value="204">Kuma�</option>
                  <option value="205">Kuma� Depo</option>
                  <option value="206">Kuma� �malat</option>
                  <option value="207">Kurs </option>
                  <option value="208">Kurs ��retmeni</option>
                  <option value="209">Kurumsal �leti�im </option>
                  <option value="210">Kurumsal M��teriler</option>
                  <option value="211">Kurumsal Pazarlama</option>
                  <option value="213">K�t�phane</option>
                  <option value="214">Laborant</option>
                  <option value="215">Laboratuvar</option>
                  <option value="216">Lectra Operat�r�</option>
                  <option value="218">Lojistik</option>
                  <option value="220">Maden</option>
                  <option value="222">Ma�aza</option>
                  <option value="223">Ma�aza Sat��</option>
                  <option value="225">Makina</option>
                  <option value="226">Makina Bak�m</option>
                  <option value="227">Mali Analist</option>
                  <option value="228">Mali Dan��man</option>
                  <option value="229">Mali Denet�i</option>
                  <option value="230">Mali ��ler</option>
                  <option value="231">Mali M��avir</option>
                  <option value="232">Mali Raporlama</option>
                  <option value="233">Maliyet Kontrol</option>
                  <option value="234">Maliyet Muhasebesi</option>
                  <option value="235">Malzeme</option>
                  <option value="236">Malzeme Planlama</option>
                  <option value="237">Marka</option>
                  <option value="238">Marka �leti�im</option>
                  <option value="240">Matematik</option>
                  <option value="241">Medikal </option>
                  <option value="242">Medya</option>
                  <option value="244">Mekanik</option>
                  <option value="245">Mekanik Bak�m</option>
                  <option value="247">Merchandiser</option>
                  <option value="248">Metalurji</option>
                  <option value="249">Meteoroloji</option>
                  <option value="250">Metod</option>
                  <option value="251">MIS</option>
                  <option value="252">Mimar</option>
                  <option value="253">Misafir ili�kileri</option>
                  <option value="255">Modelhane</option>
                  <option value="256">Modelist</option>
                  <option value="257">Montaj</option>
                  <option value="258">Muhaberat</option>
                  <option value="259">Muhasebe</option>
                  <option value="263">M�fetti�</option>
                  <option value="441">M��teri</option>
                  <option value="265">M��teri Hizmetleri</option>
                  <option value="266">M��teri Temsilcisi</option>
                  <option value="267">M�teaahit</option>
                  <option value="268">M�tercim Terc�man</option>
                  <option value="269">Nakliyat</option>
                  <option value="270">Nakliye �thalat</option>
                  <option value="271">Nakliye Pazarlama</option>
                  <option value="272">Network</option>
                  <option value="273">Numune </option>
                  <option value="274">N�kleer Fizik</option>
                  <option value="275">Ofis</option>
                  <option value="276">Operasyon</option>
                  <option value="278">Organizasyon</option>
                  <option value="279">Otel</option>
                  <option value="438">Oyuncu</option>
                  <option value="281">��retim G�revlisi</option>
                  <option value="282">��retmen</option>
                  <option value="283">�n B�ro</option>
                  <option value="284">�n Muhasebe</option>
                  <option value="285">�rme �malat</option>
                  <option value="286">�rme Takip</option>
                  <option value="288">Pazar Ara�t�rma</option>
                  <option value="289">Pazar Geli�tirme</option>
                  <option value="290">Pazarlama</option>
                  <option value="292">Perakende</option>
                  <option value="294">Personel</option>
                  <option value="297">Petrol</option>
                  <option value="299">Peyzaj Mimar�</option>
                  <option value="300">Planlama</option>
                  <option value="303">Portf�y</option>
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
                  <option value="315">Ruhsatland�rma</option>
                  <option value="316">Sa�l�k</option>
                  <option value="318">Saha</option>
                  <option value="319">Santral</option>
                  <option value="320">SAP</option>
                  <option value="321">Sat�nalma</option>
                  <option value="323">Sat��</option>
                  <option value="435">Sat�� Destek</option>
                  <option value="434">Sat�� Sonras� Hizmetler</option>
                  <option value="325">Sekreter</option>
                  <option value="326">Servis</option>
                  <option value="327">Sigorta</option>
                  <option value="329">Sistem</option>
                  <option value="330">Sistem Destek</option>
                  <option value="331">Sistem Geli�tirme</option>
                  <option value="332">Sistem G�venlik</option>
                  <option value="333">Sistem operasyon</option>
                  <option value="334">Solid �malat</option>
                  <option value="336">Sosyolog</option>
                  <option value="440">Sporcu</option>
                  <option value="337">Stajyer</option>
                  <option value="338">Stilist</option>
                  <option value="437">Stok Kontrol</option>
                  <option value="339">Strateji</option>
                  <option value="340">Stratejik Planlama</option>
                  <option value="341">�antiye</option>
                  <option value="344">�of�r</option>
                  <option value="345">�ube</option>
                  <option value="346">Tahsilat</option>
                  <option value="347">Tan�t�m</option>
                  <option value="348">Tasar�m</option>
                  <option value="350">Tedarik</option>
                  <option value="351">Teknik</option>
                  <option value="353">Teknik Destek</option>
                  <option value="354">Teknik Ressam</option>
                  <option value="426">Teknik Servis</option>
                  <option value="357">Tekstil</option>
                  <option value="359">Telefon </option>
                  <option value="360">Telekom�nikasyon</option>
                  <option value="362">Temizlik</option>
                  <option value="364">Terc�man</option>
                  <option value="365">Tezgahtar</option>
                  <option value="366">T�bbi M�messil</option>
                  <option value="367">T�p Doktoru</option>
                  <option value="368">T�r �of�r�</option>
                  <option value="369">Ticaret</option>
                  <option value="371">Toptan Sat��</option>
                  <option value="372">Tur </option>
                  <option value="373">Tur Rehberi</option>
                  <option value="377">Underwriter</option>
                  <option value="429">Ustaba��</option>
                  <option value="378">Uygulama</option>
                  <option value="381">�retim</option>
                  <option value="383">�retim Kontrol</option>
                  <option value="384">�retim Planlama</option>
                  <option value="385">�retim Vardiya</option>
                  <option value="387">�r�n</option>
                  <option value="430">�r�n Geli�tirme</option>
                  <option value="388">�r�n Pazarlama</option>
                  <option value="389">�r�n Tan�t�m</option>
                  <option value="391">Vardiya</option>
                  <option value="392">Vergi</option>
                  <option value="393">Veri Giri�</option>
                  <option value="394">Veritaban�</option>
                  <option value="395">Veteriner</option>
                  <option value="396">Veznedar</option>
                  <option value="397">Vitrin tasar�m</option>
                  <option value="398">Vize</option>
                  <option value="399">Web Programc�s�</option>
                  <option value="400">Web Tasar�mc�s�</option>
                  <option value="401">Yap�mc�</option>
                  <option value="402">Yat�r�m</option>
                  <option value="424">Yazar</option>
                  <option value="403">Yaz�l�m</option>
                  <option value="404">Yaz�l�m Destek</option>
                  <option value="405">Yaz�l�m Geli�tirme</option>
                  <option value="406">Yaz�l�m Tasar�m</option>
                  <option value="409">Y�kama Boyama</option>
                  <option value="410">Yiyecek/��ecek</option>
                  <option value="411">Y�netici Aday�</option>
                  <option value="412">Y�netici Asistan�</option>
                  <option value="413">Y�netici Sekreteri</option>
                  <option value="417">Y�netim Dan��man�</option>
                  <option value="425">Y�netim Kurulu</option>
                  <option value="418">Zincir Ma�azalar</option>
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
              <td align="right" valign="top"><p><strong>�ehir</strong></p></td>
              <td valign="top"><select name="pozisyon" id="pozisyon" multiple="multiple" style="width:230px;" size="5" title="Ctrl tu�una bas�l� tutarak en fazla 5 se�im yapabilirsiniz">
                  <option value="001">Adana</option>
                  <option value="085">Ad�yaman</option>
                  <option value="086">Afyon</option>
                  <option value="087">A�r�</option>
                  <option value="079">Aksaray</option>
                  <option value="089">Amasya</option>
                  <option value="002">Ankara</option>
                  <option value="003">Antalya</option>
                  <option value="090">Ardahan</option>
                  <option value="091">Artvin</option>
                  <option value="004">Ayd�n</option>
                  <option value="005">Bal�kesir</option>
                  <option value="092">Bart�n</option>
                  <option value="093">Batman</option>
                  <option value="094">Bayburt</option>
                  <option value="006">Bilecik</option>
                  <option value="095">Bing�l</option>
                  <option value="096">Bitlis</option>
                  <option value="007">Bolu</option>
                  <option value="097">Burdur</option>
                  <option value="008">Bursa</option>
                  <option value="009">�anakkale</option>
                  <option value="010">�ank�r�</option>
                  <option value="098">�orum</option>
                  <option value="011">Denizli</option>
                  <option value="012">Diyarbak�r</option>
                  <option value="126">D�zce</option>
                  <option value="013">Edirne</option>
                  <option value="099">Elaz��</option>
                  <option value="014">Erzincan</option>
                  <option value="015">Erzurum</option>
                  <option value="016">Eski�ehir</option>
                  <option value="017">Gaziantep</option>
                  <option value="100">Giresun</option>
                  <option value="101">G�m��hane</option>
                  <option value="102">Hakkari</option>
                  <option value="018">Hatay</option>
                  <option value="103">I�d�r</option>
                  <option value="019">Isparta</option>
                  <option value="021">�stanbul</option>
                  <option value="022">�zmir</option>
                  <option value="104">K.Mara�</option>
                  <option value="023">Karab�k</option>
                  <option value="105">Karaman</option>
                  <option value="106">Kars</option>
                  <option value="107">Kastamonu</option>
                  <option value="024">Kayseri</option>
                  <option value="080">K�r�kkale</option>
                  <option value="084">K�rklareli</option>
                  <option value="109">K�r�ehir</option>
                  <option value="110">Kilis</option>
                  <option value="026">Kocaeli</option>
                  <option value="190">Kocaeli-Gebze</option>
                  <option value="025">Konya</option>
                  <option value="081">K�tahya</option>
                  <option value="112">Malatya</option>
                  <option value="027">Manisa</option>
                  <option value="113">Mardin</option>
                  <option value="020">Mersin</option>
                  <option value="028">Mu�la</option>
                  <option value="114">Mu�</option>
                  <option value="029">Nev�ehir</option>
                  <option value="030">Ni�de</option>
                  <option value="115">Ordu</option>
                  <option value="116">Osmaniye</option>
                  <option value="031">Rize</option>
                  <option value="032">Sakarya</option>
                  <option value="033">Samsun</option>
                  <option value="117">Siirt</option>
                  <option value="118">Sinop</option>
                  <option value="119">Sivas</option>
                  <option value="120">�anl�urfa</option>
                  <option value="108">��rnak</option>
                  <option value="034">Tekirda�</option>
                  <option value="121">Tokat</option>
                  <option value="035">Trabzon</option>
                  <option value="122">Tunceli</option>
                  <option value="123">U�ak</option>
                  <option value="124">Van</option>
                  <option value="036">Yalova</option>
                  <option value="125">Yozgat</option>
                  <option value="037">Zonguldak</option>
              </select></td>
              <td align="right" valign="top"><p><strong>�irket</strong></p></td>
              <td valign="top">                <select name="select5" id="select2" multiple="multiple" style="width:230px;" size="5" title="Ctrl tu�una bas�l� tutarak en fazla 5 se�im yapabilirsiniz">
                  <option value="001">Adnano�ullar� Ltd.</option>
                  <option value="085">Ademcevahirler</option>
                  <option value="086">Arkas Nakliyat</option>
                  <option value="087">Aynen Donan�m</option>
                  <option value="079">Baytar Lustro Salonu</option>
                  <option value="089">Bereket D�ner</option>
                  <option>Celibir�irket</option>
                  </select>              </td>
            </tr>
            <tr>
              <td align="right" valign="top">&nbsp;</td>
              <td valign="top">&nbsp;</td>
              <td align="right" valign="top">&nbsp;</td>
              <td valign="top">&nbsp;</td>
            </tr>
            <tr>
              <td align="right" valign="top"><p><strong>E�itim<br />
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
                  &nbsp;Meslek Y�ksekokulu</p>
                <p>
                  <input type="checkbox" name="checkbox2222222" value="checkbox" />
                  &nbsp;Lise</p>
                <p>
                  <input type="checkbox" name="checkbox22222222" value="checkbox" />
              &nbsp;�lkokul</p></td>
              <td align="right" valign="top"><p><strong>Ya� aral���</strong></p></td>
              <td valign="top"><p>
                  <input type="checkbox" name="checkbox32222" value="checkbox" />
                  &nbsp;18-25 aras� </p>
                <p>
                  <input type="checkbox" name="checkbox4222" value="checkbox" />
                  &nbsp;25-31 aras� </p>
                <p>
                  <input type="checkbox" name="checkbox23222" value="checkbox" />
                  &nbsp;31-41 aras� </p>
                <p>
                  <input type="checkbox" name="checkbox32222" value="checkbox" />
                  &nbsp;41-51</p>
                <p>
                  <input type="checkbox" name="checkbox222222" value="checkbox" />
              &nbsp;51 ve �st�</p></td>
            </tr>
            <tr>
              <td align="right" valign="top">&nbsp;</td>
              <td valign="top">&nbsp;</td>
              <td align="right" valign="top">&nbsp;</td>
              <td valign="top">&nbsp;</td>
            </tr>
            <tr>
              <td align="right" valign="top"><p><strong>�al��ma tipi</strong></p></td>
              <td valign="top"><p>
                  <input type="checkbox" name="checkbox4" value="checkbox" />
                  S�rekli / Tam Zamanl�</p>
                <p>
                  <input type="checkbox" name="checkbox23" value="checkbox" />
                  D�nemsel / Proje Bazl�</p>
                <p>
                  <input type="checkbox" name="checkbox32" value="checkbox" />
                  Yar� Zamanl�</p>
                <p>
                  <input type="checkbox" name="checkbox222" value="checkbox" />
              Stajer</p></td>
              <td align="right" valign="top"><p><strong>�lan tarihi</strong></p></td>
              <td valign="top"><p>
                  <input name="checkbox322222" type="checkbox" value="checkbox" checked="checked" />
                  &nbsp;Son 15 g�n </p>
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
              <td align="right" valign="top"><p><strong>�lan t�r�</strong></p></td>
              <td valign="top"><p>
                  <input type="checkbox" name="checkbox3223" value="checkbox" />
                  &nbsp;Engelli</p>
                <p>
                  <input type="checkbox" name="checkbox22223" value="checkbox" />
                  &nbsp;�ehit Yak�n� / Ter�r Ma�duru</p>
                <p>
                  <input type="checkbox" name="checkbox3223" value="checkbox" />
              &nbsp;Eski H�k�ml�</p></td>
              <td align="right" valign="top">&nbsp;</td>
              <td valign="top"><p>&nbsp;</p></td>
            </tr>
          </table>
          <p>&nbsp;</p>
          <div class="HeaderPR floatLeft">
            <h2 class="sIFRHeader" style="width:200px;">�� Deneyimi</h2>
          </div>
		  <div class="hr"><hr /></div>
          <table width="100%" class="FormTable">
            <tr>
              <td width="85" align="right" valign="top"><p><strong>Sekt�r</strong></p></td>
              <td valign="top"><select name="select4" id="select6" multiple="multiple" style="width:230px;" size="5" title="Ctrl tu�una bas�l� tutarak en fazla 5 se�im yapabilirsiniz">
                  <option value="2">Ambalaj ve Ka��t</option>
                  <option value="64">Bankac�l�k / Finans</option>
                  <option value="3">Beyaz E�ya</option>
                  <option value="4">Bilgisayar / BT / Internet</option>
                  <option value="5">Cam ve Seramik</option>
                  <option value="6">Da��t�m</option>
                  <option value="7">Dan��manl�k</option>
                  <option value="8">Dayan�kl� T�ketim Mallar�</option>
                  <option value="9">Demir-�elik</option>
                  <option value="10">Denizcilik</option>
                  <option value="11">Deri</option>
                  <option value="12">Dernek ve Vak�f</option>
                  <option value="13">D�� Ticaret</option>
                  <option value="14">E�itim</option>
                  <option value="15">E�lence</option>
                  <option value="16">End�stri</option>
                  <option value="1">Elektrik ve Elektronik</option>
                  <option value="17">Faktoring</option>
                  <option value="18">Gayrimenkul</option>
                  <option value="19">G�da</option>
                  <option value="20">Halkla �li�kiler</option>
                  <option value="21">Havac�l�k</option>
                  <option value="63">H�zl� T�ketim Mallar�</option>
                  <option value="22">Hayvanc�l�k</option>
                  <option value="23">Hizmet / ��letme Servisi</option>
                  <option value="24">Holding</option>
                  <option value="25">Hukuk</option>
                  <option value="26">�la�</option>
                  <option value="27">�malat</option>
                  <option value="28">�n�aat</option>
                  <option value="29">�thalat/�hracat</option>
                  <option value="30">Kamu</option>
                  <option value="31">Kimya</option>
                  <option value="32">Kozmetik</option>
                  <option value="33">Leasing</option>
                  <option value="40">Lojistik</option>
                  <option value="34">Madencilik</option>
                  <option value="35">Ma�azac�l�k / Perakendecilik</option>
                  <option value="36">Mali Denetim-Vergi</option>
                  <option value="37">Mali M��avirlik</option>
                  <option value="38">Medya</option>
                  <option value="39">Mimarl�k</option>
                  <option value="41">Otelcilik</option>
                  <option value="42">Otomotiv</option>
                  <option value="43">Petrol ve Petrol �r�nleri</option>
                  <option value="44">Reklamc�l�k</option>
                  <option value="45">Restoranc�l�k</option>
                  <option value="46">Sa�l�k/Hastane</option>
                  <option value="47">Sanat</option>
                  <option value="48">Savunma/G�venlik</option>
                  <option value="49">Sigortac�l�k</option>
                  <option value="50">Sosyal Servisler</option>
                  <option value="51">Tar�m ve Orman �r�nleri</option>
                  <option value="52">Tekstil</option>
                  <option value="53">Telekom�nikasyon ve Network</option>
                  <option value="54">T�bbi Malzeme</option>
                  <option value="55">Toptanc�l�k</option>
                  <option value="56">Turizm</option>
                  <option value="57">Ula��m</option>
                  <option value="58">Yap� Malzemeleri</option>
                  <option value="59">Yat�r�m / Menkul De�erler</option>
                  <option value="62">Yat�r�m /Menkul D. /Borsac�l�k</option>
                  <option value="60">Yay�nc�l�k</option>
                  <option value="61">Di�er</option>
              </select></td>
              <td align="right" valign="top"><p><strong>Pozisyon</strong></p></td>
              <td valign="top"><select name="select4" id="select5" multiple="multiple" style="width:230px;" size="5" title="Ctrl tu�una bas�l� tutarak en fazla 5 se�im yapabilirsiniz">
                  <option value="2">Acente</option>
                  <option value="3">A��r Vas�ta �of�r�</option>
                  <option value="4">Ah��/A���</option>
                  <option value="5">Akademisyen</option>
                  <option value="6">Akaryak�t �stasyon</option>
                  <option value="7">Aktif Pazarlama</option>
                  <option value="8">Aktif Sat��</option>
                  <option value="9">Aktivasyon</option>
                  <option value="10">Ambar</option>
                  <option value="12">Analist</option>
                  <option value="13">Analist Programc�</option>
                  <option value="15">Analiz</option>
                  <option value="16">Animat�r</option>
                  <option value="431">Anket�r</option>
                  <option value="433">Antren�r</option>
                  <option value="17">Antrepo</option>
                  <option value="18">Apre</option>
                  <option value="19">Ara�t�rma</option>
                  <option value="20">Ara�t�rma Geli�tirme</option>
                  <option value="423">Avukat</option>
                  <option value="22">Bak�m</option>
                  <option value="23">Bak�m Onar�m</option>
                  <option value="24">Banka</option>
                  <option value="25">Banka �hracat/�thalat</option>
                  <option value="26">Banka Kredi Pazarlama</option>
                  <option value="27">Banka Operasyon</option>
                  <option value="29">Bar</option>
                  <option value="30">Bas�n</option>
                  <option value="31">Bas�n ve Halkla �li�kiler</option>
                  <option value="32">Bask�</option>
                  <option value="33">Bask� Nak��</option>
                  <option value="34">Ba�hekim</option>
                  <option value="35">Ba�hem�ire</option>
                  <option value="36">Bayi Kanal�</option>
                  <option value="37">Bilgi Giri�</option>
                  <option value="39">Bilgi ��lem</option>
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
                  <option value="52">B�lge</option>
                  <option value="53">B�lge Sat��</option>
                  <option value="54">B�t�e</option>
                  <option value="55">B�t�e Raporlama</option>
                  <option value="56">B�y�k M��teriler</option>
                  <option value="57">Cad/Cam</option>
                  <option value="439">CNC</option>
                  <option value="58">�a�r� Merkezi</option>
                  <option value="59">�evirmen</option>
                  <option value="60">�evre</option>
                  <option value="61">Da��t�m</option>
                  <option value="65">Denet�i</option>
                  <option value="66">Denetim/Denetleme</option>
                  <option value="67">Deniz Bilimleri</option>
                  <option value="68">Depo</option>
                  <option value="69">Destek</option>
                  <option value="70">D�� �li�kiler</option>
                  <option value="71">D�� pazarlama</option>
                  <option value="72">D�� Sat�nalma</option>
                  <option value="73">D�� Ticaret</option>
                  <option value="76">Diyetisyen</option>
                  <option value="77">Doktor</option>
                  <option value="78">Dokuma</option>
                  <option value="79">Dok�mantasyon</option>
                  <option value="80">Donan�m</option>
                  <option value="81">Eczac�</option>
                  <option value="82">Edit�r</option>
                  <option value="84">E�itim</option>
                  <option value="86">Elektrik</option>
                  <option value="88">Elektrik/Elektronik</option>
                  <option value="89">Elektronik</option>
                  <option value="91">Emlak</option>
                  <option value="92">End�stri</option>
                  <option value="94">Enerji</option>
                  <option value="95">ERP</option>
                  <option value="96">E-Ticaret</option>
                  <option value="97">Fabrika</option>
                  <option value="99">Finans</option>
                  <option value="444">Finans Kontrol�r�</option>
                  <option value="101">Finansal Analist</option>
                  <option value="428">Firma Orta��</option>
                  <option value="427">Firma Sahibi</option>
                  <option value="102">Fizik</option>
                  <option value="103">Fon</option>
                  <option value="106">Garson</option>
                  <option value="108">Gazeteci</option>
                  <option value="109">Genel M�d�r</option>
                  <option value="110">Genel Sat��</option>
                  <option value="111">Gerber Operat�r�</option>
                  <option value="112">G�da</option>
                  <option value="113">Gi�e</option>
                  <option value="115">G�rsel D�zenleme/Sunum/Tasar�m</option>
                  <option value="116">G�zetim</option>
                  <option value="117">Grafiker</option>
                  <option value="118">Grup</option>
                  <option value="120">Grup �r�n</option>
                  <option value="121">G�mr�k</option>
                  <option value="122">G�venlik</option>
                  <option value="123">Haber</option>
                  <option value="124">Haber Spikeri</option>
                  <option value="125">Haberle�me</option>
                  <option value="126">Halkla �li�kiler</option>
                  <option value="129">Harita</option>
                  <option value="130">Hasar</option>
                  <option value="131">Hasar Analisti</option>
                  <option value="132">Hastane</option>
                  <option value="133">Hayat Sigortas�</option>
                  <option value="134">Hazine</option>
                  <option value="135">Hem�ire</option>
                  <option value="139">Hukuk</option>
                  <option value="142">Internet Hizmetleri</option>
                  <option value="143">�cra</option>
                  <option value="144">�� Hizmetler</option>
                  <option value="145">�� Mimar</option>
                  <option value="146">�� Sat�nalma</option>
                  <option value="147">��erik</option>
                  <option value="148">�dari ��ler</option>
                  <option value="150">�hale</option>
                  <option value="151">�hracat</option>
                  <option value="153">�kmal </option>
                  <option value="155">�leti�im</option>
                  <option value="156">�malat</option>
                  <option value="157">�nsan Kaynaklar�</option>
                  <option value="159">�n�aat</option>
                  <option value="161">�plik Boyama </option>
                  <option value="162">�plik �retim</option>
                  <option value="163">�stasyon</option>
                  <option value="164">�statistik</option>
                  <option value="165">�� Geli�tirme</option>
                  <option value="166">��letme</option>
                  <option value="167">��yeri Hekimi</option>
                  <option value="168">�thalat</option>
                  <option value="169">�thalat/�hracat</option>
                  <option value="171">Jeoloji</option>
                  <option value="172">Kabin</option>
                  <option value="174">Kal�p</option>
                  <option value="175">Kal�p Tasar�m</option>
                  <option value="176">Kal�phane</option>
                  <option value="177">Kalibrasyon</option>
                  <option value="178">Kalite</option>
                  <option value="180">Kalite G�vence</option>
                  <option value="181">Kalite Kontrol</option>
                  <option value="182">Kambiyo</option>
                  <option value="183">Kameraman</option>
                  <option value="184">Kamu</option>
                  <option value="185">Kanal</option>
                  <option value="186">Kanal Geli�tirme</option>
                  <option value="187">Kanal Sat��</option>
                  <option value="188">Kargo</option>
                  <option value="189">Kart Sat�� Pazarlama</option>
                  <option value="190">Kasa </option>
                  <option value="191">Kasiyer</option>
                  <option value="192">Kategori</option>
                  <option value="486">Kaynak</option>
                  <option value="193">Kesim</option>
                  <option value="194">Kesimhane</option>
                  <option value="195">Kimya</option>
                  <option value="287">Klinik Ara�t�rma</option>
                  <option value="197">Konfeksiyon Planlama</option>
                  <option value="198">Kontrol</option>
                  <option value="201">Kredi Pazarlama</option>
                  <option value="202">Kredi Risk</option>
                  <option value="203">Kredi Tahsis</option>
                  <option value="204">Kuma�</option>
                  <option value="205">Kuma� Depo</option>
                  <option value="206">Kuma� �malat</option>
                  <option value="207">Kurs </option>
                  <option value="208">Kurs ��retmeni</option>
                  <option value="209">Kurumsal �leti�im </option>
                  <option value="210">Kurumsal M��teriler</option>
                  <option value="211">Kurumsal Pazarlama</option>
                  <option value="213">K�t�phane</option>
                  <option value="214">Laborant</option>
                  <option value="215">Laboratuvar</option>
                  <option value="216">Lectra Operat�r�</option>
                  <option value="218">Lojistik</option>
                  <option value="220">Maden</option>
                  <option value="222">Ma�aza</option>
                  <option value="223">Ma�aza Sat��</option>
                  <option value="225">Makina</option>
                  <option value="226">Makina Bak�m</option>
                  <option value="227">Mali Analist</option>
                  <option value="228">Mali Dan��man</option>
                  <option value="229">Mali Denet�i</option>
                  <option value="230">Mali ��ler</option>
                  <option value="231">Mali M��avir</option>
                  <option value="232">Mali Raporlama</option>
                  <option value="233">Maliyet Kontrol</option>
                  <option value="234">Maliyet Muhasebesi</option>
                  <option value="235">Malzeme</option>
                  <option value="236">Malzeme Planlama</option>
                  <option value="237">Marka</option>
                  <option value="238">Marka �leti�im</option>
                  <option value="240">Matematik</option>
                  <option value="241">Medikal </option>
                  <option value="242">Medya</option>
                  <option value="244">Mekanik</option>
                  <option value="245">Mekanik Bak�m</option>
                  <option value="247">Merchandiser</option>
                  <option value="248">Metalurji</option>
                  <option value="249">Meteoroloji</option>
                  <option value="250">Metod</option>
                  <option value="251">MIS</option>
                  <option value="252">Mimar</option>
                  <option value="253">Misafir ili�kileri</option>
                  <option value="255">Modelhane</option>
                  <option value="256">Modelist</option>
                  <option value="257">Montaj</option>
                  <option value="258">Muhaberat</option>
                  <option value="259">Muhasebe</option>
                  <option value="263">M�fetti�</option>
                  <option value="441">M��teri</option>
                  <option value="265">M��teri Hizmetleri</option>
                  <option value="266">M��teri Temsilcisi</option>
                  <option value="267">M�teaahit</option>
                  <option value="268">M�tercim Terc�man</option>
                  <option value="269">Nakliyat</option>
                  <option value="270">Nakliye �thalat</option>
                  <option value="271">Nakliye Pazarlama</option>
                  <option value="272">Network</option>
                  <option value="273">Numune </option>
                  <option value="274">N�kleer Fizik</option>
                  <option value="275">Ofis</option>
                  <option value="276">Operasyon</option>
                  <option value="278">Organizasyon</option>
                  <option value="279">Otel</option>
                  <option value="438">Oyuncu</option>
                  <option value="281">��retim G�revlisi</option>
                  <option value="282">��retmen</option>
                  <option value="283">�n B�ro</option>
                  <option value="284">�n Muhasebe</option>
                  <option value="285">�rme �malat</option>
                  <option value="286">�rme Takip</option>
                  <option value="288">Pazar Ara�t�rma</option>
                  <option value="289">Pazar Geli�tirme</option>
                  <option value="290">Pazarlama</option>
                  <option value="292">Perakende</option>
                  <option value="294">Personel</option>
                  <option value="297">Petrol</option>
                  <option value="299">Peyzaj Mimar�</option>
                  <option value="300">Planlama</option>
                  <option value="303">Portf�y</option>
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
                  <option value="315">Ruhsatland�rma</option>
                  <option value="316">Sa�l�k</option>
                  <option value="318">Saha</option>
                  <option value="319">Santral</option>
                  <option value="320">SAP</option>
                  <option value="321">Sat�nalma</option>
                  <option value="323">Sat��</option>
                  <option value="435">Sat�� Destek</option>
                  <option value="434">Sat�� Sonras� Hizmetler</option>
                  <option value="325">Sekreter</option>
                  <option value="326">Servis</option>
                  <option value="327">Sigorta</option>
                  <option value="329">Sistem</option>
                  <option value="330">Sistem Destek</option>
                  <option value="331">Sistem Geli�tirme</option>
                  <option value="332">Sistem G�venlik</option>
                  <option value="333">Sistem operasyon</option>
                  <option value="334">Solid �malat</option>
                  <option value="336">Sosyolog</option>
                  <option value="440">Sporcu</option>
                  <option value="337">Stajyer</option>
                  <option value="338">Stilist</option>
                  <option value="437">Stok Kontrol</option>
                  <option value="339">Strateji</option>
                  <option value="340">Stratejik Planlama</option>
                  <option value="341">�antiye</option>
                  <option value="344">�of�r</option>
                  <option value="345">�ube</option>
                  <option value="346">Tahsilat</option>
                  <option value="347">Tan�t�m</option>
                  <option value="348">Tasar�m</option>
                  <option value="350">Tedarik</option>
                  <option value="351">Teknik</option>
                  <option value="353">Teknik Destek</option>
                  <option value="354">Teknik Ressam</option>
                  <option value="426">Teknik Servis</option>
                  <option value="357">Tekstil</option>
                  <option value="359">Telefon </option>
                  <option value="360">Telekom�nikasyon</option>
                  <option value="362">Temizlik</option>
                  <option value="364">Terc�man</option>
                  <option value="365">Tezgahtar</option>
                  <option value="366">T�bbi M�messil</option>
                  <option value="367">T�p Doktoru</option>
                  <option value="368">T�r �of�r�</option>
                  <option value="369">Ticaret</option>
                  <option value="371">Toptan Sat��</option>
                  <option value="372">Tur </option>
                  <option value="373">Tur Rehberi</option>
                  <option value="377">Underwriter</option>
                  <option value="429">Ustaba��</option>
                  <option value="378">Uygulama</option>
                  <option value="381">�retim</option>
                  <option value="383">�retim Kontrol</option>
                  <option value="384">�retim Planlama</option>
                  <option value="385">�retim Vardiya</option>
                  <option value="387">�r�n</option>
                  <option value="430">�r�n Geli�tirme</option>
                  <option value="388">�r�n Pazarlama</option>
                  <option value="389">�r�n Tan�t�m</option>
                  <option value="391">Vardiya</option>
                  <option value="392">Vergi</option>
                  <option value="393">Veri Giri�</option>
                  <option value="394">Veritaban�</option>
                  <option value="395">Veteriner</option>
                  <option value="396">Veznedar</option>
                  <option value="397">Vitrin tasar�m</option>
                  <option value="398">Vize</option>
                  <option value="399">Web Programc�s�</option>
                  <option value="400">Web Tasar�mc�s�</option>
                  <option value="401">Yap�mc�</option>
                  <option value="402">Yat�r�m</option>
                  <option value="424">Yazar</option>
                  <option value="403">Yaz�l�m</option>
                  <option value="404">Yaz�l�m Destek</option>
                  <option value="405">Yaz�l�m Geli�tirme</option>
                  <option value="406">Yaz�l�m Tasar�m</option>
                  <option value="409">Y�kama Boyama</option>
                  <option value="410">Yiyecek/��ecek</option>
                  <option value="411">Y�netici Aday�</option>
                  <option value="412">Y�netici Asistan�</option>
                  <option value="413">Y�netici Sekreteri</option>
                  <option value="417">Y�netim Dan��man�</option>
                  <option value="425">Y�netim Kurulu</option>
                  <option value="418">Zincir Ma�azalar</option>
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
                  T�m ilanlarda aray�n</p>
                <p>
                  <input name="radiobutton" type="radio" value="radiobutton" />
                  Size uygun ilanlarda aray�n</p></td>
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