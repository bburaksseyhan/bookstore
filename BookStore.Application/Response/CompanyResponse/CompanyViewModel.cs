using System;

namespace BookStore.Application.Request.CompanyResponse
{
    public class CompanyViewModel
    {
        public Guid Id { get; set; }

        public int UserId { get; set; }

        public string Name { get; set; }

        public string CentralRegisrationSystemNo { get; set; }

        public string EmailAddress { get; set; }

        public string ImageUrl { get; set; }

        public string Description { get; set; }
    }
}
