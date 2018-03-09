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

public partial class UserControls_Company_Interview_uInterview : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (CARETTA.COM.Util.IsNumeric(Request.QueryString["InterviewID"]))
                DeleteInterview();
            FillDetails();
        }
    }

    private void FillDetails()
    {
        PIKCV.COM.Enumerations.InterviewTabs InterviewTabs = new PIKCV.COM.Enumerations.InterviewTabs();
        if (CARETTA.COM.Util.IsNumeric(Request.QueryString["InterviewType"]))
        {
            int InterviewStatus = Convert.ToInt32(Request.QueryString["InterviewType"]);
            InterviewTabs = (PIKCV.COM.Enumerations.InterviewTabs)InterviewStatus;
        }
        Company obj = new Company();
        DataTable dtInterviews = null;
        switch (InterviewTabs)
        {
            case PIKCV.COM.Enumerations.InterviewTabs.InterviewList:
                UInterviewTabs1.TabActive(PIKCV.COM.Enumerations.InterviewTabs.InterviewList);
                if (CARETTA.COM.Util.IsNumeric(Request.QueryString["PositionID"]))
                {
                    dtInterviews = obj.GetCompanyInterviewsGroupByAdvisorAndTime(this.smCompanyID, PIKCV.COM.EnumDB.MemberTypes.Company, Convert.ToInt32(Request.QueryString["PositionID"]));
                    DataBindHelper.BindRepeater(ref rptPositionInterviews, dtInterviews);
                    if (dtInterviews.Rows.Count > 0)
                    {
                        lbMessage.Visible = false;
                        rptPositionInterviews.Visible = true;
                    }
                    else
                    {
                        rptPositionInterviews.Visible = false;
                        lbMessage.Text = "Kayýt Bulunamadý";
                        lbMessage.Visible = true;
                        
                    }
                }
                rptGeneralInterviews.Visible = false;
                rptInterviews.Visible = false;
                break;
            case PIKCV.COM.Enumerations.InterviewTabs.MadeInterviews:
                UInterviewTabs1.TabActive(PIKCV.COM.Enumerations.InterviewTabs.MadeInterviews);
                dtInterviews = obj.GetCompanyMadeInterviews(this.smCompanyID, PIKCV.COM.EnumDB.MemberTypes.Company, this.smLanguageID);
                DataBindHelper.BindRepeater(ref rptInterviews, dtInterviews);
                if (dtInterviews.Rows.Count > 0)
                {
                    lbMessage.Visible = false;
                    rptInterviews.Visible = true;
                }
                else
                {
                    lbMessage.Visible = true;
                    lbMessage.Text = "Yapýlmýþ olan kayýtlý mülakatýnýz bulunmamaktadýr";
                    rptInterviews.Visible = false;
                }
                rptPositionInterviews.Visible = false;
                rptGeneralInterviews.Visible = false;
                break;
            case PIKCV.COM.Enumerations.InterviewTabs.GeneralInterviews:
                UInterviewTabs1.TabActive(PIKCV.COM.Enumerations.InterviewTabs.InterviewList);
                dtInterviews = obj.GetCompanyInterviewsGroupByPosition(this.smCompanyID, PIKCV.COM.EnumDB.MemberTypes.Company, this.smLanguageID);

                DataBindHelper.BindRepeater(ref rptGeneralInterviews, dtInterviews);
                if (dtInterviews.Rows.Count > 0)
                {
                    lbMessage.Visible = false;
                    rptGeneralInterviews.Visible = true;
                }
                else
                {
                    lbMessage.Visible = true;
                    lbMessage.Text = "Mülakat listesinde bilgi bulunmamaktadýr";
                    rptGeneralInterviews.Visible = false;
                }
                rptInterviews.Visible = false;
                rptPositionInterviews.Visible = false;
                break;
        }
    }

    private void DeleteInterview()
    {
        int InterviewID = Convert.ToInt32(Request.QueryString["InterviewID"]);
        Company obj = new Company();
        DataTable dtInterview = obj.GetInterviewInfo(InterviewID);
        if (dtInterview.Rows.Count > 0)
        {
            if(Convert.ToInt32(dtInterview.Rows[0]["InterviewerID"]) == this.smCompanyID)
                obj.DeleteInterview(InterviewID);
        }
    }

    protected void rptInterviews_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if ((e.Item.ItemType == ListItemType.Item) || (e.Item.ItemType == ListItemType.AlternatingItem))
        {
            DropDownList drpInterviewStatus = new DropDownList();
            drpInterviewStatus = (DropDownList)e.Item.FindControl("drpInterviewStatus");
            DataBindHelper.BindDDL(ref drpInterviewStatus, this.cmbInterviewStatus, "InterviewStatusName", "InterviewStatusID", "");
            ((DropDownList)e.Item.FindControl("drpInterviewStatus")).SelectedValue = ((HiddenField)e.Item.FindControl("hfInerviewStatusID")).Value;
            ((HyperLink)e.Item.FindControl("hplDelete")).Attributes.Add("onclick", "return confirm('Mülakatý silmek istediðinize emin misiniz');");
            ((HyperLink)e.Item.FindControl("hplDelete")).NavigateUrl = ((HyperLink)e.Item.FindControl("hplDelete")).NavigateUrl + "&InterviewType=" + Request.QueryString["InterviewType"].ToString();
        }
    }
    
    protected void drpInterviewStatus_SelectedIndexChanged(object sender, EventArgs e)
    {
        foreach (RepeaterItem repeateritem in rptInterviews.Items)
        {
            string InterviewStatus = ((DropDownList)repeateritem.FindControl("drpInterviewStatus")).SelectedValue;
            string InterviewID = ((HiddenField)repeateritem.FindControl("hfInterviewID")).Value;
            Company obj = new Company();
            obj.UpdateInterviewStatus(int.Parse(InterviewID), int.Parse(InterviewStatus));
        }
        this.Redirect("Company-Interview-Interview&InterviewType=" + Request.QueryString["InterviewType"].ToString());
    }
}
