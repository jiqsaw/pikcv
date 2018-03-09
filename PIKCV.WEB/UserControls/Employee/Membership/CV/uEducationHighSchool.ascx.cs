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

public partial class UserControls_Employee_Membership_CV_uEducationHighSchool : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CARETTA.COM.DataBindHelper.BindDDL(ref ddlHighSchoolTypes, PIKCV.COM.Data.GetSchools(this.cmbSchools, PIKCV.COM.EnumDB.SchoolTypes.HighSchoolTypes), "SchoolName", "SchoolID", "0", "Lütfen Seçiniz", "0");
            CARETTA.COM.DataBindHelper.BindDDL(ref ddlEducationStates, this.cmbEducationStates, "EducationStatusName", "EducationStatusID", "0", "Lütfen Seçiniz", "0");
            ddlEducationStates.Attributes.Add("onchange", "ShowDate(this, '" + (int)PIKCV.COM.EnumDB.EducationStates.Graduate + "')");
            UEducationNav1.SelectEducationTypes(PIKCV.COM.EnumDB.EducationTypes.HighSchool);
        }
    }


    protected void Page_PreRender(object sender, EventArgs e)
    {
        PIKCV.BUS.UserCVs objUserCV = new PIKCV.BUS.UserCVs();
        DataTable dtUserCV = objUserCV.GetUserCV(this.smUserID);
        if (dtUserCV.Rows.Count > 0)
        {
            FillData(dtUserCV);
        }
    }

    private void FillData(DataTable dt)
    {
        ddlHighSchoolTypes.SelectedValue = dt.Rows[0]["HighSchoolTypeID"].ToString();
        txtHighSchoolName.Text = dt.Rows[0]["HighSchoolName"].ToString();
        ddlEducationStates.SelectedValue = dt.Rows[0]["HighSchoolStatusID"].ToString();
        //ImgBtnSave.Visible = (Convert.ToInt32(dt.Rows[0]["CvFocusCode"]) > (int)PIKCV.COM.EnumDB.CVFocusCode.References);
        //ImgBtnContinue.Visible = !(ImgBtnSave.Visible);
        //if (int.Parse(ddlEducationStates.SelectedValue) > 0) {
        //    UDate1.Date = Convert.ToDateTime(dt.Rows[0]["HighSchoolEndDate"]);
        //}
        dvScript.InnerHtml = "<script>ShowDate(document.getElementById('" + ddlEducationStates.ClientID + "'), '" + (int)PIKCV.COM.EnumDB.EducationStates.Graduate + "');</script>";
    }

    protected void ImgBtnContinue_Click(object sender, ImageClickEventArgs e)
    {
        PIKCV.BUS.UserCVs objUserCV = new PIKCV.BUS.UserCVs();
        if (objUserCV.SaveEducationHighSchool(this.smUserID, int.Parse(ddlHighSchoolTypes.SelectedValue), txtHighSchoolName.Text, UDate1.Date, int.Parse(ddlEducationStates.SelectedValue))) {
            Response.Write("<script>alert('Bilgileriniz Kaydedildi');window.close();window.opener.location.reload();</script>");
        }
        else {
            Response.Write("<script>alert('! Bilgileriniz kaydedilemedi.')</script>");
        }
    }
}
