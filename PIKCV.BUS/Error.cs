using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace PIKCV.BUS
{
    public class Error
    {
        //Tüm Hatalarý Getir
        public static DataTable LoadAllML()
        {
            DataTable dt;
            try
            {
                PIKCV.DAL.Errors objError = new PIKCV.DAL.Errors();
                dt = objError.LoadAllML();
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
