using BookStore.Domain.Models;
using System.Collections.Generic;

namespace BookStore.Application.ViewModel
{
    public class CategoryViewModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public IEnumerable<Category> Categories { get; set; }
    }
}
