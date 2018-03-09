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

public partial class UserControls_Employee_Membership_CV_uEmploymentChooices : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ReplaceNavigateURL(ref hlPlacementPreferences, PIKCV.COM.EnumDB.CVFocusCode.PlacementPreferences);
            ReplaceNavigateURL(ref hlReferences, PIKCV.COM.EnumDB.CVFocusCode.References);
            ReplaceNavigateURL(ref hlProhibitedCompanies, PIKCV.COM.EnumDB.CVFocusCode.ProhibitedCompanies);

            imgAddToListPositons.Style.Add("cursor", "pointer");
            imgAddToListSector.Style.Add("cursor", "pointer");
            imgRemoveToListPositions.Style.Add("cursor", "pointer");
            imgRemoveToListSector.Style.Add("cursor", "pointer");

            imgAddToListSector.Attributes.Add("onclick", "SwapItem('" + lbSectors.ClientID + "','" + lbSelectedSectors.ClientID + "', ' ', '" + this.Config(PIKCV.COM.EnumUtil.Config.MaxSector) + "')");
            imgRemoveToListSector.Attributes.Add("onclick", "SwapItem('" + lbSelectedSectors.ClientID + "','" + lbSectors.ClientID + "', ' ')");

            imgAddToListPositons.Attributes.Add("onclick", "SwapItem('" + lbPositions.ClientID + "','" + lbSelectedPositions.ClientID + "', ' ', '" + this.Config(PIKCV.COM.EnumUtil.Config.MaxPosition) + "')");
            imgRemoveToListPositions.Attributes.Add("onclick", "SwapItem('" + lbSelectedPositions.ClientID + "','" + lbPositions.ClientID + "', ' ')");

            ImgBtnContinue.Attributes.Add("onmousedown", PIKCV.COM.Util.SelectAllListboxScript(lbSelectedSectors.ClientID, lbSelectedPositions.ClientID));
            ImgBtnSave.Attributes.Add("onmousedown", PIKCV.COM.Util.SelectAllListboxScript(lbSelectedSectors.ClientID, lbSelectedPositions.ClientID));

        }
    }

    private void ReplaceNavigateURL(ref HyperLink hl, PIKCV.COM.EnumDB.CVFocusCode CVFocusCode)
    {
        hl.NavigateUrl = hl.NavigateUrl.Replace("||FocusNo||", ((int)CVFocusCode).ToString());
    }

    protected void Page_PreRender(object sender, EventArgs e)
    {
        PIKCV.BUS.UserCVs objUserEmploymentChooices = new PIKCV.BUS.UserCVs();

        DataTable dtUserSectors = objUserEmploymentChooices.GetUserSectors(this.smUserID, (int)this.smLanguageID);
        DataTable dtUserPositions = objUserEmploymentChooices.GetUserPositions(this.smUserID, (int)this.smLanguageID);

        DataBindHelper.BindListbox(ref lbSelectedSectors, dtUserSectors, "SectorName", "SectorID");
        DataBindHelper.BindListbox(ref lbSelectedPositions, dtUserPositions, "PositionName", "PositionID");

        DataTable dtSectors = this.cmbSectors;
        DataTable dtSectorsNew = new DataTable();

        if (dtUserSectors.Rows.Count > 0)
        {
            dtSectorsNew.Columns.Add("SectorID");
            dtSectorsNew.Columns.Add("SectorName");

            bool add = true;
            foreach (DataRow drCache in dtSectors.Rows)
            {
                add = true;
                foreach (DataRow dr in dtUserSectors.Rows)
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


        DataTable dtPositions = this.cmbPositions;
        DataTable dtPositionsNew = new DataTable();

        if (dtPositions.Rows.Count > 0)
        {
            dtPositionsNew.Columns.Add("PositionID");
            dtPositionsNew.Columns.Add("PositionName");

            bool add = true;
            foreach (DataRow drCache in dtPositions.Rows)
            {
                add = true;
                foreach (DataRow dr in dtUserPositions.Rows)
                {
                    if (dr["PositionID"].ToString() == drCache["PositionID"].ToString())
                    {
                        add = false;
                        break;
                    }
                    if ((this.smEmployeeType != PIKCV.COM.EnumDB.EmployeeTypes.Unknown) && ((PIKCV.COM.EnumDB.EmployeeTypes)(Convert.ToInt32(drCache["PositionTypeCode"])) != this.smEmployeeType)) {
                        add = false;
                        break;
                    }
                }
                if (add)
                {
                    DataRow drNew;
                    if (this.smEmployeeType != PIKCV.COM.EnumDB.EmployeeTypes.Unknown) {
                        if (this.smEmployeeType == (PIKCV.COM.EnumDB.EmployeeTypes)(Convert.ToInt16(drCache["PositionTypeCode"]))) {
                            drNew = dtPositionsNew.NewRow();
                            drNew["PositionID"] = drCache["PositionID"].ToString();
                            drNew["PositionName"] = drCache["PositionName"].ToString();
                            dtPositionsNew.Rows.Add(drNew);
                        }
                    }
                    else {
                        drNew = dtPositionsNew.NewRow();
                        drNew["PositionID"] = drCache["PositionTypeCode"] + "_||" + drCache["PositionID"].ToString();
                        drNew["PositionName"] = drCache["PositionName"].ToString();
                        dtPositionsNew.Rows.Add(drNew);
                    }
                    
                }
            }
        }
        else { dtPositionsNew = dtPositions.Copy(); }

        DataBindHelper.BindListbox(ref lbSectors, dtSectorsNew, "SectorName", "SectorID", "0");
        DataBindHelper.BindListbox(ref lbPositions, dtPositionsNew, "PositionName", "PositionID", "0");
        PIKCV.BUS.UserCVs objUserCV = new PIKCV.BUS.UserCVs();
        DataTable dtUserCV = objUserCV.GetUserCV(this.smUserID);
        ImgBtnSave.Visible = (Convert.ToInt32(dtUserCV.Rows[0]["CvFocusCode"]) > (int)PIKCV.COM.EnumDB.CVFocusCode.References);
        ImgBtnContinue.Visible = !(ImgBtnSave.Visible);
    }

    protected void ImgBtnContinue_Click(object sender, ImageClickEventArgs e)
    {
        PIKCV.BUS.UserCVs objUserCV = new PIKCV.BUS.UserCVs();

        ArrayList arrSelectedSectors = new ArrayList();
        ArrayList arrSelectedPositions = new ArrayList();

        if (Request.Form[lbSelectedSectors.UniqueID] != null) {
            arrSelectedSectors.AddRange(Request.Form[lbSelectedSectors.UniqueID].Split(','));
        }

        if (Request.Form[lbSelectedPositions.UniqueID] != null) {
            arrSelectedPositions.AddRange(Request.Form[lbSelectedPositions.UniqueID].Split(','));
        }

        if (this.smEmployeeType == PIKCV.COM.EnumDB.EmployeeTypes.Unknown) {
            PIKCV.COM.EnumDB.EmployeeTypes EmployeeType = (PIKCV.COM.EnumDB.EmployeeTypes)(int.Parse(Util.Left(arrSelectedPositions[0].ToString(), 1)));
            for (int i = 0; i < arrSelectedPositions.Count; i++)
            {
                arrSelectedPositions[i] = arrSelectedPositions[i].ToString().Substring(arrSelectedPositions[i].ToString().IndexOf("_||") + 3);
            }
            this.smEmployeeType = EmployeeType;
        }

        if (objUserCV.SaveEmploymentChooices(this.smUserID, arrSelectedSectors, arrSelectedPositions, this.smEmployeeType))
        {
            if (ImgBtnContinue.Visible == true)
            {
                this.smCVFocus = objUserCV.CVFocus(this.smUserID);
                this.Redirect("Employee-Membership-CV&CVFocus=" + ((int)PIKCV.COM.EnumDB.CVFocusCode.PlacementPreferences).ToString());
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
