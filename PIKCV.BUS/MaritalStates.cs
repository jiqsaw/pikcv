using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace PIKCV.BUS
{
    public class MaritalStates
    {
        //Tüm Medeni Durumlarý Getir 
        public static DataTable LoadAllML(bool isDeleted)
        {
            DataTable dt;
            try
            {
                PIKCV.DAL.MaritalStates obj = new PIKCV.DAL.MaritalStates();
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
