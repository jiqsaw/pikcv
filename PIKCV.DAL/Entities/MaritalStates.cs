
// Generated by MyGeneration Version # (1.3.0.0)

using System;
using System.Data;
using System.Data.SqlClient;

namespace PIKCV.DAL
{
	public class MaritalStates : _MaritalStates
	{
        //T�m Medeni Halleri Getir 
        public DataTable LoadAllML(bool IsDeleted)
        {
            SqlConnection conn = DBHelper.getConnection();
            SqlCommand cmd = DBHelper.getSprocCmd("_GetMaritalStates", conn);
            SqlDataAdapter da;
            SqlParameter param;
            DataTable dt = new DataTable();

            param = new SqlParameter("@IsDeleted", SqlDbType.Bit, 1);
            param.Direction = ParameterDirection.Input;
            param.Value = IsDeleted;
            cmd.Parameters.Add(param);

            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
	}
}
