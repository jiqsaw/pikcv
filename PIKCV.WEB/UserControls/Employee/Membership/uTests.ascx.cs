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

public partial class UserControls_Employee_Membership_uTests : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.smIsLogin) { this.Redirect("Employee-Membership-CV"); }
        else {
            if (!IsPostBack)
            {
                UCVTabs1.TabActive(PIKCV.COM.Enumerations.CVTabs.Test);
                
                imgBtnTest.Attributes.Add("onclick", "BeginTest(" + ((int)PIKCV.COM.EnumDB.TestTypeCode.General).ToString() + ")");
                imgBtnTest.Style.Add("cursor", "pointer");
                imgBtnTest2.Attributes.Add("onclick", "BeginTest(" + ((int)PIKCV.COM.EnumDB.TestTypeCode.General).ToString() + ")");
                imgBtnTest2.Style.Add("cursor", "pointer");

                imgBtnTestPerfection.Attributes.Add("onclick", "BeginTest(" + ((int)PIKCV.COM.EnumDB.TestTypeCode.Perfection).ToString() + ")");
                imgBtnTestPerfection.Style.Add("cursor", "pointer");
                imgBtnTestPerfection2.Attributes.Add("onclick", "BeginTest(" + ((int)PIKCV.COM.EnumDB.TestTypeCode.Perfection).ToString() + ")");
                imgBtnTestPerfection2.Style.Add("cursor", "pointer"); 

                ltlFullName.Text = CARETTA.COM.Util.SpecialName(this.smFirstName + ' ' + this.smLastName);

                pnlPerfectionLink.Visible = (this.smEmployeeType == PIKCV.COM.EnumDB.EmployeeTypes.Goodpik);

                pnlMatLink.Visible = (PIKCV.BUS.Test.UserTestCtrl(this.smUserID));
                if (pnlPerfectionLink.Visible)
                {
                    pnlPerfectionLink.Visible = (PIKCV.BUS.Test.UserTestPerfectionCtrl(this.smUserID));
                }

            }
            if (CARETTA.COM.Util.IsNumeric(Request.QueryString["Notice"]))
            {
                if (int.Parse(Request.QueryString["Notice"]) == 1)
                {
                    pnlTest.Visible = false;
                    pnlTestPerfection.Visible = true;
                    UCVTabs1.AllTabsHide();
                    ltlTitleTestPerfection.Visible = true;
                    ltlTitleTest.Visible = false;
                }
            }
            else {
                ltlTitleTestPerfection.Visible = false;
                ltlTitleTest.Visible = true;
            }

            if ((CARETTA.COM.Util.IsNumeric(Request.QueryString["TestType"])) && (CARETTA.COM.Util.IsNumeric(Request.QueryString["Ref"])))
            {
                int TestTypeCode = int.Parse(Request.QueryString["TestType"]);
                if ((PIKCV.COM.EnumDB.TestTypeCode)TestTypeCode == PIKCV.COM.EnumDB.TestTypeCode.General)
                {
                    pnlTest.Visible = false;
                    pnlTestGeneral1.Visible = true;
                    imgBtnTest.Visible = false;
                    lnkTestGeneral2.Visible = false;
                }
                else if ((PIKCV.COM.EnumDB.TestTypeCode)TestTypeCode == PIKCV.COM.EnumDB.TestTypeCode.Perfection) {
                    pnlTest.Visible = false;
                    pnlTestPerfection.Visible = true;
                    imgBtnTest2.Visible = false;
                    imgBtnTestPerfection.Visible = false;
                    imgBtnTestPerfection2.Visible = false;
                    lnkTestPerfection2_1.Visible = false;
                }
            }
        }
    }

    protected void lbTestGeneral_Click(object sender, EventArgs e)
    {
        pnlTest.Visible = false;
        pnlTestGeneral1.Visible = true;
    }
    protected void lnkTestGeneral2_Click(object sender, EventArgs e)
    {
        pnlTestGeneral1.Visible = false;
        pnlTestGeneral2.Visible = true;
    }

    protected void lnkTestGeneral1_Click(object sender, EventArgs e)
    {
        pnlTestGeneral1.Visible = true;
        pnlTestGeneral2.Visible = false;
    }

    protected void lbTestPerfection_Click(object sender, EventArgs e)
    {
        pnlTest.Visible = false;
        pnlTestPerfection.Visible = true;
    }
    protected void lnkTestPerfection2_1_Click(object sender, EventArgs e)
    {
        pnlTestPerfection.Visible = false;
        pnlTestPerfection2.Visible = true;
    }
    protected void lnkTestPerfection1_1_Click1(object sender, EventArgs e)
    {
        pnlTestPerfection.Visible = true;
        pnlTestPerfection2.Visible = false;
    }

    protected void lnkTestPerfection2_2_Click2(object sender, EventArgs e)
    {
        pnlTestPerfection.Visible = false;
        pnlTestPerfection2.Visible = true;
    }
    protected void lnkTestPerfection1_2_Click1(object sender, EventArgs e)
    {
        pnlTestPerfection.Visible = true;
        pnlTestPerfection2.Visible = false;
    }
}
