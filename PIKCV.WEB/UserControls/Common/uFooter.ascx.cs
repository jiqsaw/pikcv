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

public partial class UserControls_Common_uFooter : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.cookPageType != PIKCV.COM.Enumerations.PageType.Entry)
        {
            hlUserAgreement.Visible = (this.cookPageType == PIKCV.COM.Enumerations.PageType.Employee);
            hlCompanyContract.Visible = !hlUserAgreement.Visible;
        }
        else {
            hlUserAgreement.Visible = false;
            hlCompanyContract.Visible = false;
        }
    }
}
