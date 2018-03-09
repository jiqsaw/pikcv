using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections;

namespace PIKCV.BUS
{
    public class Test
    {
        //Kullanýcý için Test Oluþtur
        public static DataTable GetRandomTest(PIKCV.COM.EnumDB.TestTypeCode TestTypeCode)
        {
            try
            {
                PIKCV.DAL.TestQuestions obj = new PIKCV.DAL.TestQuestions();
                return obj.GetRandomTest((int)TestTypeCode);
            }
            catch (Exception)
            {
                throw;
            }
            return null;
        }

        //Test Toplam Skoru Bilgileri
        public static DataTable GetTestTotalScoreInfo(float TotalPoint, PIKCV.COM.EnumDB.LanguageID LanguageID, PIKCV.COM.EnumDB.EmployeeTypes EmployeeType)
        {
            try
            {
                PIKCV.DAL.TestTotalScoreScale obj = new PIKCV.DAL.TestTotalScoreScale();
                return obj.GetTestTotalScoreInfo(TotalPoint, (int)LanguageID, (int)EmployeeType);
            }
            catch (Exception)
            {
                throw;
            }
            return null;
        }

        public static bool SaveUserTestResults(int UserID, PIKCV.COM.EnumDB.TestTypeCode TestTypeCode, DataTable dtResults) {
            
            PIKCV.DAO.TransactionMgr Tran = PIKCV.DAO.TransactionMgr.ThreadTransactionMgr();

            PIKCV.DAL.UserTestResults obj = new PIKCV.DAL.UserTestResults();

            obj.Where.UserID.Value = UserID;
            obj.Query.Load();
            if (!obj.EOF) { return false; }
            try
            {
                Tran.BeginTransaction();

                obj = new PIKCV.DAL.UserTestResults();
                PIKCV.DAL.UserCVs objUserCV = new PIKCV.DAL.UserCVs();
                objUserCV.Where.UserID.Value = UserID;
                objUserCV.Query.Load();

                objUserCV.TestMatDate = DateTime.Now;
                objUserCV.Save();

                foreach (DataRow dr in dtResults.Rows) {
                    obj.AddNew();
                    obj.TestTypeCode = (int)TestTypeCode;
                    obj.UserID = UserID;
                    obj.QuestionNo = Convert.ToInt32(dr["QuestionNo"]);
                    obj.TestQuestionID = Convert.ToInt32(dr["TestQuestionID"]);
                    obj.TestAnswerID = Convert.ToInt32(dr["TestAnswerID"]);
                    obj.Save();
                }

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

        //Yetkinlik Testini Getir
        public static DataTable GetPerfectionTest(PIKCV.COM.EnumDB.EmployeeTypes EmployeeType, PIKCV.COM.EnumDB.EmployeeTypes BothTestType, PIKCV.COM.EnumDB.LanguageID LanguageID)
        {
            try
            {
                PIKCV.DAL.TestPerfection obj = new PIKCV.DAL.TestPerfection();
                return obj.GetPerfectionTest((int)EmployeeType, (int)BothTestType, (int)LanguageID);
            }
            catch (Exception)
            {
                throw;
            }
            return null;
        }

        public static bool SaveUserTestPerfection(int UserID, DataTable dtResults) {
            
            PIKCV.DAO.TransactionMgr Tran = PIKCV.DAO.TransactionMgr.ThreadTransactionMgr();

            PIKCV.DAL.UserTestPerfectionResults obj = new PIKCV.DAL.UserTestPerfectionResults();
            obj.Where.UserID.Value = UserID;
            obj.Query.Load();
            if (!obj.EOF) { return false; }
            try
            {
                obj = new PIKCV.DAL.UserTestPerfectionResults();

                Tran.BeginTransaction();

                obj = new PIKCV.DAL.UserTestPerfectionResults();
                PIKCV.DAL.UserCVs objUserCV = new PIKCV.DAL.UserCVs();
                objUserCV.Where.UserID.Value = UserID;
                objUserCV.Query.Load();

                objUserCV.TestYetDate = DateTime.Now;
                objUserCV.Save();

                foreach (DataRow dr in dtResults.Rows) {
                    obj.AddNew();
                    obj.UserID = UserID;
                    obj.TestPerfectionID = Convert.ToInt32(dr["TestPerfectionID"]);
                    obj.AnswerPoint = Convert.ToInt32(dr["AnswerPoint"]);
                    obj.Save();
                }

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

        public static bool UserTestPerfectionCtrl(int UserID) {
            PIKCV.DAL.UserTestPerfectionResults obj = new PIKCV.DAL.UserTestPerfectionResults();
            obj.Where.UserID.Value = UserID;
            obj.Query.Load();
            if (obj.RowCount < 1) {
                return true;
            }
            return false;
        }

        public static bool UserTestCtrl(int UserID)
        {
            PIKCV.DAL.UserTestResults obj = new PIKCV.DAL.UserTestResults();
            obj.Where.UserID.Value = UserID;
            obj.Query.Load();
            if (obj.RowCount < 1)
            {
                return true;
            }
            return false;
        }

        public static string GetTestGroupName(int TestGroupID)
        {
            PIKCV.DAL.TestGroups_ML obj = new PIKCV.DAL.TestGroups_ML();
            obj.Where.TestGroupID.Value = TestGroupID;
            obj.Query.Load();
            if (obj.RowCount > 0)
            {
                return obj.GroupName;
            }
            return String.Empty;
        }

        public static string GetTestPerfectionName(int PerfectionID)
        {
            PIKCV.DAL.Perfection_ML obj = new PIKCV.DAL.Perfection_ML();
            obj.Where.PerfectionID.Value = PerfectionID;
            obj.Query.Load();
            if (obj.RowCount > 0)
            {
                return obj.PerfectionName;
            }
            return String.Empty;
        }

        //Test skorunu getir
        public static DataTable GetTestScore(PIKCV.COM.EnumDB.TestTypeCode TestTypeCode, int UserID, 
            PIKCV.COM.EnumDB.LanguageID LanguageID, PIKCV.COM.EnumDB.EmployeeTypes EmployeeTypeCode)
        {
            try
            {
                PIKCV.DAL.TestAnswers obj = new PIKCV.DAL.TestAnswers();
                return obj.GetTestScore((int)TestTypeCode, UserID, (int)LanguageID, (int)EmployeeTypeCode);
            }
            catch (Exception)
            {
                throw;
            }
            return null;
        }

        public static DataTable GetTestPerfectionScore(int UserID)
        {
            try
            {
                PIKCV.DAL.TestPerfection obj = new PIKCV.DAL.TestPerfection();
                return obj.GetTestPerfectionScore(UserID);
            }
            catch (Exception)
            {
                throw;
            }
            return null;
        }

        public static DataTable GetTestPerfectionResult(PIKCV.COM.EnumDB.EmployeeTypes EmployeeTypeCode, PIKCV.COM.EnumDB.LanguageID LanguageID, int PerfectionID, int TestLevelID) {
            try
            {
                PIKCV.DAL.TestPerfection obj = new PIKCV.DAL.TestPerfection();
                return obj.GetTestPerfectionResult((int)EmployeeTypeCode, (int)LanguageID, PerfectionID, TestLevelID);
            }
            catch (Exception)
            {
                throw;
            }
            return null;
        }
    }
}
