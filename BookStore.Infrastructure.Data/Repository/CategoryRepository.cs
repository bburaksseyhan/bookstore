using BookStore.Domain.Interfaces;
using BookStore.Domain.Models;
using BookStore.Infrastructure.Data.Context;
using System.Collections.Generic;

namespace BookStore.Infrastructure.Data.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly BookStoreDBContext _context;
        public CategoryRepository(BookStoreDBContext context)
        {
            _context = context;
        }

        public void Add(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public IEnumerable<Category> GetCategories()
        {
            return _context.Categories;
        }
    }
}
