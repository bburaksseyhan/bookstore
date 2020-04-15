using BookStore.Domain.Interfaces;
using BookStore.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
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

        public bool UpdateUserToken(int id, string token, DateTime expiredDate)
        {
            if (id > 0 && string.IsNullOrEmpty(token))
                return false;

            var getUser = _context.Users.SingleOrDefault(x => x.Id == id);

            if (getUser == null)
                return false;

            getUser.Token = token;
            getUser.ExpiredDate = expiredDate;
            
            _context.Entry(getUser).State = EntityState.Modified;

            return _context.SaveChanges() > 0;
        }
    }
}
