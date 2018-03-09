using System;
using System.Collections.Generic;
using System.Text;
using CARETTA.COM;
using System.Data;
using System.Collections;
namespace PIKCV.BUS
{
    public class Projects
    {
        public static DataTable GetCompanyProjectDetail(int CustomProjectID, PIKCV.COM.EnumDB.LanguageID LanguageID, bool IsDeleted)
        {
            PIKCV.DAL.CustomProjects obj = new PIKCV.DAL.CustomProjects();
            return obj.GetCompanyProjectDetail(CustomProjectID, (int)LanguageID, IsDeleted);
        }

        public static DataTable GetCompanyProjects(int CompanyID, bool IsDeleted)
        {
            PIKCV.DAL.CustomProjects obj = new PIKCV.DAL.CustomProjects();
            obj.Where.CompanyID.Value = CompanyID;
            obj.Where.IsDeleted.Value = IsDeleted;
            obj.Query.AddOrderBy("CreateDate", PIKCV.DAO.WhereParameter.Dir.DESC);
            obj.Query.Load();
            return obj.DefaultView.ToTable();
        }
    }
}
