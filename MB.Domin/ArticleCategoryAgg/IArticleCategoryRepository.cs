using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Domin.ArticleCategoryAgg
{
    public interface IArticleCategoryRepository
    {
       List<ArticleCategory> GetAll();
        void AddArticle(ArticleCategory category);
        ArticleCategory GetById(int id);
        void DeleteArticle(ArticleCategory category);
        void UpdateArticle(ArticleCategory category);
        void Save();
       
    }
}
