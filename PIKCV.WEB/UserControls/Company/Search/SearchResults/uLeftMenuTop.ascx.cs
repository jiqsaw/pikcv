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

public partial class UserControls_Company_Search_SearchResults_uLeftMenuTop : BaseUserControl
{
    private string strAlert = String.Empty;
    private bool isApp;
    protected void Page_Load(object sender, EventArgs e)
    {
        //Response.Cache.SetNoStore();
        if (!IsPostBack)
        {
            if (CARETTA.COM.Util.IsNumeric(Request.QueryString["isApp"]))
            {
                this.isApp = true;
            }

            DataTable dt = PIKCV.BUS.User.GetEmployeeSearchResults(smEmployeeSearchQueries.Gender,
                smEmployeeSearchQueries.AgeRange,
                smEmployeeSearchQueries.MaritalStates,
                smEmployeeSearchQueries.MilitaryStates,
                smEmployeeSearchQueries.DriverLicenceTypes,
                smEmployeeSearchQueries.Handicapped,
                smEmployeeSearchQueries.Convicted,
                smEmployeeSearchQueries.MartyrRelative,
                smEmployeeSearchQueries.TerrorAggrieved,
                smEmployeeSearchQueries.Countries,
                smEmployeeSearchQueries.TurkeyCities,
                smEmployeeSearchQueries.EducationLevels,
                smEmployeeSearchQueries.EducationStates,
                smEmployeeSearchQueries.HighSchoolEducationLevels,
                smEmployeeSearchQueries.HighSchoolTypes,
                smEmployeeSearchQueries.UniversityEducationLevels,
                smEmployeeSearchQueries.UniversityNames,
                smEmployeeSearchQueries.DepartmentNames,
                smEmployeeSearchQueries.Sectors,
                smEmployeeSearchQueries.Positions,
                smEmployeeSearchQueries.Experience,
                smEmployeeSearchQueries.LabouringTypes,
                smEmployeeSearchQueries.ForeignLanguages1,
                smEmployeeSearchQueries.ForeignLanguages1Reading,
                smEmployeeSearchQueries.ForeignLanguages1Writing,
                smEmployeeSearchQueries.ForeignLanguages1Speaking,
                smEmployeeSearchQueries.ForeignLanguages2,
                smEmployeeSearchQueries.ForeignLanguages2Reading,
                smEmployeeSearchQueries.ForeignLanguages2Writing,
                smEmployeeSearchQueries.ForeignLanguages2Speaking,
                smEmployeeSearchQueries.ForeignLanguages3,
                smEmployeeSearchQueries.ForeignLanguages3Reading,
                smEmployeeSearchQueries.ForeignLanguages3Writing,
                smEmployeeSearchQueries.ForeignLanguages3Speaking,
                smEmployeeSearchQueries.ComputerKnowledgeTypes,
                smEmployeeSearchQueries.SectorsDesired,
                smEmployeeSearchQueries.PositionsDesired,
                smEmployeeSearchQueries.CountriesDesired,
                smEmployeeSearchQueries.CitiesDesired,
                smEmployeeSearchQueries.LabouringTypesDesired,
                (int)smEmployeeSearchQueries.EmployeeSearchType,
                smCompanyID,
                smEmployeeSearchQueries.JobID,
                smEmployeeSearchQueries.ApplicationStatus
                );

            if (dt.Rows.Count < 1)
            {
                this.GoToFeedback(PIKCV.COM.EnumDB.ErrorTypes.NoEmployeeSearchResult);
            }

            rptEmployees.DataSource = dt;
            rptEmployees.DataBind();

            lblEmployeeCount.Text = dt.Rows.Count + " Aday";

            int i = 0;
            foreach (RepeaterItem ritem in rptEmployees.Items)
            {
                //((LinkButton)ritem.Controls[3]).Text = " " + dt.Rows[i]["UserName"].ToString();
                //((TextBox)ritem.Controls[5]).Text = dt.Rows[i]["UserID"].ToString();
                i++;
            }
            ArrayList arr = new ArrayList(250);
            foreach (DataRow dr in dt.Rows)
            {
                arr.Add(dr["UserID"]);
            }

            smEmployeeSearchResultUserIDs = arr;
            if (dt.Rows.Count != 0)
            {
                if (this.smUserID < 1)
                {
                    this.smUserID = Convert.ToInt32(dt.Rows[0]["UserID"]);
                }
                else
                {
                    if (!CARETTA.COM.DataTableHelper.ExistValue(dt, "UserID", this.smUserID.ToString()))
                    {
                        this.smUserID = Convert.ToInt32(dt.Rows[0]["UserID"]);
                    }
                }
            }
            else
                smUserID = -1;

            DataTable dtCOmpanyFolders = new DataTable();
            PIKCV.BUS.Company Comp = new PIKCV.BUS.Company();
            dtCOmpanyFolders = Comp.GetCompanyFolders(this.smCompanyID, false, false);
            CARETTA.COM.DataBindHelper.BindDDL(ref ddlCompanyFolders, dtCOmpanyFolders, "FolderName", "FolderID", "", PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.SendFolder), "0");

            hlAgainSearch.NavigateUrl = "#Company-Search-EmployeeSearch";
            if (!this.isApp) hlAgainSearch.NavigateUrl += "&type=" + ((int)this.smEmployeeSearchQueries.EmployeeSearchType).ToString();
            else hlAgainSearch.NavigateUrl += "&IsApp=1";

        }
        else { 
        
        }
        //dvScript.InnerHtml = String.Empty;
    }

    protected void btnHomePage_Click(object sender, ImageClickEventArgs e)
    {
        this.Redirect("Company-CompanyLogon");
    }

    protected void rptEmployees_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (isApp)
        {
            if ((e.Item.ItemType == ListItemType.Item) || (e.Item.ItemType == ListItemType.AlternatingItem))
            {
                ((Literal)e.Item.FindControl("ltlRate")).Visible = true;
            }
        }
    }

    protected void Page_PreRender(object sender, EventArgs e)
    {
        this.strAlert += "SetClass('" + this.smUserID.ToString() + "');";
        dvScript.InnerHtml = "<script>" + this.strAlert + "</script>";
    }

    protected void lbInterview_Click(object sender, EventArgs e)
    {
        int BoughtUsers = 0;
        ArrayList arrUsersAllChecked = new ArrayList();
        ArrayList arrUsersInterviewWillBeSent = new ArrayList();
        foreach (RepeaterItem item in rptEmployees.Items)
        {
            if (((CheckBox)item.FindControl("CheckBox")).Checked)
            {
                arrUsersAllChecked.Add(Convert.ToInt32(((Literal)item.FindControl("ltlUserID")).Text));
                PIKCV.BUS.Company objCompany = new PIKCV.BUS.Company();
                if (objCompany.CheckBuyContactInfo(this.smCompanyID, Convert.ToInt32(((Literal)item.FindControl("ltlUserID")).Text)))
                {
                    arrUsersInterviewWillBeSent.Add(Convert.ToInt32(((Literal)item.FindControl("ltlUserID")).Text));
                }
            }
        }
        int TotalUserCount = arrUsersAllChecked.Count;

        this.smBuyContactInfoResultUserIDs = arrUsersInterviewWillBeSent;
        this.smInterviewUserIDs = arrUsersAllChecked;

        if (arrUsersInterviewWillBeSent.Count == arrUsersAllChecked.Count)
        {
            this.strAlert = "var wpen = window.open('InsertInterview.aspx', 'PikcvMülakataÇaðýr', 'width=400,height=400,toolbar=no');wpen.focus();";
        }
        else if (arrUsersInterviewWillBeSent.Count == 0)
        {
            this.strAlert = "alert('" + PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.UsersWhichDidNotBoughtBeforeInterviewWarning) + "');";
        }
        else if (arrUsersInterviewWillBeSent.Count != arrUsersAllChecked.Count)
        {
            string Link = "Company-BuyContactInfo-BuyContactInfoResult&UserCount=" + arrUsersAllChecked.Count.ToString()
                      + "&BuyContactInfoResultPageType=" + ((int)PIKCV.COM.Enumerations.BuyContactInfoResultPageType.InsertInterview).ToString();
            this.Redirect(Link);
        }
    }

    protected void lbSendMessage_Click(object sender, EventArgs e)
    {
        int BoughtUsers = 0;
        ArrayList arrUsersAllChecked = new ArrayList();
        ArrayList arrUsersMessageWillBeSent = new ArrayList();
        foreach (RepeaterItem item in rptEmployees.Items)
        {
            if (((CheckBox)item.FindControl("CheckBox")).Checked)
            {
                arrUsersAllChecked.Add(Convert.ToInt32(((Literal)item.FindControl("ltlUserID")).Text));
                PIKCV.BUS.Company objCompany = new PIKCV.BUS.Company();
                if (objCompany.CheckBuyContactInfo(this.smCompanyID, Convert.ToInt32(((Literal)item.FindControl("ltlUserID")).Text)))
                {
                    arrUsersMessageWillBeSent.Add(Convert.ToInt32(((Literal)item.FindControl("ltlUserID")).Text));
                }
            }
        }
        int TotalUserCount = arrUsersAllChecked.Count;

        this.smMessageUserIDs = arrUsersAllChecked;
        this.smBuyContactInfoResultUserIDs = arrUsersMessageWillBeSent;
        if (arrUsersMessageWillBeSent.Count == arrUsersAllChecked.Count)
        {
            this.Redirect("Company-Messages-SendMessage");
        }
        else if (arrUsersMessageWillBeSent.Count == 0)
        {
            this.strAlert = "alert('" + PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.UsersWhichDidNotBoughtBeforeMessageWarning) + "');";
        }
        else if (arrUsersMessageWillBeSent.Count != arrUsersAllChecked.Count)
        {
            string Link = "Company-BuyContactInfo-BuyContactInfoResult&UserCount=" + arrUsersAllChecked.Count.ToString()
                      + "&BuyContactInfoResultPageType=" + ((int)PIKCV.COM.Enumerations.BuyContactInfoResultPageType.SendMessage).ToString();
            this.Redirect(Link);
        }
    }

    protected void lbBuyContactInfo_Click(object sender, EventArgs e)
    {
        PIKCV.BUS.Company objComp = new PIKCV.BUS.Company();
        ArrayList arrUserID = new ArrayList();
        ArrayList arrUsersToBought = new ArrayList();
        int UsersSuccessfullBoughts = 0;
        string Message = "";
        foreach (RepeaterItem item in rptEmployees.Items)
        {
            if (((CheckBox)item.FindControl("CheckBox")).Checked)
            {
                arrUserID.Add(Convert.ToInt32(((Literal)item.FindControl("ltlUserID")).Text));
            }
        }
        for (int i = 0; i < arrUserID.Count; i++)
        {
            if (!(objComp.CheckBuyContactInfo(this.smCompanyID, Convert.ToInt32(arrUserID[i]))))
            {
                arrUsersToBought.Add(arrUserID[i]);
            }
        }

        if (arrUsersToBought.Count == 0)
        {
            Message = "Seçtiðiniz adaylarýn iletiþim bilgileri daha önce satýn alýnmýþtýr. Bilgilere satýn alýnan iletiþim bilgileri klasöründen ulaþabilirsiniz";
        }
        else
        {
            if (arrUsersToBought.Count == arrUserID.Count)
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
                        break;
                    case PIKCV.COM.Enumerations.BuyContactInfoResult.NotEnoughPikCredi:
                        this.Redirect("Company-Jobs-Jobs-NoCredit");
                        break;
                }
            }
            else if (arrUsersToBought.Count != arrUserID.Count)
            {
                this.smBuyContactInfoResultUserIDs = arrUsersToBought;
                this.Redirect("Company-BuyContactInfo-BuyContactInfoResult&UserCount=" + arrUserID.Count.ToString());
            }
        }
        this.strAlert += "alert('" + Message + "');";
    }

    protected void SendToFolder_Click(object sender, EventArgs e)
    {
        PIKCV.BUS.Company Comp = new PIKCV.BUS.Company();
        ArrayList arr = new ArrayList();
        foreach (RepeaterItem item in rptEmployees.Items)
        {
            if (((CheckBox)item.FindControl("CheckBox")).Checked)
            {
                arr.Add(Convert.ToInt32(((Literal)item.FindControl("ltlUserID")).Text));
            }
        }
        string ErrMsg = String.Empty;
        if (Comp.InsertUsersToFolder(Convert.ToInt32(ddlCompanyFolders.SelectedValue), arr))
        {
            ErrMsg = PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.SendToFolderSuccess);
        }
        else
        {
            ErrMsg = PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.SendToFolderFailed);
        }
        this.strAlert += "alert('" + ErrMsg + "');";
    }

    protected void rptEmployees_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "Select")
        {
            this.smUserID = Convert.ToInt32(e.CommandArgument);
        }
    }
}