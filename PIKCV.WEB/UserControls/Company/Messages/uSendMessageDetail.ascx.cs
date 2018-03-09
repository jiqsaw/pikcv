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

public partial class UserControls_Company_Messages_uSendMessageDetail : BaseUserControl
{
    public int MessageID = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Util.IsNumeric(Request.QueryString["MessageID"]))
            {
                this.MessageID = Convert.ToInt32(Request.QueryString["MessageID"]);
                FillDetails();
            }
        }
    }

    private void FillDetails()
    {
        DataTable dt = PIKCV.BUS.Messages.GetCompanySendMessageDetail(this.MessageID);
        if (dt.Rows.Count > 0)
        {
            lbMessageDate.Text = string.Format("{0:d}", dt.Rows[0]["CreateDate"]);
            lbMessageOwner.Text = dt.Rows[0]["FirstName"].ToString() + " "  + dt.Rows[0]["LastName"].ToString();
            lbMessageTitle.Text = dt.Rows[0]["MessageTitle"].ToString();
            lbMessageBody.Text = dt.Rows[0]["MessageBody"].ToString();
        }
        else { PIKCV.COM.Util.GoToEntryPage(this.Response); }
    }
}
