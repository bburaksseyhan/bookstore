using BookStore.Application.Interfaces;
using BookStore.Application.ViewModel;
using BookStore.Domain.Interfaces;

namespace BookStore.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public GetUserViewModel GetUser(string emailAddress)
        {
            return new GetUserViewModel()
            {
                User = _userRepository.FindUser(emailAddress)
            };
        }

        public GetUserViewModel GetUser(string emailAddress, string password)
        {
            return new GetUserViewModel()
            {
                User = _userRepository.FindUser(emailAddress, password)
            };
        }

    }
}
