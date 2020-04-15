using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Domain.Models
{
   public  class User
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string RePassword { get; set; }

        public string Token { get; set; }

        public DateTime ExpiredDate { get; set; }

        public string RefreshToken { get; set; }

        public bool IsActive { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? DeletedDate { get; set; }

        public DateTime? UpdateDate { get; set; }
    }
}
