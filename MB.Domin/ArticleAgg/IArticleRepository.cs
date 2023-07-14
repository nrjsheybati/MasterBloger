using MB.Application.Contracts.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Domin.ArticleAgg
{
    public interface IArticleRepository
    {
        List<ArticleViewModel> GetAll();
        void AddArticle(Articles articles);
        Articles GetById(int id);
        void DeleteArticle(Articles articles);
        void UpdateArticle(Articles articles);
        void Save();
    }
}
