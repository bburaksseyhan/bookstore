using BookStore.Domain.Models;
using System.Collections.Generic;

namespace BookStore.Application.ViewModel
{
    public class BookViewModel
    {
        public IEnumerable<Book> Books { get; set; }
    }
}
