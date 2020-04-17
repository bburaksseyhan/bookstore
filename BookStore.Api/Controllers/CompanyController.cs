using BookStore.Api.Configurations;
using BookStore.Application.Interfaces;
using BookStore.Application.Request.CompanyRequest;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BookStore.Api.Controllers
{
    [Authorize]
    [ApiController]
    [Route(RouteConfig.Base)]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _companyService;

        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpGet]
        [Route(RouteConfig.Company.GetAll)]
        public IActionResult Get()
        {
            return Ok(_companyService.GetAll());
        }

        [HttpGet]
        [Route(RouteConfig.Company.Detail)]
        public IActionResult GetCategory([FromHeader]string companyId)
        {
            var result = _companyService.Detail(Guid.Parse(companyId));

            return Ok(result);
        }

        [HttpPost]
        [Route(RouteConfig.Company.Create)]
        public IActionResult Post([FromBody] CreateCompanyViewModel companyViewModel)
        {
            _companyService.Add(companyViewModel);

            return Ok(companyViewModel);
        }

        [HttpPost]
        [Route(RouteConfig.Company.Delete)]
        public IActionResult Delete([FromHeader]string companyId)
        {
            var result = _companyService.Remove(Guid.Parse(companyId));

            return Ok(result);
        }
    }
}