using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PIKCV.COM;

namespace PIKCV.BUS
{
    public class Places
    {

        //T�m �lkeleri Getir 
        public static DataTable GetCountries(bool isDeleted)
        {
            DataTable dt;
            try
            {
                PIKCV.DAL.Places objPlaces = new PIKCV.DAL.Places();
                dt = objPlaces.LoadAllML((int)EnumDB.Places.CountriesParentID, false);
            }
            catch (Exception)
            {
                dt = null;
                throw;
            }
            return dt;
        }


        //T�m �ehirleri Getir 
        public static DataTable GetCities(int PlaceID, bool isDeleted)
        {
            DataTable dt;
            try
            {
                PIKCV.DAL.Places objPlaces = new PIKCV.DAL.Places();
                dt = objPlaces.LoadAllML((int)EnumDB.Places.TurkeyPlaceID, false);
            }
            catch (Exception)
            {
                dt = null;
                throw;
            }
            return dt;
        }

    }
}
