using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace PIKCV.BUS
{
    public class Levels
    {
        //Tüm Yabancý Dilleri Getir 
        public static DataTable GetLevelsAll(bool isDeleted)
        {
            DataTable dt;
            try
            {
                PIKCV.DAL.Levels obj = new PIKCV.DAL.Levels();
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
