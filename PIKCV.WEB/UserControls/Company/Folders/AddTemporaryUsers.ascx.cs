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

public partial class UserControls_Company_Folders_AddTemporaryUsers : BaseUserControl
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
            }
            else
            {
                Response.Write("<script language='javascript'> { window.close();}</script>");
            }
        }
    }


    protected void btnSubmit_Click(object sender, ImageClickEventArgs e)
    {
        PIKCV.BUS.Company obj = new PIKCV.BUS.Company();
        string UserName = "PikUser" + Util.CreateRandomNumber(6);
        string Password = Util.CreateRandomNumber(8);
        string Email = txtEmail.Text;
        string Notes = txtNotes.Text;
        int SavedTempUserID = obj.SaveCompanyTemporaryUser(this.smCompanyID, Email, this.FolderID, UserName, Password, Notes);
        if (SavedTempUserID > 0)
        {
            //Mail yollanacak

            if (MailTemplates.Send_Tmp_TemporaryUser(MailTemplates.TemporaryUser, UserName, Password, Notes, Email))
            {
                string strErr = PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.SharedFolder);
                Response.Write("<script>alert('" + strErr + "');this.close();</script>");
            }
            else
            {
                lbMessage.Text = "Klasör paylaþýmý yapýldý fakat bilgiler mail gönderilemedi.";
            }
        }
        else
        {
            lbMessage.Text = "Kayýt yapýlýrken bir hata oluþtu, lütfen tekrar deneyin";
        }
        pnlMessage.Visible = true;
    }
}
