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

public partial class UserControls_Employee_Search_uEasySearch : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillDetails();
        }
    }

    private void FillDetails()
    {
        DataBindHelper.BindListbox(ref lbCountries, this.cmbCountries, "PlaceName", "PlaceID", "");
        DataBindHelper.BindListbox(ref lbCities, this.cmbTurkeyCities, "PlaceName", "PlaceID", "");
        DataBindHelper.BindListbox(ref lbPositions, this.cmbPositions, "PositionName", "PositionID", "");
        DataBindHelper.BindListbox(ref lbSectors, this.cmbSectors, "SectorName", "SectorID", "");
    }
}
