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

public partial class UserControls_Company_Common_uJobsTabs : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    public void TabActive(PIKCV.COM.Enumerations.JobsTabs jobTab)
    {
        switch (jobTab)
        {
            case PIKCV.COM.Enumerations.JobsTabs.NewJobEntry:
                liNewJobEntry.Attributes.Add("class", "TabActive");
                break;
            case PIKCV.COM.Enumerations.JobsTabs.PublicJobs:
                liPublicJobs.Attributes.Add("class", "TabActive");
                break;
            case PIKCV.COM.Enumerations.JobsTabs.Draft:
                liSketch.Attributes.Add("class", "TabActive");
                break;
            case PIKCV.COM.Enumerations.JobsTabs.JobArchive:
                liJobArchive.Attributes.Add("class", "TabActive");
                break;
        }
    }
    protected void lnbActiveJobs_Click(object sender, EventArgs e)
    {
        this.smListFilterTypes = new ArrayList();
        string Link = "Company-Jobs-PublicJobs&JobStatus=" + ((int)PIKCV.COM.EnumDB.JobStatus.Active).ToString();
        this.Redirect(Link);
    }

    protected void lnbDraftJobs_Click(object sender, EventArgs e)
    {
        this.smListFilterTypes = new ArrayList();
        string Link = "Company-Jobs-PublicJobs&JobStatus=" + ((int)PIKCV.COM.EnumDB.JobStatus.Draft).ToString();
        this.Redirect(Link);
    }

    protected void lnbArchivedJobs_Click(object sender, EventArgs e)
    {
        this.smListFilterTypes = new ArrayList();
        string Link = "Company-Jobs-PublicJobs&JobStatus=" + ((int)PIKCV.COM.EnumDB.JobStatus.Archive).ToString();
        this.Redirect(Link);
    }
}
