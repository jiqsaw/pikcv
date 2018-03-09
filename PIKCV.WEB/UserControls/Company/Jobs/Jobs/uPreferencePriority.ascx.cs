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

public partial class UserControls_Company_Jobs_Jobs_uPreferencePriority : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        FillDropDowns();
        FillDetails();

        if (this.smJobSaveType == PIKCV.COM.Enumerations.JobSaveType.NewJobEntry)
        {
            imgContinue.Visible = true;
        }
        else
        { imgSave.Visible = true; }
    }

    private void FillDropDowns()
    {
        DataBindHelper.BindDDL(ref drpEducationLevel1, this.cmbEducationLevels, "EducationLevelName", "EducationLevelID", "", "Lütfen Seçiniz", "0");
        DataBindHelper.BindDDL(ref drpEducationLevel2, this.cmbEducationLevels, "EducationLevelName", "EducationLevelID", "", "Lütfen Seçiniz", "0");
        DataBindHelper.BindDDL(ref drpEducationLevel3, this.cmbEducationLevels, "EducationLevelName", "EducationLevelID", "", "Lütfen Seçiniz", "0");
        DataBindHelper.BindDDL(ref drpPositions1, this.cmbPositions, "PositionName", "PositionID", "", "Lütfen Seçiniz", "0");
        DataBindHelper.BindDDL(ref drpPositions2, this.cmbPositions, "PositionName", "PositionID", "", "Lütfen Seçiniz", "0");
        DataBindHelper.BindDDL(ref drpPositions3, this.cmbPositions, "PositionName", "PositionID", "", "Lütfen Seçiniz", "0");
        DataBindHelper.BindDDL(ref drpForeignLanguage1, this.cmbForeignLanguages, "ForeignLanguageName", "ForeignLanguageID", "", "Lütfen Seçiniz", "0");
        DataBindHelper.BindDDL(ref drpForeignLanguage2, this.cmbForeignLanguages, "ForeignLanguageName", "ForeignLanguageID", "", "Lütfen Seçiniz", "0");
        DataBindHelper.BindDDL(ref drpForeignLanguage3, this.cmbForeignLanguages, "ForeignLanguageName", "ForeignLanguageID", "", "Lütfen Seçiniz", "0");

        DataBindHelper.BindDDL(ref drpReadLevel1, this.cmbLevels, "LevelName", "LevelID", "", "Lütfen Seçiniz", "-1");
        DataBindHelper.BindDDL(ref drpReadLevel2, this.cmbLevels, "LevelName", "LevelID", "", "Lütfen Seçiniz", "-1");
        DataBindHelper.BindDDL(ref drpReadLevel3, this.cmbLevels, "LevelName", "LevelID", "", "Lütfen Seçiniz", "-1");
        DataBindHelper.BindDDL(ref drpWriteLevel1, this.cmbLevels, "LevelName", "LevelID", "", "Lütfen Seçiniz", "-1");
        DataBindHelper.BindDDL(ref drpWriteLevel2, this.cmbLevels, "LevelName", "LevelID", "", "Lütfen Seçiniz", "-1");
        DataBindHelper.BindDDL(ref drpWriteLevel3, this.cmbLevels, "LevelName", "LevelID", "", "Lütfen Seçiniz", "-1");
        DataBindHelper.BindDDL(ref drpTalkLevel1, this.cmbLevels, "LevelName", "LevelID", "", "Lütfen Seçiniz", "-1");
        DataBindHelper.BindDDL(ref drpTalkLevel2, this.cmbLevels, "LevelName", "LevelID", "", "Lütfen Seçiniz", "-1");
        DataBindHelper.BindDDL(ref drpTalkLevel3, this.cmbLevels, "LevelName", "LevelID", "", "Lütfen Seçiniz", "-1");

        DataBindHelper.LoadNumberDDL(ref drpEducationLevel1ChoiceLevel1, -1, 1, -3);
        DataBindHelper.LoadNumberDDL(ref drpEducationLevel1ChoiceLevel2, -1, 1, -3);
        DataBindHelper.LoadNumberDDL(ref drpEducationLevel1ChoiceLevel3, -1, 1, -3);

        DataBindHelper.LoadNumberDDL(ref drpWorkExperianceChoiceLevel1, -1, 1, -3);
        DataBindHelper.LoadNumberDDL(ref drpWorkExperianceChoiceLevel2, -1, 1, -3);
        DataBindHelper.LoadNumberDDL(ref drpWorkExperianceChoiceLevel3, -1, 1, -3);
        
        DataBindHelper.LoadNumberDDL(ref drpForeignLanguageChoiceLevel1, -1, 1, -3);
        DataBindHelper.LoadNumberDDL(ref drpForeignLanguageChoiceLevel2, -1, 1, -3);
        DataBindHelper.LoadNumberDDL(ref drpForeignLanguageChoiceLevel3, -1, 1, -3);

        drpEducationLevel1ChoiceLevel1.Items.Insert(0, new ListItem("...", "0"));
        drpEducationLevel1ChoiceLevel2.Items.Insert(0, new ListItem("...", "0"));
        drpEducationLevel1ChoiceLevel3.Items.Insert(0, new ListItem("...", "0"));

        drpWorkExperianceChoiceLevel1.Items.Insert(0, new ListItem("...", "0"));
        drpWorkExperianceChoiceLevel2.Items.Insert(0, new ListItem("...", "0"));
        drpWorkExperianceChoiceLevel3.Items.Insert(0, new ListItem("...", "0"));

        drpForeignLanguageChoiceLevel1.Items.Insert(0, new ListItem("...", "0"));
        drpForeignLanguageChoiceLevel2.Items.Insert(0, new ListItem("...", "0"));
        drpForeignLanguageChoiceLevel3.Items.Insert(0, new ListItem("...", "0"));
    }

    private void FillDetails()
    {
        PIKCV.BUS.Job obj = new PIKCV.BUS.Job();
        DataTable dt = obj.GetJobChoiceEducationLevel(this.smJobID);
        if (dt.Rows.Count > 0)
        {
            drpEducationLevel1.SelectedValue = dt.Rows[0]["EducationLevelID"].ToString();
            drpEducationLevel1ChoiceLevel1.SelectedValue = dt.Rows[0]["Points"].ToString();
            if (dt.Rows.Count > 1)
            {
                drpEducationLevel2.SelectedValue = dt.Rows[1]["EducationLevelID"].ToString();
                drpEducationLevel1ChoiceLevel2.SelectedValue = dt.Rows[1]["Points"].ToString();
                if (dt.Rows.Count > 2)
                {
                    drpEducationLevel3.SelectedValue = dt.Rows[2]["EducationLevelID"].ToString();
                    drpEducationLevel1ChoiceLevel3.SelectedValue = dt.Rows[2]["Points"].ToString();
                }
            }
        }
        dt = obj.GetJobChoiceEmployment(this.smJobID);
        if (dt.Rows.Count > 0)
        {
            drpPositions1.SelectedValue = dt.Rows[0]["PositionID"].ToString();
            drpWorkExperianceChoiceLevel1.SelectedValue = dt.Rows[0]["Points"].ToString();
            if (dt.Rows.Count > 1)
            {
                drpPositions2.SelectedValue = dt.Rows[1]["PositionID"].ToString();
                drpWorkExperianceChoiceLevel2.SelectedValue = dt.Rows[1]["Points"].ToString();
                if (dt.Rows.Count > 2)
                {
                    drpPositions3.SelectedValue = dt.Rows[2]["PositionID"].ToString();
                    drpWorkExperianceChoiceLevel3.SelectedValue = dt.Rows[2]["Points"].ToString();
                }
            }
        }
        dt = obj.GetJobChoiceForeignLanguages(this.smJobID);
        if (dt.Rows.Count > 0)
        {
            drpForeignLanguage1.SelectedValue = dt.Rows[0]["ForeignLanguageID"].ToString();
            drpReadLevel1.SelectedValue = dt.Rows[0]["ReadLevel"].ToString();
            drpWriteLevel1.SelectedValue = dt.Rows[0]["WriteLevel"].ToString();
            drpTalkLevel1.SelectedValue = dt.Rows[0]["SpeakLevel"].ToString();
            drpForeignLanguageChoiceLevel1.SelectedValue = dt.Rows[0]["Points"].ToString();
            if (dt.Rows.Count > 1)
            {
                drpForeignLanguage2.SelectedValue = dt.Rows[1]["ForeignLanguageID"].ToString();
                drpReadLevel2.SelectedValue = dt.Rows[1]["ReadLevel"].ToString();
                drpWriteLevel2.SelectedValue = dt.Rows[1]["WriteLevel"].ToString();
                drpTalkLevel2.SelectedValue = dt.Rows[1]["SpeakLevel"].ToString();
                drpForeignLanguageChoiceLevel2.SelectedValue = dt.Rows[1]["Points"].ToString();
                if (dt.Rows.Count > 2)
                {
                    drpForeignLanguage3.SelectedValue = dt.Rows[2]["ForeignLanguageID"].ToString();
                    drpReadLevel3.SelectedValue = dt.Rows[2]["ReadLevel"].ToString();
                    drpWriteLevel3.SelectedValue = dt.Rows[2]["WriteLevel"].ToString();
                    drpTalkLevel3.SelectedValue = dt.Rows[2]["SpeakLevel"].ToString();
                    drpForeignLanguageChoiceLevel3.SelectedValue = dt.Rows[2]["Points"].ToString();
                }
            }
        }
    }

    protected void imgContinue_Click(object sender, ImageClickEventArgs e)
    {
        PIKCV.BUS.Job objJob = new PIKCV.BUS.Job();
        objJob.DeleteJobChoices(this.smJobID);
        if (drpEducationLevel1.SelectedValue != "0" && drpEducationLevel1ChoiceLevel1.SelectedValue != "0")
            objJob.SaveJobChoiceEducationLevel(this.smJobID, drpEducationLevel1.SelectedValue, drpEducationLevel1ChoiceLevel1.SelectedValue);
        if (drpEducationLevel2.SelectedValue != "0" && drpEducationLevel1ChoiceLevel2.SelectedValue != "0")
            objJob.SaveJobChoiceEducationLevel(this.smJobID, drpEducationLevel2.SelectedValue, drpEducationLevel1ChoiceLevel2.SelectedValue);
        if (drpEducationLevel3.SelectedValue != "0" && drpEducationLevel1ChoiceLevel3.SelectedValue != "0")
            objJob.SaveJobChoiceEducationLevel(this.smJobID, drpEducationLevel3.SelectedValue, drpEducationLevel1ChoiceLevel3.SelectedValue);
        if (drpForeignLanguage1.SelectedValue != "0" && drpWorkExperianceChoiceLevel1.SelectedValue != "0")
            objJob.SaveJobChoiceEmployment(this.smJobID, drpPositions1.SelectedValue, drpWorkExperianceChoiceLevel1.SelectedValue);
        if (drpForeignLanguage2.SelectedValue != "0" && drpWorkExperianceChoiceLevel2.SelectedValue != "0")
            objJob.SaveJobChoiceEmployment(this.smJobID, drpPositions2.SelectedValue, drpWorkExperianceChoiceLevel2.SelectedValue);
        if (drpForeignLanguage3.SelectedValue != "0" && drpWorkExperianceChoiceLevel3.SelectedValue != "0")
            objJob.SaveJobChoiceEmployment(this.smJobID, drpPositions3.SelectedValue, drpWorkExperianceChoiceLevel3.SelectedValue);
        if (drpForeignLanguage1.SelectedValue != "0" && drpWriteLevel1.SelectedValue != "-1" && drpReadLevel1.SelectedValue != "-1" && drpTalkLevel1.SelectedValue != "-1" && drpForeignLanguageChoiceLevel1.SelectedValue != "0")
            objJob.SaveJobChoiceForeignLanguages(this.smJobID, drpForeignLanguage1.SelectedValue, drpReadLevel1.SelectedValue, drpWriteLevel1.SelectedValue, drpTalkLevel1.SelectedValue, drpForeignLanguageChoiceLevel1.SelectedValue);
        if (drpForeignLanguage2.SelectedValue != "0" && drpWriteLevel2.SelectedValue != "-1" && drpReadLevel2.SelectedValue != "-1" && drpTalkLevel2.SelectedValue != "-1" && drpForeignLanguageChoiceLevel2.SelectedValue != "0")
            objJob.SaveJobChoiceForeignLanguages(this.smJobID, drpForeignLanguage2.SelectedValue, drpReadLevel2.SelectedValue, drpWriteLevel2.SelectedValue, drpTalkLevel2.SelectedValue, drpForeignLanguageChoiceLevel2.SelectedValue);
        if (drpForeignLanguage3.SelectedValue != "0" && drpWriteLevel3.SelectedValue != "-1" && drpReadLevel3.SelectedValue != "-1" && drpTalkLevel3.SelectedValue != "-1" && drpForeignLanguageChoiceLevel3.SelectedValue != "0")
            objJob.SaveJobChoiceForeignLanguages(this.smJobID, drpForeignLanguage3.SelectedValue, drpReadLevel3.SelectedValue, drpWriteLevel3.SelectedValue, drpTalkLevel3.SelectedValue, drpForeignLanguageChoiceLevel3.SelectedValue);

        if (this.smJobSaveType == PIKCV.COM.Enumerations.JobSaveType.NewJobEntry)
        {
            this.smJobFocus = PIKCV.COM.EnumDB.JobsFocusCode.Approval;
            this.Redirect("Company-Jobs-Jobs&JobFocus=" + ((int)PIKCV.COM.EnumDB.JobsFocusCode.Approval).ToString());
        }
        else
        {
            Response.Write("<script>alert('Yapmýþ olduðunuz deðiþiklikler kaydedilmiþtir');window.location.href('pikcv.aspx?pik=Company-Jobs-Jobs&JobFocus=" + ((int)PIKCV.COM.EnumDB.JobsFocusCode.PreferencePriority).ToString() + "');</script>");
        }


        

    }
}
