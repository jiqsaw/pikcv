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

public partial class UserControls_Common_uArticleDetail : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (CARETTA.COM.Util.IsNumeric(Request.QueryString["ArticleID"]))
            {
                FillArticleDetail(Convert.ToInt32(Request.QueryString["ArticleID"]));
            }
        }
    }

    private void FillArticleDetail(int ArticleID)
    {
        PIKCV.BUS.Articles obj = new PIKCV.BUS.Articles();
        DataTable dt = obj.GetArticleDetail(ArticleID);
        if (dt.Rows.Count > 0)
        {
            lbArticleDate.Text = String.Format("{0:d}", dt.Rows[0]["ModifyDate"]);
            lbArticleTitle.Text = dt.Rows[0]["ArticleTitle"].ToString();
            ltlArticleBody.Text = dt.Rows[0]["ArticleBody"].ToString();
        }
    }
}
