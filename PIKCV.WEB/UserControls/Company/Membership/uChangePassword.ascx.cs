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

public partial class UserControls_Company_Membership_uChangePassword : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (!(this.smIsLogin))
            {
                this.GoToDefaultPage();
            }
        }
    }

    protected void ImgBtnSend_Click(object sender, ImageClickEventArgs e)
    {
        PIKCV.BUS.Company objCompany = new PIKCV.BUS.Company();
        DataTable dtCompany = objCompany.GetCompanyInfo(this.smCompanyID);
        if (dtCompany.Rows.Count > 0)
        {
            if (txtPassword.Text != CARETTA.COM.Encryption.Decrypt(dtCompany.Rows[0]["Password"].ToString()))
            {
                if (objCompany.UpdateCompanyPassword(this.smCompanyID, txtPassword.Text, false))
                {
                    Response.Write("<script>alert('�ifreniz De�i�tirilmi�tir.');window.location.href('pikcv.aspx?pik=Company-CompanyLogon');</script>");
                }
                else
                {
                    Response.Write("<script>alert('�ifreniz De�i�tirilirken Bir Hata Olu�tu. L�tfen Tekrar Deneyin.');</script>");
                }
            }
            else
            {
                dvScript.InnerHtml = "<script>alert('L�tfen eski �ifrenizden farkl� bir �ifre giriniz.');</script>";
            }
        }
        else
        {
                Response.Write("<script>alert('�ifreniz De�i�tirilirken Bir Hata Olu�tu. L�tfen Tekrar Deneyin.');</script>");
        }
    }
}
