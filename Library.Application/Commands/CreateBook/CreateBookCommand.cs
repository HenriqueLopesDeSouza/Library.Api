using MediatR;


namespace Library.Application.Commands.CreateBook
{
    public class CreateBookCommand : IRequest<int>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }
        public string AuthorName { get; set; }
        public int YearOfPublication { get; set; }
    }
}
