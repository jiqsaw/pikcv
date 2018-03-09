using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace PIKCV.BUS
{
    public class Education
    {
        //Tüm Eðitim Durumlarý Getir 
        public static DataTable GetAllEducationStates(bool isDeleted)
        {
            DataTable dt;
            try
            {
                PIKCV.DAL.EducationStates obj = new PIKCV.DAL.EducationStates();
                dt = obj.LoadAllML(isDeleted);
            }
            catch (Exception)
            {
                dt = null;
                throw;
            }
            return dt;
        }

        //Tüm Okullarý Getir 
        public static DataTable GetAllSchools(bool isDeleted)
        {
            DataTable dt;
            try
            {
                PIKCV.DAL.Schools obj = new PIKCV.DAL.Schools();
                dt = obj.LoadAllML(isDeleted);
            }
            catch (Exception)
            {
                dt = null;
                throw;
            }
            return dt;
        }

        //Tüm Eðitim Seviyelerini Getir 
        public static DataTable GetAllEducationLevels(bool isDeleted)
        {
            DataTable dt;
            try
            {
                PIKCV.DAL.EducationLevels obj = new PIKCV.DAL.EducationLevels();
                dt = obj.LoadAllML(isDeleted);
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
