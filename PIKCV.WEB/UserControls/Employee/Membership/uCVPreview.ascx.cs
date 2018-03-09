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

public partial class UserControls_Employee_Membership_uCVPreview : BaseUserControl
{
    private DataTable dtUser;
    private DataTable dtUserCV;
    private DataTable dtUserComputerKnowledge;
    private DataTable dtUserEducationUniversity0;
    private DataTable dtUserEducationUniversity1;
    private DataTable dtUserEducationUniversity2;
    private DataTable dtUserEducationDoktorate;
    private DataTable dtUserEmployment;
    private DataTable dtUserLabouringTypes;
    private DataTable dtUserLanguages;
    private DataTable dtUserPlacementPreferences;
    private DataTable dtUserPositions;
    private DataTable dtUserReferences;
    private DataTable dtUserSectors;
    private bool IsOwned;

    protected void Page_PreRender(object sender, EventArgs e)
    {
        if (!this.smIsLogin) { this.Redirect("Employee-Membership-CV"); }
        else
        {
            //imgUserPhoto.Attributes.Add("onerror", "this.src='Images/UserImages/Small/0.png';");
            UCVTabs1.TabActive(PIKCV.COM.Enumerations.CVTabs.CVOutput);

            PIKCV.BUS.Company obJComp = new PIKCV.BUS.Company();
            this.IsOwned = ((this.smMemberType == PIKCV.COM.EnumDB.MemberTypes.Company) && (obJComp.CheckBuyContactInfo(this.smCompanyID, this.smUserID)));
            if (IsOwned)
            {
                tContact.Visible = true;
                trReferences.Visible = true;
                trMail.Visible = true;
            }
            else
            {
                tContact.Visible = (this.smMemberType == PIKCV.COM.EnumDB.MemberTypes.Employee);
                trReferences.Visible = (this.smMemberType == PIKCV.COM.EnumDB.MemberTypes.Employee);
                trMail.Visible = (this.smMemberType == PIKCV.COM.EnumDB.MemberTypes.Employee);
            }

            GetData();
            FillData();

            if (this.smIsLogin == true)
            {
                ltlEditUser.Visible = true;
                ltlNewUser.Visible = false;
            }
            else
            {
                ltlEditUser.Visible = false;
                ltlNewUser.Visible = true;
            }
        }
    }

    private void GetData()
    {
        PIKCV.BUS.User objUser = new PIKCV.BUS.User();
        PIKCV.BUS.UserCVs objUserCV = new PIKCV.BUS.UserCVs();

        this.dtUser = objUser.GetUserDetail(this.smUserID);
        this.dtUserCV = objUserCV.GetUserCV(this.smUserID);
        this.dtUserComputerKnowledge = objUserCV.GetUserComputerKnowledges(this.smUserID, (int)this.smLanguageID);

        this.dtUserEducationUniversity0 = objUserCV.GetUserEducations(this.smUserID, PIKCV.COM.EnumDB.EducationTypes.University0, PIKCV.COM.EnumDB.LanguageID.Turkish, false);
        this.dtUserEducationUniversity1 = objUserCV.GetUserEducations(this.smUserID, PIKCV.COM.EnumDB.EducationTypes.University1, PIKCV.COM.EnumDB.LanguageID.Turkish, false);
        this.dtUserEducationUniversity2 = objUserCV.GetUserEducations(this.smUserID, PIKCV.COM.EnumDB.EducationTypes.University2, PIKCV.COM.EnumDB.LanguageID.Turkish, false);
        this.dtUserEducationDoktorate = objUserCV.GetUserEducations(this.smUserID, PIKCV.COM.EnumDB.EducationTypes.Doktorate, PIKCV.COM.EnumDB.LanguageID.Turkish, false);

        this.dtUserEmployment = objUserCV.GetUserEmployment(this.smUserID, (int)this.smLanguageID);
        this.dtUserLabouringTypes = objUserCV.GetUserLabouringTypes(this.smUserID, (int)this.smLanguageID);
        this.dtUserLanguages = objUserCV.GetUserLanguages(this.smUserID, (int)this.smLanguageID);
        this.dtUserPlacementPreferences = objUserCV.GetUserPlaces(this.smUserID, (int)this.smLanguageID);
        this.dtUserPositions = objUserCV.GetUserPositions(this.smUserID, (int)this.smLanguageID);
        this.dtUserReferences = objUserCV.GetUserReferences(this.smUserID);
        this.dtUserSectors = objUserCV.GetUserSectors(this.smUserID, (int)this.smLanguageID);
    }

    private void FillData()
    {
        this.smPhotoFileName = dtUserCV.Rows[0]["PhotoFileName"].ToString();
        
        if (this.smPhotoFileName != String.Empty)
        {
            imgUserPhoto.Visible = true;
            imgUserPhoto.ImageUrl += this.smPhotoFileName;
            if (!(System.IO.File.Exists(Request.MapPath(imgUserPhoto.ImageUrl))))
            {
                imgUserPhoto.ImageUrl = "~/Images/UserImages/Small/0.png";
            }
        }
        string FirstName = this.dtUser.Rows[0]["FirstName"].ToString();
        string LastName = this.dtUser.Rows[0]["LastName"].ToString();
        ltlFirstName.Text = Util.SpecialName(FirstName);
        ltlLastName.Text = Util.SpecialName(LastName);
        ltlEditUser.Text = ltlFirstName.Text + " " + ltlLastName.Text;
        ltlEmail.Text = this.dtUser.Rows[0]["Email"].ToString();

        //KÝÞÝSEL BÝLGÝLER
        ltlModifyDate.Text = Convert.ToDateTime(this.dtUser.Rows[0]["ModifyDate"]).ToShortDateString();
        ltlNation.Text = PIKCV.COM.Data.GetPlace(this.cmbCountries, Convert.ToInt32(this.dtUserCV.Rows[0]["NationID"]))["PlaceName"].ToString();
        ltlBirthDate.Text = Convert.ToDateTime(this.dtUserCV.Rows[0]["BirthDate"]).ToShortDateString();
        ltlBirthPlace.Text = PIKCV.COM.Data.GetPlace(this.cmbTurkeyCities, Convert.ToInt32(this.dtUserCV.Rows[0]["BirthPlaceID"]))["PlaceName"].ToString();
        if ((PIKCV.COM.EnumDB.SexCode)(Convert.ToInt32(this.dtUserCV.Rows[0]["SexCode"])) == PIKCV.COM.EnumDB.SexCode.Male)
        {
            ltlSex.Text = "Erkek";
            trMilitary.Visible = true;
            ltlMilitary.Text = DataTableHelper.Filter(this.cmbMilitaryStates, "MilitaryStatusID", this.dtUserCV.Rows[0]["MilitaryStatusID"].ToString()).Rows[0]["MilitaryStatusName"].ToString();
            if ((PIKCV.COM.EnumDB.MilitaryStates)Convert.ToInt32(this.dtUserCV.Rows[0]["MilitaryStatusID"]) == PIKCV.COM.EnumDB.MilitaryStates.Postponement)
            {
                ltlMilitaryYear.Text = this.dtUserCV.Rows[0]["MilitaryYear"].ToString();
            }
        }
        else { ltlSex.Text = "Kadýn"; }
        ltlMarital.Text = DataTableHelper.Filter(this.cmbMaritalStates, "MaritalStatusID", this.dtUserCV.Rows[0]["MaritalStatusID"].ToString()).Rows[0]["MaritalStatusName"].ToString();
        ltlDisabled.Visible = Convert.ToBoolean(this.dtUserCV.Rows[0]["IsDisabled"]);
        ltlOldConvicted.Visible = Convert.ToBoolean(this.dtUserCV.Rows[0]["IsOldConvicted"]);
        ltlMartyrRelative.Visible = Convert.ToBoolean(this.dtUserCV.Rows[0]["IsMartyrRelative"]);
        ltlTerrorWronged.Visible = Convert.ToBoolean(this.dtUserCV.Rows[0]["IsTerrorWronged"]);
        ltlChronicIllness.Text = this.dtUserCV.Rows[0]["ChronicIllness"].ToString();
        if (ltlChronicIllness.Text.Trim() == String.Empty) { ltlChronicIllness.Text = "-"; }

        //ÝLETÝÞÝM BÝLGÝLERÝ
        ltlHomeCountry.Text = PIKCV.COM.Data.GetPlace(this.cmbCountries, Convert.ToInt32(this.dtUserCV.Rows[0]["HomeCountryID"]))["PlaceName"].ToString();
        ltlHomeCity.Text = PIKCV.COM.Data.GetPlace(this.cmbTurkeyCities, Convert.ToInt32(this.dtUserCV.Rows[0]["HomeCityID"]))["PlaceName"].ToString();
        ltlAddress.Text = this.dtUserCV.Rows[0]["HomeAddress"].ToString();
        ltlHomePhone.Text = Util.FormatPhone(this.dtUserCV.Rows[0]["HomePhone"].ToString().Trim());
        ltlBusinessPhone.Text = Util.FormatPhone(this.dtUserCV.Rows[0]["BusinessPhone"].ToString().Trim());
        ltlGSM.Text = Util.FormatPhone(this.dtUserCV.Rows[0]["GSM"].ToString().Trim());
        ltlGSM2.Text = Util.FormatPhone(this.dtUserCV.Rows[0]["GSM2"].ToString().Trim());
        ltlAlternateEmail.Text = this.dtUserCV.Rows[0]["ContactEmail"].ToString();
        ltlAlternateContactName.Text = this.dtUserCV.Rows[0]["AlternateContactName"].ToString();
        ltlAlternateContactPhone.Text = Util.FormatPhone(this.dtUserCV.Rows[0]["AlternateContactPhone"].ToString().Trim());

        //EÐÝTÝM
        PIKCV.COM.EnumDB.EducationTypes UserEducationType = (PIKCV.COM.EnumDB.EducationTypes)(Convert.ToInt32(this.dtUserCV.Rows[0]["EducationTypeCode"]));
        if ((int)UserEducationType < (int)PIKCV.COM.EnumDB.EducationTypes.University0)
        {
            ltlMiddleSchoolName.Text = this.dtUserCV.Rows[0]["MiddleSchoolName"].ToString();
            ltlMiddleSchoolStatus.Text = DataTableHelper.Filter(this.cmbEducationStates, "EducationStatusID", this.dtUserCV.Rows[0]["MiddleSchoolStatusID"].ToString()).Rows[0]["EducationStatusName"].ToString();
            if ((PIKCV.COM.EnumDB.EducationStates)(Convert.ToInt32(this.dtUserCV.Rows[0]["MiddleSchoolStatusID"])) == PIKCV.COM.EnumDB.EducationStates.Graduate)
            {
                ltlMiddleSchoolEndDate.Text = this.dtUserCV.Rows[0]["MiddleSchoolEndDate"].ToString();
            }
        }
        else
        {
            trMiddleSchool.Visible = false;
        }
        ltlHighSchoolName.Text = this.dtUserCV.Rows[0]["HighSchoolName"].ToString();
        ltlHighSchoolStatus.Text = DataTableHelper.Filter(this.cmbEducationStates, "EducationStatusID", this.dtUserCV.Rows[0]["HighSchoolStatusID"].ToString()).Rows[0]["EducationStatusName"].ToString();
        if ((PIKCV.COM.EnumDB.EducationStates)(Convert.ToInt32(this.dtUserCV.Rows[0]["HighSchoolStatusID"])) == PIKCV.COM.EnumDB.EducationStates.Graduate)
        {
            ltlHighSchoolEndDate.Text = this.dtUserCV.Rows[0]["HighSchoolEndDate"].ToString();
        }
        if ((int)UserEducationType >= (int)PIKCV.COM.EnumDB.EducationTypes.University0)
        {
            DataBindHelper.BindRepeater(ref rptUniversity0, this.dtUserEducationUniversity0);
        }
        if ((int)UserEducationType >= (int)PIKCV.COM.EnumDB.EducationTypes.University1)
        {
            DataBindHelper.BindRepeater(ref rptUniversity1, this.dtUserEducationUniversity1);
        }
        if ((int)UserEducationType >= (int)PIKCV.COM.EnumDB.EducationTypes.University2)
        {
            DataBindHelper.BindRepeater(ref rptUniversity2, this.dtUserEducationUniversity2);
        }
        if ((int)UserEducationType >= (int)PIKCV.COM.EnumDB.EducationTypes.Doktorate)
        {
            DataBindHelper.BindRepeater(ref rptDoktorate, this.dtUserEducationDoktorate);
        }

        //ÝÞ DENEYÝMÝ
        ltlTotalWorkExperience.Text = this.dtUserCV.Rows[0]["TotalWorkExperience"].ToString();
        DataBindHelper.BindRepeater(ref rptUserEmployment, this.dtUserEmployment);

        //NÝTELÝKLER / ÝLGÝ ALANLARI
        ltlDriverLicence.Text = DataTableHelper.Filter(this.cmbDriverLicenceTypes, "DriverLicenseTypeID", this.dtUserCV.Rows[0]["DriverLicenseTypeID"].ToString()).Rows[0]["DriverLicenseTypeName"].ToString();
        if (Convert.ToInt32(this.dtUserCV.Rows[0]["DriverLicenseTypeID"]) != (int)(PIKCV.COM.EnumDB.LicenceTypes.NoneID))
        {
            ltlDriverLicenceYear.Text = this.dtUserCV.Rows[0]["DriverLicenseYear"].ToString();
        }
        DataBindHelper.BindRepeater(ref rptUserLanguages, this.dtUserLanguages);
        DataBindHelper.BindRepeater(ref rptUserComputerKnowledge, this.dtUserComputerKnowledge);
        ltlCourseAndCertificates.Text = this.dtUserCV.Rows[0]["CourseAndCertificates"].ToString();
        ltlInterests.Text = this.dtUserCV.Rows[0]["Interests"].ToString();
        ltlClubs.Text = this.dtUserCV.Rows[0]["Clubs"].ToString();

        //TERCÝHLER
        DataBindHelper.BindRepeater(ref rptUserSectors, this.dtUserSectors);
        DataBindHelper.BindRepeater(ref rptUserPositions, this.dtUserPositions);
        DataBindHelper.BindRepeater(ref rptUserCountries, DataTableHelper.Filter(this.dtUserPlacementPreferences, "PlaceTypeCode", ((int)PIKCV.COM.EnumDB.PlaceTypes.Country).ToString()));
        DataBindHelper.BindRepeater(ref rptUserCities, DataTableHelper.Filter(this.dtUserPlacementPreferences, "PlaceTypeCode", ((int)PIKCV.COM.EnumDB.PlaceTypes.TurkeyCity).ToString()));
        DataBindHelper.BindRepeater(ref rptUserLabouringTypes, this.dtUserLabouringTypes);
        if (Convert.ToBoolean(this.dtUserCV.Rows[0]["HasTravelDifficulty"]))
        {
            ltlHasTravelDifficulty.Text = "Var";
        }
        else { ltlHasTravelDifficulty.Text = "Yok"; }

        if (Convert.ToBoolean(this.dtUserCV.Rows[0]["IsSmoking"]))
        {
            ltlSmoking.Text = "Evet";
        }
        else { ltlSmoking.Text = "Hayýr"; }

        DataBindHelper.BindRepeater(ref rptUserUserReferences, this.dtUserReferences);
    }

    protected void rptUserLanguages_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if ((e.Item.ItemType == ListItemType.Item) || (e.Item.ItemType == ListItemType.AlternatingItem))
        {
            if (((Literal)e.Item.FindControl("ltlExamID")).Text == "0")
            {
                e.Item.FindControl("ltlExamTitle").Visible = false;
                e.Item.FindControl("ltlExamName").Visible = false;
                e.Item.FindControl("ltlExamDegreeTitle").Visible = false;
                e.Item.FindControl("ltlExamDegree").Visible = false;
            }
        }
    }
    protected void rptUserEmployment_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if ((e.Item.ItemType == ListItemType.Item) || (e.Item.ItemType == ListItemType.AlternatingItem))
        {
            if (IsOwned) { ((Panel)e.Item.FindControl("pnlPhone")).Visible = true; }
            else { ((Panel)e.Item.FindControl("pnlPhone")).Visible = (this.smMemberType == PIKCV.COM.EnumDB.MemberTypes.Employee); }

            if (((Literal)e.Item.FindControl("ltlEndDate")).Text == String.Empty)
            {
                ((Literal)e.Item.FindControl("ltlEndDate")).Text = "...";
            }
            else
            {
                ((Literal)e.Item.FindControl("ltlEndDate")).Text = Convert.ToDateTime(((Literal)e.Item.FindControl("ltlEndDate")).Text).ToShortDateString();
            }
            ((Panel)e.Item.FindControl("pnlReason")).Visible = (((Literal)e.Item.FindControl("ltlReasonOfResignation")).Text.Trim() != "-");
        }
    }
}