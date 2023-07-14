using MB.Application.Contracts.Comment;
using MB.Domin.CommentAgg;
using MB.Infrastructure.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Infrastructure.EFCore.Repository
{
    public class CommentRepository : ICommentRepository
    {
        private readonly MasterBloggerContext _context;

        public CommentRepository(MasterBloggerContext context)
        {
            _context = context;
        }

        public void AddArticle(Comment articles)
        {
            _context.Add(articles);
            save();
        }

        public List<CommentViewModel> GetAll()
        {
            return _context.comments.Include(x => x.Article).Select(x => new CommentViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Email = x.Email,
                Message = x.Message,
                Status = x.Status,
                CreationDate = x.CreationDate.ToString(CultureInfo.InvariantCulture),
                Article = x.Article.Title
            }).ToList();
        }

        public void save()
        {
            _context.SaveChanges();
        }
    }
}
