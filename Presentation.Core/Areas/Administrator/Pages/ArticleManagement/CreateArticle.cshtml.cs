using MB.Application.Contracts.Article;
using MB.Application.Contracts.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Presentation.Areas.Administrator.Pages.ArticleManagement
{
    public class CreateArticleModel : PageModel
    {

        private readonly IArticleApplication _articleApplication;
        public List<SelectListItem> ArticleCategories { get; set; }
        private readonly IArticleCategoryApplication _articleCategoryApplication;

        public CreateArticleModel(IArticleApplication articleApplication, IArticleCategoryApplication articleCategoryApplication)
        {
            _articleApplication = articleApplication;
            _articleCategoryApplication = articleCategoryApplication;
        }

        public void OnGet()
        {
            ArticleCategories = _articleCategoryApplication.List()
     .Select(x => new SelectListItem(x.Title, x.Id.ToString())).ToList();
        }
        public RedirectToPageResult OnPost(CreateArticle createArticle)
        {
            _articleApplication.create(createArticle);
            return RedirectToPage("./ListAll");
        }
    }
}
