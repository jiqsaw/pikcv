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

public partial class UserControls_Employee_Membership_CV_uCharacteristicAndSocialLifeNav : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ReplaceNavigateURL(ref hlDriverLicence, PIKCV.COM.EnumDB.CVFocusCode.DriverLicense);
            ReplaceNavigateURL(ref hlForeignLanguages, PIKCV.COM.EnumDB.CVFocusCode.ForeignLanguages);
            ReplaceNavigateURL(ref hlInterests, PIKCV.COM.EnumDB.CVFocusCode.Interests);
            ReplaceNavigateURL(ref hlCourseAndCertificate, PIKCV.COM.EnumDB.CVFocusCode.CourseAndCertificate);
            ReplaceNavigateURL(ref hlComputerKnowledge, PIKCV.COM.EnumDB.CVFocusCode.ComputerKnowledge);
            ReplaceNavigateURL(ref hlClubs, PIKCV.COM.EnumDB.CVFocusCode.Clubs);
        }
    }

    private void ReplaceNavigateURL(ref HyperLink hl, PIKCV.COM.EnumDB.CVFocusCode CVFocusCode) {
        hl.NavigateUrl = hl.NavigateUrl.Replace("||FocusNo||", ((int)CVFocusCode).ToString());
    }

    public void SelectNavigatorLink(PIKCV.COM.EnumDB.CVFocusCode CVFocusCode)
    {
        switch (CVFocusCode)
        {
            case PIKCV.COM.EnumDB.CVFocusCode.DriverLicense:
                liDriverLicence.Attributes.Add("class", "selected");
                break;
            case PIKCV.COM.EnumDB.CVFocusCode.ForeignLanguages:
                liForeignLanguages.Attributes.Add("class", "selected");
                break;
            case PIKCV.COM.EnumDB.CVFocusCode.ComputerKnowledge:
                liComputerKnowledge.Attributes.Add("class", "selected");
                break;
            case PIKCV.COM.EnumDB.CVFocusCode.CourseAndCertificate:
                liCourseAndCertificate.Attributes.Add("class", "selected");
                break;
            case PIKCV.COM.EnumDB.CVFocusCode.Interests:
                liInterests.Attributes.Add("class", "selected");
                break;
            case PIKCV.COM.EnumDB.CVFocusCode.Clubs:
                liClubs.Attributes.Add("class", "selected");
                break;
        }
    }
}
