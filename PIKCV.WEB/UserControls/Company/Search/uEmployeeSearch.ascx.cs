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

public partial class UserControls_Company_Search_uEmployeeSearch : BaseUserControl
{
   
    protected void Page_Load(object sender, EventArgs e)
    {
        this.IsLogin();
        if (!Page.IsPostBack)
        {
            chIsFilterSave.Attributes.Add("onclick", "if(this.checked) { dvFilterSave.style.display='block'; } else { dvFilterSave.style.display='none'; }");

            btn_search.Attributes.Add("onmousedown", "SelectAllListBox('" + lbSelectedCountries.ClientID + "," + lbSelectedCities.ClientID + "," + lbSelectedSectors.ClientID + "," + lbSelectedPositions.ClientID + "," + lbSelectedComputerSkill.ClientID + "," + lbSelectedSectorDesired.ClientID + "," + lbSelectedPositionDesired.ClientID + "," + lbSelectedCountriesDesired.ClientID + "," + lbSelectedCitiesDesired.ClientID + "')");
            FillDetails();
            FillApplicationData();
        }
        #region Tab Select

        try
        {
            if ((CARETTA.COM.Util.IsNumeric(Request.Params["Type"]) || Request.Params["Type"] == null) && (CARETTA.COM.Util.IsNumeric(Request.Params["IsApp"])) || Request.Params["IsApp"] == null)
            {
                DataTable dtSourcePositions = new DataTable();
                // Baþvuru arama
                if (Request.Params["IsApp"] == "1")
                {
                    tab3.Attributes.Add("class", "TabActive");
                    pnl1.Visible = true;
                    if (rdEmployeeTypePikpool.Checked) dtSourcePositions = PIKCV.COM.Data.GetPositions(this.cmbPositions, PIKCV.COM.EnumDB.EmployeeTypes.Pikpool);
                    if (rdEmployeeTypeGoodPik.Checked) dtSourcePositions = PIKCV.COM.Data.GetPositions(this.cmbPositions, PIKCV.COM.EnumDB.EmployeeTypes.Goodpik);
                    if (rdEmployeeTypeAll.Checked) dtSourcePositions = this.cmbPositions;
                }
                else
                {
                    pnl1.Visible = false;
                    if (Request.Params["Type"] == ((int)PIKCV.COM.EnumDB.EmployeeTypes.Goodpik).ToString())
                    {
                        tab1.Attributes.Add("class", "TabActive");
                        dtSourcePositions = PIKCV.COM.Data.GetPositions(this.cmbPositions, PIKCV.COM.EnumDB.EmployeeTypes.Goodpik);
                    }
                    else
                    {
                        tab2.Attributes.Add("class", "TabActive");
                        dtSourcePositions = PIKCV.COM.Data.GetPositions(this.cmbPositions, PIKCV.COM.EnumDB.EmployeeTypes.Pikpool);
                    }
                }
                DataBindHelper.BindListbox(ref lbPositions, dtSourcePositions, "PositionName", "PositionID", "");
                DataBindHelper.BindListbox(ref lbPositionDesired, dtSourcePositions, "PositionName", "PositionID", "");
            }

        }
        catch (Exception)
        {
        }

        #endregion
    }
    private void FillDetails()
    {
       
        #region Details

        // Baþvuru Statüleri
        DataBindHelper.BindCheckBoxList(ref chkEvaluation, PIKCV.BUS.JobApplicants.GetJobApplicationStates(PIKCV.COM.EnumDB.LanguageID.Turkish, false), "JobApplicationStatusName", "JobApplicationStatusID");
        chkEvaluation.Items.Insert(0, new ListItem("Tümü", "0"));

        // Yaþ aralýðý
        chkAgeRange.Items[0].Value = ((int)PIKCV.COM.EnumDB.AgeRange.age_All).ToString();
        chkAgeRange.Items[1].Value = ((int)PIKCV.COM.EnumDB.AgeRange.age_18_24).ToString();
        chkAgeRange.Items[2].Value = ((int)PIKCV.COM.EnumDB.AgeRange.age_25_29).ToString();
        chkAgeRange.Items[3].Value = ((int)PIKCV.COM.EnumDB.AgeRange.age_30_34).ToString();
        chkAgeRange.Items[4].Value = ((int)PIKCV.COM.EnumDB.AgeRange.age_35_39).ToString();
        chkAgeRange.Items[5].Value = ((int)PIKCV.COM.EnumDB.AgeRange.age_40_44).ToString();
        chkAgeRange.Items[6].Value = ((int)PIKCV.COM.EnumDB.AgeRange.age_45_55).ToString();
        chkAgeRange.Items[7].Value = ((int)PIKCV.COM.EnumDB.AgeRange.age_56over).ToString();

        // Cinsiyet
        rblGenders.Items[0].Value = ((int)PIKCV.COM.EnumDB.SexCode.Female).ToString();
        rblGenders.Items[1].Value = ((int)PIKCV.COM.EnumDB.SexCode.Male).ToString();
        rblGenders.Items[2].Value = ((int)PIKCV.COM.EnumDB.SexCode.Both).ToString();

        chkExperience.Items[0].Value = ((int)PIKCV.COM.EnumDB.Experience.experience_0_1).ToString();
        chkExperience.Items[1].Value = ((int)PIKCV.COM.EnumDB.Experience.experience_2_5).ToString();
        chkExperience.Items[2].Value = ((int)PIKCV.COM.EnumDB.Experience.experience_6_10).ToString();
        chkExperience.Items[3].Value = ((int)PIKCV.COM.EnumDB.Experience.experience_10_over).ToString();

        DataBindHelper.BindListbox(ref lbCountries, this.cmbCountries, "PlaceName", "PlaceID", "");
        DataBindHelper.BindListbox(ref lbCountriesDesired, this.cmbCountries, "PlaceName", "PlaceID", "");
        DataBindHelper.BindListbox(ref lbCities, this.cmbTurkeyCities, "PlaceName", "PlaceID", "");
        DataBindHelper.BindListbox(ref lbCitiesDesired, this.cmbTurkeyCities, "PlaceName", "PlaceID", "");
        DataBindHelper.BindListbox(ref lbSectors, this.cmbSectors, "SectorName", "SectorID", "");
        DataBindHelper.BindListbox(ref lbSectorDesired, this.cmbSectors, "SectorName", "SectorID", "");
        DataBindHelper.BindListbox(ref lbComputerSkill, this.cmbComputerKnowledgeTypes, "ComputerKnowledgeTypeName", "ComputerKnowledgeTypeID", "");

        // Eðitim durumu
        DataBindHelper.BindCheckBoxList(ref chkEducationLevels, this.cmbEducationLevels, "EducationLevelName", "EducationLevelID");

        rdlMaritalStatus.Items[0].Value = ((int)PIKCV.COM.EnumDB.MaritalStates.Single).ToString();
        rdlMaritalStatus.Items[1].Value = ((int)PIKCV.COM.EnumDB.MaritalStates.Married).ToString();
        rdlMaritalStatus.Items[2].Value = ((int)PIKCV.COM.EnumDB.MaritalStates.None).ToString();

        DataBindHelper.BindCheckBoxList(ref chkMilitaryStates, this.cmbMilitaryStates, "MilitaryStatusName", "MilitaryStatusID");
        DataBindHelper.BindCheckBoxList(ref chkLabouringTypes1, this.cmbLabouringTypes, "LabouringTypeName", "LabouringTypeID");
        DataBindHelper.BindCheckBoxList(ref chkLabouringTypes2, this.cmbLabouringTypes, "LabouringTypeName", "LabouringTypeID");
        DataBindHelper.BindCheckBoxList(ref chkEducationStates1, this.cmbEducationStates, "EducationStatusName", "EducationStatusID");
        DataBindHelper.BindCheckBoxList(ref chkEducationStates2, this.cmbEducationStates, "EducationStatusName", "EducationStatusID");
                
        DataBindHelper.BindDDL(ref ddlLanguage1, this.cmbForeignLanguages, "ForeignLanguageName", "ForeignLanguageID", "", PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.InitialText), "0");
        DataBindHelper.BindDDL(ref ddlLanguage2, this.cmbForeignLanguages, "ForeignLanguageName", "ForeignLanguageID", "", PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.InitialText), "0");
        DataBindHelper.BindDDL(ref ddlLanguage3, this.cmbForeignLanguages, "ForeignLanguageName", "ForeignLanguageID", "", PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.InitialText), "0");
        DataBindHelper.BindDDL(ref ddlLanguage11, this.cmbLevels, "LevelName", "LevelID", "", PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.InitialText), "0");
        DataBindHelper.BindDDL(ref ddlLanguage111, this.cmbLevels, "LevelName", "LevelID", "", PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.InitialText), "0");
        DataBindHelper.BindDDL(ref ddlLanguage1111, this.cmbLevels, "LevelName", "LevelID", "", PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.InitialText), "0");
        DataBindHelper.BindDDL(ref ddlLanguage22, this.cmbLevels, "LevelName", "LevelID", "", PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.InitialText), "0");
        DataBindHelper.BindDDL(ref ddlLanguage222, this.cmbLevels, "LevelName", "LevelID", "", PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.InitialText), "0");
        DataBindHelper.BindDDL(ref ddlLanguage2222, this.cmbLevels, "LevelName", "LevelID", "", PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.InitialText), "0");
        DataBindHelper.BindDDL(ref ddlLanguage33, this.cmbLevels, "LevelName", "LevelID", "", PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.InitialText), "0");
        DataBindHelper.BindDDL(ref ddlLanguage333, this.cmbLevels, "LevelName", "LevelID", "", PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.InitialText), "0");
        DataBindHelper.BindDDL(ref ddlLanguage3333, this.cmbLevels, "LevelName", "LevelID", "", PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.InitialText), "0");
        DataBindHelper.BindDDL(ref ddlSchools1, PIKCV.COM.Data.GetSchools(this.cmbSchools, PIKCV.COM.EnumDB.SchoolTypes.HighSchoolTypes), "SchoolName", "SchoolID", "",PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.InitialText), "0");
        DataBindHelper.BindDDL(ref ddlSchools2, PIKCV.COM.Data.GetSchools(this.cmbSchools, PIKCV.COM.EnumDB.SchoolTypes.UniversityNames), "SchoolName", "SchoolID", "",PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.InitialText), "0");
        DataBindHelper.BindDDL(ref ddlSchools3, PIKCV.COM.Data.GetSchools(this.cmbSchools, PIKCV.COM.EnumDB.SchoolTypes.DepartmentNames), "SchoolName", "SchoolID", "", PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.InitialText), "0");

        DataBindHelper.BindRadioButtonList(ref rblDrvLicense, this.cmbDriverLicenceTypes, "DriverLicenseTypeName", "DriverLicenseTypeID", "");
        rblDrvLicense.Items.Add(new ListItem("Tümü", ((int)PIKCV.COM.EnumDB.LicenceTypes.All).ToString()));
        rblDrvLicense.SelectedValue = ((int)PIKCV.COM.EnumDB.LicenceTypes.All).ToString();

        DataBindHelper.BindCheckBoxList(ref chDrvLicense, this.cmbDriverLicenceTypes, "DriverLicenseTypeName", "DriverLicenseTypeID");

        add_to_list1.Attributes.Add("onclick", "SwapItem('" + lbCountries.ClientID + "','" + lbSelectedCountries.ClientID + "', ' ')");
        remove_from_list1.Attributes.Add("onclick", "SwapItem('" + lbSelectedCountries.ClientID + "','" + lbCountries.ClientID + "', ' ')");
        add_to_list2.Attributes.Add("onclick", "SwapItem('" + lbCities.ClientID + "','" + lbSelectedCities.ClientID + "', ' ')");
        remove_from_list2.Attributes.Add("onclick", "SwapItem('" + lbSelectedCities.ClientID + "','" + lbCities.ClientID + "', ' ')");
        add_to_list3.Attributes.Add("onclick", "SwapItem('" + lbSectors.ClientID + "','" + lbSelectedSectors.ClientID + "', ' ')");
        remove_from_list3.Attributes.Add("onclick", "SwapItem('" + lbSelectedSectors.ClientID + "','" + lbSectors.ClientID + "', ' ')");
        add_to_list4.Attributes.Add("onclick", "SwapItem('" + lbPositions.ClientID + "','" + lbSelectedPositions.ClientID + "', ' ')");
        remove_from_list4.Attributes.Add("onclick", "SwapItem('" + lbSelectedPositions.ClientID + "','" + lbPositions.ClientID + "', ' ')");
        add_to_list5.Attributes.Add("onclick", "SwapItem('" + lbComputerSkill.ClientID + "','" + lbSelectedComputerSkill.ClientID + "', ' ')");
        remove_from_list5.Attributes.Add("onclick", "SwapItem('" + lbSelectedComputerSkill.ClientID + "','" + lbComputerSkill.ClientID + "', ' ')");
        add_to_list6.Attributes.Add("onclick", "SwapItem('" + lbSectorDesired.ClientID + "','" + lbSelectedSectorDesired.ClientID + "', ' ')");
        remove_from_list6.Attributes.Add("onclick", "SwapItem('" + lbSelectedSectorDesired.ClientID + "','" + lbSectorDesired.ClientID + "', ' ')");
        add_to_list7.Attributes.Add("onclick", "SwapItem('" + lbPositionDesired.ClientID + "','" + lbSelectedPositionDesired.ClientID + "', ' ')");
        remove_from_list7.Attributes.Add("onclick", "SwapItem('" + lbSelectedPositionDesired.ClientID + "','" + lbPositionDesired.ClientID + "', ' ')");
        add_to_list8.Attributes.Add("onclick", "SwapItem('" + lbCountriesDesired.ClientID + "','" + lbSelectedCountriesDesired.ClientID + "', ' ')");
        remove_from_list8.Attributes.Add("onclick", "SwapItem('" + lbSelectedCountriesDesired.ClientID + "','" + lbCountriesDesired.ClientID + "', ' ')");
        add_to_list9.Attributes.Add("onclick", "SwapItem('" + lbCitiesDesired.ClientID + "','" + lbSelectedCitiesDesired.ClientID + "', ' ')");
        remove_from_list9.Attributes.Add("onclick", "SwapItem('" + lbSelectedCitiesDesired.ClientID + "','" + lbCitiesDesired.ClientID + "', ' ')");

        #endregion
    }

    // Baþvuru Arama'da, tepedeki 2 fazlalýktan Repeater'a veri bind eder
    private void FillApplicationData()
    {
        DataTable dtJobs = PIKCV.BUS.Job.GetCompanyAllJobs(this.smCompanyID, PIKCV.COM.EnumDB.JobStatus.Active, this.smLanguageID);
        if (dtJobs.Rows.Count < 1) {
            //this.GoToFeedback(PIKCV.COM.EnumDB.ErrorTypes.NoJobForApplicant);
        }
        //DataBindHelper.BindRepeater(ref rptAds, PIKCV.BUS.Job.GetCompanyAllJobs(this.smCompanyID ,PIKCV.COM.EnumDB.JobStatus.Deleted,this.smLanguageID ));
        DataBindHelper.BindDDL(ref ddlCompanyJobs, dtJobs, "PositionName", "JobID", "0", PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.JobsTitle), "0");
    }

    protected void btn_search_Click(object sender, ImageClickEventArgs e)
    {
        if (chIsFilterSave.Checked && txtFilterName.Text.Length == 0)
        {
            Response.Write("<script>alert('" + PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.EmptyFilterName) + "')</script>");
            return;
        }
        ArrayList arrTemp;
        EmployeeSearchQueries m_SearchQueries = new EmployeeSearchQueries();

        // Cinsiyet
        arrTemp = new ArrayList();
        if (!rblGenders.Items[2].Selected)
        {
            foreach (ListItem li in rblGenders.Items)
            {
                if (li.Selected) arrTemp.Add(li.Value);
            }
        }
        m_SearchQueries.Gender = arrTemp;

        // Yaþ aralýðý
        arrTemp = new ArrayList();
        if (!chkAgeRange.Items[0].Selected)
        {
            foreach (ListItem li in chkAgeRange.Items)
            {
                if (li.Selected) arrTemp.Add(li.Value);
            }
        }
        m_SearchQueries.AgeRange = arrTemp;

        arrTemp = new ArrayList();
        PIKCV.COM.EnumDB.MaritalStates MaritalStatus = (PIKCV.COM.EnumDB.MaritalStates)(int.Parse(rdlMaritalStatus.SelectedValue));
        if (MaritalStatus != PIKCV.COM.EnumDB.MaritalStates.None)
        {
            arrTemp.Add(((int)MaritalStatus).ToString());
        }
        m_SearchQueries.MaritalStates = arrTemp;

        arrTemp = new ArrayList();
        foreach (ListItem li in chkMilitaryStates.Items)
        {
            if (li.Selected) arrTemp.Add(li.Value);
        }
        m_SearchQueries.MilitaryStates = arrTemp;

        if (rblDrvLicense.SelectedValue == ((int)PIKCV.COM.EnumDB.LicenceTypes.All).ToString())
            m_SearchQueries.DriverLicenceTypes = -1;
        else
            m_SearchQueries.DriverLicenceTypes = int.Parse(rblDrvLicense.SelectedValue);

        m_SearchQueries.Handicapped = chkHandicapped.Checked;
        m_SearchQueries.Convicted = chkConvicted.Checked;
        m_SearchQueries.MartyrRelative = chkMartyrRelative.Checked;
        m_SearchQueries.TerrorAggrieved = chkTerrorAggrieved.Checked;

        // Ýletiþim - Ülkeler
        arrTemp = new ArrayList();
        if (Request.Form[lbSelectedCountries.UniqueID] != null)
        {
            arrTemp.AddRange(Request.Form[lbSelectedCountries.UniqueID].Split(','));
        }
        m_SearchQueries.Countries = arrTemp;
        // Ýletiþim - Þehirler
        arrTemp = new ArrayList();
        if (Request.Form[lbSelectedCities.UniqueID] != null)
        {
            arrTemp.AddRange(Request.Form[lbSelectedCities.UniqueID].Split(','));
        }
        m_SearchQueries.TurkeyCities = arrTemp;
        // Eðitim Durumu Baþlangýç -------------------------------------------
        arrTemp = new ArrayList();
        foreach (ListItem li in chkEducationLevels.Items)
        {
            if (li.Selected) arrTemp.Add(li.Value);
        }
        m_SearchQueries.EducationLevels = arrTemp;

        arrTemp = new ArrayList();
        foreach (ListItem li in chkEducationStates1.Items)
        {
            if (li.Selected) arrTemp.Add(li.Value);
        }
        m_SearchQueries.HighSchoolEducationLevels = arrTemp;

        arrTemp = new ArrayList();
        foreach (ListItem li in chkEducationStates2.Items)
        {
            if (li.Selected) arrTemp.Add(li.Value);

        }
        m_SearchQueries.UniversityEducationLevels = arrTemp;

        m_SearchQueries.HighSchoolTypes = int.Parse(ddlSchools1.SelectedValue);
        m_SearchQueries.UniversityNames = int.Parse(ddlSchools2.SelectedValue);
        m_SearchQueries.DepartmentNames = int.Parse(ddlSchools3.SelectedValue);

        arrTemp = new ArrayList();
        m_SearchQueries.EducationStates = arrTemp;
        // Eðitim Durumu Bitiþ -------------------------------------------------

        arrTemp = new ArrayList();
        if (Request.Form[lbSelectedSectors.UniqueID] != null)
        {
            arrTemp.AddRange(Request.Form[lbSelectedSectors.UniqueID].Split(','));
        }
        m_SearchQueries.Sectors = arrTemp;

        arrTemp = new ArrayList();
        if (Request.Form[lbSelectedPositions.UniqueID] != null)
        {
            arrTemp.AddRange(Request.Form[lbSelectedPositions.UniqueID].Split(','));
        }
        m_SearchQueries.Positions = arrTemp;

        arrTemp = new ArrayList();
        foreach (ListItem li in chkExperience.Items)
        {
            if (li.Selected) arrTemp.Add(li.Value);
        }
        m_SearchQueries.Experience = arrTemp;

        arrTemp = new ArrayList();
        foreach (ListItem li in chkLabouringTypes1.Items)
        {
            if (li.Selected) arrTemp.Add(li.Value);
        }
        m_SearchQueries.LabouringTypes = arrTemp;

        // Yabancý Dil Kriterleri - Baþlangýç ---------------------------------------------------
        m_SearchQueries.ForeignLanguages1 = int.Parse(ddlLanguage1.SelectedValue);
        m_SearchQueries.ForeignLanguages1Reading = int.Parse(ddlLanguage11.SelectedValue);
        m_SearchQueries.ForeignLanguages1Writing = int.Parse(ddlLanguage111.SelectedValue);
        m_SearchQueries.ForeignLanguages1Speaking = int.Parse(ddlLanguage1111.SelectedValue);

        m_SearchQueries.ForeignLanguages2 = int.Parse(ddlLanguage2.SelectedValue);
        m_SearchQueries.ForeignLanguages2Reading = int.Parse(ddlLanguage22.SelectedValue);
        m_SearchQueries.ForeignLanguages2Writing = int.Parse(ddlLanguage222.SelectedValue);
        m_SearchQueries.ForeignLanguages2Speaking = int.Parse(ddlLanguage2222.SelectedValue);

        m_SearchQueries.ForeignLanguages3 = int.Parse(ddlLanguage3.SelectedValue);
        m_SearchQueries.ForeignLanguages3Reading = int.Parse(ddlLanguage33.SelectedValue);
        m_SearchQueries.ForeignLanguages3Writing = int.Parse(ddlLanguage333.SelectedValue);
        m_SearchQueries.ForeignLanguages3Speaking = int.Parse(ddlLanguage3333.SelectedValue);

        arrTemp = new ArrayList();
        if (Request.Form[lbComputerSkill.UniqueID] != null)
        {
            arrTemp.AddRange(Request.Form[lbComputerSkill.UniqueID].Split(','));
        }
        m_SearchQueries.ComputerKnowledgeTypes = arrTemp;

        arrTemp = new ArrayList();
        if (Request.Form[lbSelectedSectorDesired.UniqueID] != null)
        {
            arrTemp.AddRange(Request.Form[lbSelectedSectorDesired.UniqueID].Split(','));
        }
        m_SearchQueries.SectorsDesired = arrTemp;

        arrTemp = new ArrayList();
        if (Request.Form[lbSelectedPositionDesired.UniqueID] != null)
        {
            arrTemp.AddRange(Request.Form[lbSelectedPositionDesired.UniqueID].Split(','));
        }
        m_SearchQueries.PositionsDesired = arrTemp;

        arrTemp = new ArrayList();
        if (Request.Form[lbSelectedCountriesDesired.UniqueID] != null)
        {
            arrTemp.AddRange(Request.Form[lbSelectedCountriesDesired.UniqueID].Split(','));
        }
        m_SearchQueries.CountriesDesired = arrTemp;

        arrTemp = new ArrayList();
        if (Request.Form[lbSelectedCitiesDesired.UniqueID] != null)
        {
            arrTemp.AddRange(Request.Form[lbSelectedCitiesDesired.UniqueID].Split(','));
        }
        m_SearchQueries.CitiesDesired = arrTemp;

        arrTemp = new ArrayList();
        foreach (ListItem li in chkLabouringTypes2.Items)
        {
            if (li.Selected) arrTemp.Add(li.Value);
        }

        m_SearchQueries.LabouringTypesDesired = arrTemp;

        if (Request.Params["type"] == ((int)PIKCV.COM.EnumDB.EmployeeTypes.Goodpik).ToString())
        {
            m_SearchQueries.EmployeeSearchType = PIKCV.COM.EnumDB.EmployeeTypes.Goodpik;
        }
        else
        {
            m_SearchQueries.EmployeeSearchType = PIKCV.COM.EnumDB.EmployeeTypes.Pikpool;
        }

        string strRedirect = "Company-Membership-UserInfo&esr=1";
        if (pnl1.Visible)
        {

            m_SearchQueries.JobID = int.Parse(ddlCompanyJobs.SelectedValue);

            //Baþvuru Statüleri
            arrTemp = new ArrayList();
            if (!chkEvaluation.Items[0].Selected)
            {
                foreach (ListItem li in chkEvaluation.Items)
                {
                    if (li.Selected) arrTemp.Add(li.Value);
                }
            }
            m_SearchQueries.ApplicationStatus = arrTemp;
            strRedirect += "&isApp=1";

            if (rdEmployeeTypeAll.Checked) m_SearchQueries.EmployeeSearchType = PIKCV.COM.EnumDB.EmployeeTypes.Both;
            if (rdEmployeeTypeGoodPik.Checked) m_SearchQueries.EmployeeSearchType = PIKCV.COM.EnumDB.EmployeeTypes.Goodpik;
            if (rdEmployeeTypePikpool.Checked) m_SearchQueries.EmployeeSearchType = PIKCV.COM.EnumDB.EmployeeTypes.Pikpool;
        }

        this.smEmployeeSearchQueries = m_SearchQueries;
        if (chIsFilterSave.Checked)
        {
            Serialize objSerialize = new Serialize();
            string FilterValue = objSerialize.SerializeObject(this.smEmployeeSearchQueries);
            PIKCV.BUS.Filters.SaveFilter(PIKCV.COM.EnumDB.FilterTypes.EmployeeSearch, txtFilterName.Text, this.smCompanyID, PIKCV.COM.EnumDB.MemberTypes.Company, FilterValue);
        }

        this.Redirect(strRedirect);
    }

    protected void chkEducationLevels_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (chkEducationLevels.SelectedValue != "")
        {
            if (chkEducationLevels.Items[1].Selected)
            {
                chkEducationStates1.Visible = true;
                ddlSchools1.Visible = true;
            }
            if(chkEducationLevels.Items[2].Selected || chkEducationLevels.Items[3].Selected || chkEducationLevels.Items[4].Selected || chkEducationLevels.Items[5].Selected)
            {
                chkEducationStates2.Visible = true;
                ddlSchools2.Visible = true;
                ddlSchools3.Visible = true;
            }
        }
        if (!chkEducationLevels.Items[1].Selected)
        {
            chkEducationStates1.Visible = false;
            ddlSchools1.Visible = false;
        }
        if (!chkEducationLevels.Items[2].Selected && !chkEducationLevels.Items[3].Selected && !chkEducationLevels.Items[4].Selected && !chkEducationLevels.Items[5].Selected)
        {
            chkEducationStates2.Visible = false;
            ddlSchools2.Visible = false;
            ddlSchools3.Visible = false;
        }
        
    }

    //protected void ddlLanguage1_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    //if (ddlLanguage1.SelectedIndex > 0)
    //    //{
    //    //    ddlLanguage11.Visible = true;
    //    //    ddlLanguage11.SelectedIndex = 0;
    //    //    ddlLanguage111.Visible = true;
    //    //    ddlLanguage111.SelectedIndex = 0;
    //    //    ddlLanguage1111.Visible = true;
    //    //    ddlLanguage1111.SelectedIndex = 0;
    //    //}
    //    //else
    //    //{
    //    //    ddlLanguage11.Visible = false;
    //    //    ddlLanguage111.Visible = false;
    //    //    ddlLanguage1111.Visible = false;
    //    //}
    //}

    //protected void ddlLanguage2_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    //if (ddlLanguage2.SelectedIndex > 0)
    //    //{
    //    //    ddlLanguage22.Visible = true;
    //    //    ddlLanguage22.SelectedIndex = 0;
    //    //    ddlLanguage222.Visible = true;
    //    //    ddlLanguage222.SelectedIndex = 0;
    //    //    ddlLanguage2222.Visible = true;
    //    //    ddlLanguage2222.SelectedIndex = 0;
    //    //}
    //    //else
    //    //{
    //    //    ddlLanguage22.Visible = false;
    //    //    ddlLanguage222.Visible = false;
    //    //    ddlLanguage2222.Visible = false;
    //    //}
    //}

    //protected void ddlLanguage3_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    //if (ddlLanguage3.SelectedIndex > 0)
    //    //{
    //    //    ddlLanguage33.Visible = true;
    //    //    ddlLanguage33.SelectedIndex = 0;
    //    //    ddlLanguage333.Visible = true;
    //    //    ddlLanguage333.SelectedIndex = 0;
    //    //    ddlLanguage3333.Visible = true;
    //    //    ddlLanguage3333.SelectedIndex = 0;
    //    //}
    //    //else
    //    //{
    //    //    ddlLanguage33.Visible = false;
    //    //    ddlLanguage333.Visible = false;
    //    //    ddlLanguage3333.Visible = false;
    //    //}
    //}
    protected void lnkAllpages_Click(object sender, EventArgs e)
    {
        ddlCompanyJobs.Items.Clear();
        ddlCompanyJobs.DataSource = null;
        DataTable dtJobs = PIKCV.BUS.Job.GetCompanyAllJobs(this.smCompanyID, PIKCV.COM.EnumDB.JobStatus.All, this.smLanguageID);
        DataBindHelper.BindDDL(ref ddlCompanyJobs, dtJobs, "PositionName", "JobID", "0", PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.JobsTitle), "0");
        lnkAllpages.Visible = false;
    }
}