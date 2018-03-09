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

public partial class UserControls_Common_uDate : BaseUserControl
{
    public DateTime Date
    {
        get { return DateTime.Parse(ddlDays.SelectedValue.PadLeft(2, '0') + "." + ddlMonths.SelectedValue.PadLeft(2, '0') + "." + ddlYears.SelectedValue.PadLeft(2, '0')); }
        set { 
            string[] Date = value.ToString().Split('.');
            ddlDays.SelectedValue = Date[0];
            ddlMonths.SelectedValue = Date[1];
            ddlYears.SelectedValue = Util.Left(Date[2], 4);
        }
    }


    public bool ValidateDisplay
    {
        get { return CustomValidatorDate.Visible; }
        set { CustomValidatorDate.Visible = value; }
    }


    public string DayClientID { get { return ddlDays.ClientID; } }
    public string MonthClientID { get { return ddlMonths.ClientID; } }
    public string YearClientID { get { return ddlYears.ClientID; } }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataBindHelper.LoadNumberDDL(ref ddlDays, 31, true);
            DataBindHelper.LoadNumberDDL(ref ddlMonths, 12, true);
            DataBindHelper.LoadNumberDDL(ref ddlYears, DateTime.Now.Year, 1, int.Parse(this.Config(PIKCV.COM.EnumUtil.Config.StartYear)));

            ddlDays.Items.Insert(0, new ListItem("Gün", "0"));
            ddlMonths.Items.Insert(0, new ListItem("Ay", "0"));
            ddlYears.Items.Insert(0, new ListItem("Yýl", "0"));
        }
    }

    public void YearDataBind(int RemoveStartYear, int RemoveEndYear) {
        ddlYears.Items.Clear();
        DataBindHelper.LoadNumberDDL(ref ddlYears, RemoveEndYear, 1, RemoveStartYear);
        ddlYears.Items.Insert(0, new ListItem("Yýl", "0"));
    }
}
