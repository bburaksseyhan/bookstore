using BookStore.Application.Interfaces;
using BookStore.Application.Services;
using BookStore.Domain.Interfaces;
using BookStore.Infrastructure.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace BookStore.Infrastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application Layer
            services.AddScoped<ICategoryService, CategoryService>();

            //Data Layer
            services.AddScoped<ICategoryRepository, CategoryRepository>();
        }
    }
}
