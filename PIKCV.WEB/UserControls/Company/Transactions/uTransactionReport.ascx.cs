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
using WebChart;

public partial class UserControls_Company_Transactions_uTransactionReport : BaseUserControl
{

    protected int TotalCreditUsed = 0;
    protected float TotalPrice = 0;
    protected int RemainderCredit = 0;

    private int ChartCreditUsed = 0;
    private int ChartBoughtCredit = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        this.IsLogin();
        if (!Page.IsPostBack)
        {
            FillData(DateTime.Now.AddDays(-90), DateTime.Now.AddDays(1));
        }
    }

    protected void FillData(DateTime OrderStartDate, DateTime OrderEndDate)
    {
        PIKCV.BUS.Orders objOrders = new PIKCV.BUS.Orders();
        DataTable dt = objOrders.GetTransactionReport(this.smCompanyID, PIKCV.COM.EnumDB.OrderTypeCode.EmployeeInfoAchieving,
            PIKCV.COM.EnumDB.OrderTypeCode.CreditBuy, PIKCV.COM.EnumDB.OrderProcessTypeCode.paid, true, this.smLanguageID, OrderStartDate, OrderEndDate);

        if (dt.Rows.Count > 0)
        {
            UPaging1.GeneratePager(ref dt, rptReports);
            rptReports.Visible = true;
            ltlNoRecord.Visible = false;
            ChartControl1.Visible = true;
            CreateChart();
        }
        else {
            rptReports.Visible = false;
            ltlNoRecord.Visible = true;
            ChartControl1.Visible = false;
        }
    }

    protected void btn_search_Click(object sender, ImageClickEventArgs e)
    {
        FillData(UOrderStartDate.Date, UOrderEndDate.Date);
    }

    private DataTable InitializeDtChart() {
        DataTable dt = new DataTable();
        dt.Columns.Add("Description");
        dt.Columns.Add("Value");
        return dt;
    }

    void CreateChart()
    {

        DataTable dtChart = InitializeDtChart();
        dtChart.Rows.Add("Kullanýlan Kredi", this.ChartCreditUsed);
        dtChart.Rows.Add("Alýnan Kredi", this.ChartBoughtCredit);

        PieChart chart = new PieChart();
        chart.DataSource = dtChart.DefaultView;
        chart.DataXValueField = "Description";
        chart.DataYValueField = "Value";
        chart.DataLabels.Visible = true;
        chart.DataLabels.ForeColor = System.Drawing.Color.Blue;
        chart.Shadow.Visible = true;
        chart.DataBind();
        chart.Explosion = dtChart.Rows.Count;
        ChartControl1.Charts.Add(chart);
        ChartControl1.RedrawChart();
    }

    protected void rptReports_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if ((e.Item.ItemType == ListItemType.Item) || (e.Item.ItemType == ListItemType.AlternatingItem))
        {
            int m_TotalCreditUsed = int.Parse(((Literal)e.Item.FindControl("ltlCreditForCalc")).Text);
            this.TotalCreditUsed += m_TotalCreditUsed;
            this.TotalPrice += float.Parse(((Literal)e.Item.FindControl("ltlPriceForCalc")).Text);
            PIKCV.COM.EnumDB.OrderTypeCode OrderTypeCode = (PIKCV.COM.EnumDB.OrderTypeCode)(int.Parse(((Literal)e.Item.FindControl("ltlOrderTypeForCalc")).Text));
            if (OrderTypeCode == PIKCV.COM.EnumDB.OrderTypeCode.CreditBuy) {
                this.ChartBoughtCredit += m_TotalCreditUsed;
                this.RemainderCredit += m_TotalCreditUsed;
            } else {
                this.ChartCreditUsed += m_TotalCreditUsed;
                this.RemainderCredit -= m_TotalCreditUsed;
            }
            ((Literal)e.Item.FindControl("ltlRemainderCredit")).Text = this.RemainderCredit.ToString();
        }
    }
}
