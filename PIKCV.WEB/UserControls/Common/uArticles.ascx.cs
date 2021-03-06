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

public partial class UserControls_Common_uArticles : BaseUserControl {
    protected void Page_Load (object sender, EventArgs e) {
        if (!IsPostBack)
        {
            FillArticles();
        }
    }

    private void FillArticles()
    {
        PIKCV.BUS.Articles objAticles = new PIKCV.BUS.Articles();
        CARETTA.COM.DataBindHelper.BindRepeater(ref rptTopArticles, objAticles.GetTopArticles());
    }
}
