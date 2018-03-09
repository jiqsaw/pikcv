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

public partial class UserControls_Company_Folders_uFoldersMain : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.IsLogin();
        if (!IsPostBack)
        {
            Session.Remove(PIKCV.COM.EnumUtil.Sess.EmployeeSearchQueries.ToString());
            FillDetails();
        }
    }

    private void FillDetails()
    {
        PIKCV.BUS.Company obj = new PIKCV.BUS.Company();
        DataTable dt = obj.GetCompanyFolders(this.smCompanyID, true, false);
        DataBindHelper.BindRepeater(ref rptDefaulFolders, dt);
        dt = obj.GetCompanyFolders(this.smCompanyID, false, false);
        DataBindHelper.BindRepeater(ref rptCreatedFolders, dt);
    }

    protected void lbnDeleteFolder_Click(object sender, EventArgs e)
    {
        int FolderID = int.Parse(((LinkButton)sender).CommandArgument);
        PIKCV.BUS.Company obj = new PIKCV.BUS.Company();
        obj.DeleteCompanyFolder(FolderID);
        FillDetails();
    }
    protected void rptCreatedFolders_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if ((e.Item.ItemType == ListItemType.Item) || (e.Item.ItemType == ListItemType.AlternatingItem))
        {
            ((LinkButton)e.Item.FindControl("lbDeleteFolder")).Attributes.Add("onclick", "return confirm('Klasörü silmek istediðinize emin misiniz');");
        }
    }
}