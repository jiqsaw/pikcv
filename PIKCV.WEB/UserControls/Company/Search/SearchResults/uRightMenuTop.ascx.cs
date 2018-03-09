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

public partial class UserControls_Company_Search_SearchResults_uRightMenuTop : BaseUserControl
{
    protected void Page_PreRender(object sender, EventArgs e)
    {
        lblEmployeeCount.Text = (this.smEmployeeSearchResultUserIDs.IndexOf(this.smUserID) +1)+ "/" + this.smEmployeeSearchResultUserIDs.Count.ToString();
    }
    protected void lbPreviousEmployee_Click(object sender, EventArgs e)
    {
        if (this.smEmployeeSearchResultUserIDs.IndexOf(this.smUserID) > 0)
            this.smUserID = int.Parse(this.smEmployeeSearchResultUserIDs[this.smEmployeeSearchResultUserIDs.IndexOf(this.smUserID) - 1].ToString());
        else
            this.smUserID = int.Parse(this.smEmployeeSearchResultUserIDs[this.smEmployeeSearchResultUserIDs.Count - 1].ToString());
        lblEmployeeCount.Text = (this.smEmployeeSearchResultUserIDs.IndexOf(this.smUserID) + 1) + "/" + this.smEmployeeSearchResultUserIDs.Count.ToString();
    }
    protected void lbNextEmployee_Click(object sender, EventArgs e)
    {
        if (this.smEmployeeSearchResultUserIDs.IndexOf(this.smUserID) < (this.smEmployeeSearchResultUserIDs.Count - 1))
            this.smUserID = int.Parse(this.smEmployeeSearchResultUserIDs[this.smEmployeeSearchResultUserIDs.IndexOf(this.smUserID) + 1].ToString());
        else
            this.smUserID = int.Parse(this.smEmployeeSearchResultUserIDs[0].ToString());
        lblEmployeeCount.Text = (this.smEmployeeSearchResultUserIDs.IndexOf(this.smUserID) + 1) + "/" + this.smEmployeeSearchResultUserIDs.Count.ToString();
    }
}
