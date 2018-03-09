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

public partial class UserControls_Employee_Membership_CV_uEducationUniversity0Add : BaseUserControl
{
    public int UserEducationID
    {
        get { return (ViewState["UserEducationID"] == null ? 0 : int.Parse(ViewState["UserEducationID"].ToString())); }
        set { ViewState["UserEducationID"] = value; }
    }

    public PIKCV.COM.EnumDB.EducationTypes EducationType
    {
        get { return (ViewState["EducationType"] == null ? PIKCV.COM.EnumDB.EducationTypes.University1 : (PIKCV.COM.EnumDB.EducationTypes)(int.Parse(ViewState["EducationType"].ToString()))); }
        set { ViewState["EducationType"] = (int)value; }
    }
	
    protected void Page_Load(object sender, EventArgs e)
    {
        PIKCV.COM.EnumDB.SchoolTypes SubSchoolType = PIKCV.COM.EnumDB.SchoolTypes.DepartmentNames;

        DataBindHelper.BindDDL(ref ddlEducationLevels, this.cmbEducationLevels, "EducationLevelName", "EducationLevelID", "-1", PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.InitialText), "-1");
        DataBindHelper.BindDDL(ref ddlUniversityNames, PIKCV.COM.Data.GetSchools(this.cmbSchools, PIKCV.COM.EnumDB.SchoolTypes.UniversityNames), "SchoolName", "SchoolID", "-1", PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.InitialText), "-1");
        DataBindHelper.BindDDL(ref ddlUniversityDepartments, PIKCV.COM.Data.GetSchools(this.cmbSchools, SubSchoolType), "SchoolName", "SchoolID", "-1", PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.InitialText), "-1");

        ddlUniversityNames.Items.Add(new ListItem(PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.OtherText), "0"));
        ddlUniversityDepartments.Items.Add(new ListItem(PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.OtherText), "0"));

        int RmvIndex1 = 0;
        int RmvIndex2 = 0;
        int IndexNo = 0;
        foreach (ListItem li in ddlEducationLevels.Items)
        {
            if (li.Value == ((int)PIKCV.COM.EnumDB.EducationTypes.MiddleSchool).ToString()) RmvIndex1 = IndexNo;
            if (li.Value == ((int)PIKCV.COM.EnumDB.EducationTypes.HighSchool).ToString()) RmvIndex2 = IndexNo;
            IndexNo++;
        }

        ddlEducationLevels.Items.RemoveAt(RmvIndex1);
        ddlEducationLevels.Items.RemoveAt(RmvIndex2 - 1);

        ddlUniversityNames.Attributes.Add("onchange", "OpenCloseSchool()");
        ddlUniversityDepartments.Attributes.Add("onchange", "OpenCloseDepartment()");
        ddlCities.Attributes.Add("onchange", "OpenCloseCity()");

        DataBindHelper.BindDDL(ref ddlEducationStates, this.cmbEducationStates, "EducationStatusName", "EducationStatusID", "0", PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.InitialText), "0");
        //ddlEducationStates.Attributes.Add("onchange", "ShowDate(this, '" + (int)PIKCV.COM.EnumDB.EducationStates.Graduate + "')");
        ddlEducationStates.Attributes.Add("onchange", "TrEducationVisible(this, '" + (int)PIKCV.COM.EnumDB.EducationStates.Graduate + "')");

        DataBindHelper.BindDDL(ref ddlCountries, this.cmbCountries, "PlaceName", "PlaceID", "-1", "Lütfen Seçiniz", "-1");
        DataBindHelper.BindDDL(ref ddlCities, this.cmbTurkeyCities, "PlaceName", "PlaceID", "-1", "Lütfen Seçiniz", "-1");

        PIKCV.COM.Data.RemoveOtherItems(ref ddlCities, (int)PIKCV.COM.EnumDB.Places.OtherPlaceID);
    
    }

    protected void ImgBtnSave_Click(object sender, ImageClickEventArgs e)
    {
        PIKCV.BUS.UserCVs objUserCV = new PIKCV.BUS.UserCVs();

        if (objUserCV.SaveEducation(this.UserEducationID, this.smUserID, (PIKCV.COM.EnumDB.EducationTypes)(int.Parse(ddlEducationLevels.SelectedValue)), int.Parse(ddlUniversityNames.SelectedValue), 
            int.Parse(ddlEducationStates.SelectedValue), UDateStart.Date, UDateEnd.Date, txtUniversityNames.Text, int.Parse(ddlUniversityDepartments.SelectedValue), 
            txtUniversityDepartments.Text, int.Parse(ddlCountries.SelectedValue), int.Parse(ddlCities.SelectedValue), txtOtherCity.Text, txtDegree.Text, false)) {

                this.smCVFocus = PIKCV.COM.EnumDB.CVFocusCode.Employment;
                ShowModal.Show(UserControls_Common_uModalPopup.Icons.alert, PIKCV.COM.EnumDB.ErrorTypes.UpdateCV, true, true);
        }
        else {
            ShowModal.Show(UserControls_Common_uModalPopup.Icons.alert, PIKCV.COM.EnumDB.ErrorTypes.NoUpdateCV);
        }
    }

    protected void Page_PreRender(object sender, EventArgs e)
    {
        if (CARETTA.COM.Util.IsNumeric(Request.QueryString["UserOREducationID"]))
        {
            ddlEducationLevels.SelectedValue = Request.QueryString["EducationType"].ToString();
        }
        if (CARETTA.COM.Util.IsNumeric(Request.QueryString["UserOREducationID"]))
        {
            this.UserEducationID = int.Parse(Request.QueryString["UserOREducationID"]);
            PIKCV.BUS.UserCVs objUserEducation = new PIKCV.BUS.UserCVs();
            DataTable dtUserEducation = objUserEducation.GetUserEducationDetail(this.UserEducationID);
            if (dtUserEducation.Rows.Count > 0) {
                FillData(dtUserEducation);
            }
        }
    }

    private void FillData(DataTable dt)
    {
        ddlUniversityNames.SelectedValue = dt.Rows[0]["SchoolID"].ToString();
        txtUniversityNames.Text = dt.Rows[0]["OtherSchool"].ToString().Trim();
        ddlUniversityDepartments.SelectedValue = dt.Rows[0]["DepartmentID"].ToString();
        txtUniversityDepartments.Text = dt.Rows[0]["OtherDepartment"].ToString().Trim();
        ddlEducationStates.SelectedValue = dt.Rows[0]["EducationStatusID"].ToString();
        UDateStart.Date = Convert.ToDateTime(dt.Rows[0]["StartDate"]);
        if (dt.Rows[0]["EndDate"] != DBNull.Value) {
            UDateEnd.Date = Convert.ToDateTime(dt.Rows[0]["EndDate"]);
        }
        txtDegree.Text = dt.Rows[0]["Degree"].ToString().Trim();
        ddlCountries.SelectedValue = dt.Rows[0]["CountryID"].ToString();
        ddlCities.SelectedValue = dt.Rows[0]["CityID"].ToString();
        txtOtherCity.Text = dt.Rows[0]["OtherCity"].ToString().Trim();
        dvScript.InnerHtml = "<script>ShowDate(document.getElementById('" + ddlEducationStates.ClientID + "'), '" + (int)PIKCV.COM.EnumDB.EducationStates.Graduate + "');</script>";
    }
}
