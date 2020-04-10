namespace BookStore.Application.ViewModel
{
    public class CreateBookViewModel
    {
        public int CategoryId { get; set; }

        public string ISBN { get; set; }

        public string Name { get; set; }

        public string Language { get; set; }

        public string Author { get; set; }

        public string Publisher { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }
    }
}
