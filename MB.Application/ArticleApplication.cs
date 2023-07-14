using MB.Application.Contracts.Article;
using MB.Domin.ArticleAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Application
{
    public class ArticleApplication : IArticleApplication
    {
        private readonly IArticleRepository _articlerepository;

        public ArticleApplication(IArticleRepository articlerepository)
        {
            _articlerepository = articlerepository;
        }

        public void Active(long id)
        {
            var Article = _articlerepository.GetById((int)id);
            Article.Active(id);
            _articlerepository.save();
        }

        public void create(CreateArticle createArticle)
        {
            var Articles = new Articles(createArticle.Title ,createArticle.ShortDescription , createArticle.Image , createArticle.Content , createArticle.ArticleCategoryId);
            _articlerepository.AddArticle(Articles);
        }

        public void Delete(long id)
        {
            var articles =_articlerepository .GetById((int)id);
            articles.Remove(id);
            _articlerepository.save();
            
        }

        public void Edit(EditArticle renameArticle)
        {
            var category = _articlerepository.GetById((int)renameArticle.Id);
            category.Edit(renameArticle.Title , renameArticle.ShortDescription , renameArticle.Image , renameArticle.Content , renameArticle.ArticleCategoryId);
            _articlerepository.save();
        }

        public List<ArticleViewModel> List()
        {
            return _articlerepository.GetAll(); 
        }

        public EditArticle EditArticle(long id)
        {
            var articleup = _articlerepository.GetById((int)id);
            return new EditArticle
            {
                Id = articleup.Id,
                Title = articleup.Title,
                ShortDescription = articleup.ShortDescription,
                Image = articleup.Image,
                Content = articleup.Content,
                ArticleCategoryId = articleup.ArticleCategoryId,

                
            };
        }

        //public void Save()
        //{
        //    _articlerepository.save();
        //}
    }
}
