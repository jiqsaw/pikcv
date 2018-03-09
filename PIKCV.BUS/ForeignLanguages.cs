using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace PIKCV.BUS
{
    public class ForeignLanguages
    {

        //Tüm Yabancý Dilleri Getir 
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

        //Tüm Yabancý Dil Sýnavlarýný Getir 
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
