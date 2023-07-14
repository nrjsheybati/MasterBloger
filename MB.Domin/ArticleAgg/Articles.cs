using MB.Domin.ArticleCategoryAgg;
using MB.Domin.CommentAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Domin.ArticleAgg
{
    public class Articles
    {
        public long Id { get; set; }
        public string Title { get; private set; }
        public string ShortDescription { get; private set; }
        public string? Image { get; private set; }
        public string Content { get; private set; }
        public bool IsDeleted { get; private set; }
        public DateTime CreateionDate { get; private set; }  
        public long ArticleCategoryId { get; private set; }
        public ArticleCategory articleCategory { get; private set; }
        public ICollection<Comment> Comments { get; private set; }

        protected Articles()
        {

        }

        public Articles(string title, string shortDescription, string image, string content, long articleCategoryId)
        {
            Title = title;
            ShortDescription = shortDescription;
            Image = image;
            Content = content;
            IsDeleted = false;
            CreateionDate = DateTime.Now;
            ArticleCategoryId = articleCategoryId;
            Comments = new List<Comment>();

        }

        public void Edit(string title ,  string shortDescription, string image, string content, long articleCategoryId)
        {
            Title = title;
            ShortDescription = shortDescription;
            Image = image;
            Content = content;
            ArticleCategoryId = articleCategoryId;
        }
        public void Remove(long id)
        {
            IsDeleted = true;
        }
        public void Active(long id)
        {
            IsDeleted = false;
        }
    }
}
