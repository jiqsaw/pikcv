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

public class BaseCompany : BaseControl, IBaseControl
{
    string IBaseControl.Show()
    {
        return "Company";
    }

    void IBaseControl.GoToDefaultPage()
    {
        HttpContext.Current.Response.Redirect("~/" + this.Config(EnumUtil.Config.PageNameCompany));
    }

    bool IBaseControl.LoginControl(string Email, string Password)
    {
        PIKCV.BUS.Company objCompany = new PIKCV.BUS.Company();
        DataTable dt = objCompany.LoginControl(Email, Password);
        if (dt.Rows.Count > 0)
        {
            this.smIsLogin = true;
            this.smCompanyID = Convert.ToInt32(dt.Rows[0]["CompanyID"]);
            this.smFirstName = dt.Rows[0]["ContactName"].ToString();
            this.smLastName = dt.Rows[0]["ContactLastName"].ToString();
            this.smCompanyName = dt.Rows[0]["CompanyName"].ToString();
            this.smLastLoginDate = Convert.ToDateTime(dt.Rows[0]["LastLoginDate"]);
            this.smPikCredi = dt.Rows[0]["Credits"].ToString();
            this.smMemberType = PIKCV.COM.EnumDB.MemberTypes.Company;
            this.smIsFirstLogin = Convert.ToBoolean(dt.Rows[0]["IsFirstLogin"]);
            return true;
        }
        return false;
    }

    void IBaseControl.GoToLogonPage()
    {
        HttpContext.Current.Response.Redirect("~/" + this.Config(EnumUtil.Config.PageNameCompanyLogon));
    }

    void IBaseControl.IsLogin()
    {
        if (this.smMemberType != EnumDB.MemberTypes.Company) {
            HttpContext.Current.Response.Redirect("~/" + this.Config(EnumUtil.Config.PageNameCompanyMembership));
        }
    }
}
