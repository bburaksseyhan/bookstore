using AutoMapper;
using AutoMapper.QueryableExtensions;
using BookStore.Application.Interfaces;
using BookStore.Application.Requet.BookRequest;
using BookStore.Application.Response;
using BookStore.Application.Response.BookResponse;
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

        public void Add(CreateBookViewModel categoryViewModel)
        {
            var createBookCommand = new CreateBookCommand(
                  categoryId: categoryViewModel.CategoryId,
                  isbn: categoryViewModel.ISBN,
                  name: categoryViewModel.Name,
                  language: categoryViewModel.Language,
                  author: categoryViewModel.Author,
                  publisher: categoryViewModel.Publisher,
                  description: categoryViewModel.Description,
                  imageUrl: categoryViewModel.ImageUrl,
                  price: categoryViewModel.Price
                );

            _bus.SendCommand(createBookCommand);

            //_bus.SendCommand(_autoMapper.Map<CreateBookCommand>(categoryViewModel));
        }

        public BaseResponse<GetBooksViewModel> Detail(int id)
        {
            var detail = _bookRepository.Detail(id);

            return new BaseResponse<GetBooksViewModel>()
            {
                Data = _autoMapper.Map<GetBooksViewModel>(detail)
            };
        }

        public IEnumerable<GetBooksViewModel> GetAll()
        {
            return _bookRepository.GetAll().ProjectTo<GetBooksViewModel>(_autoMapper.ConfigurationProvider);
        }

        public BaseResponse<bool> Remove(int id)
        {
            return new BaseResponse<bool>()
            {
                IsSuccess = _bookRepository.Remove(id)
            };
        }
    }
}
