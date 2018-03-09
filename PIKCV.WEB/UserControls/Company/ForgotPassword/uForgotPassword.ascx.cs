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

public partial class UserControls_Company_ForgotPassword_uForgotPassword : BaseUserControl
{
    public int fpCompanyID
    {
        get { return (ViewState["fpCID"] == null ? -1 : int.Parse(ViewState["fpCID"].ToString())); }
        set { ViewState["fpCID"] = value; }
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ImgBtnSend_Click(object sender, ImageClickEventArgs e)
    {
        PIKCV.BUS.Company objCompany = new PIKCV.BUS.Company();
        DataRow drCompany = null;
        if (trEmail.Visible)
        {
            drCompany = objCompany.GetCompanyByEmail(txtEmail.Text);
            if (drCompany != null)
            {
                trEmail.Visible = false;
                trSecretQuestion.Visible = true;
                trSecretAnswer.Visible = true;
                this.fpCompanyID = Convert.ToInt32(drCompany["CompanyID"]);
                ltlSecretQuestion.Text = drCompany["SecretQuestion"].ToString();
                ltlInfoMessage.Text = "�ifreniz gizli soruya verdi�iniz cevaptan sonra e-posta adresinize g�nderilecektir";
            }
            else
            {
                Response.Write("<script>alert('Bu email adresi ile kay�tl� kullan�c� bulunamad�!')</script>");
            }
        }
        else if (trSecretQuestion.Visible)
        {
              DataTable dtCompanyDetail = objCompany.GetCompanyInfo(this.fpCompanyID);
              if (dtCompanyDetail.Rows[0]["SecretAnswer"].ToString() == txtSecretAnswer.Text.Trim())
              {
                  string Pass = Encryption.Decrypt(dtCompanyDetail.Rows[0]["Password"].ToString());
                  string Email = dtCompanyDetail.Rows[0]["UserName"].ToString();
                  
                if (MailTemplates.Send_Tmp_ForgotPassCompany(MailTemplates.ForgotPasswordCompany, Pass, dtCompanyDetail.Rows[0]["ContactName"].ToString(), dtCompanyDetail.Rows[0]["ContactLastName"].ToString(), Email))
                {
                    objCompany.UpdateCompanyPassword(this.fpCompanyID, Pass, true);
                    this.GoToFeedback(PIKCV.COM.EnumDB.ErrorTypes.ForgotPassword);
                }
                else
                {
                    Response.Write("<script>alert('�ifreniz Email Adresinize G�nderirken Hata Olu�tu')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Gizli cevab�n�z yanl��!')</script>");
            }
        }
    }
}
