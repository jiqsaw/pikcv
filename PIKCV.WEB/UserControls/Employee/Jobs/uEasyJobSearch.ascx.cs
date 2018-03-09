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
public partial class UserControls_Employee_Jobs_uEasyJobSearch : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        liFilters.Visible = (this.smIsLogin);
        if (!IsPostBack)
        {
            FillData();
        }
    }

    private void FillData() {
        DataBindHelper.BindListbox(ref lbCountries, this.cmbCountries, "PlaceName", "PlaceID", "");
        DataBindHelper.BindListbox(ref lbCities, this.cmbTurkeyCities, "PlaceName", "PlaceID", "");
        DataBindHelper.BindListbox(ref lbPositions, this.cmbPositions, "PositionName", "PositionID", "");
        DataBindHelper.BindListbox(ref lbSectors, this.cmbSectors, "SectorName", "SectorID", "");

        imgAddToListCountries.Attributes.Add("onclick", "SwapItem('" + lbCountries.ClientID + "','" + lbSelectedCountries.ClientID + "', ' ', '" + this.Config(PIKCV.COM.EnumUtil.Config.MaxCountry) + "')");
        imgRemoveToListCountries.Attributes.Add("onclick", "SwapItem('" + lbSelectedCountries.ClientID + "','" + lbCountries.ClientID + "', ' ')");
        
        imgAddToListCities.Attributes.Add("onclick", "SwapItem('" + lbCities.ClientID + "','" + lbSelectedCities.ClientID + "', ' ', '" + this.Config(PIKCV.COM.EnumUtil.Config.MaxCity) + "')");
        imgRemoveToListCities.Attributes.Add("onclick", "SwapItem('" + lbSelectedCities.ClientID + "','" + lbCities.ClientID + "', ' ')");

        imgAddToListPositions.Attributes.Add("onclick", "SwapItem('" + lbPositions.ClientID + "','" + lbSelectedPositions.ClientID + "', ' ', '" + this.Config(PIKCV.COM.EnumUtil.Config.MaxPosition) + "')");
        imgRemoveToListPositions.Attributes.Add("onclick", "SwapItem('" + lbSelectedPositions.ClientID + "','" + lbPositions.ClientID + "', ' ')");

        imgAddToListSector.Attributes.Add("onclick", "SwapItem('" + lbSectors.ClientID + "','" + lbSelectedSectors.ClientID + "', ' ', '" + this.Config(PIKCV.COM.EnumUtil.Config.MaxSector) + "')");
        imgRemoveToListSector.Attributes.Add("onclick", "SwapItem('" + lbSelectedSectors.ClientID + "','" + lbSectors.ClientID + "', ' ')");

        BtnSearch.Attributes.Add("onmousedown", "SelectAllListBox('" + lbSelectedCities.ClientID + "," + lbSelectedPositions.ClientID + "," + lbSelectedSectors.ClientID + "," + lbSelectedCountries.ClientID + "')");

        imgAddToListCountries.Style.Add("cursor", "pointer");
        imgRemoveToListCountries.Style.Add("cursor", "pointer");
        imgAddToListCities.Style.Add("cursor", "pointer");
        imgRemoveToListCities.Style.Add("cursor", "pointer");
        imgAddToListPositions.Style.Add("cursor", "pointer");
        imgRemoveToListPositions.Style.Add("cursor", "pointer");
        imgAddToListSector.Style.Add("cursor", "pointer");
        imgRemoveToListSector.Style.Add("cursor", "pointer");

        trCustomJobs.Visible = this.smIsLogin;
    }
    protected void BtnSearch_Click(object sender, ImageClickEventArgs e)
    {
        ArrayList arrTemp;
        JobSearchQuery m_SearchQueries = new JobSearchQuery();
        m_SearchQueries.Keyword = Util.ReplaceStrForDB(txtKeyword.Text);

        arrTemp = new ArrayList();
        if (Request.Form[lbSelectedPositions.UniqueID] != null)
        {
            arrTemp.AddRange(Request.Form[lbSelectedPositions.UniqueID].Split(','));
        }
        m_SearchQueries.Positions = arrTemp;

        arrTemp = new ArrayList();
        if (Request.Form[lbSelectedSectors.UniqueID] != null)
        {
            arrTemp.AddRange(Request.Form[lbSelectedSectors.UniqueID].Split(','));
        }
        m_SearchQueries.Sectors = arrTemp;

        arrTemp = new ArrayList();
        if (Request.Form[lbSelectedCities.UniqueID] != null)
        {
            arrTemp.AddRange(Request.Form[lbSelectedCities.UniqueID].Split(','));
        }
        if (Request.Form[lbSelectedCountries.UniqueID] != null)
        {
            arrTemp.AddRange(Request.Form[lbSelectedCountries.UniqueID].Split(','));
        }
        m_SearchQueries.Cities = arrTemp;

        arrTemp = new ArrayList();
        m_SearchQueries.Companies = arrTemp;
        m_SearchQueries.EducationLevels = arrTemp;
        m_SearchQueries.AgeRange = PIKCV.COM.EnumDB.AgeRange.age_All;
        m_SearchQueries.LabouringTypes = arrTemp;
        m_SearchQueries.JobDate = -1;
        m_SearchQueries.CustomJobs = (rdCustomJobs.Checked);

        this.smJobSearchQueries = m_SearchQueries;

        this.smListFilterTypes = new ArrayList();
        this.Redirect("Employee-Jobs-Jobs");
    }
}