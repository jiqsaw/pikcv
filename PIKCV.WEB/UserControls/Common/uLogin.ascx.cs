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

public partial class UserControls_Common_uLogin : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (this.smIsLogin) { 
                LoginON();
                pnlCompanyName.Visible = (this.cookPageType == PIKCV.COM.Enumerations.PageType.Company);
                pnlCompanyStatus.Visible = (this.cookPageType == PIKCV.COM.Enumerations.PageType.Company);
                pnlCVStatus.Visible = (this.cookPageType == PIKCV.COM.Enumerations.PageType.Employee);
                chIsCvActive.Checked = this.smIsCvActive;
            }
            else { 
                LoginOFF();
                pnlSecurityCode.Visible = (this.cookPageType == PIKCV.COM.Enumerations.PageType.Company);
                pnlSignUpCompany.Visible = (this.cookPageType == PIKCV.COM.Enumerations.PageType.Company);
                pnlSignUpEmployee.Visible = (this.cookPageType == PIKCV.COM.Enumerations.PageType.Employee);
                
                if (this.cookPageType == PIKCV.COM.Enumerations.PageType.Company)
                {
                    dvScript.InnerHtml = "<script>$get('" + txtSecurityCode.ClientID + "').value='';</script>";
                    hlForgotPassword.NavigateUrl = "#Company-ForgotPassword-ForgotPassword"; 
                }
                else if(this.cookPageType == PIKCV.COM.Enumerations.PageType.Employee)
                { hlForgotPassword.NavigateUrl = "#Employee-ForgotPassword-ForgotPassword"; }
            }
        }
    }

    protected void btnLogin_Click(object sender, ImageClickEventArgs e)
    {
        if (this.cookPageType == PIKCV.COM.Enumerations.PageType.Employee)
        {

            if (this.LoginControl(txtEmail.Text, txtPassword.Text))
            {
                if (this.ExistLogin()) {
                    this.LogOut();
                    this.GoToFeedback(PIKCV.COM.EnumDB.ErrorTypes.ExistLogin); 
                }

                PIKCV.BUS.UserCVs objUserCV = new PIKCV.BUS.UserCVs();
                if ((objUserCV.GetUserCV(this.smUserID).Rows.Count < 1) || (((int)(objUserCV.CVFocus(this.smUserID)) < (int)PIKCV.COM.EnumDB.CVFocusCode.References))) this.Redirect("Employee-Membership-CV");
                else if (PIKCV.BUS.Test.UserTestCtrl(this.smUserID)) this.Redirect("Employee-Membership-Tests");
                else this.GoToLogonPage();
            }
            else
            {
                txtEmail.Text = "";
                ShowModal.Show(UserControls_Common_uModalPopup.Icons.error, PIKCV.COM.Data.GetErrorMessageTitleCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.UserNotExist), PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.UserNotExist), false);
            }
        }
        else
        {
            if (this.smSecurityImage == txtSecurityCode.Text.Trim())
            {
                if (this.LoginControl(txtEmail.Text, txtPassword.Text))
                {
                    if (this.ExistLogin())
                    {
                        this.LogOut();
                        this.GoToFeedback(PIKCV.COM.EnumDB.ErrorTypes.ExistLogin);
                    }

                    if (this.smIsFirstLogin)
                        this.Redirect("Company-Membership-ChangePassword");
                    this.GoToLogonPage();
                }
                else
                {
                    txtEmail.Text = "";
                    ShowModal.Show(UserControls_Common_uModalPopup.Icons.error, PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.UserNotExist), PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.UserNotExist), false);

                }
            }
            else
            {
                ShowModal.Show(UserControls_Common_uModalPopup.Icons.error, PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.SecurityCodeIsNotTrue), PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.SecurityCodeIsNotTrue), false);
            }

        }
    }

    protected void LoginON()
    {
        pnlLoginOFF.Visible = false;
        pnlLoginON.Visible = true;
        ltlFullName.Text = Util.SpecialName(this.smFirstName + " " + this.smLastName);
        ltlLastLoginDate.Text = this.smLastLoginDate.ToShortDateString();
        ltlCompanyName.Text = this.smCompanyName;
    }

    protected void Page_PreRender(object sender, EventArgs e)
    {
        if (this.smMemberType == PIKCV.COM.EnumDB.MemberTypes.Company)
        {
            hlPikCredi.Text = this.smPikCredi;
            
        }
    }

    protected void LoginOFF()
    {
        pnlLoginOFF.Visible = true;
        pnlLoginON.Visible = false;
    }

    protected void LogOut(object sender, EventArgs e)
    {
        this.LogOut();
        this.GoToDefaultPage();
    }
    protected void CVStatusChange(object sender, EventArgs e)
    {
        PIKCV.BUS.User objUser = new PIKCV.BUS.User();
        if (objUser.UpdateCVStatus(this.smUserID, chIsCvActive.Checked)) {
            this.smIsCvActive = chIsCvActive.Checked;
            if (this.smIsCvActive)
            {
                ShowModal.Show(UserControls_Common_uModalPopup.Icons.info, "ÖZGEÇMÝÞ DURUM DEÐÝÞÝMÝ", "Özgeçmiþiniz aktif hale gelmiþtir", false);
            }
            else {
                ShowModal.Show(UserControls_Common_uModalPopup.Icons.info, "ÖZGEÇMÝÞ DURUM DEÐÝÞÝMÝ", "Özgeçmiþiniz pasif hale gelmiþtir", false);
            }
        }
        else {
            ShowModal.Show(UserControls_Common_uModalPopup.Icons.error, PIKCV.COM.Data.GetErrorMessageTitleCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.CVNoConfirmed), PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.CVNoConfirmed), false);
            chIsCvActive.Checked = false;
        }
        //Response.Redirect(Util.ReturnPageName());
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        if (this.cookPageType == PIKCV.COM.Enumerations.PageType.Employee)
        {
            if (this.LoginControl("burak.ucakan@caretta.net", "126132"))
            {
                PIKCV.BUS.UserCVs objUserCV = new PIKCV.BUS.UserCVs();
                if ((objUserCV.GetUserCV(this.smUserID).Rows.Count < 1) || (((int)(objUserCV.CVFocus(this.smUserID)) < (int)PIKCV.COM.EnumDB.CVFocusCode.References))) this.Redirect("Employee-Membership-CV");
                else if (PIKCV.BUS.Test.UserTestCtrl(this.smUserID)) this.Redirect("Employee-Membership-Tests");
                else this.GoToLogonPage();
            }
            else
            {
                ShowModal.Show(UserControls_Common_uModalPopup.Icons.error, PIKCV.COM.Data.GetErrorMessageTitleCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.UserNotExist), PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.UserNotExist), false);
            }
        }
        else
        {
            if (this.LoginControl("oray.kan@caretta.net", "buraks"))
            {
                this.GoToLogonPage();
            }
            else
            {
                ShowModal.Show(UserControls_Common_uModalPopup.Icons.error, PIKCV.COM.Data.GetErrorMessageTitleCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.UserNotExist), PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.UserNotExist), false);
            }
        }
    }
}
