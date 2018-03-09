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

public partial class UserControls_Common_uTop : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Theme();
        }
        hlServices.Visible = (((this.cookPageType == PIKCV.COM.Enumerations.PageType.Employee) || (this.cookPageType == PIKCV.COM.Enumerations.PageType.Company)));
        if (hlServices.Visible)
        {
            hlServices.NavigateUrl = hlServices.NavigateUrl.Replace("||MemberType||", this.cookPageType.ToString()).ToString();
        }
    }

    private void Theme()
    {
        liEmployee.Visible = (this.cookPageType == PIKCV.COM.Enumerations.PageType.Employee);
        liCompany.Visible = !liEmployee.Visible;
        liCompany.Visible = (this.smMemberType == PIKCV.COM.EnumDB.MemberTypes.Company);
    }
    protected void imgLogo_Click(object sender, ImageClickEventArgs e)
    {
        this.GoToDefaultPage();
    }
}
