using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using PIKCV.DAO;

namespace PIKCV.DAL
{
    public class DBHelper
    {
        /// <summary>
        /// Yeni bir SqlConnection instance'� d�nd�r�r.
        /// </summary>
        /// <returns>SqlConnection nesnesi.</returns>
        public static SqlConnection getConnection() {
            string DefaultConnectionStringConfig = ConfigurationManager.AppSettings[BusinessEntity.DefaultConnectionStringConfig].ToString();
            return new SqlConnection (DefaultConnectionStringConfig);
        }

        /// <summary>
        /// �stenen stored procedure'un ismi ile, ilgili stored procedure'un, yeni bir instance'�n� yarat�p d�nd�r�r.
        /// </summary>
        /// <param name="strSprocName">Nesnesi istenen stored procedure'un ismi.</param>
        /// <param name="conn">Veritaban� ba�lant�s� nesnesi.</param>
        /// <returns>Yeni yarat�lan SQLCommand nesnesi.</returns>
        public static SqlCommand getSprocCmd(string strSprocName, SqlConnection conn) {
            string SchemaName = String.Empty;
            if (ConfigurationManager.AppSettings["SchemaName"]!=null) {
                SchemaName = ConfigurationManager.AppSettings["SchemaName"].ToString() + ".";
            }
            SqlCommand cmd = new SqlCommand(SchemaName + strSprocName, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            return cmd;
        }
    }
}