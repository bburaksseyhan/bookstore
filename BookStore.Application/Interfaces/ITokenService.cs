using BookStore.Application.ViewModel;
using System.Collections.Generic;

namespace BookStore.Application.Interfaces
{
    public interface ITokenService
    {
        string CreateRefreshToken();

        Dictionary<string, object> GetToken(string emailAddress);

        bool ValidateToken(string token);

        string GetRefreshToken(string refreshToken);

        bool UpdateUserTokens(UpdateUserViewModel updateUserViewModel);
    }
}
