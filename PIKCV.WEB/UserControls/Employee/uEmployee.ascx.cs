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

public partial class UserControls_Employee_uEmployee : BaseUserControl
{
    //private DataTable dtMainJobs;
    //private int FirstCount = 20;
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!IsPostBack)
        //{
        //    this.dtMainJobs = PIKCV.BUS.Job.GetMainJobs(PIKCV.COM.EnumDB.JobStatus.Active); //this.cmbMainJobs;
        //    DataTable dtMainJobs1 = this.dtMainJobs.Clone();
        //    DataTable dtMainJobs2 = this.dtMainJobs.Clone();
        //    for (int i = 0; i < this.dtMainJobs.Rows.Count; i++) {
        //        if (i <= FirstCount) {
        //            dtMainJobs1.Rows.Add(dtMainJobs.Rows[i].ItemArray);
        //        }
        //        else {
        //            dtMainJobs2.Rows.Add(dtMainJobs.Rows[i].ItemArray);
        //        }
        //    }

        //    dlMainJobs1.DataSource = dtMainJobs1;
        //    dlMainJobs1.DataBind();

        //    if (dtMainJobs2.Rows.Count < 1) {
        //        dvScript.InnerHtml = "<script>li2.style.display='none';</script>";
        //    }
        //    else {
        //        dlMainJobs2.DataSource = dtMainJobs2;
        //        dlMainJobs2.DataBind();
        //    }
        //}
    }
}