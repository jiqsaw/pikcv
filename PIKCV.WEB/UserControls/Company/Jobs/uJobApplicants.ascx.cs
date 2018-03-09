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

public partial class UserControls_Company_Jobs_uJobApplicants : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.IsLogin();
        if (!IsPostBack)
        {
            if (CARETTA.COM.Util.IsNumeric(Request.QueryString["UserID"]) && CARETTA.COM.Util.IsNumeric(Request.QueryString["JobApplicantID"]))
            {
                this.smUserID = Convert.ToInt32(Request.QueryString["UserID"]);
                this.smEmployeeSearchResultUserIDs = new ArrayList();
                this.smEmployeeSearchResultUserIDs.Add(this.smUserID);
                Session.Remove(PIKCV.COM.EnumUtil.Sess.EmployeeSearchQueries.ToString());
                this.Redirect("Company-Membership-UserInfo&JobApplicantID=" + Request.QueryString["JobApplicantID"].ToString());
            }

            if (!(CARETTA.COM.Util.IsNumeric(Request.QueryString["[JobApplicationStatusName]"])))
                this.smListFilterTypes = new ArrayList();
            UList1.DataBind(PIKCV.COM.Enumerations.ListTypes.CompanyJobApplicants);
            DataTable dtJobs = PIKCV.BUS.Job.GetCompanyAllJobs(this.smCompanyID, PIKCV.COM.EnumDB.JobStatus.All, this.smLanguageID);
            if (dtJobs.Rows.Count > 0)
                if (this.smCompanyID != Convert.ToInt32(dtJobs.Rows[0]["CompanyID"]))
                    this.GoToDefaultPage();

            DataBindHelper.BindDDL(ref ddlCompanyJobs, dtJobs, "PositionName", "JobID", "", "Lütfen Seçiniz...", "0");
            if (CARETTA.COM.Util.IsNumeric(Request.QueryString["JobID"]))
                ddlCompanyJobs.SelectedValue = Request.QueryString["JobID"].ToString();
        }
    }
    protected void ddlCompanyJobs_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlCompanyJobs.SelectedValue != "0")
            this.Redirect("Company-Jobs-JobApplicants&JobID=" + ddlCompanyJobs.SelectedValue);
    }
}
