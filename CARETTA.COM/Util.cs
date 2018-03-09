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
            return Text.Replace('i', '�').Replace('�', 'I').ToUpperInvariant();
        }
        public static string ToLower(string Text) 
        {
            return Text.Replace('�', 'i').Replace('I', '�').ToLowerInvariant();
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
        /// String i�indeki yeni sat�rlar� <code>&lt;br /&gt;</code>'ye d�n��t�r�r.
        /// </summary>
        /// <param name="Text">Yeni sat�rlar� html break'e d�n��t�r�lecek string</param>
        /// <returns>Yeni sat�rlar� break'e d�n��t�r�lm�� string</returns>
        public static string Nl2Br(string Text) {
            return Text.Replace("\n", "<br />");
        }

        /// <summary>
        /// STRING TEMIZLE (REG EXP)
        /// </summary>
        /// <param name="input">Temizlenecek De�i�ken</param>
        /// <returns></returns>
        public static string ClearString(string input)
        {
            System.Text.RegularExpressions.Regex regEx = new System.Text.RegularExpressions.Regex("[^0-9a-zA-Z_i�����������@\\-,.:]");
            return regEx.Replace(input, "");
        }

        /// <summary>
        /// String temizleme fonksiyonuna ihtiya� duyulmu� mu ?
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool isNeedClearString(string input) {
            return (input != ClearString(input));
        }

        /// <summary>
        /// Querystring var m� ve d�zg�n m�?
        /// </summary>
        /// <param name="input">Temizlenecek De�i�ken</param>
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
        /// String deki t�m html taglar�n� temizler
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string ClearHtmlTags(string input) {
            return System.Text.RegularExpressions.Regex.Replace(input, "(<[^>]+>)", "");
        }

        /// <summary>
        /// String in db ye kay�t i�in d�zenlenmesi
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string ReplaceStrForDB(string input)
        {
            return ClearHtmlTags(input).Replace("'", "");
        }

        /// <summary>
        /// De�i�ken Numeric ise true, de�ilse false
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
        /// Rasgele Say� �retir
        /// </summary>
        /// <param name="CharLength">Rasgele Say� Ka� Karakterli Olsun</param>
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
            return Text.Replace("�", "&#351;").Replace("�", "&#350;").Replace("�", "&#305;").Replace("�", "&#304;").Replace("�", "&ouml;").Replace("�", "&Ouml;").Replace("�", "&ccedil;").Replace("�", "&Ccedil;").Replace("�", "&#287;").Replace("�", "&#286;").Replace("�", "&uuml;").Replace("�", "&Uuml;").Replace("�", "&rsquo;");
        }


        //            � = &#351;
        //� = &#350;
        //� = &#305;
        //� = &#304;
        //� = &ouml;
        //� = &Ouml;
        //� = &ccedil;
        //� = &Ccedil;
        //� = &#287;
        //� = &#286;
        //� = &uuml;
        //� = &Uuml;
    }
}
