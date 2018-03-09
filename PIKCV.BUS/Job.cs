using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using CARETTA.COM;
using System.Collections;

namespace PIKCV.BUS
{
    public class Job
    {
        public int SaveJobType(int JobID, int CompanyID, string JobListType,
            string EmployeeType, bool IsMartyrRelative, bool IsDisabled, bool IsOldConvicted, bool IsTerrorWronged)
        {
            try
            {
                PIKCV.DAL.Jobs obj = new PIKCV.DAL.Jobs();
                if (JobID > 0) { obj.LoadByPrimaryKey(JobID); }
                else
                {
                    obj.AddNew();
                    obj.IsDisabled = false;
                    obj.JobStatus = (int)PIKCV.COM.EnumDB.JobStatus.Deleted;
                    obj.IsCompanyNameHidden = false;
                    obj.JobDescription = PIKCV.COM.Util.ReturnEmptyString(string.Empty);
                    obj.JobTitle = PIKCV.COM.Util.ReturnEmptyString(string.Empty);
                    obj.LabouringTypeID = 0;
                    obj.PositionID = 0;
                    obj.PositionIDQuality = 0;
                    obj.Gender = (int)PIKCV.COM.EnumDB.SexCode.Both;
                    obj.NumberOfWorkers = 0;
                    obj.AgeRange = 0;
                    obj.StartDate = DateTime.Now;
                    obj.EndDate = DateTime.Now.AddDays(30);
                    obj.WorkExprerience = 0;
                    obj.PageStatusCode = 0;
                }
                obj.CompanyID = CompanyID;
                obj.JobListType = int.Parse(JobListType);
                obj.UserTypeID = int.Parse(EmployeeType);
                obj.IsMartyrRelative = IsMartyrRelative;
                obj.IsDisabled = IsDisabled;
                obj.IsOldConvicted = IsOldConvicted;
                obj.IsMartyrRelative = IsMartyrRelative;
                obj.IsTerrorWronged = IsTerrorWronged;
                obj.ReferenceNumber = Util.CreateRandomNumber(15);
                obj.ModifyDate = DateTime.Now;
                obj.Save();
                return obj.JobID;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public DataTable GetJobInfo(int JobID)
        {
            PIKCV.DAL.Jobs objJob = new PIKCV.DAL.Jobs();
            objJob.Where.JobID.Value = JobID;
            objJob.Query.Load();
            return objJob.DefaultView.Table;
        }

        public int SaveJobPositionDefinition(int JobID, int NumberOfWorkers, ArrayList arrSectors, int PositionID,
            ArrayList Countries, ArrayList Cities, string JobDescription)
        {
            try
            {
                PIKCV.DAL.Jobs obj = new PIKCV.DAL.Jobs();
                obj.LoadByPrimaryKey(JobID);
                obj.NumberOfWorkers = NumberOfWorkers;
                obj.PositionID = PositionID;
                obj.JobDescription = JobDescription;
                obj.ModifyDate = DateTime.Now;
                obj.Save();
                PIKCV.DAL.JobSectors objJobSector = new PIKCV.DAL.JobSectors();
                objJobSector.DeleteAllJobSectors(JobID);
                PIKCV.DAL.JobPlaces objJobPlace = new PIKCV.DAL.JobPlaces();
                objJobPlace.DeleteAllJobPlaces(JobID);
                for (int i = 0; i < arrSectors.Count; i++)
                {
                    SaveJobSectors(obj.JobID, Convert.ToInt32(arrSectors[i]));
                }
                for (int i = 0; i < Countries.Count; i++)
                {
                    SaveJobCountries(obj.JobID, Convert.ToInt32(Countries[i]), PIKCV.COM.EnumDB.Places.CountriesParentID);
                }
                for (int i = 0; i < Cities.Count; i++)
                {
                    SaveJobCountries(obj.JobID, Convert.ToInt32(Cities[i]), PIKCV.COM.EnumDB.Places.TurkeyPlaceID);
                }

                return obj.JobID;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public void SaveJobSectors(int JobID, int SectorID)
        {
            PIKCV.DAL.JobSectors obj = new PIKCV.DAL.JobSectors();
            obj.AddNew();
            obj.JobID = JobID;
            obj.SectorID = SectorID;
            obj.Save();
        }

        public void SaveJobCountries(int JobID, int PlaceID, PIKCV.COM.EnumDB.Places PlacesTypeCode)
        {
            PIKCV.DAL.JobPlaces obj = new PIKCV.DAL.JobPlaces();
            obj.AddNew();
            obj.JobID = JobID;
            obj.PlaceID = PlaceID;
            obj.PlaceTypeCode = (int)PlacesTypeCode;
            obj.Save();
        }

        public DataTable GetJobSectorNames(int JobID)
        {
            PIKCV.DAL.JobSectors obj = new PIKCV.DAL.JobSectors();
            return obj.GetJobSectors(JobID);
        }

        public DataTable GetJobPlaceNames(int JobID, PIKCV.COM.EnumDB.Places Place)
        {
            PIKCV.DAL.JobPlaces obj = new PIKCV.DAL.JobPlaces();
            return obj.GetJobPlaces(JobID, (int)Place, (int)PIKCV.COM.EnumDB.LanguageID.Turkish);
        }

        public bool SaveJobEducationLevelsAll(int JobID,ArrayList arrEducationLevel, ArrayList arrForeignLanguages, ArrayList arrComputerKnowledge)
        {
            try
            {
                PIKCV.DAL.Jobs obj = new PIKCV.DAL.Jobs();
                obj.LoadByPrimaryKey(JobID);
                obj.ModifyDate = DateTime.Now;
                obj.Save();
                PIKCV.DAL.JobEducationLevels objJobEducationLevel = new PIKCV.DAL.JobEducationLevels();
                objJobEducationLevel.DeleteAllJobEducationLevels(JobID);
                PIKCV.DAL.JobForeignLanguages objJobForeignLanguages = new PIKCV.DAL.JobForeignLanguages();
                objJobForeignLanguages.DeleteAllJobForeignLanguages(JobID);
                PIKCV.DAL.JobComputerKnowledges objJobComputerKnowledge = new PIKCV.DAL.JobComputerKnowledges();
                objJobComputerKnowledge.DeleteAllJobComputerKnowledges(JobID);
                for (int i = 0; i < arrEducationLevel.Count; i++)
                {
                    SaveJobEducationLevel(JobID, Convert.ToInt32(arrEducationLevel[i]));
                }
                for (int i = 0; i < arrForeignLanguages.Count; i++)
                {
                    SaveJobForeignLanguages(JobID, Convert.ToInt32(arrForeignLanguages[i]));
                }
                for (int i = 0; i < arrComputerKnowledge.Count; i++)
                {
                    SaveJobComputerKnowledge(JobID, Convert.ToInt32(arrComputerKnowledge[i]));
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void SaveJobEducationLevel(int JobID, int EducationLevelID)
        {
            PIKCV.DAL.JobEducationLevels obj = new PIKCV.DAL.JobEducationLevels();
            obj.AddNew();
            obj.JobID = JobID;
            obj.EducationLevelID = EducationLevelID;
            obj.Save();
        }

        public void SaveJobForeignLanguages(int JobID, int ForeignLanguageID)
        {
            PIKCV.DAL.JobForeignLanguages obj = new PIKCV.DAL.JobForeignLanguages();
            obj.AddNew();
            obj.JobID = JobID;
            obj.ForeignLanguageID = ForeignLanguageID;
            obj.Save();
        }

        public void SaveJobComputerKnowledge(int JobID, int ComputerKnowledgeID)
        {
            PIKCV.DAL.JobComputerKnowledges obj = new PIKCV.DAL.JobComputerKnowledges();
            obj.AddNew();
            obj.JobID = JobID;
            obj.ComputerKnowledgeTypeID = ComputerKnowledgeID;
            obj.Save();
        }

        public DataTable GetJobEducationLevels(int JobID, PIKCV.COM.EnumDB.LanguageID LanguageID)
        {
            PIKCV.DAL.JobEducationLevels obj = new PIKCV.DAL.JobEducationLevels();
            return obj.GetJobEducationLevels(JobID, (int)LanguageID);
        }

        public DataTable GetJobForeignLanguages(int JobID, PIKCV.COM.EnumDB.LanguageID LanguageID)
        {
            PIKCV.DAL.JobForeignLanguages obj = new PIKCV.DAL.JobForeignLanguages();
            return obj.GetJobForeignLanguages(JobID, (int)LanguageID);
        }

        public DataTable GetJobComputerKnowledge(int JobID, PIKCV.COM.EnumDB.LanguageID LanguageID)
        {
            PIKCV.DAL.JobComputerKnowledges obj = new PIKCV.DAL.JobComputerKnowledges();
            return obj.GetJobComputerKnowledge(JobID, (int)LanguageID);
        }

        public bool SaveJobSeekingQualityAll(int JobID, ArrayList arrQualitySectors, ArrayList arrPerfection, ArrayList arrPositions, string Gender, string AgeRange, string LabouringType)
        {
            try
            {
                PIKCV.DAL.Jobs obj = new PIKCV.DAL.Jobs();
                obj.LoadByPrimaryKey(JobID);
                obj.PositionIDQuality = 0;
                obj.Gender = int.Parse(Gender);
                obj.AgeRange = int.Parse(AgeRange);
                obj.LabouringTypeID = int.Parse(LabouringType);
                obj.ModifyDate = DateTime.Now;
                obj.Save();
                PIKCV.DAL.JobQualitySectors objJobQualitySectors = new PIKCV.DAL.JobQualitySectors();
                objJobQualitySectors.DeleteAllJobQualitySectors(JobID);
                PIKCV.DAL.JobPerfection objJobPerfection = new PIKCV.DAL.JobPerfection();
                objJobPerfection.DeleteAllJobPerfection(JobID);

                PIKCV.DAL.JobQualityPositions objJobQualityPositions = new PIKCV.DAL.JobQualityPositions();
                objJobQualityPositions.Where.JobID.Value = JobID;
                objJobQualityPositions.Query.Load();
                objJobQualityPositions.DeleteAll();
                objJobQualityPositions.Save();

                for (int i = 0; i < arrQualitySectors.Count; i++)
                {
                    SaveJobQualitySector(JobID, Convert.ToInt32(arrQualitySectors[i]));
                }
                for (int i = 0; i < arrPerfection.Count; i++)
                {
                    SaveJobPerfection(JobID, Convert.ToInt32(arrPerfection[i]));
                }
                for (int i = 0; i < arrPositions.Count; i++)
                {
                    SaveJobPositions(JobID, Convert.ToInt32(arrPositions[i]));
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataTable GetJobQualitySectorNames(int JobID)
        {
            PIKCV.DAL.JobQualitySectors obj = new PIKCV.DAL.JobQualitySectors();
            return obj.GetJobQualitySectors(JobID);
        }

        public DataTable GetJobQualityPositionNames(int JobID)
        {
            PIKCV.DAL.JobQualityPositions obj = new PIKCV.DAL.JobQualityPositions();
            return obj.GetJobQualityPositions(JobID);
        }

        public DataTable GetJobPerfection(int JobID)
        {
            PIKCV.DAL.JobPerfection obj = new PIKCV.DAL.JobPerfection();
            return obj.GetJobPerfection(JobID);
        }

        public void SaveJobQualitySector(int JobID, int QualitySectorID)
        {
            PIKCV.DAL.JobQualitySectors obj = new PIKCV.DAL.JobQualitySectors();
            obj.AddNew();
            obj.JobID = JobID;
            obj.SectorID = QualitySectorID;
            obj.Save();
        }

        public void SaveJobPerfection(int JobID, int PerfecitonID)
        {
            PIKCV.DAL.JobPerfection obj = new PIKCV.DAL.JobPerfection();
            obj.AddNew();
            obj.JobID = JobID;
            obj.PerfectionID = PerfecitonID;
            obj.Save();
        }

        public void SaveJobPositions(int JobID, int PositionID)
        {
            PIKCV.DAL.JobQualityPositions obj = new PIKCV.DAL.JobQualityPositions();
            obj.AddNew();
            obj.JobID = JobID;
            obj.PositionID = PositionID;
            obj.Save();
        }

        public bool DeleteJobChoices(int JobID)
        {
            try
            {
                PIKCV.DAL.JobChoiceEducations objEducation = new PIKCV.DAL.JobChoiceEducations();
                objEducation.DeleteAllJobQualitySectors(JobID);
                PIKCV.DAL.JobChoiceEmployment objEmployment = new PIKCV.DAL.JobChoiceEmployment();
                objEmployment.DeleteAllJobQualitySectors(JobID);
                PIKCV.DAL.JobChoiceForeignLanguage objForeignLanguages = new PIKCV.DAL.JobChoiceForeignLanguage();
                objForeignLanguages.DeleteAllJobQualitySectors(JobID);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public void SaveJobChoiceEducationLevel(int JobID, string EducationLevelID, string Points)
        {
            PIKCV.DAL.JobChoiceEducations obj = new PIKCV.DAL.JobChoiceEducations();
            obj.AddNew();
            obj.JobID = JobID;
            obj.EducationLevelID = int.Parse(EducationLevelID);
            obj.Points = int.Parse(Points);
            obj.Save();
        }

        public void SaveJobChoiceEmployment(int JobID, string PositionID, string Points)
        {
            PIKCV.DAL.JobChoiceEmployment obj = new PIKCV.DAL.JobChoiceEmployment();
            obj.AddNew();
            obj.JobID = JobID;
            obj.PositionID = int.Parse(PositionID);
            obj.Points = int.Parse(Points);
            obj.Save();
        }

        public void SaveJobChoiceForeignLanguages(int JobID, string ForeignLanguageID, string ReadLevel, string WriteLevel, string SpeakLevel, string Points)
        {
            PIKCV.DAL.JobChoiceForeignLanguage obj = new PIKCV.DAL.JobChoiceForeignLanguage();
            obj.AddNew();
            obj.JobID = JobID;
            obj.ForeignLanguageID = int.Parse(ForeignLanguageID);
            obj.ReadLevel = int.Parse(ReadLevel);
            obj.WriteLevel = int.Parse(WriteLevel);
            obj.SpeakLevel = int.Parse(SpeakLevel);
            obj.Points = int.Parse(Points);
            obj.Save();
        }

        public DataTable GetJobChoiceEducationLevel(int JobID)
        {
            PIKCV.DAL.JobChoiceEducations obj = new PIKCV.DAL.JobChoiceEducations();
            obj.Where.JobID.Value = JobID;
            obj.Query.Load();
            return obj.DefaultView.Table;
        }

        public DataTable GetJobChoiceEmployment(int JobID)
        {
            PIKCV.DAL.JobChoiceEmployment obj = new PIKCV.DAL.JobChoiceEmployment();
            obj.Where.JobID.Value = JobID;
            obj.Query.Load();
            return obj.DefaultView.Table;
        }

        public DataTable GetJobChoiceForeignLanguages(int JobID)
        {
            PIKCV.DAL.JobChoiceForeignLanguage obj = new PIKCV.DAL.JobChoiceForeignLanguage();
            obj.Where.JobID.Value = JobID;
            obj.Query.Load();
            return obj.DefaultView.Table;
        }

        public int SaveApproval(int CompanyID, int JobID, int JobStatus, bool IsCompanyNameHidden, ref int NewCredit)
        {
            PIKCV.DAO.TransactionMgr Tran = PIKCV.DAO.TransactionMgr.ThreadTransactionMgr();

            try
            {
                Tran.BeginTransaction();

                PIKCV.DAL.Jobs obj = new PIKCV.DAL.Jobs();
                obj.LoadByPrimaryKey(JobID);

                if (JobStatus != (int)PIKCV.COM.EnumDB.JobStatus.Draft)
                {
                    //ilanýn pik kredisini þirketten düþelim
                    PIKCV.DAL.OrderTypes objOrderType = new PIKCV.DAL.OrderTypes();
                    objOrderType.LoadByPrimaryKey(obj.JobListType);

                    int CreditsSpend = 0;

                    PIKCV.COM.EnumDB.EmployeeTypes EmployeeTypes = (PIKCV.COM.EnumDB.EmployeeTypes)(obj.UserTypeID);
                    switch (EmployeeTypes)
                    {
                        case PIKCV.COM.EnumDB.EmployeeTypes.Pikpool:
                            CreditsSpend = objOrderType.PikPoolCredit;
                            break;
                        case PIKCV.COM.EnumDB.EmployeeTypes.Goodpik:
                            CreditsSpend = objOrderType.GoodPikCredit;
                            break;
                    }


                    PIKCV.DAL.Companies objCompany = new PIKCV.DAL.Companies();
                    objCompany.LoadByPrimaryKey(CompanyID);

                    NewCredit = objCompany.Credits - CreditsSpend;
                    objCompany.Credits = NewCredit;
                    objCompany.Save();

                    PIKCV.DAL.Orders objOrders = new PIKCV.DAL.Orders();
                    objOrders.AddNew();
                    objOrders.CompanyID = CompanyID;
                    objOrders.OrderDate = DateTime.Now;
                    objOrders.OrderTypeID = obj.JobListType;
                    objOrders.ProcessTypeCode = (int)PIKCV.COM.EnumDB.OrderProcessTypeCode.paid;
                    objOrders.IsConfirmed = true;
                    objOrders.Price = 0;
                    objOrders.TotalCreditsUsed = CreditsSpend;
                    objOrders.Save();
                    int LastOrderID = objOrders.OrderID;

                    PIKCV.DAL.OrderLineItems objOL = new PIKCV.DAL.OrderLineItems();
                    objOL.AddNew();
                    objOL.CreditUsed = CreditsSpend;
                    objOL.JobID = JobID;
                    objOL.OrderID = LastOrderID;
                    objOL.Price = 0;
                    objOL.UserID = 0;
                    objOL.Save();

                    //ilanýn pik kredisi düþürüldü þimdi ilaný kaydedelim
                }
                obj.JobStatus = JobStatus;
                obj.IsCompanyNameHidden = IsCompanyNameHidden;
                obj.ModifyDate = DateTime.Now;
                obj.Save();

                Tran.CommitTransaction();
                return obj.JobID;
            }
            catch (Exception)
            {
                Tran.RollbackTransaction();
                PIKCV.DAO.TransactionMgr.ThreadTransactionMgrReset();
                return 0;
            }
        }

        public DataTable GetJobs(int UserID, string Keyword, string Sectors, string Cities, string Positions, PIKCV.COM.EnumDB.JobStatus JobStatus, 
                                string Companies, string EducationLevels, string LabouringTypes, PIKCV.COM.EnumDB.AgeRange AgeRange, DateTime JobDate, bool CustomJobs,
                                int PositionID, int CompanyID, int Status)
        {
            try
            {
                PIKCV.DAL.Jobs obj = new PIKCV.DAL.Jobs();
                return obj.GetJobs(UserID, Keyword, Sectors, Cities, Positions, (int)JobStatus, Companies, EducationLevels, LabouringTypes, (int)AgeRange,
                                  (int)PIKCV.COM.EnumDB.AgeRange.age_All, JobDate, CustomJobs, PositionID, CompanyID, Status);
            }
            catch (Exception) { throw; }
        }

        //Ana Sayfadaki Ýlk 20 ve Ýkinci 20 ilanlarýný getir
        public static DataTable GetMainJobs(PIKCV.COM.EnumDB.JobStatus JobStatus)
        {
            PIKCV.DAL.Jobs obj = new PIKCV.DAL.Jobs();
            try {
                return obj.GetMainJobs((int)JobStatus);
            }
            catch (Exception) {
                return null;
                //throw;
            }
        }

        //Ana Sayfadaki Ýlk 20 ve Ýkinci 20 ilanlarýný getir
        public static DataTable GetUserCustomJobs(int UserID, PIKCV.COM.EnumDB.LanguageID LanguageID)
        {
            PIKCV.DAL.Jobs obj = new PIKCV.DAL.Jobs();
            try
            {
                return obj.GetUserCustomJobs(UserID, (int)LanguageID, (int)PIKCV.COM.EnumDB.JobStatus.Active);
            }
            catch (Exception)
            {
                return null;
                //throw;
            }
        }

        public static DataTable GetJobDetail(int JobID)
        {
            try {
                PIKCV.DAL.Jobs obj = new PIKCV.DAL.Jobs();
                return obj.GetJobDetail(JobID);
            }
            catch (Exception) {
                throw;
            }
        }

        public static DataTable GetCompanyJobs(int CompanyID, PIKCV.COM.EnumDB.JobStatus JobStatus, PIKCV.COM.EnumDB.LanguageID LanguageID)
        {
            DataTable dt;
            try
            {
                PIKCV.DAL.Jobs obj = new PIKCV.DAL.Jobs();
                dt = obj.GetCompanyJobs(CompanyID, (int)JobStatus, (int)LanguageID);
            }
            catch (Exception)
            {
                dt = null;
                throw;
            }
            return dt;
        }

        public DataTable GetAllJobs(PIKCV.COM.EnumDB.JobStatus JobStatus, PIKCV.COM.EnumDB.LanguageID LanguageID)
        {
            DataTable dt;
            try
            {
                PIKCV.DAL.Jobs obj = new PIKCV.DAL.Jobs();
                dt = obj.GetAllJobs((int)JobStatus, (int)LanguageID);
            }
            catch (Exception)
            {
                dt = null;
                throw;
            }
            return dt;
        }

        

        public static DataTable GetCompanyJobsAll(int CompanyID, PIKCV.COM.EnumDB.JobStatus JobStatus, PIKCV.COM.EnumDB.LanguageID LanguageID)
        {
            return GetCompanyJobsAll(CompanyID, JobStatus, LanguageID, "%");
        }

        public static DataTable GetCompanyJobsAll(int CompanyID, PIKCV.COM.EnumDB.JobStatus JobStatus, PIKCV.COM.EnumDB.LanguageID LanguageID, string PositionID)
        {
            DataTable dt;
            try
            {
                PIKCV.DAL.Jobs obj = new PIKCV.DAL.Jobs();
                dt = obj.GetCompanyJobsAll(CompanyID, (int)JobStatus, (int)LanguageID, PositionID);
            }
            catch (Exception)
            {
                dt = null;
                throw;
            }
            return dt;
        }

        public int ChangeJobStatus(int JobID, PIKCV.COM.EnumDB.JobStatus JobStatus)
        {
            try
            {
                PIKCV.DAL.Jobs obj = new PIKCV.DAL.Jobs();
                obj.LoadByPrimaryKey(JobID);
                obj.JobStatus = (int)JobStatus;
                obj.Save();
                return obj.JobID;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int ChangeJobStatus(int CompanyID, int JobID, PIKCV.COM.EnumDB.JobStatus NewJobStatus, int CreditsToDecrease, int JobListType, DateTime EndDate, PIKCV.COM.EnumDB.JobStatus CurrentJobStatus)
        {
            PIKCV.DAO.TransactionMgr Tran = PIKCV.DAO.TransactionMgr.ThreadTransactionMgr();

            try
            {
                Tran.BeginTransaction();
                PIKCV.DAL.Jobs obj = new PIKCV.DAL.Jobs();
                obj.LoadByPrimaryKey(JobID);

                if ((CurrentJobStatus == PIKCV.COM.EnumDB.JobStatus.Draft) || (EndDate < DateTime.Now))
                {
                    PIKCV.DAL.Orders objOrders = new PIKCV.DAL.Orders();
                    objOrders.AddNew();
                    objOrders.CompanyID = CompanyID;
                    objOrders.OrderDate = DateTime.Now;
                    objOrders.OrderTypeID = JobListType;
                    objOrders.ProcessTypeCode = (int)PIKCV.COM.EnumDB.OrderProcessTypeCode.paid;
                    objOrders.IsConfirmed = true;
                    objOrders.Price = 0;
                    objOrders.TotalCreditsUsed = CreditsToDecrease;
                    objOrders.Save();
                    int LastOrderID = objOrders.OrderID;

                    PIKCV.DAL.OrderLineItems objOL = new PIKCV.DAL.OrderLineItems();
                    objOL.AddNew();
                    objOL.CreditUsed = CreditsToDecrease;
                    objOL.JobID = JobID;
                    objOL.OrderID = LastOrderID;
                    objOL.Price = 0;
                    objOL.UserID = 0;
                    objOL.Save();

                    PIKCV.DAL.Companies objCompany = new PIKCV.DAL.Companies();
                    objCompany.LoadByPrimaryKey(CompanyID);
                    objCompany.Credits = objCompany.Credits - CreditsToDecrease;
                    objCompany.Save();

                    obj.StartDate = DateTime.Now;
                    obj.EndDate = DateTime.Now.AddDays(30);
                }

                obj.JobStatus = (int)NewJobStatus;
                obj.Save();

                Tran.CommitTransaction();

                return obj.JobID;
            }
            catch (Exception)
            {

                Tran.RollbackTransaction();
                PIKCV.DAO.TransactionMgr.ThreadTransactionMgrReset();
                return 0;
            }
        }

        public static DataTable GetCompanyAllJobs(int CompanyID, PIKCV.COM.EnumDB.JobStatus JobStatus,PIKCV.COM.EnumDB.LanguageID LanguageId)
        {
            DataTable dt;
            try
            {
                PIKCV.DAL.Jobs obj = new PIKCV.DAL.Jobs();
                dt = obj.GetCompanyAllJobs(CompanyID, (int)JobStatus, (int)LanguageId);
            }
            catch (Exception ex)
            {
                string s = ex.Message;
                dt = null;
                throw;
            }

            return dt;
        }

        public static DataSet GetJobStatistics(int JobID, int LanguageID, PIKCV.COM.EnumDB.SexCode SexCode)
        {
            PIKCV.DAL.Jobs obj = new PIKCV.DAL.Jobs();
            return obj.GetJobStatictics(JobID, LanguageID, (int)SexCode);
        }
    
    }
}
