using AutoMapper;

using BookStore.Application.Interfaces;
using BookStore.Application.Request.SignupRequest;
using BookStore.Core.Bus;
using BookStore.Domain.Commands.AuthCommands;
using BookStore.Domain.Interfaces;

namespace BookStore.Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _authRepository;
        private IMapper _autoMapper;
        private IMediatorHandler _bus;

        public AuthService(IAuthRepository authRepository,
                           IMapper autoMapper,
                           IMediatorHandler bus)
        {
            _authRepository = authRepository;
            _autoMapper = autoMapper;
            _bus = bus;
        }

        public string Descrypt(string encryptedText, string password)
        {
            return null;
        }

        public string Encrypt(string plainText, string password)
        {
            return null;
        }

        public void SignUp(SignUpViewModel signUpViewModel)
        {
            _bus.SendCommand(_autoMapper.Map<CreateUserCommand>(signUpViewModel));
        }
    }
}
