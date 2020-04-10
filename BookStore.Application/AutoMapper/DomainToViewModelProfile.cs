using AutoMapper;
using BookStore.Application.ViewModel;
using BookStore.Domain.Models;

namespace BookStore.Application.AutoMapper
{
    public class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile()
        {
            //category mapper
            CreateMap<Category, CreateCategoryViewModel>();
            CreateMap<Category, GetCategoryViewModel>();

            //book mapper
            CreateMap<Book, CreateBookViewModel>();
            CreateMap<Book, GetBooksViewModel>();
        }
    }
}
