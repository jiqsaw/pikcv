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
using System.Text;
using System.Collections.Generic;
using CARETTA.COM;

public partial class UserControls_Employee_Membership_Test_uTest : BaseUserControl
{
    private int QuestionCount = 30;
    private DataTable m_Test;
    private Dictionary<string, object> dcDetails;
    private PIKCV.COM.EnumDB.TestTypeCode TestTypeCode = PIKCV.COM.EnumDB.TestTypeCode.General;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.smIsLogin) { this.Redirect("Employee-Membership-CV"); }
        else
        {
            if (!IsPostBack)
            {
                pnlTest.Visible = (this.smIsLogin);
                pnlTest.Visible = PIKCV.BUS.Test.UserTestCtrl(this.smUserID);
                InitializeTest();
                GenerateQuestionsNav(QuestionCount);
            }
            else
            {

                ArrayList arrQuestions = new ArrayList();
                arrQuestions.AddRange(Request.Form[hdQuestions.UniqueID].ToString().Split(','));

                ArrayList arrAnswers = new ArrayList();
                arrAnswers.AddRange(Request.Form[hdAnswers.UniqueID].ToString().Split(','));

                TestFinish(this.TestTypeCode, FillArrAnswers(arrQuestions, arrAnswers));
            }
        }
    }

    protected void InitializeTest()
    {
        this.m_Test = PIKCV.BUS.Test.GetRandomTest(this.TestTypeCode);

        dcDetails = new Dictionary<string, object>();

        hdQuestions.Value = String.Empty;
        foreach (DataRow dr in this.m_Test.Rows)
        {
            if (!ExistQuestion(dr["TestQuestionID"].ToString())) {
                hdQuestions.Value += dr["TestQuestionID"].ToString() + ",";
                this.dcDetails.Add(dr["TestQuestionID"].ToString(), ReturnAnswers(Convert.ToInt32(dr["TestQuestionID"])));
            }
        }

        hdQuestions.Value = Util.Left(hdQuestions.Value, hdQuestions.Value.Length - 1);

        int QuestionNO = 1;
        
        foreach (KeyValuePair<string, object> dcRow in this.dcDetails) {
            dvGenerateHTML.InnerHtml += GenerateHtml(QuestionNO, ((DataTable)dcRow.Value).Rows[0]["Question"].ToString(), (DataTable)dcRow.Value);
            QuestionNO++;
        }
    }

    private bool ExistQuestion(string TestQuestionID) {
        foreach (KeyValuePair<string, object> dcRow in this.dcDetails) {
            if (dcRow.Key.ToString() == TestQuestionID) {
                return true;
            }
        }
        return false;
    }

    private DataTable ReturnAnswers(int TestQuestionID) {
        DataTable dtAnswers = this.m_Test.Clone();

        foreach (DataRow dr in this.m_Test.Rows)
        {
            if (dr["TestQuestionID"].ToString() == TestQuestionID.ToString()) {
                dtAnswers.Rows.Add(dr.ItemArray);
            }
        }
        return dtAnswers;
    }

    private string GenerateHtml(int QuestionNO, string Question, DataTable dtAnswers)
    {
        
        StringBuilder sb = new StringBuilder();
        sb.Append("<div style='display: none;' id='dv");
        sb.Append(QuestionNO.ToString()); //SORU NUMARASI DIV
        sb.Append("'>");
        sb.Append("<table width='90%' class='FormTable' style='text-align: left;'><tr><td><strong>Soru ");
        sb.Append(QuestionNO.ToString()); //SORU NUMARASI
        sb.Append(":</strong> <br />");
        sb.Append(Question); // SORU
        sb.Append("</td></tr><tr><td style='padding-top: 5px;'>");

        float BrIndex = 1;
        foreach (DataRow dr in dtAnswers.Rows)
        {
            sb.Append(GenerateAnswerHTML(Convert.ToInt32(dr["TestQuestionID"]), Convert.ToInt32(dr["TestAnswerID"]), dr["Answer"].ToString(), BrIndex));
            BrIndex++;
        }

        string strClientClick = "SetAnswer(" + QuestionNO.ToString() + ", RdListSelectedValue('rdAnswer" + dtAnswers.Rows[0]["TestQuestionID"].ToString() + "'));";

        sb.Append("</td></tr><tr><td style='height: 70px;'>");
        sb.Append("<img style='cursor: pointer;' ");
        sb.Append("onclick=\"" + strClientClick + "\"");
        sb.Append("ondblclick=\"" + strClientClick + "\"");
        sb.Append("src='Images/buttons/save.png' width='113' height='27' />");
        sb.Append("</td></tr></table>");
        sb.Append("</div>");
        return sb.ToString();
    }

    private string GenerateAnswerHTML(int QuestionID, int AnswerID, string Answer, float BrIndex) {
        StringBuilder sb = new StringBuilder();
        sb.Append("<input type='radio' name='rdAnswer");
        sb.Append(QuestionID);
        sb.Append("' value='");
        sb.Append(AnswerID);
        sb.Append("' />");
        sb.Append(Answer);
        sb.Append("&nbsp;&nbsp;&nbsp;");
        bool IsImg = (Answer.IndexOf("<img") != -1);
        if ((!IsImg) || ((IsImg) && (BrIndex==3))) { sb.Append("<br />"); }
        
        //if (Util.IsEven(BrIndex)) { sb.Append("<br />"); }
        return sb.ToString();
    }

    private void GenerateQuestionsNav(int Count) {
        StringBuilder sb = new StringBuilder();
        for (int i = 1; i <= Count; i++) {
            sb.Append("<div id='dvLink" + i.ToString() + "' class='unanswered'><a href=\"javascript:ShowHideDv('" + i.ToString() + "');\">" + i.ToString() + "</a></div>");
        }
        ltlNav.Text = sb.ToString();
    }

    protected DataTable FillArrAnswers (ArrayList arrQuestions, ArrayList arrAnswers)
    {
        DataTable dtAnswers = InitializeDtGeneral();

        for (int i = 0; i < arrAnswers.Count; i++)
        {
            dtAnswers.Rows.Add(i + 1, arrQuestions[i], arrAnswers[i]);
        }
        return dtAnswers;
    }

    private void TestFinish(PIKCV.COM.EnumDB.TestTypeCode TestTypeCode, DataTable dtResults) {
        if (PIKCV.BUS.Test.SaveUserTestResults(this.smUserID, TestTypeCode, dtResults)) {
            Response.Write("<script>alert('Testi yaptýðýnýz için teþekkür ederiz, test sonuçlarýnýza test sonuçlarý ekranýndan ulaþabilirsiniz.'); window.close(); window.opener.location.href='Pikcv.aspx?Pik=Employee-Membership-TestResults';</script>");
        }
        else {
            Response.Write("<script>alert('!! Bilgileriniz KAYDEDÝLMEDÝ.')</script>");
        }
    }

    private DataTable InitializeDtGeneral() {
        DataTable dtAnswers = new DataTable();
        dtAnswers.Columns.Add("QuestionNo");
        dtAnswers.Columns.Add("TestQuestionID");
        dtAnswers.Columns.Add("TestAnswerID");
        return dtAnswers;
    }

}