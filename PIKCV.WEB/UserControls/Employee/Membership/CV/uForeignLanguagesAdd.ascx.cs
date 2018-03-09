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

public partial class UserControls_Employee_Membership_CV_uForeignLanguagesAdd : BaseUserControl
{
    public int UserLanguageID
    {
        get { return (ViewState["UserLanguageID"] == null ? 0 : int.Parse(ViewState["UserLanguageID"].ToString())); }
        set { ViewState["UserLanguageID"] = value; }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataBindHelper.BindDDL(ref ddlForeignLanguages, this.cmbForeignLanguages, "ForeignLanguageName", "ForeignLanguageID", "-1", PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.InitialText), "-1");
            DataBindHelper.BindDDL(ref ddlRead, this.cmbLevels, "LevelName", "LevelID", "");
            DataBindHelper.BindDDL(ref ddlSpeak, this.cmbLevels, "LevelName", "LevelID", "");
            DataBindHelper.BindDDL(ref ddlWrite, this.cmbLevels, "LevelName", "LevelID", "");
            DataBindHelper.BindDDL(ref ddlForeignLanguageExams, this.cmbForeignLanguageExams, "ForeignLanguageExamName", "ForeignLanguageExamID", "0", "Yok", "0");
        }
    }


    protected void Page_PreRender(object sender, EventArgs e)
    {
        if (CARETTA.COM.Util.IsNumeric(Request.QueryString["UserLanguageID"]))
        {
            this.UserLanguageID = int.Parse(Request.QueryString["UserLanguageID"]);
            PIKCV.BUS.UserCVs objUserLanguage = new PIKCV.BUS.UserCVs();
            DataTable dtUserLanguage = objUserLanguage.GetUserLanguageDetail(this.UserLanguageID);
            if (dtUserLanguage.Rows.Count > 0)
            {
                FillData(dtUserLanguage);
            }
        }
    }

    private void FillData(DataTable dt)
    {
        txtPlaceLearned.Text = dt.Rows[0]["PlaceLearned"].ToString();
        ddlForeignLanguages.SelectedValue = dt.Rows[0]["ForeignLanguageID"].ToString();
        ddlRead.SelectedValue = dt.Rows[0]["ReadLevelID"].ToString();
        ddlWrite.SelectedValue = dt.Rows[0]["WriteLevelID"].ToString();
        ddlSpeak.SelectedValue = dt.Rows[0]["SpeakLevelID"].ToString();
        ddlForeignLanguageExams.SelectedValue = dt.Rows[0]["ForeignLanguageExamID"].ToString();
        txtExamDegree.Text = dt.Rows[0]["ExamDegree"].ToString(); 
    }
    protected void ImgBtnSave_Click(object sender, ImageClickEventArgs e)
    {

        PIKCV.BUS.UserCVs objUserCV = new PIKCV.BUS.UserCVs();
        if (objUserCV.SaveUserLanguage(this.UserLanguageID, this.smUserID, int.Parse(ddlForeignLanguages.SelectedValue), int.Parse(ddlRead.SelectedValue), 
            int.Parse(ddlWrite.SelectedValue), int.Parse(ddlSpeak.SelectedValue), txtPlaceLearned.Text, int.Parse(ddlForeignLanguageExams.SelectedValue), txtExamDegree.Text))
        {
            this.smCVFocus = PIKCV.COM.EnumDB.CVFocusCode.ComputerKnowledge;
            ShowModal.Show(UserControls_Common_uModalPopup.Icons.alert, PIKCV.COM.EnumDB.ErrorTypes.UpdateCV, true, true);
        }
        else {
            ShowModal.Show(UserControls_Common_uModalPopup.Icons.alert, PIKCV.COM.EnumDB.ErrorTypes.NoUpdateCV, true, true);
        }
    }
}