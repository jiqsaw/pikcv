
// Generated by MyGeneration Version # (1.3.0.0)

using System;
using System.Data;
using System.Data.SqlClient;

namespace PIKCV.DAL
{
	public class Interviews : _Interviews
	{
        //�irket M�lakatlar�n� Getir 
        public DataTable GetCompanyInterviews(int CompanyID, int InterviewStatusID, int InterviewerTypeCode, int LanguageID)
        {
            SqlConnection conn = DBHelper.getConnection();
            SqlCommand cmd = DBHelper.getSprocCmd("_GetCompanyInterviews", conn);
            SqlDataAdapter da;
            SqlParameter param;
            DataTable dt = new DataTable();

            param = new SqlParameter("@CompanyID", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = CompanyID;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@InterviewStatusID", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = InterviewStatusID;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@InterviewerTypeCode", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = InterviewerTypeCode;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@LanguageID", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = LanguageID;
            cmd.Parameters.Add(param);

            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        //�irket Yap�lm�� M�lakatlar� Getir 
        public DataTable GetCompanyMadeInterviews(int CompanyID, int InterviewerTypeCode, int LanguageID, DateTime InterviewDate)
        {
            SqlConnection conn = DBHelper.getConnection();
            SqlCommand cmd = DBHelper.getSprocCmd("_GetCompanyMadeInterviews", conn);
            SqlDataAdapter da;
            SqlParameter param;
            DataTable dt = new DataTable();

            param = new SqlParameter("@CompanyID", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = CompanyID;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@InterviewerTypeCode", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = InterviewerTypeCode;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@LanguageID", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = LanguageID;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@InterviewDate", SqlDbType.DateTime);
            param.Direction = ParameterDirection.Input;
            param.Value = InterviewDate;
            cmd.Parameters.Add(param);

            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        //�irket M�lakatlar�n� Pozisyona G�re Gruplayarak Getir 
        public DataTable GetCompanyInterviewsGroupByPosition(int CompanyID, int InterviewerTypeCode, int LanguageID, DateTime InterviewDate)
        {
            SqlConnection conn = DBHelper.getConnection();
            SqlCommand cmd = DBHelper.getSprocCmd("_GetCompanyInterviewsGroupByPosition", conn);
            SqlDataAdapter da;
            SqlParameter param;
            DataTable dt = new DataTable();

            param = new SqlParameter("@CompanyID", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = CompanyID;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@InterviewerTypeCode", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = InterviewerTypeCode;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@LanguageID", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = LanguageID;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@InterviewDate", SqlDbType.DateTime);
            param.Direction = ParameterDirection.Input;
            param.Value = InterviewDate;
            cmd.Parameters.Add(param);

            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        //�irket M�lakatlar�n� Dan��man ve Zamana G�re Gruplayarak Getir 
        public DataTable GetCompanyInterviewsGroupByAdvisorAndTime(int CompanyID, int InterviewerTypeCode, DateTime InterviewDate, int PositionID)
        {
            SqlConnection conn = DBHelper.getConnection();
            SqlCommand cmd = DBHelper.getSprocCmd("_GetCompanyInterviewsGroupByAdvisorAndTime", conn);
            SqlDataAdapter da;
            SqlParameter param;
            DataTable dt = new DataTable();

            param = new SqlParameter("@CompanyID", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = CompanyID;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@InterviewerTypeCode", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = InterviewerTypeCode;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@InterviewDate", SqlDbType.DateTime);
            param.Direction = ParameterDirection.Input;
            param.Value = InterviewDate;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@PositionID", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = PositionID;
            cmd.Parameters.Add(param);

            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
	}
}
