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
using PIKCV.BUS;

public partial class UserControls_Common_uMyMenu : BaseUserControl
{
    protected void Page_Init(object sender, EventArgs e)
    {
        if (this.smIsLogin)
        {
            pnlMyMenu.Visible = (this.cookPageType == PIKCV.COM.Enumerations.PageType.Employee);
            pnlCompanyMenu.Visible = (this.cookPageType == PIKCV.COM.Enumerations.PageType.Company);
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillMessageCount();
            FillJobApplicantsCount();
            CheckIfTestIsDone();
        }
    }

    private void FillMessageCount()
    {
        DataTable dt = Messages.GetUserMessageCount(smUserID, (int)PIKCV.COM.EnumDB.MemberTypes.Employee, false);
        if (dt.Rows.Count > 0) {
            LnkMessages.Text += "&nbsp;(" + dt.Rows[0]["MessageCount"].ToString() + ")";
        }
    }

    private void FillJobApplicantsCount()
    {
        DataTable dt = JobApplicants.GetUserApplicantCount(this.smUserID);
        if (dt.Rows.Count > 0)
        {
            LnkJobApplicants.Text += "&nbsp;(" + dt.Rows[0]["ApplicantCount"].ToString() + ")";
        } 
    }

    private void CheckIfTestIsDone()
    {
        PIKCV.BUS.UserCVs objUserCV = new PIKCV.BUS.UserCVs();
        DataTable dtUserCV = objUserCV.GetUserCV(this.smUserID);
        if (dtUserCV.Rows.Count > 0)
        {
            if (Convert.ToInt32(dtUserCV.Rows[0]["CvFocusCode"]) > (int)PIKCV.COM.EnumDB.CVFocusCode.References)
            {
                if (this.smEmployeeType == PIKCV.COM.EnumDB.EmployeeTypes.Pikpool)
                {
                    if (PIKCV.BUS.Test.UserTestCtrl(this.smUserID))
                    {
                        aTestResults.HRef = "#" + this.smMemberType.ToString() + "-Membership-Tests";
                        ltlTestResults.Text = "Testler";
                    }
                }
                else if (this.smEmployeeType == PIKCV.COM.EnumDB.EmployeeTypes.Goodpik)
                {
                    if (PIKCV.BUS.Test.UserTestCtrl(this.smUserID) && PIKCV.BUS.Test.UserTestPerfectionCtrl(this.smUserID))
                    {
                        aTestResults.HRef = "#" + this.smMemberType.ToString() + "-Membership-Tests";
                        ltlTestResults.Text = "Testler";
                    }
                }
            }
            else
            {
                aTestResults.HRef = "#" + this.smMemberType.ToString() + "-Membership-UserInfo";
            }
        }
        else { aTestResults.HRef = "#" + this.smMemberType.ToString() + "-Membership-UserInfo"; }
    }

    protected void lnbJobEntry_Click(object sender, EventArgs e)
    {
        this.smJobID = 0;
        this.smJobFocus = PIKCV.COM.EnumDB.JobsFocusCode.JobType;
        this.smJobSaveType = PIKCV.COM.Enumerations.JobSaveType.NewJobEntry;
        this.Redirect("Company-Jobs-Jobs");
    }

    protected void LnkJobApplicants_Click(object sender, EventArgs e)
    {
        this.smListFilterTypes = new ArrayList();
        this.Redirect("Employee-JobApplicants-JobApplicants");
    }

    protected void LnkMessages_Click(object sender, EventArgs e)
    {
        this.smListFilterTypes = new ArrayList();
        this.Redirect("Employee-Messages-Messages");
    }

    protected void LnkCompanyMessages_Click(object sender, EventArgs e)
    {
        this.smListFilterTypes = new ArrayList();
        this.Redirect("Company-Messages-Messages");
    }

    protected void LnkLogonPage_Click(object sender, EventArgs e)
    {
        this.GoToLogonPage();
    }

    protected void lnbJobs_Click(object sender, EventArgs e)
    {
        this.Redirect("Company-Jobs-PublicJobs&JobStatus=" + ((int)PIKCV.COM.EnumDB.JobStatus.Active).ToString());
    }

    protected void LnkLogonPageCompany_Click(object sender, EventArgs e)
    {
        this.GoToLogonPage();
    }

    protected void lnbJobApplicants_Click(object sender, EventArgs e)
    {
        DataTable dt = PIKCV.BUS.Job.GetCompanyAllJobs(this.smCompanyID, PIKCV.COM.EnumDB.JobStatus.All, this.smLanguageID);
        if (dt.Rows.Count > 0)
        {
            this.Redirect("Company-Jobs-JobApplicants&JobID=" + Convert.ToInt32(dt.Rows[0]["JobID"]));
        }
        else
        {
            this.GoToFeedback(PIKCV.COM.EnumDB.ErrorTypes.NoJob);
        }
    }
    
}
