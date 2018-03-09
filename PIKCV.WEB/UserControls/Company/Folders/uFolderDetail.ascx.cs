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

public partial class UserControls_Company_Folders_uFolderDetail : BaseUserControl
{
    private string strFolderName = String.Empty;

    public int FolderID
    {
        get
        {
            if (ViewState["FID"] == null)
            {
                ViewState.Add("FID", "0");
            }
            return Convert.ToInt32(ViewState["FID"]);
        }
        set { ViewState.Add("FID", value); }
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
        PIKCV.BUS.Company obj = new PIKCV.BUS.Company();
        if (CARETTA.COM.Util.IsNumeric(Request.QueryString["FolderID"]))
        {
            this.FolderID = Convert.ToInt32(Request.QueryString["FolderID"]);

            DataTable dtFolderNames = obj.GetCompanyFolders(this.smCompanyID, false);
            DataBindHelper.BindDDL(ref drpCompanyFolders, dtFolderNames, "FolderName", "FolderID", "", "Klasör seç...", "0");
            drpCompanyFolders.SelectedValue = this.FolderID.ToString();
            this.strFolderName = drpCompanyFolders.SelectedItem.Text;
            ltlSubFolderName.Text = this.strFolderName;

            DataTable dt = obj.GetCompanyFolderDetail(this.FolderID);
            if (dt.Rows.Count > 0)
            {
                if (this.smCompanyID == Convert.ToInt32(dt.Rows[0]["CompanyID"]))
                {
                    FillFolderDetailRepeater();
                }
                else
                    this.Redirect("Company-Folders-FoldersMain");
            }
            else
                this.Redirect("Company-Folders-FoldersMain");
        }
    }

    private void FillFolderDetailRepeater()
    {
        PIKCV.BUS.Company obj = new PIKCV.BUS.Company();
        DataTable dt = obj.GetCompanyFolderDetail(this.FolderID, this.smLanguageID, false);
        DataBindHelper.BindRepeater(ref rptFolders, dt);
        if (dt.Rows.Count > 0)
        {
            lbMessage.Visible = false;
            rptFolders.Visible = true;

            thTemporaryUserEmailHeader.Visible = (bool.Parse(dt.Rows[0]["IsDefault"].ToString()));
            pnlFolderDetail.Visible = true;
        }
        else
        {
            pnlFolderDetail.Visible = false;
            lbMessage.Visible = true;
            rptFolders.Visible = false;
        }
    }

    protected void drpCompanyFolders_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (drpCompanyFolders.SelectedValue != "0")
        {
            PIKCV.BUS.Company obj = new PIKCV.BUS.Company();
            this.FolderID = int.Parse(drpCompanyFolders.SelectedValue);
            this.strFolderName = drpCompanyFolders.SelectedItem.Text;
            ltlSubFolderName.Text = this.strFolderName;
            FillFolderDetailRepeater();
        }
    }

    protected void rptFolders_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if ((e.Item.ItemType == ListItemType.Item) || (e.Item.ItemType == ListItemType.AlternatingItem) || (e.Item.ItemType == ListItemType.Footer))
        {
            PIKCV.BUS.Company obj = new PIKCV.BUS.Company();
            ArrayList arrUsers = new ArrayList();
            int UsersSuccessfullBoughts = 0;
            string Message = "";
            if (e.CommandName == "UserDetail")
            {
                this.smUserID = Convert.ToInt32(e.CommandArgument);
                this.smEmployeeSearchResultUserIDs = new ArrayList();
                this.smEmployeeSearchResultUserIDs.Add(this.smUserID);
                Session.Remove(PIKCV.COM.EnumUtil.Sess.EmployeeSearchQueries.ToString());
                this.Redirect("Company-Membership-UserInfo");
            }
            if (Request.Form["chFolders"] != null)
            {
                arrUsers.AddRange(Request.Form["chFolders"].ToString().Split(','));
                if (e.CommandName == "CopyToFolder")
                {
                    if (obj.InsertUsersToFolder(int.Parse(((DropDownList)e.Item.FindControl("drpCopyCutFolderNames")).SelectedValue), arrUsers))
                    {
                        dvScript.InnerHtml = SendFolderMessage(PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.CopyToFolderSuccess));
                    }
                    else
                    {
                        dvScript.InnerHtml = SendFolderMessage(PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.CopyTofolderFailed));
                    }
                }
                else if (e.CommandName == "CutToFolder")
                {
                    if (obj.UpdateUsersFolders(this.FolderID, int.Parse(((DropDownList)e.Item.FindControl("drpCopyCutFolderNames")).SelectedValue), arrUsers))
                    {
                        dvScript.InnerHtml = SendFolderMessage(PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.CutToFolderSuccess));
                    }
                    else
                    {
                        dvScript.InnerHtml = SendFolderMessage(PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.CutToFolderFailed));
                    }
                }
                else if (e.CommandName == "OpenInterviewPage")
                {
                    int TotalUserCount = arrUsers.Count;
                    int BoughtUsers = 0;
                    ArrayList arrUsersInterviewWillBeSent = new ArrayList();
                    for (int i = 0; i < arrUsers.Count; i++)
                    {
                        PIKCV.BUS.Company objCompany = new PIKCV.BUS.Company();
                        if (objCompany.CheckBuyContactInfo(this.smCompanyID, Convert.ToInt32(arrUsers[i])))
                        {
                            BoughtUsers++;
                            arrUsersInterviewWillBeSent.Add(arrUsers[i]);
                        }
                    }
                    this.smBuyContactInfoResultUserIDs = arrUsersInterviewWillBeSent;
                    this.smInterviewUserIDs = arrUsers;
                    if (arrUsersInterviewWillBeSent.Count == arrUsers.Count)
                    {
                        dvScript.InnerHtml = "<script>var wpen = window.open('InsertInterview.aspx', 'PikcvMülakataÇaðýr', 'width=400,height=400,toolbar=no');wpen.focus();</script>";
                    }
                    else if (arrUsersInterviewWillBeSent.Count == 0)
                    {
                        dvScript.InnerHtml = "<script>alert('" + PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.UsersWhichDidNotBoughtBeforeInterviewWarning) + "');</script>";
                    }
                    else if (arrUsersInterviewWillBeSent.Count != arrUsers.Count)
                    {
                        Message = "Company-BuyContactInfo-BuyContactInfoResult&UserCount=" + arrUsers.Count.ToString()
                                  + "&BuyContactInfoResultPageType=" + ((int)PIKCV.COM.Enumerations.BuyContactInfoResultPageType.InsertInterview).ToString();
                        this.Redirect(Message);
                    }
                }
                else if (e.CommandName == "Delete")
                {
                    if (obj.DeleteUserFromFolder(this.FolderID, arrUsers))
                    {
                        dvScript.InnerHtml = SendFolderMessage(PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.DeleteFromFolderSuccsess));
                    }
                    else
                    {
                        dvScript.InnerHtml = SendFolderMessage(PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.DeleteFromFolderFailed));
                    }
                }
                else if (e.CommandName == "SendMessage")
                {
                    int TotalUserCount = arrUsers.Count;
                    int BoughtUsers = 0;
                    ArrayList arrUsersMessageWillBeSent = new ArrayList();
                    for (int i = 0; i < arrUsers.Count; i++)
                    {
                        PIKCV.BUS.Company objCompany = new PIKCV.BUS.Company();
                        if (objCompany.CheckBuyContactInfo(this.smCompanyID, Convert.ToInt32(arrUsers[i])))
                        {
                            BoughtUsers++;
                            arrUsersMessageWillBeSent.Add(arrUsers[i]);
                        }
                    }

                    this.smMessageUserIDs = arrUsers;
                    this.smBuyContactInfoResultUserIDs = arrUsersMessageWillBeSent;
                    if (arrUsersMessageWillBeSent.Count == arrUsers.Count)
                    {
                        this.Redirect("Company-Messages-SendMessage");
                    }
                    else if (arrUsersMessageWillBeSent.Count == 0)
                    {
                        dvScript.InnerHtml = "<script>alert('" + PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.UsersWhichDidNotBoughtBeforeMessageWarning) + "');</script>";
                    }
                    else if(arrUsersMessageWillBeSent.Count != arrUsers.Count)
                    {
                        Message = "Company-BuyContactInfo-BuyContactInfoResult&UserCount=" + arrUsers.Count.ToString()
                                  + "&BuyContactInfoResultPageType=" + ((int)PIKCV.COM.Enumerations.BuyContactInfoResultPageType.SendMessage).ToString();
                        this.Redirect(Message);
                    }
                }
                else if (e.CommandName == "BuyCommunicationInformation")
                {
                    PIKCV.BUS.Company objComp = new PIKCV.BUS.Company();
                    //int Difference = 0;

                    ArrayList arrUsersToBought = new ArrayList();
                    for (int i = 0; i<arrUsers.Count; i++)
                    {
                        if (!(objComp.CheckBuyContactInfo(this.smCompanyID, Convert.ToInt32(arrUsers[i]))))
                        {
                            arrUsersToBought.Add(arrUsers[i]);
                        }
                    }

                    if (arrUsersToBought.Count == 0)
                    {
                        Message = "Seçtiðiniz adaylarýn iletiþim bilgileri daha önce satýn alýnmýþtýr. Bilgilere satýn alýnan iletiþim bilgileri klasöründen ulaþabilirsiniz";
                    }
                    else
                    {
                        if (arrUsersToBought.Count == arrUsers.Count)
                        {
                            PIKCV.COM.Enumerations.BuyContactInfoResult BuyComtactInfoResult = objComp.BuyContactInfo(this.smCompanyID, arrUsersToBought, 0, ref UsersSuccessfullBoughts);
                            switch (BuyComtactInfoResult)
                            {
                                case PIKCV.COM.Enumerations.BuyContactInfoResult.Success:
                                    DataTable dt = objComp.GetCompanyInfo(this.smCompanyID);
                                    if (dt.Rows.Count > 0)
                                        this.smPikCredi = dt.Rows[0]["Credits"].ToString();
                                    Message = "Seçtiðiniz adaylarýn iletiþim bilgileri satýnalýnmýþtýr." +
                                              "Bilgilere satýnalýnan iletiþim bilgileri klasöründen ulaþabilirsiniz." +
                                              "Kalan krediniz:" + this.smPikCredi.ToString();
                                    break;
                                case PIKCV.COM.Enumerations.BuyContactInfoResult.Failed:
                                    Message = PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.BuyContactInfoFailed);
                                    dvScript.InnerHtml = SendFolderMessage(Message);
                                    break;
                                case PIKCV.COM.Enumerations.BuyContactInfoResult.NotEnoughPikCredi:
                                    this.Redirect("Company-Jobs-Jobs-NoCredit");
                                    //Response.Write("<script>alert('" + PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.NoCredit) + "');" + "window.location.href('Pikcv.aspx?Pik=Company-Credits-SelectPaymentType');" + "</script>");
                                    break;
                            }
                            dvScript.InnerHtml = SendFolderMessage(Message);
                        }
                        else if (arrUsersToBought.Count != arrUsers.Count)
                        {
                            this.smBuyContactInfoResultUserIDs = arrUsersToBought;
                            Message = "Company-BuyContactInfo-BuyContactInfoResult&UserCount=" + arrUsers.Count.ToString()
                                  + "&BuyContactInfoResultPageType=" + ((int)PIKCV.COM.Enumerations.BuyContactInfoResultPageType.BuyContactInfo).ToString();
                            this.Redirect(Message);
                        }
                    }

                    dvScript.InnerHtml = "<script>alert('" + Message + "');</script>";
                }
            }
            else
            {
                dvScript.InnerHtml = SendFolderMessage(PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.SelectAtLeastOneUser));
            }
            FillFolderDetailRepeater();
        }
    }

    private string SendFolderMessage(string Message)
    {
        string FullMessage = "<script>alert('";
        FullMessage = FullMessage + Message;
        FullMessage = FullMessage + "');";
        FullMessage = FullMessage + "window.location.href='Pikcv.aspx?Pik=Company-Folders-FolderDetail&FolderID=";
        FullMessage = FullMessage + this.FolderID.ToString() + "';";
        FullMessage = FullMessage + "</script>";
        return FullMessage;
    }

    protected void rptFolders_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        PIKCV.BUS.Company obj = new PIKCV.BUS.Company();
        if (e.Item.ItemType == ListItemType.Footer)
        {
            DropDownList drpCopyCutFolderNames = (DropDownList)e.Item.FindControl("drpCopyCutFolderNames");
            DataBindHelper.BindDDL(ref drpCopyCutFolderNames, obj.GetCompanyFolders(this.smCompanyID, false, false), "FolderName", "FolderID", "-1", PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.SendFolder), "-1");

            DataTable dt = obj.GetCompanyFolderDetail(this.FolderID);
            if (dt.Rows.Count > 0)
            {
                PIKCV.COM.EnumDB.FolderTypeID FolderType = (PIKCV.COM.EnumDB.FolderTypeID)Convert.ToInt32(dt.Rows[0]["FolderTypeID"]);
                if (FolderType == PIKCV.COM.EnumDB.FolderTypeID.UsersWillBeBought || FolderType == PIKCV.COM.EnumDB.FolderTypeID.UsersBough)
                {
                    ((ImageButton)e.Item.FindControl("btnCutToFolder")).Visible = false;
                }
                else
                {
                    ((ImageButton)e.Item.FindControl("btnCutToFolder")).Visible = true;
                }
                if (FolderType == PIKCV.COM.EnumDB.FolderTypeID.UsersBough)
                {
                    ((Panel)e.Item.FindControl("pnlBuyCommunicationInformation")).Visible = false;
                }
                else
                {
                    ((Panel)e.Item.FindControl("pnlBuyCommunicationInformation")).Visible = true;
                }
            }
            else { this.GoToDefaultPage(); }
        }
        else if ((e.Item.ItemType == ListItemType.Item) || (e.Item.ItemType == ListItemType.AlternatingItem))
        {
            ((Panel)e.Item.FindControl("pnlContactInfo")).Visible = ((int.Parse(((Literal)e.Item.FindControl("ltlIsOwned")).Text)) > 0);
            int UserID = int.Parse(((Literal)e.Item.FindControl("ltlUserID")).Text);
            Repeater rptFolderNames = ((Repeater)e.Item.FindControl("rptFolderNames"));
            DataBindHelper.BindRepeater(ref rptFolderNames, obj.GetCompanyFolderDetailByUserID(UserID, this.smCompanyID));
            ((Panel)e.Item.FindControl("pnlTemporaryUserEmail")).Visible = (bool.Parse(((Literal)e.Item.FindControl("ltlIsFolderDefault")).Text));
        }
    }
}
