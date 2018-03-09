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

public partial class UserControls_Common_uArticlesAll : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            PIKCV.BUS.Articles obj = new PIKCV.BUS.Articles();
            DataTable dtAllArticles = obj.GetAllArticles();
            UPaging1.GeneratePager(ref dtAllArticles, rptArticles, 20);
        }
    }
}
