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

public partial class UserControls_Company_Common_uInterviewTabs : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void TabActive(PIKCV.COM.Enumerations.InterviewTabs InterviewTab)
    {
        switch (InterviewTab)
        {
            case PIKCV.COM.Enumerations.InterviewTabs.InterviewList:
                liInterviewList.Attributes.Add("class", "TabActive");
                break;
            case PIKCV.COM.Enumerations.InterviewTabs.MadeInterviews:
                liMadeInterviews.Attributes.Add("class", "TabActive");
                break;
        }
    }
}
