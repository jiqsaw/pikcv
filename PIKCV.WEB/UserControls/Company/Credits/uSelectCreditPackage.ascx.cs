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

public partial class UserControls_Company_Credits_uSelectCreditPackage : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.IsLogin();
        if (!IsPostBack)
        {
            int CreditPackageID = 0;
            if (Util.IsNumeric(Request.QueryString["CreditPackageID"]))
            {
                CreditPackageID = Convert.ToInt32(Request.QueryString["CreditPackageID"]);
            }
            FillForm(CreditPackageID);
        }
    }

    private void FillForm(int CreditPackageID)
    {
        PIKCV.BUS.Credits obj = new PIKCV.BUS.Credits();
        DataTable dt = obj.GetCreditPackages();
        foreach (DataRow dr in dt.Rows)
        {
            if (Convert.ToInt32(dr["CreditPackageID"]) == 0)
            {
                dr["CreditPackageName"] = dr["Credits"].ToString() + " " + dr["CreditPackageName"].ToString();
            }
            else
            {
                double Price = Convert.ToDouble(dr["Credits"]) * Convert.ToDouble(dr["Multiplier"]);
                dr["CreditPackageName"] = dr["CreditPackageName"].ToString() + " - " + Price.ToString() + "YTL";
            }
        }
        if (dt.Rows.Count > 0)
        {
            if (Convert.ToInt32(dt.Rows[0]["CreditPackageID"]) == 0)
            {
                DataRow drOtherCredits = dt.NewRow();
                drOtherCredits["CreditPackageName"] = dt.Rows[0]["CreditPackageName"];
                drOtherCredits["CreditPackageID"] = dt.Rows[0]["CreditPackageID"];
                dt.Rows[0].Delete();
                dt.Rows.Add(drOtherCredits);
            }
        }

        CARETTA.COM.DataBindHelper.BindRadioButtonList(ref rbCreditPackages, dt, "CreditPackageName", "CreditPackageID", "1");
        if (CreditPackageID > 0)
        {
            try
            {
                rbCreditPackages.SelectedValue = CreditPackageID.ToString();
            }
            catch (Exception)
            {
                rbCreditPackages.SelectedValue = "1";
            }
        }
    }

    protected void btnContinue_Click(object sender, ImageClickEventArgs e)
    {
        if (rbCreditPackages.SelectedValue != "0")
        {
            this.Redirect("Company-Credits-SelectPaymentType&CreditPackageType=" + rbCreditPackages.SelectedValue.ToString());
        }
        else if(rbCreditPackages.SelectedValue == "0") 
        {
            this.Redirect("Company-Credits-SelectSpecialCredit");
        }
    }
}
