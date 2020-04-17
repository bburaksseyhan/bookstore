using BookStore.Application.Request.CompanyRequest;
using BookStore.Application.Request.CompanyResponse;
using System;

namespace BookStore.Application.Interfaces
{
    public interface ICompanyService : IBaseService<CreateCompanyViewModel, CompanyViewModel, Guid>
    {
    }
}
