using BookStore.Domain.Models;

namespace BookStore.Domain.Interfaces
{
    public interface IUserRepository
    {
        User FindUser(string emailAddress, string password);

        User FindUser(string emailAddress);

        User FindUser(int id);
    }
}
