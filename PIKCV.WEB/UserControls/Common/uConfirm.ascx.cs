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

public partial class UserControls_Common_uConfirm : BaseUserControl
{
    public PIKCV.COM.EnumDB.ErrorTypes ErrorType
    {
        get { return (PIKCV.COM.EnumDB.ErrorTypes)(int.Parse(ViewState["ErrorType"].ToString())); }
        set { ViewState["ErrorType"] = (int)value; }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (CARETTA.COM.Util.IsNumeric(Request.QueryString["Code"]))
            {
                this.ErrorType = (PIKCV.COM.EnumDB.ErrorTypes)(int.Parse(Request.QueryString["Code"]));
                ShowMessage();
            }
        }
    }

    private void ShowMessage()
    {
        DataRow drError = PIKCV.COM.Data.GetErrorCache(this.cmbErrors, this.ErrorType);
        lblTitle.Text = drError["ErrorTitle"].ToString();
        dvMessage.InnerHtml = drError["Message"].ToString();
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        PIKCV.BUS.UserCVs objUserCV = new PIKCV.BUS.UserCVs();
        switch (this.ErrorType)
        {
            case PIKCV.COM.EnumDB.ErrorTypes.cRemoveMemberShip:
                if (PIKCV.BUS.User.RemoveUser(this.smUserID)) { this.LogOut(); Finish(PIKCV.COM.EnumDB.ErrorTypes.RemoveUser); }
                else Finish(PIKCV.COM.EnumDB.ErrorTypes.Error);
                break;
            case PIKCV.COM.EnumDB.ErrorTypes.cDeleteMessage:
                if (Util.IsNumeric(Request.QueryString["ArgID"]))
                {
                    if (PIKCV.BUS.Messages.DeleteMesssage((Convert.ToInt32(Request.QueryString["ArgID"]))))
                    { Finish(PIKCV.COM.EnumDB.ErrorTypes.DeleteMessageSuccess); }
                    else Finish(PIKCV.COM.EnumDB.ErrorTypes.Error);
                }
                break;
            case PIKCV.COM.EnumDB.ErrorTypes.cCancelApplicant:
                PIKCV.BUS.JobApplicants obj = new PIKCV.BUS.JobApplicants();
                int JobApplicantID = Convert.ToInt32(Request.QueryString["ArgID"]);
                DataTable dt = PIKCV.BUS.JobApplicants.GetJobApplicantDetails(JobApplicantID);
                if (dt.Rows.Count > 0)
                {
                    if (!obj.ReceivedCtrl(this.smUserID, JobApplicantID))
                    {
                        if (PIKCV.BUS.JobApplicants.ChangeUserJobApplicantStatus(JobApplicantID, PIKCV.COM.EnumDB.JobApplicationStates.RecievedBack))
                        {
                            Finish(PIKCV.COM.EnumDB.ErrorTypes.CancelApplicantSuccess);
                        }
                        else
                        {
                            Finish(PIKCV.COM.EnumDB.ErrorTypes.Error);
                        }
                    }
                    else
                    {
                        Finish(PIKCV.COM.EnumDB.ErrorTypes.CancenApplicantBefore);
                    }
                }
                break;
            case PIKCV.COM.EnumDB.ErrorTypes.cDeleteFilter:
                if (Util.IsNumeric(Request.QueryString["ArgID"]))
                {
                    if (PIKCV.BUS.Filters.RemoveFilter((Convert.ToInt32(Request.QueryString["ArgID"]))))
                    { Finish(PIKCV.COM.EnumDB.ErrorTypes.DeleteFilterSuccess); }
                    else Finish(PIKCV.COM.EnumDB.ErrorTypes.Error);
                }
                break;
            case PIKCV.COM.EnumDB.ErrorTypes.cDeleteEducation:
                PIKCV.COM.EnumDB.EducationTypes EducationType = (PIKCV.COM.EnumDB.EducationTypes)int.Parse(Request.QueryString["ArgStr"]);

                switch (EducationType)
                {
                    case PIKCV.COM.EnumDB.EducationTypes.MiddleSchool:
                        objUserCV.RemoveUserMiddleSchool(Convert.ToInt32(Request.QueryString["ArgID"]));
                        break;
                    case PIKCV.COM.EnumDB.EducationTypes.HighSchool:
                        objUserCV.RemoveUserHighSchool(Convert.ToInt32(Request.QueryString["ArgID"]));
                        break;
                    case PIKCV.COM.EnumDB.EducationTypes.University0:
                        objUserCV.RemoveUserEducation(Convert.ToInt32(Request.QueryString["ArgID"]));
                        break;
                    case PIKCV.COM.EnumDB.EducationTypes.University1:
                        objUserCV.RemoveUserEducation(Convert.ToInt32(Request.QueryString["ArgID"]));
                        break;
                    case PIKCV.COM.EnumDB.EducationTypes.University2:
                        objUserCV.RemoveUserEducation(Convert.ToInt32(Request.QueryString["ArgID"]));
                        break;
                    case PIKCV.COM.EnumDB.EducationTypes.Doktorate:
                        objUserCV.RemoveUserEducation(Convert.ToInt32(Request.QueryString["ArgID"]));
                        break;
                    default:
                        break;
                }
                Finish(PIKCV.COM.EnumDB.ErrorTypes.DeleteEducationSuccess);
                break;
            case PIKCV.COM.EnumDB.ErrorTypes.cDeleteEmployment:
                if (Util.IsNumeric(Request.QueryString["ArgID"]))
                {
                    if (objUserCV.RemoveUserEmployment((Convert.ToInt32(Request.QueryString["ArgID"]))))
                    { Finish(PIKCV.COM.EnumDB.ErrorTypes.DeleteEmploymentSuccess); }
                    else Finish(PIKCV.COM.EnumDB.ErrorTypes.Error);
                }
                break;
            case PIKCV.COM.EnumDB.ErrorTypes.cDeleteForeignLanguages:
                if (Util.IsNumeric(Request.QueryString["ArgID"]))
                {
                    if (objUserCV.RemoveUserLanguage((Convert.ToInt32(Request.QueryString["ArgID"]))))
                    { Finish(PIKCV.COM.EnumDB.ErrorTypes.DeleteForeignLanguagesSuccess); }
                    else Finish(PIKCV.COM.EnumDB.ErrorTypes.Error);
                }
                break;
            case PIKCV.COM.EnumDB.ErrorTypes.cDeleteReference:
                if (Util.IsNumeric(Request.QueryString["ArgID"]))
                {
                    if (objUserCV.RemoveUserReference((Convert.ToInt32(Request.QueryString["ArgID"]))))
                    { Finish(PIKCV.COM.EnumDB.ErrorTypes.DeleteReferenceSuccess); }
                    else Finish(PIKCV.COM.EnumDB.ErrorTypes.Error);
                }
                break;
            case PIKCV.COM.EnumDB.ErrorTypes.cJobApplicantUnsuitabilitySet:
                if (Util.IsNumeric(Request.QueryString["ArgID"]))
                {
                    if (PIKCV.BUS.JobApplicants.ChangeUserJobApplicantStatus(Convert.ToInt32(Request.QueryString["ArgID"]), PIKCV.COM.EnumDB.JobApplicationStates.Unsuitability))
                    { Finish(PIKCV.COM.EnumDB.ErrorTypes.JobApplicantUnsuitabilitySetSuccess); }
                    else { Finish(PIKCV.COM.EnumDB.ErrorTypes.Error); }
                }
                break;
        }
    }

    protected void Finish(PIKCV.COM.EnumDB.ErrorTypes ErrorType) {
        tblFinish.Visible = true;
        tblConfirm.Visible = false;
        dvMessageFinish.InnerHtml = PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, ErrorType);
    }



}