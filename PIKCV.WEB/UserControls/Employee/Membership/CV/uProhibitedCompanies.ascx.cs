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

public partial class UserControls_Employee_Membership_CV_uProhibitedCompanies : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ReplaceNavigateURL(ref hlEmploymentChooices, PIKCV.COM.EnumDB.CVFocusCode.EmploymentChooices);
            ReplaceNavigateURL(ref hlReferences, PIKCV.COM.EnumDB.CVFocusCode.References);
            ReplaceNavigateURL(ref hlPlacementPreferences, PIKCV.COM.EnumDB.CVFocusCode.PlacementPreferences);

            imgAddToListCompany.Style.Add("cursor", "pointer");
            imgRemoveToListCompany.Style.Add("cursor", "pointer");

            imgAddToListCompany.Attributes.Add("onclick", "SwapItem('" + lbCompanies.ClientID + "','" + lbSelectedCompanies.ClientID + "', ' ')");
            imgRemoveToListCompany.Attributes.Add("onclick", "SwapItem('" + lbSelectedCompanies.ClientID + "','" + lbCompanies.ClientID + "', ' ')");

            ImgBtnContinue.Attributes.Add("onmousedown", "return SelectAllListBox('" + lbSelectedCompanies.ClientID + "')");
            ImgBtnSave.Attributes.Add("onmousedown", "return SelectAllListBox('" + lbSelectedCompanies.ClientID + "')");

        }
    }

    private void ReplaceNavigateURL(ref HyperLink hl, PIKCV.COM.EnumDB.CVFocusCode CVFocusCode)
    {
        hl.NavigateUrl = hl.NavigateUrl.Replace("||FocusNo||", ((int)CVFocusCode).ToString());
    }

    protected void Page_PreRender(object sender, EventArgs e)
    {

        PIKCV.BUS.UserCVs objUserProhibitedCompanies = new PIKCV.BUS.UserCVs();
        DataTable dtUserProhibitedCompanies = objUserProhibitedCompanies.GetUserProhibitedCompanies(this.smUserID);
        DataBindHelper.BindListbox(ref lbSelectedCompanies, dtUserProhibitedCompanies, "CompanyName", "CompanyID");


        DataTable dtAllCompanies = this.cmbCompanies;
        DataTable dtCompaniesNew = new DataTable();

        if (dtAllCompanies.Rows.Count > 0) { 
            dtCompaniesNew.Columns.Add("CompanyID");
            dtCompaniesNew.Columns.Add("CompanyName");

            bool add = true;
            foreach (DataRow drCache in dtAllCompanies.Rows)
            {
                add = true;
                foreach (DataRow dr in dtUserProhibitedCompanies.Rows)
                {
                    if (dr["CompanyID"].ToString() == drCache["CompanyID"].ToString())
                    {
                        add = false;
                        break;
                    }
                }
                if (add)
                {
                    DataRow drNew = dtCompaniesNew.NewRow();
                    drNew["CompanyID"] = drCache["CompanyID"].ToString();
                    drNew["CompanyName"] = drCache["CompanyName"].ToString();
                    dtCompaniesNew.Rows.Add(drNew);
                }
            }
        }
        else { dtCompaniesNew = dtAllCompanies.Copy(); }

        DataBindHelper.BindListbox(ref lbCompanies, dtCompaniesNew, "CompanyName", "CompanyID", "");

        PIKCV.BUS.UserCVs objUserCV = new PIKCV.BUS.UserCVs();
        DataTable dtUserCV = objUserCV.GetUserCV(this.smUserID);
        ImgBtnSave.Visible = (Convert.ToInt32(dtUserCV.Rows[0]["CvFocusCode"]) > (int)PIKCV.COM.EnumDB.CVFocusCode.References);
        ImgBtnContinue.Visible = !(ImgBtnSave.Visible);
    }

    protected void ImgBtnContinue_Click(object sender, ImageClickEventArgs e)
    {
        PIKCV.BUS.UserCVs objUserCV = new PIKCV.BUS.UserCVs();

        ArrayList arrSelectedCompanies = new ArrayList();


        if (Request.Form[lbSelectedCompanies.UniqueID] != null)
        {
            arrSelectedCompanies.AddRange(Request.Form[lbSelectedCompanies.UniqueID].Split(','));
        }

        if (objUserCV.SaveUserProhibitedCompanies(this.smUserID, arrSelectedCompanies))
        {
            if (ImgBtnContinue.Visible == true)
            {
                this.smCVFocus = objUserCV.CVFocus(this.smUserID);
                this.Redirect("Employee-Membership-CV&CVFocus=" + ((int)PIKCV.COM.EnumDB.CVFocusCode.References).ToString());
            }
            else {
                ShowModal.Show(UserControls_Common_uModalPopup.Icons.alert, PIKCV.COM.EnumDB.ErrorTypes.UpdateCV);
            }
        }
        else
        {
            ShowModal.Show(UserControls_Common_uModalPopup.Icons.alert, PIKCV.COM.EnumDB.ErrorTypes.NoUpdateCV);
        }
    }
}
