
// Generated by MyGeneration Version # (1.3.0.0)

using System;
using System.Data;
using System.Data.SqlClient;

namespace PIKCV.DAL
{
    public class JobChoiceForeignLanguage : _JobChoiceForeignLanguage
    {
        //�lan Tercih A��rl�klar� Yabanc� Dilleri Siler
        public void DeleteAllJobQualitySectors(int JobID)
        {
            SqlConnection conn = DBHelper.getConnection();
            SqlCommand cmd = DBHelper.getSprocCmd("_DeleteJobChoiceForeignLanguageAll", conn);
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