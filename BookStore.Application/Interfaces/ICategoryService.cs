using BookStore.Application.ViewModel;
using System.Collections.Generic;

namespace BookStore.Application.Interfaces
{
    public interface ICategoryService
    {
        IEnumerable<GetCategoryViewModel> GetCategories();

        void Create(CreateCategoryViewModel categoryViewModel);

        BaseDeleteViewModel DeleteCategory(int id);

        CategoryDetailsViewModel GetCategory(int id);
    }
}
