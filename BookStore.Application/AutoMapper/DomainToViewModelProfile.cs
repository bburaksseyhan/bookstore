using AutoMapper;
using BookStore.Application.Request.CategoryRequest;
using BookStore.Application.Request.CompanyRequest;
using BookStore.Application.Request.CompanyResponse;
using BookStore.Application.Request.CreateRequest;
using BookStore.Application.Request.SignupRequest;
using BookStore.Application.Requet.BookRequest;
using BookStore.Application.Response.BookResponse;
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

            //user mapper
            CreateMap<User, SignUpViewModel>();

            //Company mapper
            CreateMap<Company, CreateCompanyViewModel>();
            CreateMap<Company, CompanyViewModel>();
        }
    }
}
