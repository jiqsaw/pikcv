using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Configuration;

namespace PIKCV.COM
{
    public class Util
    {

        public static void GoToEntryPage(HttpResponse PageResponse)
        {
            PageResponse.Redirect("~/" + ConfigurationManager.AppSettings[EnumUtil.Config.PageNameEntry.ToString()].ToString());
        }

        // #### UserID | ## Day | ## Month | #### Year | ######## Randomize 
        public static string CreateActivationNumber (int UserID) {
            string m_UserID = UserID.ToString().PadLeft(4, '0');
            string m_Date = DateTime.Now.Day.ToString().PadLeft(2, '0') + DateTime.Now.Month.ToString().PadLeft(2, '0') + DateTime.Now.Year.ToString();
            string m_RandomNumber = CARETTA.COM.Util.CreateRandomNumber(8);
            return m_UserID + m_Date + m_RandomNumber; 
        }

        public static string ReturnEmptyString(string input) {
            if (input == String.Empty) { input = " "; }
            return input;
        }

        public static string SelectAllListboxScript(params string[] ClientID) {
            StringBuilder sb = new StringBuilder();
            sb.Append("SelectAllListBox('");
            for (int i = 0; i < ClientID.Length; i++)
            {
                sb.Append(ClientID[i] + ",");
            }
            return CARETTA.COM.Util.Left(sb.ToString(), (sb.ToString().Length)- 1) + "');";
        }
    }
}
