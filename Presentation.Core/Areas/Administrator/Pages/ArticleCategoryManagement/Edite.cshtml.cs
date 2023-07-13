using MB.Application.Contracts.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Presentation.Areas.Administrator.Pages.ArticleCategoryManagement
{
    public class EditeModel : PageModel
    {
       [BindProperty] public RenameArticleCategory RenameArticleCategory { get; set; }
        private readonly IArticleCategoryApplication _articleCategoryApplication;

        public EditeModel(IArticleCategoryApplication articleCategoryApplication)
        {
            _articleCategoryApplication = articleCategoryApplication;
        }

        public void OnGet(long id)
        {
            RenameArticleCategory=_articleCategoryApplication.rename(id);
        }
        public RedirectToPageResult OnPost()
        {
            _articleCategoryApplication.Edite(RenameArticleCategory);
            return RedirectToPage("./List");
        }
    }
}
