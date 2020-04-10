using BookStore.Domain.Models;
using System.Linq;

namespace BookStore.Domain.Interfaces
{
    public interface IBookRepository
    {
        IQueryable<Book> GetBooks();

        void Add(Book book);

        Book GetBook(int id);

        bool DeleteBook(int id);
    }
}
