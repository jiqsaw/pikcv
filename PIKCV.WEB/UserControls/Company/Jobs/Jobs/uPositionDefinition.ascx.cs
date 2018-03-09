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

public partial class UserControls_Company_Jobs_Jobs_uPositionDefinition : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            imgContinue.Attributes.Add("onmousedown", PIKCV.COM.Util.SelectAllListboxScript(lbSelectedSectors.ClientID, lbSelectedCountry.ClientID, lbSelectedCity.ClientID));
            imgSave.Attributes.Add("onmousedown", PIKCV.COM.Util.SelectAllListboxScript(lbSelectedSectors.ClientID, lbSelectedCountry.ClientID, lbSelectedCity.ClientID));
            ArrangeAddRemoveButtons();
            FillForm();
            DataTable dtJobDetail = PIKCV.BUS.Job.GetJobDetail(this.smJobID);
            if ((this.smJobID > 0) && (dtJobDetail.Rows.Count > 0)) {
            drpPositions.Enabled = (Convert.ToInt32(dtJobDetail.Rows[0]["JobStatus"]) == (int)PIKCV.COM.EnumDB.JobStatus.Deleted);
            }

            if (this.smJobSaveType == PIKCV.COM.Enumerations.JobSaveType.NewJobEntry)
            {
                imgContinue.Visible = true;
            }
            else
            { imgSave.Visible = true; }
        }
    }

    private void ArrangeAddRemoveButtons()
    {
        imgAddToListSector.Style.Add("cursor", "pointer");
        imgRemoveToListSector.Style.Add("cursor", "pointer");
        imgAddToListSector.Attributes.Add("onclick", "SwapItem('" + lbSectors.ClientID + "','" + lbSelectedSectors.ClientID + "', ' ', '" + this.Config(PIKCV.COM.EnumUtil.Config.MaxJobSector) + "')");
        imgRemoveToListSector.Attributes.Add("onclick", "SwapItem('" + lbSelectedSectors.ClientID + "','" + lbSectors.ClientID + "', ' ')");
        imgAddToListCountry.Style.Add("cursor", "pointer");
        imgRemoveToListCountry.Style.Add("cursor", "pointer");
        imgAddToListCountry.Attributes.Add("onclick", "SwapItem('" + lbCountry.ClientID + "','" + lbSelectedCountry.ClientID + "', ' ', '" + this.Config(PIKCV.COM.EnumUtil.Config.MaxJobPlace) + "')");
        imgRemoveToListCountry.Attributes.Add("onclick", "SwapItem('" + lbSelectedCountry.ClientID + "','" + lbCountry.ClientID + "', ' ')");
        imgAddToListCity.Style.Add("cursor", "pointer");
        imgRemoveToListCity.Style.Add("cursor", "pointer");
        imgAddToListCity.Attributes.Add("onclick", "SwapItem('" + lbCity.ClientID + "','" + lbSelectedCity.ClientID + "', ' ', '" + this.Config(PIKCV.COM.EnumUtil.Config.MaxJobPlace) + "')");
        imgRemoveToListCity.Attributes.Add("onclick", "SwapItem('" + lbSelectedCity.ClientID + "','" + lbCity.ClientID + "', ' ')");
    }

    private void FillForm()
    {        
        //drpNumberOfWorkers.Items[1].Value = ((int)PIKCV.COM.EnumDB.WorkerNumberRange.number_1).ToString();
        //drpNumberOfWorkers.Items[2].Value = ((int)PIKCV.COM.EnumDB.WorkerNumberRange.number_2).ToString();
        //drpNumberOfWorkers.Items[3].Value = ((int)PIKCV.COM.EnumDB.WorkerNumberRange.number_3).ToString();
        //drpNumberOfWorkers.Items[4].Value = ((int)PIKCV.COM.EnumDB.WorkerNumberRange.number_3_5).ToString();
        //drpNumberOfWorkers.Items[5].Value = ((int)PIKCV.COM.EnumDB.WorkerNumberRange.number_5_10).ToString();
        //drpNumberOfWorkers.Items[6].Value = ((int)PIKCV.COM.EnumDB.WorkerNumberRange.number_10_20).ToString();
        //drpNumberOfWorkers.Items[7].Value = ((int)PIKCV.COM.EnumDB.WorkerNumberRange.number_20over).ToString();
        
        FillListBoxSector();
        FillListBoxCountry();
        FillListBoxCity();
        FillDetails();
    }

    private void FillListBoxSector()
    {
        PIKCV.BUS.Job objJob = new PIKCV.BUS.Job();
        DataTable dtJobSectors = objJob.GetJobSectorNames(this.smJobID);
        DataBindHelper.BindListbox(ref lbSelectedSectors, dtJobSectors, "SectorName", "SectorID");

        DataTable dtSectors = this.cmbSectors;
        DataTable dtSectorsNew = new DataTable();

        if (dtJobSectors.Rows.Count > 0)
        {
            dtSectorsNew.Columns.Add("SectorID");
            dtSectorsNew.Columns.Add("SectorName");

            bool add = true;
            foreach (DataRow drCache in dtSectors.Rows)
            {
                add = true;
                foreach (DataRow dr in dtJobSectors.Rows)
                {
                    if (dr["SectorID"].ToString() == drCache["SectorID"].ToString())
                    {
                        add = false;
                        break;
                    }
                }
                if (add)
                {
                    DataRow drNew = dtSectorsNew.NewRow();
                    drNew["SectorID"] = drCache["SectorID"].ToString();
                    drNew["SectorName"] = drCache["SectorName"].ToString();
                    dtSectorsNew.Rows.Add(drNew);
                }
            }
        }
        else { dtSectorsNew = dtSectors.Copy(); }

        DataBindHelper.BindListbox(ref lbSectors, dtSectorsNew, "SectorName", "SectorID", "");
    }

    private void FillListBoxCountry()
    {
        PIKCV.BUS.Job objJob = new PIKCV.BUS.Job();
        DataTable dtJobCountries = objJob.GetJobPlaceNames(this.smJobID, PIKCV.COM.EnumDB.Places.CountriesParentID);
        DataBindHelper.BindListbox(ref lbSelectedCountry, dtJobCountries, "PlaceName", "PlaceID");

        DataTable dtCountries = this.cmbCountries;
        DataTable dtCountriesNew = new DataTable();

        if (dtJobCountries.Rows.Count > 0)
        {
            dtCountriesNew.Columns.Add("PlaceID");
            dtCountriesNew.Columns.Add("PlaceName");

            bool add = true;
            foreach (DataRow drCache in dtCountries.Rows)
            {
                add = true;
                foreach (DataRow dr in dtJobCountries.Rows)
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

        DataBindHelper.BindListbox(ref lbCountry, dtCountriesNew, "PlaceName", "PlaceID", "");
    }

    private void FillListBoxCity()
    {
        PIKCV.BUS.Job objJob = new PIKCV.BUS.Job();
        DataTable dtJobCities = objJob.GetJobPlaceNames(this.smJobID, PIKCV.COM.EnumDB.Places.TurkeyPlaceID);
        DataBindHelper.BindListbox(ref lbSelectedCity, dtJobCities, "PlaceName", "PlaceID");

        DataTable dtCities = this.cmbTurkeyCities;
        DataTable dtCitiesNew = new DataTable();

        if (dtJobCities.Rows.Count > 0)
        {
            dtCitiesNew.Columns.Add("PlaceID");
            dtCitiesNew.Columns.Add("PlaceName");

            bool add = true;
            foreach (DataRow drCache in dtCities.Rows)
            {
                add = true;
                foreach (DataRow dr in dtJobCities.Rows)
                {
                    if (dr["PlaceID"].ToString() == drCache["PlaceID"].ToString())
                    {
                        add = false;
                        break;
                    }
                }
                if (add)
                {
                    DataRow drNew = dtCitiesNew.NewRow();
                    drNew["PlaceID"] = drCache["PlaceID"].ToString();
                    drNew["PlaceName"] = drCache["PlaceName"].ToString();
                    dtCitiesNew.Rows.Add(drNew);
                }
            }
        }
        else { dtCitiesNew = dtCities.Copy(); }

        DataBindHelper.BindListbox(ref lbCity, dtCitiesNew, "PlaceName", "PlaceID", "");
    }

    private void FillDetails()
    {
        PIKCV.BUS.Job obj = new PIKCV.BUS.Job();
        DataTable dtJobInfo = obj.GetJobInfo(this.smJobID);
        if (dtJobInfo.Rows.Count > 0)
        {
            PIKCV.COM.EnumDB.EmployeeTypes EmployeeType = PIKCV.COM.EnumDB.EmployeeTypes.Unknown;
            EmployeeType = (PIKCV.COM.EnumDB.EmployeeTypes)Convert.ToInt32(dtJobInfo.Rows[0]["UserTypeID"]);
            DataBindHelper.BindDDL(ref drpPositions, PIKCV.BUS.Position.GetPositions(EmployeeType, this.smLanguageID, false), "PositionName", "PositionID", "", "Lütfen Seçiniz...", "0");
            txtReferanceNumber.Text = dtJobInfo.Rows[0]["ReferenceNumber"].ToString();
            txtJobDescription.Text = dtJobInfo.Rows[0]["JobDescription"].ToString();
            if (dtJobInfo.Rows[0]["NumberOfWorkers"].ToString() == "0")
            { txtNumberOfWorkers.Text = ""; }
            else { txtNumberOfWorkers.Text = dtJobInfo.Rows[0]["NumberOfWorkers"].ToString(); }

            //drpNumberOfWorkers.SelectedValue = dtJobInfo.Rows[0]["NumberOfWorkers"].ToString();

            drpPositions.SelectedValue = dtJobInfo.Rows[0]["PositionID"].ToString();
        }
    }

    protected void imgContinue_Click(object sender, ImageClickEventArgs e)
    {
        int SavedJobID = 0;
        ArrayList arrSelectedSectors = new ArrayList();
        ArrayList arrSelectedCountries = new ArrayList();
        ArrayList arrSelectedCities = new ArrayList();
        if (Request.Form[lbSelectedSectors.UniqueID] != null)
        {
            arrSelectedSectors.AddRange(Request.Form[lbSelectedSectors.UniqueID].Split(','));
        }
        if (Request.Form[lbSelectedCountry.UniqueID] != null)
        {
            arrSelectedCountries.AddRange(Request.Form[lbSelectedCountry.UniqueID].Split(','));
        }
        if (Request.Form[lbSelectedCity.UniqueID] != null)
        {
            arrSelectedCities.AddRange(Request.Form[lbSelectedCity.UniqueID].Split(','));
        }
        PIKCV.BUS.Job objJob = new PIKCV.BUS.Job();
        int NumberOfWorkers = 0;
        if (txtNumberOfWorkers.Text != "")
        {
            NumberOfWorkers = Convert.ToInt32(txtNumberOfWorkers.Text);
        }
        //NumberOfWorkers = int.Parse(drpNumberOfWorkers.SelectedValue);
        SavedJobID = objJob.SaveJobPositionDefinition(this.smJobID, NumberOfWorkers,
            arrSelectedSectors, Convert.ToInt32(drpPositions.SelectedValue), arrSelectedCountries, arrSelectedCities, txtJobDescription.Text);
        if (SavedJobID != 0)
        {
            pnlError.Visible = false;
            if (this.smJobSaveType == PIKCV.COM.Enumerations.JobSaveType.NewJobEntry)
            {
                this.smJobFocus = PIKCV.COM.EnumDB.JobsFocusCode.EducationLevel;
                this.Redirect("Company-Jobs-Jobs&JobFocus=" + ((int)PIKCV.COM.EnumDB.JobsFocusCode.EducationLevel).ToString());
            }
            else
            {
                Response.Write("<script>alert('Yapmýþ olduðunuz deðiþiklikler kaydedilmiþtir');window.location.href('pikcv.aspx?pik=Company-Jobs-Jobs&JobFocus=" + ((int)PIKCV.COM.EnumDB.JobsFocusCode.PositionDefinition).ToString() + "');</script>");
            }
        }
        else
        {
            pnlError.Visible = true;
            ltlError.Text = "Kayýt sýrasýnda bir hata oluþtu lütfen tekrar deneyin";
        }
    }
}
