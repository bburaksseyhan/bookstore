using BookStore.Application.Interfaces;
using BookStore.Application.ViewModel;
using BookStore.Core.Bus;
using BookStore.Domain.Commands;
using BookStore.Domain.Interfaces;
namespace BookStore.Application.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        private readonly IMediatorHandler _bus;

        public BookService(IBookRepository bookRepository, IMediatorHandler bus)
        {
            _bookRepository = bookRepository;
            _bus = bus;
        }

        public void Create(BookViewModel bookViewModel)
        {
            var createBookCommand = new CreateBookCommand(
                  categoryId: bookViewModel.CategoryId,
                  isbn: bookViewModel.ISBN,
                  name: bookViewModel.Name,
                  language: bookViewModel.Language,
                  author: bookViewModel.Author,
                  publisher: bookViewModel.Publisher,
                  description: bookViewModel.Description,
                  imageUrl: bookViewModel.ImageUrl
                );

            _bus.SendCommand(createBookCommand);
        }

        public BookViewModel GetBooks()
        {
            return new BookViewModel()
            {
                Books = _bookRepository.GetBooks()
            };
        }
    }
}
