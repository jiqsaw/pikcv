using System;
using System.Data;
using System.Data.SqlClient;

namespace PIKCV.DAL
{
	public class TestAnswers : _TestAnswers
	{
        //Test skorlarýný getir 
        public DataTable GetTestScore(int TestTypeCode, int UserID, int LanguageID, int EmployeeTypeCode)
        {
            SqlConnection conn = DBHelper.getConnection();
            SqlCommand cmd = DBHelper.getSprocCmd("_GetTestScore", conn);
            SqlDataAdapter da;
            SqlParameter param;
            DataTable dt = new DataTable();

            param = new SqlParameter("@TestTypeCode", SqlDbType.Int, 4);
            param.Direction = ParameterDirection.Input;
            param.Value = TestTypeCode;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@UserID", SqlDbType.Int, 4);
            param.Direction = ParameterDirection.Input;
            param.Value = UserID;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@LanguageID", SqlDbType.Int, 4);
            param.Direction = ParameterDirection.Input;
            param.Value = LanguageID;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@EmployeeTypeCode", SqlDbType.Int, 4);
            param.Direction = ParameterDirection.Input;
            param.Value = EmployeeTypeCode;
            cmd.Parameters.Add(param);

            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
	}
}
