
// Generated by MyGeneration Version # (1.3.0.0)

using System;
using System.Data;
using System.Data.SqlClient;

namespace PIKCV.DAL
{
    public class JobPerfection : _JobPerfection
    {
        ////�lan Yetkinliklerini Getir 
        public DataTable GetJobPerfection(int JobID)
        {
            SqlConnection conn = DBHelper.getConnection();
            SqlCommand cmd = DBHelper.getSprocCmd("_GetJobPerfection", conn);
            SqlDataAdapter da;
            SqlParameter param;
            DataTable dt = new DataTable();

            param = new SqlParameter("@JobID", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = JobID;
            cmd.Parameters.Add(param);

            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        //�lan Yetkinliklerini Siler
        public void DeleteAllJobPerfection(int JobID)
        {
            SqlConnection conn = DBHelper.getConnection();
            SqlCommand cmd = DBHelper.getSprocCmd("_DeleteJobPerfectionAll", conn);
            SqlParameter param;

            param = new SqlParameter("@JobID", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = JobID;
            cmd.Parameters.Add(param);

            conn.Open();

            cmd.ExecuteNonQuery();
        }
    }
}
