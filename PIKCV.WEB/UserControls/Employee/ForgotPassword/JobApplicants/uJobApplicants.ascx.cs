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

public partial class UserControls_Employee_JobApplicants_uJobApplicants : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.smJobDetailRefererUrl = PIKCV.COM.Enumerations.JobDetailRefererUrl.JobApplicants;
            UList1.DataBind(PIKCV.COM.Enumerations.ListTypes.UserJobApplicants);
        }
    }
}
