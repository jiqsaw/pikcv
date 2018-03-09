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

public partial class Privacy : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            PIKCV.BUS.Job obj = new PIKCV.BUS.Job();
            DataTable dt = obj.GetAllJobs(PIKCV.COM.EnumDB.JobStatus.Active, PIKCV.COM.EnumDB.LanguageID.Turkish);
            CARETTA.COM.DataBindHelper.BindRepeater(ref rptJobs, dt);
        }
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
