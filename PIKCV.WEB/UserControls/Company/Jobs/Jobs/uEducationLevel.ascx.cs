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

public partial class UserControls_Company_Jobs_Jobs_uEducationLevel : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            imgContinue.Attributes.Add("onmousedown", PIKCV.COM.Util.SelectAllListboxScript(lbSelectedEducationLevel.ClientID, lbSelectedForeignLanguages.ClientID, lbSelectedComputerKnowledge.ClientID));
            imgSave.Attributes.Add("onmousedown", PIKCV.COM.Util.SelectAllListboxScript(lbSelectedEducationLevel.ClientID, lbSelectedForeignLanguages.ClientID, lbSelectedComputerKnowledge.ClientID));
            ArrangeAddRemoveButtons();
            FillForm();
            if (this.smJobSaveType == PIKCV.COM.Enumerations.JobSaveType.NewJobEntry)
            {
                imgContinue.Visible = true;
            }
            else
            { imgSave.Visible = true; }
        }
    }

    private void FillForm()
    {
        FillListBoxEducationLevel();
        FillListBoxForeignLanguages();
        FillListBoxComputerKnowledge();
    }

    private void ArrangeAddRemoveButtons()
    {
        imgAddToListEducationLevel.Style.Add("cursor", "pointer");
        imgRemoveToListEducationLevel.Style.Add("cursor", "pointer");
        imgAddToListEducationLevel.Attributes.Add("onclick", "SwapItem('" + lbEducationLevel.ClientID + "','" + lbSelectedEducationLevel.ClientID + "', ' ', '" + this.Config(PIKCV.COM.EnumUtil.Config.MaxJobEducationLevel) + "')");
        imgRemoveToListEducationLevel.Attributes.Add("onclick", "SwapItem('" + lbSelectedEducationLevel.ClientID + "','" + lbEducationLevel.ClientID + "', ' ')");
        imgAddToListLanguages.Style.Add("cursor", "pointer");
        imgRemoveToListLanguages.Style.Add("cursor", "pointer");
        imgAddToListLanguages.Attributes.Add("onclick", "SwapItem('" + lbForeignLanguages.ClientID + "','" + lbSelectedForeignLanguages.ClientID + "', ' ', '" + this.Config(PIKCV.COM.EnumUtil.Config.MaxJobForeignLanguage) + "')");
        imgRemoveToListLanguages.Attributes.Add("onclick", "SwapItem('" + lbSelectedForeignLanguages.ClientID + "','" + lbForeignLanguages.ClientID + "', ' ')");
        imgAddToListComputerKnowledge.Style.Add("cursor", "pointer");
        imgRemoveToListComputerKnowledge.Style.Add("cursor", "pointer");
        imgAddToListComputerKnowledge.Attributes.Add("onclick", "SwapItem('" + lbComputerKnowledge.ClientID + "','" + lbSelectedComputerKnowledge.ClientID + "', ' ', '" + this.Config(PIKCV.COM.EnumUtil.Config.MaxJobComputerKnowledge) + "')");
        imgRemoveToListComputerKnowledge.Attributes.Add("onclick", "SwapItem('" + lbSelectedComputerKnowledge.ClientID + "','" + lbComputerKnowledge.ClientID + "', ' ')");
    }

    private void FillListBoxEducationLevel()
    {
        PIKCV.BUS.Job objJob = new PIKCV.BUS.Job();
        DataTable dtJobEducationLevels = objJob.GetJobEducationLevels(this.smJobID, this.smLanguageID);
        DataBindHelper.BindListbox(ref lbSelectedEducationLevel, dtJobEducationLevels, "EducationLevelName", "EducationLevelID");

        DataTable dtEducationLevels = this.cmbEducationLevels;
        DataTable dtEducationLevelsNew = new DataTable();

        if (dtJobEducationLevels.Rows.Count > 0)
        {
            dtEducationLevelsNew.Columns.Add("EducationLevelID");
            dtEducationLevelsNew.Columns.Add("EducationLevelName");

            bool add = true;
            foreach (DataRow drCache in dtEducationLevels.Rows)
            {
                add = true;
                foreach (DataRow dr in dtJobEducationLevels.Rows)
                {
                    if (dr["EducationLevelID"].ToString() == drCache["EducationLevelID"].ToString())
                    {
                        add = false;
                        break;
                    }
                }
                if (add)
                {
                    DataRow drNew = dtEducationLevelsNew.NewRow();
                    drNew["EducationLevelID"] = drCache["EducationLevelID"].ToString();
                    drNew["EducationLevelName"] = drCache["EducationLevelName"].ToString();
                    dtEducationLevelsNew.Rows.Add(drNew);
                }
            }
        }
        else { dtEducationLevelsNew = dtEducationLevels.Copy(); }

        DataBindHelper.BindListbox(ref lbEducationLevel, dtEducationLevelsNew, "EducationLevelName", "EducationLevelID", "");
    }

    private void FillListBoxForeignLanguages()
    {
        PIKCV.BUS.Job objJob = new PIKCV.BUS.Job();
        DataTable dtJobForeignLanguages = objJob.GetJobForeignLanguages(this.smJobID, this.smLanguageID);
        DataBindHelper.BindListbox(ref lbSelectedForeignLanguages, dtJobForeignLanguages, "ForeignLanguageName", "ForeignLanguageID");

        DataTable dtForeignLanguages = this.cmbForeignLanguages;
        DataTable dtForeignLanguagesNew = new DataTable();

        if (dtJobForeignLanguages.Rows.Count > 0)
        {
            dtForeignLanguagesNew.Columns.Add("ForeignLanguageID");
            dtForeignLanguagesNew.Columns.Add("ForeignLanguageName");

            bool add = true;
            foreach (DataRow drCache in dtForeignLanguages.Rows)
            {
                add = true;
                foreach (DataRow dr in dtJobForeignLanguages.Rows)
                {
                    if (dr["ForeignLanguageID"].ToString() == drCache["ForeignLanguageID"].ToString())
                    {
                        add = false;
                        break;
                    }
                }
                if (add)
                {
                    DataRow drNew = dtForeignLanguagesNew.NewRow();
                    drNew["ForeignLanguageID"] = drCache["ForeignLanguageID"].ToString();
                    drNew["ForeignLanguageName"] = drCache["ForeignLanguageName"].ToString();
                    dtForeignLanguagesNew.Rows.Add(drNew);
                }
            }
        }
        else { dtForeignLanguagesNew = dtForeignLanguages.Copy(); }

        DataBindHelper.BindListbox(ref lbForeignLanguages, dtForeignLanguagesNew, "ForeignLanguageName", "ForeignLanguageID", "");
    }

    private void FillListBoxComputerKnowledge()
    {
        PIKCV.BUS.Job objJob = new PIKCV.BUS.Job();
        DataTable dtJobComputerKnowledge = objJob.GetJobComputerKnowledge(this.smJobID, this.smLanguageID);
        DataBindHelper.BindListbox(ref lbSelectedComputerKnowledge, dtJobComputerKnowledge, "ComputerKnowledgeTypeName", "ComputerKnowledgeTypeID");

        DataTable dtComputerKnowledge = this.cmbComputerKnowledgeTypes;
        DataTable dtComputerKnowledgeNew = new DataTable();

        if (dtJobComputerKnowledge.Rows.Count > 0)
        {
            dtComputerKnowledgeNew.Columns.Add("ComputerKnowledgeTypeID");
            dtComputerKnowledgeNew.Columns.Add("ComputerKnowledgeTypeName");

            bool add = true;
            foreach (DataRow drCache in dtComputerKnowledge.Rows)
            {
                add = true;
                foreach (DataRow dr in dtJobComputerKnowledge.Rows)
                {
                    if (dr["ComputerKnowledgeTypeID"].ToString() == drCache["ComputerKnowledgeTypeID"].ToString())
                    {
                        add = false;
                        break;
                    }
                }
                if (add)
                {
                    DataRow drNew = dtComputerKnowledgeNew.NewRow();
                    drNew["ComputerKnowledgeTypeID"] = drCache["ComputerKnowledgeTypeID"].ToString();
                    drNew["ComputerKnowledgeTypeName"] = drCache["ComputerKnowledgeTypeName"].ToString();
                    dtComputerKnowledgeNew.Rows.Add(drNew);
                }
            }
        }
        else { dtComputerKnowledgeNew = dtComputerKnowledge.Copy(); }

        DataBindHelper.BindListbox(ref lbComputerKnowledge, dtComputerKnowledgeNew, "ComputerKnowledgeTypeName", "ComputerKnowledgeTypeID", "");
    }

    protected void imgContinue_Click(object sender, ImageClickEventArgs e)
    {
        ArrayList arrSelectedEducationLevels = new ArrayList();
        ArrayList arrSelectedForeignLanguages = new ArrayList();
        ArrayList arrSelectedComputerKnowledges = new ArrayList();
        if (Request.Form[lbSelectedEducationLevel.UniqueID] != null)
        {
            arrSelectedEducationLevels.AddRange(Request.Form[lbSelectedEducationLevel.UniqueID].Split(','));
        }
        if (Request.Form[lbSelectedForeignLanguages.UniqueID] != null)
        {
            arrSelectedForeignLanguages.AddRange(Request.Form[lbSelectedForeignLanguages.UniqueID].Split(','));
        }
        if (Request.Form[lbSelectedComputerKnowledge.UniqueID] != null)
        {
            arrSelectedComputerKnowledges.AddRange(Request.Form[lbSelectedComputerKnowledge.UniqueID].Split(','));
        }
        PIKCV.BUS.Job objJob = new PIKCV.BUS.Job();
        if (objJob.SaveJobEducationLevelsAll(this.smJobID, arrSelectedEducationLevels, arrSelectedForeignLanguages, arrSelectedComputerKnowledges) == true)
        {
            pnlError.Visible = false;

            if (this.smJobSaveType == PIKCV.COM.Enumerations.JobSaveType.NewJobEntry)
            {
                this.smJobFocus = PIKCV.COM.EnumDB.JobsFocusCode.SeekingQuality;
                this.Redirect("Company-Jobs-Jobs&JobFocus=" + ((int)PIKCV.COM.EnumDB.JobsFocusCode.SeekingQuality).ToString());
            }
            else
            {
                Response.Write("<script>alert('Yapmýþ olduðunuz deðiþiklikler kaydedilmiþtir');window.location.href('pikcv.aspx?pik=Company-Jobs-Jobs&JobFocus=" + ((int)PIKCV.COM.EnumDB.JobsFocusCode.EducationLevel).ToString() + "');</script>");
            }
        }
        else
        {
            pnlError.Visible = true;
            ltlError.Text = "Kayýt sýrasýnda bir hata oluþtu lütfen tekrar deneyin";
        }
    }
}
