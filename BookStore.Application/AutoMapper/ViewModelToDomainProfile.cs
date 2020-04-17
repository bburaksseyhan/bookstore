using AutoMapper;
using BookStore.Application.Request.CompanyRequest;
using BookStore.Application.Request.CreateRequest;
using BookStore.Application.Request.SignupRequest;
using BookStore.Application.Requet.BookRequest;
using BookStore.Domain.BookCommands.Commands;
using BookStore.Domain.CategoryCommands.Commands;
using BookStore.Domain.Commands.AuthCommands;
using BookStore.Domain.Commands.CompanyCommands;

namespace BookStore.Application.AutoMapper
{
    public class ViewModelToDomainProfile : Profile
    {
        public ViewModelToDomainProfile()
        {
            CreateMap<CreateCategoryViewModel, CreateCategoryCommand>()
                .ConstructUsing(x => new CreateCategoryCommand(x.Name, x.Description));

            CreateMap<CreateBookViewModel, CreateBookCommand>()
                .ConvertUsing(x => new CreateBookCommand(x.CategoryId, x.ISBN, x.Name, x.Language, x.Author, x.Publisher, x.Description, x.ImageUrl, x.Price));

            CreateMap<SignUpViewModel, CreateUserCommand>()
                .ConvertUsing(x => new CreateUserCommand(x.FirstName, x.LastName, x.Email, x.Password, x.RePassword));

            CreateMap<CreateCompanyViewModel, CreateCompanyCommand>()
               .ConvertUsing(x => new CreateCompanyCommand(x.UserId, x.Name, x.CentralRegisrationSystemNo, x.EmailAddress, x.ImageUrl, x.Description, x.IsActice));
        }
    }
}
