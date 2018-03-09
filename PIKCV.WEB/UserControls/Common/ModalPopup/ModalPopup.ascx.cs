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

public partial class UserControls_Common_uModalPopup : BaseUserControl
{
    string IconPath = "~/UserControls/Common/ModalPopup/Images/";
    public enum Icons
    {
        alert,
        error,
        error2,
        info,
        info2,
        reload,
        stop,
        stop2
    }

    protected void Page_Load(object sender, EventArgs e) {

    }
    
    public string TargetControlID
    {
        set { ModalPopupExtender.TargetControlID = value; }
    }

    public Icons Icon
    {
        set { imgIcon.ImageUrl = IconPath + value.ToString() + ".png"; }
    }

    public string Title
    { 
        set { lblTitle.Text = value; }
    }

    public string Message
    {
        set { lblText.Text = value; }
    }

    public void Show(Icons Icon, PIKCV.COM.EnumDB.ErrorTypes ErrorType) {
        Show(Icon, ErrorType, false, false);
    }

    public void Show(Icons Icon, PIKCV.COM.EnumDB.ErrorTypes ErrorType, bool IsOpenerReload, bool IsSelfClose) { 
        DataRow drErr = PIKCV.COM.Data.GetErrorCache(this.cmbErrors, ErrorType);
        Show(Icon, drErr["ErrorTitle"].ToString(), drErr["Message"].ToString(), false);

        string Script = String.Empty;

        if (IsSelfClose) { Script = "SelfClose();"; }
        if (IsOpenerReload) { Script = "OpenerReload();"; }

    }

    public void Show(Icons Icon, string Title, string Message) {
        Show(Icon, Title, Message, IsPostBack);
    }

    public void Show(Icons Icon, string Title, string Message, bool Post)
    {
        this.Visible = true;
        imgIcon.ImageUrl = IconPath + Icon.ToString() + ".png";
        lblTitle.Text = Title;
        dvMessage.InnerHtml = Message;
        //FormDeactive(Post);
        ModalPopupExtender.Show();
    }

    private void FormDeactive(bool AsyncPostBack) {
        if (AsyncPostBack) { 
            ScriptManager.RegisterClientScriptBlock(pnlModal, pnlModal.GetType(), "DeActive", "DeActive()", true); 
        } else { 
            dvScript.InnerHtml = "<script>DeActive()</script>"; 
        }
    }

}
