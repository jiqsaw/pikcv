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

public partial class UserControls_Company_Search_uFilters : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.smIsLogin)
        {
            FillData();
        }
    }

    private void FillData() {
        DataTable dtUserFilters = PIKCV.BUS.Filters.GetUserFilters(PIKCV.COM.EnumDB.FilterTypes.EmployeeSearch, this.smCompanyID, PIKCV.COM.EnumDB.MemberTypes.Company, false);
        if (dtUserFilters.Rows.Count > 0) {
            DataBindHelper.BindRepeater(ref rptFilters, dtUserFilters);
        }
        else
        {
            ltlNoRecord.Visible = true;
            rptFilters.Visible = false;
        }
    }

    protected void rptFilters_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        int FilterID = int.Parse(e.CommandArgument.ToString());
        if (e.CommandName == "Remove")
        {
            PIKCV.BUS.Filters.RemoveFilter(FilterID);
        }
        else if (e.CommandName == "Detail")
        {
            DataRow drFilter = PIKCV.BUS.Filters.GetFilter(FilterID);
            string FilterValue = drFilter["FilterValue"].ToString();
            Serialize objSer = new Serialize();
            EmployeeSearchQueries SearchQueries = new EmployeeSearchQueries();
            SearchQueries = (EmployeeSearchQueries)(objSer.DeserializeObject(FilterValue.Substring(1), typeof(EmployeeSearchQueries)));
            this.smEmployeeSearchQueries = SearchQueries;
            this.Redirect("Company-Membership-UserInfo&esr=1");
        }
        else if (e.CommandName == "Rename")
        {
            ((LinkButton)e.Item.FindControl("lnkFilterName")).Visible = false;
            ((TextBox)e.Item.FindControl("txtFilterName")).Visible = true;
            ((LinkButton)e.Item.FindControl("lnkFilterRenameSave")).Visible = true;
        }
        else if (e.CommandName == "RenameSave")
        {
            PIKCV.BUS.Filters.RenameFilter(FilterID, Request.Form[((TextBox)e.Item.FindControl("txtFilterName")).UniqueID].ToString());
            ((LinkButton)e.Item.FindControl("lnkFilterName")).Visible = true;
            ((TextBox)e.Item.FindControl("txtFilterName")).Visible = false;
            ((LinkButton)e.Item.FindControl("lnkFilterRenameSave")).Visible = false;
            FillData();
        }
    }

}
