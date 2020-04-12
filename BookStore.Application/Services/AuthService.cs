using AutoMapper;

using BookStore.Application.Interfaces;
using BookStore.Application.ViewModel;
using BookStore.Core.Bus;
using BookStore.Domain.Commands.AuthCommands;
using BookStore.Domain.Interfaces;
using BookStore.Domain.Models;

namespace BookStore.Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _authRepository;
        private IMapper _autoMapper;
        private IMediatorHandler _bus;

        public AuthService(IAuthRepository authRepository, IMapper autoMapper,IMediatorHandler bus)
        {
            _authRepository = authRepository;
            _autoMapper = autoMapper;
            _bus = bus;
        }

        public GetUserViewModel GetUser(string emailAddress)
        {
            return new GetUserViewModel()
            {
                User = _authRepository.FindUser(emailAddress)
            };
        }

        public SignInViewModel SignIn(string emailAddress, string password)
        {
            return new SignInViewModel
            {
                IsSuccess = _authRepository.SignIn(emailAddress, password)
            };
        }

        public void SignUp(SignUpViewModel signUpViewModel)
        {
            _bus.SendCommand(_autoMapper.Map<CreateUserCommand>(signUpViewModel));
        }
    }
}
