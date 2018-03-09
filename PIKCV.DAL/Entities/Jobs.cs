
// Generated by MyGeneration Version # (1.3.0.0)

using System;
using System.Data;
using System.Data.SqlClient;

namespace PIKCV.DAL
{
	public class Jobs : _Jobs
	{
        //�lan Arama Sonu�lar�n� [Full]
        public DataTable GetJobs(int UserID, string Keyword, string Sectors, string Cities, string Positions, int JobStatus, string Companies, 
                                string EducationLevels, string LabouringTypes, int AgeRange, int AgeRangeAll, DateTime JobDate, bool CustomJobs,
                                int PositionID, int CompanyID, int Status)
        {
            SqlConnection conn = DBHelper.getConnection();
            SqlCommand cmd = DBHelper.getSprocCmd("_GetJobs", conn);
            SqlDataAdapter da;
            SqlParameter param;
            DataTable dt = new DataTable();

            if (UserID != -1)
            {
                param = new SqlParameter("@UserID", SqlDbType.Int, 4);
                param.Direction = ParameterDirection.Input;
                param.Value = UserID;
                cmd.Parameters.Add(param);
            }

            param = new SqlParameter("@Keyword", SqlDbType.NVarChar, 128);
            param.Direction = ParameterDirection.Input;
            param.Value = Keyword;
            cmd.Parameters.Add(param);


            if (Sectors != String.Empty)
            {
                param = new SqlParameter("@Sectors", SqlDbType.Xml);
                param.Direction = ParameterDirection.Input;
                param.Value = Sectors;
                cmd.Parameters.Add(param);
            }

            if (Cities != String.Empty)
            {
                param = new SqlParameter("@Cities", SqlDbType.Xml);
                param.Direction = ParameterDirection.Input;
                param.Value = Cities;
                cmd.Parameters.Add(param);
            }

            param = new SqlParameter("@Positions", SqlDbType.Xml);
            param.Direction = ParameterDirection.Input;
            param.Value = Positions;
            cmd.Parameters.Add(param);

            if (JobStatus != -1)
            {
                param = new SqlParameter("@JobStatus", SqlDbType.Int, 4);
                param.Direction = ParameterDirection.Input;
                param.Value = JobStatus;
                cmd.Parameters.Add(param);
            }

            if (Companies != String.Empty)
            {
                param = new SqlParameter("@Companies", SqlDbType.Xml);
                param.Direction = ParameterDirection.Input;
                param.Value = Companies;
                cmd.Parameters.Add(param);
            }

            if (EducationLevels != String.Empty)
            {
                param = new SqlParameter("@EducationLevels", SqlDbType.Xml);
                param.Direction = ParameterDirection.Input;
                param.Value = EducationLevels;
                cmd.Parameters.Add(param);
            }

            if (LabouringTypes != String.Empty)
            {
                param = new SqlParameter("@LabouringTypes", SqlDbType.Xml);
                param.Direction = ParameterDirection.Input;
                param.Value = LabouringTypes;
                cmd.Parameters.Add(param);
            }

            if (AgeRange != -1)
            {
                param = new SqlParameter("@AgeRange", SqlDbType.Int, 4);
                param.Direction = ParameterDirection.Input;
                param.Value = AgeRange;
                cmd.Parameters.Add(param);
            }

            if (AgeRangeAll != -1)
            {
                param = new SqlParameter("@AgeRangeAll", SqlDbType.Int, 4);
                param.Direction = ParameterDirection.Input;
                param.Value = AgeRangeAll;
                cmd.Parameters.Add(param);
            }

            if (JobDate != DateTime.MinValue)
            {
                param = new SqlParameter("@JobDate", SqlDbType.DateTime);
                param.Direction = ParameterDirection.Input;
                param.Value = JobDate;
                cmd.Parameters.Add(param);
            }

            param = new SqlParameter("@CustomJobs", SqlDbType.Bit, 1);
            param.Direction = ParameterDirection.Input;
            param.Value = CustomJobs;
            cmd.Parameters.Add(param);

            if (PositionID != -1)
            {
                param = new SqlParameter("@PositionID", SqlDbType.Int, 4);
                param.Direction = ParameterDirection.Input;
                param.Value = PositionID;
                cmd.Parameters.Add(param);
            }

            if (CompanyID != -1)
            {
                param = new SqlParameter("@CompanyID", SqlDbType.Int, 4);
                param.Direction = ParameterDirection.Input;
                param.Value = CompanyID;
                cmd.Parameters.Add(param);
            }

            if (Status != -1)
            {
                param = new SqlParameter("@Status", SqlDbType.Int, 4);
                param.Direction = ParameterDirection.Input;
                param.Value = Status;
                cmd.Parameters.Add(param);
            }

            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        ////�lan Arama Sonu�lar�n� [Kolay Arama Logon]
        //public DataTable GetJobs(int UserID, string Keyword, string Sectors, string Cities, string Positions, int JobStatus, bool CustomJobs)
        //{
        //    return GetJobs(UserID, Keyword, Sectors, Cities, Positions, JobStatus, String.Empty, String.Empty, String.Empty, -1, -1, DateTime.MinValue, CustomJobs, -1, -1, -1);
        //}

        ////�lan Arama Sonu�lar�n� [Kolay Arama No Login]
        //public DataTable GetJobs(string Keyword, string Sectors, string Cities, string Positions, int JobStatus, bool CustomJobs)
        //{
        //    return GetJobs(-1, Keyword, Sectors, Cities, Positions, JobStatus, CustomJobs);
        //}

        ////�lan Arama Sonu�lar�n� [Detayl� Arama Filtreler No Login]
        //public DataTable GetJobs(string Keyword, string Sectors, string Cities, string Positions, int JobStatus, bool CustomJobs)
        //{
        //    return GetJobs(-1, Keyword, Sectors, Cities, Positions, JobStatus, CustomJobs);
        //}


        //Ana Sayfadaki �lk 20 ve �kinci 20 ilanlar�n� getir


        public DataTable GetMainJobs(int JobStatus)
        {
            SqlConnection conn = DBHelper.getConnection();
            SqlCommand cmd = DBHelper.getSprocCmd("_GetMainJobs", conn);
            SqlDataAdapter da;
            SqlParameter param;
            DataTable dt = new DataTable();

            param = new SqlParameter("@JobStatus", SqlDbType.Int, 4);
            param.Direction = ParameterDirection.Input;
            param.Value = JobStatus;
            cmd.Parameters.Add(param);

            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public DataTable GetUserCustomJobs(int UserID, int LanguageID, int ActiveJobID)
        {
            SqlConnection conn = DBHelper.getConnection();
            SqlCommand cmd = DBHelper.getSprocCmd("_GetUserCustomJobs", conn);
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


            param = new SqlParameter("@ActiveJobID", SqlDbType.Int, 4);
            param.Direction = ParameterDirection.Input;
            param.Value = ActiveJobID;
            cmd.Parameters.Add(param);

            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public DataSet GetJobStatictics(int JobID, int LanguageID, int SexCode)
        {
            SqlConnection conn = DBHelper.getConnection();
            SqlCommand cmd = DBHelper.getSprocCmd("_GetJobStatistics", conn);
            SqlDataAdapter da;
            SqlParameter param;
            DataSet ds = new DataSet();

            param = new SqlParameter("@JobID", SqlDbType.Int, 4);
            param.Direction = ParameterDirection.Input;
            param.Value = JobID;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@LanguageID", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = LanguageID;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@SexCode", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = SexCode;
            cmd.Parameters.Add(param);

            da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;
        }

        //�lan Detay�n� Getir
        public DataTable GetJobDetail(int JobID)
        {
            SqlConnection conn = DBHelper.getConnection();
            SqlCommand cmd = DBHelper.getSprocCmd("_GetJobDetail", conn);
            SqlDataAdapter da;
            SqlParameter param;
            DataTable dt = new DataTable();

            param = new SqlParameter("@JobID", SqlDbType.Int, 4);
            param.Direction = ParameterDirection.Input;
            param.Value = JobID;
            cmd.Parameters.Add(param);

            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        //�irket Top 3 �lan�n� Getir 
        public DataTable GetCompanyJobs(int CompanyID, int JobStatus, int LanguageID)
        {
            SqlConnection conn = DBHelper.getConnection();
            SqlCommand cmd = DBHelper.getSprocCmd("_GetCompanyJobs", conn);
            SqlDataAdapter da;
            SqlParameter param;
            DataTable dt = new DataTable();

            param = new SqlParameter("@CompanyID", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = CompanyID;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@JobStatus", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = JobStatus;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@LanguageID", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = LanguageID;
            cmd.Parameters.Add(param);

            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        //Pozisyona G�re �irket �lanlar�n� Getir 
        public DataTable GetCompanyJobsAll(int CompanyID, int JobStatus, int LanguageID, string PositionID)
        {
            SqlConnection conn = DBHelper.getConnection();
            SqlCommand cmd = DBHelper.getSprocCmd("_GetCompanyJobsAll", conn);
            SqlDataAdapter da;
            SqlParameter param;
            DataTable dt = new DataTable();

            param = new SqlParameter("@CompanyID", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = CompanyID;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@JobStatus", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = JobStatus;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@LanguageID", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = LanguageID;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@PositionID", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = PositionID;
            cmd.Parameters.Add(param);

            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        //�irket T�m �lanlar�n� Getir 
        public DataTable GetCompanyAllJobs(int CompanyID, int JobStatus,int LanguageId)
        {
            SqlConnection conn = DBHelper.getConnection();
            SqlCommand cmd = DBHelper.getSprocCmd("_GetCompanyAllJobs", conn);
            SqlDataAdapter da;
            SqlParameter param;
            DataTable dt = new DataTable();

            param = new SqlParameter("@CompanyID", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = CompanyID;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@JobStatus", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = JobStatus;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@LanguageID", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = LanguageId;
            cmd.Parameters.Add(param);

            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }


        //b�t�n ilanlar� getir
        public DataTable GetAllJobs( int JobStatus, int LanguageID)
        {
            SqlConnection conn = DBHelper.getConnection();
            SqlCommand cmd = DBHelper.getSprocCmd("_GetAllJobs", conn);
            SqlDataAdapter da;
            SqlParameter param;
            DataTable dt = new DataTable();

            param = new SqlParameter("@JobStatus", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = JobStatus;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@LanguageID", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = LanguageID;
            cmd.Parameters.Add(param);

            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

    }
}
