using BookStore.Application.Interfaces;
using BookStore.Application.Services;
using BookStore.Core.Bus;
using BookStore.Domain.CategoryCommands.Commands;
using BookStore.Domain.CommandHandlers;
using BookStore.Domain.Commands.AuthCommands;
using BookStore.Domain.Interfaces;
using BookStore.Infrastructure.Bus;
using BookStore.Infrastructure.Data.Context;
using BookStore.Infrastructure.Data.Repository;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace BookStore.Infrastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain InMemoryBus MediatR
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            //Domain Handlers
            services.AddScoped<IRequestHandler<CreateCategoryCommand, bool>, CategoryCommandHandler>();
            services.AddScoped<IRequestHandler<CreateUserCommand, bool>, SignupCommandHandler>();

            //Application Layer
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IBookService, BookService>();
            services.AddScoped<IAuthService, AuthService>();

            //Data Layer
            services.AddScoped<IAuthRepository, AuthRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<BookStoreDBContext>();
        }
    }
}
