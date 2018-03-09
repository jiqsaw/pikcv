using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Globalization;

public partial class JobStatistics : System.Web.UI.Page
{
    public int maxBarLength = 150;

    public class Stat
    {
        public string Descr;
        public int Count;
        public float Percentage;

        public Stat(string descr, int total)
        {
            this.Descr = Descr;
            this.Count = total;
        }

        public static void CalcPercentage(params Stat[] stats)
        {
            float sum = 0;
            foreach (Stat stat in stats)
                sum += stat.Count;

            foreach (Stat stat in stats)
            {
                if (sum != 0)
                {
                    stat.Percentage = 100.0f * (stat.Count / sum);
                }
                else
                {
                    stat.Percentage = 0;
                }
            }
        }
    }

    public Dictionary<string, Stat> stats = new Dictionary<string, Stat>();

    private void addStat(object srcData, string ident)
    {
       // ident = ident.ToLower(CultureInfo.InvariantCulture);
        int total = (int)srcData;
        Stat curStat = new Stat(ident, total);

        stats.Add(ident, curStat);
        sumBuffer.Add(curStat);
    }

    List<Stat> sumBuffer = new List<Stat>();

    protected void calcPercentage()
    {
        Stat.CalcPercentage(sumBuffer.ToArray());
        sumBuffer.Clear();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            int jobID =0;

            if (CARETTA.COM.Util.IsNumeric(Request.QueryString["JobID"]))
            {
                jobID = Convert.ToInt32(Request.QueryString["JobID"]);


                //SqlConnection connection = new SqlConnection(@"Data Source=CARETTASERVER\SQL2005;Initial Catalog=PikCv;User Id=sa;Password=1234aA;");
                //connection.Open();
                //SqlDataAdapter adapter = new SqlDataAdapter(String.Format("exec pikcv.[GetJobStatistics] {0}, @langID=1", jobID), connection);
                //DataSet result = new DataSet();
                //adapter.Fill(result);
                //connection.Close();

                DataSet result = PIKCV.BUS.Job.GetJobStatistics(jobID, (int)PIKCV.COM.EnumDB.LanguageID.Turkish, PIKCV.COM.EnumDB.SexCode.Male);

                // ilk resultset'i al, hesaplanmasi basit alanlar.
                DataRow row = result.Tables[0].Rows[0];
                int appTotal = (int)row["app_Count"];
                lbJobApplicantCount.Text = appTotal.ToString();

                addStat(row["app_Count"], "appCount");
                //addStat(row["app_Total"], "appTotal");

                calcPercentage();

                addStat(row["age_18"], "a1");
                addStat(row["age_25"], "a2");
                addStat(row["age_30"], "a3");
                addStat(row["age_35"], "a4");
                addStat(row["age_40"], "a5");
                addStat(row["age_45"], "a6");
                addStat(row["age_60"], "a7");
                calcPercentage();

                addStat(row["working"], "working");
                addStat(appTotal - (int)row["working"], "notworking");
                calcPercentage();

                addStat(row["mil_done"], "mildone");
                addStat(row["mil_postpone"], "milpostpone");
                addStat(row["mil_notdone"], "milnotdone");
                calcPercentage();

                addStat(row["SexCount"], "male");
                addStat(appTotal - (int)row["SexCount"], "female");
                calcPercentage();

                // $ehirler

                //int a = 1;
                //int sum = 0;
                //foreach (DataRow crow in result.Tables[1].Rows)
                //{
                //    int count = (int)crow["Count"];
                //    Stat stat = new Stat((string)crow["PlaceName"], count);
                //    stats.Add(String.Format("c{0}", a++.ToString()), stat);
                //    sum += count;
                //}
                foreach (DataRow crow in result.Tables[1].Rows)
                {
                    addStat(crow["Count"], crow["PlaceName"].ToString());
                }

                calcPercentage();

                foreach (DataRow dr in result.Tables[1].Rows)
                {
                    dr["Percentage"] = Convert.ToInt32(stats[dr["PlaceName"].ToString()].Percentage).ToString();
                }

                rptLivingPlace.DataSource = result.Tables[1];
                rptLivingPlace.DataBind();

                // Þehiler

                // buldugun degerleri direkt yukle
                //this.mil_done.Attributes["width"] = "1000";

                //setProgress(mil_done, "mildone");
                //setProgress(mil_notdone, "milnotdone");
                //setProgress(mil_postponed, "milpostpone");

                //setProgress(app_count, "appcount");
                //setProgress(app_total, "apptotal");


                ////Deðerleri yazýyoruz
                BarControlWorking.Description = "Çalýþýyor";
                BarControlWorking.Count = stats["working"].Count;
                BarControlWorking.Percentage = Convert.ToInt32(stats["working"].Percentage);
                BarControlNotWorking.Description = "Çalýþmýyor";
                BarControlNotWorking.Count = stats["notworking"].Count;
                BarControlNotWorking.Percentage = Convert.ToInt32(stats["notworking"].Percentage);

                BarControlMan.Description = "Bayan";
                BarControlMan.Count = stats["female"].Count;
                BarControlMan.Percentage = Convert.ToInt32(stats["female"].Percentage);
                BarControlWomen.Description = "Bay";
                BarControlWomen.Count = stats["male"].Count;
                BarControlWomen.Percentage = Convert.ToInt32(stats["male"].Percentage);


                BarControlage_18.Description = "18-25";
                BarControlage_18.Count = stats["a1"].Count;
                BarControlage_18.Percentage = Convert.ToInt32(stats["a1"].Percentage);
                BarControlage_25.Description = "25-30";
                BarControlage_25.Count = stats["a2"].Count;
                BarControlage_25.Percentage = Convert.ToInt32(stats["a2"].Percentage);
                BarControlage_30.Description = "30-35";
                BarControlage_30.Count = stats["a3"].Count;
                BarControlage_30.Percentage = Convert.ToInt32(stats["a3"].Percentage);
                BarControlage_35.Description = "30-35";
                BarControlage_35.Count = stats["a4"].Count;
                BarControlage_35.Percentage = Convert.ToInt32(stats["a4"].Percentage);
                BarControlage_40.Description = "40-45";
                BarControlage_40.Count = stats["a5"].Count;
                BarControlage_40.Percentage = Convert.ToInt32(stats["a5"].Percentage);
                BarControlage_45.Description = "45-60";
                BarControlage_45.Count = stats["a6"].Count;
                BarControlage_45.Percentage = Convert.ToInt32(stats["a6"].Percentage);
                BarControlage_60.Description = "60 ve üstü";
                BarControlage_60.Count = stats["a7"].Count;
                BarControlage_60.Percentage = Convert.ToInt32(stats["a7"].Percentage);

                //BarControlLivingPlace1.Description = "Ýstanbul";
                //BarControlLivingPlace1.Count = stats["c1"].Count;
                //BarControlLivingPlace1.Percentage = Convert.ToInt32(stats["c1"].Percentage);
                //BarControlLivingPlace2.Description = "Ankara";
                //BarControlLivingPlace2.Count = stats["c2"].Count;
                //BarControlLivingPlace2.Percentage = Convert.ToInt32(stats["c2"].Percentage);
                //BarControlLivingPlace3.Description = "Ýzmir";
                //BarControlLivingPlace3.Count = stats["c3"].Count;
                //BarControlLivingPlace3.Percentage = Convert.ToInt32(stats["c3"].Percentage);
                //BarControlLivingPlace4.Description = "Antalya";
                //BarControlLivingPlace4.Count = stats["c4"].Count;
                //BarControlLivingPlace4.Percentage = Convert.ToInt32(stats["c4"].Percentage);
                //BarControlLivingPlace5.Description = "Diðer";
                //BarControlLivingPlace5.Count = stats["c5"].Count;
                //BarControlLivingPlace5.Percentage = Convert.ToInt32(stats["c5"].Percentage);

                BarControlMilitaryDone.Description = "Yaptý";
                BarControlMilitaryDone.Count = stats["mildone"].Count;
                BarControlMilitaryDone.Percentage = Convert.ToInt32(stats["mildone"].Percentage);
                BarControlMilitaryNotDone.Description = "Yapmadý";
                BarControlMilitaryNotDone.Count = stats["milnotdone"].Count;
                BarControlMilitaryNotDone.Percentage = Convert.ToInt32(stats["milnotdone"].Percentage);
                BarControlMilitaryPostponed.Description = "Tecilli";
                BarControlMilitaryPostponed.Count = stats["milpostpone"].Count;
                BarControlMilitaryPostponed.Percentage = Convert.ToInt32(stats["milpostpone"].Percentage);


                DataTable dtJobDetail = PIKCV.BUS.Job.GetJobDetail(jobID);
                if (dtJobDetail.Rows.Count > 0)
                {
                    lbPosition.Text = dtJobDetail.Rows[0]["PositionName"].ToString();
                    lbJobDate.Text = string.Format("{0:d}", dtJobDetail.Rows[0]["StartDate"]);
                }
            }
            else
            {
                //Job id yanlýþ 
            }
        }
    }

    protected void setProgress(HtmlGenericControl ctl, string data)
    {
        Stat curStat = stats[data];
        ctl.Style["width"] = ((int)(curStat.Percentage * 2.2)).ToString();
    }
}
