using BookStore.Application.Interfaces;
using BookStore.Application.ViewModel;
using BookStore.Core.Bus;
using BookStore.Domain.Categories.Commands;
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

        public void Create(CreateCategoryViewModel categoryViewModel)
        {
            var createCategoryCommand = new CreateCategoryCommand(
                  categoryViewModel.Name,
                  categoryViewModel.Description
                );

            _bus.SendCommand(createCategoryCommand);
        }

        public DeleteCategoryViewModel DeleteCategory(int id)
        {
            return new DeleteCategoryViewModel()
            {
                IsSuccess = _categoryRepository.DeleteCategory(id)
            };
        }

        public GetCategoryViewModel GetCategories()
        {
            return new GetCategoryViewModel()
            {
                Categories = _categoryRepository.GetCategories()
            };
        }

        public GetOneCategoryViewModel GetCategory(int id)
        {
            return new GetOneCategoryViewModel()
            {
                Category = _categoryRepository.GetCategory(id)
            };
        }
    }
}


