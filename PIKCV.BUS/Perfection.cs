using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace PIKCV.BUS
{
    public class Perfection
    {
        //Tüm Yetkinlikleri Getir 
        public static DataTable LoadAllML(bool isDeleted)
        {
            DataTable dt;
            try
            {
                PIKCV.DAL.Perfection obj = new PIKCV.DAL.Perfection();
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
