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

        public Book Detail(int id)
        {
            return _context.Books.Where(x => x.Id == id).FirstOrDefault();
        }

        public bool Edit(int id, Book item)
        {
            throw new System.NotImplementedException();
        }

        public IQueryable<Book> GetAll()
        {
            return _context.Books;
        }

        public bool Remove(int id)
        {
            var book = Detail(id);

            if (book == null)
            {
                return false;
            }

            _context.Books.Remove(book);
            return _context.SaveChanges() > 0;
        }
    }
}
