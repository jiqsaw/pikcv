using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using CARETTA.COM;
using System.Collections;

namespace PIKCV.BUS
{
    public class User
    {
        #region User Columns

        private int m_UserID = 0;
        private string m_ActivationNumber;
        private DateTime m_CreateDate;
        private string m_Email;
        private PIKCV.COM.EnumDB.EmployeeTypes m_EmployeeType;
        private string m_FirstName;
        private string m_IdentityNo;
        private bool m_IsActive;
        private bool m_IsCVActive;
        private bool m_IsCVConfirmed;
        private bool m_IsDeleted;
        private bool m_IsEmailConfirmed;
        private DateTime m_LastLoginDate;
        private string m_LastName;
        private DateTime m_ModifyDate;
        private string m_Password;

        public int UserID
        {
            get { return m_UserID; }
            set { m_UserID = value; }
        }

        public string ActivationNumber
        {
            get { return m_ActivationNumber; }
            set { m_ActivationNumber = value; }
        }

        public DateTime CreateDate
        {
            get { return m_CreateDate; }
            set { m_CreateDate = value; }
        }
        public string Email
        {
            get { return m_Email; }
            set { m_Email = value; }
        }

        public PIKCV.COM.EnumDB.EmployeeTypes EmployeeType
        {
            get { return m_EmployeeType; }
            set { m_EmployeeType = value; }
        }

        public string FirstName
        {
            get { return m_FirstName; }
            set { m_FirstName = value; }
        }

        public string IdentityNo
        {
            get { return m_IdentityNo; }
            set { m_IdentityNo = value; }
        }

        public bool IsActive
        {
            get { return m_IsActive; }
            set { m_IsActive = value; }
        }

        public bool IsCVActive
        {
            get { return m_IsCVActive; }
            set { m_IsCVActive = value; }
        }

        public bool IsCVConfirmed
        {
            get { return m_IsCVConfirmed; }
            set { m_IsCVConfirmed = value; }
        }

        public bool IsDeleted
        {
            get { return m_IsDeleted; }
            set { m_IsDeleted = value; }
        }

        public bool IsEmailConfirmed
        {
            get { return m_IsEmailConfirmed; }
            set { m_IsEmailConfirmed = value; }
        }

        public DateTime LastLoginDate
        {
            get { return m_LastLoginDate; }
            set { m_LastLoginDate = value; }
        }

        public string LastName
        {
            get { return m_LastName; }
            set { m_LastName = value; }
        }

        public DateTime ModifyDate
        {
            get { return m_ModifyDate; }
            set { m_ModifyDate = value; }
        }

        public string Password
        {
            get { return m_Password; }
            set { m_Password = value; }
        }

        #endregion

        public bool UserExist(string Email, string IdentityNo)
        {
            string m_Email = CARETTA.COM.Util.ClearString(Email.Trim());
            string m_IdentityNo = CARETTA.COM.Util.ClearString(IdentityNo.Trim());
            PIKCV.DAL.User objUser = new PIKCV.DAL.User();
            objUser.Where.Email.Value = m_Email;
            objUser.Where.IdentityNo.Value = m_IdentityNo;
            objUser.Query.Load("OR");
            if (objUser.RowCount > 0) { return true; }
            else return false;
        }

        public bool LoginControl(string Email, string Password)
        {
            Email = Util.ClearString(Email.Trim());
            Password = Encryption.Encrypt(CARETTA.COM.Util.ClearString(Password.Trim()));
            PIKCV.DAL.User objUser = new PIKCV.DAL.User();
            objUser.Where.Email.Value = Email;
            objUser.Where.Password.Value = Password;
            objUser.Where.IsEmailConfirmed.Value = true;
            objUser.Where.IsActive.Value = true;
            objUser.Where.IsDeleted.Value = false;
            objUser.Query.Load();
            if (!objUser.EOF)
            {
                this.m_UserID = objUser.UserID;
                this.m_ActivationNumber = objUser.ActivationNumber;
                this.m_CreateDate = objUser.CreateDate;
                this.m_Email = objUser.Email;
                this.m_EmployeeType = (PIKCV.COM.EnumDB.EmployeeTypes)((int)objUser.EmployeeTypeCode);
                this.m_FirstName = objUser.FirstName;
                this.m_IdentityNo = objUser.IdentityNo;
                this.m_IsActive = objUser.IsActive;
                this.m_IsCVActive = objUser.IsCVActive;
                this.m_IsCVConfirmed = objUser.IsCVConfirmed;
                this.m_IsDeleted = objUser.IsDeleted;
                this.m_IsEmailConfirmed = objUser.IsEmailConfirmed;
                this.m_LastName = objUser.LastName;
                this.m_ModifyDate = objUser.ModifyDate;
                this.m_Password = objUser.Password;
                this.m_LastLoginDate = objUser.LastLoginDate;
                UpdateLastLoginDate(UserID);
                return true;
            }
            return false;
        }

        public void UpdateLastLoginDate(int UserID)
        {
            DateTime LastLoginDate = DateTime.Now;
            PIKCV.DAL.User objUser = new PIKCV.DAL.User();
            objUser.LoadByPrimaryKey(UserID);
            objUser.LastLoginDate = LastLoginDate;
            objUser.Save();
        }

        public bool UpdateCVStatus(int UserID, bool IsCVActive)
        {
            PIKCV.DAL.User objUser = new PIKCV.DAL.User();
            objUser.LoadByPrimaryKey(UserID);
            if (objUser.IsCVConfirmed)
            {
                objUser.IsCVActive = IsCVActive;
                objUser.Save();
                return true;
            }
            return false;
        }

        // Üyelik Bilgileri Yeni Kayýt | Güncelle 
        public int SaveUserInfo(int UserID, string FirstName, string LastName, string Email, string IdentityNo,
                                string Password, string SecretQuestion, string SecretAnswer, bool IsWantedSMS)
        {
            try
            {
                PIKCV.DAL.User objUser = new PIKCV.DAL.User();

                if (UserID > 0) { objUser.LoadByPrimaryKey(UserID); }
                else { objUser.AddNew(); objUser.CreateDate = DateTime.Now; }

                objUser.Email = Email;
                objUser.FirstName = Util.ReplaceStrForDB(FirstName);
                objUser.IdentityNo = Util.ClearString(IdentityNo.Trim());

                if (UserID < 1)
                {
                    objUser.CreateDate = DateTime.Now;
                    objUser.ActivationNumber = " ";
                    objUser.EmployeeTypeCode = (int)PIKCV.COM.EnumDB.EmployeeTypes.Unknown;
                    objUser.IsActive = true;
                    objUser.IsCVActive = false;
                    objUser.IsCVConfirmed = false;
                    objUser.IsDeleted = false;
                    objUser.IsEmailConfirmed = false;
                    //**objUser.IsEmailConfirmed = true;
                    objUser.LastLoginDate = DateTime.Now.AddYears(50);
                }
                if (Password != String.Empty) objUser.Password = Encryption.Encrypt(Password);
                objUser.LastName = Util.ReplaceStrForDB(LastName);
                objUser.ModifyDate = DateTime.Now;
                objUser.SecretQuestion = Util.ReplaceStrForDB(SecretQuestion);
                objUser.SecretAnswer = Util.ReplaceStrForDB(SecretAnswer);
                objUser.IsWantedSMS = IsWantedSMS;
                objUser.Save();
                return objUser.UserID;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public bool isEmailConfirmed(int UserID)
        {
            PIKCV.DAL.User obj = new PIKCV.DAL.User();
            obj.LoadByPrimaryKey(UserID);
            if (!obj.EOF) { return obj.IsEmailConfirmed; }
            else { return false; }
        }

        public bool SaveActivation(int UserID, string ActivationNumber)
        {
            try
            {
                PIKCV.DAL.User objUser = new PIKCV.DAL.User();
                objUser.LoadByPrimaryKey(UserID);
                objUser.ActivationNumber = ActivationNumber;
                objUser.Save();
                return true;
            }
            catch (Exception)
            {
                throw;
            }

            return false;
        }

        public bool ActivateUser(int UserID, string ActivationNumber)
        {
            PIKCV.DAL.User objUser = new PIKCV.DAL.User();
            objUser.Where.UserID.Value = UserID;
            objUser.Where.ActivationNumber.Value = ActivationNumber;
            objUser.Query.Load();
            if (objUser.RowCount > 0)
            {
                objUser.LoadByPrimaryKey(UserID);
                objUser.IsEmailConfirmed = true;
                objUser.Save();
                return true;
            }
            return false;
        }

        public DataTable GetUserDetail(int UserID)
        {
            PIKCV.DAL.User obj = new PIKCV.DAL.User();
            obj.LoadByPrimaryKey(UserID);
            return obj.DefaultView.ToTable();
        }

        public DataRow GetUserByEmail(string Email)
        {
            string m_Email = Util.ClearString(Email.Trim());
            PIKCV.DAL.User objUser = new PIKCV.DAL.User();
            objUser.Where.Email.Value = m_Email;
            objUser.Query.Load();
            if (objUser.RowCount > 0) { return objUser.DefaultView.ToTable().Rows[0]; }
            else return null;
        }

        public DataTable GetUserInterviewPikcv(int UserID)
        {
            PIKCV.DAL.InterviewPikcv obj = new PIKCV.DAL.InterviewPikcv();
            return obj.GetPikcvInterview(UserID);
        }

        public DataTable GetUserInterviewPikcvPropertiesPoints(int InterviewPikcvID, int LanguageID)
        {
            PIKCV.DAL.InterviewPikcv obj = new PIKCV.DAL.InterviewPikcv();
            return obj.GetPikcvInterviewPoints(InterviewPikcvID, LanguageID);
        }

        public static DataTable GetEmployeeSearchResults(ArrayList Gender,
            ArrayList AgeRange,
            ArrayList MaritalStates,
            ArrayList MilitaryStates,
            int DriverLicenceTypes,
            bool Handicapped,
            bool Convicted,
            bool MartyrRelative,
            bool TerrorAggrieved,
            ArrayList Countries,
            ArrayList TurkeyCities,
            ArrayList EducationLevels,
            ArrayList EducationStates,
            ArrayList HighSchoolEducationLevels,
            int HighSchoolTypes,
            ArrayList UniversityEducationLevels,
            int UniversityNames,
            int DepartmentNames,
            ArrayList Sectors,
            ArrayList Positions,
            ArrayList Experience,
            ArrayList LabouringTypes,
            int ForeignLanguages1,
            int ForeignLanguages1Reading,
            int ForeignLanguages1Writing,
            int ForeignLanguages1Speaking,
            int ForeignLanguages2,
            int ForeignLanguages2Reading,
            int ForeignLanguages2Writing,
            int ForeignLanguages2Speaking,
            int ForeignLanguages3,
            int ForeignLanguages3Reading,
            int ForeignLanguages3Writing,
            int ForeignLanguages3Speaking,
            ArrayList ComputerKnowledgeTypes,
            ArrayList SectorsDesired,
            ArrayList PositionsDesired,
            ArrayList CountriesDesired,
            ArrayList CitiesDesired,
            ArrayList LabouringTypesDesired,
            int EmployeeSearchType,
            int CompanyID,
            int JobID, 
            ArrayList ApplicationStatus)
        {


            //int EmployeeSearchType
            //int UniversityNames,
            //int DepartmentNames,
            //int HighSchoolTypes,

            string strGender;
            if (Gender != null && Gender.Count != 0)
                strGender = XMLHelper.BuildXmlString("Gender", "Gender", Gender);
            else
                strGender = "";

            string strAgeRange;
            if (AgeRange != null && AgeRange.Count != 0)
                strAgeRange = XMLHelper.BuildXmlString("AgeRange", "AgeRange", AgeRange);
            else
                strAgeRange = "";

            string strMaritalStates;
            if (MaritalStates != null && MaritalStates.Count != 0)
                strMaritalStates = XMLHelper.BuildXmlString("MaritalStates", "MaritalStates", MaritalStates);
            else
                strMaritalStates = "";

            string strMilitaryStates;
            if (MilitaryStates != null && MilitaryStates.Count != 0)
                strMilitaryStates = XMLHelper.BuildXmlString("MilitaryStates", "MilitaryStates", MilitaryStates);
            else
                strMilitaryStates = "";

            string strCountries;
            if (Countries != null && Countries.Count != 0)
                strCountries = XMLHelper.BuildXmlString("Countries", "Countries", Countries);
            else
                strCountries = "";

            string strTurkeyCities;
            if (TurkeyCities != null && TurkeyCities.Count != 0)
                strTurkeyCities = XMLHelper.BuildXmlString("TurkeyCities", "TurkeyCities", TurkeyCities);
            else
                strTurkeyCities = "";

            string strEducationLevels;
            if (EducationLevels != null && EducationLevels.Count != 0)
                strEducationLevels = XMLHelper.BuildXmlString("EducationLevels", "EducationLevels", EducationLevels);
            else
                strEducationLevels = "";

            string strEducationStates;
            if (EducationStates != null && EducationStates.Count != 0)
                strEducationStates = XMLHelper.BuildXmlString("EducationStates", "EducationStates", EducationStates);
            else
                strEducationStates = "";

            string strHighSchoolEducationLevels;
            if (HighSchoolEducationLevels != null && HighSchoolEducationLevels.Count != 0)
                strHighSchoolEducationLevels = XMLHelper.BuildXmlString("HighSchoolEducationLevels", "HighSchoolEducationLevels", HighSchoolEducationLevels);
            else
                strHighSchoolEducationLevels = "";

            string strUniversityEducationLevels;
            if (UniversityEducationLevels != null && UniversityEducationLevels.Count != 0)
                strUniversityEducationLevels = XMLHelper.BuildXmlString("UniversityEducationLevels", "UniversityEducationLevels", UniversityEducationLevels);
            else
                strUniversityEducationLevels = "";

            string strSectors;
            if (Sectors != null && Sectors.Count != 0)
                strSectors = XMLHelper.BuildXmlString("Sectors", "Sectors", Sectors);
            else
                strSectors = "";

            string strPositions;
            if (Positions != null && Positions.Count != 0)
                strPositions = XMLHelper.BuildXmlString("Positions", "Positions", Positions);
            else
                strPositions = "";

            string strExperience;
            if (Experience != null && Experience.Count != 0)
                strExperience = XMLHelper.BuildXmlString("Experience", "Experience", Experience);
            else
                strExperience = "";

            string strLabouringTypes;
            if (LabouringTypes != null && LabouringTypes.Count != 0)
                strLabouringTypes = XMLHelper.BuildXmlString("LabouringTypes", "LabouringTypes", LabouringTypes);
            else
                strLabouringTypes = "";

            string strComputerKnowledgeTypes;
            if (ComputerKnowledgeTypes != null && ComputerKnowledgeTypes.Count != 0)
                strComputerKnowledgeTypes = XMLHelper.BuildXmlString("ComputerKnowledgeTypes", "ComputerKnowledgeTypes", ComputerKnowledgeTypes);
            else
                strComputerKnowledgeTypes = "";

            string strSectorsDesired;
            if (SectorsDesired != null && SectorsDesired.Count != 0)
                strSectorsDesired = XMLHelper.BuildXmlString("SectorsDesired", "SectorsDesired", SectorsDesired);
            else
                strSectorsDesired = "";

            string strPositionsDesired;
            if (PositionsDesired != null && PositionsDesired.Count != 0)
                strPositionsDesired = XMLHelper.BuildXmlString("PositionsDesired", "PositionsDesired", PositionsDesired);
            else
                strPositionsDesired = "";

            string strCountriesDesired;
            if (CountriesDesired != null && CountriesDesired.Count != 0)
                strCountriesDesired = XMLHelper.BuildXmlString("CountriesDesired", "CountriesDesired", CountriesDesired);
            else
                strCountriesDesired = "";

            string strCitiesDesired;
            if (CitiesDesired != null && CitiesDesired.Count != 0)
                strCitiesDesired = XMLHelper.BuildXmlString("CitiesDesired", "CitiesDesired", CitiesDesired);
            else
                strCitiesDesired = "";

            string strLabouringTypesDesired;
            if (LabouringTypesDesired != null && LabouringTypesDesired.Count != 0)
                strLabouringTypesDesired = XMLHelper.BuildXmlString("LabouringTypesDesired", "LabouringTypesDesired", LabouringTypesDesired);
            else
                strLabouringTypesDesired = "";

            string strApplicationStatus;
            if (ApplicationStatus != null && ApplicationStatus.Count != 0)
                strApplicationStatus = XMLHelper.BuildXmlString("ApplicationStatus", "ApplicationStatus", ApplicationStatus);
            else
                strApplicationStatus = "";

            //string strForeignLanguages;
            //if (ForeignLanguages != null && ForeignLanguages.Count != 0)
            //    strForeignLanguages = "";
            //    //strForeignLanguages = XMLHelper.BuildXmlString("ForeignLanguages", "ForeignLanguages", ForeignLanguages);
            //else
            //    strForeignLanguages = "";

            //string strForeignLanguagesReading;
            //if (ForeignLanguagesReading != null && ForeignLanguagesReading.Count != 0)
            //    strForeignLanguagesReading = "";
            //    //strForeignLanguagesReading = XMLHelper.BuildXmlString("ForeignLanguagesReading", "ForeignLanguagesReading", ForeignLanguagesReading);
            //else
            //    strForeignLanguagesReading = "";

            //string strForeignLanguagesWriting;
            //if (ForeignLanguagesWriting != null && ForeignLanguagesWriting.Count != 0)
            //    strForeignLanguagesWriting = "";
            //    //strForeignLanguagesWriting = XMLHelper.BuildXmlString("ForeignLanguagesWriting", "ForeignLanguagesWriting", ForeignLanguagesWriting);
            //else
            //    strForeignLanguagesWriting = "";

            //string strForeignLanguagesSpeaking;
            //if (ForeignLanguagesSpeaking != null && ForeignLanguagesSpeaking.Count != 0)
            //    strForeignLanguagesSpeaking = "";
            //    //strForeignLanguagesSpeaking = XMLHelper.BuildXmlString("ForeignLanguagesSpeaking", "ForeignLanguagesSpeaking", ForeignLanguagesSpeaking);
            //else
            //    strForeignLanguagesSpeaking = "";

            string strForeignLanguages = "";
            if (ForeignLanguages1 != 0 || ForeignLanguages2 != 0 || ForeignLanguages3 != 0)
            {
                strForeignLanguages = "<ForeignLanguages> ";
                if (ForeignLanguages1 != 0)
                {
                    strForeignLanguages += "<flng fl=\"" + ForeignLanguages1.ToString() + "\" fls=\"" + ForeignLanguages1Speaking.ToString() + "\" flw=\"" + ForeignLanguages1Writing.ToString() + "\" flr=\"" + ForeignLanguages1Reading.ToString() + "\" /> "; 
                }
                if (ForeignLanguages2 != 0)
                {
                    strForeignLanguages += "<flng fl=\"" + ForeignLanguages2.ToString() + "\" fls=\"" + ForeignLanguages2Speaking.ToString() + "\" flw=\"" + ForeignLanguages2Writing.ToString() + "\" flr=\"" + ForeignLanguages2Reading.ToString() + "\" /> "; 
                }
                if (ForeignLanguages3 != 0)
                {
                    strForeignLanguages += "<flng fl=\"" + ForeignLanguages3.ToString() + "\" fls=\"" + ForeignLanguages3Speaking.ToString() + "\" flw=\"" + ForeignLanguages3Writing.ToString() + "\" flr=\"" + ForeignLanguages3Reading.ToString() + "\" /> "; 
                }
                strForeignLanguages += " </ForeignLanguages>";
            }


            DataTable dt;
            try
            {
                PIKCV.DAL.User obj = new PIKCV.DAL.User();
                dt = null;
                dt = obj.GetEmployeeSearchResults(strGender, strAgeRange, strMaritalStates, strMilitaryStates, DriverLicenceTypes,
                Handicapped, Convicted, MartyrRelative, TerrorAggrieved,
                strCountries, strTurkeyCities, strEducationLevels, strEducationStates, strHighSchoolEducationLevels,
                HighSchoolTypes, strUniversityEducationLevels, UniversityNames, DepartmentNames, strSectors, strPositions, strExperience,
                strLabouringTypes, strForeignLanguages, strComputerKnowledgeTypes, strSectorsDesired,
                strPositionsDesired, strCountriesDesired, strCitiesDesired, strLabouringTypesDesired, EmployeeSearchType, CompanyID, JobID, strApplicationStatus);
            }
            catch (Exception)
            {
                dt = null;
                throw;
            }
            return dt;
        }

        public static bool RemoveUser(int UserID) {
            try
            {
                PIKCV.DAL.User objUser = new PIKCV.DAL.User();
                objUser.LoadByPrimaryKey(UserID);
                objUser.IsDeleted = true;
                objUser.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
