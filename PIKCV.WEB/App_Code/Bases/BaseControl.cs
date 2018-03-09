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

public class BaseControl : SM, IBaseControl
{
    #region :: CACHE ::
    public object GetCache(EnumUtil.CacheTypes CacheType)
    {
        return Cache[this.ReturnStrKey(CacheType, 00)];
    }

    public object GetCache(EnumUtil.CacheTypes CacheType, int SplitID)
    {
        return Cache[this.ReturnStrKey(CacheType, SplitID)];
    }

    protected void GenerateCache(EnumUtil.CacheTypes CacheType, EnumUtil.CachePeriods CachePeriod, string CacheDescription, DataTable Data) {
        GenerateCache(CacheType, CachePeriod, CacheDescription, Data, "");
    }
    protected void GenerateCache(EnumUtil.CacheTypes CacheType, EnumUtil.CachePeriods CachePeriod, string CacheDescription, DataTable Data, string SplitCellName) {
        CM objCM = new CM();
        Hashtable Hash = objCM.GenerateHash(CacheType, CachePeriod, CacheDescription, Data, SplitCellName);
        foreach (DictionaryEntry DE in Hash) { Cache[DE.Key.ToString()] = DE.Value; }
    }

    private string ReturnStrKey(EnumUtil.CacheTypes CacheType, int SplitID)
    {
        return ((int)CacheType).ToString() + "||" + SplitID.ToString().PadLeft(2, '0');
    }

    protected DataTable Item(EnumUtil.CacheTypes CacheType, EnumUtil.CachePeriods CachePeriod, string CacheDescription, DataTable CacheData)
    {
        return Item(CacheType, CachePeriod, 0, CacheDescription, CacheData);
    }
    protected DataTable Item(EnumUtil.CacheTypes CacheType, EnumUtil.CachePeriods CachePeriod, int SplitID, string CacheDescription, DataTable CacheData)
    {
        if (this.GetCache(CacheType, SplitID) == null) { this.GenerateCache(CacheType, CachePeriod, CacheDescription, CacheData); }
        return ((CM.CacheValue)this.GetCache(CacheType, SplitID)).Data;
    }

    protected void CacheRemove(EnumUtil.CacheTypes CacheType)
    {
        Cache.Remove(this.ReturnStrKey(CacheType, 0));
    }
    protected void CacheRemove(EnumUtil.CacheTypes CacheType, int SplitID)
    {
        Cache.Remove(this.ReturnStrKey(CacheType, SplitID));
    }
    protected void CacheClear()
    {
        foreach (DictionaryEntry DE in Cache) { Cache.Remove(DE.Key.ToString()); }
    }
    #endregion

    public string Config(PIKCV.COM.EnumUtil.Config Param)
    {
        return (ConfigurationManager.AppSettings[Param.ToString()] == null) ? String.Empty : ConfigurationManager.AppSettings[Param.ToString()].ToString();
    }
    private IBaseControl Base()
    {
        IBaseControl obj = null;
        Cookie Cookie = new Cookie();
        Enumerations.PageType CookiePageType = (Enumerations.PageType)(int.Parse(Cookie.Read(EnumUtil.Cookies.PageType)));
        if (CookiePageType == Enumerations.PageType.Company) { obj = new BaseCompany(); }
        else if (CookiePageType == Enumerations.PageType.Employee) { obj = new BaseEmployee(); }
        else { Util.GoToEntryPage(this.Response); }
        return obj;
    }

    #region IBaseControl Methods

    private string Show(IBaseControl BaseType) { return BaseType.Show(); }
    private void GoToDefaultPage(IBaseControl BaseType) { BaseType.GoToDefaultPage(); }
    private bool LoginControl(IBaseControl BaseType, string Email, string Password) 
    { 
        return BaseType.LoginControl(Email, Password); 
    }
    private void GoToLogonPage(IBaseControl BaseType) { BaseType.GoToLogonPage(); }
    private void IsLogin(IBaseControl BaseType) { BaseType.IsLogin(); }

    #endregion

    #region IBaseControl Members

    public string Show() { return this.Show(Base()); }
    public void GoToDefaultPage() { this.GoToDefaultPage(Base()); }
    public bool LoginControl(string Email, string Password) { return this.LoginControl(Base(), Email, Password); }
    public void GoToLogonPage() { this.GoToLogonPage(Base()); }
    public void IsLogin() { this.IsLogin(Base()); }

    #endregion

}
