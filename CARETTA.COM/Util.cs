using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections;

namespace CARETTA.COM
{
    public class Util
    {
        public static string Left(string param, int length) 
        {
            if (param.Length < length) { length = param.Length; }
            return param.Substring(0, length);
        }
        public static string Right(string param, int length) 
        {
            if (param.Length < length) { length = param.Length; }
            return param.Substring(param.Length - length, length);
        }
        public static string Mid(string param, int startIndex, int length) 
        {
            if (param.Length < length) { length = param.Length; }
            return param.Substring(startIndex, length);
        }
        public static string Mid(string param, int startIndex) 
        {
            return param.Substring(startIndex);
        }

        public static string ToUpper(string Text) 
        {
            return Text.Replace('i', 'Ý').Replace('ý', 'I').ToUpperInvariant();
        }
        public static string ToLower(string Text) 
        {
            return Text.Replace('Ý', 'i').Replace('I', 'ý').ToLowerInvariant();
        }
        public static string SpecialName(string Text) {
            string strOutput = String.Empty;
            ArrayList arrTexts = new ArrayList();
            arrTexts.AddRange(Text.Split(' '));
            for (int i = 0; i < arrTexts.Count; i++)
            {
                if (arrTexts[i].ToString().Trim() != String.Empty)
                {
                    strOutput += ToUpper(Left(arrTexts[i].ToString(), 1)) + ToLower(Mid(arrTexts[i].ToString(), 1));
                    if ((arrTexts.Count > 0) && ((arrTexts.Count - 1) > i)) strOutput += ' ';
                }
            }
            return strOutput;
        }

        public static string ReturnPageName() 
        {
            return System.IO.Path.GetFileName(System.Web.HttpContext.Current.Request.RawUrl);
        }
        public static string ReturnRefererPageName() 
        {
            return System.IO.Path.GetFileName(System.Web.HttpContext.Current.Request.UrlReferrer.ToString());
        }
        public static string ApplicationRootPath() {
            //return System.Web.HttpContext.Current.Request.Url.AbsoluteUri.Substring(0, System.Web.HttpContext.Current.Request.Url.AbsoluteUri.LastIndexOf('/') + 1);
            return "http://demo.caretta.net/pikcv/";
        }

        public static float FormatPrice(object inNumber) {
            return float.Parse(String.Format("{0:c}", inNumber).Replace(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol, "").Trim());
        }
        public static string FormatPriceToString(object inNumber) {
            return String.Format("{0:c}", inNumber).Replace(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol, "").Trim();
        }
        public static string FormatPhone(string input) {
            input = input.Replace(" ", String.Empty);
            if (input.Length == 7) return String.Format("{0:### ## ##}", Convert.ToInt64(input));
            else if (input.Length == 10) return String.Format("{0:(###) ### ## ##}", Convert.ToInt64(input));
            else if (input.Length == 11) return String.Format("{0:#(###) ### ## ##}", Convert.ToInt64(input));
            else if (input.Length == 12) return String.Format("{0:##(###) ### ## ##}", Convert.ToInt64(input));
            else if (input.Length == 13) return String.Format("{0:###(###) ### ## ##}", Convert.ToInt64(input));
            else return input;
        }

        public static bool IsEven(object input)
        { return ((int)((int.Parse(input.ToString())))) % 2 == 0; }

        /// <summary>
        /// String içindeki yeni satýrlarý <code>&lt;br /&gt;</code>'ye dönüþtürür.
        /// </summary>
        /// <param name="Text">Yeni satýrlarý html break'e dönüþtürülecek string</param>
        /// <returns>Yeni satýrlarý break'e dönüþtürülmüþ string</returns>
        public static string Nl2Br(string Text) {
            return Text.Replace("\n", "<br />");
        }

        /// <summary>
        /// STRING TEMIZLE (REG EXP)
        /// </summary>
        /// <param name="input">Temizlenecek Deðiþken</param>
        /// <returns></returns>
        public static string ClearString(string input)
        {
            System.Text.RegularExpressions.Regex regEx = new System.Text.RegularExpressions.Regex("[^0-9a-zA-Z_iþçöüðÝÞÇÖÜÐ@\\-,.:]");
            return regEx.Replace(input, "");
        }

        /// <summary>
        /// String temizleme fonksiyonuna ihtiyaç duyulmuþ mu ?
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool isNeedClearString(string input) {
            return (input != ClearString(input));
        }

        /// <summary>
        /// Querystring var mý ve düzgün mü?
        /// </summary>
        /// <param name="input">Temizlenecek Deðiþken</param>
        /// <returns></returns>
        public static bool IsString(object input)
        {
            string m_input = String.Empty;

            if (input == null) { return false; }
            try
            {
                m_input = ClearString(input.ToString());
                if (m_input == string.Empty) { return false; }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// String deki tüm html taglarýný temizler
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string ClearHtmlTags(string input) {
            return System.Text.RegularExpressions.Regex.Replace(input, "(<[^>]+>)", "");
        }

        /// <summary>
        /// String in db ye kayýt için düzenlenmesi
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string ReplaceStrForDB(string input)
        {
            return ClearHtmlTags(input).Replace("'", "");
        }

        /// <summary>
        /// Deðiþken Numeric ise true, deðilse false
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsNumeric(object input) {

            if (input == null) {
                return false;
            }

            if (input.ToString() == string.Empty) {
                return false;
            }

            foreach (char c in input.ToString()) {
                if (!char.IsNumber(c))
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Rasgele Sayý Üretir
        /// </summary>
        /// <param name="CharLength">Rasgele Sayý Kaç Karakterli Olsun</param>
        /// <returns></returns>
        public static string CreateRandomNumber(int CharLength) {
            Random rnd = new Random(DateTime.Now.Year * DateTime.Now.Month * DateTime.Now.Day * DateTime.Now.Millisecond);
            string RndNumber = string.Empty;
            for (int i = 1; i <= CharLength; i++) {
                RndNumber += rnd.Next(0, 9).ToString();
            }
            return RndNumber;
        }

        ///<summary>
        /// String b
        /// </summary>
        public static string PurifyStringFromTurkishCharacters(string Text)
        {
            return Text.Replace("þ", "&#351;").Replace("Þ", "&#350;").Replace("ý", "&#305;").Replace("Ý", "&#304;").Replace("ö", "&ouml;").Replace("Ö", "&Ouml;").Replace("ç", "&ccedil;").Replace("Ç", "&Ccedil;").Replace("ð", "&#287;").Replace("Ð", "&#286;").Replace("ü", "&uuml;").Replace("Ü", "&Uuml;").Replace("’", "&rsquo;");
        }


        //            þ = &#351;
        //Þ = &#350;
        //ý = &#305;
        //Ý = &#304;
        //ö = &ouml;
        //Ö = &Ouml;
        //ç = &ccedil;
        //Ç = &Ccedil;
        //ð = &#287;
        //Ð = &#286;
        //ü = &uuml;
        //Ü = &Uuml;
    }
}
