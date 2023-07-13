using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Application.Contracts.ArticleCategory
{
    public interface IArticleCategoryApplication
    {

        List<ArticleCategoryViewModel> List();
        void create(CreateArticleCategory createArticle);
        void Edite(RenameArticleCategory renameArticleCategory);
        RenameArticleCategory rename(long id);  
        void Delete(long id);
        void Active(long id);
    }
}
