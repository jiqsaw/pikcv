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

public partial class UserControls_Company_Jobs_uJobs : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.IsLogin();
        if (!IsPostBack){
            hlJobType.NavigateUrl = hlJobType.NavigateUrl.Replace("||FocusNo||", ((int)PIKCV.COM.EnumDB.JobsFocusCode.JobType).ToString());
            hlPositionDefinition.NavigateUrl = hlPositionDefinition.NavigateUrl.Replace("||FocusNo||", ((int)PIKCV.COM.EnumDB.JobsFocusCode.PositionDefinition).ToString());
            hlEducationLevel.NavigateUrl = hlEducationLevel.NavigateUrl.Replace("||FocusNo||", ((int)PIKCV.COM.EnumDB.JobsFocusCode.EducationLevel).ToString());
            hlSeekingQuality.NavigateUrl = hlSeekingQuality.NavigateUrl.Replace("||FocusNo||", ((int)PIKCV.COM.EnumDB.JobsFocusCode.SeekingQuality).ToString());
            hlPreferencePriority.NavigateUrl = hlPreferencePriority.NavigateUrl.Replace("||FocusNo||", ((int)PIKCV.COM.EnumDB.JobsFocusCode.PreferencePriority).ToString());
            hlApproval.NavigateUrl = hlApproval.NavigateUrl.Replace("||FocusNo||", ((int)PIKCV.COM.EnumDB.JobsFocusCode.Approval).ToString());

            if (CARETTA.COM.Util.IsNumeric(Request.QueryString["JobID"]))
            {
                int JobID = Convert.ToInt32(Request.QueryString["JobID"]);
                if (JobID == 0) 
                { 
                    this.smJobID = 0;
                    this.smJobFocus = PIKCV.COM.EnumDB.JobsFocusCode.JobType;
                    this.smJobSaveType = PIKCV.COM.Enumerations.JobSaveType.NewJobEntry;
                }
                else
                {
                    PIKCV.BUS.Job obj = new PIKCV.BUS.Job();
                    DataTable dt = obj.GetJobInfo(JobID);
                    if (dt.Rows.Count > 0)
                    {
                        if (Convert.ToInt32(dt.Rows[0]["CompanyID"]) == this.smCompanyID)
                        {
                            this.smJobID = JobID;
                            this.smJobFocus = PIKCV.COM.EnumDB.JobsFocusCode.Approval;
                            if (CARETTA.COM.Util.IsNumeric(Request.QueryString["JobSaveType"]))
                            {
                                int JobSaveType = Convert.ToInt32(Request.QueryString["JobSaveType"]);
                                try
                                {
                                    this.smJobSaveType = (PIKCV.COM.Enumerations.JobSaveType)JobSaveType;
                                }
                                catch (Exception)
                                {
                                    this.GoToDefaultPage();
                                }
                            }
                            else { this.GoToDefaultPage(); }

                        }
                        else { this.GoToDefaultPage(); }
                    }
                }
            }
        }
        CtrlStep();

        ltlTitleNewJob.Visible = (this.smJobSaveType == PIKCV.COM.Enumerations.JobSaveType.NewJobEntry);
        ltlTitleEditJob.Visible = !ltlTitleNewJob.Visible;

        UJobsTabs1.TabActive(PIKCV.COM.Enumerations.JobsTabs.NewJobEntry);
    }

    void CtrlStep(){
        if (this.smIsLogin)
        {
            PIKCV.COM.EnumDB.JobsFocusCode JobFocus = PIKCV.COM.EnumDB.JobsFocusCode.JobType;
            //if (JobFocus != PIKCV.COM.EnumDB.JobsFocusCode.JobType)
            //{
            if (Util.IsString(Request.QueryString["JobFocus"]))
            {
                JobFocus = (PIKCV.COM.EnumDB.JobsFocusCode)(int.Parse(Request.QueryString["JobFocus"]));
                if ((int)this.smJobFocus < (int)JobFocus)
                    JobFocus = this.smJobFocus;
            }
            else
            {
                if ((int)JobFocus > (int)PIKCV.COM.EnumDB.JobsFocusCode.Approval)
                {
                    JobFocus = PIKCV.COM.EnumDB.JobsFocusCode.JobType;
                }
            }
            //}

            switch (this.smJobSaveType)
            {
                case PIKCV.COM.Enumerations.JobSaveType.NewJobEntry:
                    if ((int)JobFocus < (int)PIKCV.COM.EnumDB.JobsFocusCode.PositionDefinition) { li1.Attributes.Add("class", "selected"); }
                    else if ((int)JobFocus < (int)PIKCV.COM.EnumDB.JobsFocusCode.EducationLevel) { li2.Attributes.Add("class", "selected"); }
                    else if ((int)JobFocus < (int)PIKCV.COM.EnumDB.JobsFocusCode.SeekingQuality) { li3.Attributes.Add("class", "selected"); }
                    else if ((int)JobFocus < (int)PIKCV.COM.EnumDB.JobsFocusCode.PreferencePriority) { li4.Attributes.Add("class", "selected"); }
                    else if ((int)JobFocus < (int)PIKCV.COM.EnumDB.JobsFocusCode.Approval) { li5.Attributes.Add("class", "selected"); }
                    else { li6.Attributes.Add("class", "selected"); }
                    break;
                case PIKCV.COM.Enumerations.JobSaveType.Update:
                    if ((int)JobFocus < (int)PIKCV.COM.EnumDB.JobsFocusCode.PositionDefinition) { JobFocus = PIKCV.COM.EnumDB.JobsFocusCode.PositionDefinition; }
                    if ((int)JobFocus > (int)PIKCV.COM.EnumDB.JobsFocusCode.PreferencePriority) { JobFocus = PIKCV.COM.EnumDB.JobsFocusCode.PreferencePriority; }
                    if ((int)JobFocus < (int)PIKCV.COM.EnumDB.JobsFocusCode.EducationLevel) { li2.Attributes.Add("class", "selected"); }
                    else if ((int)JobFocus < (int)PIKCV.COM.EnumDB.JobsFocusCode.SeekingQuality) { li3.Attributes.Add("class", "selected"); }
                    else if ((int)JobFocus < (int)PIKCV.COM.EnumDB.JobsFocusCode.PreferencePriority) { li4.Attributes.Add("class", "selected"); }
                    else { li5.Attributes.Add("class", "selected"); }
                    break;
                case PIKCV.COM.Enumerations.JobSaveType.ArchiveOrDraft:
                    if ((int)JobFocus < (int)PIKCV.COM.EnumDB.JobsFocusCode.PositionDefinition) { JobFocus = PIKCV.COM.EnumDB.JobsFocusCode.PositionDefinition; }
                    if ((int)JobFocus > (int)PIKCV.COM.EnumDB.JobsFocusCode.PreferencePriority) { JobFocus = PIKCV.COM.EnumDB.JobsFocusCode.PreferencePriority; }
                    if ((int)JobFocus < (int)PIKCV.COM.EnumDB.JobsFocusCode.EducationLevel) { li2.Attributes.Add("class", "selected"); }
                    else if ((int)JobFocus < (int)PIKCV.COM.EnumDB.JobsFocusCode.SeekingQuality) { li3.Attributes.Add("class", "selected"); }
                    else if ((int)JobFocus < (int)PIKCV.COM.EnumDB.JobsFocusCode.PreferencePriority) { li4.Attributes.Add("class", "selected"); }
                    else { li5.Attributes.Add("class", "selected"); }
                    break;
            }


            string ControlPath = "~/UserControls/Company/Jobs/Jobs/u" + JobFocus.ToString() + ".ascx";
            try
            {
                Control objControl = new Control();
                objControl = LoadControl(ControlPath);
                PHCVFocus.Controls.Clear();
                PHCVFocus.Controls.Add(objControl);
            }
            catch (Exception) { }

            switch (this.smJobSaveType)
            {
                case PIKCV.COM.Enumerations.JobSaveType.NewJobEntry:
                    hlPositionDefinition.Enabled = ((int)this.smJobFocus > (int)PIKCV.COM.EnumDB.JobsFocusCode.JobType);
                    hlEducationLevel.Enabled = ((int)this.smJobFocus > (int)PIKCV.COM.EnumDB.JobsFocusCode.PositionDefinition);
                    hlSeekingQuality.Enabled = ((int)this.smJobFocus > (int)PIKCV.COM.EnumDB.JobsFocusCode.EducationLevel);
                    hlPreferencePriority.Enabled = ((int)this.smJobFocus > (int)PIKCV.COM.EnumDB.JobsFocusCode.SeekingQuality);
                    hlApproval.Enabled = ((int)this.smJobFocus > (int)PIKCV.COM.EnumDB.JobsFocusCode.PreferencePriority);
                    break;
                case PIKCV.COM.Enumerations.JobSaveType.Update:
                    hlApproval.Enabled = false;
                    hlJobType.Enabled = false;
                    hlEducationLevel.Enabled = true;
                    hlPositionDefinition.Enabled = true;
                    hlPreferencePriority.Enabled = true;
                    hlSeekingQuality.Enabled = true;
                    break;
                case PIKCV.COM.Enumerations.JobSaveType.ArchiveOrDraft:
                    hlApproval.Enabled = false;
                    hlJobType.Enabled = false;
                    hlEducationLevel.Enabled = true;
                    hlPositionDefinition.Enabled = true;
                    hlPreferencePriority.Enabled = true;
                    hlSeekingQuality.Enabled = true;
                    break;
            }

        }
    }
}
