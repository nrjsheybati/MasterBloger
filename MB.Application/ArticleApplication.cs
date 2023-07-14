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
            throw new NotImplementedException();
        }

        public void create(CreateArticle createArticle)
        {
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public void Edit(EditArticle renameArticleCategory)
        {
            throw new NotImplementedException();
        }

        public List<ArticleViewModel> List()
        {
            return _articlerepository.GetAll(); 
        }

        public EditArticle EditArticle(long id)
        {
            throw new NotImplementedException();
        }
    }
}
