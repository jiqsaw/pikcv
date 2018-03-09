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
using System.Text;
using CARETTA.COM;

public partial class UserControls_Common_uList : BaseUserControl
{
    #region  :: Generic List Codes :: 

    private int m_RowStart = 0;
    private int m_PageSize = 10;
    private int m_FilterCount = 0;

    public Hashtable HtQuery 
    {
        get { return (ViewState["htQuery"] == null ? new Hashtable() : (Hashtable)ViewState["htQuery"]); }
        set { ViewState["htQuery"] = value; }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        this.m_PageSize = int.Parse(this.Config(PIKCV.COM.EnumUtil.Config.ListPageSize));
    }

    private bool Exist(DataTable dtSource, string Value) {

        foreach (DataRow dr in dtSource.Rows)
        {
            if (dr["Text"].ToString() == Value) {
                return true;
            }
        }
        return false;
    }

    private DataTable Distinct(DataTable dt, string IDColumn, string DataColumn) { 
        DataTable dtFilter = new DataTable();
        dtFilter.Columns.Add("Value");
        dtFilter.Columns.Add("Text");

        foreach (DataRow dr in dt.Rows)
        {
            if (!Exist(dtFilter, dr[DataColumn].ToString())) {
                DataRow drFilterNew = dtFilter.NewRow();
                drFilterNew["Value"] = dr[IDColumn].ToString();
                drFilterNew["Text"] = dr[DataColumn].ToString();
                dtFilter.Rows.Add(drFilterNew);
            }
        }
        return dtFilter;
    }

    private void AddDataInfo(ref DataTable dtInfo, string Title, string ColumnName, bool IsFilter, int FilterIndex) {
        AddDataInfo(ref dtInfo, Title, ColumnName, IsFilter, FilterIndex, false, String.Empty, String.Empty);
    }

    private void AddDataInfo(ref DataTable dtInfo, string Title, string ColumnName, bool IsFilter, int FilterIndex, bool IsLink, string Link, string LinkQueryColumn) {
        if (dtInfo.Rows.Count < 1) {
            dtInfo.Columns.Add("Title");
            dtInfo.Columns.Add("ColumnName");
            dtInfo.Columns.Add("IsFilter");
            dtInfo.Columns.Add("FilterIndex");
            dtInfo.Columns.Add("IsLink");
            dtInfo.Columns.Add("Link");
            dtInfo.Columns.Add("LinkQueryColumn");
        }
        DataRow dr = dtInfo.NewRow();
        dr["Title"] = Title;
        dr["ColumnName"] = ColumnName;
        dr["IsFilter"] = IsFilter;
        dr["FilterIndex"] = FilterIndex;
        dr["IsLink"] = IsLink;
        dr["Link"] = Link;
        dr["LinkQueryColumn"] = LinkQueryColumn;
        dtInfo.Rows.Add(dr);
    }

    private void InitializeHtQuery(DataTable dtSource) {
        Hashtable m_HtQuery = new Hashtable();

        foreach (DataRow dr in dtSource.Rows)
        {
            m_HtQuery.Add(dr["ColumnName"].ToString(), "%");
            if (Util.IsString(Request.QueryString["[" + dr["ColumnName"].ToString() + "]"]))
            {
                m_HtQuery[dr["ColumnName"].ToString()] = Request.QueryString["[" + dr["ColumnName"].ToString() + "]"];
            }
        }

        this.HtQuery = m_HtQuery;
    }

    private void AddListFilterTypes(DataTable dt, string Value, string Text) {
        if (this.smListFilterTypes.Count < this.m_FilterCount) {
            ArrayList ListFilterTypes = this.smListFilterTypes;
            ListFilterTypes.Add(Distinct(dt, Value, Text));
            this.smListFilterTypes = ListFilterTypes;
        }
    }

    private string UrlReplace(string Name) {
        string Path = Request.Url.OriginalString;
        int NameIndex = Path.IndexOf(Name);
        if (NameIndex != -1) {
            int EndIndex = Path.IndexOf("&", NameIndex);
            if (EndIndex != -1) {
                Path = Path.Substring(0, NameIndex - 1) + Path.Substring(EndIndex, Path.Length - EndIndex);
            } else {
                Path = Path.Substring(0, NameIndex - 1);
            }
        }
        Path = "window.location='" + Path + "&" + Name + "=";
        return Path;
    }

    private string GenerateDDL(string ID, DataTable dt) {
        StringBuilder sb = new StringBuilder();
        sb.Append("<select style='width:90%' id='ddl" + ID + "' name='ddl" + ID + "' onchange=\"" + UrlReplace("[" + ID + "]") + "' + this.options[this.selectedIndex].value\">");

        sb.Append("<option value='%'>Tümü</option>");
        foreach (DataRow dr in dt.Rows) {
            sb.Append("<option value='" + dr["Value"].ToString() + "'>" + dr["Text"].ToString() + "</option>");
        }

        sb.Append("</select>");

        dvScript.InnerHtml += "<script>ddlSelected('ddl" + ID + "','" + this.HtQuery[ID] + "');</script>";
        return sb.ToString();
    }

    private void FilterCount(DataTable dtInfo)
    {
        foreach (DataRow dr in dtInfo.Rows)
        {
            if (Convert.ToBoolean(dr["IsFilter"]))
            {
                this.m_FilterCount++;
            }
        }
    }

    public void DataBind(DataTable dtInfo, DataTable dtData, string LinkList)
    {
        if (dtData.Rows.Count > 0)
        {

            int ColumnCount = dtInfo.Rows.Count;
            int RowCount = dtData.Rows.Count;

            if (CARETTA.COM.Util.IsNumeric(Request.QueryString["rstrt__"]))
            {
                this.m_RowStart = int.Parse(Request.QueryString["rstrt__"]);
            }

            string Sort = " ";

            if (Util.IsString(Request.QueryString["SortColumn"]))
            {
                try
                {
                    Sort = Request.QueryString["SortColumn"].ToString().Trim();
                    dtData.DefaultView.Sort = Sort;
                    dtData = dtData.DefaultView.ToTable();
                }
                catch (Exception) { }
            }

            StringBuilder sb = new StringBuilder();
            sb.Append("<table width='100%' class='dataGrid'>");

            sb.Append("<tr>");
            for (int i = 0; i < ColumnCount; i++)
            {
                sb.Append("<th class='Order' style='cursor: pointer; border-bottom: 0px none; padding-bottom: 0px;' onclick=\"window.location='Pikcv.aspx?Pik=" + LinkList + "&SortColumn=" + dtInfo.Rows[i]["ColumnName"].ToString().Replace(Sort, Sort + " DESC") + "'\"><strong>");
                sb.Append(dtInfo.Rows[i]["Title"].ToString());
                sb.Append("</strong></th>");
            }
            sb.Append("</tr>");

            sb.Append("<tr>");
            for (int i = 0; i < ColumnCount; i++)
            {
                sb.Append("<th style='padding-top: 0; border-top: 0px none;'>");
                if (Convert.ToBoolean(dtInfo.Rows[i]["IsFilter"]))
                {
                    sb.Append(GenerateDDL(dtInfo.Rows[i]["ColumnName"].ToString(), (DataTable)(this.smListFilterTypes[Convert.ToInt32(dtInfo.Rows[i]["FilterIndex"])])));
                }
                sb.Append("</th>");
            }
            sb.Append("</tr>");

            for (int i = this.m_RowStart; i < this.m_RowStart + this.m_PageSize; i++)
            {
                if (i >= RowCount) { break; }
                sb.Append("<tr class='odd'>");

                for (int j = 0; j < ColumnCount; j++)
                {
                    sb.Append("<td>");
                    if (Convert.ToBoolean(dtInfo.Rows[j]["IsLink"]))
                    {
                        sb.Append("<a href=#" + dtInfo.Rows[j]["Link"].ToString() + "&" + dtInfo.Rows[j]["LinkQueryColumn"].ToString() + "=" + dtData.Rows[i][dtInfo.Rows[j]["LinkQueryColumn"].ToString()].ToString() + "><strong>");
                    }

                    sb.Append(dtData.Rows[i][dtInfo.Rows[j]["ColumnName"].ToString()].ToString());

                    if (Convert.ToBoolean(dtInfo.Rows[j]["IsLink"])) { sb.Append("</strong></a>"); }

                    sb.Append("</td>");
                }
                sb.Append("</tr>");
            }

            sb.Append("</table>");

            dvList.InnerHtml = sb.ToString();

            int ForRowCount = RowCount / m_PageSize;
            if (ForRowCount * m_PageSize != RowCount)
            {
                ForRowCount++;
            }

            lblRecordCount.Text = RowCount.ToString();

            DataBindHelper.LoadNumberDDL(ref ddlPageNumber, ForRowCount);

            foreach (ListItem li in ddlPageNumber.Items)
            {
                li.Value = ((int.Parse(li.Value) * m_PageSize) - m_PageSize).ToString();
            }

            ddlPageNumber.SelectedValue = this.m_RowStart.ToString();
            ddlPageNumber.Attributes.Add("onchange", UrlReplace("rstrt__") + "' + this.options[this.selectedIndex].value");
        }
        else {
            pnlList.Visible = false;
            pnlNoRecord.Visible = true;
        }
    }

    #endregion

    public void DataBind(PIKCV.COM.Enumerations.ListTypes ListType)
    {
        DataTable dt = new DataTable();
        DataTable dtInfo;
        switch (ListType)
        {
            case PIKCV.COM.Enumerations.ListTypes.Message:
                string JobID = "%";
                if (CARETTA.COM.Util.IsNumeric(Request.QueryString["JobID"])) {
                    JobID = Request.QueryString["JobID"].ToString();
                }

                dtInfo = new DataTable();
                AddDataInfo(ref dtInfo, "", "ReadResult", false, -1);
                AddDataInfo(ref dtInfo, "Konu", "MessageTitle", false, -1, true, "Employee-Messages-MessageDetail", "MessageID");
                AddDataInfo(ref dtInfo, "Gönderen", "CompanyName", true, 0);
                AddDataInfo(ref dtInfo, "Tarih", "CreateDate", false, -1);
                AddDataInfo(ref dtInfo, "", "Delete", false, -1);
                

                InitializeHtQuery(dtInfo);
                dt = PIKCV.BUS.Messages.GetAllMessages(this.smUserID, false, PIKCV.COM.EnumDB.MemberTypes.Employee, this.HtQuery["CompanyName"].ToString(), JobID);


                dt.Columns.Add("ReadResult");
                dt.Columns.Add("Delete");

                foreach (DataRow dr in dt.Rows)
                {
                    dr["Delete"] = "<a href=\"" + this.OpenConfirm(PIKCV.COM.EnumDB.ErrorTypes.cDeleteMessage, Convert.ToInt32(dr["MessageID"])) + "\">Sil<a>";
                    if (Convert.ToBoolean(dr["IsRead"]))
                    {
                        dr["ReadResult"] = "<img src='images/misc/read.jpg' />";
                    }
                    else
                    {
                        dr["ReadResult"] = "<img src='images/misc/unread.jpg' />";
                    }
                }

                FilterCount(dtInfo);

                AddListFilterTypes(dt, "CompanyID", "CompanyName");
                
                DataBind(dtInfo, dt, "Employee-Messages-Messages");

                lblNoRecord.Text = PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.NoMessage);

                break;

            case PIKCV.COM.Enumerations.ListTypes.UserJobApplicants:
                dtInfo = new DataTable();
                AddDataInfo(ref dtInfo, "Baþvuru Tarihi", "ApplicationDate", false, -1);
                AddDataInfo(ref dtInfo, "Firma", "CompanyName", true, 0);
                AddDataInfo(ref dtInfo, "Pozisyon", "PositionName", true, 1, true, "Employee-Jobs-JobDetail", "JobID");
                AddDataInfo(ref dtInfo, "Durum", "JobApplicationStatusName", true, 2);
                AddDataInfo(ref dtInfo, "Mesaj", "MessageCount", false, -1, true, "Employee-Messages-Messages", "JobID");
                AddDataInfo(ref dtInfo, "Baþvuru Ýptal", "CancelApplicant", false, -1);

                InitializeHtQuery(dtInfo);
                dt = PIKCV.BUS.JobApplicants.GetUserJobApplicants(this.smUserID, this.smLanguageID, this.HtQuery["CompanyName"].ToString(), this.HtQuery["PositionName"].ToString(), this.HtQuery["JobApplicationStatusName"].ToString());

                dt.Columns.Add("CancelApplicant");

                foreach (DataRow dr in dt.Rows)
                {
                    if ((PIKCV.COM.EnumDB.JobApplicationStates)dr["ApplicationStatusID"] == PIKCV.COM.EnumDB.JobApplicationStates.RecievedBack)
                    {
                        dr["CancelApplicant"] = "";
                    }
                    else
                    {
                        dr["CancelApplicant"] = "<a href=\"" + this.OpenConfirm(PIKCV.COM.EnumDB.ErrorTypes.cCancelApplicant, Convert.ToInt32(dr["JobApplicantID"]), "") + "\">Baþvuru Ýptal<a>";
                    }
                }

                FilterCount(dtInfo);

                AddListFilterTypes(dt, "CompanyID", "CompanyName");
                AddListFilterTypes(dt, "PositionID", "PositionName");
                AddListFilterTypes(dt, "ApplicationStatusID", "JobApplicationStatusName");
                
                DataBind(dtInfo, dt, "Employee-JobApplicants-JobApplicants");

                lblNoRecord.Text = PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.NoApplicant);
                
                break;

            case PIKCV.COM.Enumerations.ListTypes.CompanyMessages:

                dtInfo = new DataTable();
                AddDataInfo(ref dtInfo, "Konu", "MessageTitle", false, -1, true, "Company-Messages-MessageDetail", "MessageID");
                AddDataInfo(ref dtInfo, "Tarih", "CreateDate", false, -1);

                InitializeHtQuery(dtInfo);
                dt = PIKCV.BUS.Messages.GetCompanyMessages(this.smCompanyID, false, PIKCV.COM.EnumDB.MemberTypes.Company);

                FilterCount(dtInfo);

                DataBind(dtInfo, dt, "Company-Messages-Messages");

                lblNoRecord.Text = PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.NoMessage);

                break;

            case PIKCV.COM.Enumerations.ListTypes.CompanySentMessages:

                dtInfo = new DataTable();
                AddDataInfo(ref dtInfo, "", "ReadResult", false, -1);
                AddDataInfo(ref dtInfo, "Konu", "MessageTitle", false, -1, true, "Company-Messages-SendMessageDetail", "MessageID");
                AddDataInfo(ref dtInfo, "Gönderilen", "FullName", true, 0, true, "Company-Messages-SentMessages", "UserID");
                AddDataInfo(ref dtInfo, "Tarih", "CreateDate", false, -1);

                InitializeHtQuery(dtInfo);
                dt = PIKCV.BUS.Messages.GetCompanySentMessages(this.smCompanyID, false, this.HtQuery["FullName"].ToString());

                dt.Columns.Add("ReadResult");

                foreach (DataRow dr in dt.Rows)
                {
                    if (Convert.ToBoolean(dr["IsRead"])) { dr["ReadResult"] = ""; }
                    else { dr["ReadResult"] = "<img src='images/misc/unread.jpg' />"; }
                }

                FilterCount(dtInfo);

                AddListFilterTypes(dt, "UserID", "FullName");

                DataBind(dtInfo, dt, "Company-Messages-SentMessages");

                lblNoRecord.Text = PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.NoMessage);

                break;

            case PIKCV.COM.Enumerations.ListTypes.EnteredJobs:

                int m_Status = 1;
                PIKCV.COM.EnumDB.JobStatus JobStatus = PIKCV.COM.EnumDB.JobStatus.Active;
                if (CARETTA.COM.Util.IsNumeric(Request.QueryString["JobStatus"]))
                {
                    m_Status = Convert.ToInt32(Request.QueryString["JobStatus"]);
                    JobStatus = (PIKCV.COM.EnumDB.JobStatus)m_Status;
                }
                
                dtInfo = new DataTable();
                AddDataInfo(ref dtInfo, "Referans Numarasý", "ReferenceNumber", false, -1);
                AddDataInfo(ref dtInfo, "Pozisyon", "PositionName", true, 0);
                AddDataInfo(ref dtInfo, "Baþvuru", "ApplicantCount", false, -1, true, "Company-Jobs-JobApplicants", "JobID");
                AddDataInfo(ref dtInfo, "Bitiþ Tarihi", "EndDate", false, -1);
                AddDataInfo(ref dtInfo, "Ýstatistik", "Statistics", false, -1);

                switch (JobStatus)
                {
                    case PIKCV.COM.EnumDB.JobStatus.Active:
                        AddDataInfo(ref dtInfo, "Durum", "Update", false, -1, true, "Company-Jobs-Jobs&JobFocus=2&JobSaveType=" + ((int)PIKCV.COM.Enumerations.JobSaveType.Update).ToString(), "JobID");
                        AddDataInfo(ref dtInfo, "", "Archive", false, -1, true, "Company-Jobs-PublicJobs&JobStatus=4", "JobID");
                        break;
                    case PIKCV.COM.EnumDB.JobStatus.Draft:
                        AddDataInfo(ref dtInfo, "Durum", "Update", false, -1, true, "Company-Jobs-Jobs&JobFocus=2&JobSaveType=" + ((int)PIKCV.COM.Enumerations.JobSaveType.ArchiveOrDraft).ToString(), "JobID");
                        AddDataInfo(ref dtInfo, "", "Archive", false, -1, true, "Company-Jobs-PublicJobs&JobStatus=1", "JobID");
                        break;
                    case PIKCV.COM.EnumDB.JobStatus.Archive:
                        AddDataInfo(ref dtInfo, "Durum", "Update", false, -1, true, "Company-Jobs-Jobs&JobFocus=2&JobSaveType=" + ((int)PIKCV.COM.Enumerations.JobSaveType.ArchiveOrDraft).ToString(), "JobID");
                        AddDataInfo(ref dtInfo, "", "Archive", false, -1, true, "Company-Jobs-PublicJobs&JobStatus=1", "JobID");
                        break;
                }
                
                AddDataInfo(ref dtInfo, "", "Delete", false, -1);
                
                
                //AddDataInfo(ref dtInfo, "", "Delete", false, -1, true, "Company-Jobs-PublicJobs&JobStatus=" + ((int)PIKCV.COM.EnumDB.JobStatus.Draft).ToString(), "JobID");

                InitializeHtQuery(dtInfo);
                dt = PIKCV.BUS.Job.GetCompanyJobsAll(this.smCompanyID, JobStatus, this.smLanguageID, this.HtQuery["PositionName"].ToString());

                dt.Columns.Add("Update");
                dt.Columns.Add("Archive");
                dt.Columns.Add("Delete");
                dt.Columns.Add("Statistics");

                foreach (DataRow dr in dt.Rows)
                {
                    switch (JobStatus)
                    {
                        case PIKCV.COM.EnumDB.JobStatus.Active:
                            dr["Update"] = "Güncelle";
                            dr["Archive"] = "Arþivle";
                            dr["Delete"] = "";
                            break;
                        case PIKCV.COM.EnumDB.JobStatus.Draft:
                            dr["Update"] = "Güncelle";
                            dr["Archive"] = "Yayýnla";

                            //"<span onclick='DraftDeleteCtrl(3, 3)'>Delete</span>";


                            string Delete = "<u><b><span onclick='DraftDeleteCtrl(" +
                                        ((int)PIKCV.COM.EnumDB.JobStatus.Draft).ToString() +
                                        ", " + dr["JobID"].ToString() +
                                        ")'>Sil</span><b></u>";
                            dr["Delete"] = Delete;
                            break;
                        case PIKCV.COM.EnumDB.JobStatus.Archive:
                            dr["Update"] = "";
                            dr["Delete"] = "";
                            dr["Archive"] = "Yayýnla";
                            break;
                    }
                    
                    string StatisticImage = "<img onclick='OpenJobStatistics(";
                    StatisticImage = StatisticImage + dr["JobID"].ToString() + ")'";
                    StatisticImage = StatisticImage + "style='cursor: pointer;' src='images/misc/statistic.png' width='16' height='14' />";
                    
                    dr["Statistics"] = StatisticImage;

                    string PositionName = "<strong><a href='javascript:;' onclick='OpenJobPreview(" + dr["JobID"].ToString() + ")'>" + dr["PositionName"].ToString() + "</a></strong>";
                    dr["PositionName"] = PositionName;
                }

                FilterCount(dtInfo);

                AddListFilterTypes(dt, "PositionID", "PositionName");

                DataBind(dtInfo, dt, "Company-Jobs-PublicJobs");

                string NoRecordMsg = String.Empty;
                switch (JobStatus)
                {
                    case PIKCV.COM.EnumDB.JobStatus.Active:
                        lblNoRecord.Text = PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.NoJob);
                        break;
                    case PIKCV.COM.EnumDB.JobStatus.Draft:
                        lblNoRecord.Text = PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.NoDraftJob);
                        break;
                    case PIKCV.COM.EnumDB.JobStatus.Archive:
                        lblNoRecord.Text = PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.NoArchiveJob);
                        break;
                }

                break;

            case PIKCV.COM.Enumerations.ListTypes.JobSearchResults:
                JobSearchQuery JobSearchQueries = this.smJobSearchQueries;

                dtInfo = new DataTable();
                AddDataInfo(ref dtInfo, "Pozisyon", "PositionName_JobTitle", true, 0, true, "Employee-Jobs-JobDetail", "JobID");
                AddDataInfo(ref dtInfo, "Ref NO", "ReferenceNumber", false, -1);
                AddDataInfo(ref dtInfo, "Firma", "CompanyName", true, 1);
                AddDataInfo(ref dtInfo, "Son Baþvuru", "EndDate", false, -1);
                AddDataInfo(ref dtInfo, "Tarih", "ModifyDate", false, -1);
                AddDataInfo(ref dtInfo, "Baþvuru", "IsApply", true, 2);

                string Keyword = JobSearchQueries.Keyword;
                string Positions = XMLHelper.BuildXmlString("Positions", "PositionID", JobSearchQueries.Positions);
                string Sectors = (JobSearchQueries.Sectors.Count > 0) ? XMLHelper.BuildXmlString("Sectors", "SectorID", JobSearchQueries.Sectors) : String.Empty;
                string Cities = (JobSearchQueries.Cities.Count > 0) ? XMLHelper.BuildXmlString("Cities", "PlaceID", JobSearchQueries.Cities) : String.Empty;
                string Companies = (JobSearchQueries.Companies.Count > 0) ? XMLHelper.BuildXmlString("Copmanies", "CompanyID", JobSearchQueries.Companies) : String.Empty;
                string EducationLevels = (JobSearchQueries.EducationLevels.Count > 0) ? XMLHelper.BuildXmlString("EducationLevels", "EducationLevelID", JobSearchQueries.EducationLevels) : String.Empty;
                PIKCV.COM.EnumDB.AgeRange AgeRange = JobSearchQueries.AgeRange;
                string LabouringTypes = (JobSearchQueries.LabouringTypes.Count > 0) ? XMLHelper.BuildXmlString("LabouringTypes", "LabouringTypeID", JobSearchQueries.LabouringTypes) : String.Empty;
                DateTime JobDate = (JobSearchQueries.JobDate != -1) ?  DateTime.Now.AddDays(JobSearchQueries.JobDate) : DateTime.MinValue; 
                bool CustomJobs = JobSearchQueries.CustomJobs;

                InitializeHtQuery(dtInfo);

                int PositionID = (this.HtQuery["PositionName_JobTitle"].ToString() == "%") ? -1 : Convert.ToInt32(this.HtQuery["PositionName_JobTitle"]);
                int CompanyID = (this.HtQuery["CompanyName"].ToString() == "%") ? -1 : Convert.ToInt32(this.HtQuery["CompanyName"]);
                int Status = (this.HtQuery["IsApply"].ToString() == "%") ? -1 : Convert.ToInt32(this.HtQuery["IsApply"]);

                PIKCV.BUS.Job objJob = new PIKCV.BUS.Job();
                dt = objJob.GetJobs(this.smUserID, Keyword, Sectors, Cities, Positions, PIKCV.COM.EnumDB.JobStatus.Active, Companies, EducationLevels,
                                    LabouringTypes, AgeRange, JobDate, CustomJobs, PositionID, CompanyID, Status);

                FilterCount(dtInfo);

                AddListFilterTypes(dt, "PositionID", "PositionName_JobTitle");
                AddListFilterTypes(dt, "CompanyID", "CompanyName");
                AddListFilterTypes(dt, "Status", "IsApply");

                DataBind(dtInfo, dt, "Employee-Jobs-Jobs");

                lblNoRecord.Text = PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.NoJobSearch);

                break;
            case PIKCV.COM.Enumerations.ListTypes.CompanyJobApplicants:
                int ApplicantJobID = 0;
                if (CARETTA.COM.Util.IsNumeric(Request.QueryString["JobID"]))
                {
                    ApplicantJobID = Convert.ToInt32(Request.QueryString["JobID"]);
                }

                dtInfo = new DataTable();
                //AddDataInfo(ref dtInfo, "Kiþi", "FullName", false, -1, true, "Company-Jobs-JobApplicants", "UserID");
                AddDataInfo(ref dtInfo, "Kiþi", "FullName", false, -1);
                AddDataInfo(ref dtInfo, "Baþvuru Tarihi", "ApplicationDate", false, -1);
                AddDataInfo(ref dtInfo, "Puan", "Rate", false, -1);
                AddDataInfo(ref dtInfo, "Durum", "JobApplicationStatusName", true, 0);
                AddDataInfo(ref dtInfo, "", "Unsuitability", false, -1);


                InitializeHtQuery(dtInfo);
                dt = PIKCV.BUS.JobApplicants.GetCompanyJobApplicants(ApplicantJobID, this.smLanguageID, this.HtQuery["JobApplicationStatusName"].ToString());
                dt.Columns.Add("Unsuitability");

                foreach (DataRow dr in dt.Rows)
                {
                    dr["FullName"] = "<a href='Pikcv.aspx?Pik=Company-Jobs-JobApplicants&UserID=" + dr["UserID"].ToString() + "&JobApplicantID=" + dr["JobApplicantID"].ToString() + "'>" + dr["FullName"].ToString() + "</a>";
                    if (!(Convert.ToInt32(dr["JobApplicationStatusID"]) == (int)PIKCV.COM.EnumDB.JobApplicationStates.Unsuitability))
                        dr["Unsuitability"] = dr["Unsuitability"] = "<a href=\"" + this.OpenConfirm(PIKCV.COM.EnumDB.ErrorTypes.cJobApplicantUnsuitabilitySet, Convert.ToInt32(dr["JobApplicantID"])) + "\">Reddet<a>";
                }

                FilterCount(dtInfo);

                AddListFilterTypes(dt, "JobApplicationStatusID", "JobApplicationStatusName");

                DataBind(dtInfo, dt, "Company-Jobs-JobApplicants");

                lblNoRecord.Text = PIKCV.COM.Data.GetErrorMessageCache(this.cmbErrors, PIKCV.COM.EnumDB.ErrorTypes.NoApplicant);

                break;
        }
    }

}