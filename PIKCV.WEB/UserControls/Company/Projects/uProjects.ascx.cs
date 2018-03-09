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

public partial class UserControls_Company_Projects_uProjects : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (!(this.smIsLogin))
                this.GoToDefaultPage();
            DataBindHelper.BindDDL(ref ddlProjects, PIKCV.BUS.Projects.GetCompanyProjects(this.smCompanyID, false), "ProjectName", "CustomProjectID", "");
            FillData(); 
        }
        
    }

    private void FillData()
    {
        if (ddlProjects.Items.Count > 0)
        {
            DataTable dt = PIKCV.BUS.Projects.GetCompanyProjectDetail(Convert.ToInt32(ddlProjects.SelectedValue), this.smLanguageID, false);

            if (dt.Rows.Count > 0)
            {
                dt.Columns.Add("Percentage");
                dt.Columns.Add("EmployeeType");
                int TotalWantedEmployeeCount = 0;
                int TotalFoundEmployeeCount = 0;

                foreach (DataRow dr in dt.Rows)
                {
                    TotalWantedEmployeeCount = TotalWantedEmployeeCount + Convert.ToInt32(dr["WantedEmployeeCount"]);
                    TotalFoundEmployeeCount = TotalFoundEmployeeCount + Convert.ToInt32(dr["FoundEmployeeCount"]);
                    if (((PIKCV.COM.EnumDB.EmployeeTypes)(Convert.ToInt32(dr["PositionTypeCode"]))) == PIKCV.COM.EnumDB.EmployeeTypes.Goodpik)
                    {
                        dr["EmployeeType"] = "Yönetici";
                    }
                    else
                    {
                        dr["EmployeeType"] = "Eleman / Uzman";
                    }
                }
                DataBindHelper.BindRepeater(ref rptProejects, dt);
                lbProjectDate.Text = Convert.ToDateTime(dt.Rows[0]["CreateDate"]).ToShortDateString();
                lbProjectName.Text = dt.Rows[0]["ProjectName"].ToString();
                lbProjectPrice.Text = dt.Rows[0]["Price"].ToString();
                lbTotalFoundEmployeeCount.Text = TotalFoundEmployeeCount.ToString();
                int TotalPercentage = TotalFoundEmployeeCount * 100 / TotalWantedEmployeeCount;
                lbTotalPercentage.Text = TotalPercentage.ToString();
                ChartBarTotal.Style["width"] = TotalPercentage.ToString() + "px";
                int TotalRemainingEmployeeCount = TotalWantedEmployeeCount - TotalFoundEmployeeCount;
                lbTotalRemainingEmployeeCount.Text = TotalRemainingEmployeeCount.ToString();
                lbTotalWantedEmployee.Text = TotalWantedEmployeeCount.ToString();
                pnlProjects.Visible = true;
                lbMessage.Visible = false;
                ddlProjects.Visible = true;
            }
        }
        else
        {
            pnlProjects.Visible = false;
            lbMessage.Visible = true;
            ddlProjects.Visible = false;
        }
    }
    protected void ddlProjects_SelectedIndexChanged(object sender, EventArgs e)
    {
        FillData();
    }
}
