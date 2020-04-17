using AutoMapper;
using AutoMapper.QueryableExtensions;
using BookStore.Application.Interfaces;
using BookStore.Application.Request.CategoryRequest;
using BookStore.Application.Request.CreateRequest;
using BookStore.Application.Response;
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

        public void Add(CreateCategoryViewModel categoryViewModel)
        {
            _bus.SendCommand(_autoMapper.Map<CreateCategoryCommand>(categoryViewModel));
        }

        public IEnumerable<GetCategoryViewModel> GetAll()
        {
            return _categoryRepository.GetAll()
                                       .ProjectTo<GetCategoryViewModel>(_autoMapper.ConfigurationProvider);
        }

        public BaseResponse<GetCategoryViewModel> Detail(int id)
        {
            var data = _categoryRepository.Detail(id);

            return new BaseResponse<GetCategoryViewModel>()
            {
                Data = _autoMapper.Map<GetCategoryViewModel>(data)
            };
        }

        public BaseResponse<bool> Remove(int id)
        {
            return new BaseResponse<bool>()
            {
                IsSuccess = _categoryRepository.Remove(id)
            };
        }
    }
}


