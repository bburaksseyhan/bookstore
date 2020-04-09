using BookStore.Domain.Models;
using System.Collections.Generic;

namespace BookStore.Domain.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategories();

        void Add(Category category);
    }
}
