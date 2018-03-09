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
            m_Activation.Subject = "PIKCV - Üyelik Aktivasyon";
            m_Activation.Body = "Sayýn ||FirstName|| ||LastName|| <br><br>" +
                                "PÝKcv.com üyelik iþlemlerinizi tamamlamak için aþaðýdaki linke týklayarak özgeçmiþ bilgilerinizi" +
                                " ve testinizi doldurunuz. Üyeliðinizin aktif olabilmesi için özgeçmiþ bilgilerinizi tamamladýkdan" +
                                " sonra sitemizde yer alan testi mutlaka almanýz gerekmektedir.<br><br>" +
                                "<a href='" + Util.ApplicationRootPath() + "Pikcv.aspx?Pik=Employee-Activation-Activation&AN=||ACTIVATIONCODE||&U=||USERID||'>Üyeliðinizin aktif olmasý için lütfen týklayýnýz.</a>" +
           //m_Activation.Body = "<a href='http://www.pikcv.com/Pikcv.aspx?Pik=Employee-Activation-Activation&AN=||ACTIVATIONCODE||&U=||USERID||'>Üyeliðinizin aktif olmasý için lütfen týklayýnýz.</a>";
           //m_Activation.Body = "<a href='http://demo.caretta.net/pikcv/Pikcv.aspx?Pik=Employee-Activation-Activation&AN=||ACTIVATIONCODE||&U=||USERID||'>Üyeliðinizin aktif olmasý için lütfen týklayýnýz.</a>";
                                "<br><br>PÝKcv.com’u tercih ettiðiniz için teþekkür ederiz.";

            return m_Activation; 
        }
    }

    public static MailContent ActivationCompany
    {
        get
        {
            MailContent m_Activation = new MailContent();
            m_Activation.From = ConfigurationSettings.AppSettings["MailFrom"].ToString();
            m_Activation.Subject = "PIKCV - Firme Üyelik E-posta Onayý";
            m_Activation.Body = "Sayýn ||FirstName|| ||LastName|| <br><br>" +
                                "PÝKcv.com üyelik iþlemlerinizi tamamlamak için aþaðýdaki linke týklayarak üyelik e-posta doðrulamasýný yapýnýz. <br>" +
                                "Bu doðrulama sonrasýnda sitemize yönlendirileceksiniz. Pikcv.com üyeliðinizin onaylanmasý için sitemizde yer alan danýþmanlýk sözleþmesini yazdýrýp, gerekli yerlerini doldurunuz ve PÝK Danýþmanlýk’ýn aþaðýda belirtilen adresine gönderiniz. <br><br>" +
                                "<a href='" + Util.ApplicationRootPath() + "Pikcv.aspx?Pik=Company-Activation-Activation&AN=||ACTIVATIONCODE||&C=||COMPANYID||'>Üyelik eposta doðrulamasý için lütfen týklayýnýz.</a>" +
                                "<br><br>PIKcv.com’u tercih ettiðiniz için teþekkür ederiz.";

            return m_Activation;
        }
    }

    public static MailContent WelcomeMessage {
        get { 
            MailContent m_Activation = new MailContent ();
            m_Activation.From = ConfigurationSettings.AppSettings["MailFrom"].ToString();
            m_Activation.Subject = "PIKCV - Hoþgeldiniz";
            m_Activation.Body = "Sayýn ||FirstName|| ||LastName|| <br><br>" +
                                "PÝKcv.com’a hoþ geldiniz ;<br><br>Sitemizi kolayca kullarak size özel bilgilere en kýsa zamanda" +
                                "ulaþabilirsiniz. <br>Özgeçmiþiniz iþe alým danýþmanlýðýný yaptýðýmýz tüm  þirketler için" +
                                "tarafýmýzca deðerlendirilir ve uygun görülenler ilgili þirketlere önerilir." +
                                "<br>Veritabanýmýzda yer alan özgeçmiþiniz sitemize üye olan tüm iþverenler tarafýndan incelenir." +
                                "Özgeçmiþinizle sizin için uygun olan ilanlara baþvurabilirsiniz." +
                                "<br><br>Bizi tercih ettiðiniz için teþekkür ederiz.";
            return m_Activation;
        }
    }

    public static MailContent ForgotPassword {
        get {
            MailContent m_ForgotPassword = new MailContent ();
            m_ForgotPassword.From = ConfigurationSettings.AppSettings["MailFrom"].ToString();
            m_ForgotPassword.Subject = "PIKCV - Þifre Hatýrlatma";
            m_ForgotPassword.Body = "Sayýn ||FirstName|| ||LastName||, <br><br>Bu e-posta PIKcv.com üzerinden þifremi unuttum" + 
                                    " linkine týklayarak yapmýþ olduðunuz istek üzerine, sistem tarafýndan otomatik olarak" +
                                    " gönderilmiþtir. Aþaðýda þifreniz yer almaktadýr. <br><br>Þifre: ||PASSWORD|| <br><br>" +
                                    "Saygýlarýmýzla," + 
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
            m_ForgotPasswordCompany.Subject = "PIKCV - Þirket Þifre Hatýrlatma";
            m_ForgotPasswordCompany.Body = "Sayýn ||FirstName|| ||LastName|| <br><br>Bu e-posta PIKcv.com üzerinden þifremi unuttum" +
                                    " linkine týklayarak yapmýþ olduðunuz istek üzerine, sistem tarafýndan otomatik olarak" +
                                    " gönderilmiþtir. Aþaðýda þifreniz yer almaktadýr <br><br>Þifre: ||PASSWORD|| <br><br>" +
                                    "Saygýlarýmýzla,";
            return m_ForgotPasswordCompany;
        }
    }

    public static MailContent TemporaryUser
    {
        get
        {
            MailContent m_TemporaryUser = new MailContent();
            m_TemporaryUser.From = ConfigurationSettings.AppSettings["MailFrom"].ToString();
            m_TemporaryUser.Subject = "PIKCV - Klasör Paylaþýmý";
            m_TemporaryUser.Body = "Size gönderilen klasör içindeki adaylarýn özgeçmiþ bilgilerine aþaðýdaki linke týklayarak eriþebilirsiniz.<br>" +
                                    "Sitemize giriþinizi aþaðýda size iletilen kullanýcý adý ve þifresini kullanarak yapmanýz gerekmektedir.<br>" +
                                    "Size iletilen kullanýcý adý ve þifresi 5 gün süre ile geçerli olacaktýr.<br><br>" +
                                    "Klasör içinde uygun bulduðunuz adaylarý iletiþim bilgisi satýnalma istekleri klasörüne gönderebilirsiniz." +
                                    "Bu adaylarýn iletiþim bilgileri sadece firmanýz adýna sitemizi kullanmaya yetkili kiþi tarafýndan satýn alýnabilir.<br><br>" +
                                    "Kullanýcý Adýnýz: <b>||USERNAME||</b><br>" +
                                    "Þifreniz: <b>||PASSWORD||</b><br><br>" +
                                    " <a href='" + Util.ApplicationRootPath() + "TemporaryUserLogin.aspx'>Size iletilen klasöre eriþebilmek için týklayýnýz</a>" +
                                    "<br><br>Saygýlarýmýzla," +
                                    "<br><br>Gönderenin Özel Notu: ||NOTES||";
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
            m_FriendMail.Subject = "PIKCV Ýþ Ýlaný - ||SUBJECT||";
            m_FriendMail.Body = "Aþaðýdaki linke týklayarak sitemizde yer alan ilan detayýna ulaþabilirsiniz. <br /><br> <a target='_blank' href='" + Util.ApplicationRootPath() + "Pikcv.aspx?Pik=Employee-Jobs-JobDetail&JobID=||JOBID||'>Pikcv iþ ilaný için týklayýnýz.</a>";
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
               "<td style='font-family: Verdana, Arial Helvetica, sans-serif; font-size:8pt; line-height: 140%; color: #666'>Perakende Ýnsan Kaynaklarý LTD.ÞTÝ<br />" +
               "Büyükdere cad. Meydan sok.<br />Spring Giz Plaza Kat.13<br />Maslak-Þiþli ÝSTANBUL</td>" +
               "<td width='1' bgcolor='#CCCCCC'></td>" +
               "<td valign='top' style='font-family: Verdana, Arial Helvetica, sans-serif; font-size:8pt; line-height: 140%; color: #666'>Tel: +90 0212 329 79 32 (Pbx)<br />" +
               "Faks: +90 0212 329 79 32<br />E-posta: <a href='web@pikcv.com' style='color:#006699'>bilgi@pikcv.com</a><br />" +
               "Web sitesi: <a href='http://www.pikcv.com.tr' target='_blank' style='color:#006699'>www.pikcv.com</a></td>" +
               "</tr></table></td></tr><tr><td bgcolor='#CCCCCC'></td>" +
               "</tr><tr><td style='padding:15px;font-family:Verdana, Arial, Helvetica, sans-serif;font-size:7pt;color:#999;'>Bu elektronik posta ve onunla iletilen bütün dosyalar sadece göndericisi tarafýndan almasý amaçlanan yetkili gerçek ya da tüzel kiþinin kullanýmý içindir. Eðer söz konusu yetkili alýcý deðilseniz bu elektronik postanýn içerigini açýklamanýz, kopyalamanýz, yönlendirmeniz ve kullanmanýz kesinlikle yasaktýr ve bu elektronik postayý derhal silmeniz gerekmektedir. PikCV, bu mesajýn içerdigi bilgilerin doðruluðu veya eksiksiz olduðu konusunda herhangi bir garanti vermemektedir. Bu nedenle bu bilgilerin ne þekilde olursa olsun içeriginden, iletilmesinden, alýnmasýndan ve saklanmasýndan, virüs içermesinden ve bilgisayar sisteminize verebileceði herhangi bir zarardan sorumlu tutulamaz. Bu mesajdaki görüþler yalnýzca gönderen kiþiye aittir ve PikCV'un görüþlerini yansýtmayabilir.</td>" +
               "</tr><tr><td>&nbsp;</td></tr></table>";
    }

    #endregion

}