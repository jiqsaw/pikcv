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

public partial class UserControls_Company_Activation_uActivation : BaseUserControl
{
    private string ActivationNumber;
    private int MemberID; 
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Util.IsString(Request.QueryString["AN"]) && Util.IsNumeric(Request.QueryString["C"]))
            {
                this.ActivationNumber = Request.QueryString["AN"].ToString();
                this.MemberID = Convert.ToInt32(Request.QueryString["C"]);
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
        PIKCV.BUS.Company objCompany = new PIKCV.BUS.Company();
        if (objCompany.ActivateMember(this.MemberID, this.ActivationNumber))
        {
            ltlActivateYES.Visible = true;
            ltlActivateMsg.Visible = true;
            hlDownload.Visible = true;
        }
        else
        {
            ltlActivateNO.Visible = true;
            ltlActivateMsg.Visible = false;
            hlDownload.Visible = false;
        }
    }
}
