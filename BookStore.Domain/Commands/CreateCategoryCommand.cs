namespace BookStore.Domain.Commands
{
    public class CreateCategoryCommand : CategoryCommand
    {
        public CreateCategoryCommand(string name, string description)
        {
            Name = name;
            Descriptiom = description;
        }
    }
}
