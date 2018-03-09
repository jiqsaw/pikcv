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
using CARETTA.COM;

public partial class UserControls_Company_uCompanyLogon : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.IsLogin();
        if (!IsPostBack)
        {
            FillJobs();
            FillCreditPackages();
            FillCreditSituation();
            FillFolders();
        }
    }

    private void FillJobs()
    {
        DataTable dt = Job.GetCompanyJobs(this.smCompanyID, PIKCV.COM.EnumDB.JobStatus.Active, PIKCV.COM.EnumDB.LanguageID.Turkish);
        CARETTA.COM.DataBindHelper.BindRepeater(ref rptJobs, dt);
        if (dt.Rows.Count > 0)
        {
            pnlJobs.Visible = true;

            dvNoJobs.Visible = false;
            rptJobs.Visible = true;
        }
        else
        {
            pnlJobs.Visible = false;

            dvNoJobs.Visible = true;
            rptJobs.Visible = false;
            lbNoJobs.Text = "Henüz aktif bir ilanýnýz bulunmamaktadýr";
        }
    }

    private void FillCreditPackages()
    {
        Credits obj = new Credits();
        DataTable dtCredits = obj.GetCreditPackages();
        if (dtCredits.Rows.Count > 0)
        {
            if (Convert.ToInt32(dtCredits.Rows[0]["CreditPackageID"]) == 0)
            {
                dtCredits.Rows[0].Delete();
            }
        }
        DataBindHelper.BindRepeater(ref rptCredits, dtCredits);
    }

    private void FillCreditSituation()
    {
        Credits obj = new Credits();
        DataTable dt = obj.GetCompanyCreditSituation(this.smCompanyID);
        if (dt.Rows.Count > 0)
        {
            lbRemainingCredits.Text = this.smPikCredi;
            if (dt.Rows[0]["OrderDate"].ToString() != "...")
            {
                lbLastCreditTakenDate.Text = Convert.ToDateTime(dt.Rows[0]["OrderDate"]).ToShortDateString();
            }
            else {
                lbLastCreditTakenDate.Text = dt.Rows[0]["OrderDate"].ToString();
            }
        }
    }

    private void FillFolders()
    {
        Company obj = new Company();
        string FolderIDUsersToTake = "";
        string FolderToTakeUserCount = "";
        string FolderIDUsersTaken = "";
        string FolderTakenUserCount = "";
        int TotalUserCount = 0;

        DataTable dtCompanyFolders = obj.GetCompanyDefaultFolderSituation(this.smCompanyID, true, false);

        foreach (DataRow dr in dtCompanyFolders.Rows)
        {
            if (Convert.ToInt32(dr["FolderTypeID"]) == (int)PIKCV.COM.EnumDB.FolderTypeID.UsersWillBeBought)
            {
                FolderIDUsersToTake = dr["FolderID"].ToString();
                FolderToTakeUserCount = dr["FolderUserCount"].ToString();
                TotalUserCount = TotalUserCount + Convert.ToInt32(dr["FolderUserCount"]);
            }
            else if (Convert.ToInt32(dr["FolderTypeID"]) == (int)PIKCV.COM.EnumDB.FolderTypeID.UsersBough)
            {
                FolderIDUsersTaken = dr["FolderID"].ToString();
                FolderTakenUserCount = dr["FolderUserCount"].ToString();
                TotalUserCount = TotalUserCount + Convert.ToInt32(dr["FolderUserCount"]);
            }
        }

        if (TotalUserCount > 0)
        {
            hplUsersTaken.Text = FolderTakenUserCount + hplUsersTaken.Text;
            hplUsersTaken.NavigateUrl = hplUsersTaken.NavigateUrl + FolderIDUsersTaken;
            hplUsersToTake.Text = FolderToTakeUserCount + hplUsersToTake.Text;
            hplUsersToTake.NavigateUrl = hplUsersToTake.NavigateUrl + FolderIDUsersToTake;
        }
        else { pnlFolders.Visible = false; }
    }

    protected void lnbRefNo_Click(object sender, EventArgs e)
    {
        this.smJobID = int.Parse(((LinkButton)sender).CommandArgument);
        this.Redirect("Company-Jobs-Jobs");
    }

    protected void lnbArchive_Click(object sender, EventArgs e)
    {
        Job obj = new Job();
        obj.ChangeJobStatus(int.Parse(((LinkButton)sender).CommandArgument), PIKCV.COM.EnumDB.JobStatus.Archive);
        FillJobs();
    }

    protected void lnbUpdate_Click(object sender, EventArgs e)
    {
        //this.smJobID = int.Parse(((LinkButton)sender).CommandArgument);
        this.Redirect("Company-Jobs-Jobs&JobFocus=" + ((int)PIKCV.COM.EnumDB.JobsFocusCode.PositionDefinition).ToString() + "&JobSaveType=" + ((int)PIKCV.COM.Enumerations.JobSaveType.Update).ToString() + "&JobID=" + ((LinkButton)sender).CommandArgument);
    }

    protected void lnbDelete_Click(object sender, EventArgs e)
    {
        Job obj = new Job();
        obj.ChangeJobStatus(int.Parse(((LinkButton)sender).CommandArgument), PIKCV.COM.EnumDB.JobStatus.Deleted);
        FillJobs();
    }

    protected void rptJobs_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if ((e.Item.ItemType == ListItemType.Item) || (e.Item.ItemType == ListItemType.AlternatingItem))
        {
            ((LinkButton)(e.Item.FindControl("lnbDelete"))).Attributes.Add("onclick", "return confirm('Ýlaný silmek istediðinize emin misiniz');");
            ((LinkButton)(e.Item.FindControl("lnbArchive"))).Attributes.Add("onclick", "return confirm('Ýlaný arþivlemek istediðinize emin misiniz');");

        }
    }
}
