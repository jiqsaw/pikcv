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

public partial class UserControls_Company_Jobs_Jobs_uSeekingQuality : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            imgContinue.Attributes.Add("onmousedown", PIKCV.COM.Util.SelectAllListboxScript(lbSelectedSectors.ClientID, lbSelectedPerfection.ClientID, lbSelectedPositions.ClientID));
            imgSave.Attributes.Add("onmousedown", PIKCV.COM.Util.SelectAllListboxScript(lbSelectedSectors.ClientID, lbSelectedPerfection.ClientID, lbSelectedPositions.ClientID));
            ArrangeAddRemoveButtons();
            FillForm();


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
        imgAddToListSector.Attributes.Add("onclick", "SwapItem('" + lbSectors.ClientID + "','" + lbSelectedSectors.ClientID + "', ' ', '" + this.Config(PIKCV.COM.EnumUtil.Config.MaxJobSeekingQualitySectorAndPosition) + "')");
        imgRemoveToListSector.Attributes.Add("onclick", "SwapItem('" + lbSelectedSectors.ClientID + "','" + lbSectors.ClientID + "', ' ')");
        imgAddToListPerfection.Style.Add("cursor", "pointer");
        imgRemoveToListPerfection.Style.Add("cursor", "pointer");
        imgAddToListPerfection.Attributes.Add("onclick", "SwapItem('" + lbPerfection.ClientID + "','" + lbSelectedPerfection.ClientID + "', ' ', '" + this.Config(PIKCV.COM.EnumUtil.Config.MaxJobPerfection) + "')");
        imgRemoveToListPerfection.Attributes.Add("onclick", "SwapItem('" + lbSelectedPerfection.ClientID + "','" + lbPerfection.ClientID + "', ' ')");
        imgAddToListPosition.Style.Add("cursor", "pointer");
        imgRemoveToListPosition.Style.Add("cursor", "pointer");
        imgAddToListPosition.Attributes.Add("onclick", "SwapItem('" + lbPositions.ClientID + "','" + lbSelectedPositions.ClientID + "', ' ', '" + this.Config(PIKCV.COM.EnumUtil.Config.MaxJobSeekingQualitySectorAndPosition) + "')");
        imgRemoveToListPosition.Attributes.Add("onclick", "SwapItem('" + lbSelectedPositions.ClientID + "','" + lbPositions.ClientID + "', ' ')");
    }

    private void FillForm()
    {
        //DataBindHelper.BindDDL(ref drpPositions, this.cmbPositions, "PositionName", "PositionID", "", "Lütfen seçiniz...", "0");
        rdAgeRange.Items[0].Value = ((int)PIKCV.COM.EnumDB.AgeRange.age_All).ToString();
        rdAgeRange.Items[1].Value = ((int)PIKCV.COM.EnumDB.AgeRange.age_18_24).ToString();
        rdAgeRange.Items[2].Value = ((int)PIKCV.COM.EnumDB.AgeRange.age_25_29).ToString();
        rdAgeRange.Items[3].Value = ((int)PIKCV.COM.EnumDB.AgeRange.age_30_34).ToString();
        rdAgeRange.Items[4].Value = ((int)PIKCV.COM.EnumDB.AgeRange.age_35_39).ToString();
        rdAgeRange.Items[5].Value = ((int)PIKCV.COM.EnumDB.AgeRange.age_40_44).ToString();
        rdAgeRange.Items[6].Value = ((int)PIKCV.COM.EnumDB.AgeRange.age_45_55).ToString();
        rdAgeRange.Items[7].Value = ((int)PIKCV.COM.EnumDB.AgeRange.age_56over).ToString();
        DataBindHelper.BindRadioButtonList(ref rblLabouringTypes, this.cmbLabouringTypes, "LabouringTypeName", "LabouringTypeID", "1");
        rblGender.Items[0].Value = ((int)PIKCV.COM.EnumDB.SexCode.Male).ToString();
        rblGender.Items[1].Value = ((int)PIKCV.COM.EnumDB.SexCode.Female).ToString();
        rblGender.Items[2].Value = ((int)PIKCV.COM.EnumDB.SexCode.Both).ToString();
        FillListBoxSector();
        FillListBoxPosition();
        FillListBoxPerfection();
        FillDetails();
    }

    private void FillListBoxPosition()
    {
        PIKCV.BUS.Job objJob = new PIKCV.BUS.Job();
        DataTable dtJobPosition = objJob.GetJobQualityPositionNames(this.smJobID);
        DataBindHelper.BindListbox(ref lbSelectedPositions, dtJobPosition, "PositionName", "PositionID");

        DataTable dtPosition = this.cmbPositions;
        DataTable dtPositionNew = new DataTable();

        if (dtJobPosition.Rows.Count > 0)
        {
            dtPositionNew.Columns.Add("PositionID");
            dtPositionNew.Columns.Add("PositionName");

            bool add = true;
            foreach (DataRow drCache in dtPosition.Rows)
            {
                add = true;
                foreach (DataRow dr in dtJobPosition.Rows)
                {
                    if (dr["PositionID"].ToString() == drCache["PositionID"].ToString())
                    {
                        add = false;
                        break;
                    }
                }
                if (add)
                {
                    DataRow drNew = dtPositionNew.NewRow();
                    drNew["PositionID"] = drCache["PositionID"].ToString();
                    drNew["PositionName"] = drCache["PositionName"].ToString();
                    dtPositionNew.Rows.Add(drNew);
                }
            }
        }
        else { dtPositionNew = dtPosition.Copy(); }

        DataBindHelper.BindListbox(ref lbPositions, dtPositionNew, "PositionName", "PositionID", "");
    }

    private void FillListBoxSector()
    {
        PIKCV.BUS.Job objJob = new PIKCV.BUS.Job();
        DataTable dtJobSectors = objJob.GetJobQualitySectorNames(this.smJobID);
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

    private void FillListBoxPerfection()
    {
        PIKCV.BUS.Job objJob = new PIKCV.BUS.Job();
        DataTable dtJobPerfection = objJob.GetJobPerfection(this.smJobID);
        DataBindHelper.BindListbox(ref lbSelectedPerfection, dtJobPerfection, "PerfectionName", "PerfectionID");

        DataTable dtPerfection = this.cmbPerfection;
        DataTable dtPerfectionNew = new DataTable();

        if (dtJobPerfection.Rows.Count > 0)
        {
            dtPerfectionNew.Columns.Add("PerfectionID");
            dtPerfectionNew.Columns.Add("PerfectionName");

            bool add = true;
            foreach (DataRow drCache in dtPerfection.Rows)
            {
                add = true;
                foreach (DataRow dr in dtJobPerfection.Rows)
                {
                    if (dr["PerfectionID"].ToString() == drCache["PerfectionID"].ToString())
                    {
                        add = false;
                        break;
                    }
                }
                if (add)
                {
                    DataRow drNew = dtPerfectionNew.NewRow();
                    drNew["PerfectionID"] = drCache["PerfectionID"].ToString();
                    drNew["PerfectionName"] = drCache["PerfectionName"].ToString();
                    dtPerfectionNew.Rows.Add(drNew);
                }
            }
        }
        else { dtPerfectionNew = dtPerfection.Copy(); }

        DataBindHelper.BindListbox(ref lbPerfection, dtPerfectionNew, "PerfectionName", "PerfectionID", "");
    }

    private void FillDetails()
    {
        PIKCV.BUS.Job obj = new PIKCV.BUS.Job();
        DataTable dtJobInfo = obj.GetJobInfo(this.smJobID);
        if (dtJobInfo.Rows.Count > 0)
        {
            //drpPositions.SelectedValue = dtJobInfo.Rows[0]["PositionIDQuality"].ToString();
            rblGender.SelectedValue = dtJobInfo.Rows[0]["Gender"].ToString();
            rdAgeRange.SelectedValue = dtJobInfo.Rows[0]["AgeRange"].ToString();
            rblLabouringTypes.SelectedValue = dtJobInfo.Rows[0]["LabouringTypeID"].ToString();
        }
    }

    protected void imgContinue_Click(object sender, ImageClickEventArgs e)
    {
        ArrayList arrSelectedSectors = new ArrayList();
        ArrayList arrSelectedPerfection = new ArrayList();
        ArrayList arrSelectedPositions = new ArrayList();
        if (Request.Form[lbSelectedSectors.UniqueID] != null)
        {
            arrSelectedSectors.AddRange(Request.Form[lbSelectedSectors.UniqueID].Split(','));
        }
        if (Request.Form[lbSelectedPerfection.UniqueID] != null)
        {
            arrSelectedPerfection.AddRange(Request.Form[lbSelectedPerfection.UniqueID].Split(','));
        }
        if (Request.Form[lbSelectedPositions.UniqueID] != null)
        {
            arrSelectedPositions.AddRange(Request.Form[lbSelectedPositions.UniqueID].Split(','));
        }
        PIKCV.BUS.Job objJob = new PIKCV.BUS.Job();
        if (objJob.SaveJobSeekingQualityAll(this.smJobID, arrSelectedSectors, arrSelectedPerfection, arrSelectedPositions, rblGender.SelectedValue, rdAgeRange.SelectedValue, rblLabouringTypes.SelectedValue))
        {
            pnlError.Visible = false;
            if (this.smJobSaveType == PIKCV.COM.Enumerations.JobSaveType.NewJobEntry)
            {
                this.smJobFocus = PIKCV.COM.EnumDB.JobsFocusCode.PreferencePriority;
                this.Redirect("Company-Jobs-Jobs&JobFocus=" + ((int)PIKCV.COM.EnumDB.JobsFocusCode.PreferencePriority).ToString());
            }
            else
            {
                Response.Write("<script>alert('Yapmýþ olduðunuz deðiþiklikler kaydedilmiþtir');window.location.href('pikcv.aspx?pik=Company-Jobs-Jobs&JobFocus=" + ((int)PIKCV.COM.EnumDB.JobsFocusCode.SeekingQuality).ToString() + "');</script>");
            }
        }
        else
        {
            pnlError.Visible = true;
            ltlError.Text = "Kayýt sýrasýnda bir hata oluþtu lütfen tekrar deneyin";
        }
    }
}



