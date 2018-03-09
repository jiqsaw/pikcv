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

public partial class UserControls_Company_Messages_uSentMessages : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.IsLogin();
        if (!IsPostBack)
        {
            if (Util.IsNumeric(Request.QueryString["UserID"]))
            {
                this.smUserID = Convert.ToInt32(Request.QueryString["UserID"]);
                this.smEmployeeSearchResultUserIDs = new ArrayList();
                this.smEmployeeSearchResultUserIDs.Add(this.smUserID);
                Session.Remove(PIKCV.COM.EnumUtil.Sess.EmployeeSearchQueries.ToString());
                this.Redirect("Company-Membership-UserInfo");
            }
            UList1.DataBind(PIKCV.COM.Enumerations.ListTypes.CompanySentMessages);
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
}
