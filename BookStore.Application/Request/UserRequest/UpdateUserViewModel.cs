using System;

namespace BookStore.Application.Request.UserRequest
{
    public class UpdateUserViewModel
    {
        public int Id { get; set; }

        public string Token { get; set; }

        public DateTime ExpiredDate { get; set; }
    }
}
