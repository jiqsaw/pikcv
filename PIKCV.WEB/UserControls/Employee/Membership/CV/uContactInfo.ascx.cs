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

public partial class UserControls_Employee_Membership_CV_uContactInfo : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            hlPersonalInfo.NavigateUrl = hlPersonalInfo.NavigateUrl.Replace("||FocusNo||", ((int)PIKCV.COM.EnumDB.CVFocusCode.PersonalInfo).ToString());

            DataBindHelper.BindDDL(ref ddlHomeCountry, this.cmbCountries, "PlaceName", "PlaceID", "-1", PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.InitialText), "-1");
            DataBindHelper.BindDDL(ref ddlHomeCity, this.cmbTurkeyCities, "PlaceName", "PlaceID", "-1", PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.InitialText), "-1");

            PIKCV.COM.Data.RemoveOtherItems(ref ddlHomeCity, (int)PIKCV.COM.EnumDB.Places.OtherPlaceID);

            PIKCV.BUS.UserCVs objUserCV = new PIKCV.BUS.UserCVs();
            DataTable dtUserCV = objUserCV.GetUserCV(this.smUserID);
            if (dtUserCV.Rows.Count > 0)
            {
                FillData(dtUserCV);
            }
        }
        ddlHomeCity.Attributes.Add("onchange", "OpenCloseOther(" + ((int)PIKCV.COM.EnumDB.Places.OtherPlaceID).ToString() + ", '" + ddlHomeCity.ClientID + "', 'dvOther')");
    }


    private void FillData(DataTable dt) {
        ddlHomeCountry.SelectedValue = dt.Rows[0]["HomeCountryID"].ToString();
        ddlHomeCity.SelectedValue = dt.Rows[0]["HomeCityID"].ToString().Trim();
        txtOtherHomeCity.Text = dt.Rows[0]["OtherHomeCityName"].ToString();
        txtAddress.Text = dt.Rows[0]["HomeAddress"].ToString().Trim();
        txtHomePhone.Text = dt.Rows[0]["HomePhone"].ToString().Trim();
        txtBusinessPhone.Text = dt.Rows[0]["BusinessPhone"].ToString().Trim();
        txtGSM.Text = dt.Rows[0]["GSM"].ToString().Trim();
        txtGSM2.Text = dt.Rows[0]["GSM2"].ToString().Trim();
        txtContactEmail.Text = dt.Rows[0]["ContactEmail"].ToString().Trim();
        txtAlternateContactName.Text = dt.Rows[0]["AlternateContactName"].ToString().Trim();
        txtAlternateContactPhone.Text = dt.Rows[0]["AlternateContactPhone"].ToString().Trim();
        ImgBtnSave.Visible = (Convert.ToInt32(dt.Rows[0]["CvFocusCode"]) > (int)PIKCV.COM.EnumDB.CVFocusCode.References);
        ImgBtnContinue.Visible = !(ImgBtnSave.Visible);
    }

    protected void ImgBtnContinue_Click(object sender, ImageClickEventArgs e)
    {
        PIKCV.BUS.UserCVs objUserCV = new PIKCV.BUS.UserCVs();
        if (objUserCV.SaveContactInfo(this.smUserID, int.Parse(ddlHomeCountry.SelectedValue), int.Parse(ddlHomeCity.SelectedValue), txtOtherHomeCity.Text, txtAddress.Text, 
            txtHomePhone.Text, txtBusinessPhone.Text, txtGSM.Text, txtGSM2.Text, txtContactEmail.Text, 
            txtAlternateContactName.Text, txtAlternateContactPhone.Text)) {

                if (ImgBtnContinue.Visible == true)
                {
                    this.smCVFocus = PIKCV.COM.EnumDB.CVFocusCode.Education;
                    this.Redirect("Employee-Membership-CV&CVFocus=" + ((int)PIKCV.COM.EnumDB.CVFocusCode.Education).ToString());
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
