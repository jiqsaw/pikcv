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

public partial class UserControls_Company_Membership_uCompanyInfo : BaseUserControl
{
    public string PhotoFileName
    {
        get
        {
            if (ViewState["PFN"] == null)
            {
                ViewState.Add("PFN", "");
            }
            return (string)ViewState["PFN"];

        }
        set { ViewState.Add("PFN", value); }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        UImageUpload1.ImageUploaded += new UserControls_Common_uImageUpload.ImageUploadedDelegate(UImageUpload1_ImageUploaded);
        UImageUpload1.RaiseEvents = true;
        if (!IsPostBack)
        {
            ((ImageButton)UImageUpload1.FindControl("btnSubmit")).Visible = false;
            UImageUpload1.ImageSaveType = PIKCV.COM.Enumerations.ImageSaveType.Company;
            imgCompanyDetailLogo.Attributes.Add("onerror", "this.src='" + this.Config(PIKCV.COM.EnumUtil.Config.CompanyImagePath) + "0.png';");
            DataBindHelper.BindListbox(ref lbSectors, this.cmbSectors, "SectorName", "SectorID", "");
            imgAddToListSector.Style.Add("cursor", "pointer");
            imgRemoveToListSector.Style.Add("cursor", "pointer");
            imgAddToListSector.Attributes.Add("onclick", "SwapItem('" + lbSectors.ClientID + "','" + lbSelectedSectors.ClientID + "', ' ')");
            imgRemoveToListSector.Attributes.Add("onclick", "SwapItem('" + lbSelectedSectors.ClientID + "','" + lbSectors.ClientID + "', ' ')");
            imgContinue.Attributes.Add("onmousedown", "return SelectAllListBox('" + lbSelectedSectors.ClientID + "')");
            if (this.smIsLogin == true)
            {
                FillCompanyInfo();
                ltlEditUser.Visible = true;
                ltlDescriptionEdit.Visible = true;
                ltlDescription.Visible = false;
                ltlNewUser.Visible = false;
                pnlCompanyDetails.Visible = true;
                pnlCompanyInformation.Visible = false;
            }
            else {
                ltlEditUser.Visible = false;
                ltlNewUser.Visible = true;
                ltlDescriptionEdit.Visible = false;
                ltlDescription.Visible = true;
                pnlCompanyDetails.Visible = false;
                pnlCompanyInformation.Visible = true;
            }
        }
    }

    private void UImageUpload1_ImageUploaded(string FileName)
    {
        //imgCompanyLogo.ImageUrl = "~/" + this.Config(PIKCV.COM.EnumUtil.Config.CompanyImagePath) + FileName;
        this.PhotoFileName = FileName;
        PIKCV.BUS.Company objCompany = new PIKCV.BUS.Company();
        objCompany.UpdateCompanyPhoto(this.smCompanyID, this.PhotoFileName);
    }

    protected void imgContinue_Click(object sender, ImageClickEventArgs e)
    {
        int SaveCompanyID = 0;
        string ErrMsg = String.Empty;
        string PhoneNumber = txtPhoneNumber.Text.Trim();
        string FaxNumber = txtFaxNumber.Text.Trim();
        string Email = txtEMail.Text.Trim();
        ArrayList arrSelectedSectors = new ArrayList();

        if (Request.Form[lbSelectedSectors.UniqueID] != null)
        {
            arrSelectedSectors.AddRange(Request.Form[lbSelectedSectors.UniqueID].Split(','));
        }

        PIKCV.BUS.Company objCompany = new PIKCV.BUS.Company();
        if (this.smIsLogin == true)
        {
            SaveCompanyID = objCompany.UpdateCompanyInfo(this.smCompanyID, arrSelectedSectors, txtCompanyName.Text,
                txtCompanyDescription.Text, Convert.ToInt32(txtNumberOfWorkers.Text), txtContactName.Text, txtContactLastName.Text,
                txtPhoneNumber.Text, txtFaxNumber.Text, txtEMail.Text, this.PhotoFileName, txtSecretQuestion.Text, txtSecretAnswer.Text);
            //imgCompanyLogo.ImageUrl = "~/" + this.Config(PIKCV.COM.EnumUtil.Config.CompanyImagePath) + this.PhotoFileName;
            if (SaveCompanyID > 0)
            {
                pnlSuccess.Visible = true;
                ltlSuccess.Text = "Üyelik bilgileriniz baþarýyla deðiþtirilmiþtir";
                pnlError.Visible = false;
                this.smCompanyName = txtCompanyName.Text;
                this.smFirstName = txtContactName.Text;
                this.smLastName = txtContactLastName.Text;
            }
            else
            {
                pnlError.Visible = true;
                ltlError.Text = "Üyelik bilgileri deðiþtirilirken bir hata oluþtu lütfen tekrar deneyin";
                pnlSuccess.Visible = false;
            }
        }
        else
        {
            int CompanyUserExistance = objCompany.CompanyExistanceControlForEmail(txtEMail.Text);
            if (CompanyUserExistance == 0)
            {
                SaveCompanyID = objCompany.InsertCompanyInfo(arrSelectedSectors, txtCompanyName.Text, txtCompanyDescription.Text,
            Convert.ToInt32(txtNumberOfWorkers.Text), txtContactName.Text, txtContactLastName.Text,
            PhoneNumber, FaxNumber, Email, txtSecretQuestion.Text, txtSecretAnswer.Text);
                if (SaveCompanyID > 0)
                {
                    this.smCompanyID = SaveCompanyID;
                    UImageUpload1.SendFile();
                    this.smCompanyID = 0;
                    string ActivationCode = PIKCV.COM.Util.CreateActivationNumber(SaveCompanyID);
                    if (objCompany.SaveActivation(SaveCompanyID, ActivationCode))
                    {
                        //Aktivasyon Linkini Mail Yolla 
                        if (MailTemplates.Send_Tmp_ActivationCompany(MailTemplates.ActivationCompany, ActivationCode, SaveCompanyID, txtContactName.Text, txtContactLastName.Text, Email))
                        { //**
                            //**this.LoginControl(txtEMail.Text, txtPassword.Text, String.Empty);
                            this.GoToFeedback(PIKCV.COM.EnumDB.ErrorTypes.SaveCompany);
                        } //**
                        else
                        { //**
                            pnlError.Visible = true;
                            ltlError.Text = "Üyelik iþlemi sýrasýnda bir hata oluþtu. Lütfen tekrar deneyin.";
                            pnlSuccess.Visible = false;
                        } //**
                    }

                    //pnlSuccess.Visible = true;

                    //ltlSuccess.Text = "Üyelik isteðiniz bize ulaþmýþtýr. Üyeliðiniz incelenip en yakýn zamanda kullanýcý adý ve þifreniz e-posta adresinize gönderilecektir.";
                    //pnlError.Visible = false;
                }
                else
                {
                    pnlError.Visible = true;
                    ltlError.Text = "Üyelik iþlemi sýrasýnda bir hata oluþtu. Lütfen tekrar deneyin.";
                    pnlSuccess.Visible = false;
                }
            }
            else if(CompanyUserExistance > 0)
            {
                pnlError.Visible = true;
                ltlError.Text = "Bu email adresiyle daha önceden kayýt yapýlmýþtýr. Bir email adresiyle sadece bir kayýt yapýlabilir.";
                pnlSuccess.Visible = false;
            }
            else if (CompanyUserExistance == -1)
            {
                pnlError.Visible = true;
                ltlError.Text = "Üyelik iþlemi sýrasýnda bir hata oluþtu. Lütfen tekrar deneyin.";
                pnlSuccess.Visible = false;
            }
        }
    }

    private void FillCompanyInfo()
    {
        PIKCV.BUS.Company objCompany = new PIKCV.BUS.Company();
        DataTable dt = objCompany.GetCompanyInfo(this.smCompanyID);
        if (dt.Rows.Count > 0)
        {
            lblCompanyDescription.Text = dt.Rows[0]["CompanyDescription"].ToString();
            lblCompanyName.Text = dt.Rows[0]["CompanyName"].ToString();
            lblCompanyContactLastName.Text = dt.Rows[0]["ContactLastName"].ToString();
            lblCompanyContactFirstName.Text = dt.Rows[0]["ContactName"].ToString();
            lblEmail.Text = dt.Rows[0]["ContactEmail"].ToString();
            lblCompanyFaxNumber.Text = dt.Rows[0]["Fax"].ToString();
            lblNumberOfWorkers.Text = dt.Rows[0]["NumberOfWorkers"].ToString();
            lblCompanyPhoneNumber.Text = dt.Rows[0]["Phone"].ToString();
            
            //this.PhotoFileName = dt.Rows[0]["PhotoFileName"].ToString();
            imgCompanyDetailLogo.ImageUrl = "~/" + this.Config(PIKCV.COM.EnumUtil.Config.CompanyImagePath) + dt.Rows[0]["PhotoFileName"].ToString();

            PIKCV.BUS.Company objCompanies = new PIKCV.BUS.Company();
            DataTable dtCompanySectors = objCompanies.GetCompanySectorNames(this.smCompanyID);
            DataBindHelper.BindRepeater(ref rptSectors, dtCompanySectors);
        }
        else { this.GoToDefaultPage(); }
    }

    //private void FillListBoxForLoginedCompany()
    //{
    //    PIKCV.BUS.Company objCompany = new PIKCV.BUS.Company(); 
    //    DataTable dtCompanySectors = objCompany.GetCompanySectorNames(this.smCompanyID);
    //    DataBindHelper.BindListbox(ref lbSelectedSectors, dtCompanySectors, "SectorName", "SectorID");

    //    DataTable dtSectors = this.cmbSectors;
    //    DataTable dtSectorsNew = new DataTable();

    //    if (dtCompanySectors.Rows.Count > 0)
    //    {
    //        dtSectorsNew.Columns.Add("SectorID");
    //        dtSectorsNew.Columns.Add("SectorName");

    //        bool add = true;
    //        foreach (DataRow drCache in dtSectors.Rows)
    //        {
    //            add = true;
    //            foreach (DataRow dr in dtCompanySectors.Rows)
    //            {
    //                if (dr["SectorID"].ToString() == drCache["SectorID"].ToString())
    //                {
    //                    add = false;
    //                    break;
    //                }
    //            }
    //            if (add)
    //            {
    //                DataRow drNew = dtSectorsNew.NewRow();
    //                drNew["SectorID"] = drCache["SectorID"].ToString();
    //                drNew["SectorName"] = drCache["SectorName"].ToString();
    //                dtSectorsNew.Rows.Add(drNew);
    //            }
    //        }
    //    }
    //    else { dtSectorsNew = dtSectors.Copy(); }

    //    DataBindHelper.BindListbox(ref lbSectors, dtSectorsNew, "SectorName", "SectorID", "");
    //}
}
