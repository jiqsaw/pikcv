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

public partial class UserControls_Employee_Membership_CV_uEmployment : BaseUserControl
{

    protected void Page_PreRender(object sender, EventArgs e)
    {
        PIKCV.BUS.UserCVs objUserEmployment = new PIKCV.BUS.UserCVs();
        DataTable dtUserEmployment = objUserEmployment.GetUserEmployment(this.smUserID, (int)this.smLanguageID);
        pnlNoRecord.Visible = (dtUserEmployment.Rows.Count < 1);
        pnlEmployment.Visible = !pnlNoRecord.Visible;
        rptEmployment.DataSource = dtUserEmployment;
        rptEmployment.DataBind();

        DataBindHelper.LoadNumberDDL(ref ddlTotalWorkExperience, 60, 1, 0);
        ddlTotalWorkExperience.Items.Insert(0, new ListItem(PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.InitialText), "-1"));

        PIKCV.BUS.UserCVs objUserCV = new PIKCV.BUS.UserCVs();
        DataTable dtUserCV = objUserCV.GetUserCV(this.smUserID);
        ddlTotalWorkExperience.SelectedValue = dtUserCV.Rows[0]["TotalWorkExperience"].ToString();
        ImgBtnContinue.Visible = !(Convert.ToInt32(dtUserCV.Rows[0]["CvFocusCode"]) > (int)PIKCV.COM.EnumDB.CVFocusCode.References);
    }

    protected void ImgBtnContinue_Click(object sender, ImageClickEventArgs e)
    {
        this.Redirect("Employee-Membership-CV&CVFocus=" + ((int)PIKCV.COM.EnumDB.CVFocusCode.DriverLicense).ToString());
    }
    protected void rptEmployment_ItemCommand(object source, RepeaterCommandEventArgs e)
    {

    }
    protected void rptEmployment_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        DateTime EndDate;
        if ((e.Item.ItemType == ListItemType.Item) || (e.Item.ItemType == ListItemType.AlternatingItem))
        {
            EndDate = DateTime.Parse(((Literal)e.Item.FindControl("ltlEndDate")).Text);
            if (EndDate < DateTime.Now)
            {
                ((Literal)e.Item.FindControl("ltlEndDate")).Text = Convert.ToDateTime(EndDate).ToShortDateString();
            }
            else { ((Literal)e.Item.FindControl("ltlEndDate")).Text = "..."; }
            string UserEmploymentID = ((HyperLink)e.Item.FindControl("hlRemoveEmployment")).NavigateUrl;
            ((HyperLink)e.Item.FindControl("hlRemoveEmployment")).NavigateUrl = this.OpenConfirm(PIKCV.COM.EnumDB.ErrorTypes.cDeleteEmployment, int.Parse(UserEmploymentID));
        } 
    }
    protected void ddlTotalWorkExperience_SelectedIndexChanged(object sender, EventArgs e)
    {
        PIKCV.BUS.UserCVs objUserCV = new PIKCV.BUS.UserCVs();
        if (objUserCV.SaveTotalWorkExperience(this.smUserID, int.Parse(ddlTotalWorkExperience.SelectedValue)))
        {
            this.smCVFocus = objUserCV.CVFocus(this.smUserID);
        }
        else
        {
            Response.Write("<script>alert('!Toplam Ýþ Deneyiminiz Kaydedilemedi.')</script>");
        }
    }
}
