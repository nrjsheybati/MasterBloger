using MB.Application.Contracts.Comment;
using MB.Infrastructure.Query;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Presentation.Pages
{
    public class ArticleDetailsModel : PageModel
    {
        public ArticleViewQuery Article { get; set; }
        private readonly ICommentApplication _commentApplication;


        private readonly IArticleQuery _articleQuery;

        public ArticleDetailsModel(IArticleQuery articleQuery, ICommentApplication commentApplication)
        {
            _articleQuery = articleQuery;
            _commentApplication = commentApplication;
        }

        public void OnGet(long id)
        {
            Article = _articleQuery.GetById(id);
        }
        public RedirectToPageResult OnPost(AddComment command)
        {
            _commentApplication.AddComment(command);
            return RedirectToPage("./ArticleDetails", new { id = command.ArticleId });
        }
    }
}
