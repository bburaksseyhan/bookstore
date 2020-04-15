using AutoMapper;
using AutoMapper.QueryableExtensions;
using BookStore.Application.Interfaces;
using BookStore.Application.ViewModel;
using BookStore.Core.Bus;
using BookStore.Domain.CategoryCommands.Commands;
using BookStore.Domain.Interfaces;
using System.Collections.Generic;

namespace BookStore.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        private readonly IMediatorHandler _bus;
        private readonly IMapper _autoMapper;

        public CategoryService(ICategoryRepository categoryRepository,
                               IMediatorHandler bus,
                               IMapper autoMapper)
        {
            _categoryRepository = categoryRepository;
            _bus = bus;
            _autoMapper = autoMapper;
        }

        public void Create(CreateCategoryViewModel categoryViewModel)
        {
            _bus.SendCommand(_autoMapper.Map<CreateCategoryCommand>(categoryViewModel));
        }

        public BaseDeleteViewModel DeleteCategory(int id)
        {
            return new BaseDeleteViewModel()
            {
                 IsDeleted = _categoryRepository.DeleteCategory(id)
            };
        }

        public IEnumerable<GetCategoryViewModel> GetCategories()
        {
            return _categoryRepository.GetCategories()
                                      .ProjectTo<GetCategoryViewModel>(_autoMapper.ConfigurationProvider);
        }

        public CategoryDetailsViewModel GetCategory(int id)
        {
            return new CategoryDetailsViewModel()
            {
                Category = _categoryRepository.GetCategory(id)
            };
        }
    }
}


