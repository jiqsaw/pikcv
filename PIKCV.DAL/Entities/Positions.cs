
// Generated by MyGeneration Version # (1.3.0.0)

using System;
using System.Data;
using System.Data.SqlClient;

namespace PIKCV.DAL
{
	public class Positions : _Positions
	{
        //Pozisyonlar� Getir 
        public DataTable LoadAllML (bool IsDeleted) {
            SqlConnection conn = DBHelper.getConnection();
            SqlCommand cmd = DBHelper.getSprocCmd("_GetPositionsAll", conn);
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

        //Pozisyonlar� Getir 
        public DataTable GetPositions(int EmployeeType, int LanguageID,bool IsDeleted)
        {
            SqlConnection conn = DBHelper.getConnection();
            SqlCommand cmd = DBHelper.getSprocCmd("_GetPositionsByEmployeeType", conn);
            SqlDataAdapter da;
            SqlParameter param;
            DataTable dt = new DataTable();

            param = new SqlParameter("@EmployeeType", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = EmployeeType;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@LanguageID", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = LanguageID;
            cmd.Parameters.Add(param);
            
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