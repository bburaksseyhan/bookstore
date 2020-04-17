using BookStore.Domain.BookCommands.Commands;
using BookStore.Domain.Interfaces;
using BookStore.Domain.Models;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BookStore.Domain.CommandHandlers
{
    public class BookCommandHandler : IRequestHandler<CreateBookCommand, bool>
    {
        private readonly IBookRepository _bookRepository;

        public BookCommandHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public Task<bool> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            var book = new Book()
            {
                CategoryId = request.CategoryId,
                Name = request.Name,
                Author = request.Author,
                Description = request.Description,
                ISBN = request.ISBN,
                ImageUrl = request.ImageUrl,
                Language = request.Language,
                Publisher = request.Publisher,
                Price = request.Price
            };

            _bookRepository.Add(book);

            return Task.FromResult(true);
        }
    }
}
