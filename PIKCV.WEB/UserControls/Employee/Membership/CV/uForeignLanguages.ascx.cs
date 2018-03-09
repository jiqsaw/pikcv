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

public partial class UserControls_Employee_Membership_CV_uForeignLanguages : BaseUserControl
{

    protected void Page_PreRender(object sender, EventArgs e)
    {
        PIKCV.BUS.UserCVs objUserLanguages = new PIKCV.BUS.UserCVs();
        DataTable dtUserLanguages = objUserLanguages.GetUserLanguages(this.smUserID, (int)this.smLanguageID);
        pnlNoRecord.Visible = (dtUserLanguages.Rows.Count < 1);
        pnlForeignLanguages.Visible = !pnlNoRecord.Visible;
        rptForeignLanguages.DataSource = dtUserLanguages;
        rptForeignLanguages.DataBind();
        UCharacteristicAndSocialLifeNav1.SelectNavigatorLink(PIKCV.COM.EnumDB.CVFocusCode.ForeignLanguages);
        PIKCV.BUS.UserCVs objUserCV = new PIKCV.BUS.UserCVs();
        DataTable dtUserCV = objUserCV.GetUserCV(this.smUserID);
        ImgBtnContinue.Visible = !(Convert.ToInt32(dtUserCV.Rows[0]["CvFocusCode"]) > (int)PIKCV.COM.EnumDB.CVFocusCode.References);
    }

    protected void ImgBtnContinue_Click(object sender, ImageClickEventArgs e)
    {
        this.Redirect("Employee-Membership-CV&CVFocus=" + ((int)PIKCV.COM.EnumDB.CVFocusCode.ComputerKnowledge).ToString());
    }
    protected void rptForeignLanguages_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        
    }
    protected void rptForeignLanguages_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item)
        {
            string UserLanguageID = ((HyperLink)e.Item.FindControl("hlRemoveLanguage")).NavigateUrl;
            ((HyperLink)e.Item.FindControl("hlRemoveLanguage")).NavigateUrl = this.OpenConfirm(PIKCV.COM.EnumDB.ErrorTypes.cDeleteForeignLanguages, int.Parse(UserLanguageID));
        }
    }
}
