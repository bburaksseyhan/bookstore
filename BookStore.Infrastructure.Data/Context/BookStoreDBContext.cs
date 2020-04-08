using BookStore.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Infrastructure.Data.Context
{
    public class BookStoreDBContext : DbContext
    {
        public BookStoreDBContext(DbContextOptions options) :
            base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
    }
}
