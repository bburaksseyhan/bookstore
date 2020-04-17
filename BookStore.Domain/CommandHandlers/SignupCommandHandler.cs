using BookStore.Domain.Commands.AuthCommands;
using BookStore.Domain.Interfaces;
using BookStore.Domain.Models;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BookStore.Domain.CommandHandlers
{
    public class SignupCommandHandler : IRequestHandler<CreateUserCommand, bool>
    {
        private readonly IAuthRepository _authRepository;

        public SignupCommandHandler(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }

        public Task<bool> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = new User()
            {
                Id = request.Id,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                Password = request.Password,
                RePassword = request.RePassword,
                Token = request.Token,
                ExpiredDate = request.ExpiredDate,
                IsActive = request.IsActive,
                CreatedDate = request.CreatedDate,
                DeletedDate = request.DeletedDate,
                UpdatedDate = request.UpdateDate
            };

            _authRepository.SignUp(user);

            return Task.FromResult(true);
        }
    }
}
