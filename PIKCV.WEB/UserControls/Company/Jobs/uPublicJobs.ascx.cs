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
using PIKCV.BUS;

public partial class UserControls_Company_Jobs_uPublicJobs : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Util.IsNumeric(Request.QueryString["JobStatus"]))
            {
                int Status = Convert.ToInt32(Request.QueryString["JobStatus"]);
                PIKCV.COM.Enumerations.JobsTabs jobStatus = (PIKCV.COM.Enumerations.JobsTabs)Status;
                UJobsTabs1.TabActive(jobStatus);
                UpdateJobStatus(jobStatus);
            }

            UList1.DataBind(PIKCV.COM.Enumerations.ListTypes.EnteredJobs);
        }
    }

    private void UpdateJobStatus(PIKCV.COM.Enumerations.JobsTabs JobStatus)
    {
        switch (JobStatus)
        {
            case PIKCV.COM.Enumerations.JobsTabs.PublicJobs:
                if (CARETTA.COM.Util.IsNumeric(Request.QueryString["JobID"]))
                {
                    int JobID = Convert.ToInt32(Request.QueryString["JobID"]);
                    PIKCV.BUS.Job obj = new PIKCV.BUS.Job();
                    DataTable dt = obj.GetJobInfo(JobID);
                    if (dt.Rows.Count > 0)
                    {
                        if (Convert.ToInt32(dt.Rows[0]["CompanyID"]) == this.smCompanyID)
                        {
                            int Credits = 0;
                            DataRow drOrderType = PIKCV.BUS.Orders.GetOrderTypesDetails(Convert.ToInt32(dt.Rows[0]["JobListType"]));
                            if (drOrderType != null)
                            {
                                PIKCV.COM.EnumDB.EmployeeTypes EmployeeType = (PIKCV.COM.EnumDB.EmployeeTypes)(Convert.ToInt32(dt.Rows[0]["UserTypeID"]));
                                switch (EmployeeType)
                                {
                                    case PIKCV.COM.EnumDB.EmployeeTypes.Pikpool:
                                        CompanyCreditControl(Convert.ToInt32(drOrderType["PikPoolCredit"]));
                                        Credits = Convert.ToInt32(drOrderType["PikPoolCredit"]);
                                        break;
                                    case PIKCV.COM.EnumDB.EmployeeTypes.Goodpik:
                                        CompanyCreditControl(Convert.ToInt32(drOrderType["GoodPikCredit"]));
                                        Credits = Convert.ToInt32(drOrderType["PikPoolCredit"]);
                                        break;
                                }
                            }
                            DateTime JobEndDate = Convert.ToDateTime(dt.Rows[0]["EndDate"]);
                            PIKCV.COM.EnumDB.JobStatus CurrentJobStatus = (PIKCV.COM.EnumDB.JobStatus)(Convert.ToInt32(dt.Rows[0]["JobStatus"]));
                            if (obj.ChangeJobStatus(this.smCompanyID, JobID, PIKCV.COM.EnumDB.JobStatus.Active, Credits, Convert.ToInt32(dt.Rows[0]["JobListType"]), JobEndDate, CurrentJobStatus) > 0)
                            {
                                if ((CurrentJobStatus == PIKCV.COM.EnumDB.JobStatus.Draft) || (JobEndDate < DateTime.Now))
                                {
                                    Credits = int.Parse(this.smPikCredi) - Credits;
                                    this.smPikCredi = Credits.ToString();
                                }
                                dvScript.InnerHtml = "<script>alert('Ýlanýnýz  þu andan itibaren yayýndadýr, yayýndaki ilanlar bölümünden takip edebilirsiniz')</script>";
                                
                            }
                            else
                            {
                                dvScript.InnerHtml = "<script>alert('Ýlanýnýz yayýna konulurken bir hata oluþtu')</script>";
                            }
                        }
                    }
                }
                break;
            case PIKCV.COM.Enumerations.JobsTabs.JobArchive:
                if (CARETTA.COM.Util.IsNumeric(Request.QueryString["JobID"]))
                {
                    int JobID = Convert.ToInt32(Request.QueryString["JobID"]);
                    PIKCV.BUS.Job obj = new PIKCV.BUS.Job();
                    DataTable dt = obj.GetJobInfo(JobID);
                    if (dt.Rows.Count > 0)
                    {
                        if (Convert.ToInt32(dt.Rows[0]["CompanyID"]) == this.smCompanyID)
                            obj.ChangeJobStatus(JobID, PIKCV.COM.EnumDB.JobStatus.Archive);
                    }
                }
                break;
            case PIKCV.COM.Enumerations.JobsTabs.Draft:
                if (CARETTA.COM.Util.IsNumeric(Request.QueryString["JobID"]))
                {
                    int JobID = Convert.ToInt32(Request.QueryString["JobID"]);
                    PIKCV.BUS.Job obj = new PIKCV.BUS.Job();
                    DataTable dt = obj.GetJobInfo(JobID);
                    if (dt.Rows.Count > 0)
                    {
                        if (Convert.ToInt32(dt.Rows[0]["CompanyID"]) == this.smCompanyID)
                            if (obj.ChangeJobStatus(JobID, PIKCV.COM.EnumDB.JobStatus.Deleted) > 0)
                            { dvScript.InnerHtml = "<script>alert('Ýlanýnýz  silinmiþtir.')</script>"; }
                            else { dvScript.InnerHtml = "<script>alert('Ýlanýnýz  silinirken bir hata oluþtu!')</script>"; }
                    }
                }
                break;
        }
    }

    private void CompanyCreditControl(int Credits)
    {
        Company obj = new Company();
        DataTable dt = obj.GetCompanyInfo(this.smCompanyID);
        if (dt.Rows.Count > 0)
        {
            if (Convert.ToInt32(dt.Rows[0]["Credits"]) < Credits)
            {
                this.Redirect("Company-Jobs-Jobs-NoCredit");
            }
        }
        else { this.Redirect("Company-CompanyLogon"); }
    }
}