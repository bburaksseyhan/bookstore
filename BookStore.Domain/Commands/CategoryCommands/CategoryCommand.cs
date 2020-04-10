using BookStore.Core.Commands;

namespace BookStore.Domain.CategoryCommands.Commands
{
    public class CategoryCommand : Command
    {
        public int Id { get; protected set; }

        public string Name { get; protected set; }

        public string Description { get; protected set; }
    }
}
