using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using CARETTA.COM;

namespace PIKCV.BUS
{
    public class TemporaryUsers
    {
        public static DataTable TemporaryUserLoginControl(string UserCode, string PassWord)
        {
            PIKCV.DAL.TemporaryUsers obj = new PIKCV.DAL.TemporaryUsers();
            return obj.TemporaryUserLoginControl(Util.ClearString(UserCode), Encryption.Encrypt(Util.ClearString(PassWord)), DateTime.Now);
        }

        public static DataTable GetTemporaryUserDetail(int TemporaryUserID)
        {
            PIKCV.DAL.TemporaryUsers obj = new PIKCV.DAL.TemporaryUsers();
            obj.LoadByPrimaryKey(TemporaryUserID);
            return obj.DefaultView.ToTable();
        }
    }
}
