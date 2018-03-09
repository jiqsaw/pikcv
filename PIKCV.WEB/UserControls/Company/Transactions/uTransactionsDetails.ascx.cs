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

public partial class UserControls_Company_Transactions_uTransactionsDetails : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Util.IsNumeric(Request.QueryString["type"]))
            {
                FillData(Convert.ToInt32(Request.QueryString["type"]));
            }
            else
            {
                this.GoToDefaultPage();
            }
        }
    }

    protected void FillData(int Type)
    {
        if (Request.Params["type"] != null)
        {
            PIKCV.BUS.Orders objOrders = new PIKCV.BUS.Orders();
            PIKCV.COM.EnumDB.OrderProcessTypeCode ProcessTypeCode = PIKCV.COM.EnumDB.OrderProcessTypeCode.unknown;

            if (Type == (int)PIKCV.COM.EnumDB.OrderProcessTypeCode.non_invoiced) {
                ltlTransaction_non_invoiced.Visible = true;
                ltlTransaction_paid.Visible = false;
                ltlTransaction_unpaid.Visible = false;
                ProcessTypeCode = PIKCV.COM.EnumDB.OrderProcessTypeCode.non_invoiced;
            } else if (Type == (int)PIKCV.COM.EnumDB.OrderProcessTypeCode.paid) {
                ltlTransaction_paid.Visible = true;
                ltlTransaction_non_invoiced.Visible = false;
                ltlTransaction_unpaid.Visible = false;
                ProcessTypeCode = PIKCV.COM.EnumDB.OrderProcessTypeCode.paid;
            } else if (Type == (int)PIKCV.COM.EnumDB.OrderProcessTypeCode.unpaid) {
                ltlTransaction_unpaid.Visible = true;
                ltlTransaction_non_invoiced.Visible = false;
                ltlTransaction_paid.Visible = false;
                ProcessTypeCode = PIKCV.COM.EnumDB.OrderProcessTypeCode.unpaid;
            }
            ddlTransactionType.SelectedValue = Type.ToString();

            if (ProcessTypeCode != PIKCV.COM.EnumDB.OrderProcessTypeCode.unknown) {
                DataTable dt = objOrders.GetTransactions(this.smCompanyID, ProcessTypeCode, this.smLanguageID, PIKCV.COM.EnumDB.OrderTypeCode.CreditBuy);
                if (dt.Rows.Count > 0)
                {
                    UPaging1.GeneratePager(ref dt, rptTransactions);
                    ltlNoRecord.Visible = false;
                    rptTransactions.Visible = true;
                    UPaging1.Visible = true;
                }
                else {
                    ltlNoRecord.Visible = true;
                    rptTransactions.Visible = false;
                    UPaging1.Visible = false;
                }
            }
        }
    }
    protected void ddlTransactionType_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlTransactionType.SelectedValue != null && ddlTransactionType.SelectedValue != string.Empty)
        {
            if (ddlTransactionType.SelectedValue == ((int)PIKCV.COM.EnumDB.OrderProcessTypeCode.unknown).ToString())
            {
                this.Redirect("Company-Transactions-TransactionReport");
            }
            else
            {
                FillData(int.Parse(ddlTransactionType.SelectedValue));
            }
        }
    }
}
