using MB.Domin.ArticleAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Domin.CommentAgg
{
    public class Comment
    {
        public Comment(string name, string email, string message, long articleId)
        {
            Name = name;
            Email = email;
            Message = message;
            ArticleId = articleId;
            CreationDate= DateTime.Now;
            Status = (int)status.New;
        }

        public void Confirm()
        {
            Status = (int)status.Confirmed;
        }

        public void Cancel()
        {
            Status = (int)status.Canceled;
        }
       public enum status
        {
            New = 1,
            Confirmed = 2,
            Canceled = 3
        }
        public long Id { get; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Message { get; private set; }
        public int Status { get; private set; }
        public long ArticleId { get; private set; }
        public Articles Article { get; private set; }
        public DateTime CreationDate { get; private set; }



    }

}
