using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using CARETTA.COM;

public partial class UserControls_Employee_Jobs_uJobDetail : BaseUserControl
{
    public string PageReferer
    {
        get
        {
            if (ViewState["Prf"] == null)
            {
                ViewState.Add("Prf", "Pikcv.aspx?Pik=Employee-EmployeeLogon");
            }
            return ViewState["Prf"].ToString();
        }
        set { ViewState.Add("Prf", value); }
    }
    private DataTable dtJob;
    private int JobID;
    private PIKCV.COM.EnumDB.EmployeeTypes PositonType;
    

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            switch (this.smJobDetailRefererUrl)
            {
                case PIKCV.COM.Enumerations.JobDetailRefererUrl.MainPage:
                    this.PageReferer = "Pikcv.aspx?Pik=Employee-EmployeeLogon";
                    break;
                case PIKCV.COM.Enumerations.JobDetailRefererUrl.JobSearch:
                    this.PageReferer = "Pikcv.aspx?Pik=Employee-Jobs-Jobs";
                    break;
                case PIKCV.COM.Enumerations.JobDetailRefererUrl.JobApplicants:
                    this.PageReferer = "Pikcv.aspx?Pik=Employee-JobApplicants-JobApplicants";
                    break;
            }

            if (CARETTA.COM.Util.IsNumeric(Request.QueryString["JobID"]))
            {
                this.JobID = int.Parse(Request.QueryString["JobID"]);
            }
            else { this.GoToDefaultPage(); }

            FillData();

        }
    }

    private void FillData()
    {

        this.dtJob = PIKCV.BUS.Job.GetJobDetail(this.JobID);
        if (dtJob.Rows.Count < 1) { this.GoToDefaultPage(); }

        PIKCV.BUS.Company objCompany = new PIKCV.BUS.Company();
        DataTable dtCompany = objCompany.GetCompanyInfo(Convert.ToInt32(this.dtJob.Rows[0]["CompanyID"]));
        ltlCompanyName.Text = dtCompany.Rows[0]["CompanyName"].ToString();

        string PositionName = dtJob.Rows[0]["PositionName"].ToString();
        this.PositonType = (PIKCV.COM.EnumDB.EmployeeTypes)Convert.ToInt32(DataTableHelper.Filter(this.cmbPositions, "PositionID", dtJob.Rows[0]["PositionID"].ToString()).Rows[0]["PositionTypeCode"]);

        ltlPositionName.Text = PositionName;
        ltlRefNo.Text = dtJob.Rows[0]["ReferenceNumber"].ToString();
        
        if (dtJob.Rows[0]["PhotoFileName"].ToString().Trim() == String.Empty) imgLogo.Visible = false;
        else imgLogo.ImageUrl = "~/" + this.Config(PIKCV.COM.EnumUtil.Config.CompanyImagePath) + dtJob.Rows[0]["PhotoFileName"].ToString();
        
        ltlJobTitle.Text = dtJob.Rows[0]["JobTitle"].ToString();

        ltlNumberOfWorkers.Text = dtJob.Rows[0]["NumberOfWorkers"].ToString();
        ltlStartDate.Text = Convert.ToDateTime(dtJob.Rows[0]["StartDate"]).ToShortDateString();
        ltlEndDate.Text = Convert.ToDateTime(dtJob.Rows[0]["EndDate"]).ToShortDateString();

        PIKCV.BUS.Job objJob = new PIKCV.BUS.Job();
        DataBindHelper.BindRepeater(ref rptJobSectors, objJob.GetJobSectorNames(this.JobID));
        
        DataBindHelper.BindRepeater(ref rptJobPlaces, objJob.GetJobPlaceNames(this.JobID, PIKCV.COM.EnumDB.Places.TurkeyPlaceID));
        DataBindHelper.BindRepeater(ref rptJobCountries, objJob.GetJobPlaceNames(this.JobID, PIKCV.COM.EnumDB.Places.CountriesParentID));

        ltlJobDescription.Text = Util.Nl2Br(dtJob.Rows[0]["JobDescription"].ToString());
        DataBindHelper.BindRepeater(ref rptEducationLevels, objJob.GetJobEducationLevels(this.JobID, PIKCV.COM.EnumDB.LanguageID.Turkish));
        DataBindHelper.BindRepeater(ref rptJobQualitySectors, objJob.GetJobQualitySectorNames(this.JobID));

        DataBindHelper.BindRepeater(ref rptJobQualityPositions, objJob.GetJobQualityPositionNames(this.JobID));
        
        DataBindHelper.BindRepeater(ref rptPerfections, objJob.GetJobPerfection(this.JobID));
        ltlJobLabouringTypeName.Text = DataTableHelper.Filter(this.cmbLabouringTypes, "LabouringTypeID", dtJob.Rows[0]["LabouringTypeID"].ToString()).Rows[0]["LabouringTypeName"].ToString();

        ltlDisabled.Visible = Convert.ToBoolean(dtJob.Rows[0]["IsDisabled"]);
        ltlOldConvicted.Visible = Convert.ToBoolean(dtJob.Rows[0]["IsOldConvicted"]);
        ltlMartyrRelative.Visible = Convert.ToBoolean(dtJob.Rows[0]["IsMartyrRelative"]);
        ltlTerrorWronged.Visible = Convert.ToBoolean(dtJob.Rows[0]["IsTerrorWronged"]);

        dvJobProperties.Visible = ((ltlMartyrRelative.Visible) || (ltlDisabled.Visible) || (ltlOldConvicted.Visible) || (ltlTerrorWronged.Visible));

        PIKCV.COM.EnumDB.SexCode JobSexCode = (PIKCV.COM.EnumDB.SexCode)Convert.ToInt32(dtJob.Rows[0]["Gender"]);
        switch (JobSexCode)
        {
            case PIKCV.COM.EnumDB.SexCode.Male:
                ltlSex.Text = "Erkek";
                break;
            case PIKCV.COM.EnumDB.SexCode.Female:
                ltlSex.Text = "Kadýn";
                break;
            case PIKCV.COM.EnumDB.SexCode.Both:
                ltlSex.Text = "Erkek - Kadýn";
                break;
        }

        PIKCV.COM.EnumDB.AgeRange Age = (PIKCV.COM.EnumDB.AgeRange)Convert.ToInt32(dtJob.Rows[0]["AgeRange"]);
        switch (Age)
        {
            case PIKCV.COM.EnumDB.AgeRange.age_18_24:
                ltlAgeRange.Text = "18-24";
                break;
            case PIKCV.COM.EnumDB.AgeRange.age_25_29:
                ltlAgeRange.Text = "25-29";
                break;
            case PIKCV.COM.EnumDB.AgeRange.age_30_34:
                ltlAgeRange.Text = "30-34";
                break;
            case PIKCV.COM.EnumDB.AgeRange.age_35_39:
                ltlAgeRange.Text = "35-39";
                break;
            case PIKCV.COM.EnumDB.AgeRange.age_40_44:
                ltlAgeRange.Text = "40-44";
                break;
            case PIKCV.COM.EnumDB.AgeRange.age_45_55:
                ltlAgeRange.Text = "45-55";
                break;
            case PIKCV.COM.EnumDB.AgeRange.age_56over:
                ltlAgeRange.Text = "56+";
                break;
            case PIKCV.COM.EnumDB.AgeRange.age_All:
                ltlAgeRange.Text = "Farketmez";
                break;
        }

        DataBindHelper.BindRepeater(ref rptForeignLanguages, objJob.GetJobForeignLanguages(this.JobID, PIKCV.COM.EnumDB.LanguageID.Turkish));
        DataBindHelper.BindRepeater(ref rptComputerKnowledges, objJob.GetJobComputerKnowledge(this.JobID, PIKCV.COM.EnumDB.LanguageID.Turkish));

        if (PIKCV.BUS.JobApplicants.ApplicantCtrl(this.smUserID, this.JobID))
        {
            ImgBtnApply.Visible = false;
            ltlNoButtonMessage.Visible = true;
            ltlNoButtonMessage.Text = PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.ApplicantCtrl);
        }

        if (!this.smIsLogin)
        {
            ImgBtnApply.Visible = false;
            pnlApplicantCtrlLogin.Visible = true;
            //ltlNoButtonMessage.Text = PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.ApplicantCtrLogin);
        }

        if (ImgBtnApply.Visible)
        {
            //if (!this.smIsLogin) { ImgBtnApply.Visible = false; ImgBtnApply.OnClientClick = "alert('Ýlanlara baþvurmak için üye olmanýz gereklidir.'); window.location.href='Pikcv.aspx?Pik=Employee-Membership-UserInfo';window.location.href('" + this.PageReferer + "');"; }
            //else if (!this.smIsCvActive) ImgBtnApply.OnClientClick = "alert('Ýlana baþvurabilmek için özgeçminizin aktif olmasý gerekmektedir'); return false;"; 
            if (this.smMemberType == PIKCV.COM.EnumDB.MemberTypes.Company) ImgBtnApply.Visible = false;
            else if (this.PositonType != this.smEmployeeType) ImgBtnApply.Visible = false;
            else if (!this.smIsCvConfirmed) { ImgBtnApply.Visible = false; ImgBtnApply.OnClientClick = "alert('Üyeliðiniz onay için beklemektedir, onay sonrasýnda ilanlara baþvuru yapabileceksiniz, üyelik onayýnýz e-posta adresinize iletilecektir'); return false;"; }
            else ImgBtnApply.CommandArgument = this.JobID.ToString();
        }

        if (this.smMemberType == PIKCV.COM.EnumDB.MemberTypes.Company) { liSendFriend.Visible = false; }
        else {
            hlSendFriend.NavigateUrl = "javascript:SendFriend(" + ((int)PIKCV.COM.EnumDB.SendFriendType.Job).ToString() + ", " + this.JobID.ToString() + ")";
        }
    }
    
    protected void ImgBtnApply_Click(object sender, ImageClickEventArgs e)
    {
        if ((this.smIsLogin) && (this.smMemberType == PIKCV.COM.EnumDB.MemberTypes.Employee))
        {
            int JobID = int.Parse(ImgBtnApply.CommandArgument);
            if (PIKCV.BUS.JobApplicants.JobToApply(this.smUserID, JobID)) {
                dvScript.InnerHtml = "<script>alert('Bu ilana yapmýþ olduðunuz baþvuru kaydedilmiþtir');window.location.href('" + this.PageReferer + "');</script>";
            }
            else {
                ShowModal.Show(UserControls_Common_uModalPopup.Icons.error, PIKCV.COM.EnumDB.ErrorTypes.Error); 
            }
        }
    }
}