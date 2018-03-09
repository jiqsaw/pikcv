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

public partial class CVPopup : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Util.IsString(Request.QueryString["CVPage"]))
        {
            string CVPage = Request.QueryString["CVPage"].ToString();
            string ControlPath = "~/UserControls/Employee/MemberShip/CV/u" + CVPage + ".ascx";
            try
            {
                Control objControl = new Control();
                objControl = LoadControl(ControlPath);
                PH1.Controls.Clear();
                PH1.Controls.Add(objControl);
            }
            catch (Exception) { }
        }
    }
}
