using BookStore.Application.Interfaces;
using BookStore.Application.ViewModel;
using BookStore.Core.Bus;
using BookStore.Domain.Commands;
using BookStore.Domain.Interfaces;

namespace BookStore.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        private readonly IMediatorHandler _bus;

        public CategoryService(ICategoryRepository categoryRepository, IMediatorHandler bus)
        {
            _categoryRepository = categoryRepository;
            _bus = bus;
        }

        public void Create(CategoryViewModel categoryViewModel)
        {
            var createCategoryCommand = new CreateCategoryCommand(
                  categoryViewModel.Name,
                  categoryViewModel.Description
                );

            _bus.SendCommand(createCategoryCommand);
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
