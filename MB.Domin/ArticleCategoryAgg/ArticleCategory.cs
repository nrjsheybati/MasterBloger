using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Domin.ArticleCategoryAgg
{
    public class ArticleCategory
    {
        public ArticleCategory(string title)
        {

            Title = title;
            IsDeleted = false;
            CreateTitel = DateTime.Now;
        }
        public long Id { get; set; }
        public string Title { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreateTitel { get; set; }
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
