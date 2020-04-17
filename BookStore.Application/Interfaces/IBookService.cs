using BookStore.Application.Requet.BookRequest;
using BookStore.Application.Response.BookResponse;

namespace BookStore.Application.Interfaces
{
    public interface IBookService : IBaseService<CreateBookViewModel, GetBooksViewModel, int>
    {
    }
}
