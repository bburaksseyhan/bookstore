using BookStore.Application.Request.UserRequest;

namespace BookStore.Application.Interfaces
{
    public interface IUserService
    {
        GetUserViewModel GetUser(string emailAddress);

        GetUserViewModel GetUser(string emailAddress, string password);
    }
}
