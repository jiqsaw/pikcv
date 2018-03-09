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

public partial class UserControls_Company_Folders_uCreateFolder : BaseUserControl
{
    public int FolderID
    {
        get
        {
            if (ViewState["FID"] == null)
            {
                ViewState.Add("FID", "0");
            }
            return Convert.ToInt32(ViewState["FID"]);
        }
        set { ViewState.Add("FID", value); }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (CARETTA.COM.Util.IsNumeric(Request.QueryString["FolderID"]))
            {
                this.FolderID = Convert.ToInt32(Request.QueryString["FolderID"]);
                FillDetails();
            }
        }
    }

    private void FillDetails()
    {
        PIKCV.BUS.Company obj = new PIKCV.BUS.Company();
        DataTable dt = obj.GetCompanyFolderDetail(this.FolderID);
        if (dt.Rows.Count > 0)
        {
            txtFolderName.Text = dt.Rows[0]["FolderName"].ToString();
        }
        else
        {
            Response.Write("<script language='javascript'> { window.close();}</script>");
        }
    }
    protected void btnSubmit_Click(object sender, ImageClickEventArgs e)
    {
        PIKCV.BUS.Company obj = new PIKCV.BUS.Company();
        if (obj.FolderExistance(this.smCompanyID, txtFolderName.Text, false) > 0)
        {
            Response.Write("<script> { alert('Bu isimde bir klasör zaten bulunmaktadýr.'); } </script>");
        }
        else
        {
            if (obj.SaveCompanyFolder(this.smCompanyID, this.FolderID, txtFolderName.Text) > 0)
            {
                lbMessage.Text = "Klasör baþarýyla kaydedildi";
                Response.Write("<script language='javascript'> { alert('Klasör baþarýyla kaydedildi');window.opener.location.reload();window.close();}</script>");
            }
            else
            {
                Response.Write("<script language='javascript'> { alert('Klasör kaydederken bir hata oluþtu. Lütfen tekrar deneyin');window.opener.location.reload();window.close();}</script>");
            }
        }
    }
}
