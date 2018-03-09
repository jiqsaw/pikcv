using System;
using System.Collections.Generic;
using System.Text;
using CARETTA.COM;
using System.Data;
using System.Collections;

namespace PIKCV.BUS
{
    public class UserCVs
    {
        public bool SavePersonalInfo(int UserID, int NationID, DateTime BirthDate, int BirthPlaceID, string OtherPlaceName, 
            PIKCV.COM.EnumDB.SexCode SexCode, int MaritalStatusID, int MilitaryStatusID, int MilitaryYear, bool IsDisabled, bool IsOldConvicted,
            bool IsMartyrRelative, bool IsTerrorWronged, string ChronicIllness)
        {
            try
            {
                PIKCV.DAL.UserCVs obj = new PIKCV.DAL.UserCVs();
                obj.Where.UserID.Value = UserID;
                obj.Query.Load();
                if (obj.RowCount < 1) { 
                    obj.AddNew();
                    obj.UserID = UserID;
                    obj.AlternateContactPhone = " ";
                    obj.AlternateContactName = " ";
                    obj.ContactEmail = " ";
                    obj.CreateDate = DateTime.Now;
                    obj.DriverLicenseTypeID = 5;
                    obj.DriverLicenseYear = 0;
                    obj.GSM = " ";
                    obj.GSM2 = " ";
                    obj.HasTravelDifficulty = false;
                    obj.EducationTypeCode = (int)PIKCV.COM.EnumDB.EducationTypes.Unknown;
                    obj.HighSchoolName = " ";
                    obj.HighSchoolStatusID = 0;
                    obj.HighSchoolTypeID = 0;
                    obj.HomeAddress = " ";
                    obj.HomeCityID = -1;
                    obj.HomeCountryID = -1;
                    obj.OtherHomeCityName = " ";
                    obj.HomePhone = " ";
                    obj.IsSmoking = false;
                    obj.MiddleSchoolStatusID = 0;
                    obj.MiddleSchoolName = " ";
                    obj.TotalWorkExperience = -1;
                    obj.PhotoFileName = " ";
                    obj.SeriousSickness = " ";
                    obj.VideoFileName = " ";
                    obj.BusinessPhone = " ";
                    obj.CourseAndCertificates = " ";
                    obj.Interests = " ";
                    obj.Clubs = " ";
                    obj.CvFocusCode = (int)PIKCV.COM.EnumDB.CVFocusCode.ContactInfo;
                }

                obj.NationID = NationID;
                obj.BirthDate = BirthDate;
                obj.BirthPlaceID = BirthPlaceID;
                obj.OtherBirthPlaceName = PIKCV.COM.Util.ReturnEmptyString(Util.ReplaceStrForDB(OtherPlaceName));
                obj.SexCode = (int)SexCode;
                obj.MaritalStatusID = MaritalStatusID;
                obj.MilitaryStatusID = MilitaryStatusID;
                obj.MilitaryYear = MilitaryYear;
                obj.IsDisabled = IsDisabled;
                obj.IsOldConvicted = IsOldConvicted;
                obj.IsMartyrRelative = IsMartyrRelative;
                obj.IsTerrorWronged = IsTerrorWronged;
                obj.ChronicIllness = PIKCV.COM.Util.ReturnEmptyString(Util.ReplaceStrForDB(ChronicIllness));

                obj.ModifyDate = DateTime.Now;

                obj.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SaveContactInfo(int UserID, int HomeCountryID, int HomeCityID, string OtherHomeCity , string Address, string HomePhone, string BusinessPhone, 
            string GSM, string GSM2, string ContactEmail, string AlternateContactName, string AltenateContactPhone)
        {

                try {
                    PIKCV.DAL.UserCVs obj = new PIKCV.DAL.UserCVs();
                    obj.Where.UserID.Value = UserID;
                    obj.Query.Load();
                    if (obj.RowCount < 1) { return false; }

                    obj.HomeCountryID = HomeCountryID;
                    obj.HomeCityID = HomeCityID;
                    obj.OtherHomeCityName = PIKCV.COM.Util.ReturnEmptyString(Util.ReplaceStrForDB(OtherHomeCity));
                    obj.HomeAddress = PIKCV.COM.Util.ReturnEmptyString(Util.ReplaceStrForDB(Address));
                    obj.HomePhone = PIKCV.COM.Util.ReturnEmptyString(Util.ReplaceStrForDB(HomePhone));
                    obj.BusinessPhone = PIKCV.COM.Util.ReturnEmptyString(Util.ReplaceStrForDB(BusinessPhone));
                    obj.GSM = PIKCV.COM.Util.ReturnEmptyString(Util.ReplaceStrForDB(GSM.Trim()));
                    obj.GSM2 = PIKCV.COM.Util.ReturnEmptyString(Util.ReplaceStrForDB(GSM2.Trim()));
                    obj.ContactEmail = PIKCV.COM.Util.ReturnEmptyString(Util.ReplaceStrForDB(ContactEmail.Trim()));
                    obj.AlternateContactName = PIKCV.COM.Util.ReturnEmptyString(Util.ReplaceStrForDB(AlternateContactName));
                    obj.AlternateContactPhone = PIKCV.COM.Util.ReturnEmptyString(Util.ReplaceStrForDB(AltenateContactPhone.Trim()));

                    obj.ModifyDate = DateTime.Now;
                    if (obj.CvFocusCode < (int)PIKCV.COM.EnumDB.CVFocusCode.Education) {
                        obj.CvFocusCode = (int)PIKCV.COM.EnumDB.CVFocusCode.Education;
                    }

                    obj.Save();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
        }

        public bool SaveEducationType(int UserID, PIKCV.COM.EnumDB.EducationTypes EducationType) {
            try
            {
                PIKCV.DAL.UserCVs obj = new PIKCV.DAL.UserCVs();
                obj.Where.UserID.Value = UserID;
                obj.Query.Load();
                if (obj.RowCount < 1) { return false; }

                obj.EducationTypeCode = (int)EducationType;

                obj.ModifyDate = DateTime.Now;

                if (obj.CvFocusCode < (int)PIKCV.COM.EnumDB.CVFocusCode.Employment)
                {
                    obj.CvFocusCode = (int)PIKCV.COM.EnumDB.CVFocusCode.Employment;
                }

                obj.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
            
        public PIKCV.COM.EnumDB.CVFocusCode CVFocus(int UserID) {
            PIKCV.DAL.UserCVs obj = new PIKCV.DAL.UserCVs();
            obj.Where.UserID.Value = UserID;
            obj.Query.Load();
            if (obj.RowCount < 1)
            {
                return PIKCV.COM.EnumDB.CVFocusCode.PersonalInfo;
            }
            else {
                return (PIKCV.COM.EnumDB.CVFocusCode)obj.CvFocusCode;
            }
        }

        public bool SaveCVFocus(int UserID, PIKCV.COM.EnumDB.CVFocusCode CVFocus)
        {
            try
            {
                PIKCV.DAL.UserCVs obj = new PIKCV.DAL.UserCVs();
                obj.Where.UserID.Value = UserID;
                obj.Query.Load();
                if (obj.RowCount < 1) { return false; }

                obj.CvFocusCode = (int)CVFocus;

                obj.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static PIKCV.COM.EnumDB.EducationTypes GetEducationType(int UserID)
        {
            PIKCV.DAL.UserCVs obj = new PIKCV.DAL.UserCVs();
            obj.Where.UserID.Value = UserID;
            obj.Query.Load();
            if (obj.RowCount < 1)
            {
                return PIKCV.COM.EnumDB.EducationTypes.Unknown;
            }
            else
            {
                return (PIKCV.COM.EnumDB.EducationTypes)obj.EducationTypeCode;
            }
        }

        public bool SaveEducationMiddleSchool(int UserID, string MiddleSchoolName, int MiddleEducationStatus, DateTime MiddleSchoolEndDate)
        {
            try {
                PIKCV.DAL.UserCVs obj = new PIKCV.DAL.UserCVs();
                obj.Where.UserID.Value = UserID;
                obj.Query.Load();
                if (obj.RowCount < 1) { return false; }

                obj.MiddleSchoolName = PIKCV.COM.Util.ReturnEmptyString(Util.ReplaceStrForDB(MiddleSchoolName));
                obj.MiddleSchoolStatusID = MiddleEducationStatus;
                obj.MiddleSchoolEndDate = MiddleSchoolEndDate;

                obj.ModifyDate = DateTime.Now;
                if (obj.CvFocusCode < (int)PIKCV.COM.EnumDB.CVFocusCode.Education){
                    obj.CvFocusCode = (int)PIKCV.COM.EnumDB.CVFocusCode.Education;
                }

                obj.Save();
                return true;
            }
            catch (Exception) {
                return false;
            }
        }

        public bool SaveEducationHighSchool(int UserID, int HighSchoolTypeID, string HighSchoolName, DateTime HighSchoolEndDate, int HighSchoolStatusID) {
            try {
                PIKCV.DAL.UserCVs obj = new PIKCV.DAL.UserCVs();
                obj.Where.UserID.Value = UserID;
                obj.Query.Load();
                if (obj.RowCount < 1) { return false; }

                obj.HighSchoolTypeID = HighSchoolTypeID;
                obj.HighSchoolName = PIKCV.COM.Util.ReturnEmptyString(Util.ReplaceStrForDB(HighSchoolName));
                obj.HighSchoolEndDate = HighSchoolEndDate;
                obj.HighSchoolStatusID = HighSchoolStatusID;

                obj.ModifyDate = DateTime.Now;
                if (obj.CvFocusCode < (int)PIKCV.COM.EnumDB.CVFocusCode.Education){
                    obj.CvFocusCode = (int)PIKCV.COM.EnumDB.CVFocusCode.Education;
                }

                obj.Save();
                return true;
            }
            catch (Exception) {
                return false;
            }
        }

        public DataTable GetUserCV(int UserID) {
            PIKCV.DAL.UserCVs objUserCV = new PIKCV.DAL.UserCVs();
            objUserCV.Where.UserID.Value = UserID;
            objUserCV.Query.Load();
            return objUserCV.DefaultView.ToTable();
        } 

        public DataTable GetUserEducations(int UserID, PIKCV.COM.EnumDB.EducationTypes EducationType, PIKCV.COM.EnumDB.LanguageID LanugageID, bool IsDeleted)
        {
            try
            {
                PIKCV.DAL.UserEducation objUserEducation = new PIKCV.DAL.UserEducation();
                return objUserEducation.GetUserEducation(UserID, (int)EducationType, (int)LanugageID, IsDeleted);
            }
            catch (Exception) {
                return null;
            }
            return null;

        }

        public DataTable GetUserEducationDetail(int UserEducationID)
        {
            try
            {
                PIKCV.DAL.UserEducation objUserEducation = new PIKCV.DAL.UserEducation();
                objUserEducation.LoadByPrimaryKey(UserEducationID);
                return objUserEducation.DefaultView.ToTable();
            }
            catch (Exception) {
                return null;
            }
        }

        public DataTable GetUserEducationList(int UserID, PIKCV.COM.EnumDB.EducationStates EducationStatusID, PIKCV.COM.EnumDB.LanguageID LanugageID, bool IsDeleted)
        {
            try
            {
                PIKCV.DAL.UserEducation objUserEducation = new PIKCV.DAL.UserEducation();
                return objUserEducation.GetUserEducationList(UserID, (int)EducationStatusID, (int)LanugageID, IsDeleted);
            }
            catch (Exception)
            {
                return null;
            }
            return null;

        }

        public DataTable GetUserEmployment(int UserID, int LanguageID) {
            PIKCV.DAL.UserEmployment obj = new PIKCV.DAL.UserEmployment();
            try
            {
                return obj.GetUserEmployment(UserID, LanguageID);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable GetUserEmploymentDetail(int UserEmploymentID)
        {
            PIKCV.DAL.UserEmployment obj = new PIKCV.DAL.UserEmployment();
            obj.LoadByPrimaryKey(UserEmploymentID);
            return obj.DefaultView.ToTable();
        }

        public DataTable GetUserLanguages(int UserID, int LanguageID)
        {
            PIKCV.DAL.UserLanguages obj = new PIKCV.DAL.UserLanguages();
            return obj.GetUserLanguages(UserID, LanguageID);
        }

        public DataTable GetUserLanguageDetail(int UserLanguageID)
        {
            PIKCV.DAL.UserLanguages obj = new PIKCV.DAL.UserLanguages();
            obj.LoadByPrimaryKey(UserLanguageID);
            return obj.DefaultView.ToTable();
        }

        public void RemoveUserEducation(int UserEducationID) {
            PIKCV.DAL.UserEducation obj = new PIKCV.DAL.UserEducation();
            obj.LoadByPrimaryKey(UserEducationID);
            obj.MarkAsDeleted();
            obj.Save();
        }

        public bool RemoveUserEmployment(int UserEmploymentID) {
            try
            {
                PIKCV.DAL.UserEmployment obj = new PIKCV.DAL.UserEmployment();
                obj.LoadByPrimaryKey(UserEmploymentID);
                obj.MarkAsDeleted();
                obj.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool RemoveUserLanguage(int UserLanguageID)
        {
            try
            {

                PIKCV.DAL.UserLanguages obj = new PIKCV.DAL.UserLanguages();
                obj.LoadByPrimaryKey(UserLanguageID);
                obj.MarkAsDeleted();
                obj.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SaveEducation(int UserEducationID, int UserID, PIKCV.COM.EnumDB.EducationTypes EducationTypeCode, int SchoolID, 
            int EducationStatusID, DateTime StartDate, DateTime EndDate, string OtherSchool, int DepartmentID, string OtherDepartment, int CountryID,
            int CityID, string OtherCity, string Degree, bool IsDeleted) {

                PIKCV.DAO.TransactionMgr Tran = PIKCV.DAO.TransactionMgr.ThreadTransactionMgr();

            try {
                PIKCV.DAL.UserEducation obj = new PIKCV.DAL.UserEducation();
                if (UserEducationID > 0) {
                    obj.LoadByPrimaryKey(UserEducationID);
                } else {
                    obj.AddNew();
                }

                obj.CityID = CityID;
                obj.CountryID = CountryID;
                string mDegree = Util.ReplaceStrForDB(Degree.Trim());
                if (mDegree == "") { mDegree = "0"; }
                obj.Degree = float.Parse(mDegree);
                obj.DepartmentID = DepartmentID;
                obj.EducationStatusID = EducationStatusID;
                obj.EducationTypeCode = (int)EducationTypeCode;

                if (EducationStatusID.ToString() == ((int)PIKCV.COM.EnumDB.EducationStates.Graduate).ToString())
                {
                    obj.EndDate = EndDate;
                }
                else {
                    obj.EndDate = StartDate.AddYears(-1);
                }
                
                obj.IsDeleted = IsDeleted;

                obj.OtherCity = PIKCV.COM.Util.ReturnEmptyString(Util.ReplaceStrForDB(OtherCity));
                obj.OtherDepartment = PIKCV.COM.Util.ReturnEmptyString(Util.ReplaceStrForDB(OtherDepartment));
                obj.OtherSchool = PIKCV.COM.Util.ReturnEmptyString(Util.ReplaceStrForDB(OtherSchool));
                obj.SchoolID = SchoolID;
                obj.StartDate = StartDate;
                obj.UserID = UserID;

                PIKCV.DAL.UserCVs ObjCV = new PIKCV.DAL.UserCVs();
                ObjCV.Where.UserID.Value = UserID;
                ObjCV.Query.Load();
                if (ObjCV.RowCount < 1) { return false; }
                ObjCV.ModifyDate = DateTime.Now;
                if (ObjCV.CvFocusCode < (int)PIKCV.COM.EnumDB.CVFocusCode.Education){
                    ObjCV.CvFocusCode = (int)PIKCV.COM.EnumDB.CVFocusCode.Education;
                }

                Tran.BeginTransaction();
                
                ObjCV.Save();
                obj.Save();

                Tran.CommitTransaction();

                return true;
            }
            catch (Exception) {
                Tran.RollbackTransaction();
                PIKCV.DAO.TransactionMgr.ThreadTransactionMgrReset();
                return false;
            }
        }

        public bool SaveUserPhoto(int UserID, string PhotoFileName)
        {
            try
            {
                PIKCV.DAL.UserCVs obj = new PIKCV.DAL.UserCVs();
                obj.Where.UserID.Value = UserID;
                obj.Query.Load();
                if (obj.RowCount < 1) { return false; }

                obj.PhotoFileName = PhotoFileName;

                obj.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SaveDriverLicence(int UserID, int DriverLicenseTypeID, int DriverLicenseYear)
        {
            try
            {
                PIKCV.DAL.UserCVs obj = new PIKCV.DAL.UserCVs();
                obj.Where.UserID.Value = UserID;
                obj.Query.Load();
                if (obj.RowCount < 1) { return false; }

                obj.DriverLicenseTypeID = DriverLicenseTypeID;
                obj.DriverLicenseYear = DriverLicenseYear;

                obj.ModifyDate = DateTime.Now;
                if (obj.CvFocusCode < (int)PIKCV.COM.EnumDB.CVFocusCode.DriverLicense)
                {
                    obj.CvFocusCode = (int)PIKCV.COM.EnumDB.CVFocusCode.DriverLicense;
                }

                obj.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SaveTotalWorkExperience(int UserID, int TotalWorkExperience)
        {
            try
            {
                PIKCV.DAL.UserCVs obj = new PIKCV.DAL.UserCVs();
                obj.Where.UserID.Value = UserID;
                obj.Query.Load();
                if (obj.RowCount < 1) { return false; }

                obj.ModifyDate = DateTime.Now;
                obj.TotalWorkExperience = TotalWorkExperience;

                obj.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SaveUserEmployment(int UserEmploymentID, int UserID, string CompanyName, string CompanyPhone, bool CanReference, int CityID, string OtherCityName, int CountryID, 
            bool IsWorking, DateTime StartDate, DateTime EndDate, string JobDefiniton, int LabouringTypeID, int PositionID, string ReasonOfResignation, int SectorID) {
            PIKCV.DAO.TransactionMgr Tran = PIKCV.DAO.TransactionMgr.ThreadTransactionMgr();

            try
            {
                PIKCV.DAL.UserEmployment obj = new PIKCV.DAL.UserEmployment();
                if (UserEmploymentID > 0)
                {
                    obj.LoadByPrimaryKey(UserEmploymentID);
                }
                else
                {
                    obj.AddNew();
                }

                obj.CompanyName = PIKCV.COM.Util.ReturnEmptyString(Util.ReplaceStrForDB(CompanyName));
                obj.CompanyPhone = PIKCV.COM.Util.ReturnEmptyString(Util.ReplaceStrForDB(CompanyPhone));
                obj.CanReference = CanReference;
                obj.CityID = CityID;
                obj.OtherCityName = PIKCV.COM.Util.ReturnEmptyString(Util.ReplaceStrForDB(OtherCityName));
                obj.IsWorking = IsWorking;
                obj.CountryID = CountryID;
                obj.StartDate = StartDate;

                if (StartDate < EndDate) {
                    obj.EndDate = EndDate;    
                }

                obj.JobDescription = PIKCV.COM.Util.ReturnEmptyString(Util.ReplaceStrForDB(JobDefiniton));
                obj.LabouringTypeID = LabouringTypeID;
                obj.PositionID = PositionID;
                obj.ReasonOfResignation = PIKCV.COM.Util.ReturnEmptyString(Util.ReplaceStrForDB(ReasonOfResignation));
                obj.SectorID = SectorID;
                obj.UserID = UserID;

                PIKCV.DAL.UserCVs ObjCV = new PIKCV.DAL.UserCVs();
                ObjCV.Where.UserID.Value = UserID;
                ObjCV.Query.Load();
                if (ObjCV.RowCount < 1) { return false; }
                ObjCV.ModifyDate = DateTime.Now;
                if (ObjCV.CvFocusCode < (int)PIKCV.COM.EnumDB.CVFocusCode.DriverLicense)
                {
                    ObjCV.CvFocusCode = (int)PIKCV.COM.EnumDB.CVFocusCode.DriverLicense;
                }

                Tran.BeginTransaction();

                ObjCV.Save();
                obj.Save();

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

        public bool SaveUserComputerKnowledge(int UserID, ArrayList arrComputerKnowledge)
        {
            PIKCV.DAO.TransactionMgr Tran = PIKCV.DAO.TransactionMgr.ThreadTransactionMgr();

            try
            {
                PIKCV.DAL.UserComputerKnowledge obj = new PIKCV.DAL.UserComputerKnowledge();
                obj.Where.UserID.Value = UserID;
                obj.Query.Load();

                Tran.BeginTransaction();

                obj.DeleteAll();
                obj.Save();

                obj = new PIKCV.DAL.UserComputerKnowledge();
                string ComputerKnowledgeTypeID = String.Empty;

                for (int i = 0; i < arrComputerKnowledge.Count; i++)
                {
                    obj.AddNew();
                    obj.UserID = UserID;

                    if (Util.Left(arrComputerKnowledge[i].ToString(), 2) == "__") {
                        obj.OtherComputerKnowledge = arrComputerKnowledge[i].ToString().Replace("__", "");
                        obj.ComputerKnowledgeTypeID = 0;
                    } else {
                        obj.OtherComputerKnowledge = " ";
                        obj.ComputerKnowledgeTypeID = Convert.ToInt32(arrComputerKnowledge[i]);
                    }
                    obj.Save();
                }

                PIKCV.DAL.UserCVs ObjCV = new PIKCV.DAL.UserCVs();
                ObjCV.Where.UserID.Value = UserID;
                ObjCV.Query.Load();
        
                ObjCV.ModifyDate = DateTime.Now;
                if (ObjCV.CvFocusCode < (int)PIKCV.COM.EnumDB.CVFocusCode.ComputerKnowledge)
                {
                    ObjCV.CvFocusCode = (int)PIKCV.COM.EnumDB.CVFocusCode.ComputerKnowledge;
                }
                ObjCV.Save();

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

        public bool SaveEmploymentChooices(int UserID, ArrayList arrSelectedSectors, ArrayList arrSelectedPositions, PIKCV.COM.EnumDB.EmployeeTypes EmployeeType)
        {
            PIKCV.DAO.TransactionMgr Tran = PIKCV.DAO.TransactionMgr.ThreadTransactionMgr();

            try
            {
                PIKCV.DAL.UserSectors objSectors = new PIKCV.DAL.UserSectors();
                PIKCV.DAL.UserPositions objPositions = new PIKCV.DAL.UserPositions();
                PIKCV.DAL.UserCVs ObjCV = new PIKCV.DAL.UserCVs();
                PIKCV.DAL.User ObjUser = new PIKCV.DAL.User();

                objSectors.Where.UserID.Value = UserID;
                objPositions.Where.UserID.Value = UserID;
                objSectors.Query.Load();
                objPositions.Query.Load();

                Tran.BeginTransaction();
                
                objSectors.DeleteAll();
                objSectors.Save();

                objPositions.DeleteAll();
                objPositions.Save();

                for (int i = 0; i < arrSelectedPositions.Count; i++)
                {
                    objPositions.AddNew();
                    objPositions.UserID = UserID;
                    objPositions.PositionID = Convert.ToInt32(arrSelectedPositions[i]);
                    objPositions.Save();
                }

                for (int i = 0; i < arrSelectedSectors.Count; i++)
                {
                    objSectors.AddNew();
                    objSectors.UserID = UserID;
                    objSectors.SectorID = Convert.ToInt32(arrSelectedSectors[i]);
                    objSectors.Save();
                }

                ObjCV.Where.UserID.Value = UserID;
                ObjCV.Query.Load();

                ObjCV.ModifyDate = DateTime.Now;
                if (ObjCV.CvFocusCode < (int)PIKCV.COM.EnumDB.CVFocusCode.PlacementPreferences)
                {
                    ObjCV.CvFocusCode = (int)PIKCV.COM.EnumDB.CVFocusCode.PlacementPreferences;
                }
                ObjCV.Save();

                ObjUser.LoadByPrimaryKey(UserID);
                ObjUser.EmployeeTypeCode = (int)EmployeeType;
                ObjUser.Save();

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

        public bool SavePlacementPreferences(int UserID, ArrayList arrSelectedCities, ArrayList arrSelectedCountries, bool HasTravelDifficulty, ArrayList arrLabouringTypes, bool IsSmoking)
        {
            PIKCV.DAO.TransactionMgr Tran = PIKCV.DAO.TransactionMgr.ThreadTransactionMgr();

            try
            {
                PIKCV.DAL.UserPlacementPreferences objPlacementPreferences = new PIKCV.DAL.UserPlacementPreferences();
                PIKCV.DAL.UserCVs ObjCV = new PIKCV.DAL.UserCVs();
                PIKCV.DAL.UserLabouringTypes objLabouringTypes = new PIKCV.DAL.UserLabouringTypes();

                objPlacementPreferences.Where.UserID.Value = UserID;
                objPlacementPreferences.Query.Load();
                
                objLabouringTypes.Where.UserID.Value = UserID;
                objLabouringTypes.Query.Load();

                Tran.BeginTransaction();
                
                objPlacementPreferences.DeleteAll();
                objPlacementPreferences.Save();

                objLabouringTypes.DeleteAll();
                objLabouringTypes.Save();
                objLabouringTypes = new PIKCV.DAL.UserLabouringTypes();

                for (int i = 0; i < arrLabouringTypes.Count; i++)
                {
                    objLabouringTypes.AddNew();
                    objLabouringTypes.UserID = UserID;
                    objLabouringTypes.LabouringTypeID = Convert.ToInt32(arrLabouringTypes[i]);
                    objLabouringTypes.Save();
                }

                for (int i = 0; i < arrSelectedCities.Count; i++)
                {
                    objPlacementPreferences.AddNew();
                    objPlacementPreferences.UserID = UserID;
                    objPlacementPreferences.PlaceTypeCode = (int)PIKCV.COM.EnumDB.PlaceTypes.TurkeyCity;

                    if (Util.Left(arrSelectedCities[i].ToString(), 2) == "__")
                    {
                        objPlacementPreferences.OtherPlace = arrSelectedCities[i].ToString().Replace("__", "");
                        objPlacementPreferences.PlaceID = 0;
                    }
                    else
                    {
                        objPlacementPreferences.OtherPlace = " ";
                        objPlacementPreferences.PlaceID = Convert.ToInt32(arrSelectedCities[i]);
                    }
                    objPlacementPreferences.Save();
                }

                for (int i = 0; i < arrSelectedCountries.Count; i++)
                {
                    objPlacementPreferences.AddNew();
                    objPlacementPreferences.UserID = UserID;
                    objPlacementPreferences.PlaceTypeCode = (int)PIKCV.COM.EnumDB.PlaceTypes.Country;
                    objPlacementPreferences.PlaceID = Convert.ToInt32(arrSelectedCountries[i]);
                    objPlacementPreferences.OtherPlace = " ";
                    objPlacementPreferences.Save();
                }

                ObjCV.Where.UserID.Value = UserID;
                ObjCV.Query.Load();

                if (ObjCV.CvFocusCode < (int)PIKCV.COM.EnumDB.CVFocusCode.ProhibitedCompanies)
                {
                    ObjCV.CvFocusCode = (int)PIKCV.COM.EnumDB.CVFocusCode.ProhibitedCompanies;
                }

                ObjCV.ModifyDate = DateTime.Now;
                ObjCV.HasTravelDifficulty = HasTravelDifficulty;
                ObjCV.IsSmoking = IsSmoking;
                ObjCV.Save();

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

        public bool SaveCourseAndCertificates(int UserID, string CourseAndCertificates)
        {
            try
            {
                PIKCV.DAL.UserCVs obj = new PIKCV.DAL.UserCVs();
                obj.Where.UserID.Value = UserID;
                obj.Query.Load();
                if (obj.RowCount < 1) { return false; }

                obj.CourseAndCertificates = PIKCV.COM.Util.ReturnEmptyString(Util.ReplaceStrForDB(CourseAndCertificates));

                obj.ModifyDate = DateTime.Now;
                if (obj.CvFocusCode < (int)PIKCV.COM.EnumDB.CVFocusCode.Interests)
                {
                    obj.CvFocusCode = (int)PIKCV.COM.EnumDB.CVFocusCode.Interests;
                }

                obj.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SaveInterests(int UserID, string Interests)
        {
            try
            {
                PIKCV.DAL.UserCVs obj = new PIKCV.DAL.UserCVs();
                obj.Where.UserID.Value = UserID;
                obj.Query.Load();
                if (obj.RowCount < 1) { return false; }

                obj.Interests = PIKCV.COM.Util.ReturnEmptyString(Util.ReplaceStrForDB(Interests));

                obj.ModifyDate = DateTime.Now;
                if (obj.CvFocusCode < (int)PIKCV.COM.EnumDB.CVFocusCode.Clubs)
                {
                    obj.CvFocusCode = (int)PIKCV.COM.EnumDB.CVFocusCode.Clubs;
                }

                obj.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SaveClubs(int UserID, string Clubs)
        {
            try
            {
                PIKCV.DAL.UserCVs obj = new PIKCV.DAL.UserCVs();
                obj.Where.UserID.Value = UserID;
                obj.Query.Load();
                if (obj.RowCount < 1) { return false; }

                obj.Clubs = PIKCV.COM.Util.ReturnEmptyString(Util.ReplaceStrForDB(Clubs));

                obj.ModifyDate = DateTime.Now;
                if (obj.CvFocusCode < (int)PIKCV.COM.EnumDB.CVFocusCode.EmploymentChooices)
                {
                    obj.CvFocusCode = (int)PIKCV.COM.EnumDB.CVFocusCode.EmploymentChooices;
                }

                obj.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SaveUserReference(int UserReferenceID, int UserID, string ReferenceName, string Company, string Phone, string Position)
        {
            PIKCV.DAO.TransactionMgr Tran = PIKCV.DAO.TransactionMgr.ThreadTransactionMgr();

            try
            {
                PIKCV.DAL.UserReferences obj = new PIKCV.DAL.UserReferences();
                if (UserReferenceID > 0)
                {
                    obj.LoadByPrimaryKey(UserReferenceID);
                }
                else
                {
                    obj.AddNew();
                }

                obj.UserID = UserID;
                obj.ReferenceName = PIKCV.COM.Util.ReturnEmptyString(Util.ReplaceStrForDB(ReferenceName));
                obj.Company = PIKCV.COM.Util.ReturnEmptyString(Util.ReplaceStrForDB(Company));
                obj.Phone = PIKCV.COM.Util.ReturnEmptyString(Util.ReplaceStrForDB(Phone.Trim()));
                obj.Position = PIKCV.COM.Util.ReturnEmptyString(Util.ReplaceStrForDB(Position));

                PIKCV.DAL.UserCVs ObjCV = new PIKCV.DAL.UserCVs();
                ObjCV.Where.UserID.Value = UserID;
                ObjCV.Query.Load();
                if (ObjCV.RowCount < 1) { return false; }
                ObjCV.ModifyDate = DateTime.Now;
                if (ObjCV.CvFocusCode < (int)PIKCV.COM.EnumDB.CVFocusCode.OtherChoices)
                {
                    ObjCV.CvFocusCode = (int)PIKCV.COM.EnumDB.CVFocusCode.OtherChoices;
                }

                Tran.BeginTransaction();

                ObjCV.Save();
                obj.Save();

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

        public DataTable GetUserReferences(int UserID) {
            PIKCV.DAL.UserReferences obj = new PIKCV.DAL.UserReferences();
            obj.Where.UserID.Value = UserID;
            obj.Query.Load();
            return obj.DefaultView.ToTable();
        }

        public DataTable GetReferenceDetail(int UserReferenceID) {
            PIKCV.DAL.UserReferences obj = new PIKCV.DAL.UserReferences();
            obj.LoadByPrimaryKey(UserReferenceID);
            return obj.DefaultView.ToTable();
        }

        public DataTable GetUserComputerKnowledges(int UserID, int LanguageID) {
            PIKCV.DAL.UserComputerKnowledge obj = new PIKCV.DAL.UserComputerKnowledge();
            return obj.GetUserComputerKnowledges(UserID, LanguageID);
        }

        public DataTable GetUserSectors(int UserID, int LanguageID)
        {
            PIKCV.DAL.UserSectors obj = new PIKCV.DAL.UserSectors();
            return obj.GetUserSectors(UserID, LanguageID);
        }

        public DataTable GetUserPlaces(int UserID, int LanguageID)
        {
            PIKCV.DAL.UserPlacementPreferences obj = new PIKCV.DAL.UserPlacementPreferences();
            return obj.GetUserPlacementPreferences(UserID, LanguageID);
        }

        public DataTable GetUserPositions(int UserID, int LanguageID)
        {
            PIKCV.DAL.UserPositions obj = new PIKCV.DAL.UserPositions();
            return obj.GetUserPositions(UserID, LanguageID);
        }

        public DataTable GetUserLabouringTypes(int UserID, int LanguageID)
        {
            PIKCV.DAL.UserLabouringTypes obj = new PIKCV.DAL.UserLabouringTypes();
            return obj.GetUserLabouringTypes(UserID, LanguageID);
        }

        public bool SaveUserLanguage(int UserLanguageID, int UserID, int ForeignLanguageID, int ReadLevelID, int WriteLevelID, int SpeakLevelID,
            string PlaceLearned, int ForeignLanguageExamID, string ExamDegree)
        {
            PIKCV.DAO.TransactionMgr Tran = PIKCV.DAO.TransactionMgr.ThreadTransactionMgr();

            try
            {
                PIKCV.DAL.UserLanguages obj = new PIKCV.DAL.UserLanguages();
                if (UserLanguageID > 0)
                {
                    obj.LoadByPrimaryKey(UserLanguageID);
                }
                else
                {
                    obj.AddNew();
                }

                obj.ForeignLanguageID = ForeignLanguageID;
                obj.PlaceLearned = PIKCV.COM.Util.ReturnEmptyString(Util.ReplaceStrForDB(PlaceLearned));
                obj.WriteLevelID = WriteLevelID;
                obj.SpeakLevelID = SpeakLevelID;
                obj.ReadLevelID = ReadLevelID;
                obj.UserID = UserID;
                obj.ForeignLanguageExamID = ForeignLanguageExamID;

                string mExamDegree = Util.ReplaceStrForDB(ExamDegree.Trim());
                if (mExamDegree == "") { mExamDegree = "0"; }
                obj.ExamDegree = float.Parse(mExamDegree);

                PIKCV.DAL.UserCVs ObjCV = new PIKCV.DAL.UserCVs();
                ObjCV.Where.UserID.Value = UserID;
                ObjCV.Query.Load();
                if (ObjCV.RowCount < 1) { return false; }
                ObjCV.ModifyDate = DateTime.Now;
                if (ObjCV.CvFocusCode < (int)PIKCV.COM.EnumDB.CVFocusCode.ComputerKnowledge)
                {
                    ObjCV.CvFocusCode = (int)PIKCV.COM.EnumDB.CVFocusCode.ComputerKnowledge;
                }

                Tran.BeginTransaction();

                ObjCV.Save();
                obj.Save();

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

        public bool SaveUserProhibitedCompanies(int UserID, ArrayList arrSelectedCompanies)
        {
            PIKCV.DAO.TransactionMgr Tran = PIKCV.DAO.TransactionMgr.ThreadTransactionMgr();

            try
            {
                PIKCV.DAL.UserCVs ObjCV = new PIKCV.DAL.UserCVs();
                PIKCV.DAL.UserProhibitedCompanies objUserProhibites = new PIKCV.DAL.UserProhibitedCompanies();

                objUserProhibites.Where.UserID.Value = UserID;
                objUserProhibites.Query.Load();

                Tran.BeginTransaction();

                objUserProhibites.DeleteAll();
                objUserProhibites.Save();

                objUserProhibites = new PIKCV.DAL.UserProhibitedCompanies();

                for (int i = 0; i < arrSelectedCompanies.Count; i++)
                {
                    objUserProhibites.AddNew();
                    objUserProhibites.UserID = UserID;
                    objUserProhibites.CompanyID = Convert.ToInt32(arrSelectedCompanies[i]);
                    objUserProhibites.Save();
                }

                ObjCV.Where.UserID.Value = UserID;
                ObjCV.Query.Load();

                if (ObjCV.CvFocusCode < (int)PIKCV.COM.EnumDB.CVFocusCode.References)
                {
                    ObjCV.CvFocusCode = (int)PIKCV.COM.EnumDB.CVFocusCode.References;
                }

                ObjCV.ModifyDate = DateTime.Now;
                ObjCV.Save();

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

        public DataTable GetUserProhibitedCompanies(int UserID)
        {
            PIKCV.DAL.UserProhibitedCompanies obj = new PIKCV.DAL.UserProhibitedCompanies();
            return obj.GetUserProhibitedCompanies(UserID);
        }

        public bool RemoveUserReference(int UserReferenceID)
        {
            try
            {

                PIKCV.DAL.UserReferences obj = new PIKCV.DAL.UserReferences();
                obj.LoadByPrimaryKey(UserReferenceID);
                obj.MarkAsDeleted();
                obj.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void UpdateCVModifyDate(int UserID) { 
            try
            {
                PIKCV.DAL.UserCVs obj = new PIKCV.DAL.UserCVs();
                obj.Where.UserID.Value = UserID;
                obj.Query.Load();
                if (obj.RowCount > 0) { obj.ModifyDate = DateTime.Now; }
                obj.Save();
            }
            catch (Exception) { }
        }


        public void RemoveUserHighSchool(int UserID)
        {
            try
            {
                PIKCV.DAL.UserCVs obj = new PIKCV.DAL.UserCVs();
                obj.Where.UserID.Value = UserID;
                obj.Query.Load();
                if (obj.RowCount > 0) { 
                    obj.ModifyDate = DateTime.Now;
                    obj.HighSchoolEndDate = DateTime.Now.AddDays(1);
                    obj.HighSchoolName = " ";
                    obj.HighSchoolStatusID = 0;
                    obj.HighSchoolTypeID = 0;
                }
                obj.Save();
            }
            catch (Exception) { }
        }

        public void RemoveUserMiddleSchool(int UserID)
        {
            try
            {
                PIKCV.DAL.UserCVs obj = new PIKCV.DAL.UserCVs();
                obj.Where.UserID.Value = UserID;
                obj.Query.Load();
                if (obj.RowCount > 0)
                {
                    obj.MiddleSchoolEndDate = DateTime.Now.AddDays(1); ;
                    obj.MiddleSchoolName = " ";
                    obj.MiddleSchoolStatusID = 0;

                }
                obj.Save();
            }
            catch (Exception) { }
        }

        public DataTable GetUserDriverLicenses(int UserID, PIKCV.COM.EnumDB.LanguageID LanguageID)
        {
            try
            {
                PIKCV.DAL.UserDriverLicense obj = new PIKCV.DAL.UserDriverLicense();
                return obj.GetUserDriverLicense(UserID, (int)LanguageID);
            }
            catch (Exception)
            {
                return null;
            }
            return null;
        }

        public bool SaveUserDriverLicenses(int UserID, ArrayList arrDriverLicenses)
        {
            PIKCV.DAO.TransactionMgr Tran = PIKCV.DAO.TransactionMgr.ThreadTransactionMgr();

            try
            {
                Tran.BeginTransaction();

                PIKCV.DAL.UserDriverLicense obj = new PIKCV.DAL.UserDriverLicense();
                obj.Where.UserID.Value = UserID;
                obj.Query.Load();
                obj.DeleteAll();
                obj.Save();

                for (int i = 0; i < arrDriverLicenses.Count; i++)
                {
                    obj.AddNew();
                    obj.UserID = UserID;
                    obj.DriverLicenseTypeID = Convert.ToInt32(arrDriverLicenses[i]);
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
    }
}