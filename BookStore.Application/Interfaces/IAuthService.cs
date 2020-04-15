using BookStore.Application.ViewModel;

namespace BookStore.Application.Interfaces
{
    public interface IAuthService
    {
        void SignUp(SignUpViewModel signUpViewModel);

        string Encrypt(string plainText, string password);

        string Descrypt(string encryptedText, string password);
    }
}
