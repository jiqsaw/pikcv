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

public partial class UserControls_Common_uNotice : BaseUserControl
{
    protected void Page_Init(object sender, EventArgs e)
    {
        if (this.smIsLogin)
        {
            pnlCompany.Visible = (this.smMemberType == PIKCV.COM.EnumDB.MemberTypes.Company);

            if (this.smMemberType == PIKCV.COM.EnumDB.MemberTypes.Employee){
                pnlEmployee.Visible = ((PIKCV.BUS.Test.UserTestPerfectionCtrl(this.smUserID)) && (!PIKCV.BUS.Test.UserTestCtrl(this.smUserID)) && (this.smIsCvConfirmed) && (this.smEmployeeType == PIKCV.COM.EnumDB.EmployeeTypes.Pikpool));
            }
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (this.cookPageType == PIKCV.COM.Enumerations.PageType.Company)
                FillCompanyDetails();
        }
    }

    private void FillCompanyDetails()
    {
        PIKCV.BUS.Company objCompany = new PIKCV.BUS.Company();
        DataTable dtCompany = objCompany.GetCompanyInfo(this.smCompanyID);
        PIKCV.BUS.SystemUsers objSystemUser = new PIKCV.BUS.SystemUsers();
        if (dtCompany.Rows.Count > 0)
        {
            DataTable dtSystemUser = objSystemUser.GetSystemUser(1);
            if (dtSystemUser.Rows.Count > 0)
            {
                hlEmail.NavigateUrl += dtSystemUser.Rows[0]["Email"].ToString();
                hlEmail.Text = dtSystemUser.Rows[0]["Email"].ToString();
                lbLastName.Text = dtSystemUser.Rows[0]["LastName"].ToString();
                lbFirstName.Text = dtSystemUser.Rows[0]["FirstName"].ToString();
                lbPhoneNumber.Text = dtSystemUser.Rows[0]["PhoneNumber"].ToString();
            }
        }
    }
}
