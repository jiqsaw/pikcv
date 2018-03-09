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

public partial class UserControls_Employee_Membership_CV_uDriverLicense : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //DataBindHelper.LoadNumberDDL(ref ddlDriverLicenseYear, DateTime.Now.Year, 1, DateTime.Now.AddYears(-40).Year);
            //ddlDriverLicenseYear.Items.Insert(0, new ListItem(PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.InitialText), "0"));
            //DataBindHelper.BindDDL(ref ddlDriverLicenseTypes, this.cmbDriverLicenceTypes, "DriverLicenseTypeName", "DriverLicenseTypeID", "0", PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.InitialText), "0");
            UCharacteristicAndSocialLifeNav1.SelectNavigatorLink(PIKCV.COM.EnumDB.CVFocusCode.DriverLicense);
            //ddlDriverLicenseTypes.Attributes.Add("onchange", "ShowHideLicenceYear('" + ddlDriverLicenseTypes.ClientID + "','" + (int)PIKCV.COM.EnumDB.LicenceTypes.NoneID + "', '" + ddlDriverLicenseYear.ClientID + "')");
            DataBindHelper.BindCheckBoxList(ref chDriverLicenses, this.cmbDriverLicenceTypes, "DriverLicenseTypeName", "DriverLicenseTypeID");
        }
    }

    protected void Page_PreRender(object sender, EventArgs e)
    {
        //PIKCV.BUS.UserCVs objUserCV = new PIKCV.BUS.UserCVs();
        //DataTable dtUserCV = objUserCV.GetUserCV(this.smUserID);
        //if (dtUserCV.Rows.Count > 0)
        //{
        //    FillData(dtUserCV);
        //}
        PIKCV.BUS.UserCVs objUserDriverLicensees = new PIKCV.BUS.UserCVs();
        DataTable dtDriverLicenses = objUserDriverLicensees.GetUserDriverLicenses(this.smUserID, this.smLanguageID);
        if (dtDriverLicenses.Rows.Count > 0)
        {
            FillData(dtDriverLicenses);
        }
    }

    private void FillData(DataTable dt)
    {
        //ddlDriverLicenseTypes.SelectedValue = dt.Rows[0]["DriverLicenseTypeID"].ToString();
        //ddlDriverLicenseYear.SelectedValue = dt.Rows[0]["DriverLicenseYear"].ToString();
        //ImgBtnSave.Visible = (Convert.ToInt32(dt.Rows[0]["CvFocusCode"]) > (int)PIKCV.COM.EnumDB.CVFocusCode.References);
        //ImgBtnContinue.Visible = !(ImgBtnSave.Visible);
        ImgBtnSave.Visible = (Convert.ToInt32(dt.Rows[0]["CvFocusCode"]) > (int)PIKCV.COM.EnumDB.CVFocusCode.References);
        ImgBtnContinue.Visible = !(ImgBtnSave.Visible);

        for (int i = 0; i < chDriverLicenses.Items.Count; i++)
        {
            foreach (DataRow dr in dt.Rows)
            {
                if (Convert.ToInt32(dr["DriverLicenseTypeID"]) == int.Parse(chDriverLicenses.Items[i].Value))
                    chDriverLicenses.Items[i].Selected = true;
            }
        }
    }

    protected void ImgBtnContinue_Click(object sender, ImageClickEventArgs e)
    {
        //PIKCV.BUS.UserCVs objUserCV = new PIKCV.BUS.UserCVs();
        //if (objUserCV.SaveDriverLicence(this.smUserID, int.Parse(ddlDriverLicenseTypes.SelectedValue), int.Parse(ddlDriverLicenseYear.SelectedValue)))
        //{
        //    if (ImgBtnContinue.Visible == true)
        //    {
        //        this.smCVFocus = objUserCV.CVFocus(this.smUserID);
        //        this.Redirect("Employee-Membership-CV&CVFocus=" + ((int)PIKCV.COM.EnumDB.CVFocusCode.ForeignLanguages).ToString());
        //    }
        //    else { Response.Write("<script>alert('Özgeçmiþinizde yaptýðýnýz güncellemeler kaydedilmiþtir');</script>"); }
        //}
        //else
        //{
        //    Response.Write("<script>alert('! Bilgileriniz kaydedilemedi.')</script>");
        //}


        PIKCV.BUS.UserCVs objUserCV = new PIKCV.BUS.UserCVs();
        ArrayList arrDriverLicenses = new ArrayList();

        for (int i = 0; i < chDriverLicenses.Items.Count; i++)
        {
            if (chDriverLicenses.Items[i].Selected)
                arrDriverLicenses.Add(Convert.ToInt32(chDriverLicenses.Items[i].Value));
        }

        if (objUserCV.SaveUserDriverLicenses(this.smUserID, arrDriverLicenses))
        {
            if (ImgBtnContinue.Visible == true)
            {
                this.smCVFocus = objUserCV.CVFocus(this.smUserID);
                this.Redirect("Employee-Membership-CV&CVFocus=" + ((int)PIKCV.COM.EnumDB.CVFocusCode.ForeignLanguages).ToString());
            }
            ShowModal.Show(UserControls_Common_uModalPopup.Icons.alert, PIKCV.COM.EnumDB.ErrorTypes.UpdateCV);
        }
        else
        {
            ShowModal.Show(UserControls_Common_uModalPopup.Icons.alert, PIKCV.COM.EnumDB.ErrorTypes.NoUpdateCV);
        }
    }
}
