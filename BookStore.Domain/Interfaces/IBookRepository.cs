using BookStore.Domain.Models;
using System.Collections.Generic;

namespace BookStore.Domain.Interfaces
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetBooks();

        void Add(Book book);
    }
}
