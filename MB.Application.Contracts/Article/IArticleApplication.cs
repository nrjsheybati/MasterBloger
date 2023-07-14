using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Application.Contracts.Article
{
    public interface IArticleApplication
    {
        List<ArticleViewModel> List();
        void create(CreateArticle createArticle);
        void Edit(EditArticle renameArticleCategory);
        EditArticle EditArticle(long id);
        void Delete(long id);
        void Active(long id);
    }
}
