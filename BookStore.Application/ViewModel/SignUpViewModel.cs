using System;

namespace BookStore.Application.ViewModel
{
    public class SignUpViewModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string RePassword { get; set; }

        public string Token { get; set; }

        public DateTime ExpiredDate { get; set; }

        public string RefresToken { get; set; }

        public bool IsActive { get; set; }

        public string RefreshToken { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? DeletedDate { get; set; }

        public DateTime? UpdateDate { get; set; }
    }
}
