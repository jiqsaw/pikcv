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

public partial class UserControls_Employee_Membership_CV_uComputerKnowledge : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {   
            imgAddToList.Attributes.Add("onclick", "SwapItem('" + lbComputerKnowledgeTypes.ClientID + "','" + lbSelectedComputerKnowledgeTypes.ClientID + "', '" + txtOtherType.ClientID + "')");
            imgRemoveToList.Attributes.Add("onclick", "SwapItem('" + lbSelectedComputerKnowledgeTypes.ClientID + "','" + lbComputerKnowledgeTypes.ClientID + "', '" + txtOtherType.ClientID + "')");
            ImgBtnContinue.Attributes.Add("onmousedown", "return SelectAllListBox('" + lbSelectedComputerKnowledgeTypes.ClientID + "');");
            ImgBtnSave.Attributes.Add("onmousedown", "return SelectAllListBox('" + lbSelectedComputerKnowledgeTypes.ClientID + "');");

            UCharacteristicAndSocialLifeNav1.SelectNavigatorLink(PIKCV.COM.EnumDB.CVFocusCode.ComputerKnowledge);
            imgAddToList.Style.Add("cursor", "pointer");
            imgRemoveToList.Style.Add("cursor", "pointer");

            lbComputerKnowledgeTypes.Attributes.Add("onchange", "OpenCloseOther(" + ((int)PIKCV.COM.EnumDB.OtherComputerKnowledgeID.Other).ToString() + ")");
        }
    }

    protected void Page_PreRender(object sender, EventArgs e)
    {
        PIKCV.BUS.UserCVs objUserComputerKnowledges = new PIKCV.BUS.UserCVs();
        DataTable dtUserComputerKnowledges = objUserComputerKnowledges.GetUserComputerKnowledges(this.smUserID, (int)this.smLanguageID); 
        DataBindHelper.BindListbox(ref lbSelectedComputerKnowledgeTypes, dtUserComputerKnowledges, "ComputerKnowledgeTypeName", "ComputerKnowledgeTypeID");

        DataTable dtComputerKnowledgeTypes = this.cmbComputerKnowledgeTypes;
        DataTable dtComputerKnowledgeTypeNew = new DataTable();

        if (dtUserComputerKnowledges.Rows.Count > 0)
        {
            dtComputerKnowledgeTypeNew.Columns.Add("ComputerKnowledgeTypeID");
            dtComputerKnowledgeTypeNew.Columns.Add("ComputerKnowledgeTypeName");

            bool add = true;
            foreach (DataRow drCache in dtComputerKnowledgeTypes.Rows)
            {
                add = true;
                foreach (DataRow dr in dtUserComputerKnowledges.Rows)
                {
                    if (dr["ComputerKnowledgeTypeID"].ToString() == drCache["ComputerKnowledgeTypeID"].ToString())
                    {
                        add = false;
                        break;
                    }
                }
                if (add) {
                    DataRow drNew = dtComputerKnowledgeTypeNew.NewRow();
                    drNew["ComputerKnowledgeTypeID"] = drCache["ComputerKnowledgeTypeID"].ToString();
                    drNew["ComputerKnowledgeTypeName"] = drCache["ComputerKnowledgeTypeName"].ToString();
                    dtComputerKnowledgeTypeNew.Rows.Add(drNew);
                }
            }
        }
        else { dtComputerKnowledgeTypeNew = dtComputerKnowledgeTypes.Copy(); }

        DataBindHelper.BindListbox(ref lbComputerKnowledgeTypes, dtComputerKnowledgeTypeNew, "ComputerKnowledgeTypeName", "ComputerKnowledgeTypeID", "");
        PIKCV.BUS.UserCVs objUserCV = new PIKCV.BUS.UserCVs();
        DataTable dtUserCV = objUserCV.GetUserCV(this.smUserID);
        ImgBtnSave.Visible = (Convert.ToInt32(dtUserCV.Rows[0]["CvFocusCode"]) > (int)PIKCV.COM.EnumDB.CVFocusCode.References);
        ImgBtnContinue.Visible = !(ImgBtnSave.Visible);

        dvScript.InnerHtml = "<script>OtherDown('" + lbComputerKnowledgeTypes.ClientID + "', " + ((int)PIKCV.COM.EnumDB.OtherComputerKnowledgeID.Other).ToString() + ")</script>";
    }

    protected void ImgBtnContinue_Click(object sender, ImageClickEventArgs e)
    {
        PIKCV.BUS.UserCVs objUserCV = new PIKCV.BUS.UserCVs();

        ArrayList arrSelectedValues = new ArrayList();
        if (Request.Form[lbSelectedComputerKnowledgeTypes.UniqueID] != null) {
            arrSelectedValues.AddRange(Request.Form[lbSelectedComputerKnowledgeTypes.UniqueID].Split(','));
        }

        if (arrSelectedValues.Count > 0) {
            if (objUserCV.SaveUserComputerKnowledge(this.smUserID, arrSelectedValues)) {
                if (ImgBtnContinue.Visible == true)
                {
                    this.smCVFocus = objUserCV.CVFocus(this.smUserID);
                    this.Redirect("Employee-Membership-CV&CVFocus=" + ((int)PIKCV.COM.EnumDB.CVFocusCode.CourseAndCertificate).ToString());
                }
                ShowModal.Show(UserControls_Common_uModalPopup.Icons.alert, PIKCV.COM.EnumDB.ErrorTypes.UpdateCV);
            }
            else {
                ShowModal.Show(UserControls_Common_uModalPopup.Icons.alert, PIKCV.COM.EnumDB.ErrorTypes.NoUpdateCV);
            }
        }
        else {
            this.smCVFocus = objUserCV.CVFocus(this.smUserID);
            this.Redirect("Employee-Membership-CV&CVFocus=" + ((int)PIKCV.COM.EnumDB.CVFocusCode.CourseAndCertificate).ToString());
        }
    }
}
