using BookStore.Domain.Models;
using Microsoft.EntityFrameworkCore;
namespace BookStore.Infrastructure.Data.Context
{
    public class BookStoreDBContext : DbContext
    {
        public BookStoreDBContext(DbContextOptions options) :
            base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Book> Books { get; set; }
    }
}
