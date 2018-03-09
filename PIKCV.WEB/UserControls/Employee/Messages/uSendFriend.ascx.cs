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

public partial class UserControls_Employee_Messages_uSendFriend : BaseUserControl
{
    private PIKCV.COM.EnumDB.SendFriendType SendFriendType;
    private int ParamID;
    private MailTemplates.MailContent MailContent;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Util.IsNumeric(Request.QueryString["SendFriendType"])) {
                this.SendFriendType = (PIKCV.COM.EnumDB.SendFriendType)(int.Parse(Request.QueryString["SendFriendType"]));
            }
            if (Util.IsNumeric(Request.QueryString["ID"])) {
                this.ParamID = int.Parse(Request.QueryString["ID"]);
            }
            FillDetail();
        }
    }

    private void FillDetail() {
        switch (SendFriendType)
        {
            case PIKCV.COM.EnumDB.SendFriendType.Job:
                this.MailContent = MailTemplates.SendFriendToJob;
                dvMessage.InnerHtml = this.MailContent.Body.Replace("||JOBID||", this.ParamID.ToString());
                break;
        }
    }

    protected void imgSend_Click(object sender, ImageClickEventArgs e)
    {
        string MailBody = dvMessage.InnerHtml;
        MailBody += "<br><br>";
        MailBody += "gönderenin notu: " + txtNote.Text;

        if (MailTemplates.Send_FriendMail(MailTemplates.SendFriendToJob, txtTo.Text, txtSubject.Text, MailBody))
            ShowModal.Show(UserControls_Common_uModalPopup.Icons.info, PIKCV.COM.EnumDB.ErrorTypes.NoticeSendFriend, true, true);
            //Response.Write("<script>alert('" + PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.NoticeSendFriend) + "'); window.close();</script>");
        else
            ShowModal.Show(UserControls_Common_uModalPopup.Icons.error, PIKCV.COM.Data.GetErrorMessageTitleCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.AsyncPostBackError), PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.AsyncPostBackError), false);        
    }
}
