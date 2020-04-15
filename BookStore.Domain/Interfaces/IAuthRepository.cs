using BookStore.Domain.Models;

namespace BookStore.Domain.Interfaces
{
    public interface IAuthRepository
    {
        bool SignIn(string emailAddress, string password);

        bool SignUp(User user);
    }
}
