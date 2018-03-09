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

public partial class UserControls_Company_Search_uEmployeeList : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.IsLogin();
        FillJobApplicants();    
    }

    private void FillJobApplicants()
    {
        string strJobApplicants = CARETTA.COM.XMLHelper.BuildXmlString("Jobs", "JobID", this.smCompanyJobs);
        DataTable dt = new DataTable();
        dt = PIKCV.BUS.JobApplicants.GetJobApplicantsSorted(strJobApplicants);
        CARETTA.COM.DataBindHelper.BindRepeater(ref rptAds, dt);
        int i = 0;
        foreach (RepeaterItem ritem in rptAds.Items)
        {
            ((LinkButton)ritem.Controls[1]).Text = " " + dt.Rows[i]["FirstName"].ToString() + " " + dt.Rows[i]["LastName"].ToString();
            ((Literal)ritem.Controls[3]).Text = " " + dt.Rows[i]["UserID"].ToString();
            i++;
        }
    }
    protected void rptAds_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "Select")
        {
            smUserID = Convert.ToInt32(((Literal)rptAds.Items[e.Item.ItemIndex].Controls[3]).Text);
        }
        ArrayList arrUsers = new ArrayList();
        foreach (RepeaterItem ritem in rptAds.Items)
        {
            arrUsers.Add(((Literal)ritem.Controls[3]).Text);
        }
        smEmployeeSearchResultUserIDs = arrUsers;
        this.Redirect("Company-Membership-UserInfo&esr=1");
    }
}
