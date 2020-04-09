using BookStore.Application.ViewModel;

namespace BookStore.Application.Interfaces
{
    public interface ICategoryService
    {
        CategoryViewModel GetCategories();
    }
}
