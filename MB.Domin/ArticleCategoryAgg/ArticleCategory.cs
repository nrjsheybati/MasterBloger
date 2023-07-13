using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MB.Domin.ArticleAgg;
using System.Collections.Generic;

namespace MB.Domin.ArticleCategoryAgg
{
    public class ArticleCategory
    {
        public ArticleCategory(string title)
        {

            Title = title;
            IsDeleted = false;
            CreateTitel = DateTime.Now;
            Articles = new List<Articles>();
        }

        protected ArticleCategory()
        {
        }
        public long Id { get; private set; }
        public string Title { get; private set; }
        public bool IsDeleted { get; private set; }
        public DateTime CreateTitel { get; private set; }
        public ICollection<Articles> Articles { get; set; }
        //public ICollection<Article> Articles { get; set; }
        public void Rename(string title)
        {
            Title = title;
        }
        public void Remove(long id)
        {
            IsDeleted = true;
        }
        public void Active(long id)
        {
            IsDeleted=false;
        }

    }

}
