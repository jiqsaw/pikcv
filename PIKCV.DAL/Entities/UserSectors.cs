
// Generated by MyGeneration Version # (1.3.0.0)

using System;
using System.Data;
using System.Data.SqlClient;

namespace PIKCV.DAL
{
	public class UserSectors : _UserSectors
	{
        // Kullan�c�n Sekt�rlerini Getir 
        public DataTable GetUserSectors(int UserID, int LanguageID)
        {
            SqlConnection conn = DBHelper.getConnection();
            SqlCommand cmd = DBHelper.getSprocCmd("_GetUserSectors", conn);
            SqlDataAdapter da;
            SqlParameter param;
            DataTable dt = new DataTable();

            param = new SqlParameter("@UserID", SqlDbType.Int, 4);
            param.Direction = ParameterDirection.Input;
            param.Value = UserID;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@LanguageID", SqlDbType.Int, 4);
            param.Direction = ParameterDirection.Input;
            param.Value = LanguageID;
            cmd.Parameters.Add(param);

            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
	}
}