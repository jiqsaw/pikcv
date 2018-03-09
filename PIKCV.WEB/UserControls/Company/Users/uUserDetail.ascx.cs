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

public partial class UserControls_Company_Users_uUserDetail : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (CARETTA.COM.Util.IsNumeric(Request.QueryString["UserID"]))
        {
            this.smUserID = int.Parse(Request.QueryString["UserID"]);
        }
    }
}
