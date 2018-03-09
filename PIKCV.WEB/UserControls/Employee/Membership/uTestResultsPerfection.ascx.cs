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

public partial class UserControls_Employee_Membership_uTestResultsPerfection : BaseUserControl
{
    private DataTable dtTestScore = null;
    private DateTime TestDate;
    //private float TotalPoint = 0;
    //private int GroupCount = 6;
    private DataTable dtAllInfo;
    private PIKCV.COM.EnumDB.EmployeeTypes EmployeeType = PIKCV.COM.EnumDB.EmployeeTypes.Unknown;

    protected void Page_PreRender(object sender, EventArgs e)
    {
        string Redirect = String.Empty;
        //if (PIKCV.BUS.Test.UserTestPerfectionCtrl(this.smUserID)) { Redirect = this.smMemberType.ToString() + "-Membership-UserInfo"; }

        hlMatResult.NavigateUrl = "#" + this.smMemberType.ToString() + "-Membership-TestResults";
        if (CARETTA.COM.Util.IsNumeric(Request.QueryString["esr"]))
        {
            if (int.Parse(Request.QueryString["esr"]) == 1)
            {
                hlMatResult.NavigateUrl += "&esr=1";
                if (Redirect != String.Empty) { Redirect += "&esr=1"; }
            }
        }
        if (Redirect != String.Empty) { this.Redirect(Redirect); }


        UCVTabs1.TabActive(PIKCV.COM.Enumerations.CVTabs.TestResults);
        GetTestScore();
        if (this.dtTestScore.Rows.Count > 5) FillTestScore();

        liMAT.Visible = !PIKCV.BUS.Test.UserTestCtrl(this.smUserID);
        liYET.Visible = !PIKCV.BUS.Test.UserTestPerfectionCtrl(this.smUserID);
    }

    private void GetTestScore()
    {
        if (this.smMemberType == PIKCV.COM.EnumDB.MemberTypes.Company)
        {
            PIKCV.BUS.User objUser = new PIKCV.BUS.User();
            this.EmployeeType = (PIKCV.COM.EnumDB.EmployeeTypes)Convert.ToInt32(objUser.GetUserDetail(this.smUserID).Rows[0]["EmployeeTypeCode"]);
        }
        else
        {
            this.EmployeeType = this.smEmployeeType;
        }

        this.dtTestScore = PIKCV.BUS.Test.GetTestPerfectionScore(this.smUserID);
        PIKCV.BUS.UserCVs objUserCV = new PIKCV.BUS.UserCVs();
        try
        {
            this.TestDate = Convert.ToDateTime(objUserCV.GetUserCV(this.smUserID).Rows[0]["TestYetDate"]);
        }
        catch (Exception) { }
        
        int ActiveRowIndex = 0;
        
        float GroupLevelScore1 = 0;
        float GroupLevelScore2 = 0;
        float GroupLevelScore3 = 0;

        string Description = String.Empty;
        int PerfectionID = 0;
        int LevelID = 0;

        DataRow dr;
        DataTable dtScoreResult;

        for (int i = 0; i <= 30; i=i + 6)
        {
            GroupLevelScore1 = ReturnLevelPoint(i);
            GroupLevelScore2 = ReturnLevelPoint(i + 2);
            GroupLevelScore3 = ReturnLevelPoint(i + 4);

            if (GroupLevelScore1 > GroupLevelScore2) ActiveRowIndex = i;
            else if (GroupLevelScore1 < GroupLevelScore2) ActiveRowIndex = i + 2;
            else if ((GetSmallPoint(i)) > (GetSmallPoint(i + 2))) ActiveRowIndex = i;
            else ActiveRowIndex = i + 2;

            if (ActiveRowIndex == i)
            {
                if (GroupLevelScore1 > GroupLevelScore3) ActiveRowIndex = i;
                else if (GroupLevelScore1 < GroupLevelScore3) ActiveRowIndex = i + 4;
                else if ((GetSmallPoint(i)) > (GetSmallPoint(i + 4))) ActiveRowIndex = i;
                else ActiveRowIndex = i + 4;
            }

            if (ActiveRowIndex == i + 2)
            {
                if (GroupLevelScore2 > GroupLevelScore3) ActiveRowIndex = i + 2;
                else if (GroupLevelScore2 > GroupLevelScore3) ActiveRowIndex = i + 4;
                else if ((GetSmallPoint(i + 2)) > (GetSmallPoint(i + 4))) ActiveRowIndex = i + 2;
                else ActiveRowIndex = i + 4;
            }


            dr = this.dtTestScore.Rows[ActiveRowIndex];

            PerfectionID = Convert.ToInt32(dr["PerfectionID"]);
            LevelID = Convert.ToInt32(dr["TestLevelID"]);

            dtScoreResult = PIKCV.BUS.Test.GetTestPerfectionResult(this.EmployeeType, this.smLanguageID, PerfectionID, LevelID);
            Description = dtScoreResult.Rows[0]["Description"].ToString();

            AddDtAllInfo(PerfectionID, dr["PerfectionName"].ToString(), LevelID, dr["LevelCode"].ToString(), Description);
        }
    }

    private float ReturnLevelPoint(int RowIndex) {
        float TempPoint = 0;
        TempPoint = (Convert.ToInt32(this.dtTestScore.Rows[RowIndex]["AnswerPoint"]) + Convert.ToInt32(this.dtTestScore.Rows[RowIndex + 1]["AnswerPoint"]));
        return TempPoint / 2;
    }

    private float GetSmallPoint(int RowIndex)
    {
        float TempPoint1 = 0;
        float TempPoint2 = 0;
        TempPoint1 = Convert.ToInt32(this.dtTestScore.Rows[RowIndex]["AnswerPoint"]);
        TempPoint2 = Convert.ToInt32(this.dtTestScore.Rows[RowIndex + 1]["AnswerPoint"]);
        if (TempPoint1 > TempPoint2) return TempPoint1; 
        else return TempPoint2;
    }

    private DataTable InitializedtAllInfo() {
        DataTable dt = new DataTable();
        dt.Columns.Add("PerfectionID");
        dt.Columns.Add("PerfectionName");
        dt.Columns.Add("TestLevelID");
        dt.Columns.Add("LevelCode");
        dt.Columns.Add("Description");
        return dt;
    }

    private void AddDtAllInfo(int PerfectionID, string PerfectionName, int TestLevelID, string LevelCode, string Description) {
        if ((dtAllInfo == null) || (dtAllInfo.Rows.Count < 1)) { this.dtAllInfo = InitializedtAllInfo(); }
        dtAllInfo.Rows.Add(PerfectionID, PerfectionName, TestLevelID, LevelCode, Description);
    }

    private void FillTestScore() {
        ltlTestDate.Text = this.TestDate.ToShortDateString();

        ltlGroupName1.Text = this.dtAllInfo.Rows[0]["PerfectionName"].ToString();
        ltlGroupName2.Text = this.dtAllInfo.Rows[1]["PerfectionName"].ToString();
        ltlGroupName3.Text = this.dtAllInfo.Rows[2]["PerfectionName"].ToString();
        ltlGroupName4.Text = this.dtAllInfo.Rows[3]["PerfectionName"].ToString();
        ltlGroupName5.Text = this.dtAllInfo.Rows[4]["PerfectionName"].ToString();
        ltlGroupName6.Text = this.dtAllInfo.Rows[5]["PerfectionName"].ToString();

        ltlLevelCode1.Text = this.dtAllInfo.Rows[0]["LevelCode"].ToString();
        ltlLevelCode2.Text = this.dtAllInfo.Rows[1]["LevelCode"].ToString();
        ltlLevelCode3.Text = this.dtAllInfo.Rows[2]["LevelCode"].ToString();
        ltlLevelCode4.Text = this.dtAllInfo.Rows[3]["LevelCode"].ToString();
        ltlLevelCode5.Text = this.dtAllInfo.Rows[4]["LevelCode"].ToString();
        ltlLevelCode6.Text = this.dtAllInfo.Rows[5]["LevelCode"].ToString();

        ltlResultDescription1.Text = this.dtAllInfo.Rows[0]["Description"].ToString();
        ltlResultDescription2.Text = this.dtAllInfo.Rows[1]["Description"].ToString();
        ltlResultDescription3.Text = this.dtAllInfo.Rows[2]["Description"].ToString();
        ltlResultDescription4.Text = this.dtAllInfo.Rows[3]["Description"].ToString();
        ltlResultDescription5.Text = this.dtAllInfo.Rows[4]["Description"].ToString();
        ltlResultDescription6.Text = this.dtAllInfo.Rows[5]["Description"].ToString();

        trLevelCode.Visible = (this.smMemberType == PIKCV.COM.EnumDB.MemberTypes.Company);
    }
}
