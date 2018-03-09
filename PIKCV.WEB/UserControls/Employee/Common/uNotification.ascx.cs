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

public partial class UserControls_Employee_Common_uNotification : BaseUserControl
{
    protected void Page_PreRender(object sender, EventArgs e)
    {
        NotificationCtrl();
    }

    private void NotificationCtrl()
    {
        DataRow drError = null;
        PIKCV.BUS.UserCVs objUserCV = new PIKCV.BUS.UserCVs();

        //CV si var mý?
        if (objUserCV.GetUserCV(this.smUserID).Rows.Count < 1)
        {
            pnlCVCtrl.Visible = true;
            drError = PIKCV.COM.Data.GetErrorCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.NoticeNOCV);
            ltlCVCtrlTitle.Text = drError["ErrorTitle"].ToString();
            ltlCVCtrlMessage.Text = drError["Message"].ToString();
        }
        else
        {
            //Test Çözülmüþ mü Kontrol
            if (PIKCV.BUS.Test.UserTestCtrl(this.smUserID))
            {
                
                pnlTestCtrl.Visible = true;
                if (this.smEmployeeType == PIKCV.COM.EnumDB.EmployeeTypes.Pikpool)
                {
                    drError = PIKCV.COM.Data.GetErrorCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.NoticeTestCtrl);
                }
                else
                {
                    drError = PIKCV.COM.Data.GetErrorCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.NoticeTestCtrlForGoodPik);
                }
                ltlTestTitle.Text = drError["ErrorTitle"].ToString();
                ltlTestMessage.Text = drError["Message"].ToString();
            }
            else if (this.smIsCvConfirmed)
            {
                //CV Güncel Kontrol
                DataTable dtUserCV = objUserCV.GetUserCV(this.smUserID);
                DateTime CVModifyDate = Convert.ToDateTime(dtUserCV.Rows[0]["ModifyDate"]);
                if (CVModifyDate < DateTime.Now.AddMonths((int.Parse(this.Config(PIKCV.COM.EnumUtil.Config.CVActualMonth))) * -1))
                {
                    pnlActualCtrl.Visible = true;
                    drError = PIKCV.COM.Data.GetErrorCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.NoticeActualCtrl);
                    ltlActualTitle.Text = drError["ErrorTitle"].ToString();
                    ltlActualMessage.Text = drError["Message"].ToString();
                }

                //CV Aktiflik Kontrol
                PIKCV.BUS.User objUser = new PIKCV.BUS.User();
                if (!Convert.ToBoolean(objUser.GetUserDetail(this.smUserID).Rows[0]["IsCVActive"]))
                {
                    pnlCVActive.Visible = true;
                    drError = PIKCV.COM.Data.GetErrorCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.NoticeCvActiveCtrl);
                    ltlCVActiveTitle.Text = drError["ErrorTitle"].ToString();
                    ltlCVActiveMessage.Text = drError["Message"].ToString();
                }
                else
                {
                    pnlCVActive.Visible = false;
                }
            }
        }
        pnlNotification.Visible = true;
        pnlNotification.Visible = (!((!pnlCVCtrl.Visible) && (!pnlActualCtrl.Visible) && (!pnlTestCtrl.Visible) && (!pnlCVActive.Visible)));
    }

    protected void ImgBtnCvModify_Click(object sender, ImageClickEventArgs e)
    {
        PIKCV.BUS.UserCVs objUserCV = new PIKCV.BUS.UserCVs();
        objUserCV.UpdateCVModifyDate(this.smUserID);
    }
}
