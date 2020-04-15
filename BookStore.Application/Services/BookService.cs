using AutoMapper;
using AutoMapper.QueryableExtensions;
using BookStore.Application.Interfaces;
using BookStore.Application.ViewModel;
using BookStore.Core.Bus;
using BookStore.Domain.BookCommands.Commands;
using BookStore.Domain.Interfaces;
using System.Collections.Generic;

namespace BookStore.Application.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _autoMapper;

        public BookService(IBookRepository bookRepository, 
                           IMediatorHandler bus,
                           IMapper autoMapper)
        {
            _bookRepository = bookRepository;
            _bus = bus;
            _autoMapper = autoMapper;
        }

        public void Create(CreateBookViewModel bookViewModel)
        {
            #region if you do not use automapper
            //var createBookCommand = new CreateBookCommand(
            //      categoryId: bookViewModel.CategoryId,
            //      isbn: bookViewModel.ISBN,
            //      name: bookViewModel.Name,
            //      language: bookViewModel.Language,
            //      author: bookViewModel.Author,
            //      publisher: bookViewModel.Publisher,
            //      description: bookViewModel.Description,
            //      imageUrl: bookViewModel.ImageUrl
            //    );
            #endregion

            _bus.SendCommand(_autoMapper.Map<CreateBookCommand>(bookViewModel));
        }

        public BaseDeleteViewModel DeleteCategory(int id)
        {
            return new BaseDeleteViewModel()
            {
                 IsDeleted = _bookRepository.DeleteBook(id)
            };
        }

        public IEnumerable<GetBooksViewModel> GetBooks()
        {
            return _bookRepository.GetBooks().ProjectTo<GetBooksViewModel>(_autoMapper.ConfigurationProvider);
        }

        public BookDetailsViewModel GetCategory(int id)
        {
            return new BookDetailsViewModel()
            {
                Book = _bookRepository.GetBook(id)
            };
        }
    }
}
