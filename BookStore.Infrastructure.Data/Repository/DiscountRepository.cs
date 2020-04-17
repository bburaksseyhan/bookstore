using BookStore.Domain.Interfaces;
using BookStore.Domain.Models;
using BookStore.Infrastructure.Data.Context;
using System;
using System.Linq;

namespace BookStore.Infrastructure.Data.Repository
{
    public class DiscountRepository : IDiscountRepository
    {
        private readonly BookStoreDBContext _context;

        public DiscountRepository(BookStoreDBContext context)
        {
            _context = context;
        }

        public void Add(Discount item)
        {
            _context.Discounts.Add(item);
            _context.SaveChanges();
        }

        public Discount Detail(int id)
        {
            return _context.Discounts.FirstOrDefault(x => x.Id == id);
        }

        public bool Edit(int id, Discount item)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Discount> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
