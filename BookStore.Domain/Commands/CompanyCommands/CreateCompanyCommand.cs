using System;

namespace BookStore.Domain.Commands.CompanyCommands
{
    public class CreateCompanyCommand : CompanyCommand
    {
        public CreateCompanyCommand(int userId,
                                    string name, string centralRegisrationSystemNo,
                                    string emailAddress, string imageUrl,
                                    string description, bool isActive)
        {
            Id = Guid.NewGuid();
            UserId = userId;
            Name = name;
            CentralRegisrationSystemNo = centralRegisrationSystemNo;
            EmailAddress = emailAddress;
            ImageUrl = imageUrl;
            Description = description;
            IsActive = isActive;
        }
    }
}
