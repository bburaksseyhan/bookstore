using BookStore.Application.Interfaces;
using BookStore.Application.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        [Route("signup")]
        public IActionResult SignUp(SignUpViewModel signUpViewModel)
        {
            var getUser = _authService.GetUser(signUpViewModel.Email);

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
            var getUser = _authService.GetUser(email);

            if (getUser == null)
            {
                return Ok(new { Message = "Use not found" });
            }

            var result = _authService.SignIn(email, password);

            return Ok(result);
        }
    }
}