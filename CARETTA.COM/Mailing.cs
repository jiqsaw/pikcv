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

namespace CARETTA.COM {
    public class Mailing {
        private string m_EMailServer;

        public Mailing () {
            try { m_EMailServer = ConfigurationManager.AppSettings["EMailServer"].ToString(); }
            catch (Exception) { m_EMailServer = ""; }
        }

        public Mailing (string EMailServer) {
            m_EMailServer = EMailServer;
        }

        public bool Send_SimpleHtml(string From, string To, string Subject, string Body, string Bcc, string CC, MailPriority Priority) {
            return Send_SimpleHtml(From, To, Subject, Body, Bcc, CC, Priority, String.Empty, String.Empty);
        }
        
        public bool Send_SimpleHtml (string From, string To, string Subject, string Body, string Bcc, string CC, MailPriority Priority, string UserName, string Password) {
            try {
                MailMessage Msg = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                MailAddress Address = new MailAddress(From);

                if ((UserName != String.Empty) && (Password != String.Empty)) {
                    smtp.Credentials = new System.Net.NetworkCredential(UserName, Password);
                }

                Msg.From = Address;
                Address = new MailAddress(To);

                Msg.To.Add(Address);
                Msg.Subject = Subject;
                Msg.Body = CARETTA.COM.Util.PurifyStringFromTurkishCharacters(Body);
                Msg.BodyEncoding = System.Text.Encoding.UTF8;

                if (CC != "") { Msg.CC.Add(CC); }
                if (Bcc != "") { Msg.Bcc.Add(Bcc); }

                Msg.Priority = Priority;
                Msg.IsBodyHtml = true;

                smtp.Host = this.m_EMailServer;

                smtp.Send(Msg);
                return true;
            }
            catch (Exception) {
                return false;
            }
        }
    }
}