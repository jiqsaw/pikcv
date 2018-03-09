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

public partial class UserControls_Employee_Membership_CV_uEmploymentAdd : BaseUserControl
{
    public int UserEmploymentID
    {
        get { return (ViewState["UserEmploymentID"] == null ? 0 : int.Parse(ViewState["UserEmploymentID"].ToString())); }
        set { ViewState["UserEmploymentID"] = value; }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            rdIsWorkingNO.Attributes.Add("onclick", "if (this.checked) { trReason.style.display='block';  trDate.style.display='block'; }");
            rdIsWorkingYES.Attributes.Add("onclick", "if (this.checked) { trReason.style.display='none';  trDate.style.display='none';  SetMinDate(); document.getElementById('" + txtReasonOfResignation.ClientID + "').value = '-'; }");
        }
    }

    protected void Page_PreRender(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataBindHelper.BindDDL(ref ddlSectors, this.cmbSectors, "SectorName", "SectorID", "0", PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.InitialText), "-1");
            ddlSectors.Items.Add(new ListItem(PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.OtherText), "0"));
            DataBindHelper.BindDDL(ref ddlPositions, this.cmbPositions, "PositionName", "PositionID", "0", PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.InitialText), "0");
            DataBindHelper.BindDDL(ref ddlLabouringTypes, this.cmbLabouringTypes, "LabouringTypeName", "LabouringTypeID", "0", PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.InitialText), "0");
            DataBindHelper.BindDDL(ref ddlCountries, this.cmbCountries, "PlaceName", "PlaceID", "-1", PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.InitialText), "-1");
            DataBindHelper.BindDDL(ref ddlCities, this.cmbTurkeyCities, "PlaceName", "PlaceID", "-1", PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.InitialText), "-1");

            PIKCV.COM.Data.RemoveOtherItems(ref ddlCities, (int)PIKCV.COM.EnumDB.Places.OtherPlaceID);

            if (CARETTA.COM.Util.IsNumeric(Request.QueryString["UserEmploymentID"]))
            {
                this.UserEmploymentID = int.Parse(Request.QueryString["UserEmploymentID"]);
                PIKCV.BUS.UserCVs objUserEmployment = new PIKCV.BUS.UserCVs();
                DataTable dtUserEmployment = objUserEmployment.GetUserEmploymentDetail(this.UserEmploymentID);
                if (dtUserEmployment.Rows.Count > 0)
                {
                    FillData(dtUserEmployment);
                }
            }
            ddlCities.Attributes.Add("onchange", "OpenCloseOther(" + ((int)PIKCV.COM.EnumDB.Places.OtherPlaceID).ToString() + ", '" + ddlCities.ClientID + "', 'dvOther')");
            //dvScript.InnerHtml = "<script>OtherDown('" + ddlCities.ClientID + "', " + ((int)PIKCV.COM.EnumDB.Places.OtherPlaceID).ToString() + ")</script>";
        }
    }

    private void FillData(DataTable dt)
    {
        txtCompanyName.Text = dt.Rows[0]["CompanyName"].ToString();
        ddlSectors.SelectedValue = dt.Rows[0]["SectorID"].ToString();
        ddlPositions.SelectedValue = dt.Rows[0]["PositionID"].ToString();
        txtJobDefinition.Text = dt.Rows[0]["JobDescription"].ToString();
        ddlLabouringTypes.SelectedValue = dt.Rows[0]["LabouringTypeID"].ToString();
        ddlCountries.SelectedValue = dt.Rows[0]["CountryID"].ToString();
        ddlCities.SelectedValue = dt.Rows[0]["CityID"].ToString();
        txtOtherCityName.Text = dt.Rows[0]["OtherCityName"].ToString();
        rdIsWorkingYES.Checked = Convert.ToBoolean(dt.Rows[0]["IsWorking"]);
        rdIsWorkingNO.Checked = !rdIsWorkingYES.Checked;
        UDateStart.Date = Convert.ToDateTime(dt.Rows[0]["StartDate"]);
        if (dt.Rows[0]["EndDate"] != DBNull.Value) {
            UDateEnd.Date = Convert.ToDateTime(dt.Rows[0]["EndDate"]);
        }
        txtReasonOfResignation.Text = dt.Rows[0]["ReasonOfResignation"].ToString();
        txtCompanyPhone.Text = dt.Rows[0]["CompanyPhone"].ToString();
        rdCanReferenceYES.Checked = Convert.ToBoolean(dt.Rows[0]["CanReference"]);
        rdCanReferenceNO.Checked = !rdCanReferenceYES.Checked;
    }

    protected void ImgBtnSave_Click(object sender, ImageClickEventArgs e)
    {
        PIKCV.BUS.UserCVs objUserCV = new PIKCV.BUS.UserCVs();

        if (objUserCV.SaveUserEmployment(this.UserEmploymentID, this.smUserID, txtCompanyName.Text, txtCompanyPhone.Text, rdCanReferenceYES.Checked, 
            int.Parse(ddlCities.SelectedValue), txtOtherCityName.Text, int.Parse(ddlCountries.SelectedValue), rdIsWorkingYES.Checked, UDateStart.Date, UDateEnd.Date, 
            txtJobDefinition.Text, int.Parse(ddlLabouringTypes.SelectedValue), int.Parse(ddlPositions.SelectedValue), 
            txtReasonOfResignation.Text, int.Parse(ddlSectors.SelectedValue)))
        {
            this.smCVFocus = PIKCV.COM.EnumDB.CVFocusCode.DriverLicense;
            ShowModal.Show(UserControls_Common_uModalPopup.Icons.alert, PIKCV.COM.EnumDB.ErrorTypes.UpdateCV, true, true);
        }
        else
        {
            ShowModal.Show(UserControls_Common_uModalPopup.Icons.alert, PIKCV.COM.EnumDB.ErrorTypes.NoUpdateCV);
        }
    }
}
