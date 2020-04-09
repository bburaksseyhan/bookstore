using BookStore.Application.ViewModel;

namespace BookStore.Application.Interfaces
{
    public interface IBookService
    {
        BookViewModel GetBooks();
    }
}
