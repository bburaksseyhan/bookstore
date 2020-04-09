using BookStore.Domain.Commands;
using BookStore.Domain.Interfaces;
using BookStore.Domain.Models;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BookStore.Domain.CommandHandlers
{
    public class CategoryCommandHandler : IRequestHandler<CreateCategoryCommand, bool>
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryCommandHandler(ICategoryRepository bookRepository)
        {
            _categoryRepository = bookRepository;
        }

        public Task<bool> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = new Category()
            {
                Name = "Technology",
                Description = string.Empty
            };

            _categoryRepository.Add(category);

            return Task.FromResult(true);
        }
    }
}
