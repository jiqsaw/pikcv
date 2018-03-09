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

public partial class Test : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Util.IsNumeric(Request.QueryString["TestType"]))
        {
            PIKCV.COM.EnumDB.TestTypeCode TestType = (PIKCV.COM.EnumDB.TestTypeCode)int.Parse(Request.QueryString["TestType"].ToString());
            string TestControl = "Test";
            if (TestType == PIKCV.COM.EnumDB.TestTypeCode.Perfection) {
                TestControl = "TestPerfection";
            }
            string ControlPath = "~/UserControls/Employee/MemberShip/Test/u" + TestControl + ".ascx";
            try
            {
                Control objControl = new Control();
                objControl = LoadControl(ControlPath);
                PH1.Controls.Clear();
                PH1.Controls.Add(objControl);
            }
            catch (Exception) { }
        }
    }
}
