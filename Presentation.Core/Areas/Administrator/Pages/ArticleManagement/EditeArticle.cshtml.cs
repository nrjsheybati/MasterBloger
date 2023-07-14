using MB.Application.Contracts.Article;
using MB.Application.Contracts.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Presentation.Areas.Administrator.Pages.ArticleManagement
{
    public class EditeArticleModel : PageModel
    {
        [BindProperty] public EditArticle editeArticle { get; set; }
        private readonly IArticleApplication _articleApplication;

        public List<SelectListItem> ArticleCategories { get; set; }
        private readonly IArticleCategoryApplication _articleCategoryApplication;

        public EditeArticleModel(IArticleApplication articleApplication, IArticleCategoryApplication articleCategoryApplication)
        {
            _articleApplication = articleApplication;
            _articleCategoryApplication = articleCategoryApplication;
        }
        public void OnGet(long id)
        {
            editeArticle = _articleApplication.EditArticle(id);
            ArticleCategories = _articleCategoryApplication.List()
.Select(x => new SelectListItem(x.Title, x.Id.ToString())).ToList();
        }
        public RedirectToPageResult OnPost()
        {
            _articleApplication.Edit(editeArticle);
            return RedirectToPage("./ListAll");
        }
    }
}
