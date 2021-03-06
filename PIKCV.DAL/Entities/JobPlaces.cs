
// Generated by MyGeneration Version # (1.3.0.0)

using System;
using System.Data;
using System.Data.SqlClient;

namespace PIKCV.DAL
{
	public class JobPlaces : _JobPlaces
	{
        ////�lan �lkelerini,�ehirlerini Getir 
        public DataTable GetJobPlaces(int JobID, int PlaceTypeCode, int LanguageID)
        {
            SqlConnection conn = DBHelper.getConnection();
            SqlCommand cmd = DBHelper.getSprocCmd("_GetJobPlaces", conn);
            SqlDataAdapter da;
            SqlParameter param;
            DataTable dt = new DataTable();

            param = new SqlParameter("@JobID", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = JobID;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@PlaceTypeCode", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = PlaceTypeCode;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@LanguageID", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = LanguageID;
            cmd.Parameters.Add(param);

            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        //�lan �ehirlerini, �lkelerini Siler
        public void DeleteAllJobPlaces(int JobID)
        {
            SqlConnection conn = DBHelper.getConnection();
            SqlCommand cmd = DBHelper.getSprocCmd("_DeleteJobPlacesAll", conn);
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
