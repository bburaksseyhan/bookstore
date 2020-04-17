using System;

namespace BookStore.Domain.Models
{
   public  class User : BaseModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string RePassword { get; set; }

        public string Token { get; set; }

        public DateTime ExpiredDate { get; set; }
    }
}
