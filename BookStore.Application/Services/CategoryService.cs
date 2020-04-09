using BookStore.Application.Interfaces;
using BookStore.Application.ViewModel;
using BookStore.Domain.Interfaces;

namespace BookStore.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public CategoryViewModel GetCategories()
        {
            return new CategoryViewModel()
            {
                Categories = _categoryRepository.GetCategories()
            };
        }
    }
}
