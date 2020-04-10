using BookStore.Application.ViewModel;
using System.Collections.Generic;

namespace BookStore.Application.Interfaces
{
    public interface IBookService
    {
        IEnumerable<GetBooksViewModel> GetBooks();

        void Create(CreateBookViewModel bookViewModel);

        BaseDeleteViewModel DeleteCategory(int id);

        BookDetailsViewModel GetCategory(int id);
    }
}
