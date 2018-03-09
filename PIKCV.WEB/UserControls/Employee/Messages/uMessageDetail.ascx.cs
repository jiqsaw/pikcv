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
using PIKCV.BUS;

public partial class UserControls_Employee_Messages_uMessageDetail : BaseUserControl
{
    public int MessageID = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if(Util.IsNumeric(Request.QueryString["MessageID"]))
            {
                this.MessageID = Convert.ToInt32(Request.QueryString["MessageID"]);
                FillDetails();
            }
        }
    }

    private void FillDetails()
    {
        DataTable dt = PIKCV.BUS.Messages.GetMessageByMessageID(this.MessageID);
        if (dt.Rows.Count > 0)
        {
            if (Convert.ToInt32(dt.Rows[0]["MessageOwnerID"]) == smUserID)
            {
                lbMessageDate.Text = string.Format("{0:d}", dt.Rows[0]["CreateDate"]);
                lbMessageFrom.Text = dt.Rows[0]["CompanyName"].ToString();
                lbMessageTitle.Text = dt.Rows[0]["MessageTitle"].ToString();
                lbMessageBody.Text = dt.Rows[0]["MessageBody"].ToString();
                if (!Convert.ToBoolean(dt.Rows[0]["Isread"]))
                {
                    Messages.MakeMessageReaded(this.MessageID);
                }
            }
            else { PIKCV.COM.Util.GoToEntryPage(this.Response); }
        }
        else { PIKCV.COM.Util.GoToEntryPage(this.Response); }
    }
}
