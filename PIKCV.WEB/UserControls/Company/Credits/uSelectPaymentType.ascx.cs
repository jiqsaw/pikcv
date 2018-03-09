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

public partial class UserControls_Company_Credits_uSelectPaymentType : BaseUserControl
{
    public int CreditPackageTypeID
    {
        get
        {
            if (ViewState["PID"] == null)
            {
                ViewState.Add("PID", "0");
            }
            return Convert.ToInt32(ViewState["PID"]);
        }
        set { ViewState.Add("PID", value); }
    }

    public int OtherPackageCredits
    {
        get
        {
            if (ViewState["OPC"] == null)
            {
                ViewState.Add("OPC", "0");
            }
            return Convert.ToInt32(ViewState["OPC"]);
        }
        set { ViewState.Add("OPC", value); }
    }

    public double OtherPackageMultiplier
    {
        get
        {
            if (ViewState["OPCM"] == null)
            {
                ViewState.Add("OPCM", "0");
            }
            return Convert.ToInt32(ViewState["OPCM"]);
        }
        set { ViewState.Add("OPCM", value); }
    }

    public bool IsOtherPackage
    {
        get
        {
            if (ViewState["IOP"] == null)
            {
                ViewState.Add("IOP", "true");
            }
            return Convert.ToBoolean(ViewState["IOP"]);
        }
        set { ViewState.Add("IOP", value); }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Util.IsNumeric(Request.QueryString["CreditPackageType"]))
            {
                this.CreditPackageTypeID = Convert.ToInt32(Request.QueryString["CreditPackageType"]);
                if (Util.IsNumeric(Request.QueryString["OtherPackageCredits"]))
                {
                    int MinCredits = 0;
                    this.OtherPackageCredits = Convert.ToInt32(Request.QueryString["OtherPackageCredits"]);
                    PIKCV.BUS.Credits obj = new PIKCV.BUS.Credits();
                    DataTable dt = obj.GetCreditDetail(0);
                    if (dt.Rows.Count > 0)
                    {
                        MinCredits = Convert.ToInt32(dt.Rows[0]["Credits"]);
                        this.OtherPackageMultiplier = Convert.ToDouble(dt.Rows[0]["Multiplier"]);
                    }
                    if (this.OtherPackageCredits >= MinCredits)
                    {
                        this.IsOtherPackage = true;
                    }
                    else
                    {
                        this.Redirect("Company-Credits-SelectCreditPackage");
                    }
                }
                else { this.IsOtherPackage = false; }
                FillForm();
            }
            else
            {
                this.Redirect("Company-Credits-SelectCreditPackage");
            }
        }
    }

    private void FillForm()
    {
        PIKCV.BUS.Credits obj = new PIKCV.BUS.Credits();
        DataTable dt = obj.GetCreditDetail(this.CreditPackageTypeID);
        double Credtits = 0;
        if (this.IsOtherPackage)
        {
            lbCredits.Text = this.OtherPackageCredits.ToString();
            Credtits = this.OtherPackageCredits * Convert.ToDouble(dt.Rows[0]["Multiplier"]);
            lbPrice.Text = Credtits.ToString();
        }
        else
        {
            if (dt.Rows.Count > 0)
            {
                lbCredits.Text = dt.Rows[0]["Credits"].ToString();
                Credtits = Convert.ToInt32(dt.Rows[0]["Credits"]) * Convert.ToDouble(dt.Rows[0]["Multiplier"]);
                lbPrice.Text = Credtits.ToString();
            }
            else
            {
                this.Redirect("Company-Credits-SelectCreditPackage");
            }
        }

        PIKCV.BUS.Company objCompany = new PIKCV.BUS.Company();
        dt = objCompany.GetCompanyInfo(this.smCompanyID);
        if (dt.Rows.Count > 0)
        {
            if (Convert.ToInt32(dt.Rows[0]["MaxLoan"]) < Convert.ToInt32(lbPrice.Text))
            {
                pnlPaymentTypeLoan.Visible = false;
                rbLoan.Checked = false;
                rbTransfer.Checked = true;
                btnSubmit_Click(new object(), null);
            }
        }
        else
        { this.Redirect("Company-Credits-SelectCreditPackage"); }
    }

    protected void btnSubmit_Click(object sender, ImageClickEventArgs e)
    {
        pnlPackageDetail.Visible = false;
        pnlLoan.Visible = rbLoan.Checked;
        pnlTransfer.Visible = rbTransfer.Checked;
    }

    protected void btnContinueTransfer_Click(object sender, ImageClickEventArgs e)
    {
        pnlTransfer.Visible = false;
        MakePayment(PIKCV.COM.EnumDB.PaymentType.Transfer);
    }

    protected void btnContinueLoad_Click(object sender, ImageClickEventArgs e)
    {
        pnlLoan.Visible = false;
        MakePayment(PIKCV.COM.EnumDB.PaymentType.Loan);
    }

    private void MakePayment(PIKCV.COM.EnumDB.PaymentType PaymentType)
    {
        PIKCV.BUS.Credits obj = new PIKCV.BUS.Credits();
        int SavedCreditOrderID = 0;
        if (this.IsOtherPackage)
        {

            SavedCreditOrderID = obj.InsertCreditOrders(this.smCompanyID, this.CreditPackageTypeID, 0, 0, this.OtherPackageCredits, this.OtherPackageMultiplier, PIKCV.COM.EnumDB.OrderTypeCode.CreditBuy, PaymentType, this.IsOtherPackage);
        }
        else
        {
            DataTable dt = obj.GetCreditDetail(this.CreditPackageTypeID);
            if (dt.Rows.Count > 0)
            {
                SavedCreditOrderID = obj.InsertCreditOrders(this.smCompanyID, this.CreditPackageTypeID, Convert.ToInt32(dt.Rows[0]["Credits"]), Convert.ToInt32(dt.Rows[0]["Multiplier"]), 0, 0, PIKCV.COM.EnumDB.OrderTypeCode.CreditBuy, PaymentType, this.IsOtherPackage); 
            }
            else
            {
                this.Redirect("Company-Credits-SelectCreditPackage");
            }
        }
        if (SavedCreditOrderID > 0)
        {
            DataTable dt = obj.GetCreditOrderDetail(SavedCreditOrderID);
            if (dt.Rows.Count > 0)
            {
                double TotalAmount = 0;
                if (this.IsOtherPackage)
                {
                    lbApprovalCreditPackageName.Text = "Pik Kredi Alýmý (" + dt.Rows[0]["OtherPackageQuantity"].ToString() + ")";
                    TotalAmount = Convert.ToInt32(dt.Rows[0]["OtherPackageQuantity"]) * Convert.ToDouble(dt.Rows[0]["OtherPackagePrice"]);
                    lbApprovalPrice.Text = TotalAmount.ToString() + " YTL";
                }
                else
                {
                    lbApprovalCreditPackageName.Text = "Pik Kredi Alýmý (" + dt.Rows[0]["Quantity"].ToString() + ")";
                    TotalAmount = Convert.ToInt32(dt.Rows[0]["Quantity"]) * Convert.ToDouble(dt.Rows[0]["ItemPrice"]);
                    lbApprovalPrice.Text = TotalAmount.ToString() + " YTL";
                }
                lbOrderDate.Text = string.Format("{0:d}", dt.Rows[0]["OrderDate"]);
                lbOrderType.Text = ((PIKCV.COM.EnumDB.PaymentType)(Convert.ToInt32(dt.Rows[0]["PaymentType"]))).ToString();
                
            }
            if (PaymentType == PIKCV.COM.EnumDB.PaymentType.Transfer)
            {
                lbApprovalMessage.Text = "Talebiniz alýndý, ödeme sonrasýnda sitemizde iþlem yapabileceksiniz.";
            }
            else {


                dvMsg.Visible = false;
            }
            
        }
        else
        {
            lbApprovalMessage.Text = "Kayýt sýrasýnda bir hata oluþtu. Lütfen tekrar deneyin.";
        }
        pnlHeader.Visible = false;
        pnlApproval.Visible = true;

        PIKCV.BUS.Company objCompany = new PIKCV.BUS.Company();
        this.smPikCredi = objCompany.GetCompanyInfo(this.smCompanyID).Rows[0]["Credits"].ToString();


        if (this.smRememberURL != String.Empty)
        {
            string strUrl = this.smRememberURL;
            this.smRememberURL = String.Empty;
            Response.Redirect(strUrl);
        }
    }
}
