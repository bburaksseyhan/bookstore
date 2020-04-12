using BookStore.Domain.Models;

namespace BookStore.Domain.Interfaces
{
    public interface IAuthRepository
    {
        bool SignIn(string emailAddress, string password);

        bool SignUp(User user);

        User FindUser(string emailAddress, string password);

        User FindUser(string emailAddress);
    }
}
