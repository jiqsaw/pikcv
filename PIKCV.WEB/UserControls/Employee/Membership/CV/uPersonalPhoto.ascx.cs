using System;
using System.Data;
using System.Configuration;
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
using System.IO;
using System.Drawing;
using PIKCV.BUS;

public partial class UserControls_Employee_Membership_CV_uPersonalPhoto : BaseUserControl
{

    private string ImageUploded;

    protected void Page_Load(object sender, EventArgs e)
    {
        UImageUpload1.ImageUploaded += new UserControls_Common_uImageUpload.ImageUploadedDelegate(UImageUpload1_ImageUploaded);
        UImageUpload1.RaiseEvents = true;
        UImageUpload1.ImageTooSmall += new UserControls_Common_uImageUpload.ImageTooSmallDelegate(UImageUpload1_ImageTooSmall);
        if (!this.smIsLogin) { this.Redirect("Employee-Membership-CV"); }
        else
        {
            if (this.smPhotoFileName != String.Empty)
            {
                //if (this.smIsCvConfirmed) { this.Redirect("Employee-Membership-UserInfo"); }
                //else { this.Redirect("Employee-Membership-Tests"); }
                //imgUserPhoto.ImageUrl = "~/" + this.Config(PIKCV.COM.EnumUtil.Config.UserImagePath) + this.smPhotoFileName;
            }
            if (!IsPostBack)
            {
                imgUserPhoto.Attributes.Add("onerror", "this.src='" + this.Config(PIKCV.COM.EnumUtil.Config.UserImagePath) + "0.png';");
                FillImageDetail();
                UCVTabs1.TabActive(PIKCV.COM.Enumerations.CVTabs.Photo);
            }
        }
    }

    private void FillImageDetail()
    {
        UserCVs objUserCV = new UserCVs();
        DataTable dtUserCV = objUserCV.GetUserCV(smUserID);
        if (dtUserCV.Rows.Count > 0)
        {
            if (dtUserCV.Rows[0]["PhotoFileName"].ToString().Trim() != "")
            {
                imgUserPhoto.ImageUrl = "~/" + this.Config(PIKCV.COM.EnumUtil.Config.UserImagePath) + dtUserCV.Rows[0]["PhotoFileName"];
                if (this.smIsCvConfirmed)
                {
                    lbMessage.Text = "CV niz onaylandýktan sonra resminizi güncelleyemezsiniz.";
                }
                pnlMessage.Visible = true;
            }
            else
            {
                imgUserPhoto.ImageUrl = "~/Images/UserImages/0.png";
            }
        }
    }

    private void UImageUpload1_ImageUploaded(string FileName)
    {
        if (FileName != "")
        {
            UserCVs objUserCV = new UserCVs();

            ImageUploded = FileName;
            if (objUserCV.SaveUserPhoto(this.smUserID, ImageUploded))
            {
                imgUserPhoto.ImageUrl = "~/" + this.Config(PIKCV.COM.EnumUtil.Config.UserImagePath) + ImageUploded;
                this.smPhotoFileName = ImageUploded;
                dvScript.InnerHtml = "<script>alert('Özgeçmiþ bilgileriniz tamamlanmýþtýr. Test bölümünden devam edebilirsiniz. Teþekkürler');</script>";
                hplContinue.Visible = true;
                //Response.Write("<script>alert('" + strAlert + "');location.href='Pikcv.aspx?Pik=Employee-Membership-Tests';</script>");
                //this.Redirect("Employee-Membership-Tests");
            }
            else
            {
                lbMessage.Text = "Resim Yüklerken Bir Hata Oluþtu Lütfen Tekrar Deneyin";
            }
        }
        else
        { lbMessage.Text = "Resim Yüklerken Bir Hata Oluþtu Lütfen Tekrar Deneyin"; }
        pnlMessage.Visible = true;
    }

    private void UImageUpload1_ImageTooSmall()
    {
        dvScript.InnerHtml = "<script>alert('Girmiþ olduðunuz resim, sistemin izin verdiði en küçük resim ebatlarýndan daha küçüktür. Lütfen daha büyük bir resim giriniz');</script>";
    }
}
