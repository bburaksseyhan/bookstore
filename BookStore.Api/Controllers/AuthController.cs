using BookStore.Application.Interfaces;
using BookStore.Application.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BookStore.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly ITokenService _tokenService;
        private readonly IUserService _userService;

        public AuthController(IAuthService authService,
                              ITokenService tokenService,
                              IUserService userService)
        {
            _authService = authService;
            _tokenService = tokenService;
            _userService = userService;
        }

        [HttpPost]
        [Route("signup")]
        public IActionResult SignUp(SignUpViewModel signUpViewModel)
        {
            var getUser = _userService.GetUser(signUpViewModel.Email);

            if (getUser.User != null)
            {
                return Ok(new { Message = "User already signup" });
            }

            _authService.SignUp(signUpViewModel);

            return Ok(new { Message = "OK" });
        }

        [HttpPost]
        [Route("signin")]
        public IActionResult SignIn(string email, string password)
        {
            var user = _userService.GetUser(email, password);

            if (user.User == null)
            {
                return Unauthorized();
            }

            if (user != null && user.User.ExpiredDate > DateTime.Now)
            {
                var validate = _tokenService.ValidateToken(user.User.Token);

                if (validate)
                {
                    _tokenService.UpdateUserTokens(new UpdateUserViewModel()
                    {
                        Id = user.User.Id,
                        RefreshToken = _tokenService.CreateRefreshToken(),
                        Token = _tokenService.GetToken(user.User.Email)["Token"].ToString()
                    });
                }
                else
                {
                    return Unauthorized();
                }
            }

            var result = _authService.SignIn(email, password);

            return Ok(result);
        }


        [HttpPost]
        public IActionResult RefreshToken([FromBody]string refreshToken)
        {
            var result = _tokenService.GetRefreshToken(refreshToken);

            if (string.IsNullOrEmpty(result))
            {
                return NotFound("Refresh Token Not Found");
            }

            //todo: refresh claims and refresh user tokens
            _tokenService.
            return null;
        }
    }
}