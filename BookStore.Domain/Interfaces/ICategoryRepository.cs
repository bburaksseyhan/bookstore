using BookStore.Domain.Models;
using System.Collections.Generic;

namespace BookStore.Domain.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategories();

        void Add(Category category);

        Category GetCategory(int id);

        bool DeleteCategory(int id);
    }
}
