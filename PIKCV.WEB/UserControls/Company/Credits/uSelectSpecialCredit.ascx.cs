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

public partial class UserControls_Company_Credits_uSelectSpecialCredit : BaseUserControl
{
    public double CreditMultiplier
    {
        get
        {
            if (ViewState["CM"] == null)
            {
                ViewState.Add("CM", "0");
            }
            return Convert.ToInt32(ViewState["CM"]);
        }
        set { ViewState.Add("CM", value); }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillForm();
        }
    }

    private void FillForm()
    {
        PIKCV.BUS.Credits obj = new PIKCV.BUS.Credits();
        DataTable dt = obj.GetCreditDetail(0);
        if (dt.Rows.Count > 0)
        {
            lbCreditMultiplier.Text = dt.Rows[0]["Multiplier"].ToString();
            this.CreditMultiplier = Convert.ToDouble(dt.Rows[0]["Multiplier"]);
            lbCredits.Text = dt.Rows[0]["Credits"].ToString();
            errMinPikCredi.MinimumValue = dt.Rows[0]["Credits"].ToString();
            errMinPikCredi.ErrorMessage = "Lütfen " + errMinPikCredi.MinimumValue + "'den büyük bir tamsayý sayý giriniz.";
            double Price = Convert.ToDouble(dt.Rows[0]["Multiplier"]) * Convert.ToDouble(dt.Rows[0]["Credits"]);
            lbPrice.Text = Price.ToString();
        }
    }

    protected void btnCalculate_Click(object sender, ImageClickEventArgs e)
    {
        lbCredits.Text = txtCredits.Text;
        double Price = (Convert.ToDouble(txtCredits.Text)) * this.CreditMultiplier;
        lbPrice.Text = Price.ToString();
        pnlCalcMsg.Visible = true;
    }
    protected void btnContinue_Click1(object sender, ImageClickEventArgs e)
    {
        this.Redirect("Company-Credits-SelectPaymentType&CreditPackageType=0&OtherPackageCredits=" + txtCredits.Text);
    }
    protected void lbChangePackage_Click(object sender, EventArgs e)
    {
        this.Redirect("Company-Credits-SelectCreditPackage");
    }
}
