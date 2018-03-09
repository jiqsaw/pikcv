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

public partial class UserControls_Employee_Membership_uCV : BaseUserControl {
    protected void Page_Load (object sender, EventArgs e) {
        if (!IsPostBack)
        {
            hlPersonalInfo.NavigateUrl = hlPersonalInfo.NavigateUrl.Replace("||FocusNo||", ((int)PIKCV.COM.EnumDB.CVFocusCode.PersonalInfo).ToString());
            hlEducation.NavigateUrl = hlEducation.NavigateUrl.Replace("||FocusNo||", ((int)PIKCV.COM.EnumDB.CVFocusCode.Education).ToString());
            hlEmployment.NavigateUrl = hlEmployment.NavigateUrl.Replace("||FocusNo||", ((int)PIKCV.COM.EnumDB.CVFocusCode.Employment).ToString());
            hlSocial.NavigateUrl = hlSocial.NavigateUrl.Replace("||FocusNo||", ((int)PIKCV.COM.EnumDB.CVFocusCode.DriverLicense).ToString());
            hlPreferences.NavigateUrl = hlPreferences.NavigateUrl.Replace("||FocusNo||", ((int)PIKCV.COM.EnumDB.CVFocusCode.EmploymentChooices).ToString());
        }
        CtrlStep();
        UCVTabs1.TabActive(PIKCV.COM.Enumerations.CVTabs.CV);
    }

    void CtrlStep () {
        pnlNoEmailConfirmed.Visible = !this.smIsEmailConfirmed;
        if (this.smIsLogin) {
            PIKCV.COM.EnumDB.CVFocusCode CVFocus = this.smCVFocus;
            if (CVFocus != PIKCV.COM.EnumDB.CVFocusCode.PersonalInfo)
            {
                if (Util.IsString(Request.QueryString["CVFocus"]))
                {
                    CVFocus = (PIKCV.COM.EnumDB.CVFocusCode)(int.Parse(Request.QueryString["CVFocus"]));
                }
                else {
                    if ((int)CVFocus > (int)PIKCV.COM.EnumDB.CVFocusCode.References) {
                        CVFocus = PIKCV.COM.EnumDB.CVFocusCode.PersonalInfo;
                    }
                }
            }

            if ((int)CVFocus < (int)PIKCV.COM.EnumDB.CVFocusCode.Education) { li1.Attributes.Add("class", "selected"); }
            else if ((int)CVFocus < (int)PIKCV.COM.EnumDB.CVFocusCode.Employment) { li2.Attributes.Add("class", "selected"); }
            else if ((int)CVFocus < (int)PIKCV.COM.EnumDB.CVFocusCode.DriverLicense) { li3.Attributes.Add("class", "selected"); }
            else if ((int)CVFocus < (int)PIKCV.COM.EnumDB.CVFocusCode.EmploymentChooices) { li4.Attributes.Add("class", "selected"); }
            else { li5.Attributes.Add("class", "selected"); }

            string ControlPath = "~/UserControls/Employee/MemberShip/CV/u" + CVFocus.ToString() + ".ascx";
            try {
                Control objControl = new Control();
                objControl = LoadControl(ControlPath);
                PHCVFocus.Controls.Clear();
                PHCVFocus.Controls.Add(objControl);
            }
            catch (Exception) { this.GoToDefaultPage(); }
            
        }

        PIKCV.BUS.UserCVs objUserCV = new PIKCV.BUS.UserCVs();
        PIKCV.COM.EnumDB.CVFocusCode DBCvFocus = objUserCV.CVFocus(this.smUserID);

        if ((int)DBCvFocus > (int)PIKCV.COM.EnumDB.CVFocusCode.References)
        {
            lblCVHeader.Text = "Özgeçmiþ Güncelleme";
        }
        else
        {
            lblCVHeader.Text = "Özgeçmiþ Bilgileri";
        }

        hlEducation.Enabled = ((int)DBCvFocus > (int)PIKCV.COM.EnumDB.CVFocusCode.ContactInfo);
        hlEmployment.Enabled = ((int)DBCvFocus > (int)PIKCV.COM.EnumDB.CVFocusCode.EducationDoktorate);
        hlSocial.Enabled = ((int)DBCvFocus > (int)PIKCV.COM.EnumDB.CVFocusCode.Employment);
        hlPreferences.Enabled = ((int)DBCvFocus > (int)PIKCV.COM.EnumDB.CVFocusCode.Clubs);
    }
}
