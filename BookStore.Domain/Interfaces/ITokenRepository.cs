using System;

namespace BookStore.Domain.Interfaces
{
    public interface ITokenRepository
    {
        bool UpdateUserToken(int id, string token, DateTime expiredDate);
    }
}
