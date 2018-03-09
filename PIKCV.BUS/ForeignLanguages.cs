using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace PIKCV.BUS
{
    public class ForeignLanguages
    {

        //T�m Yabanc� Dilleri Getir 
        public static DataTable GetForeignLanguagesAll(bool isDeleted)
        {
            DataTable dt;
            try
            {
                PIKCV.DAL.ForeignLanguages obj = new PIKCV.DAL.ForeignLanguages();
                dt = obj.LoadAllML(isDeleted);
            }
            catch (Exception)
            {
                dt = null;
                throw;
            }
            return dt;
        }

        //T�m Yabanc� Dil S�navlar�n� Getir 
        public static DataTable GetForeignLanguageExams(bool isDeleted)
        {
            DataTable dt;
            try
            {
                PIKCV.DAL.ForeignLanguageExams obj = new PIKCV.DAL.ForeignLanguageExams();
                obj.Where.IsDeleted.Value = isDeleted;
                obj.Query.Load();
                dt = obj.DefaultView.ToTable();
            }
            catch (Exception)
            {
                dt = null;
                throw;
            }
            return dt;
        }

    }
}
