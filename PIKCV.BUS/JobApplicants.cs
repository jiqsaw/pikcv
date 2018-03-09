using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace PIKCV.BUS
{
    public class JobApplicants
    {

        //Kullanýcýnýn Baþvurularýn Getir 
        public static DataTable GetUserJobApplicants(int UserID, PIKCV.COM.EnumDB.LanguageID LanguageID, string CompanyID, string PositionID, string ApplicationStatusID)
        {
            try {
                PIKCV.DAL.JobApplicants obj = new PIKCV.DAL.JobApplicants();
                return obj.GetUserJobApplicants(UserID, (int)LanguageID, CompanyID, PositionID, ApplicationStatusID);
            }
            catch (Exception) {
                throw;
            }
        }

        //Kullanýcýnýn Baþvuru Sayýsýný Getirir
        public static int GetUserJobApplicantsCount(int UserID)
        {
            try {
                PIKCV.DAL.JobApplicants objJobApplicants = new PIKCV.DAL.JobApplicants();
                objJobApplicants.Where.UserID.Value = UserID;
                objJobApplicants.Query.Load();
                return objJobApplicants.RowCount;
            }
            catch (Exception) {
                throw;
            }
            return 0;
        }

        //Baþvuru Sayýsýný Getirir
        public static DataTable GetUserApplicantCount(int UserID)
        {
            DataTable dt;
            try
            {
                PIKCV.DAL.JobApplicants objApplicant = new PIKCV.DAL.JobApplicants();
                dt = objApplicant.GetUserApplicantCount(UserID);
            }
            catch (Exception)
            {
                dt = null;
                throw;
            }
            return dt;
        }

        //Baþvuru Statüleri
        public static DataTable GetJobApplicationStates(PIKCV.COM.EnumDB.LanguageID LanguageID, bool IsDeleted)
        {
            DataTable dt;
            try
            {
                PIKCV.DAL.JobApplicationStates obj = new PIKCV.DAL.JobApplicationStates();
                dt = obj.GetJobApplicationStates((int)LanguageID, IsDeleted);
            }
            catch (Exception)
            {
                dt = null;
                throw;
            }
            return dt;
        }


        public static bool JobToApply(int UserID, int JobID) {
            PIKCV.DAO.TransactionMgr Tran = PIKCV.DAO.TransactionMgr.ThreadTransactionMgr();

            PIKCV.DAL.JobApplicants obj;
            PIKCV.DAL.JobApplicationStatusChanges objLog = new PIKCV.DAL.JobApplicationStatusChanges();
            try
            {
                obj = new PIKCV.DAL.JobApplicants();
                objLog = new PIKCV.DAL.JobApplicationStatusChanges();

                Tran.BeginTransaction();

                obj.Where.UserID.Value = UserID;
                obj.Where.JobID.Value = JobID;
                obj.Query.Load();

                if (obj.RowCount < 1) { obj.AddNew(); }

                obj.ApplicationDate = DateTime.Now;
                obj.UserID = UserID;
                obj.ApplicationStatusID = (int)PIKCV.COM.EnumDB.JobApplicationStates.NotExaminet;
                obj.JobID = JobID;
                obj.Save();
                int m_Identity = obj.JobApplicantID;

                objLog.AddNew();
                objLog.ApplicationDate = DateTime.Now;
                objLog.ApplicationStatusID = (int)PIKCV.COM.EnumDB.JobApplicationStates.NotExaminet;
                objLog.ApplicationTitle = " ";
                objLog.JobApplicantID = m_Identity;
                objLog.Save();

                Tran.CommitTransaction();

                return true;
            }
            catch (Exception)
            {
                Tran.RollbackTransaction();
                PIKCV.DAO.TransactionMgr.ThreadTransactionMgrReset();
                return false;
            }
        }

        public static bool ApplicantCtrl(int UserID, int JobID)
        {
            PIKCV.DAL.JobApplicants obj;
            try
            {
                obj = new PIKCV.DAL.JobApplicants();

                obj.Where.UserID.Value = UserID;
                obj.Where.JobID.Value = JobID;
                obj.Sort = "JobApplicantID DESC";
                obj.Query.Load();

                bool Result = false;
                if (obj.RowCount > 0)
                {
                    Result = true;
                    if (obj.ApplicationStatusID == (int)PIKCV.COM.EnumDB.JobApplicationStates.RecievedBack)
                    {
                        Result = false;
                    }
                }
                return Result;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ReceivedCtrl(int UserID, int JobApplicantID)
        {
            PIKCV.DAL.JobApplicants obj;
            try
            {
                obj = new PIKCV.DAL.JobApplicants();

                obj.LoadByPrimaryKey(JobApplicantID);

                if ((obj.RowCount < 1) || (obj.ApplicationStatusID == (int)PIKCV.COM.EnumDB.JobApplicationStates.RecievedBack)) { return true; }
                else return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static DataTable GetJobApplicantDetails(int JobApplicantID)
        {
            try
            {
                PIKCV.DAL.JobApplicants obj = new PIKCV.DAL.JobApplicants();
                obj.Where.JobApplicantID.Value = JobApplicantID;
                obj.Query.Load();
                return obj.DefaultView.Table;
            }
            catch (Exception)
            {
                return null;
            }

        }

        public static bool ChangeUserJobApplicantStatus(int JobApplicantID, PIKCV.COM.EnumDB.JobApplicationStates JobApplicantStates)
        {
            PIKCV.DAO.TransactionMgr Tran = PIKCV.DAO.TransactionMgr.ThreadTransactionMgr();
            try
            {
                PIKCV.DAL.JobApplicants objStatus = new PIKCV.DAL.JobApplicants();
                PIKCV.DAL.JobApplicationStatusChanges objStatusChanges = new PIKCV.DAL.JobApplicationStatusChanges();

                Tran.BeginTransaction();

                objStatus.LoadByPrimaryKey(JobApplicantID);
                objStatus.ApplicationStatusID = (int)JobApplicantStates;
                objStatus.Save();

                objStatusChanges.AddNew();
                objStatusChanges.JobApplicantID = JobApplicantID;
                objStatusChanges.ApplicationDate = DateTime.Now;
                objStatusChanges.ApplicationStatusID = (int)JobApplicantStates;
                objStatusChanges.ApplicationTitle = PIKCV.COM.Util.ReturnEmptyString("");
                objStatusChanges.Save();

                Tran.CommitTransaction();

                return true;
            }
            catch (Exception)
            {
                Tran.RollbackTransaction();
                PIKCV.DAO.TransactionMgr.ThreadTransactionMgrReset();
                return false;
            }

        }

        //Baþvuranlarý Getirir
        public static DataTable GetJobApplicantsSorted(string JobIds)
        {
            DataTable dt;
            try
            {
                PIKCV.DAL.JobApplicants objApplicant = new PIKCV.DAL.JobApplicants();
                dt = objApplicant.GetJobApplicantsSorted(JobIds);
            }
            catch (Exception)
            {
                dt = null;
                throw;
            }
            return dt;
        }

        //Þirketin Baþvurularýn Getir 
        public static DataTable GetCompanyJobApplicants(int JobID, PIKCV.COM.EnumDB.LanguageID LanguageID, string ApplicationStatusID)
        {
            try
            {
                PIKCV.DAL.JobApplicants obj = new PIKCV.DAL.JobApplicants();
                return obj.GetCompanyJobApplicants(JobID, (int)LanguageID, ApplicationStatusID);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
