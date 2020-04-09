using AutoMapper;
using AutoMapper.QueryableExtensions;
using BookStore.Application.Interfaces;
using BookStore.Application.ViewModel;
using BookStore.Core.Bus;
using BookStore.Domain.Categories.Commands;
using BookStore.Domain.Interfaces;
using System.Collections.Generic;

namespace BookStore.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        private readonly IMediatorHandler _bus;
        private readonly IMapper _autoMapper;

        public CategoryService(ICategoryRepository categoryRepository, IMediatorHandler bus, IMapper autoMapper)
        {
            _categoryRepository = categoryRepository;
            _bus = bus;
            _autoMapper = autoMapper;
        }

        public void Create(CreateCategoryViewModel categoryViewModel)
        {
            _bus.SendCommand(_autoMapper.Map<CreateCategoryCommand>(categoryViewModel));
        }

        public DeleteCategoryViewModel DeleteCategory(int id)
        {
            return new DeleteCategoryViewModel()
            {
                IsSuccess = _categoryRepository.DeleteCategory(id)
            };
        }

        public IEnumerable<GetCategoryViewModel> GetCategories()
        {
            return _categoryRepository.GetCategories()
                                      .ProjectTo<GetCategoryViewModel>(_autoMapper.ConfigurationProvider);
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


