using BookStore.Core.Commands;
using System;

namespace BookStore.Domain.Commands.AuthCommands
{
    public class SignUpCommand : Command
    {
        public int Id { get; protected set; }

        public string FirstName { get; protected set; }

        public string LastName { get; protected set; }

        public string Email { get; protected set; }

        public string Password { get; protected set; }

        public string RePassword { get; protected set; }

        public string Token { get; protected set; }

        public DateTime ExpiredDate { get; protected set; }

        public bool IsActive { get; protected set; }

        public DateTime? CreatedDate { get; protected set; }

        public DateTime? DeletedDate { get; protected set; }

        public DateTime? UpdateDate { get; protected set; }
    }
}
