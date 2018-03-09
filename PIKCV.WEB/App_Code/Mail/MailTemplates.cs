using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Net.Mail;
using CARETTA.COM;

public class MailTemplates
{
    public struct MailContent {
        public string From;
        public string Subject;
        public string Body;
        public string To;
    }

    #region Contents

    public static MailContent Activation {
        get {
            MailContent m_Activation = new MailContent ();
            m_Activation.From = ConfigurationSettings.AppSettings["MailFrom"].ToString();
            m_Activation.Subject = "PIKCV - �yelik Aktivasyon";
            m_Activation.Body = "Say�n ||FirstName|| ||LastName|| <br><br>" +
                                "P�Kcv.com �yelik i�lemlerinizi tamamlamak i�in a�a��daki linke t�klayarak �zge�mi� bilgilerinizi" +
                                " ve testinizi doldurunuz. �yeli�inizin aktif olabilmesi i�in �zge�mi� bilgilerinizi tamamlad�kdan" +
                                " sonra sitemizde yer alan testi mutlaka alman�z gerekmektedir.<br><br>" +
                                "<a href='" + Util.ApplicationRootPath() + "Pikcv.aspx?Pik=Employee-Activation-Activation&AN=||ACTIVATIONCODE||&U=||USERID||'>�yeli�inizin aktif olmas� i�in l�tfen t�klay�n�z.</a>" +
           //m_Activation.Body = "<a href='http://www.pikcv.com/Pikcv.aspx?Pik=Employee-Activation-Activation&AN=||ACTIVATIONCODE||&U=||USERID||'>�yeli�inizin aktif olmas� i�in l�tfen t�klay�n�z.</a>";
           //m_Activation.Body = "<a href='http://demo.caretta.net/pikcv/Pikcv.aspx?Pik=Employee-Activation-Activation&AN=||ACTIVATIONCODE||&U=||USERID||'>�yeli�inizin aktif olmas� i�in l�tfen t�klay�n�z.</a>";
                                "<br><br>P�Kcv.com�u tercih etti�iniz i�in te�ekk�r ederiz.";

            return m_Activation; 
        }
    }

    public static MailContent ActivationCompany
    {
        get
        {
            MailContent m_Activation = new MailContent();
            m_Activation.From = ConfigurationSettings.AppSettings["MailFrom"].ToString();
            m_Activation.Subject = "PIKCV - Firme �yelik E-posta Onay�";
            m_Activation.Body = "Say�n ||FirstName|| ||LastName|| <br><br>" +
                                "P�Kcv.com �yelik i�lemlerinizi tamamlamak i�in a�a��daki linke t�klayarak �yelik e-posta do�rulamas�n� yap�n�z. <br>" +
                                "Bu do�rulama sonras�nda sitemize y�nlendirileceksiniz. Pikcv.com �yeli�inizin onaylanmas� i�in sitemizde yer alan dan��manl�k s�zle�mesini yazd�r�p, gerekli yerlerini doldurunuz ve P�K Dan��manl�k��n a�a��da belirtilen adresine g�nderiniz. <br><br>" +
                                "<a href='" + Util.ApplicationRootPath() + "Pikcv.aspx?Pik=Company-Activation-Activation&AN=||ACTIVATIONCODE||&C=||COMPANYID||'>�yelik eposta do�rulamas� i�in l�tfen t�klay�n�z.</a>" +
                                "<br><br>PIKcv.com�u tercih etti�iniz i�in te�ekk�r ederiz.";

            return m_Activation;
        }
    }

    public static MailContent WelcomeMessage {
        get { 
            MailContent m_Activation = new MailContent ();
            m_Activation.From = ConfigurationSettings.AppSettings["MailFrom"].ToString();
            m_Activation.Subject = "PIKCV - Ho�geldiniz";
            m_Activation.Body = "Say�n ||FirstName|| ||LastName|| <br><br>" +
                                "P�Kcv.com�a ho� geldiniz ;<br><br>Sitemizi kolayca kullarak size �zel bilgilere en k�sa zamanda" +
                                "ula�abilirsiniz. <br>�zge�mi�iniz i�e al�m dan��manl���n� yapt���m�z t�m  �irketler i�in" +
                                "taraf�m�zca de�erlendirilir ve uygun g�r�lenler ilgili �irketlere �nerilir." +
                                "<br>Veritaban�m�zda yer alan �zge�mi�iniz sitemize �ye olan t�m i�verenler taraf�ndan incelenir." +
                                "�zge�mi�inizle sizin i�in uygun olan ilanlara ba�vurabilirsiniz." +
                                "<br><br>Bizi tercih etti�iniz i�in te�ekk�r ederiz.";
            return m_Activation;
        }
    }

    public static MailContent ForgotPassword {
        get {
            MailContent m_ForgotPassword = new MailContent ();
            m_ForgotPassword.From = ConfigurationSettings.AppSettings["MailFrom"].ToString();
            m_ForgotPassword.Subject = "PIKCV - �ifre Hat�rlatma";
            m_ForgotPassword.Body = "Say�n ||FirstName|| ||LastName||, <br><br>Bu e-posta PIKcv.com �zerinden �ifremi unuttum" + 
                                    " linkine t�klayarak yapm�� oldu�unuz istek �zerine, sistem taraf�ndan otomatik olarak" +
                                    " g�nderilmi�tir. A�a��da �ifreniz yer almaktad�r. <br><br>�ifre: ||PASSWORD|| <br><br>" +
                                    "Sayg�lar�m�zla," + 
                                    "<br><br> <a href='http://www.pikcv.com.tr' target='_blank' style='color:#006699'>pikcv.com</a>";
            return m_ForgotPassword; 
        }
    }

    public static MailContent ForgotPasswordCompany
    {
        get
        {
            MailContent m_ForgotPasswordCompany = new MailContent();
            m_ForgotPasswordCompany.From = ConfigurationSettings.AppSettings["MailFrom"].ToString();
            m_ForgotPasswordCompany.Subject = "PIKCV - �irket �ifre Hat�rlatma";
            m_ForgotPasswordCompany.Body = "Say�n ||FirstName|| ||LastName|| <br><br>Bu e-posta PIKcv.com �zerinden �ifremi unuttum" +
                                    " linkine t�klayarak yapm�� oldu�unuz istek �zerine, sistem taraf�ndan otomatik olarak" +
                                    " g�nderilmi�tir. A�a��da �ifreniz yer almaktad�r <br><br>�ifre: ||PASSWORD|| <br><br>" +
                                    "Sayg�lar�m�zla,";
            return m_ForgotPasswordCompany;
        }
    }

    public static MailContent TemporaryUser
    {
        get
        {
            MailContent m_TemporaryUser = new MailContent();
            m_TemporaryUser.From = ConfigurationSettings.AppSettings["MailFrom"].ToString();
            m_TemporaryUser.Subject = "PIKCV - Klas�r Payla��m�";
            m_TemporaryUser.Body = "Size g�nderilen klas�r i�indeki adaylar�n �zge�mi� bilgilerine a�a��daki linke t�klayarak eri�ebilirsiniz.<br>" +
                                    "Sitemize giri�inizi a�a��da size iletilen kullan�c� ad� ve �ifresini kullanarak yapman�z gerekmektedir.<br>" +
                                    "Size iletilen kullan�c� ad� ve �ifresi 5 g�n s�re ile ge�erli olacakt�r.<br><br>" +
                                    "Klas�r i�inde uygun buldu�unuz adaylar� ileti�im bilgisi sat�nalma istekleri klas�r�ne g�nderebilirsiniz." +
                                    "Bu adaylar�n ileti�im bilgileri sadece firman�z ad�na sitemizi kullanmaya yetkili ki�i taraf�ndan sat�n al�nabilir.<br><br>" +
                                    "Kullan�c� Ad�n�z: <b>||USERNAME||</b><br>" +
                                    "�ifreniz: <b>||PASSWORD||</b><br><br>" +
                                    " <a href='" + Util.ApplicationRootPath() + "TemporaryUserLogin.aspx'>Size iletilen klas�re eri�ebilmek i�in t�klay�n�z</a>" +
                                    "<br><br>Sayg�lar�m�zla," +
                                    "<br><br>G�nderenin �zel Notu: ||NOTES||";
            return m_TemporaryUser;
        }
    }

    public static MailContent SendFriendToJob
    {
        get
        {
            MailContent m_FriendMail;
            m_FriendMail.From = ConfigurationSettings.AppSettings["MailFrom"].ToString();
            m_FriendMail.To = "||TO||";
            m_FriendMail.Subject = "PIKCV �� �lan� - ||SUBJECT||";
            m_FriendMail.Body = "A�a��daki linke t�klayarak sitemizde yer alan ilan detay�na ula�abilirsiniz. <br /><br> <a target='_blank' href='" + Util.ApplicationRootPath() + "Pikcv.aspx?Pik=Employee-Jobs-JobDetail&JobID=||JOBID||'>Pikcv i� ilan� i�in t�klay�n�z.</a>";
            return m_FriendMail;
        }
    }

    #endregion

    #region Codes

    public static bool Send_SimpleHtml (MailContent MailContent, string To, string Bcc, string CC, MailPriority Priority) {
        CARETTA.COM.Mailing objMail = new CARETTA.COM.Mailing();
        return objMail.Send_SimpleHtml(MailContent.From, To, MailContent.Subject, MailContent.Body, Bcc, CC, Priority, ConfigurationSettings.AppSettings["MailFrom"].ToString(), ConfigurationSettings.AppSettings["MailFromPassword"].ToString());
    }

    public static bool Send_Tmp_Activation (MailContent MailContent, string ActivationCode, int UserID, string FirstName, string LastName, string To) { 
        MailContent.Body = MailContent.Body.Replace("||ACTIVATIONCODE||", ActivationCode);
        MailContent.Body = MailContent.Body.Replace("||USERID||", UserID.ToString());
        MailContent.Body = MailContent.Body.Replace("||FirstName||", FirstName.ToString());
        MailContent.Body = MailContent.Body.Replace("||LastName||", LastName.ToString());
        MailContent.Body = GetSubjectMaster(MailContent.Body);
        return Send_SimpleHtml(MailContent, To, "", "", MailPriority.High);
    }

    public static bool Send_Tmp_ActivationCompany(MailContent MailContent, string ActivationCode, int CompanyID, string FirstName, string LastName, string To)
    {
        MailContent.Body = MailContent.Body.Replace("||ACTIVATIONCODE||", ActivationCode);
        MailContent.Body = MailContent.Body.Replace("||COMPANYID||", CompanyID.ToString());
        MailContent.Body = MailContent.Body.Replace("||FirstName||", FirstName);
        MailContent.Body = MailContent.Body.Replace("||LastName||", LastName);
        MailContent.Body = GetSubjectMaster(MailContent.Body);
        return Send_SimpleHtml(MailContent, To, "", "", MailPriority.High);
    }

    public static bool Send_Tmp_WelcomeMessage(MailContent MailContent, string FirstName, string LastName, string To)
    {
        MailContent.Body = MailContent.Body.Replace("||FirstName||", FirstName.ToString());
        MailContent.Body = MailContent.Body.Replace("||LastName||", LastName.ToString());
        MailContent.Body = GetSubjectMaster(MailContent.Body);
        return Send_SimpleHtml(MailContent, To, "", "", MailPriority.High);
    }

    public static bool Send_Tmp_ForgotPass(MailContent MailContent, string Password, string FirstName, string LastName, string To)
    {
        MailContent.Body = MailContent.Body.Replace("||PASSWORD||", Password);
        MailContent.Body = MailContent.Body.Replace("||FirstName||", FirstName);
        MailContent.Body = MailContent.Body.Replace("||LastName||", LastName);
        MailContent.Body = GetSubjectMaster(MailContent.Body);
        return Send_SimpleHtml(MailContent, To, "", "", MailPriority.High);
    }

    public static bool Send_Tmp_ForgotPassCompany(MailContent MailContent, string Password, string FirstName, string LastName, string To)
    {
        MailContent.Body = MailContent.Body.Replace("||PASSWORD||", Password);
        MailContent.Body = MailContent.Body.Replace("||FirstName||", FirstName);
        MailContent.Body = MailContent.Body.Replace("||LastName||", LastName);
        MailContent.Body = GetSubjectMaster(MailContent.Body);
        return Send_SimpleHtml(MailContent, To, "", "", MailPriority.High);
    }


    public static bool Send_FriendMail(MailContent MailContent, string To, string Subject, string Message)
    {
        MailContent.To  = MailContent.To.Replace("||TO||", To);
        MailContent.Subject  = MailContent.Subject.Replace("||SUBJECT||", Subject);
        MailContent.Body = GetSubjectMaster(Message);
        return Send_SimpleHtml(MailContent, To, "", "", MailPriority.High);
    }

    public static bool Send_Tmp_TemporaryUser(MailContent MailContent, string UserName, string Password, string Notes, string To)
    {
        MailContent.Body = MailContent.Body.Replace("||USERNAME||", UserName);
        MailContent.Body = MailContent.Body.Replace("||PASSWORD||", Password);
        MailContent.Body = MailContent.Body.Replace("||NOTES||", Notes);
        MailContent.Body = GetSubjectMaster(MailContent.Body);
        return Send_SimpleHtml(MailContent, To, "", "", MailPriority.High);
    }

    private static string GetSubjectMaster(string Message)
    {
        return "<table style='width:700px;' border='0' align='center' cellpadding='0' cellspacing='0'>" +
               "<tr><td>&nbsp;</td></tr><tr><td><img src='" + Util.ApplicationRootPath() + "Images/misc/pikcv_popup_logo.png' width='230' height='70' /></td></tr>" +
               "<tr><td style='padding:15px;font-family:Verdana, Arial, Helvetica, sans-serif;font-size:8pt;line-height:12pt;'><p>" +
               Message +
               "</p></td></tr><tr><td bgcolor='#CCCCCC'></td>" +
               "</tr><tr><td><table border='0' cellspacing='15' cellpadding='0'><tr>" +
               "<td style='font-family: Verdana, Arial Helvetica, sans-serif; font-size:8pt; line-height: 140%; color: #666'>Perakende �nsan Kaynaklar� LTD.�T�<br />" +
               "B�y�kdere cad. Meydan sok.<br />Spring Giz Plaza Kat.13<br />Maslak-�i�li �STANBUL</td>" +
               "<td width='1' bgcolor='#CCCCCC'></td>" +
               "<td valign='top' style='font-family: Verdana, Arial Helvetica, sans-serif; font-size:8pt; line-height: 140%; color: #666'>Tel: +90 0212 329 79 32 (Pbx)<br />" +
               "Faks: +90 0212 329 79 32<br />E-posta: <a href='web@pikcv.com' style='color:#006699'>bilgi@pikcv.com</a><br />" +
               "Web sitesi: <a href='http://www.pikcv.com.tr' target='_blank' style='color:#006699'>www.pikcv.com</a></td>" +
               "</tr></table></td></tr><tr><td bgcolor='#CCCCCC'></td>" +
               "</tr><tr><td style='padding:15px;font-family:Verdana, Arial, Helvetica, sans-serif;font-size:7pt;color:#999;'>Bu elektronik posta ve onunla iletilen b�t�n dosyalar sadece g�ndericisi taraf�ndan almas� ama�lanan yetkili ger�ek ya da t�zel ki�inin kullan�m� i�indir. E�er s�z konusu yetkili al�c� de�ilseniz bu elektronik postan�n i�erigini a��klaman�z, kopyalaman�z, y�nlendirmeniz ve kullanman�z kesinlikle yasakt�r ve bu elektronik postay� derhal silmeniz gerekmektedir. PikCV, bu mesaj�n i�erdigi bilgilerin do�rulu�u veya eksiksiz oldu�u konusunda herhangi bir garanti vermemektedir. Bu nedenle bu bilgilerin ne �ekilde olursa olsun i�eriginden, iletilmesinden, al�nmas�ndan ve saklanmas�ndan, vir�s i�ermesinden ve bilgisayar sisteminize verebilece�i herhangi bir zarardan sorumlu tutulamaz. Bu mesajdaki g�r��ler yaln�zca g�nderen ki�iye aittir ve PikCV'un g�r��lerini yans�tmayabilir.</td>" +
               "</tr><tr><td>&nbsp;</td></tr></table>";
    }

    #endregion

}