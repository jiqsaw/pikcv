using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace PIKCV.BUS
{
    public class DriverLicense
    {
        //Tüm Ehliyet Tiplerini Getir 
        public static DataTable GetAllDriverLicences(bool isDeleted)
        {
            DataTable dt;
            try
            {
                PIKCV.DAL.DriverLicenseTypes obj = new PIKCV.DAL.DriverLicenseTypes();
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
