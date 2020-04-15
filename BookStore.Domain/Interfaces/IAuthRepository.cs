using BookStore.Domain.Models;

namespace BookStore.Domain.Interfaces
{
    public interface IAuthRepository
    {
        bool SignUp(User user);
    }
}
