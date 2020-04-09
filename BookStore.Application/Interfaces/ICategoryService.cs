using BookStore.Application.ViewModel;

namespace BookStore.Application.Interfaces
{
    public interface ICategoryService
    {
        GetCategoryViewModel GetCategories();

        void Create(CreateCategoryViewModel categoryViewModel);

        DeleteCategoryViewModel DeleteCategory(int id);

        GetOneCategoryViewModel GetCategory(int id);
    }
}
