using AutoMapper;
using BookStore.Application.ViewModel;
using BookStore.Domain.BookCommands.Commands;
using BookStore.Domain.CategoryCommands.Commands;

namespace BookStore.Application.AutoMapper
{
    public class ViewModelToDomainProfile : Profile
    {
        public ViewModelToDomainProfile()
        {
            CreateMap<CreateCategoryViewModel, CreateCategoryCommand>()
                .ConstructUsing(x => new CreateCategoryCommand(x.Name, x.Description));

            CreateMap<CreateBookViewModel, CreateBookCommand>()
                .ConvertUsing(x => new CreateBookCommand(x.CategoryId, x.ISBN, x.Name, x.Language, x.Author, x.Publisher, x.Description, x.ImageUrl));
        }
    }
}
