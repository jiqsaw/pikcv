using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace PIKCV.BUS
{
    public class Education
    {
        //T�m E�itim Durumlar� Getir 
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

        //T�m Okullar� Getir 
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

        //T�m E�itim Seviyelerini Getir 
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
