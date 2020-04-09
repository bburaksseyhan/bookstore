using BookStore.Application.ViewModel;
using System.Collections.Generic;

namespace BookStore.Application.Interfaces
{
    public interface ICategoryService
    {
        IEnumerable<GetCategoryViewModel> GetCategories();

        void Create(CreateCategoryViewModel categoryViewModel);

        DeleteCategoryViewModel DeleteCategory(int id);

        GetOneCategoryViewModel GetCategory(int id);
    }
}
