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

public partial class UserControls_Employee_Membership_CV_uReferences : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e) {
        ReplaceNavigateURL(ref hlEmploymentChooices, PIKCV.COM.EnumDB.CVFocusCode.EmploymentChooices);
        ReplaceNavigateURL(ref hlPlacementPreferences, PIKCV.COM.EnumDB.CVFocusCode.PlacementPreferences);
        ReplaceNavigateURL(ref hlProhibitedCompanies, PIKCV.COM.EnumDB.CVFocusCode.ProhibitedCompanies);
    }

    protected void Page_PreRender(object sender, EventArgs e)
    {
        PIKCV.BUS.UserCVs objUserReferences = new PIKCV.BUS.UserCVs();
        DataTable dtUserReferences = objUserReferences.GetUserReferences(this.smUserID);
        pnlNoRecord.Visible = (dtUserReferences.Rows.Count < 1);
        pnlReferences.Visible = !pnlNoRecord.Visible;
        rptReferences.DataSource = dtUserReferences;
        rptReferences.DataBind();
        PIKCV.BUS.UserCVs objUserCV = new PIKCV.BUS.UserCVs();
        DataTable dtUserCV = objUserCV.GetUserCV(this.smUserID);
        ImgBtnContinue.Visible = !(Convert.ToInt32(dtUserCV.Rows[0]["CvFocusCode"]) > (int)PIKCV.COM.EnumDB.CVFocusCode.References);
    }

    private void ReplaceNavigateURL(ref HyperLink hl, PIKCV.COM.EnumDB.CVFocusCode CVFocusCode) {
        hl.NavigateUrl = hl.NavigateUrl.Replace("||FocusNo||", ((int)CVFocusCode).ToString());
    }

    protected void ImgBtnContinue_Click(object sender, ImageClickEventArgs e) {
        PIKCV.BUS.UserCVs objUserCV = new PIKCV.BUS.UserCVs();
        if (objUserCV.SaveCVFocus(this.smUserID, PIKCV.COM.EnumDB.CVFocusCode.OtherChoices)) {
            if (this.smPhotoFileName == String.Empty) this.Redirect("Employee-Membership-CV-PersonalPhoto");
            else if (PIKCV.BUS.Test.UserTestCtrl(this.smUserID)) { this.Redirect("Employee-Membership-Tests"); }
            else { this.Redirect("Employee-Membership-CV"); }
        }
    }

    protected void rptReferences_ItemCommand(object source, RepeaterCommandEventArgs e)
    {

    }
    protected void rptReferences_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {
            string UserReferenceID = ((HyperLink)e.Item.FindControl("hlRemoveReferences")).NavigateUrl;
            ((HyperLink)e.Item.FindControl("hlRemoveReferences")).NavigateUrl = this.OpenConfirm(PIKCV.COM.EnumDB.ErrorTypes.cDeleteReference, int.Parse(UserReferenceID));
        }
    }
}

