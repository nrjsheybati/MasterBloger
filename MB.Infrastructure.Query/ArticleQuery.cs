using MB.Infrastructure.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Infrastructure.Query
{
    public class ArticleQuery : IArticleQuery
    {
        private readonly MasterBloggerContext _context;

        public ArticleQuery(MasterBloggerContext context)
        {
            _context = context;
        }

        public List<ArticleViewQuery> GetArticles()
        {
            return _context.Articles.Include(x => x.articleCategory).Select(x => new ArticleViewQuery
            {
                Id = x.Id,
                Title = x.Title,
                articleCategory = x.articleCategory.Title,
                CreateionDate = x.CreateionDate.ToString(CultureInfo.InvariantCulture),
                ShortDescription = x.ShortDescription,
                Image = x.Image,

            }).ToList();
        }


        public ArticleViewQuery GetById(long id)
        {
            return _context.Articles.Include(x => x.articleCategory).Select(x => new ArticleViewQuery
            {
                Id = x.Id,
                Title = x.Title,
                articleCategory = x.articleCategory.Title,
                CreateionDate = x.CreateionDate.ToString(CultureInfo.InvariantCulture),
                ShortDescription = x.ShortDescription,
                Image = x.Image,
                Content = x.Content,

            }).FirstOrDefault(x => x.Id == id);
        }
    }
}
