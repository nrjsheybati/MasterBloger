using MB.Application.Contracts.Article;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Presentation.Areas.Administrator.Pages.ArticleManagement
{
    public class ListAllModel : PageModel
    {

        public List<ArticleViewModel> Articles { get; set; }
        private readonly IArticleApplication _articleApplication;

        public ListAllModel(IArticleApplication articleApplication)
        {
            _articleApplication = articleApplication;
        }

        public void OnGet()
        {
            Articles = _articleApplication.List();
        }
        public RedirectToPageResult OnpostRemove(long id)
        {
            _articleApplication.Delete(id);
            return RedirectToPage("./ListAll");
        }
        public RedirectToPageResult OnpostActivate(long id)
        {
            _articleApplication.Active(id);
            return RedirectToPage("./ListAll");
        }
    }
}
