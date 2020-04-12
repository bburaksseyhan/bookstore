using BookStore.Domain.Interfaces;
using BookStore.Domain.Models;
using BookStore.Infrastructure.Data.Context;
using System.Linq;

namespace BookStore.Infrastructure.Data.Repository
{
    public class AuthRepository : IAuthRepository
    {
        private readonly BookStoreDBContext _context;

        public AuthRepository(BookStoreDBContext context)
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

        public bool SignIn(string emailAddress, string password)
        {
            var getOne = FindUser(emailAddress, password);

            if (getOne == null)
                return false;

            var registeredUser = _context.Users
                                         .Where(x => x.Email == emailAddress && x.Password == password)
                                         .FirstOrDefault();

            if (registeredUser == null)
                return false;

            return true;
        }

        public bool SignUp(User user)
        {
            if (user == null)
            {
                return false;
            }

            var getOne = FindUser(user.Email, user.Password);

            if (getOne == null)
            {
                _context.Users.Add(user);

                _context.SaveChanges();

                return true;
            }

            return false;
        }
    }
}
