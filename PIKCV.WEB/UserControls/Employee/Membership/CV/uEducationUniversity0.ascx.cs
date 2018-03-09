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

public partial class UserControls_Employee_Membership_CV_uEducationUniversity0 : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) {
            hlAddSchool.NavigateUrl = hlAddSchool.NavigateUrl.Replace("||ST||", ((int)PIKCV.COM.EnumDB.EducationTypes.University0).ToString());
            UEducationNav1.SelectEducationTypes(PIKCV.COM.EnumDB.EducationTypes.University0);

            PIKCV.BUS.UserCVs objUserCV = new PIKCV.BUS.UserCVs();
            DataTable dtUserCV = objUserCV.GetUserCV(this.smUserID);
            ImgBtnContinue.Visible = !(Convert.ToInt32(dtUserCV.Rows[0]["CvFocusCode"]) > (int)PIKCV.COM.EnumDB.CVFocusCode.References);
        }
    }

    protected void Page_PreRender(object sender, EventArgs e)
    {
        PIKCV.BUS.UserCVs objUserEducation = new PIKCV.BUS.UserCVs();
        DataTable dtUserEducation = objUserEducation.GetUserEducations(this.smUserID, PIKCV.COM.EnumDB.EducationTypes.University0, PIKCV.COM.EnumDB.LanguageID.Turkish, false);
        pnlNoRecord.Visible = (dtUserEducation.Rows.Count < 1);
        pnlUniversity0List.Visible = !pnlNoRecord.Visible;
        rptUniversity0List.DataSource = dtUserEducation;
        rptUniversity0List.DataBind();
    }

    protected void ImgBtnContinue_Click(object sender, ImageClickEventArgs e)
    {
        this.Redirect("Employee-Membership-CV&CVFocus=" + ((int)PIKCV.COM.EnumDB.CVFocusCode.EducationHighSchool).ToString());  
    }
    protected void rptUniversity0List_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if ((e.Item.ItemType == ListItemType.Item) || (e.Item.ItemType == ListItemType.AlternatingItem))
        {
            HyperLink hlEdit = ((HyperLink)e.Item.FindControl("hlEditSchool"));
            hlEdit.NavigateUrl = hlEdit.NavigateUrl.Replace("||ST||", ((int)PIKCV.COM.EnumDB.EducationTypes.University0).ToString());
        }
    }
    protected void rptUniversity0List_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "Delete") {
            PIKCV.BUS.UserCVs objUserCV = new PIKCV.BUS.UserCVs();
            objUserCV.RemoveUserEducation(Convert.ToInt32(e.CommandArgument));
        }
    }
}
