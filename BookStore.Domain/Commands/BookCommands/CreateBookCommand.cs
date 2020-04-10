
namespace BookStore.Domain.BookCommands.Commands
{
    public class CreateBookCommand : BookCommand
    {
        public CreateBookCommand(int categoryId, string isbn, string name, string language, string author, string publisher, string description, string imageUrl)
        {
            CategoryId = categoryId;
            ISBN = isbn;
            Name = name;
            Language = language;
            Author = author;
            Publisher = publisher;
            Description = description;
            ImageUrl = imageUrl;
        }
    }
}
