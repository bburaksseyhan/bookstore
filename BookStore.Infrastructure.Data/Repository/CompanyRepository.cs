using BookStore.Domain.Interfaces;
using BookStore.Domain.Models;
using BookStore.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace BookStore.Infrastructure.Data.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly BookStoreDBContext _context;
        public CompanyRepository(BookStoreDBContext context)
        {
            _context = context;
        }

        public void Add(Company item)
        {
            try
            {
                _context.Companies.Add(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

            }
        }

        public Company Detail(Guid id)
        {
            return _context.Companies.FirstOrDefault(x => x.Id == id);
        }

        public bool Edit(Guid id, Company item)
        {
            var company = Detail(id);

            if (company != null)
            {
                company.IsActive = item.IsActive;
                _context.Entry(company).State = EntityState.Modified;
                return _context.SaveChanges() > 0;
            }

            return false;
        }

        public IQueryable<Company> GetAll()
        {
            return _context.Companies;
        }

        public bool Remove(Guid id)
        {
            var company = Detail(id);

            if (company != null)
            {
                company.IsActive = false;

                _context.Entry(company).State = EntityState.Modified;
                return _context.SaveChanges() > 0;
            }

            return false;
        }
    }
}
