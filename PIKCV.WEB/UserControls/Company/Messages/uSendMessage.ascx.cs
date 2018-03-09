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

public partial class UserControls_Company_Messages_uSendMessage : BaseUserControl
{

    public int MessageDraftID
    {
        get { return (ViewState["MessageDraftID"] == null ? -1 : int.Parse(ViewState["MessageDraftID"].ToString())); }
        set { ViewState["MessageDraftID"] = value; }
    }

    private bool IsNew;
    private bool Prevview;

    protected void Page_Load(object sender, EventArgs e)
    {
        this.IsLogin();
        if (!IsPostBack)
        {
            DataBindHelper.BindDDL(ref ddlMessageDrafts, PIKCV.BUS.Messages.GetMessageDrafts(this.smCompanyID), "MessageName", "MessageDraftID", "0", "Taslaklar...", "0");
            DataBindHelper.BindDDL(ref ddlSystemDraftMessages, PIKCV.BUS.Messages.GetSystemDraftMessages(false), "MessageName", "SystemDraftMessageID", "0", "Sistem Mesajlarý...", "0");
            if ((Util.IsNumeric(Request.QueryString["MessageDraftID"])) || (Util.IsNumeric(Request.QueryString["IsNew"])))
            {
                if (Util.IsNumeric(Request.QueryString["IsNew"]))
                {
                    this.IsNew = Convert.ToBoolean((int.Parse(Request.QueryString["IsNew"].ToString())));
                }
                if (!IsNew)
                {
                    this.MessageDraftID = int.Parse(Request.QueryString["MessageDraftID"]);
                    GetMessageDraftDetail(MessageDraftID);
                }
                trChDraft.Visible = false;
                trDrafts.Visible = false;
                trTo.Visible = false;
                imgSend.Visible = false;
                imgSave.Visible = true;
                ltlDraftMessage.Visible = true;
                ltlSendMessage.Visible = false;
                trMessageName.Visible = true;
            }
            else {
                FillUserNames();
                //trChDraft.Visible = true;
                trDrafts.Visible = true;
                trTo.Visible = true;
                imgSend.Visible = true;
                imgSave.Visible = false;
                ltlDraftMessage.Visible = false;
                ltlSendMessage.Visible = true;
                trMessageName.Visible = false;
            }
        }
    }

    private void FillUserNames()
    {
        ArrayList arrUsers = this.smMessageUserIDs;
        string UserName = "";
        for (int i = 0; i < arrUsers.Count; i++)
        {
            PIKCV.BUS.User obj = new PIKCV.BUS.User();
            DataTable dt = obj.GetUserDetail(Convert.ToInt32(arrUsers[i]));
            if (dt.Rows.Count > 0)
            {
                UserName = dt.Rows[0]["FirstName"].ToString() + " " + dt.Rows[0]["LastName"].ToString();
            }
            if (i != 0)
            {
                lbUserNames.Text = lbUserNames.Text + ", " + UserName;
            }
            else
            {
                lbUserNames.Text = UserName;
            }
            
        }
    }

    protected void imgSend_Click(object sender, ImageClickEventArgs e)
    {
        PIKCV.BUS.Messages obj = new PIKCV.BUS.Messages();
        if (obj.InsertMessages(this.smCompanyID, txtMessage.Text, txtMessageTitle.Text, PIKCV.COM.EnumDB.MemberTypes.Employee, PIKCV.COM.EnumDB.MemberTypes.Company, this.smMessageUserIDs))
        {
            this.smMessageUserIDs = null;

            if (chDraft.Checked) {
                if (obj.SaveMessageDraft(0, this.smCompanyID, txtMessageTitle.Text, txtMessage.Text, txtMessageName.Text)) { 
                    
                }
            }

            this.GoToFeedback(PIKCV.COM.EnumDB.ErrorTypes.MessageSendSuccess);
            //lbMessage.Text = "Mesajlarýnýz baþarýyla gönderilmiþtir.";
        }
        else
        {
            lbMessage.Text = "Mesaj gönderilirken bir hata oluþtu. Lütfen tekrar deneyin.";
        }
        lbMessage.Visible = true;
    }

    protected void imgSave_Click(object sender, ImageClickEventArgs e)
    {
        PIKCV.BUS.Messages obj = new PIKCV.BUS.Messages();
        if (obj.SaveMessageDraft(this.MessageDraftID, this.smCompanyID, txtMessageTitle.Text, txtMessage.Text, txtMessageName.Text))
        {
            string strJs = "alert('Mesajýnýz baþarýyla kaydedildi');window.location.href='Pikcv.aspx?Pik=Company-Messages-MessageDrafts';";
            Response.Write("<script>" + strJs.ToString() + "</script>");
            //this.Redirect("#Company-Messages-Messages"); ;
        }
        else
        {
            lbMessage.Text = "Mesaj kaydedilirken hata oluþtu. Lütfen tekrar deneyin.";
        }
    }

    protected void ddlMessageDrafts_SelectedIndexChanged(object sender, EventArgs e)
    {
        int MessageDraftID = int.Parse(ddlMessageDrafts.SelectedValue);
        if (MessageDraftID > 0)
        {
            GetMessageDraftDetail(MessageDraftID);
            trChDraft.Visible = false;
        }
        else
        {
            //trChDraft.Visible = true;
            txtMessage.Text = String.Empty;
            txtMessageTitle.Text = String.Empty;
        }
    }

    private void GetMessageDraftDetail(int MessageDraftID)
    {
        if (MessageDraftID > 0)
        {
            DataTable dtMessageDetail = PIKCV.BUS.Messages.GetMessageDraftDetail(MessageDraftID);
            if (Util.IsNumeric(Request.QueryString["Prevview"]))
            {
                this.Prevview = Convert.ToBoolean((int.Parse(Request.QueryString["Prevview"].ToString())));
            }

            if (dtMessageDetail.Rows.Count > 0)
            {
                ltlMessageTitle.Text = dtMessageDetail.Rows[0]["Subject"].ToString();
                ltlMessage.Text = dtMessageDetail.Rows[0]["Message"].ToString();
                ltlMessageName.Text = dtMessageDetail.Rows[0]["MessageName"].ToString();
                txtMessageTitle.Text = dtMessageDetail.Rows[0]["Subject"].ToString();
                txtMessage.Text = dtMessageDetail.Rows[0]["Message"].ToString();
                txtMessageName.Text = dtMessageDetail.Rows[0]["MessageName"].ToString();

                ltlMessageTitle.Visible = this.Prevview;
                ltlMessage.Visible = this.Prevview;
                ltlMessageName.Visible = this.Prevview;
                txtMessageTitle.Visible = !(this.Prevview);
                txtMessage.Visible = !(this.Prevview);
                txtMessageName.Visible = !(this.Prevview);
                imgSave.Visible = !(this.Prevview);
                ddlSystemDraftMessages.Visible = !(this.Prevview);
            }
        }
    }
    protected void ddlSystemDraftMessages_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlSystemDraftMessages.SelectedValue != "0")
        {
            DataTable dt = PIKCV.BUS.Messages.GetSystemDraftMessageDetail(int.Parse(ddlSystemDraftMessages.SelectedValue));
            if (dt.Rows.Count > 0)
            {
                txtMessage.Text = dt.Rows[0]["Message"].ToString();
                txtMessageName.Text = dt.Rows[0]["MessageName"].ToString();
                txtMessageTitle.Text = dt.Rows[0]["Subject"].ToString();
            }
        }
    }
}
