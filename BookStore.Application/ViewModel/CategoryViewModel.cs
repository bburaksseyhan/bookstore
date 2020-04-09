using BookStore.Domain.Models;
using System.Collections.Generic;

namespace BookStore.Application.ViewModel
{
    public class CategoryViewModel
    {
        public IEnumerable<Category> Categories { get; set; }
    }
}
