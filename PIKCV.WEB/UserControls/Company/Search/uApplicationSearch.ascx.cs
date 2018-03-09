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

public partial class UserControls_Company_Search_uApplicationSearch : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            FillDetails();
            btn_search.Attributes.Add("onmousedown", "SelectAllListBox('" + lbSelectedCountries.ClientID + "," + lbSelectedCities.ClientID + "," + lbSelectedSectors.ClientID + "," + lbSelectedPositions.ClientID + "," + lbSelectedComputerSkill.ClientID + "," + lbSelectedSectorDesired.ClientID + "," + lbSelectedPositionDesired.ClientID + "," + lbSelectedCountriesDesired.ClientID + "," + lbSelectedCitiesDesired.ClientID + "')");
        }
    }

    private void FillDetails()
    {
        //DataBindHelper.BindRepeater(ref rptAds, PIKCV.BUS.JobApplicants.GetUserJobApplicants(smUserID, this.smLanguageID, smCompanyID.ToString(), "1", ""));
        DataBindHelper.BindRepeater(ref rptAds, PIKCV.BUS.JobApplicants.GetUserJobApplicants(2, this.smLanguageID, smCompanyID.ToString(), "1", ""));


        chkAgeRange.Items[0].Value = ((int)PIKCV.COM.EnumDB.AgeRange.age_All).ToString();
        chkAgeRange.Items[1].Value = ((int)PIKCV.COM.EnumDB.AgeRange.age_18_24).ToString();
        chkAgeRange.Items[2].Value = ((int)PIKCV.COM.EnumDB.AgeRange.age_25_29).ToString();
        chkAgeRange.Items[3].Value = ((int)PIKCV.COM.EnumDB.AgeRange.age_30_34).ToString();
        chkAgeRange.Items[4].Value = ((int)PIKCV.COM.EnumDB.AgeRange.age_35_39).ToString();
        chkAgeRange.Items[5].Value = ((int)PIKCV.COM.EnumDB.AgeRange.age_40_44).ToString();
        chkAgeRange.Items[6].Value = ((int)PIKCV.COM.EnumDB.AgeRange.age_45_55).ToString();
        chkAgeRange.Items[7].Value = ((int)PIKCV.COM.EnumDB.AgeRange.age_56over).ToString();

        chkGenders.Items[0].Value = ((int)PIKCV.COM.EnumDB.SexCode.Female).ToString();
        chkGenders.Items[1].Value = ((int)PIKCV.COM.EnumDB.SexCode.Male).ToString();
        chkGenders.Items[2].Value = ((int)PIKCV.COM.EnumDB.SexCode.Both).ToString();

        chkExperience.Items[0].Value = ((int)PIKCV.COM.EnumDB.Experience.experience_0_1).ToString();
        chkExperience.Items[1].Value = ((int)PIKCV.COM.EnumDB.Experience.experience_2_5).ToString();
        chkExperience.Items[2].Value = ((int)PIKCV.COM.EnumDB.Experience.experience_6_10).ToString();
        chkExperience.Items[3].Value = ((int)PIKCV.COM.EnumDB.Experience.experience_10_over).ToString();

        DataBindHelper.BindListbox(ref lbCountries, this.cmbCountries, "PlaceName", "PlaceID", "");
        DataBindHelper.BindListbox(ref lbCountriesDesired, this.cmbCountries, "PlaceName", "PlaceID", "");
        DataBindHelper.BindListbox(ref lbCities, this.cmbTurkeyCities, "PlaceName", "PlaceID", "");
        DataBindHelper.BindListbox(ref lbCitiesDesired, this.cmbTurkeyCities, "PlaceName", "PlaceID", "");
        DataBindHelper.BindListbox(ref lbPositions, this.cmbPositions, "PositionName", "PositionID", "");
        DataBindHelper.BindListbox(ref lbPositionDesired, this.cmbPositions, "PositionName", "PositionID", "");
        DataBindHelper.BindListbox(ref lbSectors, this.cmbSectors, "SectorName", "SectorID", "");
        DataBindHelper.BindListbox(ref lbSectorDesired, this.cmbSectors, "SectorName", "SectorID", "");
        DataBindHelper.BindListbox(ref lbComputerSkill, this.cmbComputerKnowledgeTypes, "ComputerKnowledgeTypeName", "ComputerKnowledgeTypeID", "");

        DataBindHelper.BindCheckBoxList(ref chkMaritalStatus, this.cmbMaritalStates, "MaritalStatusName", "MaritalStatusID");
        DataBindHelper.BindCheckBoxList(ref chkMilitaryStates, this.cmbMilitaryStates, "MilitaryStatusName", "MilitaryStatusID");
        DataBindHelper.BindCheckBoxList(ref chkLabouringTypes1, this.cmbLabouringTypes, "LabouringTypeName", "LabouringTypeID");
        DataBindHelper.BindCheckBoxList(ref chkLabouringTypes2, this.cmbLabouringTypes, "LabouringTypeName", "LabouringTypeID");
        DataBindHelper.BindCheckBoxList(ref chkEducationLevels, this.cmbEducationLevels, "EducationLevelName", "EducationLevelID");
        DataBindHelper.BindCheckBoxList(ref chkEducationStates1, this.cmbEducationStates, "EducationStatusName", "EducationStatusID");
        DataBindHelper.BindCheckBoxList(ref chkEducationStates2, this.cmbEducationStates, "EducationStatusName", "EducationStatusID");

        DataBindHelper.BindDDL(ref ddlDrvLicense1, this.cmbDriverLicenceTypes, "DriverLicenseTypeName", "DriverLicenseTypeID", "");
        DataBindHelper.BindDDL(ref ddlLanguage1, this.cmbForeignLanguages, "ForeignLanguageName", "ForeignLanguageID", "");
        DataBindHelper.BindDDL(ref ddlLanguage2, this.cmbForeignLanguages, "ForeignLanguageName", "ForeignLanguageID", "");
        DataBindHelper.BindDDL(ref ddlLanguage3, this.cmbForeignLanguages, "ForeignLanguageName", "ForeignLanguageID", "");
        DataBindHelper.BindDDL(ref ddlLanguage11, this.cmbLevels, "LevelName", "LevelID", "");
        DataBindHelper.BindDDL(ref ddlLanguage111, this.cmbLevels, "LevelName", "LevelID", "");
        DataBindHelper.BindDDL(ref ddlLanguage1111, this.cmbLevels, "LevelName", "LevelID", "");
        DataBindHelper.BindDDL(ref ddlLanguage22, this.cmbLevels, "LevelName", "LevelID", "");
        DataBindHelper.BindDDL(ref ddlLanguage222, this.cmbLevels, "LevelName", "LevelID", "");
        DataBindHelper.BindDDL(ref ddlLanguage2222, this.cmbLevels, "LevelName", "LevelID", "");
        DataBindHelper.BindDDL(ref ddlLanguage33, this.cmbLevels, "LevelName", "LevelID", "");
        DataBindHelper.BindDDL(ref ddlLanguage333, this.cmbLevels, "LevelName", "LevelID", "");
        DataBindHelper.BindDDL(ref ddlLanguage3333, this.cmbLevels, "LevelName", "LevelID", "");
        DataBindHelper.BindDDL(ref ddlSchools1, PIKCV.COM.Data.GetSchools(this.cmbSchools, PIKCV.COM.EnumDB.SchoolTypes.HighSchoolTypes), "SchoolName", "SchoolID", "");
        DataBindHelper.BindDDL(ref ddlSchools2, PIKCV.COM.Data.GetSchools(this.cmbSchools, PIKCV.COM.EnumDB.SchoolTypes.UniversityNames), "SchoolName", "SchoolID", "");
        DataBindHelper.BindDDL(ref ddlSchools3, PIKCV.COM.Data.GetSchools(this.cmbSchools, PIKCV.COM.EnumDB.SchoolTypes.DepartmentNames), "SchoolName", "SchoolID", "");

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
    
        // Ýlanlarý Bind Et
        
    }
}
