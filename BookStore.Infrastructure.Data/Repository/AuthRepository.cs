using BookStore.Domain.Interfaces;
using BookStore.Domain.Models;
using BookStore.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BookStore.Infrastructure.Data.Repository
{
    public class AuthRepository : IAuthRepository
    {
        private readonly BookStoreDBContext _context;
        private readonly IUserRepository _userRepository;

        public AuthRepository(BookStoreDBContext context, IUserRepository userRepository)
        {
            _context = context;
            _userRepository = userRepository;
        }

        public string GetUserToken(string refreshToken)
        {
            return _context.Users.FirstOrDefault(x => x.RefreshToken == refreshToken).RefreshToken;
        }

        public bool SignIn(string emailAddress, string password)
        {
            var getOne = _userRepository.FindUser(emailAddress, password);

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

            var getOne = _userRepository.FindUser(user.Email, user.Password);

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
