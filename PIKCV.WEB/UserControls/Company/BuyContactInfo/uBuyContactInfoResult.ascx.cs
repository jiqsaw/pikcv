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

public partial class UserControls_Company_BuyContactInfo_uBuyContactInfoResult : BaseUserControl
{
    public PIKCV.COM.Enumerations.BuyContactInfoResultPageType BuyContactInfoResultPageType
    {
        get
        {
            if (ViewState["PTY"] == null)
            {
                ViewState.Add("PTY", PIKCV.COM.Enumerations.BuyContactInfoResultPageType.Unknown);
            }
            return (PIKCV.COM.Enumerations.BuyContactInfoResultPageType)(Convert.ToInt32(ViewState["PTY"]));
        }
        set { ViewState.Add("PTY", value); }
    }


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (CARETTA.COM.Util.IsNumeric(Request.QueryString["UserCount"]) && CARETTA.COM.Util.IsNumeric(Request.QueryString["BuyContactInfoResultPageType"]))
            {
                this.BuyContactInfoResultPageType = (PIKCV.COM.Enumerations.BuyContactInfoResultPageType)Convert.ToInt32(Request.QueryString["BuyContactInfoResultPageType"]);
                if (this.BuyContactInfoResultPageType != PIKCV.COM.Enumerations.BuyContactInfoResultPageType.BuyContactInfo && this.BuyContactInfoResultPageType != PIKCV.COM.Enumerations.BuyContactInfoResultPageType.InsertInterview && this.BuyContactInfoResultPageType != PIKCV.COM.Enumerations.BuyContactInfoResultPageType.SendMessage)
                {
                    this.BuyContactInfoResultPageType = PIKCV.COM.Enumerations.BuyContactInfoResultPageType.Unknown;
                }
                FillForm(); 
            }
            else { this.GoToDefaultPage(); }
        }
    }

    private void FillForm()
    {
        switch (this.BuyContactInfoResultPageType)
        {
            case PIKCV.COM.Enumerations.BuyContactInfoResultPageType.BuyContactInfo:
                int UsersWillBeboughtCount = this.smBuyContactInfoResultUserIDs.Count;
                int UsersWillNotBought = Convert.ToInt32(Request.QueryString["UserCount"]) - this.smBuyContactInfoResultUserIDs.Count;
                ltlBuyContactInfoResult.Text = "Seçtiðiniz " + UsersWillNotBought.ToString() + " adayýn iletiþim bilgisi daha önce satýn alýnmýþtýr," +
                               "bilgilerine satýn alýnan iletiþim bilgileri klasöründen ulaþabilirsiniz." +
                               "<br>Diðer " + UsersWillBeboughtCount.ToString() + " adayýn iletiþim bilgisini almak için devam tuþuna basýnýz";
                btnContinueWithoutBuyContactInfo.Visible = false;
                break;
            case PIKCV.COM.Enumerations.BuyContactInfoResultPageType.SendMessage:
                int MessagesWillNotBeSent = 0;
                MessagesWillNotBeSent = this.smMessageUserIDs.Count - this.smBuyContactInfoResultUserIDs.Count;
                ltlBuyContactInfoResult.Text = "Seçtiðiniz " + MessagesWillNotBeSent.ToString() + " adayýn iletiþim bilgisi satýn alýnmamýþtýr." +
                               "Bu adaylarý mülakata çaðýrabilmek için iletiþim bilgilerini  satýn almanýz gerekmektedir" +
                               "<br>Satýnalma iþlemini yapmak için týklayýnýz";
                btnContinueWithoutBuyContactInfo.Visible = true;
                break;
            case PIKCV.COM.Enumerations.BuyContactInfoResultPageType.InsertInterview:
                int InterviewsWillBeSent = 0;
                InterviewsWillBeSent = this.smInterviewUserIDs.Count - this.smBuyContactInfoResultUserIDs.Count;
                ltlBuyContactInfoResult.Text = "Seçtiðiniz " + InterviewsWillBeSent.ToString() + " adayýn iletiþim bilgisi satýn alýnmamýþtýr." +
                               "Bu adaylara mesaj göndermek için iletiþim bilgilerini  satýn almanýz gerekmektedir." +
                               "<br>Satýnalma iþlemini yapmak için týklayýnýz";
                btnContinueWithoutBuyContactInfo.Visible = true;
                break;
            case PIKCV.COM.Enumerations.BuyContactInfoResultPageType.Unknown:
                this.GoToDefaultPage();
                break;
        }
    }
    protected void btnContinue_Click(object sender, ImageClickEventArgs e)
    {
        int UsersSuccessfullBoughts = 0;
        string Message = "";
        PIKCV.BUS.Company objComp = new PIKCV.BUS.Company();
        PIKCV.COM.Enumerations.BuyContactInfoResult BuyComtactInfoResult = PIKCV.COM.Enumerations.BuyContactInfoResult.Failed;

        switch (this.BuyContactInfoResultPageType)
        {
            case PIKCV.COM.Enumerations.BuyContactInfoResultPageType.BuyContactInfo:
                BuyComtactInfoResult = objComp.BuyContactInfo(this.smCompanyID, this.smBuyContactInfoResultUserIDs, 0, ref UsersSuccessfullBoughts);
                switch (BuyComtactInfoResult)
                {
                    case PIKCV.COM.Enumerations.BuyContactInfoResult.Success:
                        DataTable dt = objComp.GetCompanyInfo(this.smCompanyID);
                        if (dt.Rows.Count > 0)
                            this.smPikCredi = dt.Rows[0]["Credits"].ToString();
                        Message = "<script>alert('Seçtiðiniz adaylarýn iletiþim bilgileri satýnalýnmýþtýr." +
                                  "Bilgilere satýnalýnan iletiþim bilgileri klasöründen ulaþabilirsiniz." +
                                  "Kalan krediniz:" + this.smPikCredi.ToString() + "');" +
                                  "window.location.href='Pikcv.aspx?Pik=Company-Folders-FoldersMain'" +
                                  "</script>";
                        this.smBuyContactInfoResultUserIDs = null;
                        Response.Write(Message);
                        break;
                    case PIKCV.COM.Enumerations.BuyContactInfoResult.Failed:
                        Message = PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.BuyContactInfoFailed);
                        Response.Write("<script>alert('" + Message + "');</script>");
                        break;
                    case PIKCV.COM.Enumerations.BuyContactInfoResult.NotEnoughPikCredi:
                        this.Redirect("Company-Jobs-Jobs-NoCredit");
                        break;
                }
                break;
            case PIKCV.COM.Enumerations.BuyContactInfoResultPageType.SendMessage:
                BuyComtactInfoResult = objComp.BuyContactInfo(this.smCompanyID, this.smMessageUserIDs, 0, ref UsersSuccessfullBoughts);
                switch (BuyComtactInfoResult)
                {
                    case PIKCV.COM.Enumerations.BuyContactInfoResult.Success:
                        DataTable dt = objComp.GetCompanyInfo(this.smCompanyID);
                        if (dt.Rows.Count > 0)
                            this.smPikCredi = dt.Rows[0]["Credits"].ToString();
                        Message = "<script>alert('Seçtiðiniz adaylarýn iletiþim bilgileri satýnalýnmýþtýr." +
                                  "Bilgilere satýnalýnan iletiþim bilgileri klasöründen ulaþabilirsiniz." +
                                  "Kalan krediniz:" + this.smPikCredi.ToString() + "');" +
                                  "window.location.href('pikcv.aspx?Pik=Company-Messages-SendMessage');" +
                                  "</script>";
                        this.smBuyContactInfoResultUserIDs = null;
                        Response.Write(Message);
                        break;
                    case PIKCV.COM.Enumerations.BuyContactInfoResult.Failed:
                        Message = PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.BuyContactInfoFailed);
                        Response.Write("<script>alert('" + Message + "');</script>");
                        break;
                    case PIKCV.COM.Enumerations.BuyContactInfoResult.NotEnoughPikCredi:
                        this.Redirect("Company-Jobs-Jobs-NoCredit");
                        break;
                }
                break;
            case PIKCV.COM.Enumerations.BuyContactInfoResultPageType.InsertInterview:
                BuyComtactInfoResult = objComp.BuyContactInfo(this.smCompanyID, this.smInterviewUserIDs, 0, ref UsersSuccessfullBoughts);
                switch (BuyComtactInfoResult)
                {
                    case PIKCV.COM.Enumerations.BuyContactInfoResult.Success:
                        DataTable dt = objComp.GetCompanyInfo(this.smCompanyID);
                        if (dt.Rows.Count > 0)
                            this.smPikCredi = dt.Rows[0]["Credits"].ToString();
                        Message = "<script>alert('Seçtiðiniz adaylarýn iletiþim bilgileri satýnalýnmýþtýr." +
                                  "Bilgilere satýnalýnan iletiþim bilgileri klasöründen ulaþabilirsiniz." +
                                  "Kalan krediniz:" + this.smPikCredi.ToString() + "');" +
                                  "var wpen = window.open('InsertInterview.aspx', 'PikcvMülakataÇaðýr', 'width=400,height=400,toolbar=no');wpen.focus();" +
                                  "</script>";
                        this.smBuyContactInfoResultUserIDs = null;
                        Response.Write(Message);
                        break;
                    case PIKCV.COM.Enumerations.BuyContactInfoResult.Failed:
                        Message = PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.BuyContactInfoFailed);
                        Response.Write("<script>alert('" + Message + "');</script>");
                        break;
                    case PIKCV.COM.Enumerations.BuyContactInfoResult.NotEnoughPikCredi:
                        this.Redirect("Company-Jobs-Jobs-NoCredit");
                        break;
                }
                break;
        }
    }
    protected void btnContinueWithoutBuyContactInfo_Click(object sender, ImageClickEventArgs e)
    {
        if (this.BuyContactInfoResultPageType == PIKCV.COM.Enumerations.BuyContactInfoResultPageType.InsertInterview)
        {
            this.smInterviewUserIDs = this.smBuyContactInfoResultUserIDs;
            Response.Write("<script>var wpen = window.open('InsertInterview.aspx', 'PikcvMülakataÇaðýr', 'width=400,height=400,toolbar=no');wpen.focus();</script>");
        }
        else if (this.BuyContactInfoResultPageType == PIKCV.COM.Enumerations.BuyContactInfoResultPageType.SendMessage)
        {
            this.smMessageUserIDs = this.smBuyContactInfoResultUserIDs;
            this.Redirect("Company-Messages-SendMessage");
        }
    }
}
