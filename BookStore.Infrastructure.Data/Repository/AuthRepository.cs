using BookStore.Domain.Interfaces;
using BookStore.Domain.Models;
using BookStore.Infrastructure.Data.Context;

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
