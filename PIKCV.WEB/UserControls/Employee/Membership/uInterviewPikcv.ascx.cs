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

public partial class UserControls_Employee_Membership_uInterviewPikcv : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if(CARETTA.COM.Util.IsNumeric(Request.QueryString["UserID"]))
                FillDetails(Convert.ToInt32(Request.QueryString["UserID"]));
        }
    }

    private void FillDetails(int UserID)
    {
        PIKCV.BUS.User obj = new PIKCV.BUS.User();
        DataTable dt = obj.GetUserInterviewPikcv(UserID);
        if (dt.Rows.Count > 0)
        {
            lbInterviewDate.Text = string.Format("{0:d}", dt.Rows[0]["InterviewDate"]);
            lbInterviewResult.Text = dt.Rows[0]["InterviewResult"].ToString();
            lbRequestedWage.Text = dt.Rows[0]["RequestedWage"].ToString();
            lbTakingWage.Text = dt.Rows[0]["TakingWage"].ToString();
            lbAveragePoints.Text = dt.Rows[0]["AveragePoints"].ToString();
            lbWorkLeaveReason.Text = dt.Rows[0]["WorkLeaveReason"].ToString();
            dt = obj.GetUserInterviewPikcvPropertiesPoints(Convert.ToInt32(dt.Rows[0]["InterviewPikcvID"]), (int)this.smLanguageID);
            CARETTA.COM.DataBindHelper.BindRepeater(ref rptIntervies, dt);
            pnlNoRecord.Visible = false;
            pnlRecord.Visible = true;
        }
        else
        {
            pnlNoRecord.Visible = true;
            pnlRecord.Visible = false;
        }
    }
}
