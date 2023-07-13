using MB.Application.Contracts.ArticleCategory;
using MB.Infrastructure.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Presentation.Areas.Administrator.Pages.ArticleCategoryManagement
{

    public class ListModel : PageModel
    {
        public List<ArticleCategoryViewModel> ArticleCategories { get; set; }
        private readonly IArticleCategoryApplication _articleCategoryApplication;


        public ListModel(IArticleCategoryApplication articleCategoryApplication)
        {
            _articleCategoryApplication = articleCategoryApplication;
        }


        public void OnGet()
        {
            ArticleCategories = _articleCategoryApplication.List();
        }
        public RedirectToPageResult OnpostRemove(long id)
        {
            _articleCategoryApplication.Delete(id);
            return RedirectToPage("./List");
        }
        public RedirectToPageResult OnpostActivate(long id)
        {
            _articleCategoryApplication.Active(id);
            return RedirectToPage("./List");
        }
    }
}
