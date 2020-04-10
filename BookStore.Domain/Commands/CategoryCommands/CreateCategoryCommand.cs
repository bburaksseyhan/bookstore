namespace BookStore.Domain.CategoryCommands.Commands
{
    public class CreateCategoryCommand : CategoryCommand
    {
        public CreateCategoryCommand(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
