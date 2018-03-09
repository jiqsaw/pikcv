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

public partial class UserControls_Employee_Membership_CV_uClubs : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            PIKCV.BUS.UserCVs objUserCV = new PIKCV.BUS.UserCVs();
            DataTable dtUserCV = objUserCV.GetUserCV(this.smUserID);
            if (dtUserCV.Rows.Count > 0)
            {
                txtClubs.Text = dtUserCV.Rows[0]["Clubs"].ToString();
                ImgBtnSave.Visible = (Convert.ToInt32(dtUserCV.Rows[0]["CvFocusCode"]) > (int)PIKCV.COM.EnumDB.CVFocusCode.References);
                ImgBtnContinue.Visible = !(ImgBtnSave.Visible);
            }
            UCharacteristicAndSocialLifeNav1.SelectNavigatorLink(PIKCV.COM.EnumDB.CVFocusCode.Clubs);
        }
    }

    protected void ImgBtnContinue_Click(object sender, ImageClickEventArgs e)
    {
        PIKCV.BUS.UserCVs objUserCV = new PIKCV.BUS.UserCVs();
        if (objUserCV.SaveClubs(this.smUserID, txtClubs.Text))
        {
            if (ImgBtnContinue.Visible == true)
            {
                this.smCVFocus = objUserCV.CVFocus(this.smUserID);
                this.Redirect("Employee-Membership-CV&CVFocus=" + ((int)PIKCV.COM.EnumDB.CVFocusCode.EmploymentChooices).ToString());
            }
            ShowModal.Show(UserControls_Common_uModalPopup.Icons.alert, PIKCV.COM.EnumDB.ErrorTypes.UpdateCV);
        }
        else
        {
            ShowModal.Show(UserControls_Common_uModalPopup.Icons.alert, PIKCV.COM.EnumDB.ErrorTypes.NoUpdateCV);
        }
    }
}
