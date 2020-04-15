using BookStore.Domain.Interfaces;
using BookStore.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BookStore.Infrastructure.Data.Repository
{
    public class TokenRepository : ITokenRepository
    {
        private readonly BookStoreDBContext _context;
        public TokenRepository(BookStoreDBContext context)
        {
            _context = context;
        }

        public string GetRefreshToken(string refreshToken)
        {
            return _context.Users.FirstOrDefault(x => x.RefreshToken == refreshToken).RefreshToken;
        }

        public bool UpdateUserToken(int id, string refreshToken, string token)
        {
            if (id > 0 && string.IsNullOrEmpty(refreshToken) && string.IsNullOrEmpty(token))
                return false;

            var getUser = _context.Users.SingleOrDefault(x => x.Id == id);

            if (getUser == null)
                return false;

            getUser.RefreshToken = refreshToken;
            getUser.Token = token;

            _context.Entry(getUser).State = EntityState.Modified;

            return _context.SaveChanges() > 0;
        }
    }
}
