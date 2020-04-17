using BookStore.Core.Commands;
using System;

namespace BookStore.Domain.Commands.CompanyCommands
{
    public class CompanyCommand : Command
    {
        public Guid Id { get; protected set; }

        public int UserId { get; protected set; }

        public string Name { get; protected set; }

        public string CentralRegisrationSystemNo { get; protected set; }

        public string EmailAddress { get; protected set; }

        public string ImageUrl { get; protected set; }

        public bool IsActive { get; protected set; }

        public string Description { get; protected set; }
    }
}
