
// Generated by MyGeneration Version # (1.3.0.0)

using System;
using System.Data;
using System.Data.SqlClient;

namespace PIKCV.DAL
{
	public class UserEducation : _UserEducation
	{
        //Kullanıcın Bilgilerini Getir 
        public DataTable GetUserEducation(int UserID, int EducationTypeCode, int LanguageID, bool IsDeleted) {
            SqlConnection conn = DBHelper.getConnection();
            SqlCommand cmd = DBHelper.getSprocCmd("_GetUserEducation", conn);
            SqlDataAdapter da;
            SqlParameter param;
            DataTable dt = new DataTable();

            param = new SqlParameter("@EducationTypeCode", SqlDbType.Int, 4);
            param.Direction = ParameterDirection.Input;
            param.Value = EducationTypeCode;
            cmd.Parameters.Add(param); 

            param = new SqlParameter("@UserID", SqlDbType.Int, 4);
            param.Direction = ParameterDirection.Input;
            param.Value = UserID;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@LanguageID", SqlDbType.Int, 4);
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

        //Kullanıcın Okullarının Listesi Getir 
        public DataTable GetUserEducationList(int UserID, int EducationStatusID, int LanguageID, bool IsDeleted)
        {
            SqlConnection conn = DBHelper.getConnection();
            SqlCommand cmd = DBHelper.getSprocCmd("_GetUserEducationList", conn);
            SqlDataAdapter da;
            SqlParameter param;
            DataTable dt = new DataTable();

            param = new SqlParameter("@EducationStatusID", SqlDbType.Int, 4);
            param.Direction = ParameterDirection.Input;
            param.Value = EducationStatusID;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@UserID", SqlDbType.Int, 4);
            param.Direction = ParameterDirection.Input;
            param.Value = UserID;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@LanguageID", SqlDbType.Int, 4);
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
