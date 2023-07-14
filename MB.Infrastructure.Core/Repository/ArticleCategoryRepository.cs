using MB.Domin.ArticleCategoryAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Infrastructure.Core.Repository
{
    public class ArticleCategoryRepository: IArticleCategoryRepository
    {
        private readonly MasterBloggerContext _masterBloggerContext;
         public ArticleCategoryRepository(MasterBloggerContext bloggerContext)
        {
            _masterBloggerContext = bloggerContext; 
        }

        public void AddArticle(ArticleCategory category)
        {
            _masterBloggerContext.ArticleCategories.Add(category);
            Save();

        }
        public List<ArticleCategory> GetAll()
        {
           return _masterBloggerContext.ArticleCategories.ToList();
        }

        public void DeleteArticle(ArticleCategory category)
        {
            throw new NotImplementedException();
        }
 
        public void Save()
        {
            _masterBloggerContext.SaveChanges();
        }

        public ArticleCategory GetById(int id)
        {
            return _masterBloggerContext.ArticleCategories.FirstOrDefault(q => q.Id == id);
        }

        public void UpdateArticle(ArticleCategory category)
        {
            throw new NotImplementedException();
        }


        //public List<ArticleCategory> GetAll2()
        //{

        //   return _masterBloggerContext.ArticleCategories.Where(Q=>Q.Title.Contains("a") ).ToList();

        //}
    }
}
