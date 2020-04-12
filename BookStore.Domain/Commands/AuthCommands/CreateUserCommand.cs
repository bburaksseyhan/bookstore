using BookStore.Domain.Models;
using System;

namespace BookStore.Domain.Commands.AuthCommands
{
    public class CreateUserCommand : SignUpCommand
    {
        public CreateUserCommand(int id, string firstName, string lastName, string email, string password, string rePassword, string token, int expiredDate, bool isActive, DateTime createdDate, DateTime? deletedDate, DateTime? updateDate)
        {
            Id = Id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            RePassword = rePassword;
            Token = token;
            ExpiredDate = expiredDate;
            IsActive = isActive;
            CreatedDate = createdDate;
            DeletedDate = deletedDate;
            UpdateDate = updateDate;
        }
    }
}
