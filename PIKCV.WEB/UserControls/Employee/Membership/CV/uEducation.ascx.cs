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

public partial class UserControls_Employee_Membership_CV_uEducation : BaseUserControl
{
    private DataTable dtUserCV;
    protected void Page_Load(object sender, EventArgs e)
    {
        hlAddSchool.Visible = true;
        hlAddMiddleSchool.Visible = true;
        if (!IsPostBack)
        {
            PIKCV.BUS.UserCVs objUserCV = new PIKCV.BUS.UserCVs();
            this.dtUserCV = objUserCV.GetUserCV(this.smUserID);
            if (dtUserCV.Rows.Count > 0)
            {
                FillData(this.dtUserCV);
                ddlEducationTypes.SelectedValue = this.dtUserCV.Rows[0]["EducationTypeCode"].ToString();
            }
        }
    }

    private void FillData(DataTable dt) { 
        PIKCV.BUS.UserCVs objUserEducation = new PIKCV.BUS.UserCVs();
        DataTable dtUserEducation = objUserEducation.GetUserEducationList(this.smUserID, PIKCV.COM.EnumDB.EducationStates.Graduate, PIKCV.COM.EnumDB.LanguageID.Turkish, false);
        pnlNoRecord.Visible = (dtUserEducation.Rows.Count < 1);
        pnlEducationList.Visible = !pnlNoRecord.Visible;
        rptEducationList.DataSource = dtUserEducation;
        rptEducationList.DataBind();

        foreach (DataRow dr in dtUserEducation.Rows)
        {
            if (((PIKCV.COM.EnumDB.EducationTypes)(Convert.ToInt32(dr["EducationLevelID"]))) == PIKCV.COM.EnumDB.EducationTypes.MiddleSchool) {
                hlAddMiddleSchool.Visible = false;
            }
            else if (((PIKCV.COM.EnumDB.EducationTypes)(Convert.ToInt32(dr["EducationLevelID"]))) == PIKCV.COM.EnumDB.EducationTypes.HighSchool) {
                hlAddHighSchool.Visible = false;
            }
        }

    }

    protected void ImgBtnContinue_Click(object sender, ImageClickEventArgs e)
    {
        PIKCV.COM.EnumDB.EducationTypes EducationType = (PIKCV.COM.EnumDB.EducationTypes)(int.Parse(ddlEducationTypes.SelectedValue));
        PIKCV.BUS.UserCVs objUserCV = new PIKCV.BUS.UserCVs();
        if (objUserCV.SaveEducationType(this.smUserID, EducationType)) {

            this.smCVFocus = objUserCV.CVFocus(this.smUserID);
            this.Redirect("Employee-Membership-CV&CVFocus=" + ((int)PIKCV.COM.EnumDB.CVFocusCode.Employment).ToString());
        }
        else {
            Response.Write("<script>alert('!Bilgileriniz kaydedilemedi.')</script>");
        }
    }
    protected void rptEducationList_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        //PIKCV.COM.EnumDB.EducationTypes EducationType = (PIKCV.COM.EnumDB.EducationTypes)int.Parse(((HiddenField)e.Item.FindControl("hdEducationLevelID")).Value);
        //if (e.CommandName == "Delete")
        //{
        //    PIKCV.BUS.UserCVs objUserCV = new PIKCV.BUS.UserCVs();

        //    switch (EducationType)
        //    {
        //        case PIKCV.COM.EnumDB.EducationTypes.MiddleSchool:
        //            objUserCV.RemoveUserMiddleSchool(Convert.ToInt32(e.CommandArgument));
        //            break;
        //        case PIKCV.COM.EnumDB.EducationTypes.HighSchool:
        //            objUserCV.RemoveUserHighSchool(Convert.ToInt32(e.CommandArgument));
        //            break;
        //        case PIKCV.COM.EnumDB.EducationTypes.University0:
        //            objUserCV.RemoveUserEducation(Convert.ToInt32(e.CommandArgument));
        //            break;
        //        case PIKCV.COM.EnumDB.EducationTypes.University1:
        //            objUserCV.RemoveUserEducation(Convert.ToInt32(e.CommandArgument));
        //            break;
        //        case PIKCV.COM.EnumDB.EducationTypes.University2:
        //            objUserCV.RemoveUserEducation(Convert.ToInt32(e.CommandArgument));
        //            break;
        //        case PIKCV.COM.EnumDB.EducationTypes.Doktorate:
        //            objUserCV.RemoveUserEducation(Convert.ToInt32(e.CommandArgument));
        //            break;
        //        default:
        //            break;
        //    }

        //    FillData(this.dtUserCV);
        //}
    }
    protected void rptEducationList_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if ((e.Item.ItemType == ListItemType.Item) || (e.Item.ItemType == ListItemType.AlternatingItem))
        {
            PIKCV.COM.EnumDB.EducationTypes EducationType = (PIKCV.COM.EnumDB.EducationTypes)int.Parse(((HiddenField)e.Item.FindControl("hdEducationLevelID")).Value);
            string OrgLink = ((HyperLink)e.Item.FindControl("hlEditSchool")).NavigateUrl;
            if (EducationType == PIKCV.COM.EnumDB.EducationTypes.HighSchool) { 
                ((HyperLink)e.Item.FindControl("hlEditSchool")).NavigateUrl = OrgLink.Replace("||Popup||", "EducationHighSchool");
            }
            else if (EducationType == PIKCV.COM.EnumDB.EducationTypes.MiddleSchool)
            {
                ((HyperLink)e.Item.FindControl("hlEditSchool")).NavigateUrl = OrgLink.Replace("||Popup||", "EducationMiddleSchool");
            }
            else {
                ((HyperLink)e.Item.FindControl("hlEditSchool")).NavigateUrl = OrgLink.Replace("||Popup||", "EducationUniversityAdd");
            }

            ((HyperLink)e.Item.FindControl("hlEditSchool")).NavigateUrl = ((HyperLink)e.Item.FindControl("hlEditSchool")).NavigateUrl.Replace("||ET||", ((int)EducationType).ToString());


            int UserOREducationID = int.Parse(((HyperLink)e.Item.FindControl("hlRemoveSchool")).NavigateUrl);
            ((HyperLink)e.Item.FindControl("hlRemoveSchool")).NavigateUrl = this.OpenConfirm(PIKCV.COM.EnumDB.ErrorTypes.cDeleteEducation, UserOREducationID, ((int)EducationType).ToString());
        }
    }
}