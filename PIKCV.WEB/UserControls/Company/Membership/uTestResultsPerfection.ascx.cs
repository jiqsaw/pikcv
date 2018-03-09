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

public partial class UserControls_Company_Membership_uTestResultsPerfection : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (CARETTA.COM.Util.IsNumeric(Request.QueryString["esr"]))
            {
            }
            else { URightMenuTop1.Visible = false; }
        }
    }
}
