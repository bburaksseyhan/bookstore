namespace BookStore.Domain.Models
{
    public class Discount : BaseModel
    {
        public int Id { get; set; }

        public int BookId { get; set; }

        public decimal Price { get; set; }

        public decimal? NewPrice { get; set; }
    }
}
