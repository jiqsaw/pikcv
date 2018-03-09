using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections;
using PIKCV.COM;

public class CM
{
    public CM()
    {
        this.m_htCache = new Hashtable();
    }

    private Hashtable m_htCache;
    private string SplitCellName = "LanguageID";
    public struct CacheValue
    {
        public EnumUtil.CacheTypes Code;
        public int Period;
        public DateTime TimeStamp;
        public string Description;
        public DataTable Data;
    }

    private string ReturnStrKey(EnumUtil.CacheTypes CacheType, int SplitID)
    {
        return ((int)CacheType).ToString() + "||" + SplitID.ToString().PadLeft(2, '0');
    }

    public Hashtable GenerateHash(EnumUtil.CacheTypes CacheType, EnumUtil.CachePeriods CachePeriod, string CacheDescription, DataTable dtDataSource, string SplitCellName)
    {
        Hashtable Hash = new Hashtable();
        DataTable dtData = new DataTable();
        string Key = String.Empty;
        CacheValue CacheValue = new CacheValue();
        if (SplitCellName == String.Empty) { SplitCellName = this.SplitCellName; }
        if (isHasSplitCell(dtDataSource, SplitCellName))
        {
            dtDataSource.DefaultView.Sort = SplitCellName;
            dtDataSource = dtDataSource.DefaultView.ToTable();
            for (int i = 0; i < dtDataSource.Rows.Count; i++)
            {
                if (i != dtDataSource.Rows.Count - 1)
                {
                    if (dtDataSource.Rows[i][SplitCellName].ToString() == dtDataSource.Rows[i + 1][SplitCellName].ToString())
                    {
                        if (dtData.Columns.Count < 1) { dtData = dtDataSource.Clone(); }
                        dtData.Rows.Add(dtDataSource.Rows[i].ItemArray);
                    }
                    else
                    {
                        dtData.Rows.Add(dtDataSource.Rows[i].ItemArray);
                        Key = ReturnStrKey(CacheType, Convert.ToInt32(dtDataSource.Rows[i][SplitCellName]));
                        CacheValue = SetCacheData(CacheType, CachePeriod, CacheDescription, dtData);
                        Hash.Add(Key, CacheValue);
                        dtData = new DataTable();
                    }
                }
                else
                {
                    if (dtData.Columns.Count < 1) { dtData = dtDataSource.Clone(); }
                    dtData.Rows.Add(dtDataSource.Rows[i].ItemArray);
                    Key = ReturnStrKey(CacheType, Convert.ToInt32(dtDataSource.Rows[i][SplitCellName]));
                    CacheValue = SetCacheData(CacheType, CachePeriod, CacheDescription, dtData);
                    Hash.Add(Key, CacheValue);
                    dtData = new DataTable();
                }
            }
        }
        else
        {
            Key = ReturnStrKey(CacheType, 0);
            CacheValue = SetCacheData(CacheType, CachePeriod, CacheDescription, dtDataSource);
            Hash.Add(Key, CacheValue);
        }
        return Hash;
    }

    private CacheValue SetCacheData(EnumUtil.CacheTypes CacheType, EnumUtil.CachePeriods CachePeriod, string Description, DataTable Data)
    {
        CacheValue CacheValue = new CacheValue();
        CacheValue.Code = CacheType;
        CacheValue.Period = (int)CachePeriod;
        CacheValue.TimeStamp = DateTime.Now;
        CacheValue.Description = Description;
        CacheValue.Data = Data;
        return CacheValue;
    }

    public bool isHasSplitCell(DataTable dt, string SplitCellName)
    {
        foreach (DataColumn dc in dt.Columns)
        {
            if (dc.ColumnName == SplitCellName) { return true; }
        }
        return false;
    }

}