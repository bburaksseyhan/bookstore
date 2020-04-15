using System;

namespace BookStore.Domain.Commands.AuthCommands
{
    public class CreateUserCommand : SignUpCommand
    {
        public CreateUserCommand(int id, string firstName, string lastName, string email, string password, string rePassword, string token, DateTime expiredDate, string refreshToken, bool isActive, DateTime createdDate, DateTime? deletedDate, DateTime? updateDate)
        {
            Id = Id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            RePassword = rePassword;
            Token = token;
            ExpiredDate = expiredDate;
            RefreshToken = refreshToken;
            IsActive = isActive;
            CreatedDate = createdDate;
            DeletedDate = deletedDate;
            UpdateDate = updateDate;
        }
    }
}
