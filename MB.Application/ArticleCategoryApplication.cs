using MB.Application.Contracts.ArticleCategory;
using MB.Domin.ArticleCategoryAgg;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Application
{
    public class ArticleCategoryApplication : IArticleCategoryApplication
    {
        private readonly IArticleCategoryRepository _articleCategoryRepository;
        public ArticleCategoryApplication(IArticleCategoryRepository articleCategoryRepository)
        {
            _articleCategoryRepository = articleCategoryRepository;

        }

        public void Active(long id)
        {
            var category = _articleCategoryRepository.GetById((int)id);
            category.Active(id);
            _articleCategoryRepository.Save();
        }

        public void create(CreateArticleCategory createArticle)
        {
            var articlecategory = new ArticleCategory(createArticle.Title);
            _articleCategoryRepository.AddArticle(articlecategory);
        }

        public void Delete(long id)
        {
            var category = _articleCategoryRepository.GetById((int)id);
            category.Remove(id);
            _articleCategoryRepository.Save();
        }

        public void Edite(RenameArticleCategory renameArticleCategory)
        {
            var category = _articleCategoryRepository.GetById((int)renameArticleCategory.Id);
            category.Rename(renameArticleCategory.Title);
            _articleCategoryRepository.Save();
        }

        public List<ArticleCategoryViewModel> List()
        {
            var articleCategories = _articleCategoryRepository.GetAll();

            return articleCategories.Select(articleCategory => new ArticleCategoryViewModel
            {
                Id = articleCategory.Id,
                Title = articleCategory.Title,
                IsDeleted = articleCategory.IsDeleted,
                CreationDate = articleCategory.CreateTitel.ToString(CultureInfo.InvariantCulture)
            }).OrderByDescending(x => x.Id).ToList();
        }

        public RenameArticleCategory rename(long id)
        {
            var articleup = _articleCategoryRepository.GetById((int)id);
            return new RenameArticleCategory
            {
                Id=articleup.Id,
                Title=articleup.Title,
            };
        }
    }
}
