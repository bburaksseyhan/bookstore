using BookStore.Application.ViewModel;

namespace BookStore.Application.Interfaces
{
    public interface IUserService
    {
        GetUserViewModel GetUser(string emailAddress);

        GetUserViewModel GetUser(string emailAddress, string password);
    }
}
