using BookStore.Application.Response.BookViewModel;

namespace BookStore.Application.Interfaces
{
    public interface IBookService : IBaseService<BooksViewModel, int>
    {
    }
}
