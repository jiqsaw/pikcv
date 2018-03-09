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

public partial class UserControls_Employee_Membership_CV_uEducationUniversity2 : BaseUserControl
{
    private PIKCV.COM.EnumDB.EducationTypes EducationType = PIKCV.COM.EnumDB.EducationTypes.University2;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            hlAddSchool.NavigateUrl = hlAddSchool.NavigateUrl.Replace("||ST||", ((int)this.EducationType).ToString());
            UEducationNav1.SelectEducationTypes(this.EducationType);
            PIKCV.BUS.UserCVs objUserCV = new PIKCV.BUS.UserCVs();
            DataTable dtUserCV = objUserCV.GetUserCV(this.smUserID);
            ImgBtnContinue.Visible = !(Convert.ToInt32(dtUserCV.Rows[0]["CvFocusCode"]) > (int)PIKCV.COM.EnumDB.CVFocusCode.References);
        }
    }

    protected void Page_PreRender(object sender, EventArgs e)
    {
        PIKCV.BUS.UserCVs objUserEducation = new PIKCV.BUS.UserCVs();
        DataTable dtUserEducation = objUserEducation.GetUserEducations(this.smUserID, EducationType, PIKCV.COM.EnumDB.LanguageID.Turkish, false);
        pnlNoRecord.Visible = (dtUserEducation.Rows.Count < 1);
        pnlUniversityList.Visible = !pnlNoRecord.Visible;
        rptUniversityList.DataSource = dtUserEducation;
        rptUniversityList.DataBind();
    }

    protected void ImgBtnContinue_Click(object sender, ImageClickEventArgs e)
    {
        this.Redirect("Employee-Membership-CV&CVFocus=" + ((int)PIKCV.COM.EnumDB.CVFocusCode.EducationUniversity1).ToString());
    }
    protected void rptUniversityList_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if ((e.Item.ItemType == ListItemType.Item) || (e.Item.ItemType == ListItemType.AlternatingItem))
        {
            HyperLink hlEdit = ((HyperLink)e.Item.FindControl("hlEditSchool"));
            hlEdit.NavigateUrl = hlEdit.NavigateUrl.Replace("||ST||", ((int)EducationType).ToString());
        }
    }
    protected void rptUniversityList_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "Delete")
        {
            PIKCV.BUS.UserCVs objUserCV = new PIKCV.BUS.UserCVs();
            objUserCV.RemoveUserEducation(Convert.ToInt32(e.CommandArgument));
        }
    }
}