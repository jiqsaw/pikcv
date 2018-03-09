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

public partial class UserControls_Employee_Common_uCVTabs : BaseUserControl
{
    private bool IsNotice;
    protected void Page_PreRender(object sender, EventArgs e)
    {
        if (!IsNotice)
        {
            PIKCV.BUS.UserCVs objUserCV = new PIKCV.BUS.UserCVs();
            PIKCV.COM.EnumDB.CVFocusCode m_CVFocusCode = objUserCV.CVFocus(this.smUserID);
            liCVOutput.Visible = ((this.smIsLogin) && ((int)(m_CVFocusCode) > (int)PIKCV.COM.EnumDB.CVFocusCode.References));
            liPhoto.Visible = ((!this.smIsCvConfirmed) && (((int)(m_CVFocusCode) > (int)PIKCV.COM.EnumDB.CVFocusCode.ContactInfo) && (this.smMemberType != PIKCV.COM.EnumDB.MemberTypes.Company && this.smMemberType != PIKCV.COM.EnumDB.MemberTypes.TemporaryUser)));
            liPikInterview.Visible = ((this.smMemberType == PIKCV.COM.EnumDB.MemberTypes.Company || this.smMemberType == PIKCV.COM.EnumDB.MemberTypes.TemporaryUser) && (this.smEmployeeType == PIKCV.COM.EnumDB.EmployeeTypes.Goodpik));

            liCV.Visible = (this.smMemberType == PIKCV.COM.EnumDB.MemberTypes.Employee);


            liTest.Visible = ((this.smMemberType == PIKCV.COM.EnumDB.MemberTypes.Employee) && (liCVOutput.Visible) && (PIKCV.BUS.Test.UserTestCtrl(this.smUserID)));

            liTest.Visible = ((!(!PIKCV.BUS.Test.UserTestCtrl(this.smUserID) && !PIKCV.BUS.Test.UserTestPerfectionCtrl(this.smUserID))) && (this.smMemberType == PIKCV.COM.EnumDB.MemberTypes.Employee));

            if ((this.smMemberType == PIKCV.COM.EnumDB.MemberTypes.Employee) && (this.smEmployeeType == PIKCV.COM.EnumDB.EmployeeTypes.Unknown || this.smEmployeeType == PIKCV.COM.EnumDB.EmployeeTypes.Both))
            {
                liTest.Visible = false;
            }

            if (this.smEmployeeType == PIKCV.COM.EnumDB.EmployeeTypes.Pikpool)
            {
                liTest.Visible = PIKCV.BUS.Test.UserTestCtrl(this.smUserID);
            }

            liTestResults.Visible = false;
            if (!PIKCV.BUS.Test.UserTestCtrl(this.smUserID)) { liTestResults.Visible = true; };
            if (!PIKCV.BUS.Test.UserTestPerfectionCtrl(this.smUserID)) { liTestResults.Visible = true; };

            dvScript.InnerHtml = "<script>TabLinkEsrReplace(" + (Session[PIKCV.COM.EnumUtil.Sess.EmployeeSearchQueries.ToString()] == null).ToString().ToLower() + ", " + (this.smMemberType == PIKCV.COM.EnumDB.MemberTypes.Company).ToString().ToLower() + ", " + (this.smMemberType == PIKCV.COM.EnumDB.MemberTypes.TemporaryUser).ToString().ToLower() + ")</script>";
        }
    }

    public void AllTabsHide() {
        liUserInfo.Visible = false;
        liCV.Visible = false;
        liPhoto.Visible = false;
        liCVOutput.Visible = false;
        liPikInterview.Visible = false;
        liTest.Visible = false;
        liTestResults.Visible = false;
        this.IsNotice = true;
    }

    public void TabActive(PIKCV.COM.Enumerations.CVTabs CVTab) {
        switch (CVTab)
        {
            case PIKCV.COM.Enumerations.CVTabs.UserInfo:
                liUserInfo.Attributes.Add("class", "TabActive");
                break;
            case PIKCV.COM.Enumerations.CVTabs.CV:
                liCV.Attributes.Add("class", "TabActive");
                break;
            case PIKCV.COM.Enumerations.CVTabs.Photo:
                liPhoto.Attributes.Add("class", "TabActive");
                break;
            case PIKCV.COM.Enumerations.CVTabs.CVOutput:
                liCVOutput.Attributes.Add("class", "TabActive");
                break;
            case PIKCV.COM.Enumerations.CVTabs.Test:
                liTest.Attributes.Add("class", "TabActive");
                break;
            case PIKCV.COM.Enumerations.CVTabs.PikInterview:
                liPikInterview.Attributes.Add("class", "TabActive");
                break;
            case PIKCV.COM.Enumerations.CVTabs.TestResults:
                liTestResults.Attributes.Add("class", "TabActive");
                break;
        }
    }
}
