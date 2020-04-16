using BookStore.Application.Interfaces;
using BookStore.Application.Request.SigninRequest;
using BookStore.Application.Request.SignupRequest;
using BookStore.Application.Request.UserRequest;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace BookStore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly ITokenService _tokenService;
        private readonly IUserService _userService;

        public AuthenticationController(IAuthService authService,
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
            if (!ModelState.IsValid)
            {
                return BadRequest(signUpViewModel);
            }

            var getUser = _userService.GetUser(signUpViewModel.Email);

            if (getUser.User != null)
            {
                return StatusCode(409);//already signup
            }

            _authService.SignUp(signUpViewModel); //create user

            return Ok(new { Message = "OK" });
        }

        [HttpPost]
        [Route("signin")]
        public IActionResult SignIn([FromBody] SignInViewModel signInViewModel)
        {
            var tokenDictionary = new Dictionary<string, object>();

            var user = _userService.GetUser(signInViewModel.EmailAddress, signInViewModel.Password);

            if (user.User == null)
            {
                return Unauthorized();
            }

            if (user != null && user.User.IsActive)
            {
                //todo: şifre kontrolü yapılacak
                tokenDictionary = _tokenService.GetAccessToken(user.User.Email);

                _tokenService.UpdateUserTokens(new UpdateUserViewModel()
                {
                    Id = user.User.Id,
                    Token = tokenDictionary["Token"].ToString(),
                    ExpiredDate = Convert.ToDateTime(tokenDictionary["Expiration"])
                });
            }
            else
            {
                return Unauthorized();
            }

            return Ok(tokenDictionary);
        }
    }
}