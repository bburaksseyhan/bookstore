using BookStore.Domain.Interfaces;
using BookStore.Domain.Models;
using BookStore.Infrastructure.Data.Context;
using System.Linq;

namespace BookStore.Infrastructure.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly BookStoreDBContext _context;

        public UserRepository(BookStoreDBContext context)
        {
            _context = context;
        }

        public User FindUser(string emailAddress, string password)
        {
            return _context.Users
                           .Where(e => e.Email == emailAddress && e.Password == password)
                           .FirstOrDefault();
        }

        public User FindUser(string emailAddress)
        {
            return _context.Users
                           .Where(e => e.Email == emailAddress)
                           .FirstOrDefault();
        }

        public User FindUser(int id)
        {
            return _context.Users
                      .Where(e => e.Id == id)
                      .FirstOrDefault();
        }
    }
}
