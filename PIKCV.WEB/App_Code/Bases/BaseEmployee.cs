using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using PIKCV.COM;

public class BaseEmployee : BaseControl, IBaseControl
{
    string IBaseControl.Show()
    {
        return "Employee";
    }

    void IBaseControl.GoToDefaultPage()
    {
        HttpContext.Current.Response.Redirect("~/" + this.Config(EnumUtil.Config.PageNameEmployee));
    }

    bool IBaseControl.LoginControl(string Email, string Password)
    {
        PIKCV.BUS.User objUser = new PIKCV.BUS.User();

        if (objUser.LoginControl(Email, Password))
        {
            this.smUserID = objUser.UserID;
            this.smIsLogin = true;
            this.smEmployeeType = objUser.EmployeeType;
            this.smFirstName = objUser.FirstName;
            this.smIsEmailConfirmed = objUser.IsEmailConfirmed;
            this.smIsCvActive = objUser.IsCVActive;
            this.smIsCvConfirmed = objUser.IsCVConfirmed;
            this.smLastLoginDate = objUser.LastLoginDate;
            this.smLastName = objUser.LastName;
            this.smUserEmail = objUser.Email;
            this.smMemberType = PIKCV.COM.EnumDB.MemberTypes.Employee;

            PIKCV.BUS.UserCVs objUserCvs = new PIKCV.BUS.UserCVs();
            DataTable dtUserCV = objUserCvs.GetUserCV(this.smUserID);
            if (dtUserCV.Rows.Count < 1)
            {
                this.smCVFocus = PIKCV.COM.EnumDB.CVFocusCode.PersonalInfo;
                this.smPhotoFileName = String.Empty;
            }
            else
            {
                this.smCVFocus = (PIKCV.COM.EnumDB.CVFocusCode)(Convert.ToInt32(dtUserCV.Rows[0]["CvFocusCode"]));
                this.smPhotoFileName = dtUserCV.Rows[0]["PhotoFileName"].ToString().Trim();
            }
            return true;
        }
        return false;
    }

    void IBaseControl.GoToLogonPage()
    {
        HttpContext.Current.Response.Redirect("~/" + this.Config(EnumUtil.Config.PageNameEmployeeLogon));
    }

    void IBaseControl.IsLogin()
    {
        if (this.smMemberType != EnumDB.MemberTypes.Employee)
        {
            HttpContext.Current.Response.Redirect("~/" + this.Config(EnumUtil.Config.PageNameEmployeeMembership));
        }
    }
}
