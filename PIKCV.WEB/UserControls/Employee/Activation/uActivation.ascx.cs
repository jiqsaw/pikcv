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
using PIKCV.BUS;

public partial class UserControls_Employee_Activation_uActivation : BaseUserControl
{
    private string ActivationNumber;
    private int UserID; 
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Util.IsString(Request.QueryString["AN"]) && Util.IsNumeric(Request.QueryString["U"]))
            {
                this.ActivationNumber = Request.QueryString["AN"].ToString();
                this.UserID = Convert.ToInt32(Request.QueryString["U"]);
                ActivateMember();
            }
            else
            {
                ltlActivateNO.Visible = true;
            }
        }
    }

    private void ActivateMember()
    {
        User objUser = new User();
        if (objUser.ActivateUser(this.UserID, this.ActivationNumber))
        {
            ltlActivateYES.Visible = true;
        }
        else
        {
            ltlActivateNO.Visible = true;
        }
    }
}
