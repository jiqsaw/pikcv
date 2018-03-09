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

public partial class UserControls_Employee_Membership_CV_uReferenceAdd : BaseUserControl
{

    public int UserReferenceID
    {
        get { return (ViewState["UserReferenceID"] == null ? 0 : int.Parse(ViewState["UserReferenceID"].ToString())); }
        set { ViewState["UserReferenceID"] = value; }
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Page_PreRender(object sender, EventArgs e)
    {
        if (CARETTA.COM.Util.IsNumeric(Request.QueryString["UserReferenceID"]))
        {
            this.UserReferenceID = int.Parse(Request.QueryString["UserReferenceID"]);
            PIKCV.BUS.UserCVs objUserReferenceDetail = new PIKCV.BUS.UserCVs();
            DataTable dtUserReferenceDetail = objUserReferenceDetail.GetReferenceDetail(this.UserReferenceID);
            if (dtUserReferenceDetail.Rows.Count > 0)
            {
                FillData(dtUserReferenceDetail);
            }
        }
    }

    private void FillData(DataTable dt)
    {
        txtReferenceName.Text = dt.Rows[0]["ReferenceName"].ToString();
        txtCompany.Text = dt.Rows[0]["Company"].ToString();
        txtPhone.Text = dt.Rows[0]["Phone"].ToString();
        txtPosition.Text = dt.Rows[0]["Position"].ToString();
    }

    protected void ImgBtnSave_Click(object sender, ImageClickEventArgs e)
    {
        PIKCV.BUS.UserCVs objUserCV = new PIKCV.BUS.UserCVs();

        if (objUserCV.SaveUserReference(this.UserReferenceID, this.smUserID, txtReferenceName.Text, txtCompany.Text, txtPhone.Text, txtPosition.Text))
        {
            this.smCVFocus = PIKCV.COM.EnumDB.CVFocusCode.References;
            ShowModal.Show(UserControls_Common_uModalPopup.Icons.alert, PIKCV.COM.EnumDB.ErrorTypes.UpdateCV, true, true);
        }
        else
        {
            ShowModal.Show(UserControls_Common_uModalPopup.Icons.alert, PIKCV.COM.EnumDB.ErrorTypes.NoUpdateCV);
        }
    }
}
