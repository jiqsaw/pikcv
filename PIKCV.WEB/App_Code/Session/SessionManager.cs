using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using PIKCV.COM;
using System.Collections;

public class SM : System.Web.UI.UserControl
{
    private void SET(EnumUtil.Sess SessionName, object Value) { System.Web.HttpContext.Current.Session[SessionName.ToString()] = Value; }
    private object GET(EnumUtil.Sess SessionName) { return System.Web.HttpContext.Current.Session[SessionName.ToString()]; }

    public EnumDB.LanguageID smLanguageID
    {
        get { return (GET(EnumUtil.Sess.LanguageID) == null ? EnumDB.LanguageID.Turkish : (EnumDB.LanguageID)((int)GET(EnumUtil.Sess.LanguageID))); }
        set { SET(EnumUtil.Sess.LanguageID, (int)value); }
    }

    public bool smIsLogin
    {
        get { return (GET(EnumUtil.Sess.IsLogin) == null ? false : Convert.ToBoolean(GET(EnumUtil.Sess.IsLogin))); }
        set { SET(EnumUtil.Sess.IsLogin, value); }
    }

    public EnumDB.MemberTypes smMemberType
    {
        get { return (GET(EnumUtil.Sess.MemberType) == null ? EnumDB.MemberTypes.Unknown : (EnumDB.MemberTypes)((int)GET(EnumUtil.Sess.MemberType))); }
        set { SET(EnumUtil.Sess.MemberType, (int)value); }
    }

    public int smUserID
    {
        get { return (GET(EnumUtil.Sess.UserID) == null ? -1 : (int)GET(EnumUtil.Sess.UserID)); }
        set { SET(EnumUtil.Sess.UserID, value); }
    }

    public EnumDB.CVFocusCode smCVFocus
    {
        get { return (GET(EnumUtil.Sess.CVFocus) == null ? EnumDB.CVFocusCode.PersonalInfo : (EnumDB.CVFocusCode)((int)GET(EnumUtil.Sess.CVFocus))); }
        set { SET(EnumUtil.Sess.CVFocus, (int)value); }
    }

    public EnumDB.JobsFocusCode smJobFocus
    {
        get { return (GET(EnumUtil.Sess.JobFocus) == null ? EnumDB.JobsFocusCode.JobType : (EnumDB.JobsFocusCode)((int)GET(EnumUtil.Sess.JobFocus))); }
        set { SET(EnumUtil.Sess.JobFocus, (int)value); }
    }

    public Enumerations.JobSaveType smJobSaveType
    {
        get { return (GET(EnumUtil.Sess.JobSaveType) == null ? Enumerations.JobSaveType.NewJobEntry : (Enumerations.JobSaveType)((int)GET(EnumUtil.Sess.JobSaveType))); }
        set { SET(EnumUtil.Sess.JobSaveType, (int)value); }
    }

    public EnumDB.EmployeeTypes smEmployeeType
    {
        get { return (GET(EnumUtil.Sess.EmployeeType) == null ? EnumDB.EmployeeTypes.Unknown : (EnumDB.EmployeeTypes)((int)GET(EnumUtil.Sess.EmployeeType))); }
        set { SET(EnumUtil.Sess.EmployeeType, (int)value); }
    }

    public string smUserEmail
    {
        get { return (GET(EnumUtil.Sess.Email) == null ? String.Empty : GET(EnumUtil.Sess.Email).ToString()); }
        set { SET(EnumUtil.Sess.Email, value); }
    }

    public bool smIsEmailConfirmed
    {
        get { return (GET(EnumUtil.Sess.IsEmailConfirmed) == null ? false : Convert.ToBoolean(GET(EnumUtil.Sess.IsEmailConfirmed).ToString())); }
        set { SET(EnumUtil.Sess.IsEmailConfirmed, value); }
    }

    public bool smIsFirstLogin
    {
        get { return (GET(EnumUtil.Sess.IsFirstLogin) == null ? false : Convert.ToBoolean(GET(EnumUtil.Sess.IsFirstLogin).ToString())); }
        set { SET(EnumUtil.Sess.IsFirstLogin, value); }
    }

    public string smFirstName
    {
        get { return (GET(EnumUtil.Sess.FirstName) == null ? String.Empty : GET(EnumUtil.Sess.FirstName).ToString()); }
        set { SET(EnumUtil.Sess.FirstName, value); }
    }

    public string smLastName
    {
        get { return (GET(EnumUtil.Sess.LastName) == null ? String.Empty : GET(EnumUtil.Sess.LastName).ToString()); }
        set { SET(EnumUtil.Sess.LastName, value); }
    }

    public DateTime smLastLoginDate
    {
        get { return (GET(EnumUtil.Sess.LastLoginDate) == null ? DateTime.MaxValue : Convert.ToDateTime(GET(EnumUtil.Sess.LastLoginDate).ToString())); }
        set { SET(EnumUtil.Sess.LastLoginDate, value); }
    }

    public bool smIsCvActive
    {
        get { return (GET(EnumUtil.Sess.IsCvActive) == null ? false : Convert.ToBoolean(GET(EnumUtil.Sess.IsCvActive).ToString())); }
        set { SET(EnumUtil.Sess.IsCvActive, value); }
    }

    public bool smIsCvConfirmed
    {
        get { return (GET(EnumUtil.Sess.IsCvConfirmed) == null ? false : Convert.ToBoolean(GET(EnumUtil.Sess.IsCvConfirmed).ToString())); }
        set { SET(EnumUtil.Sess.IsCvConfirmed, value); }
    }

    public string smPhotoFileName
    {
        get { return (GET(EnumUtil.Sess.PhotoFileName) == null ? String.Empty : GET(EnumUtil.Sess.PhotoFileName).ToString()); }
        set { SET(EnumUtil.Sess.PhotoFileName, value); }
    }

    public string smCompanyName
    {
        get { return (GET(EnumUtil.Sess.CompanyName) == null ? String.Empty : GET(EnumUtil.Sess.CompanyName).ToString()); }
        set { SET(EnumUtil.Sess.CompanyName, value); }
    }

    public string smPikCredi
    {
        get { return (GET(EnumUtil.Sess.PikCredi) == null ? String.Empty : GET(EnumUtil.Sess.PikCredi).ToString()); }
        set { SET(EnumUtil.Sess.PikCredi, value); }
    }

    public int smCompanyID
    {
        get { return (GET(EnumUtil.Sess.CompanyID) == null ? 0 : (int)GET(EnumUtil.Sess.CompanyID)); }
        set { SET(EnumUtil.Sess.CompanyID, value); }
    }

    public ArrayList smListFilterTypes {
        get { return (GET(EnumUtil.Sess.ListFilterTypes) == null ? new ArrayList() : (ArrayList)GET(EnumUtil.Sess.ListFilterTypes)); }
        set { SET(EnumUtil.Sess.ListFilterTypes, value); }    
    }

    public int smJobID
    {
        get { return (GET(EnumUtil.Sess.JobID) == null ? 0 : (int)GET(EnumUtil.Sess.JobID)); }
        set { SET(EnumUtil.Sess.JobID, value); }
    }

    public ArrayList smInterviewUserIDs
    {
        get { return (GET(EnumUtil.Sess.InterviewUserIDs) == null ? new ArrayList() : (ArrayList)GET(EnumUtil.Sess.InterviewUserIDs)); }
        set { SET(EnumUtil.Sess.InterviewUserIDs, value); }
    }

    public ArrayList smBuyContactInfoResultUserIDs
    {
        get { return (GET(EnumUtil.Sess.BuyContactInfoResultUserIDs) == null ? new ArrayList() : (ArrayList)GET(EnumUtil.Sess.BuyContactInfoResultUserIDs)); }
        set { SET(EnumUtil.Sess.BuyContactInfoResultUserIDs, value); }
    }

    public ArrayList smMessageUserIDs
    {
        get { return (GET(EnumUtil.Sess.MessageUserIDs) == null ? new ArrayList() : (ArrayList)GET(EnumUtil.Sess.MessageUserIDs)); }
        set { SET(EnumUtil.Sess.MessageUserIDs, value); }
    }

    public struct JobSearchQuery
    {
        public string Keyword;
        public ArrayList Positions;
        public ArrayList Sectors;
        public ArrayList Cities;
        public ArrayList Companies;
        public ArrayList EducationLevels;
        public PIKCV.COM.EnumDB.AgeRange AgeRange;
        public ArrayList LabouringTypes;
        public int JobDate;
        public bool CustomJobs;
    }
    public JobSearchQuery smJobSearchQueries
    {
        get { return (JobSearchQuery)GET(EnumUtil.Sess.JobSearchQueries); }
        set { SET(EnumUtil.Sess.JobSearchQueries, value); }
    }

    public struct EmployeeSearchQueries
    {
        public ArrayList Gender;
        public ArrayList AgeRange;
        public ArrayList MaritalStates;
        public ArrayList MilitaryStates;
        public int DriverLicenceTypes;
        public bool Handicapped;
        public bool Convicted;
        public bool MartyrRelative;
        public bool TerrorAggrieved;

        public ArrayList Countries;
        public ArrayList TurkeyCities;

        public ArrayList EducationLevels;
        public ArrayList EducationStates;
        public ArrayList HighSchoolEducationLevels;
        public int HighSchoolTypes;
        public ArrayList UniversityEducationLevels;
        public int UniversityNames;
        public int DepartmentNames;

        public ArrayList Sectors;
        public ArrayList Positions;
        public ArrayList Experience;
        public ArrayList LabouringTypes;

        public int ForeignLanguages1;
        public int ForeignLanguages1Reading;
        public int ForeignLanguages1Writing;
        public int ForeignLanguages1Speaking;
        public int ForeignLanguages2;
        public int ForeignLanguages2Reading;
        public int ForeignLanguages2Writing;
        public int ForeignLanguages2Speaking;
        public int ForeignLanguages3;
        public int ForeignLanguages3Reading;
        public int ForeignLanguages3Writing;
        public int ForeignLanguages3Speaking;

        public ArrayList ForeignLanguages;
        public ArrayList ForeignLanguagesReading;
        public ArrayList ForeignLanguagesWriting;
        public ArrayList ForeignLanguagesSpeaking;

        //public DataTable dtForeignLanguages;

        public ArrayList ComputerKnowledgeTypes;
        public ArrayList SectorsDesired;
        public ArrayList PositionsDesired;
        public ArrayList CountriesDesired;
        public ArrayList CitiesDesired;
        public ArrayList LabouringTypesDesired;
        public PIKCV.COM.EnumDB.EmployeeTypes EmployeeSearchType;
        public ArrayList ApplicationStatus;
        public int JobID;

    }
    public EmployeeSearchQueries smEmployeeSearchQueries
    {
        get { return (EmployeeSearchQueries)GET(EnumUtil.Sess.EmployeeSearchQueries); }
        set { SET(EnumUtil.Sess.EmployeeSearchQueries, value); }
    }

    public ArrayList smEmployeeSearchResultUserIDs
    {
        get { return (GET(EnumUtil.Sess.EmployeeSearchResultUserIDs ) == null ? new ArrayList() : (ArrayList)GET(EnumUtil.Sess.EmployeeSearchResultUserIDs )); }
        set { SET(EnumUtil.Sess.EmployeeSearchResultUserIDs , value); }
    }

    public string smSecurityImage
    {
        get { return (GET(EnumUtil.Sess.SecurityImage) == null ? string.Empty : GET(EnumUtil.Sess.SecurityImage).ToString()); }
        set { SET(EnumUtil.Sess.SecurityImage, value); }
    }

    public ArrayList smCompanyJobs
    {
        get { return (GET(EnumUtil.Sess.CompanyJobs) == null ? new ArrayList() : (ArrayList)GET(EnumUtil.Sess.CompanyJobs)); }
        set { SET(EnumUtil.Sess.CompanyJobs, value); }
    }

    public string smRememberURL
    {
        get { return (GET(EnumUtil.Sess.RememberURL) == null ? string.Empty : GET(EnumUtil.Sess.RememberURL).ToString()); }
        set { SET(EnumUtil.Sess.RememberURL, value); }
    }

    public int smTemporaryUserID
    {
        get { return (GET(EnumUtil.Sess.TemporaryUserID) == null ? 0 : (int)GET(EnumUtil.Sess.TemporaryUserID)); }
        set { SET(EnumUtil.Sess.TemporaryUserID, value); }
    }

    public int smSecretAnswerCount
    {
        get { return (GET(EnumUtil.Sess.SecretAnswerCount) == null ? 0 : (int)GET(EnumUtil.Sess.SecretAnswerCount)); }
        set { SET(EnumUtil.Sess.SecretAnswerCount, value); }
    }

    public Enumerations.JobDetailRefererUrl smJobDetailRefererUrl
    {
        get { return (GET(EnumUtil.Sess.JobDetailRefererUrl) == null ? Enumerations.JobDetailRefererUrl.MainPage : (Enumerations.JobDetailRefererUrl)((int)GET(EnumUtil.Sess.JobDetailRefererUrl))); }
        set { SET(EnumUtil.Sess.JobDetailRefererUrl, (int)value); }
    }
}