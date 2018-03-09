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

public partial class UserControls_Employee_Membership_CV_uPlacementPreferences : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataBindHelper.BindCheckBoxList(ref chLabouringTypes, this.cmbLabouringTypes, "LabouringTypeName", "LabouringTypeID");

            ReplaceNavigateURL(ref hlEmploymentChooices, PIKCV.COM.EnumDB.CVFocusCode.EmploymentChooices);
            ReplaceNavigateURL(ref hlReferences, PIKCV.COM.EnumDB.CVFocusCode.References);
            ReplaceNavigateURL(ref hlProhibitedCompanies, PIKCV.COM.EnumDB.CVFocusCode.ProhibitedCompanies);

            imgAddToListCities.Style.Add("cursor", "pointer");
            imgAddToListCountries.Style.Add("cursor", "pointer");
            imgRemoveToListCities.Style.Add("cursor", "pointer");
            imgRemoveToListCountries.Style.Add("cursor", "pointer");

            imgAddToListCities.Attributes.Add("onclick", "SwapItem('" + lbCities.ClientID + "','" + lbSelectedCities.ClientID + "', '" + txtOtherPlace.ClientID + "', '" + this.Config(PIKCV.COM.EnumUtil.Config.MaxCity) + "')");
            imgRemoveToListCities.Attributes.Add("onclick", "SwapItem('" + lbSelectedCities.ClientID + "','" + lbCities.ClientID + "', '" + txtOtherPlace.ClientID + "')");

            imgAddToListCountries.Attributes.Add("onclick", "SwapItem('" + lbCountries.ClientID + "','" + lbSelectedCountries.ClientID + "', ' ', '" + this.Config(PIKCV.COM.EnumUtil.Config.MaxCountry) + "')");
            imgRemoveToListCountries.Attributes.Add("onclick", "SwapItem('" + lbSelectedCountries.ClientID + "','" + lbCountries.ClientID + "', ' ')");

            ImgBtnContinue.Attributes.Add("onmousedown", PIKCV.COM.Util.SelectAllListboxScript(lbSelectedCountries.ClientID, lbSelectedCities.ClientID));
            ImgBtnSave.Attributes.Add("onmousedown", PIKCV.COM.Util.SelectAllListboxScript(lbSelectedCountries.ClientID, lbSelectedCities.ClientID));

            lbCities.Attributes.Add("onchange", "OpenCloseOther(" + ((int)PIKCV.COM.EnumDB.Places.OtherPlaceID).ToString() + ")");
        }
    }

    protected void Page_PreRender(object sender, EventArgs e) {

        PIKCV.BUS.UserCVs objUserPlaces = new PIKCV.BUS.UserCVs();
        DataTable dtUserPlacesAll = objUserPlaces.GetUserPlaces(this.smUserID, (int)this.smLanguageID);

        PIKCV.BUS.UserCVs objUserLabouringTypes = new PIKCV.BUS.UserCVs();
        DataTable dtUserLabouringTypes = objUserLabouringTypes.GetUserLabouringTypes(this.smUserID, (int)this.smLanguageID);

        
        foreach (DataRow dr in dtUserLabouringTypes.Rows) {
            foreach (ListItem li in chLabouringTypes.Items) {
                if (li.Value == dr["LabouringTypeID"].ToString()) {
                    li.Selected = true;
                    break;
                }
            }
        }

        DataTable dtUserPlaceCountries = new DataTable();
        dtUserPlaceCountries.Columns.Add("PlaceID");
        dtUserPlaceCountries.Columns.Add("PlaceName");

        DataTable dtUserPlaceCities = dtUserPlaceCountries.Clone();

        foreach (DataRow dr in dtUserPlacesAll.Rows)
        {
            if (dr["PlaceTypeCode"].ToString() == ((int)PIKCV.COM.EnumDB.PlaceTypes.Country).ToString())
            {
                DataRow drNew = dtUserPlaceCountries.NewRow();
                drNew["PlaceID"] = dr["PlaceID"].ToString();
                drNew["PlaceName"] = dr["PlaceName"].ToString();
                dtUserPlaceCountries.Rows.Add(drNew);
            }
            else {
                DataRow drNew = dtUserPlaceCities.NewRow();
                drNew["PlaceID"] = dr["PlaceID"].ToString();
                drNew["PlaceName"] = dr["PlaceName"].ToString();
                dtUserPlaceCities.Rows.Add(drNew);
            }
        }

        DataBindHelper.BindListbox(ref lbSelectedCountries, dtUserPlaceCountries, "PlaceName", "PlaceID", "");
        DataBindHelper.BindListbox(ref lbSelectedCities, dtUserPlaceCities, "PlaceName", "PlaceID", "");


        DataTable dtCountries = this.cmbCountries;
        DataTable dtCountriesNew = new DataTable();

        if (dtUserPlaceCountries.Rows.Count > 0)
        {
            dtCountriesNew.Columns.Add("PlaceID");
            dtCountriesNew.Columns.Add("PlaceName");

            bool add = true;
            foreach (DataRow drCache in dtCountries.Rows)
            {
                add = true;
                foreach (DataRow dr in dtUserPlaceCountries.Rows)
                {
                    if (dr["PlaceID"].ToString() == drCache["PlaceID"].ToString())
                    {
                        add = false;
                        break;
                    }
                }
                if (add)
                {
                    DataRow drNew = dtCountriesNew.NewRow();
                    drNew["PlaceID"] = drCache["PlaceID"].ToString();
                    drNew["PlaceName"] = drCache["PlaceName"].ToString();
                    dtCountriesNew.Rows.Add(drNew);
                }
            }
        }
        else { dtCountriesNew = dtCountries.Copy(); }

        DataTable dtTurkeyCities = this.cmbTurkeyCities;
        DataTable dtCitiesNew = new DataTable();

        if (dtUserPlaceCities.Rows.Count > 0)
        {
            dtCitiesNew.Columns.Add("PlaceID");
            dtCitiesNew.Columns.Add("PlaceName");

            bool add = true;
            foreach (DataRow drCache in dtTurkeyCities.Rows)
            {
                add = true;
                foreach (DataRow dr in dtUserPlaceCities.Rows)
                {
                    if (dr["PlaceID"].ToString() == drCache["PlaceID"].ToString())
                    {
                        add = false;
                        break;
                    }
                }
                if (add) {
                    DataRow drNew = dtCitiesNew.NewRow();
                    drNew["PlaceID"] = drCache["PlaceID"].ToString();
                    drNew["PlaceName"] = drCache["PlaceName"].ToString();
                    dtCitiesNew.Rows.Add(drNew);
                }
            }
        }
        else { dtCitiesNew = dtTurkeyCities.Copy(); }
         
        DataBindHelper.BindListbox(ref lbCountries, dtCountriesNew, "PlaceName", "PlaceID", "");
        DataBindHelper.BindListbox(ref lbCities, dtCitiesNew, "PlaceName", "PlaceID", "");

        PIKCV.BUS.UserCVs objUserCV = new PIKCV.BUS.UserCVs();

        DataTable dtUserCV = objUserCV.GetUserCV(this.smUserID);
        
        bool HasTravelDifficulty = Convert.ToBoolean(dtUserCV.Rows[0]["HasTravelDifficulty"]);
        rdHasTravelDifficultyYes.Checked = HasTravelDifficulty;
        rdHasTravelDifficultyNo.Checked = !HasTravelDifficulty;
        
        bool IsSmoking = Convert.ToBoolean(dtUserCV.Rows[0]["IsSmoking"]);
        rdIsSmokingYes.Checked = IsSmoking;
        rdIsSmokingNo.Checked = !IsSmoking;

        ImgBtnSave.Visible = (Convert.ToInt32(dtUserCV.Rows[0]["CvFocusCode"]) > (int)PIKCV.COM.EnumDB.CVFocusCode.References);
        ImgBtnContinue.Visible = !(ImgBtnSave.Visible);

        dvScript.InnerHtml = "<script>OtherDown('" + lbCities.ClientID + "', " + ((int)PIKCV.COM.EnumDB.Places.OtherPlaceID).ToString() + ")</script>";
    }

    private void ReplaceNavigateURL(ref HyperLink hl, PIKCV.COM.EnumDB.CVFocusCode CVFocusCode)
    {
        hl.NavigateUrl = hl.NavigateUrl.Replace("||FocusNo||", ((int)CVFocusCode).ToString());
    }

    protected void ImgBtnContinue_Click(object sender, ImageClickEventArgs e) {
        PIKCV.BUS.UserCVs objUserCV = new PIKCV.BUS.UserCVs();

        ArrayList arrSelectedCities = new ArrayList();
        ArrayList arrSelectedCountries = new ArrayList();
        ArrayList arrSelectedLabouringTypes = new ArrayList();

        if (Request.Form[lbSelectedCities.UniqueID] != null) {
            arrSelectedCities.AddRange(Request.Form[lbSelectedCities.UniqueID].Split(','));
        }

        if (Request.Form[lbSelectedCountries.UniqueID] != null) {
            arrSelectedCountries.AddRange(Request.Form[lbSelectedCountries.UniqueID].Split(','));
        }

        foreach (ListItem li in chLabouringTypes.Items) {
            if (li.Selected) {
                arrSelectedLabouringTypes.Add(li.Value);
            }
        }

        bool HasTravelDifficulty = rdHasTravelDifficultyYes.Checked;

        if (objUserCV.SavePlacementPreferences(this.smUserID, arrSelectedCities, arrSelectedCountries, HasTravelDifficulty, arrSelectedLabouringTypes, rdIsSmokingYes.Checked))
        {
            if (ImgBtnContinue.Visible == true)
            {
                this.smCVFocus = objUserCV.CVFocus(this.smUserID);
                this.Redirect("Employee-Membership-CV&CVFocus=" + ((int)PIKCV.COM.EnumDB.CVFocusCode.ProhibitedCompanies).ToString());
            }
            else {
                ShowModal.Show(UserControls_Common_uModalPopup.Icons.alert, PIKCV.COM.EnumDB.ErrorTypes.UpdateCV);
            }
        }
        else
        {
            ShowModal.Show(UserControls_Common_uModalPopup.Icons.alert, PIKCV.COM.EnumDB.ErrorTypes.NoUpdateCV);
        }
    }
}
