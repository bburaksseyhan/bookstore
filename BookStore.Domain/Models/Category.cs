using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Domain.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
