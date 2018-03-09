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

public partial class UserControls_Company_Messages_uMessageDrafts : BaseUserControl
{
    private DataTable dtMessageDrafts;
    protected void Page_Load(object sender, EventArgs e)
    {
        this.IsLogin();
        if (!IsPostBack)
        {
            this.dtMessageDrafts = PIKCV.BUS.Messages.GetMessageDrafts(this.smCompanyID);
            FillData();
        }
    }

    private void FillData()
    {
        if (this.dtMessageDrafts.Rows.Count > 0)
        {
            DataBindHelper.BindRepeater(ref rptDrafts, this.dtMessageDrafts);
        }
        else
        {
            ltlNoRecord.Visible = true;
        }
    }

    protected void lnkMessages_Click(object sender, EventArgs e)
    {
        this.smListFilterTypes = new ArrayList();
        this.Redirect("Company-Messages-Messages");
    }
    protected void lnkSentMessages_Click(object sender, EventArgs e)
    {
        this.smListFilterTypes = new ArrayList();
        this.Redirect("Company-Messages-SentMessages");
    }

    protected void rptDrafts_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if ((e.Item.ItemType == ListItemType.Item) || (e.Item.ItemType == ListItemType.AlternatingItem))
        {
            int MessageDraftID = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Remove")
            {
                PIKCV.BUS.Messages.RemoveMessageDraft(MessageDraftID);
                this.dtMessageDrafts = PIKCV.BUS.Messages.GetMessageDrafts(this.smCompanyID);
                FillData();
            }
            else if (e.CommandName == "Detail") {
                this.Redirect("Company-Messages-SendMessage&MessageDraftID=" + MessageDraftID.ToString() + "&Prevview=1");
            }
            else if (e.CommandName == "Update")
            {
                this.Redirect("Company-Messages-SendMessage&MessageDraftID=" + MessageDraftID.ToString());
            }
        }
    }
}
    