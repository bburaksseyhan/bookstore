namespace BookStore.Domain.Models
{
    public class Book : BaseModel
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public int CompanyId { get; set; }

        public string ISBN { get; set; }

        public string Name { get; set; }

        public string Language { get; set; }

        public string Author { get; set; }

        public string Publisher { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }
    }
}
