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

public partial class UserControls_Employee_ForgotPassword_uForgotPassword : BaseUserControl
{
    private int MaxSecretAnswerCount = 3;
    public int fpUserID
    {
        get { return (ViewState["fpUserID"] == null ? -1 : int.Parse(ViewState["fpUserID"].ToString())); }
        set { ViewState["fpUserID"] = value; }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        Cookie objCook = new Cookie();
        if (objCook.Read(PIKCV.COM.EnumUtil.Cookies.UserIP) == Request.ServerVariables["REMOTE_ADDR"].ToString()) {
            this.GoToFeedback(PIKCV.COM.EnumDB.ErrorTypes.SecretAnswerNoLimit);
        }
    }
    protected void ImgBtnSend_Click(object sender, ImageClickEventArgs e)
    {
        PIKCV.BUS.User objUser = new PIKCV.BUS.User();
        DataRow drUser = null;
        if (trEmail.Visible)
        {
            drUser = objUser.GetUserByEmail(txtEmail.Text);
            if (drUser != null)
            {
                trEmail.Visible = false;
                trSecretQuestion.Visible = true;
                trSecretAnswer.Visible = true;
                this.fpUserID = Convert.ToInt32(drUser["UserID"]);
                ltlSecretQuestion.Text = drUser["SecretQuestion"].ToString();
                ltlInfoMessage.Text = "Þifreniz gizli soruya verdiðiniz cevaptan sonra e-posta adresinize gönderilecektir";
            }
            else
            {
                Response.Write("<script>alert('Bu eposta adresi ile kayýtlý kullanýcý bulunamadý!')</script>");
            }
        }
        else if (trSecretQuestion.Visible)
        {
            DataTable dtUserDetail = objUser.GetUserDetail(this.fpUserID);
            if (dtUserDetail.Rows[0]["SecretAnswer"].ToString() == txtSecretAnswer.Text.Trim())
            {
                string Pass = Encryption.Decrypt(dtUserDetail.Rows[0]["Password"].ToString());
                string Email = dtUserDetail.Rows[0]["Email"].ToString();
                if (MailTemplates.Send_Tmp_ForgotPass(MailTemplates.ForgotPassword, Pass, dtUserDetail.Rows[0]["FirstName"].ToString(), dtUserDetail.Rows[0]["LastName"].ToString(), Email))
                {
                    //Response.Write("<script>alert('Þifreniz Email Adresinize Gönderildi')</script>");
                    //this.GoToDefaultPage();
                    this.GoToFeedback(PIKCV.COM.EnumDB.ErrorTypes.ForgotPassword);
                }
                else
                {
                    Response.Write("<script>alert('Þifreniz Email Adresinize Gönderirken Hata Oluþtu')</script>");
                }
            }
            else
            {
                this.smSecretAnswerCount++;

                if (this.smSecretAnswerCount >= MaxSecretAnswerCount) {
                    Cookie objCook = new Cookie();
                    objCook.Write(PIKCV.COM.EnumUtil.Cookies.UserIP, Request.ServerVariables["REMOTE_ADDR"].ToString());
                }
                dvScript.InnerHtml = "<script>alert('Gizli sorunuzun cevabýný yanlýþ girdiniz, tekrar giriþ yapýnýz')</script>";
            }
        }
    }
}