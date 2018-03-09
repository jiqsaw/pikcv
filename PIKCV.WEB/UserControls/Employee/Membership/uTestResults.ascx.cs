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

public partial class UserControls_Employee_Membership_uTestResults : BaseUserControl
{
    private int DefaultBarHeight = 18;
    private DataTable dtTestScore;
    private DateTime TestDate;
    private float TotalPoint = 0;
    private PIKCV.COM.EnumDB.EmployeeTypes EmployeeType = PIKCV.COM.EnumDB.EmployeeTypes.Unknown;
    //private int GroupCount = 6;

    protected void Page_PreRender(object sender, EventArgs e)
    {
        string Redirect = String.Empty;
        hlYetResult.NavigateUrl = "#" + this.smMemberType.ToString() + "-Membership-TestResultsPerfection";
        if (PIKCV.BUS.Test.UserTestCtrl(this.smUserID)) { Redirect = this.smMemberType.ToString() + "-Membership-TestResultsPerfection"; }

        if (CARETTA.COM.Util.IsNumeric(Request.QueryString["esr"]))
        {
            if (int.Parse(Request.QueryString["esr"]) == 1)
            {
                hlYetResult.NavigateUrl += "&esr=1";
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
    private void GetTestScore() {
        if (this.smMemberType == PIKCV.COM.EnumDB.MemberTypes.Company)
        {
            PIKCV.BUS.User objUser = new PIKCV.BUS.User();
            this.EmployeeType = (PIKCV.COM.EnumDB.EmployeeTypes)Convert.ToInt32(objUser.GetUserDetail(this.smUserID).Rows[0]["EmployeeTypeCode"]);
        }
        else {
            this.EmployeeType = this.smEmployeeType;
        }

        this.dtTestScore = PIKCV.BUS.Test.GetTestScore(PIKCV.COM.EnumDB.TestTypeCode.General, this.smUserID, this.smLanguageID, EmployeeType);
        PIKCV.BUS.UserCVs objUserCV = new PIKCV.BUS.UserCVs();
        try
        {
            this.TestDate = Convert.ToDateTime(objUserCV.GetUserCV(this.smUserID).Rows[0]["TestMatDate"]);
        }
        catch (Exception) { }
        
    }

    private void FillTestScore() {
        ltlTestDate.Text = this.TestDate.ToShortDateString();

        ltlGroupName1.Text = this.dtTestScore.Rows[0]["GroupName"].ToString();
        ltlGroupName2.Text = this.dtTestScore.Rows[1]["GroupName"].ToString();
        ltlGroupName3.Text = this.dtTestScore.Rows[2]["GroupName"].ToString();
        ltlGroupName4.Text = this.dtTestScore.Rows[3]["GroupName"].ToString();
        ltlGroupName5.Text = this.dtTestScore.Rows[4]["GroupName"].ToString();
        ltlGroupName6.Text = this.dtTestScore.Rows[5]["GroupName"].ToString();

        ltlLevelCode1.Text = this.dtTestScore.Rows[0]["LevelCode"].ToString();
        ltlLevelCode2.Text = this.dtTestScore.Rows[1]["LevelCode"].ToString();
        ltlLevelCode3.Text = this.dtTestScore.Rows[2]["LevelCode"].ToString();
        ltlLevelCode4.Text = this.dtTestScore.Rows[3]["LevelCode"].ToString();
        ltlLevelCode5.Text = this.dtTestScore.Rows[4]["LevelCode"].ToString();
        ltlLevelCode6.Text = this.dtTestScore.Rows[5]["LevelCode"].ToString();

        int Point1 = Convert.ToInt32(this.dtTestScore.Rows[0]["Point"]);
        int Point2 = Convert.ToInt32(this.dtTestScore.Rows[1]["Point"]);
        int Point3 = Convert.ToInt32(this.dtTestScore.Rows[2]["Point"]);
        int Point4 = Convert.ToInt32(this.dtTestScore.Rows[3]["Point"]);
        int Point5 = Convert.ToInt32(this.dtTestScore.Rows[4]["Point"]);
        int Point6 = Convert.ToInt32(this.dtTestScore.Rows[5]["Point"]);

        ltlPoint1.Text = Point1.ToString();
        ltlPoint2.Text = Point2.ToString();
        ltlPoint3.Text = Point3.ToString();
        ltlPoint4.Text = Point4.ToString();
        ltlPoint5.Text = Point5.ToString();
        ltlPoint6.Text = Point6.ToString();

        imgBar1.Height = Unit.Pixel(DefaultBarHeight * Point1);
        imgBar2.Height = Unit.Pixel(DefaultBarHeight * Point2);
        imgBar3.Height = Unit.Pixel(DefaultBarHeight * Point3);
        imgBar4.Height = Unit.Pixel(DefaultBarHeight * Point4);
        imgBar5.Height = Unit.Pixel(DefaultBarHeight * Point5);
        imgBar6.Height = Unit.Pixel(DefaultBarHeight * Point6);

        float Multipliers = 0;
        foreach (DataRow dr in dtTestScore.Rows)
        {
            this.TotalPoint += Convert.ToSingle(dr["TotalPoint"]);
            Multipliers += Convert.ToSingle(dr["Multiplier"]);
        }

        this.TotalPoint = this.TotalPoint / Multipliers;
        ltlTotalScore.Text = this.TotalPoint.ToString("N");
        int ImgTotalHeight = Convert.ToInt32(DefaultBarHeight * this.TotalPoint);
        imgBarResult.Height = Unit.Pixel(ImgTotalHeight);

        DataRow drTotalScoreInfo = PIKCV.BUS.Test.GetTestTotalScoreInfo(this.TotalPoint, PIKCV.COM.EnumDB.LanguageID.Turkish, this.EmployeeType).Rows[0];
        ltlResultDescription.Text = drTotalScoreInfo["Description"].ToString();
        trLevelCode.Visible = (this.smMemberType == PIKCV.COM.EnumDB.MemberTypes.Company);
    }
}