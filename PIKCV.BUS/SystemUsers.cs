using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using CARETTA.COM;

namespace PIKCV.BUS
{
    public class SystemUsers
    {
        public DataTable GetSystemUser(int SystemUserID)
        {
            PIKCV.DAL.SystemUsers obj = new PIKCV.DAL.SystemUsers();
            obj.Where.SystemUserID.Value = SystemUserID;
            obj.Query.Load();
            return obj.DefaultView.ToTable();
        }
    }
}
