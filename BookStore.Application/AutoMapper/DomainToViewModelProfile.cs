using AutoMapper;
using BookStore.Application.ViewModel;
using BookStore.Domain.Models;

namespace BookStore.Application.AutoMapper
{
    public class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<Category, CreateCategoryViewModel>();
            CreateMap<Category, GetCategoryViewModel>();
        }
    }
}
