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

public partial class UserControls_Company_TemporaryUsers_uTemporaryUsersFolderDeail : BaseUserControl
{
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

    public int FolderIDToSend
    {
        get
        {
            if (ViewState["NFID"] == null)
            {
                ViewState.Add("NFID", "0");
            }
            return Convert.ToInt32(ViewState["NFID"]);
        }
        set { ViewState.Add("NFID", value); }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillForm();

        }
    }

    private void GetFolderIDToSend(int CompanyID)
    {
        PIKCV.BUS.Company obj = new PIKCV.BUS.Company();
        
        
        
        DataTable dt = obj.GetCompanyFolderByFolderType(CompanyID, PIKCV.COM.EnumDB.FolderTypeID.UsersWillBeBought, false);
        if (dt.Rows.Count > 0)
        {
            this.FolderIDToSend = Convert.ToInt32(dt.Rows[0]["FolderID"]);
        }
        else { this.GoToDefaultPage(); }
        //DataTable dt = obj.GetCompanyFolders(CompanyID, false);
        ///////TODO: Folder type geldiðinde deðiþecek
        //foreach (DataRow dr in dt.Rows)
        //{
        //    if (dr["FolderName"].ToString() == "Satýn Alýnacaklar")
        //    {
        //        this.FolderIDToSend = Convert.ToInt32(dr["FolderID"]);
        //        break;
        //    }
        //}
        /////////////////////////
    }

    private void FillForm()
    {
        PIKCV.BUS.Company obj = new PIKCV.BUS.Company();
        DataTable dtTemporaryUsers = PIKCV.BUS.TemporaryUsers.GetTemporaryUserDetail(this.smTemporaryUserID);
        if (dtTemporaryUsers.Rows.Count > 0)
        {
            this.FolderID = Convert.ToInt32(dtTemporaryUsers.Rows[0]["FolderID"]);
            DataTable dt = obj.GetCompanyFolderDetail(this.FolderID);
            if (dt.Rows.Count > 0)
            {
                lbFolderName.Text = dt.Rows[0]["FolderName"].ToString();
                GetFolderIDToSend(Convert.ToInt32(dt.Rows[0]["CompanyID"]));
                dt = obj.GetCompanyFolderDetail(this.FolderID, PIKCV.COM.EnumDB.LanguageID.Turkish, false);
                if (dt.Rows.Count > 0)
                {
                    DataBindHelper.BindRepeater(ref rptFolders, dt);
                    rptFolders.Visible = true;
                    lbMessage.Visible = false;
                }
                else
                {
                    lbMessage.Text = "Dosya içinde herhangibir kullanýcý bulunamadý!";
                    lbMessage.Visible = true;
                    rptFolders.Visible = false;
                }
            }
            else
            {
                lbMessage.Text = "Aradýðýnýz dosya bulunamadý!";
                lbMessage.Visible = true;
                rptFolders.Visible = false;
            }
        }
        else
        {
            lbMessage.Text = "Sisteme baðlanýrken bir hata oluþtu!";
            lbMessage.Visible = true;
            rptFolders.Visible = false;
        }
    }

    protected void rptFolders_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if ((e.Item.ItemType == ListItemType.Item) || (e.Item.ItemType == ListItemType.AlternatingItem) || (e.Item.ItemType == ListItemType.Footer))
        {
            if (e.CommandName == "UserDetail")
            {
                this.smUserID = Convert.ToInt32(e.CommandArgument);
                this.smEmployeeSearchResultUserIDs = new ArrayList();
                this.smEmployeeSearchResultUserIDs.Add(this.smUserID);
                this.smMemberType = PIKCV.COM.EnumDB.MemberTypes.TemporaryUser;
                this.smIsLogin = true;
                Session.Remove(PIKCV.COM.EnumUtil.Sess.EmployeeSearchQueries.ToString());
                Response.Write("<script>window.open('TemporaryUsers/TemporaryUsersUserInfo.aspx', 'PikcvKullanýcýDetay', 'toolbar=no, scrollbars, width=815, height=650')</script>");
            }
            else
            {
                PIKCV.BUS.Company obj = new PIKCV.BUS.Company();
                ArrayList arrUsers = new ArrayList();
                if (Request.Form["chFolders"] != null)
                {
                    arrUsers.AddRange(Request.Form["chFolders"].ToString().Split(','));
                    if (e.CommandName == "Delete")
                    {
                        if (obj.DeleteUserFromFolder(this.FolderID, arrUsers))
                        {
                            Response.Write("<script> { alert('Seçtiðiniz kullanýcýlar silinmiþtir');}</script>");
                        }
                        else
                        {
                            Response.Write("<script> { alert('Seçtiðiniz kullanýcýlar silinirken bir hata oluþtu');}</script>");
                        }
                    }
                    else if (e.CommandName == "SendToFolder")
                    {
                        if (obj.UpdateUsersFolders(this.FolderID, this.FolderIDToSend, arrUsers, this.smTemporaryUserID))
                        {
                            Response.Write("<script> { alert('Belirlediðiniz kullanýcýlar seçtiðiniz klasöre taþýnmýþtýr');}</script>");
                        }
                        else
                        {
                            Response.Write("<script> { alert('Taþýnma sýrasýnda bir hata oluþtu. Lütfen tekrar deneyin');}</script>");
                        }
                    }
                }
                else
                {
                    Response.Write("<script> { alert(' " + PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.SelectAtLeastOneUser) + "');}</script>");
                }
            }
            FillForm();
        }
    }

    protected void rptFolders_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        PIKCV.BUS.Company obj = new PIKCV.BUS.Company();
        if (e.Item.ItemType == ListItemType.Footer)
        {
            DataTable dt = obj.GetCompanyFolderDetail(this.FolderID);
            if (dt.Rows.Count > 0)
            {
                if (Convert.ToInt32(dt.Rows[0]["FolderTypeID"]) == (int)PIKCV.COM.EnumDB.FolderTypeID.UsersWillBeBought)
                {
                    ((Panel)e.Item.FindControl("pnlSendToFolder")).Visible = false;
                }
                else
                {
                    ((Panel)e.Item.FindControl("pnlSendToFolder")).Visible = true;
                }
            }
            else { this.GoToDefaultPage(); }



            ///////TODO: Folder type geldiðinde deðiþecek
            //if (lbFolderName.Text == "Satýn Alýnacaklar")
            //{
            //    ((Panel)e.Item.FindControl("pnlSendToFolder")).Visible = false;
            //}
            //else
            //{
            //    ((Panel)e.Item.FindControl("pnlSendToFolder")).Visible = true;
            //}

            ///////////////////////////
        }
    }

}
