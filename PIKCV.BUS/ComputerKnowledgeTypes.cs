using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace PIKCV.BUS
{
    public class ComputerKnowledgeTypes
    {

        //Tüm Bilgisayar Bilgisi Tiplerini Getir 
        public static DataTable GetComputerKnowledgeTypesAll(bool isDeleted)
        {
            DataTable dt;
            try
            {
                PIKCV.DAL.ComputerKnowledgeTypes obj = new PIKCV.DAL.ComputerKnowledgeTypes();
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
