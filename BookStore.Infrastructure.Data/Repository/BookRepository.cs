using BookStore.Domain.Interfaces;
using BookStore.Domain.Models;
using BookStore.Infrastructure.Data.Context;
using System.Collections.Generic;

namespace BookStore.Infrastructure.Data.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly BookStoreDBContext _context;
        public BookRepository(BookStoreDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Book> GetBooks()
        {
            return _context.Books;
        }
    }
}
