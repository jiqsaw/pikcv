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
using PIKCV.BUS;

public partial class UserControls_Company_Jobs_Jobs_uApproval : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillForm();
        }
    }

    private void FillForm()
    {
        rblJobBroadcastType.Items[0].Value = ((int)PIKCV.COM.EnumDB.JobStatus.Active).ToString();
        rblJobBroadcastType.Items[1].Value = ((int)PIKCV.COM.EnumDB.JobStatus.Draft).ToString();
    }
    protected void btnSubmit_Click(object sender, ImageClickEventArgs e)
    {
        PIKCV.BUS.Job obj = new PIKCV.BUS.Job();
        int NewCredit = -1;

        if (obj.SaveApproval(this.smCompanyID,this.smJobID, int.Parse(rblJobBroadcastType.SelectedValue), chkisCompanySecret.Checked, ref NewCredit) > 0)
        {
            if (NewCredit != -1) { this.smPikCredi = NewCredit.ToString(); }
            if (rblJobBroadcastType.SelectedValue == ((int)PIKCV.COM.EnumDB.JobStatus.Draft).ToString())
            {
                this.GoToFeedback(PIKCV.COM.EnumDB.ErrorTypes.SaveDraft);
            }
            else
            {
                this.GoToFeedback(PIKCV.COM.EnumDB.ErrorTypes.SaveJob);
            }
            //Response.Write("<script language='javascript'> { alert ('Ýlanýnýz Baþarýyla Kaydedilmiþtir');}</script>");
        }
        else { Response.Write("<script language='javascript'> { alert ('Ýlaný kaydederken bir hata oluþtu');}</script>"); }
    }

}