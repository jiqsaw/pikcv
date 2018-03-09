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

public partial class UserControls_Employee_uEmployeeLogon : BaseUserControl
{
    private DataTable dtMainJobs;
    private int FirstCount = 10;
    private int SecondCount = 10;
    protected void Page_Load(object sender, EventArgs e)
    {
        UTeaser1.BtnSignUp = false;
        if (!IsPostBack)
        {
            this.IsLogin();
            this.smJobDetailRefererUrl = PIKCV.COM.Enumerations.JobDetailRefererUrl.MainPage;
            CustomJobs();

        }
    }


    private void CustomJobs()
    {
        this.dtMainJobs = PIKCV.BUS.Job.GetUserCustomJobs(this.smUserID, this.smLanguageID);
        int j = 0;
        //for (int i = this.dtMainJobs.Rows.Count; i <= (FirstCount + SecondCount); i++)
        //{
        //    if (j < this.cmbMainJobs.Rows.Count)
        //    {
        //        this.dtMainJobs.Rows.Add(this.cmbMainJobs.Rows[j].ItemArray);
        //        j++;
        //    }
        //    else break;
        //}
            pnlCustomJobs.Visible = (dtMainJobs.Rows.Count > 0);
            UMainJobs1.Visible = !(pnlCustomJobs.Visible);
        if (dtMainJobs.Rows.Count > 0)
        {
            DataTable dtMainJobs1 = this.dtMainJobs.Clone();
            DataTable dtMainJobs2 = this.dtMainJobs.Clone();
            for (int i = 0; i < (FirstCount + SecondCount); i++)
            {
                if (i < this.dtMainJobs.Rows.Count)
                {
                    if (i < FirstCount) dtMainJobs1.Rows.Add(dtMainJobs.Rows[i].ItemArray);
                    else dtMainJobs2.Rows.Add(dtMainJobs.Rows[i].ItemArray);
                }
            }

            dlMainJobs1.DataSource = dtMainJobs1;
            dlMainJobs1.DataBind();

            if (dtMainJobs2.Rows.Count < 1)
            {
                dvScript.InnerHtml = "<script>li2.style.display='none';</script>";
            }
            else
            {
                dlMainJobs2.DataSource = dtMainJobs2;
                dlMainJobs2.DataBind();
            }
        }
    }

}