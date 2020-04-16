using BookStore.Application.Request.CategoryRequest;
using BookStore.Application.Request.CategoryResponse;
using BookStore.Application.Request.CreateRequest;
using BookStore.Application.Response;
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
