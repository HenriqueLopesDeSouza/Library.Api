
namespace Library.Application.ViewModels
{
    public class BookViewModel
    {
        public BookViewModel(int id,string title, string description, string isbn, string authorName, int yearOfPublication)
        {
            Id = id;
            Title = title;
            Description = description;
            ISBN = isbn;
            AuthorName = authorName;
            YearOfPublication = yearOfPublication;
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }
        public string AuthorName { get; set; }
        public int YearOfPublication { get; set; }
    }
}
