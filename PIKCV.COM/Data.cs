using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Web.UI.WebControls;

namespace PIKCV.COM
{
    public class Data
    {
        public static DataRow GetErrorCache(DataTable dtErrors, EnumDB.ErrorTypes ErrorType ) {
            DataRow drError = null; ;
            foreach (DataRow dr in dtErrors.Rows) {
                if (Convert.ToInt32(dr["ErrorTypeCode"]) == (int)ErrorType) {
                    drError = dr;
                    break;
                }
            }
            return drError;
        }

        public static DataTable CountriesWithoutTurkey(DataTable dtCountries)
        {
            foreach (DataRow dr in dtCountries.Rows)
            {
                if (Convert.ToInt32(dr["PlaceID"]) == (int)EnumDB.Places.TurkeyPlaceID)
                    dr.Delete();
                break;
            }
            return dtCountries;
        }

        public static string GetErrorMessageCache(DataTable dtErrors, EnumDB.ErrorTypes ErrorType) {
            return GetErrorCache(dtErrors, ErrorType)["Message"].ToString();
        }

        public static string GetErrorMessageTitleCache(DataTable dtErrors, EnumDB.ErrorTypes ErrorType)
        {
            return GetErrorCache(dtErrors, ErrorType)["ErrorTitle"].ToString();
        }

        public static DataTable GetSchools(DataTable dtSchools, EnumDB.SchoolTypes SchoolType)
        {
            DataTable dtSchool = dtSchools.Clone();
            foreach (DataRow dr in dtSchools.Rows)
            {
                if (Convert.ToInt32(dr["SchoolTypeCode"]) == (int)SchoolType)
                {
                    dtSchool.Rows.Add(dr.ItemArray);
                }
            }
            return dtSchool;
        }

        public static DataRow GetPlace(DataTable dtPlaces, int PlaceID)
        {
            DataRow drError = null; ;
            foreach (DataRow dr in dtPlaces.Rows)
            {
                if (Convert.ToInt32(dr["PlaceID"]) == PlaceID)
                {
                    drError = dr;
                    break;
                }
            }
            return drError;
        }

        public static DataTable GetPositions(DataTable dtPositions, EnumDB.EmployeeTypes EmployeeType)
        {
            DataTable dtPosition = dtPositions.Clone();
            foreach (DataRow dr in dtPositions.Rows)
            {
                if (Convert.ToInt32(dr["PositionTypeCode"]) == (int)EmployeeType)
                {
                    dtPosition.Rows.Add(dr.ItemArray);
                }
            }
            return dtPosition;
        }

        public static void RemoveOtherItems(ref DropDownList ddl, int OtherID)
        {
            ListItem liOther = new ListItem();
            foreach (ListItem li in ddl.Items)
            {
                if (li.Value == OtherID.ToString())
                {
                    liOther = li;
                    break;
                }
            }

            ddl.Items.Remove(liOther);
            ddl.Items.Add(liOther);
        }

    }
}
 