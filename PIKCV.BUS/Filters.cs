using System;
using System.Collections.Generic;
using System.Text;
using CARETTA.COM;
using System.Data;

namespace PIKCV.BUS
{
    public class Filters
    {
        public static void SaveFilter(PIKCV.COM.EnumDB.FilterTypes FilterType, string FilterName, int OwnerID, PIKCV.COM.EnumDB.MemberTypes MemberType, string FilterValue) {
            try {
                PIKCV.DAL.Filters objFilter = new PIKCV.DAL.Filters();
                objFilter.AddNew();
                objFilter.CreateDate = DateTime.Now;
                objFilter.FilterName = Util.ReplaceStrForDB(FilterName);
                objFilter.FilterOwnerID = OwnerID;
                objFilter.FilterOwnerTypeCode = (int)MemberType;
                objFilter.FilterTypeCode = (int)FilterType;
                objFilter.FilterValue = FilterValue;
                objFilter.IsDeleted = false;
                objFilter.ModifyDate = DateTime.Now;
                objFilter.Save();
            }
            catch (Exception) {
            }

        }

        public static DataTable GetUserFilters(PIKCV.COM.EnumDB.FilterTypes FilterType, int OwnerID, PIKCV.COM.EnumDB.MemberTypes MemberType, bool IsDeleted) {
            PIKCV.DAL.Filters objFilters = new PIKCV.DAL.Filters();
            objFilters.Where.FilterTypeCode.Value = (int)FilterType;
            objFilters.Where.FilterOwnerID.Value = OwnerID;
            objFilters.Where.FilterOwnerTypeCode.Value = (int)MemberType;
            objFilters.Where.IsDeleted.Value = IsDeleted;
            objFilters.Query.Load();
            return objFilters.DefaultView.ToTable();
        }

        public static DataRow GetFilter(int FilterID)
        {
            PIKCV.DAL.Filters objFilters = new PIKCV.DAL.Filters();
            objFilters.LoadByPrimaryKey(FilterID);
            return objFilters.DefaultView.ToTable().Rows[0];
        }

        public static int CheckFilterExistance(int UserID, string FilterName, PIKCV.COM.EnumDB.MemberTypes MemberType, PIKCV.COM.EnumDB.FilterTypes FilterType)
        {
            PIKCV.DAL.Filters objFilters = new PIKCV.DAL.Filters();
            objFilters.Where.FilterName.Value = FilterName;
            objFilters.Where.FilterOwnerID.Value = UserID;
            objFilters.Where.FilterOwnerTypeCode.Value = (int)MemberType;
            objFilters.Where.FilterTypeCode.Value = (int)FilterType;
            objFilters.Where.IsDeleted.Value = false;
            objFilters.Query.Load();
            return objFilters.DefaultView.ToTable().Rows.Count;
        }


        public static bool RemoveFilter(int FilterID) {
            try
            {
                PIKCV.DAL.Filters objFilters = new PIKCV.DAL.Filters();
                objFilters.LoadByPrimaryKey(FilterID);
                objFilters.IsDeleted = true;
                objFilters.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
 
        }

        public static void RenameFilter(int FilterID, string FilterName)
        {
            PIKCV.DAL.Filters objFilters = new PIKCV.DAL.Filters();
            objFilters.LoadByPrimaryKey(FilterID);
            objFilters.FilterName = Util.ReplaceStrForDB(FilterName);
            objFilters.Save();
        }
    }
}