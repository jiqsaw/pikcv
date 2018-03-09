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

public partial class UserControls_Company_Messages_uMessages : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.IsLogin();
        if (!IsPostBack)
        {
            UList1.DataBind(PIKCV.COM.Enumerations.ListTypes.CompanyMessages);
        }
    }
    protected void lnkMessages_Click(object sender, EventArgs e)
    {
        this.smListFilterTypes = new ArrayList();
        this.Redirect("Company-Messages-Messages");
    }
    protected void lnkSentMessages_Click(object sender, EventArgs e)
    {
        this.smListFilterTypes = new ArrayList();
        this.Redirect("Company-Messages-SentMessages");
    }
}
