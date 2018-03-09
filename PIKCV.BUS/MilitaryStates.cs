using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace PIKCV.BUS
{
    public class MilitaryStates
    {
        //Tüm Askerlik Durumlarýný Getir 
        public static DataTable LoadAllML(bool isDeleted)
        {
            DataTable dt;
            try
            {
                PIKCV.DAL.MilitaryStates obj = new PIKCV.DAL.MilitaryStates();
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
