using BookStore.Api.Helper;
using BookStore.Application.Interfaces;
using BookStore.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace BookStore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthTokenController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IAuthService _authService;


        public AuthTokenController(IConfiguration configuration, IAuthService authService)
        {
            _configuration = configuration;
            _authService = authService;
        }

        [HttpPost]
        [Route("token")]
        public IActionResult GetToken([FromBody]AuthViewModel authViewModel)
        {
            var result = _authService.GetUser(authViewModel.EmailAddress);

            JwtHelper jwtHelper = new JwtHelper(_configuration);

            var token = jwtHelper.GetToken(authViewModel.EmailAddress);

            if (string.IsNullOrEmpty(token))
            {
                return Unauthorized();
            }

            return Ok(token);
        }
    }
}