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

public partial class UserControls_Employee_Signup_uUserInfo : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        imgUserPhoto.ImageUrl = "~/Images/UserImages/";
        if (!IsPostBack)
        {
            SetEmployeeExaminet();
            //imgUserPhoto.Attributes.Add("onerror", "this.src='Images/UserImages/0.png';");
            txtEMail.ReadOnly = (this.smIsLogin);
            txtIdentityNo.ReadOnly = (this.smIsLogin);
            UCVTabs1.TabActive(PIKCV.COM.Enumerations.CVTabs.UserInfo);
        }
        if (this.smIsLogin) { 
            ltlDescription.Text = "Lütfen istediðiniz alanlarý güncelleyiniz";
            pnlPrivacy.Enabled = false;
            hlRemoveUser.NavigateUrl = this.OpenConfirm(PIKCV.COM.EnumDB.ErrorTypes.cRemoveMemberShip, 0);
        }
        trRemoveUser.Visible = this.smIsLogin;
    }

    protected void ShowError(string Msg)
    {
        pnlError.Visible = true;
        ltlError.Text = Msg;
    }

    protected void Page_PreRender(object sender, EventArgs e)
    {
        PIKCV.BUS.User objUser = new PIKCV.BUS.User();
        if (this.smIsLogin)
        {
            DataTable dtUser = objUser.GetUserDetail(this.smUserID);
            if (dtUser.Rows.Count > 0)
            {
                if (this.smMemberType == PIKCV.COM.EnumDB.MemberTypes.Employee)
                {
                    txtName.Text = dtUser.Rows[0]["FirstName"].ToString();
                    txtSurName.Text = dtUser.Rows[0]["LastName"].ToString();
                    txtEMail.Text = dtUser.Rows[0]["Email"].ToString();
                    txtIdentityNo.Text = dtUser.Rows[0]["IdentityNo"].ToString();
                    txtPrivateQuestion.Text = dtUser.Rows[0]["SecretQuestion"].ToString();
                    txtPrivateAnswer.Text = dtUser.Rows[0]["SecretAnswer"].ToString();
                    chIsWantedSMS.Checked = Convert.ToBoolean(dtUser.Rows[0]["IsWantedSMS"]);
                    dvScript.InnerHtml = "<script>document.getElementById('chAggreement').checked = true; document.getElementById('chPrivacy').checked = true;</script>";
                    rqrPass.Enabled = false;
                    rqrPass2.Enabled = false;
                    CustomValidatorPassword.Enabled = false;
                    pnlCompany.Visible = false;
                    pnlEmployee.Visible = true;

                    ltlTitle.Visible = false;
                    ltlTitle2.Visible = false;
                    ltlTitle3.Visible = true;
                }
                else if (this.smMemberType == PIKCV.COM.EnumDB.MemberTypes.Company || this.smMemberType == PIKCV.COM.EnumDB.MemberTypes.TemporaryUser)
                {
                    lblPersonnelNameHeader.Text = "Adý:";
                    lblPersonnelSurnameHeader.Text = "Soyadý:";

                    trMsg.Visible = false;
                    lblName.Text = dtUser.Rows[0]["FirstName"].ToString();
                    lblSurName.Text = dtUser.Rows[0]["LastName"].ToString();

                    ltlTitle.Visible = false;
                    ltlTitle2.Visible = true;
                    ltlTitle2.Text = Util.SpecialName(lblName.Text + " " + lblSurName.Text);
                    ltlTitle3.Visible = false;

                    pnlEmployee.Visible = false;
                    pnlCompany.Visible = true;

                    // Get Company Folders
                    DataTable dtCOmpanyFolders = new DataTable();
                    PIKCV.BUS.Company Comp = new PIKCV.BUS.Company();
                    dtCOmpanyFolders = Comp.GetCompanyFolders(this.smCompanyID, false, false);
                    CARETTA.COM.DataBindHelper.BindDDL(ref ddlCompanyFolders, dtCOmpanyFolders, "FolderName", "FolderID", "", PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.SendFolder), "0");
                    
                    // Önceden bu herifin bilgileri alýnmýþ mý?
                    if (this.smMemberType == PIKCV.COM.EnumDB.MemberTypes.Company)
                    {
                        imgBuyContactInfo.Visible = !(CheckBuyContactInfo(this.smCompanyID, this.smUserID));
                        liInterview.Visible = !(imgBuyContactInfo.Visible);
                        liSendMessage.Visible = !(imgBuyContactInfo.Visible);
                    }
                    else
                    {
                        imgBuyContactInfo.Visible = false;
                        liInterview.Visible = false;
                        liSendMessage.Visible = false;
                        ddlCompanyFolders.Visible = false;
                        liSentToFile.Visible = false;
                    }
                    
                    // Pozisyon
                    PIKCV.BUS.UserCVs objUserCV = new PIKCV.BUS.UserCVs();
                    DataTable dtUserPositions = new DataTable();
                    dtUserPositions = objUserCV.GetUserPositions(this.smUserID, (int)this.smLanguageID);
                    DataBindHelper.BindRepeater(ref rptUserPositions, dtUserPositions);
                    
                    // Tecrübe
                    DataTable dtUserCV = new DataTable();
                    dtUserCV = objUserCV.GetUserCV(this.smUserID);
                    int UserAge = DateTime.Now.Year - (Convert.ToDateTime(dtUserCV.Rows[0]["BirthDate"]).Year);
                    lblAge.Text = UserAge.ToString();

                    if (!imgBuyContactInfo.Visible)
                    {
                        trAddress.Visible = true;
                        trEmail.Visible = true;
                        trPhoto.Visible = true;
                        lblAddress.Text = dtUserCV.Rows[0]["HomeAddress"].ToString();
                        lblPhone.Text = dtUserCV.Rows[0]["HomePhone"].ToString();
                        lblEmail.Text = dtUser.Rows[0]["Email"].ToString();
                    }
                    else {
                        trAddress.Visible = false;
                        trEmail.Visible = false;
                        trPhoto.Visible = false;
                    }

                    ltlTotalWorkExperience.Text = dtUserCV.Rows[0]["TotalWorkExperience"].ToString();
                    this.smPhotoFileName = dtUserCV.Rows[0]["PhotoFileName"].ToString();
                }
            }
        }

        imgUserPhoto.ImageUrl += this.smPhotoFileName;
        if (!(System.IO.File.Exists(Request.MapPath(imgUserPhoto.ImageUrl))))
        {
            imgUserPhoto.ImageUrl = "~/Images/UserImages/0.png";
        }

        //txtPassword.Text = "Pass" + Util.CreateRandomNumber(6);
        //txtPassword2.Text = txtPassword.Text;
        //txtIdentityNo.Text = Util.CreateRandomNumber(11);
        //txtPrivateQuestion.Text = "Soru" + Util.CreateRandomNumber(5);
        //txtPrivateAnswer.Text = "Cevap" + Util.CreateRandomNumber(5);
    }

    protected void imgContinue_Click(object sender, ImageClickEventArgs e)
    {
        string ErrMsg = String.Empty;
        string Email = txtEMail.Text.Trim();
        string Password = txtPassword.Text.Trim();
        string IdentityNo = txtIdentityNo.Text.Trim();

        if (Util.isNeedClearString(Email)) { ErrMsg += PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.ValidationEmail); }
        if (Util.isNeedClearString(Password)) { ErrMsg += PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.ValidationPassword); }
        if (Util.isNeedClearString(IdentityNo)) { ErrMsg += PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.ValidationIdentity); }

        if (ErrMsg == String.Empty)
        {
            PIKCV.BUS.User objUser = new PIKCV.BUS.User();

            if ((this.smIsLogin) || (!objUser.UserExist(Email, IdentityNo)))
            {
                int SavedUserID = objUser.SaveUserInfo(this.smUserID, txtName.Text, txtSurName.Text, Email, IdentityNo, Password, txtPrivateQuestion.Text, txtPrivateAnswer.Text, chIsWantedSMS.Checked);
                this.smFirstName = txtName.Text;
                this.smLastName = txtSurName.Text;
                if (SavedUserID > 0)
                {
                    if (!this.smIsLogin)
                    {
                        string ActivationCode = PIKCV.COM.Util.CreateActivationNumber(SavedUserID);
                        if (objUser.SaveActivation(SavedUserID, ActivationCode))
                        {
                            //Aktivasyon Linkini Mail Yolla 
                            if (MailTemplates.Send_Tmp_Activation(MailTemplates.Activation, ActivationCode, SavedUserID, this.smFirstName, this.smLastName, Email))
                            {
                                this.Redirect("Employee-Membership-CV");    //2.Adýma Yönlendir 
                            }
                            else
                            {
                                ErrMsg += PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.OkSaveNoSendMail); //**
                            }
                        }
                    }
                    else
                    {
                        this.Redirect("Employee-Membership-CV");
                    }
                }
                else
                {
                    ErrMsg += PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.NoSave);
                }
            }
            else
            {
                ErrMsg += PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.UserExist);
            }
        }
        this.ShowError(ErrMsg);
    }

    #region Eleman Arama

    private void SetEmployeeExaminet()
    {
        if (Util.IsNumeric(Request.QueryString["JobApplicantID"]))
        {
            PIKCV.BUS.JobApplicants.ChangeUserJobApplicantStatus(Convert.ToInt32(Request.QueryString["JobApplicantID"]), PIKCV.COM.EnumDB.JobApplicationStates.Examinet);
        }
    }

    private bool CheckBuyContactInfo()
    {
        PIKCV.BUS.Company Comp = new PIKCV.BUS.Company();
        DataTable dtCompanyOwnedUsers = new DataTable();
        dtCompanyOwnedUsers = Comp.GetCompanyOwnedUsers(this.smCompanyID);
        if (dtCompanyOwnedUsers.Rows.Count == 0)
            return false;
        return true;
    }

    private bool CheckBuyContactInfo(int CompanyID, int UserID)
    {
        PIKCV.BUS.Company Comp = new PIKCV.BUS.Company();
        return Comp.CheckBuyContactInfo(CompanyID, UserID);
    }

    protected void lbSendMessage_Click(object sender, EventArgs e)
    {
        ArrayList arr = new ArrayList(1);
        arr.Insert(0, this.smUserID);
        this.smMessageUserIDs = arr;
        this.Redirect("Company-Messages-SendMessage");
    }

    protected void lbPrint_Click(object sender, EventArgs e)
    {
        //Response.Write("javascript.window.print('burak');");
    }

    protected void imgBuyContactInfo_Click(object sender, ImageClickEventArgs e)
    {
        PIKCV.BUS.Company objComp = new PIKCV.BUS.Company();
        ArrayList arrUserID = new ArrayList();
        arrUserID.Add(this.smUserID);
        PIKCV.COM.Enumerations.BuyContactInfoResult BuyComtactInfoResult = objComp.BuyContactInfo(this.smCompanyID, arrUserID, 0);
        string err = String.Empty;
        switch (BuyComtactInfoResult)
        {
            case PIKCV.COM.Enumerations.BuyContactInfoResult.Success:
                DataTable dt = objComp.GetCompanyInfo(this.smCompanyID);
                if (dt.Rows.Count > 0)
                    this.smPikCredi = dt.Rows[0]["Credits"].ToString();
                //Response.Write("<script>alert('" + PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.BuyContactInfo) + this.smPikCredi + "');</script>");
                err = "alert('" + PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.BuyContactInfo) + this.smPikCredi + "');";
                break;
            case PIKCV.COM.Enumerations.BuyContactInfoResult.Failed:
                //Response.Write("<script>alert('" + PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.BuyContactInfoFailed) + "');</script>");
                err = "alert('" + PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.BuyContactInfoFailed) + "');";
                break;
            case PIKCV.COM.Enumerations.BuyContactInfoResult.NotEnoughPikCredi:
                this.Redirect("Company-Jobs-Jobs-NoCredit");
                //Response.Write("<script>alert('" + PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.NoCredit) + "');" + "window.location.href('Pikcv.aspx?Pik=Company-Credits-SelectPaymentType');" + "</script>");
                break;
        }
        if (err != String.Empty) { dvScript.InnerHtml = "<script>" + err + "</script>"; }
    }

    #endregion

    protected void lnkSendToFolder_Click(object sender, EventArgs e)
    {
        string ErrMsg = String.Empty;
        PIKCV.BUS.Company Comp = new PIKCV.BUS.Company();
        ArrayList arr = new ArrayList(1);
        arr.Insert(0, this.smUserID);
        if (Comp.InsertUsersToFolder(Convert.ToInt32(ddlCompanyFolders.SelectedValue), arr))
        {
            ErrMsg = PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.SendToFolderSuccess);
        }
        else
        {
            ErrMsg = PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.SendToFolderFailed);
        }
        dvScript.InnerHtml = "<script>alert('" + ErrMsg + "');</script>";
    }
    protected void lbInterview_Click(object sender, EventArgs e)
    {
        ArrayList arr = new ArrayList(1);
        arr.Insert(0, this.smUserID);
        this.smInterviewUserIDs = arr;
        Response.Write("<script>window.open('InsertInterview.aspx', 'PikcvMülakataÇaðýr', 'width=550,height=500,toolbar=no');</script>");
    }
}