using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace PIKCV.BUS
{
    public class DriverLicence
    {

        //Tüm Ehlyiet Tiplerini Getir 
        public static DataTable GetAllDriverLicenceTypes(bool IsDelete)
        {
            DataTable dt;
            try
            {
                PIKCV.DAL.DriverLicenseTypes obj = new PIKCV.DAL.DriverLicenseTypes();
                dt = obj.LoadAllML(false);
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
