using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Infrastructure.Query
{
    public interface IArticleQuery
    {
        List<ArticleViewQuery> GetArticles();
        ArticleViewQuery GetById(long id);
    }

}
