using BookStore.Application.Response.BookResponse;

namespace BookStore.Application.Interfaces
{
    public interface IBookService : IBaseService<BooksViewModel, int>
    {
    }
}
