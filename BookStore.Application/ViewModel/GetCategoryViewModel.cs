using BookStore.Domain.Models;
using System.Collections.Generic;

namespace BookStore.Application.ViewModel
{
    public class GetCategoryViewModel
    {
        //public IEnumerable<Category> Categories { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
