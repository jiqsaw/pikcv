using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections;
using PIKCV.COM;

public class BaseUserControl : BaseControl
{
    #region : CACHE ITEMS :

    public DataTable cmbErrors {
        get {
            CM CM = new CM();
            EnumUtil.CacheTypes CacheType = EnumUtil.CacheTypes.Errors;
            EnumUtil.CachePeriods CachePeriod = EnumUtil.CachePeriods.Errors;
            string CacheDescription = "HATALAR";
            int SplitID = (int)this.smLanguageID;

            if (this.GetCache(CacheType, SplitID) == null) {
                DataTable dtCacheData = PIKCV.BUS.Error.LoadAllML();
                this.GenerateCache(CacheType, CachePeriod, CacheDescription, dtCacheData); 
            }
            return ((CM.CacheValue)this.GetCache(CacheType, SplitID)).Data;
        }
    }

    public DataTable cmbCountries {
        get {
            CM CM = new CM();
            EnumUtil.CacheTypes CacheType = EnumUtil.CacheTypes.Countries;
            EnumUtil.CachePeriods CachePeriod = EnumUtil.CachePeriods.Countries;
            string CacheDescription = "ÜLKELER";
            int SplitID = (int)this.smLanguageID;

            if (this.GetCache(CacheType, SplitID) == null) {
                DataTable dtCacheData = PIKCV.BUS.Places.GetCountries(false);
                this.GenerateCache(CacheType, CachePeriod, CacheDescription, dtCacheData); 
            }
            return ((CM.CacheValue)this.GetCache(CacheType, SplitID)).Data;
        }
    }

    public DataTable cmbTurkeyCities {
        get {
            CM CM = new CM();
            EnumUtil.CacheTypes CacheType = EnumUtil.CacheTypes.TurkeyCities;
            EnumUtil.CachePeriods CachePeriod = EnumUtil.CachePeriods.TurkeyCities;
            string CacheDescription = "TÜRKÝYE ÞEHÝRLERÝ";
            int SplitID = (int)this.smLanguageID;

            if (this.GetCache(CacheType, SplitID) == null) {
                DataTable dtCacheData = PIKCV.BUS.Places.GetCities(((int)EnumDB.Places.TurkeyPlaceID), false);
                this.GenerateCache(CacheType, CachePeriod, CacheDescription, dtCacheData); 
            }
            return ((CM.CacheValue)this.GetCache(CacheType, SplitID)).Data;
        }
    }

    public DataTable cmbSectors {
        get {
            CM CM = new CM();
            EnumUtil.CacheTypes CacheType = EnumUtil.CacheTypes.Sectors;
            EnumUtil.CachePeriods CachePeriod = EnumUtil.CachePeriods.Sectors;
            string CacheDescription = "SEKTÖRLER";
            int SplitID = (int)this.smLanguageID;

            if (this.GetCache(CacheType, SplitID) == null) {
                DataTable dtCacheData = PIKCV.BUS.Sector.LoadAllML(false);
                this.GenerateCache(CacheType, CachePeriod, CacheDescription, dtCacheData); 
            }
            return ((CM.CacheValue)this.GetCache(CacheType, SplitID)).Data;
        }
    }

    public DataTable cmbPositions {
        get {
            CM CM = new CM();
            EnumUtil.CacheTypes CacheType = EnumUtil.CacheTypes.Positions;
            EnumUtil.CachePeriods CachePeriod = EnumUtil.CachePeriods.Positions;
            string CacheDescription = "POZÝSYONLAR";
            int SplitID = (int)this.smLanguageID;

            if (this.GetCache(CacheType, SplitID) == null) {
                DataTable dtCacheData = PIKCV.BUS.Position.LoadAllML(false);
                this.GenerateCache(CacheType, CachePeriod, CacheDescription, dtCacheData); 
            }
            return ((CM.CacheValue)this.GetCache(CacheType, SplitID)).Data;
        }
    }
    
    public DataTable cmbMaritalStates {
        get
        {
            CM CM = new CM();
            EnumUtil.CacheTypes CacheType = EnumUtil.CacheTypes.MaritalStates;
            EnumUtil.CachePeriods CachePeriod = EnumUtil.CachePeriods.MaritalStates;
            string CacheDescription = "MEDENÝ HALLER";
            int SplitID = (int)this.smLanguageID;

            if (this.GetCache(CacheType, SplitID) == null)
            {
                DataTable dtCacheData = PIKCV.BUS.MaritalStates.LoadAllML(false);
                this.GenerateCache(CacheType, CachePeriod, CacheDescription, dtCacheData);
            }
            return ((CM.CacheValue)this.GetCache(CacheType, SplitID)).Data;
        }
    }

    public DataTable cmbMilitaryStates {
        get
        {
            CM CM = new CM();
            EnumUtil.CacheTypes CacheType = EnumUtil.CacheTypes.MilitaryStates;
            EnumUtil.CachePeriods CachePeriod = EnumUtil.CachePeriods.MilitaryStates;
            string CacheDescription = "ASKERLÝK DURUMLARI";
            int SplitID = (int)this.smLanguageID;

            if (this.GetCache(CacheType, SplitID) == null)
            {
                DataTable dtCacheData = PIKCV.BUS.MilitaryStates.LoadAllML(false);
                this.GenerateCache(CacheType, CachePeriod, CacheDescription, dtCacheData);
            }
            return ((CM.CacheValue)this.GetCache(CacheType, SplitID)).Data;
        }
    }

    public DataTable cmbEducationStates {
        get
        {
            CM CM = new CM();
            EnumUtil.CacheTypes CacheType = EnumUtil.CacheTypes.EducationStates;
            EnumUtil.CachePeriods CachePeriod = EnumUtil.CachePeriods.EducationStates;
            string CacheDescription = "EÐÝTÝM DURUMLARI";
            int SplitID = (int)this.smLanguageID;

            if (this.GetCache(CacheType, SplitID) == null)
            {
                DataTable dtCacheData = PIKCV.BUS.Education.GetAllEducationStates(false);
                this.GenerateCache(CacheType, CachePeriod, CacheDescription, dtCacheData);
            }
            return ((CM.CacheValue)this.GetCache(CacheType, SplitID)).Data;
        }
    }

    public DataTable cmbSchools
    {
        get
        {
            CM CM = new CM();
            EnumUtil.CacheTypes CacheType = EnumUtil.CacheTypes.Schools;
            EnumUtil.CachePeriods CachePeriod = EnumUtil.CachePeriods.Schools;
            string CacheDescription = "OKULLAR";
            int SplitID = (int)this.smLanguageID;

            if (this.GetCache(CacheType, SplitID) == null)
            {
                DataTable dtCacheData = PIKCV.BUS.Education.GetAllSchools(false);
                this.GenerateCache(CacheType, CachePeriod, CacheDescription, dtCacheData);
            }
            return ((CM.CacheValue)this.GetCache(CacheType, SplitID)).Data;
        }
    }

    public DataTable cmbDriverLicenceTypes
    {
        get
        {
            CM CM = new CM();
            EnumUtil.CacheTypes CacheType = EnumUtil.CacheTypes.DriverLicenceTypes;
            EnumUtil.CachePeriods CachePeriod = EnumUtil.CachePeriods.DriverLicenceTypes;
            string CacheDescription = "TÜM EHLÝYET TÝPLERÝ";
            int SplitID = (int)this.smLanguageID;

            if (this.GetCache(CacheType, SplitID) == null)
            {
                DataTable dtCacheData = PIKCV.BUS.DriverLicence.GetAllDriverLicenceTypes(false);
                this.GenerateCache(CacheType, CachePeriod, CacheDescription, dtCacheData);
            }
            return ((CM.CacheValue)this.GetCache(CacheType, SplitID)).Data;
        }
    }

    public DataTable cmbLabouringTypes
    {
        get
        {
            CM CM = new CM();
            EnumUtil.CacheTypes CacheType = EnumUtil.CacheTypes.LabouringTypes;
            EnumUtil.CachePeriods CachePeriod = EnumUtil.CachePeriods.LabouringTypes;
            string CacheDescription = "TÜM ÇALIÞMA ÞEKÝLLERÝ";
            int SplitID = (int)this.smLanguageID;

            if (this.GetCache(CacheType, SplitID) == null)
            {
                DataTable dtCacheData = PIKCV.BUS.LabouringTypes.LoadAllML(false);
                this.GenerateCache(CacheType, CachePeriod, CacheDescription, dtCacheData);
            }
            return ((CM.CacheValue)this.GetCache(CacheType, SplitID)).Data;
        }
    }

    public DataTable cmbComputerKnowledgeTypes
    {
        get
        {
            CM CM = new CM();
            EnumUtil.CacheTypes CacheType = EnumUtil.CacheTypes.ComputerKnowledgeTypes;
            EnumUtil.CachePeriods CachePeriod = EnumUtil.CachePeriods.ComputerKnowledgeTypes;
            string CacheDescription = "TÜM BÝLGSAYAR BÝLGÝ TÝPLERÝ";
            int SplitID = (int)this.smLanguageID;

            if (this.GetCache(CacheType, SplitID) == null)
            {
                DataTable dtCacheData = PIKCV.BUS.ComputerKnowledgeTypes.GetComputerKnowledgeTypesAll(false);
                this.GenerateCache(CacheType, CachePeriod, CacheDescription, dtCacheData);
            }
            return ((CM.CacheValue)this.GetCache(CacheType, SplitID)).Data;
        }
    }

    public DataTable cmbForeignLanguages
    {
        get
        {
            CM CM = new CM();
            EnumUtil.CacheTypes CacheType = EnumUtil.CacheTypes.ForeignLanguages;
            EnumUtil.CachePeriods CachePeriod = EnumUtil.CachePeriods.ForeignLanguages;
            string CacheDescription = "TÜM YABANCI DÝLLER";
            int SplitID = (int)this.smLanguageID;

            if (this.GetCache(CacheType, SplitID) == null)
            {
                DataTable dtCacheData = PIKCV.BUS.ForeignLanguages.GetForeignLanguagesAll(false);
                this.GenerateCache(CacheType, CachePeriod, CacheDescription, dtCacheData);
            }
            return ((CM.CacheValue)this.GetCache(CacheType, SplitID)).Data;
        }
    }

    public DataTable cmbForeignLanguageExams
    {
        get
        {
            CM CM = new CM();
            EnumUtil.CacheTypes CacheType = EnumUtil.CacheTypes.ForeignLanguageExams;
            EnumUtil.CachePeriods CachePeriod = EnumUtil.CachePeriods.ForeignLanguageExams;
            string CacheDescription = "TÜM YABANCI DÝL SINAVLARI";

            if (this.GetCache(CacheType) == null)
            {
                DataTable dtCacheData = PIKCV.BUS.ForeignLanguages.GetForeignLanguageExams(false);
                this.GenerateCache(CacheType, CachePeriod, CacheDescription, dtCacheData);
            }
            return ((CM.CacheValue)this.GetCache(CacheType)).Data;
        }
    }

    public DataTable cmbLevels
    {
        get
        {
            CM CM = new CM();
            EnumUtil.CacheTypes CacheType = EnumUtil.CacheTypes.Levels;
            EnumUtil.CachePeriods CachePeriod = EnumUtil.CachePeriods.Levels;
            string CacheDescription = "TÜM LEVELLER";
            int SplitID = (int)this.smLanguageID;

            if (this.GetCache(CacheType, SplitID) == null)
            {
                DataTable dtCacheData = PIKCV.BUS.Levels.GetLevelsAll(false);
                this.GenerateCache(CacheType, CachePeriod, CacheDescription, dtCacheData);
            }
            return ((CM.CacheValue)this.GetCache(CacheType, SplitID)).Data;
        }
    }

    public DataTable cmbEducationLevels
    {
        get
        {
            CM CM = new CM();
            EnumUtil.CacheTypes CacheType = EnumUtil.CacheTypes.EducationLevels;
            EnumUtil.CachePeriods CachePeriod = EnumUtil.CachePeriods.EducationLevels;
            string CacheDescription = "TÜM EÐÝTÝM SEVÝYELERÝ";
            int SplitID = (int)this.smLanguageID;

            if (this.GetCache(CacheType, SplitID) == null)
            {
                DataTable dtCacheData = PIKCV.BUS.Education.GetAllEducationLevels(false);
                this.GenerateCache(CacheType, CachePeriod, CacheDescription, dtCacheData);
            }
            return ((CM.CacheValue)this.GetCache(CacheType, SplitID)).Data;
        }
    }

    public DataTable cmbCompanies
    {
        get
        {
            CM CM = new CM();
            EnumUtil.CacheTypes CacheType = EnumUtil.CacheTypes.Companies;
            EnumUtil.CachePeriods CachePeriod = EnumUtil.CachePeriods.Companies;
            string CacheDescription = "TÜM FÝRMALAR";

            if (this.GetCache(CacheType)== null)
            {
                DataTable dtCacheData = PIKCV.BUS.Company.GetAllCompanies(false, true, true);
                this.GenerateCache(CacheType, CachePeriod, CacheDescription, dtCacheData);
            }
            return ((CM.CacheValue)this.GetCache(CacheType)).Data;
        }
    }

    public DataTable cmbPerfection
    {
        get
        {
            CM CM = new CM();
            EnumUtil.CacheTypes CacheType = EnumUtil.CacheTypes.Perfection;
            EnumUtil.CachePeriods CachePeriod = EnumUtil.CachePeriods.Perfection;
            string CacheDescription = "TÜM YETKÝNLÝKLER";
            int SplitID = (int)this.smLanguageID;

            if (this.GetCache(CacheType, SplitID) == null)
            {
                DataTable dtCacheData = PIKCV.BUS.Perfection.LoadAllML(false);
                this.GenerateCache(CacheType, CachePeriod, CacheDescription, dtCacheData);
            }
            return ((CM.CacheValue)this.GetCache(CacheType, SplitID)).Data;
        }
    }

    public DataTable cmbInterviewStatus
    {
        get
        {
            CM CM = new CM();
            EnumUtil.CacheTypes CacheType = EnumUtil.CacheTypes.InterviewStatus;
            EnumUtil.CachePeriods CachePeriod = EnumUtil.CachePeriods.InterviewStatus;
            string CacheDescription = "TÜM MÜLAKAT STATÜLERÝ";
            int SplitID = (int)this.smLanguageID;

            if (this.GetCache(CacheType, SplitID) == null)
            {
                DataTable dtCacheData = PIKCV.BUS.InterviewStates.LoadAllML(false);
                this.GenerateCache(CacheType, CachePeriod, CacheDescription, dtCacheData);
            }
            return ((CM.CacheValue)this.GetCache(CacheType, SplitID)).Data;
        }
    }

    public DataTable cmbMainJobs
    {
        get
        {
            CM CM = new CM();
            EnumUtil.CacheTypes CacheType = EnumUtil.CacheTypes.MainJobs;
            EnumUtil.CachePeriods CachePeriod = EnumUtil.CachePeriods.MainJobs;
            string CacheDescription = "ELEMAN ANA SAYFA ÝLK ÝLANLAR";

            if (this.GetCache(CacheType) == null)
            {
                DataTable dtCacheData = PIKCV.BUS.Job.GetMainJobs(EnumDB.JobStatus.Active);
                this.GenerateCache(CacheType, CachePeriod, CacheDescription, dtCacheData);
            }
            return ((CM.CacheValue)this.GetCache(CacheType)).Data;
        }
    }
    #endregion

    #region : COOKIE ITEMS :

    public Enumerations.PageType cookPageType {
        get {
            Cookie Cookie = new Cookie();
            if (Cookie.Read(EnumUtil.Cookies.PageType) != String.Empty)
            {
                return (Enumerations.PageType)(int.Parse(Cookie.Read(EnumUtil.Cookies.PageType)));
            }
            else {
                return Enumerations.PageType.Entry;
            }
        }
        set {
            Cookie Cookie = new Cookie();
            Cookie.Write(EnumUtil.Cookies.PageType, ((int)value).ToString());
        }
    }

    public string cookUserIP
    {
        get
        {
            Cookie Cookie = new Cookie();
            return (Cookie.Read(EnumUtil.Cookies.UserIP));
        }
        set
        {
            Cookie Cookie = new Cookie();
            Cookie.Write(EnumUtil.Cookies.UserIP, value);
        }
    }

    #endregion
    
    protected void GoToEmployeePage()
    {
        HttpContext.Current.Response.Redirect("~/" + this.Config(EnumUtil.Config.PageNameEmployee));
    }

    protected void GoToCompanyPage()
    {
        HttpContext.Current.Response.Redirect("~/" + this.Config(EnumUtil.Config.PageNameCompany));
    }

    protected void Redirect(string URL)
    {
        Response.Redirect("Pikcv.aspx?Pik=" + URL);
    }

    protected void GoToFeedback(PIKCV.COM.EnumDB.ErrorTypes ErrorType)
    {
        this.Redirect("Common-Feedback&Code=" + (int)(ErrorType));
    }

    protected string OpenConfirm(PIKCV.COM.EnumDB.ErrorTypes ErrorType) {
        return OpenConfirm(ErrorType, -1, String.Empty);
    }

    protected string OpenConfirm(PIKCV.COM.EnumDB.ErrorTypes ErrorType, string ArgStr)
    {
        return OpenConfirm(ErrorType, -1, ArgStr);
    }

    protected string OpenConfirm(PIKCV.COM.EnumDB.ErrorTypes ErrorType, int ArgID)
    {
        return OpenConfirm(ErrorType, ArgID, String.Empty);
    }

    protected string OpenConfirm(PIKCV.COM.EnumDB.ErrorTypes ErrorType, int ArgID, string ArgStr)
    {
        return "javascript:OpenConfirm(" + ((int)(ErrorType)).ToString() + ", " + ArgID.ToString() + ", '" + ArgStr + "')";
    }

    protected void LogOut() {
        Application.Remove(ReturnApplicationKey());
        Session.Clear();
        Session.Abandon();
    }

    protected void Page_Init(object sender, EventArgs e)
    {
        if (this.smIsLogin)
        {
            if (!ExistLogin()) {
                if (Application.Contents[ReturnApplicationKey()] != null) Application.Contents[ReturnApplicationKey()] = DateTime.Now;
                else Application.Add(ReturnApplicationKey(), DateTime.Now);
            }
            else Application.Contents[ReturnApplicationKey()] = DateTime.Now;
        }
    }

    private string ReturnApplicationKey() {
        return ((int)this.smMemberType).ToString() + "||" + this.smUserID.ToString();
    }

    protected bool ExistLogin() {
        return !((Application.Contents[ReturnApplicationKey()] == null) || (Convert.ToDateTime(Application.Contents[ReturnApplicationKey()]) < DateTime.Now.AddMinutes(Convert.ToInt32(this.Config(EnumUtil.Config.RefreshTime)) * -1)));
    }
}
