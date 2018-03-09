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

public partial class UserControls_Employee_Jobs_uDetailJobSearch : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        liFilters.Visible = (this.smIsLogin);
        trFilter.Visible = (this.smIsLogin);
        if (!IsPostBack)
        {
            FillData();
        }
    }

    private void FillData()
    {
        DataBindHelper.BindListbox(ref lbCountries, this.cmbCountries, "PlaceName", "PlaceID", "");
        DataBindHelper.BindListbox(ref lbCities, this.cmbTurkeyCities, "PlaceName", "PlaceID", "");
        DataBindHelper.BindListbox(ref lbPositions, this.cmbPositions, "PositionName", "PositionID", "");
        DataBindHelper.BindListbox(ref lbSectors, this.cmbSectors, "SectorName", "SectorID", "");
        DataBindHelper.BindCheckBoxList(ref chListLabouringTypes, this.cmbLabouringTypes, "LabouringTypeName", "LabouringTypeID");
        DataBindHelper.BindCheckBoxList(ref chEducationLevels, this.cmbEducationLevels, "EducationLevelName", "EducationLevelID");
        DataBindHelper.BindListbox(ref lbCompanies, this.cmbCompanies, "CompanyName", "CompanyID");

        rdAgeRange.Items[0].Value = ((int)PIKCV.COM.EnumDB.AgeRange.age_18_24).ToString();
        rdAgeRange.Items[1].Value = ((int)PIKCV.COM.EnumDB.AgeRange.age_25_29).ToString();
        rdAgeRange.Items[2].Value = ((int)PIKCV.COM.EnumDB.AgeRange.age_30_34).ToString();
        rdAgeRange.Items[3].Value = ((int)PIKCV.COM.EnumDB.AgeRange.age_35_39).ToString();
        rdAgeRange.Items[4].Value = ((int)PIKCV.COM.EnumDB.AgeRange.age_40_44).ToString();
        rdAgeRange.Items[5].Value = ((int)PIKCV.COM.EnumDB.AgeRange.age_45_55).ToString();
        rdAgeRange.Items[6].Value = ((int)PIKCV.COM.EnumDB.AgeRange.age_56over).ToString();
        rdAgeRange.Items[7].Value = ((int)PIKCV.COM.EnumDB.AgeRange.age_All).ToString();


        imgAddToListCountries.Attributes.Add("onclick", "SwapItem('" + lbCountries.ClientID + "','" + lbSelectedCountries.ClientID + "', ' ', '" + this.Config(PIKCV.COM.EnumUtil.Config.MaxCountry) + "')");
        imgRemoveToListCountries.Attributes.Add("onclick", "SwapItem('" + lbSelectedCountries.ClientID + "','" + lbCountries.ClientID + "', ' ')");

        imgAddToListCities.Attributes.Add("onclick", "SwapItem('" + lbCities.ClientID + "','" + lbSelectedCities.ClientID + "', ' ', '" + this.Config(PIKCV.COM.EnumUtil.Config.MaxCity) + "')");
        imgRemoveToListCities.Attributes.Add("onclick", "SwapItem('" + lbSelectedCities.ClientID + "','" + lbCities.ClientID + "', ' ')");

        imgAddToListPositions.Attributes.Add("onclick", "SwapItem('" + lbPositions.ClientID + "','" + lbSelectedPositions.ClientID + "', ' ', '" + this.Config(PIKCV.COM.EnumUtil.Config.MaxPosition) + "')");
        imgRemoveToListPositions.Attributes.Add("onclick", "SwapItem('" + lbSelectedPositions.ClientID + "','" + lbPositions.ClientID + "', ' ')");

        imgAddToListSector.Attributes.Add("onclick", "SwapItem('" + lbSectors.ClientID + "','" + lbSelectedSectors.ClientID + "', ' ', '" + this.Config(PIKCV.COM.EnumUtil.Config.MaxSector) + "')");
        imgRemoveToListSector.Attributes.Add("onclick", "SwapItem('" + lbSelectedSectors.ClientID + "','" + lbSectors.ClientID + "', ' ')");

        imgAddToListCompanies.Attributes.Add("onclick", "SwapItem('" + lbCompanies.ClientID + "','" + lbSelectedCompanies.ClientID + "', ' ', '" + this.Config(PIKCV.COM.EnumUtil.Config.MaxProhibitedCompanies) + "')");
        imgRemoveToListCompanies.Attributes.Add("onclick", "SwapItem('" + lbSelectedCompanies.ClientID + "','" + lbCompanies.ClientID + "', ' ')");

        BtnSearch.Attributes.Add("onmousedown", "SelectAllListBox('" + lbSelectedCities.ClientID + "," + lbSelectedPositions.ClientID + "," + lbSelectedSectors.ClientID + "," + lbSelectedCompanies.ClientID + "," + lbSelectedCountries.ClientID + "')");

        imgAddToListCountries.Style.Add("cursor", "pointer");
        imgRemoveToListCountries.Style.Add("cursor", "pointer");
        imgAddToListCities.Style.Add("cursor", "pointer");
        imgRemoveToListCities.Style.Add("cursor", "pointer");
        imgAddToListPositions.Style.Add("cursor", "pointer");
        imgRemoveToListPositions.Style.Add("cursor", "pointer");
        imgAddToListSector.Style.Add("cursor", "pointer");
        imgRemoveToListSector.Style.Add("cursor", "pointer");
        imgAddToListCompanies.Style.Add("cursor", "pointer");
        imgRemoveToListCompanies.Style.Add("cursor", "pointer");

        trCustomJobs.Visible = this.smIsLogin;

        chIsFilterSave.Attributes.Add("onclick", "if(this.checked) { dvFilterSave.style.display='block'; } else { dvFilterSave.style.display='none'; }");

    }

    protected void BtnSearch_Click(object sender, ImageClickEventArgs e)
    {
        ArrayList arrTemp;
        JobSearchQuery m_SearchQueries = new JobSearchQuery();
        m_SearchQueries.Keyword = Util.ReplaceStrForDB(txtKeyword.Text);

        arrTemp = new ArrayList();
        if (Request.Form[lbSelectedPositions.UniqueID] != null) {
            arrTemp.AddRange(Request.Form[lbSelectedPositions.UniqueID].Split(','));
        }
        m_SearchQueries.Positions = arrTemp;

        arrTemp = new ArrayList();
        if (Request.Form[lbSelectedSectors.UniqueID] != null) {
            arrTemp.AddRange(Request.Form[lbSelectedSectors.UniqueID].Split(','));
        }
        m_SearchQueries.Sectors = arrTemp;

        arrTemp = new ArrayList();
        if (Request.Form[lbSelectedCities.UniqueID] != null) {
            arrTemp.AddRange(Request.Form[lbSelectedCities.UniqueID].Split(','));
        }
        if (Request.Form[lbSelectedCountries.UniqueID] != null) {
            arrTemp.AddRange(Request.Form[lbSelectedCountries.UniqueID].Split(','));
        }
        m_SearchQueries.Cities = arrTemp;

        arrTemp = new ArrayList();
        if (Request.Form[lbSelectedCompanies.UniqueID] != null) {
            arrTemp.AddRange(Request.Form[lbSelectedCompanies.UniqueID].Split(','));
        }
        m_SearchQueries.Companies = arrTemp;

        arrTemp = new ArrayList();
        foreach (ListItem li in chEducationLevels.Items) {
            if (li.Selected) { arrTemp.Add(li.Value); }
        }
        m_SearchQueries.EducationLevels = arrTemp;

        m_SearchQueries.AgeRange = (PIKCV.COM.EnumDB.AgeRange)(int.Parse(rdAgeRange.SelectedValue));

        arrTemp = new ArrayList();
        foreach (ListItem li in chListLabouringTypes.Items) {
            if (li.Selected) { arrTemp.Add(li.Value); }
        }
        m_SearchQueries.LabouringTypes = arrTemp;

        m_SearchQueries.JobDate = int.Parse(rdJobDate.SelectedValue);

        m_SearchQueries.CustomJobs = (rdCustomJobs.Checked);

        this.smJobSearchQueries = m_SearchQueries;

        

        if (chIsFilterSave.Checked)
        {
            Serialize objSerialize = new Serialize();
            string FilterValue = objSerialize.SerializeObject(this.smJobSearchQueries);
            if (PIKCV.BUS.Filters.CheckFilterExistance(this.smUserID, txtFilterName.Text, PIKCV.COM.EnumDB.MemberTypes.Employee, PIKCV.COM.EnumDB.FilterTypes.JobSearch) == 0)
            {
                PIKCV.BUS.Filters.SaveFilter(PIKCV.COM.EnumDB.FilterTypes.JobSearch, txtFilterName.Text, this.smUserID, PIKCV.COM.EnumDB.MemberTypes.Employee, FilterValue);
                this.smListFilterTypes = new ArrayList();
                //Response.Write("<script>alert('Filtreniz kaydedilmiþtir, filtre bilgilerinize kayýtlý filtreleriniz bölümünden ulaþabilirsiniz');window.location.href('pikcv.aspx?Pik=Employee-Jobs-Jobs');</script>");
                this.Redirect("Employee-Jobs-Jobs&PopupID=" + ((int)PIKCV.COM.EnumDB.ErrorTypes.FilterSaveSuccess).ToString());
            }
            else
            { 
                //TODO: seçtiði herþey gidiyor
                ShowModal.Show(UserControls_Common_uModalPopup.Icons.alert, PIKCV.COM.Data.GetErrorMessageTitleCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.FilterAlreadyExist), PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.FilterAlreadyExist), false);
            }
        }
        else
        {
            this.smListFilterTypes = new ArrayList();
            this.Redirect("Employee-Jobs-Jobs");
        }
    }

}