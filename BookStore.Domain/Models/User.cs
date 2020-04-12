
using System;

namespace BookStore.Domain.Models
{
    public class User
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string RePassword { get; set; }

        public string Token { get; set; }

        public int ExpiredDate { get; set; }

        public bool IsActive { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? DeletedDate { get; set; }

        public DateTime? UpdateDate { get; set; }
    }
}
