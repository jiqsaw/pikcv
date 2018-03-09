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

public partial class UserControls_Employee_Membership_CV_uPersonalInfo : BaseUserControl {

    private string Script = string.Empty;

    protected void Page_Load (object sender, EventArgs e) {
        if (!IsPostBack)
        {
            hlContactInfo.NavigateUrl = hlContactInfo.NavigateUrl.Replace("||FocusNo||", ((int)PIKCV.COM.EnumDB.CVFocusCode.ContactInfo).ToString());
        }
        ddlBirthPlace.Attributes.Add("onchange", "OpenCloseOther(" + ((int)PIKCV.COM.EnumDB.Places.OtherPlaceID).ToString() + ", '" + ddlBirthPlace.ClientID + "', 'dvOther')");
    }

    protected void Page_PreRender(object sender, EventArgs e)
    {
        if (!IsPostBack)
            FillControls();
        int StartYear = int.Parse(this.Config(PIKCV.COM.EnumUtil.Config.StartYear));
        int EndYear = DateTime.Now.AddYears(int.Parse(this.Config(PIKCV.COM.EnumUtil.Config.MinAge)) * -1).Year;
        UDate1.YearDataBind(StartYear, EndYear);
        PIKCV.BUS.UserCVs objUserCV = new PIKCV.BUS.UserCVs();
        DataTable dtUserCV = objUserCV.GetUserCV(this.smUserID);
        if (dtUserCV.Rows.Count > 0) {
            FillData(dtUserCV);
        }

        if (Script != String.Empty) { dvScript.InnerHtml = "<script>" + Script + "<script>"; }
    }

    private void FillControls()
    {
        DataBindHelper.BindDDL(ref ddlNation, this.cmbCountries, "PlaceName", "PlaceID", "-1", PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.InitialText), "-1");
        DataBindHelper.BindDDL(ref ddlBirthPlace, this.cmbTurkeyCities, "PlaceName", "PlaceID", "-1", PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.InitialText), "-1");
        DataBindHelper.BindDDL(ref ddlMaritalStates, this.cmbMaritalStates, "MaritalStatusName", "MaritalStatusID", "0", PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.InitialText), "0");
        DataBindHelper.BindDDL(ref ddlMilitaryStates, this.cmbMilitaryStates, "MilitaryStatusName", "MilitaryStatusID", "0", PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.InitialText), "0");
        DataBindHelper.LoadNumberDDL(ref ddlMilitaryYear, DateTime.Now.Year + 10, 1, DateTime.Now.Year + 1, false);
        ddlMilitaryYear.Items.Insert(0, "0");

        ddlMilitaryStates.Attributes.Add("onchange", "ShowHideMilitaryYear(this,'" + ((int)PIKCV.COM.EnumDB.MilitaryStates.Postponement).ToString() + "')");

        rdSexCode.Items[(int)PIKCV.COM.EnumDB.SexCode.Male].Attributes.Add("onclick", "ShowSexCode()");
        rdSexCode.Items[(int)PIKCV.COM.EnumDB.SexCode.Female].Attributes.Add("onclick", "HideSexCode()");

        ListItem liOther = new ListItem();
        foreach (ListItem li in ddlBirthPlace.Items)
        {
            if (li.Value == ((int)PIKCV.COM.EnumDB.Places.OtherPlaceID).ToString()) {
                liOther = li;
                break;
            }
        }
        ddlBirthPlace.Items.Remove(liOther);
        ddlBirthPlace.Items.Add(liOther);
    }

    private void FillData(DataTable dt) {
        ddlNation.SelectedValue = dt.Rows[0]["NationID"].ToString();
        UDate1.Date = Convert.ToDateTime(dt.Rows[0]["BirthDate"]);
        ddlBirthPlace.SelectedValue = dt.Rows[0]["BirthPlaceID"].ToString();
        txtOtherBirthPlace.Text = dt.Rows[0]["OtherBirthPlaceName"].ToString();
        rdSexCode.SelectedValue = dt.Rows[0]["SexCode"].ToString();
        ddlMaritalStates.SelectedValue = dt.Rows[0]["MaritalStatusID"].ToString();
        ddlMilitaryStates.SelectedValue = dt.Rows[0]["MilitaryStatusID"].ToString();
        ddlMilitaryYear.SelectedValue = dt.Rows[0]["MilitaryYear"].ToString();
        chIsDisabled.Checked = Convert.ToBoolean(dt.Rows[0]["IsDisabled"]);
        chIsOldConvicted.Checked = Convert.ToBoolean(dt.Rows[0]["IsOldConvicted"]);
        chIsMartyrRelative.Checked = Convert.ToBoolean(dt.Rows[0]["IsMartyrRelative"]);
        chIsTerrorWronged.Checked = Convert.ToBoolean(dt.Rows[0]["IsTerrorWronged"]);
        txtChronicIllness.Text = dt.Rows[0]["ChronicIllness"].ToString();

        ImgBtnSave.Visible = (Convert.ToInt32(dt.Rows[0]["CvFocusCode"]) > (int)PIKCV.COM.EnumDB.CVFocusCode.References);
        ImgBtnContinue.Visible = !(ImgBtnSave.Visible);

        if (dt.Rows[0]["SexCode"].ToString() == ((int)PIKCV.COM.EnumDB.SexCode.Female).ToString())
        {
            Script += "HideSexCode();";
        }
    }

    protected void ImgBtnContinue_Click(object sender, ImageClickEventArgs e)
    {
        int MilitaryYear = 0;
        if (ddlMilitaryStates.SelectedValue == ((int)PIKCV.COM.EnumDB.MilitaryStates.Postponement).ToString()) { 
            MilitaryYear = int.Parse(ddlMilitaryYear.SelectedValue);
        }
        PIKCV.BUS.UserCVs objUserCV = new PIKCV.BUS.UserCVs();
        if (objUserCV.SavePersonalInfo(this.smUserID, int.Parse(ddlNation.SelectedValue), UDate1.Date, int.Parse(ddlBirthPlace.SelectedValue), txtOtherBirthPlace.Text,
            (PIKCV.COM.EnumDB.SexCode)int.Parse(rdSexCode.SelectedValue), int.Parse(ddlMaritalStates.SelectedValue), int.Parse(ddlMilitaryStates.SelectedValue),
            MilitaryYear, chIsDisabled.Checked, chIsOldConvicted.Checked, chIsMartyrRelative.Checked, chIsTerrorWronged.Checked, txtChronicIllness.Text))
        {
            
            if (ImgBtnContinue.Visible == true)
            {
                this.smCVFocus = objUserCV.CVFocus(this.smUserID);
                this.Redirect("Employee-Membership-CV&CVFocus=" + ((int)PIKCV.COM.EnumDB.CVFocusCode.ContactInfo).ToString()); 
            }
            else {
                ShowModal.Show(UserControls_Common_uModalPopup.Icons.alert, PIKCV.COM.EnumDB.ErrorTypes.UpdateCV);
            }
        }
        else {
            ShowModal.Show(UserControls_Common_uModalPopup.Icons.alert, PIKCV.COM.EnumDB.ErrorTypes.NoUpdateCV);
        }
    }
}
