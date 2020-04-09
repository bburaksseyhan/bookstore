using BookStore.Core.Commands;

namespace BookStore.Domain.Commands
{
    public abstract class BookCommand : Command
    {
        public int Id { get; protected set; }

        public int CategoryId { get; protected set; }

        public string ISBN { get; protected set; }

        public string Name { get; protected set; }

        public string Language { get; protected set; }

        public string Author { get; protected set; }

        public string Publisher { get; protected set; }

        public string Description { get; protected set; }

        public string ImageUrl { get; protected set; }
    }
}
