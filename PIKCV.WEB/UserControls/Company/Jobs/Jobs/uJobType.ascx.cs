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

public partial class UserControls_Company_Jobs_Jobs_uJobType : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //if (CARETTA.COM.Util.IsNumeric(Request.QueryString["JobID"]))
            //{
            //    this.smJobID = int.Parse(Request.QueryString["JobID"]);
            //}

            FillData();
            FillDetails();
            if (this.smJobSaveType == PIKCV.COM.Enumerations.JobSaveType.NewJobEntry)
            { btnSubmit.Visible = true; }
            else { btnSave.Visible = true; }
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

    private void FillData()
    {

        rblJobListType.Items[0].Value = ((int)PIKCV.COM.EnumDB.JobListTypes.Main1).ToString();
        rblJobListType.Items[1].Value = ((int)PIKCV.COM.EnumDB.JobListTypes.Main2).ToString();
        rblJobListType.Items[2].Value = ((int)PIKCV.COM.EnumDB.JobListTypes.Standart).ToString();
        rblEmployeeTypes.Items[0].Value = ((int)PIKCV.COM.EnumDB.EmployeeTypes.Goodpik).ToString();
        rblEmployeeTypes.Items[1].Value = ((int)PIKCV.COM.EnumDB.EmployeeTypes.Pikpool).ToString();
    }

    private void FillDetails()
    {
        Job obj = new Job();
        DataTable dt = obj.GetJobInfo(this.smJobID);
        if (dt.Rows.Count > 0)
        {
            rblJobListType.SelectedValue = dt.Rows[0]["JobListType"].ToString();
            rblEmployeeTypes.SelectedValue = dt.Rows[0]["LabouringTypeID"].ToString();
            chkDisabled.Checked = Convert.ToBoolean(dt.Rows[0]["IsDisabled"]);
            chkMartyrRelative.Checked = Convert.ToBoolean(dt.Rows[0]["IsMartyrRelative"]);
            chkOldConvicted.Checked = Convert.ToBoolean(dt.Rows[0]["IsOldConvicted"]);
            chkTerrorWronged.Checked = Convert.ToBoolean(dt.Rows[0]["IsTerrorWronged"]);
        }
    }

    protected void btnSubmit_Click(object sender, ImageClickEventArgs e)
    {
        DataRow drOrderType = PIKCV.BUS.Orders.GetOrderTypesDetails(Convert.ToInt32(rblJobListType.SelectedValue));
        if (drOrderType != null)
        {
            PIKCV.COM.EnumDB.EmployeeTypes JobListType = (PIKCV.COM.EnumDB.EmployeeTypes)(Convert.ToInt32(rblEmployeeTypes.SelectedValue));
            switch (JobListType)
            {
                case PIKCV.COM.EnumDB.EmployeeTypes.Pikpool:
                    CompanyCreditControl(Convert.ToInt32(drOrderType["PikPoolCredit"]));
                    break;
                case PIKCV.COM.EnumDB.EmployeeTypes.Goodpik:
                    CompanyCreditControl(Convert.ToInt32(drOrderType["GoodPikCredit"]));
                    break;
            }
        }
        Job objJob = new Job();
        int SavedJob = objJob.SaveJobType(this.smJobID, this.smCompanyID, rblJobListType.SelectedValue, rblEmployeeTypes.SelectedValue,
            chkMartyrRelative.Checked, chkDisabled.Checked, chkOldConvicted.Checked, chkTerrorWronged.Checked);
        if (SavedJob != 0)
        {
            pnlError.Visible = false;
            if (this.smJobSaveType == PIKCV.COM.Enumerations.JobSaveType.NewJobEntry)
            {
                this.smJobID = SavedJob;
                this.smJobFocus = PIKCV.COM.EnumDB.JobsFocusCode.PositionDefinition;
                this.Redirect("Company-Jobs-Jobs&JobFocus=" + ((int)PIKCV.COM.EnumDB.JobsFocusCode.PositionDefinition).ToString());
            }
            else
            {
                Response.Write("<script>alert('Yapmýþ olduðunuz deðiþiklikler kaydedilmiþtir');window.location.href('pikcv.aspx?pik=Company-Jobs-Jobs&JobFocus=" + ((int)PIKCV.COM.EnumDB.JobsFocusCode.JobType).ToString() + "');</script>");
            }
        }
        else
        {
            pnlError.Visible = true;
            ltlError.Text = "Kayýt sýrasýnda bir hata oluþtu lütfen tekrar deneyin";
        }
    }
}
