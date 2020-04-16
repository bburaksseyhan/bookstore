using BookStore.Application.Request.UserRequest;
using System.Collections.Generic;

namespace BookStore.Application.Interfaces
{
    public interface ITokenService
    {
        string CreateRefreshToken();

        Dictionary<string, object> GetAccessToken(string emailAddress);
       
        bool ValidateToken(string token);

        bool UpdateUserTokens(UpdateUserViewModel updateUserViewModel);
    }
}
