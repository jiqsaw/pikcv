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

public partial class Pikcv : BasePage
{
    private int EmployeeSearch = 0;

    #region URLManagement
    private string m_uctFolderName = "UserControls";
    private string ReturnPhysicalPath(string FileName) {
        string m_FileName = (FileName.Replace("/", "\\").Split('&'))[0];
        return Request.PhysicalApplicationPath + this.m_uctFolderName + "\\" + m_FileName;
    }

    private void MemberCtrl(PIKCV.COM.EnumDB.MemberTypes MemberType) {
        if (Session[PIKCV.COM.EnumUtil.Sess.MemberType.ToString()] != null)
        {
            if (Session[PIKCV.COM.EnumUtil.Sess.MemberType.ToString()].ToString() != ((int)MemberType).ToString())
            {
                Session.Clear();
                Session.Abandon();
                PIKCV.COM.Util.GoToEntryPage(this.Response);
            }
        }
    }

    private void CookEmployee() {
        Cookie Cookie = new Cookie();
        Cookie.Write(PIKCV.COM.EnumUtil.Cookies.PageType, ((int)PIKCV.COM.EnumDB.MemberTypes.Employee).ToString());
        MemberCtrl(PIKCV.COM.EnumDB.MemberTypes.Employee);
    }

    private void CookCompany()
    {
        Cookie Cookie = new Cookie();
        Cookie.Write(PIKCV.COM.EnumUtil.Cookies.PageType, ((int)PIKCV.COM.EnumDB.MemberTypes.Company).ToString());
        MemberCtrl(PIKCV.COM.EnumDB.MemberTypes.Company);
    }

    private void CookUnknown()
    {
        Cookie Cookie = new Cookie();
        if (Cookie.Read(PIKCV.COM.EnumUtil.Cookies.PageType) == String.Empty) {
            CookEmployee();
        }
    }

    protected void Page_Init(object sender, EventArgs e)
    {
        string Url = Util.ApplicationRootPath() + "Pikcv.aspx?Pik=Common-Feedback&Code=" + (int)PIKCV.COM.EnumDB.ErrorTypes.AutomaticDisconnectMessage;
        Response.AddHeader("Refresh", ConfigurationManager.AppSettings["RefreshTime"].ToString() + "; URL=" + Url);
        EmployeeSearchCtrl();

        if (Util.IsString(Request.QueryString["Pik"]))
        {
            string Qstr = Request.QueryString["Pik"].ToString();

            //cookie ctrl
            string strCook = Qstr.Split('-')[0];

            if (strCook == PIKCV.COM.EnumDB.MemberTypes.Employee.ToString()) { CookEmployee(); }
            else if ((strCook == PIKCV.COM.EnumDB.MemberTypes.Company.ToString())) { CookCompany(); }
            else if (strCook == PIKCV.COM.EnumDB.MemberTypes.Common.ToString())
            {
                if (Session[PIKCV.COM.EnumUtil.Sess.MemberType.ToString()] == null) { CookUnknown(); }
                else
                {
                    if (this.Session[PIKCV.COM.EnumUtil.Sess.MemberType.ToString()].ToString() == ((int)PIKCV.COM.EnumDB.MemberTypes.Employee).ToString())
                    {
                        CookEmployee();
                    }
                    else { CookCompany(); }
                }
            }

            Qstr = Qstr.Substring(0, Qstr.LastIndexOf('-') + 1) + "u" + Qstr.Substring(Qstr.LastIndexOf('-') + 1);
            Qstr = Qstr.Replace('-', '/') + ".ascx";
            string PhysicalPath = ReturnPhysicalPath(Qstr);
            if (System.IO.File.Exists(PhysicalPath))
            {
                string ControlPath = "~/" + m_uctFolderName + "/" + Qstr;
                Control objCtrl = LoadControl(ControlPath);
                PH1.Controls.Clear();
                PH1.Controls.Add(objCtrl);
            }
        }
    }
    #endregion

    private void EmployeeSearchCtrl()
    {
        if (Util.IsNumeric(Request.QueryString["esr"]))
        { this.EmployeeSearch = int.Parse(Request.QueryString["esr"]); }

        if ((this.EmployeeSearch == 1) && (Session[PIKCV.COM.EnumUtil.Sess.MemberType.ToString()] != null) && ((PIKCV.COM.EnumDB.MemberTypes)(Session[PIKCV.COM.EnumUtil.Sess.MemberType.ToString()]) == PIKCV.COM.EnumDB.MemberTypes.Company))
        {
            string ControlPath = "~/UserControls/Company/Search/SearchResults/uLeftMenu.ascx";
            Control objCtrl = LoadControl(ControlPath);
            PHEmployeeSearch.Controls.Clear();
            PHEmployeeSearch.Controls.Add(objCtrl);
            PHEmployeeSearch.Visible = true;
            pnlStandart.Visible = false;
        }
        else
        {
            //Session[PIKCV.COM.EnumUtil.Sess.UserID.ToString()] = -1;
            pnlStandart.Visible = true;
            PHEmployeeSearch.Controls.Clear();
            PHEmployeeSearch.Visible = false;
        }
    }
}
