using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace PIKCV.BUS
{
    public class InterviewStates
    {
        //Tüm Mülakat Statülerini Getir 
        public static DataTable LoadAllML(bool isDeleted)
        {
            DataTable dt;
            try
            {
                PIKCV.DAL.InterviewStates obj = new PIKCV.DAL.InterviewStates();
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
