
// Generated by MyGeneration Version # (1.3.0.0)

using System;
using System.Data;
using System.Data.SqlClient;

namespace PIKCV.DAL
{
	public class TestPerfection : _TestPerfection
	{
        //Yetkinlik Testini Getir 
        public DataTable GetPerfectionTest(int EmployeeTypeCode, int BothEmployeeType, int LanguageID)
        {
            SqlConnection conn = DBHelper.getConnection();
            SqlCommand cmd = DBHelper.getSprocCmd("_GetPerfectionTest", conn);
            SqlDataAdapter da;
            SqlParameter param;
            DataTable dt = new DataTable();

            param = new SqlParameter("@EmployeeTypeCode", SqlDbType.Int, 4);
            param.Direction = ParameterDirection.Input;
            param.Value = EmployeeTypeCode;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@BothEmployeeType", SqlDbType.Int, 4);
            param.Direction = ParameterDirection.Input;
            param.Value = BothEmployeeType;
            cmd.Parameters.Add(param);


            param = new SqlParameter("@LanguageID", SqlDbType.Int, 4);
            param.Direction = ParameterDirection.Input;
            param.Value = LanguageID;
            cmd.Parameters.Add(param);

            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public DataTable GetTestPerfectionScore(int UserID)
        {
            SqlConnection conn = DBHelper.getConnection();
            SqlCommand cmd = DBHelper.getSprocCmd("_GetTestPerfectionScore", conn);
            SqlDataAdapter da;
            SqlParameter param;
            DataTable dt = new DataTable();

            param = new SqlParameter("@UserID", SqlDbType.Int, 4);
            param.Direction = ParameterDirection.Input;
            param.Value = UserID;
            cmd.Parameters.Add(param);

            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }


        public DataTable GetTestPerfectionResult(int EmployeeTypeCode, int LanguageID, int PerfectionID, int TestLevelID)
        {
            SqlConnection conn = DBHelper.getConnection();
            SqlCommand cmd = DBHelper.getSprocCmd("_GetTestPerfectionResult", conn);
            SqlDataAdapter da;
            SqlParameter param;
            DataTable dt = new DataTable();

            param = new SqlParameter("@EmployeeTypeCode", SqlDbType.Int, 4);
            param.Direction = ParameterDirection.Input;
            param.Value = EmployeeTypeCode;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@LanguageID", SqlDbType.Int, 4);
            param.Direction = ParameterDirection.Input;
            param.Value = LanguageID;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@PerfectionID", SqlDbType.Int, 4);
            param.Direction = ParameterDirection.Input;
            param.Value = PerfectionID;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@TestLevelID", SqlDbType.Int, 4);
            param.Direction = ParameterDirection.Input;
            param.Value = TestLevelID;
            cmd.Parameters.Add(param);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }    
    
    }
}
