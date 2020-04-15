using BookStore.Application.Interfaces;
using BookStore.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BookStore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthTokenController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly IUserService _userService;
        private readonly ITokenService _tokenService;


        public AuthTokenController(IAuthService authService,
                                   IUserService userService,
                                   ITokenService tokenService)
        {
            _authService = authService;
            _userService = userService;
            _tokenService = tokenService;
        }

        [HttpPost]
        [Route("token")]
        public IActionResult GetToken([FromBody]AuthViewModel authViewModel)
        {
            var token = new Dictionary<string, object>();

            if (ModelState.IsValid)
            {
                var result = _userService.GetUser(authViewModel.EmailAddress);

                if (result == null)
                {
                    token = _tokenService.GetToken(authViewModel.EmailAddress);

                    if (string.IsNullOrEmpty(token["Token"].ToString()))
                    {
                        return Unauthorized();
                    }
                }
            }

            return Ok(token);
        }
    }
}