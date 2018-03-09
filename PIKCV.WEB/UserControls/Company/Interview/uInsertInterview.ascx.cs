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

public partial class UserControls_Company_Interview_uInsertInterview : BaseUserControl
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (this.smInterviewUserIDs.Count > 0)
            {
                FillDetails();
            }
            else
            {
                Response.Write("<script> { window.close();}</script>");
            }
        }
    }

    private void FillDetails()
    {
        DataBindHelper.LoadNumberDDL(ref drpEndHour, 23, 1, 0);
        DataBindHelper.LoadNumberDDL(ref drpStartHour, 23, 1, 0);
        DataBindHelper.LoadNumberDDL(ref drpEndMinute, 55, 5, 0);
        DataBindHelper.LoadNumberDDL(ref drpStartMinute, 55, 5, 0);
        PIKCV.BUS.Company obj = new PIKCV.BUS.Company();
        DataBindHelper.BindDDL(ref drpAdvisor, obj.GetCompanyAdvisor(this.smCompanyID), "FirstName", "CompanyAdvisorID", "", "Lütfen Seçiniz...", "0");
        DataBindHelper.BindDDL(ref drpPosition, this.cmbPositions, "PositionName", "PositionID", "", "Lütfen Seçiniz...", "0");

        if ((Session[PIKCV.COM.EnumUtil.Sess.EmployeeSearchQueries.ToString()] != null) && (this.smEmployeeSearchQueries.JobID > 0)) {
            drpPosition.SelectedValue = PIKCV.BUS.Job.GetJobDetail(this.smEmployeeSearchQueries.JobID).Rows[0]["PositionID"].ToString();
        }
    }
    protected void drpAdvisor_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (drpAdvisor.SelectedValue != "0")
        {
            errAdvisorTextBox.Enabled = false;
        }
        else { errAdvisorTextBox.Enabled = true; }
    }
    protected void btnSubmit_Click(object sender, ImageClickEventArgs e)
    {
        int AdvisorID = 0;
        string AdvisorName = "";
        if (drpAdvisor.SelectedValue == "0")
        {
            PIKCV.BUS.Company objCompany = new PIKCV.BUS.Company();
            AdvisorID = objCompany.InsertCompanyAdvisor(this.smCompanyID, txtAdvisor.Text, txtAdvisor.Text);
            AdvisorName = txtAdvisor.Text;
        }
        else
        {
            AdvisorID = int.Parse(drpAdvisor.SelectedValue);
            AdvisorName = drpAdvisor.SelectedItem.Text;
        }
        DateTime InterviewDate = UDate1.Date;
        DateTime InterviewStartTime = new DateTime(InterviewDate.Year, InterviewDate.Month, InterviewDate.Day, int.Parse(drpStartHour.SelectedValue), int.Parse(drpStartMinute.SelectedValue), 0);
        DateTime InterviewEndTime = new DateTime(InterviewDate.Year, InterviewDate.Month, InterviewDate.Day, int.Parse(drpEndHour.SelectedValue), int.Parse(drpEndMinute.SelectedValue), 0);
        PIKCV.BUS.Interview objInterview = new PIKCV.BUS.Interview();
        if (objInterview.InsertInterview(this.smCompanyID, AdvisorID, UDate1.Date, InterviewEndTime, PIKCV.COM.EnumDB.MemberTypes.Company,
            txtInterviewPlace.Text, InterviewStartTime, int.Parse(drpPosition.SelectedValue), this.smCompanyID, this.smInterviewUserIDs, AdvisorName))
        {
            Response.Write("<script language='javascript'> { alert('Seçtiðiniz kullanýcýlar mülakata çaðýrýldý');window.close();}</script>");
            this.smInterviewUserIDs = null;
        }
        else
        {
            Response.Write("<script language='javascript'> { alert('Seçtiðiniz kullanýcýlar mülakata çaðýrýlýrken bir hata oluþtu. Lütfen tekrar deneyin');window.close();}</script>");
        }
    }
}
