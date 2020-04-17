using BookStore.Application.Request.CategoryRequest;
using BookStore.Application.Request.CreateRequest;

namespace BookStore.Application.Interfaces
{
    public interface ICategoryService : IBaseService<CreateCategoryViewModel, GetCategoryViewModel, int>
    {
    }
}
