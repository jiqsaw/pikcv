using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace PIKCV.BUS
{
    public class Position
    {

        //Tüm Pozisyonlarý Getir 
        public static DataTable LoadAllML(bool isDeleted)
        {
            DataTable dt;
            try
            {
                PIKCV.DAL.Positions obj = new PIKCV.DAL.Positions();
                dt = obj.LoadAllML(isDeleted);
            }
            catch (Exception)
            {
                dt = null;
                throw;
            }
            return dt;
        }

        public static DataTable GetPositions(PIKCV.COM.EnumDB.EmployeeTypes EmployeeType, PIKCV.COM.EnumDB.LanguageID LanguageID, bool IsDeleted)
        {
            DataTable dt;
            try
            {
                PIKCV.DAL.Positions obj = new PIKCV.DAL.Positions();
                dt = obj.GetPositions((int)EmployeeType, (int)LanguageID, IsDeleted);
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
