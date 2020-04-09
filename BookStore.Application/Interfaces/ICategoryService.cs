using BookStore.Application.ViewModel;
using System.Collections.Generic;

namespace BookStore.Application.Interfaces
{
    public interface ICategoryService
    {
        CategoryViewModel GetCategories();
    }
}
