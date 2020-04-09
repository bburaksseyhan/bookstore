using BookStore.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace BookStore.Domain.Interfaces
{
    public interface ICategoryRepository
    {
        IQueryable<Category> GetCategories();

        void Add(Category category);

        Category GetCategory(int id);

        bool DeleteCategory(int id);
    }
}
