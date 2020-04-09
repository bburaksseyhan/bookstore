using BookStore.Domain.Models;
using System.Collections.Generic;

namespace BookStore.Application.ViewModel
{
    public class BookViewModel
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public string ISBN { get; set; }

        public string Name { get; set; }

        public string Language { get; set; }

        public string Author { get; set; }

        public string Publisher { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public IEnumerable<Book> Books { get; set; }
    }
}
