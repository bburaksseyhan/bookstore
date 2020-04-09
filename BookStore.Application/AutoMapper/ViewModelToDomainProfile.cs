using AutoMapper;
using BookStore.Application.ViewModel;
using BookStore.Domain.Categories.Commands;

namespace BookStore.Application.AutoMapper
{
    public class ViewModelToDomainProfile : Profile
    {
        public ViewModelToDomainProfile()
        {
            CreateMap<CreateCategoryViewModel, CreateCategoryCommand>()
                .ConstructUsing(x => new CreateCategoryCommand(x.Name, x.Description));
        }
    }
}
