using BookStore.Domain.Interfaces;
using BookStore.Domain.Models;
using BookStore.Infrastructure.Data.Context;
using System.Linq;

namespace BookStore.Infrastructure.Data.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly BookStoreDBContext _context;
        public BookRepository(BookStoreDBContext context)
        {
            _context = context;
        }

        public void Add(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public bool DeleteBook(int id)
        {
            bool result = false;

            var book = GetBook(id);

            if (book == null)
            {
                return result = false;
            }

            _context.Books.Remove(book);
            result = _context.SaveChanges() > 0;

            return result;
        }

        public Book GetBook(int id)
        {
            return _context.Books.Where(x => x.Id == id).FirstOrDefault();
        }

        public IQueryable<Book> GetBooks()
        {
            return _context.Books;
        }
    }
}
