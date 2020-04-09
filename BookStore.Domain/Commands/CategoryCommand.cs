using BookStore.Core.Commands;

namespace BookStore.Domain.Commands
{
    public class CategoryCommand : Command
    {
        public int Id { get; protected set; }

        public string Name { get; protected set; }

        public string Descriptiom { get; protected set; }
    }
}
