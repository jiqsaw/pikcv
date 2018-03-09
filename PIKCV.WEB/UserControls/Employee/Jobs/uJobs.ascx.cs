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

public partial class UserControls_Employee_Jobs_uJobs : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) {
            if (Util.IsNumeric(Request.QueryString["PopupID"]))
            {
                int PopupID = Convert.ToInt32(Request.QueryString["PopupID"]);
                PIKCV.COM.EnumDB.ErrorTypes ErrorType = (PIKCV.COM.EnumDB.ErrorTypes)PopupID;
                ShowModal.Show(UserControls_Common_uModalPopup.Icons.alert, PIKCV.COM.Data.GetErrorMessageTitleCache(this.cmbErrors, ErrorType), PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, ErrorType), false);
            }
            this.smJobDetailRefererUrl = PIKCV.COM.Enumerations.JobDetailRefererUrl.JobSearch;
            UList1.DataBind(PIKCV.COM.Enumerations.ListTypes.JobSearchResults);
            dvUserFilters.Visible = ((this.smIsLogin) && (this.smMemberType == PIKCV.COM.EnumDB.MemberTypes.Employee));
        }
        DataBindHelper.BindDDL(ref ddlFilters, PIKCV.BUS.Filters.GetUserFilters(PIKCV.COM.EnumDB.FilterTypes.JobSearch, this.smUserID, PIKCV.COM.EnumDB.MemberTypes.Employee, false), "FilterName", "FilterID", "0", "Filtrelerim", "0");
    }
    protected void ddlFilters_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlFilters.SelectedValue != "0") {
            int FilterID = int.Parse(ddlFilters.SelectedValue);
            DataRow drFilter = PIKCV.BUS.Filters.GetFilter(FilterID);
            string FilterValue = drFilter["FilterValue"].ToString();
            Serialize objSer = new Serialize();
            JobSearchQuery SearchQueries = new JobSearchQuery();
            SearchQueries = (JobSearchQuery)(objSer.DeserializeObject(FilterValue.Substring(1), typeof(JobSearchQuery)));
            this.smJobSearchQueries = SearchQueries;
        }
    }
    protected void btnSave_Click(object sender, ImageClickEventArgs e)
    {
        Serialize objSerialize = new Serialize();
        string FilterValue = objSerialize.SerializeObject(this.smJobSearchQueries);
        PIKCV.BUS.Filters.SaveFilter(PIKCV.COM.EnumDB.FilterTypes.JobSearch, txtFilterName.Text, this.smUserID, PIKCV.COM.EnumDB.MemberTypes.Employee, FilterValue);
        Response.Write("<script>alert('Filtre Kaydedildi')</script>");
    }
}
