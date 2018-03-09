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

public partial class UserControls_Employee_Membership_CV_uEducationNav : BaseUserControl
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            PIKCV.COM.EnumDB.EducationTypes UserEducationType = PIKCV.BUS.UserCVs.GetEducationType(this.smUserID);

            hlDoktorate.NavigateUrl = hlDoktorate.NavigateUrl.Replace("||FocusNo||", ((int)PIKCV.COM.EnumDB.CVFocusCode.EducationDoktorate).ToString());
            hlUniversity2.NavigateUrl = hlUniversity2.NavigateUrl.Replace("||FocusNo||", ((int)PIKCV.COM.EnumDB.CVFocusCode.EducationUniversity2).ToString());
            hlUniversity1.NavigateUrl = hlUniversity1.NavigateUrl.Replace("||FocusNo||", ((int)PIKCV.COM.EnumDB.CVFocusCode.EducationUniversity1).ToString());
            hlUniversity0.NavigateUrl = hlUniversity0.NavigateUrl.Replace("||FocusNo||", ((int)PIKCV.COM.EnumDB.CVFocusCode.EducationUniversity0).ToString());
            hlHighSchool.NavigateUrl = hlHighSchool.NavigateUrl.Replace("||FocusNo||", ((int)PIKCV.COM.EnumDB.CVFocusCode.EducationHighSchool).ToString());
            hlMiddleSchool.NavigateUrl = hlMiddleSchool.NavigateUrl.Replace("||FocusNo||", ((int)PIKCV.COM.EnumDB.CVFocusCode.EducationMiddleSchool).ToString());

            ShowEducationTypes(UserEducationType);

        }
    }

    public void ShowEducationTypes(PIKCV.COM.EnumDB.EducationTypes EducationType) { 
        liDoktorate.Visible = ((int)EducationType >= (int)PIKCV.COM.EnumDB.EducationTypes.Doktorate);
        liUniversity2.Visible = ((int)EducationType >= (int)PIKCV.COM.EnumDB.EducationTypes.University2);
        liUniversity1.Visible = ((int)EducationType >= (int)PIKCV.COM.EnumDB.EducationTypes.University1);
        liUniversity0.Visible = ((int)EducationType >= (int)PIKCV.COM.EnumDB.EducationTypes.University0);
        liHighSchool.Visible = ((int)EducationType >= (int)PIKCV.COM.EnumDB.EducationTypes.HighSchool);
        liMiddleSchool.Visible = ((int)EducationType <= (int)PIKCV.COM.EnumDB.EducationTypes.HighSchool);
    }

    public void SelectEducationTypes(PIKCV.COM.EnumDB.EducationTypes EducationType)
    {
        switch (EducationType)
        {
            case PIKCV.COM.EnumDB.EducationTypes.Doktorate:
                liDoktorate.Attributes.Add("class", "selected");
                break;
            case PIKCV.COM.EnumDB.EducationTypes.HighSchool:
                liHighSchool.Attributes.Add("class", "selected");
                break;
            case PIKCV.COM.EnumDB.EducationTypes.MiddleSchool:
                liMiddleSchool.Attributes.Add("class", "selected");
                break;
            case PIKCV.COM.EnumDB.EducationTypes.University0:
                liUniversity0.Attributes.Add("class", "selected");
                break;
            case PIKCV.COM.EnumDB.EducationTypes.University1:
                liUniversity1.Attributes.Add("class", "selected");
                break;
            case PIKCV.COM.EnumDB.EducationTypes.University2:
                liUniversity2.Attributes.Add("class", "selected");
                break;
        }
    }

}
