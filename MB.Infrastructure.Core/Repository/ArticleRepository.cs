using MB.Application.Contracts.Article;
using MB.Domin.ArticleAgg;
using MB.Infrastructure.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Infrastructure.EFCore.Repository
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly MasterBloggerContext _context;

        public ArticleRepository(MasterBloggerContext context) 
        {
            _context = context;
        }

        public List<ArticleViewModel> GetAll()
        {
            return _context.Articles.Include(x => x.articleCategory).Select(x => new ArticleViewModel
            {
                Id = x.Id,
                Title = x.Title,
                articleCategory = x.articleCategory.Title,
                IsDeleted = x.IsDeleted,
                CreateionDate = x.CreateionDate.ToString(CultureInfo.InvariantCulture)
            }).ToList();
        }

        public void AddArticle(Articles articles)
        {
            _context.Articles.Add(articles);
            save();
           
            
        }

        public void DeleteArticle(Articles articles)
        {
            throw new NotImplementedException();
        }

        public Articles GetById(long id)
        {
            return _context.Articles.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateArticle(Articles articles)
        {
            throw new NotImplementedException();
        }

        public void save()
        {
            _context.SaveChanges();
        }
    }
}
