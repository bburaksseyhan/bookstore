using System;

namespace BookStore.Domain.Commands.AuthCommands
{
    public class CreateUserCommand : SignUpCommand
    {
        public CreateUserCommand(string firstName, string lastName, string email, string password, string rePassword)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            RePassword = rePassword;
            CreatedDate = DateTime.Now;
        }
    }
}
