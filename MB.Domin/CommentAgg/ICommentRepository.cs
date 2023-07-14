using MB.Application.Contracts.Comment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Domin.CommentAgg
{
    public interface ICommentRepository
    {
        List<CommentViewModel> GetAll();
        void AddArticle(Comment articles);
        void save();
    }
}
