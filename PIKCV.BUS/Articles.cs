using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace PIKCV.BUS
{
    public class Articles
    {
        public DataTable GetTopArticles() {
            PIKCV.DAL.Articles obj = new PIKCV.DAL.Articles();
            obj.Where.ArticleTypeCode.Value = (int)PIKCV.COM.EnumDB.ArticleTypes.Article;
            obj.Where.IsMain.Value = true;
            obj.Query.AddOrderBy("ModifyDate", PIKCV.DAO.WhereParameter.Dir.DESC);
            obj.Query.Top = 1;
            obj.Query.Load();
            return obj.DefaultView.ToTable();
        }

        public DataTable GetArticleDetail(int ArticleID)
        {
            PIKCV.DAL.Articles obj = new PIKCV.DAL.Articles();
            obj.Where.ArticleTypeCode.Value = (int)PIKCV.COM.EnumDB.ArticleTypes.Article;
            obj.Where.ArticleID.Value = ArticleID;
            obj.Query.Load();
            return obj.DefaultView.ToTable();
        }

        public DataTable GetAllArticles()
        {
            PIKCV.DAL.Articles obj = new PIKCV.DAL.Articles();
            obj.Query.AddOrderBy("ModifyDate", PIKCV.DAO.WhereParameter.Dir.DESC);
            obj.Query.Load();
            return obj.DefaultView.ToTable();
        }
    }
}
