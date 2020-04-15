using BookStore.Application.ViewModel;

namespace BookStore.Application.Interfaces
{
    public interface IAuthService
    {
        SignInViewModel SignIn(string emailAddress, string password);

        void SignUp(SignUpViewModel signUpViewModel);
    }
}
