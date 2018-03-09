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

public partial class UserControls_Company_TemporaryUsers_uTemporaryUserLogin : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void btnSend_Click(object sender, ImageClickEventArgs e)
    {
        DataTable dt = PIKCV.BUS.TemporaryUsers.TemporaryUserLoginControl(txtUserName.Text, txtPassword.Text);
        if(dt.Rows.Count > 0)
        {
            this.smTemporaryUserID = Convert.ToInt32(dt.Rows[0]["TemporaryUserID"]);
            Response.Redirect("TemporaryUsersFolderDeail.aspx");
        }
        else
        {
            Response.Write("<script> { alert('Yanlýþ kullanýcý adý ya da þifre girdiniz.');}</script>");
        }
    }
}
