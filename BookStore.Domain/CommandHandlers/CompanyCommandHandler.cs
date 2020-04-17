using BookStore.Domain.Commands.CompanyCommands;
using BookStore.Domain.Interfaces;
using BookStore.Domain.Models;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BookStore.Domain.CommandHandlers
{
    public class CompanyCommandHandler : IRequestHandler<CreateCompanyCommand, bool>
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyCommandHandler(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public Task<bool> Handle(CreateCompanyCommand request, CancellationToken cancellationToken)
        {
            var company = new Company()
            {
                Id = Guid.NewGuid(),
                CentralRegisrationSystemNo = request.CentralRegisrationSystemNo,
                Name = request.Name,
                UserId = request.UserId,
                Description = request.Description,
                EmailAddress = request.EmailAddress,
                CreatedDate = DateTime.Now,
                ImageUrl = request.ImageUrl,
                IsActive = request.IsActive
            };

            _companyRepository.Add(company);

            return Task.FromResult(true);
        }
    }
}
