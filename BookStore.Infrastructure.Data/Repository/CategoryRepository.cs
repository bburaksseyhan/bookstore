using BookStore.Domain.Interfaces;
using BookStore.Domain.Models;
using BookStore.Infrastructure.Data.Context;
using System.Collections.Generic;
using System.Linq;

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

        public bool DeleteCategory(int id)
        {
            bool result = false;

            var category = GetCategory(id);

            if (category == null)
            {
                return result = false;
            }

            _context.Categories.Remove(category);
            result = _context.SaveChanges() > 0;

            return result;
        }

        public IEnumerable<Category> GetCategories()
        {
            return _context.Categories;
        }

        public Category GetCategory(int id)
        {
            return _context.Categories.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
