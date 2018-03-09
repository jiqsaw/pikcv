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

public partial class UserControls_Common_uFeedback : BaseUserControl
{
    private PIKCV.COM.EnumDB.ErrorTypes ErrorType;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (CARETTA.COM.Util.IsNumeric(Request.QueryString["Code"]))
            {
                this.ErrorType = (PIKCV.COM.EnumDB.ErrorTypes)(int.Parse(Request.QueryString["Code"]));
            }
            ShowMessage();
        }
    }

    private void ShowMessage() {
        DataRow drError = PIKCV.COM.Data.GetErrorCache(this.cmbErrors, this.ErrorType);
        ltlTitle.Text = drError["ErrorTitle"].ToString();
        ltlMessage.Text = drError["Message"].ToString();
    }
}