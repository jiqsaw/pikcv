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

public partial class UserControls_Employee_Membership_Test_uTestPerfection : BaseUserControl
{
    private DataTable dtTest;
    private DataTable dtTestGroups;
    protected int ddlNo = 1;
    protected int StatementNo = 1;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if ((!this.smIsLogin) || (!UserTestCtrl())) { pnlTest.Visible = false; }
            else
            {
                GetData();
                FillData();
            }
        }
        else {
            TestFinish();
        }
    }

    private void GetData()
    {
        this.dtTest = PIKCV.BUS.Test.GetPerfectionTest(this.smEmployeeType, PIKCV.COM.EnumDB.EmployeeTypes.Both, this.smLanguageID);
        this.dtTestGroups = DataTableHelper.Distinct(this.dtTest, "PerfectionID");
    }

    private void FillData()
    {
        hdQuestions.Value = String.Empty;
        foreach (DataRow dr in this.dtTest.Rows)
        {
            hdQuestions.Value += dr["TestPerfectionID"].ToString() + ",";
        }

        hdQuestions.Value = Util.Left(hdQuestions.Value, hdQuestions.Value.Length - 1);
        DataBindHelper.BindRepeater(ref rptTest, this.dtTestGroups);
    }

    protected void rptTest_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if ((e.Item.ItemType == ListItemType.Item) || (e.Item.ItemType == ListItemType.AlternatingItem))
        {
            int GroupNO = int.Parse(((Literal)e.Item.FindControl("ltlGorupNO")).Text);
            ((Literal)e.Item.FindControl("ltlGroupName")).Text = PIKCV.BUS.Test.GetTestPerfectionName(GroupNO);
            Repeater rptStatement = ((Repeater)e.Item.FindControl("rptStatement"));
            DataBindHelper.BindRepeater(ref rptStatement, DataTableHelper.Filter(this.dtTest, "PerfectionID", GroupNO.ToString()));
        }
    }

    private DataTable InitializeDtPerfection()
    {
        DataTable dtAnswers = new DataTable();
        dtAnswers.Columns.Add("TestPerfectionID");
        dtAnswers.Columns.Add("AnswerPoint");
        return dtAnswers;
    }

    protected void ImgBtnTestFinish_Click(object sender, ImageClickEventArgs e)
    {
        TestFinish();
    }

    private void TestFinish() {
        DataTable dtResults = InitializeDtPerfection();

        ArrayList arrQuestions = new ArrayList();
        arrQuestions.AddRange(Request.Form[hdQuestions.UniqueID].ToString().Split(','));

        ArrayList arrAnswers = new ArrayList();
        arrAnswers.AddRange(Request.Form[hdAnswers.UniqueID].ToString().Split(','));

        for (int i = 0; i < arrAnswers.Count; i++)
        {
            dtResults.Rows.Add(arrQuestions[i], arrAnswers[i]);
        }

        if (PIKCV.BUS.Test.SaveUserTestPerfection(this.smUserID, dtResults))
        {
            Response.Write("<script>alert('Testi yaptýðýnýz için teþekkür ederiz, test sonuçlarýnýza test sonuçlarý ekranýndan ulaþabilirsiniz.'); window.close(); window.opener.location.href='Pikcv.aspx?Pik=Employee-Membership-TestResultsPerfection';</script>");
        }
        else
        {
            Response.Write("<script>alert('!! Bilgileriniz KAYDEDÝLMEDÝ.')</script>");
        }
    }

    private bool UserTestCtrl() {
        return PIKCV.BUS.Test.UserTestPerfectionCtrl(this.smUserID);
    }
}