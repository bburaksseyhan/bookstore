using AutoMapper;
using AutoMapper.QueryableExtensions;
using BookStore.Application.Interfaces;
using BookStore.Application.Request.CompanyRequest;
using BookStore.Application.Request.CompanyResponse;
using BookStore.Application.Response;
using BookStore.Core.Bus;
using BookStore.Domain.Commands.CompanyCommands;
using BookStore.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace BookStore.Application.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _autoMapper;

        public CompanyService(ICompanyRepository companyService,
                              IMediatorHandler bus,
                              IMapper autoMapper)
        {
            _companyRepository = companyService;
            _bus = bus;
            _autoMapper = autoMapper;
        }

        public void Add(CreateCompanyViewModel item)
        {
            _bus.SendCommand(_autoMapper.Map<CreateCompanyCommand>(item));
        }

        public BaseResponse<CompanyViewModel> Detail(Guid id)
        {
            var detail = _companyRepository.Detail(id);

            return new BaseResponse<CompanyViewModel>()
            {
                Data = _autoMapper.Map<CompanyViewModel>(detail)
            };
        }

        public IEnumerable<CompanyViewModel> GetAll()
        {
            return _companyRepository.GetAll().ProjectTo<CompanyViewModel>(_autoMapper.ConfigurationProvider);
        }

        public BaseResponse<bool> Remove(Guid id)
        {
            return new BaseResponse<bool>()
            {
                Data = _companyRepository.Remove(id)
            };
        }
    }
}
