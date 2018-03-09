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
using System.ComponentModel;

public partial class UserControls_Company_Statistics_BarControl : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    //   [DefaultValue((string)null)]
    [Category("Custom")]
    [RefreshProperties(RefreshProperties.All)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public string Description
    {
        get { return this.txtDescription.InnerText; }
        set { this.txtDescription.InnerText = value; }
    }

    private int percentage;
    [Category("Custom")]
    [RefreshProperties(RefreshProperties.All)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public int Percentage
    {
        get
        {
            return percentage;
        }
        set
        {
            percentage = value;

            txtPercentage.InnerText = percentage.ToString() + "%";
            divBar.Style["width"] = (percentage * 2).ToString() + "px";
            // divBar.Style["width"] = "1232";

        }
    }

    private int count;
    [Category("Custom")]
    [RefreshProperties(RefreshProperties.All)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public int Count
    {
        get
        {
            return count;
        }

        set
        {
            count = value;
            txtCount.InnerText = String.Format("({0} kiþi)", count);

        }
    }
}
