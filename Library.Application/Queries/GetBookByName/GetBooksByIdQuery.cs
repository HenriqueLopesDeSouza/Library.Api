using Library.Application.ViewModels;
using MediatR;

namespace Library.Application.Queries.GetBookById
{
    public class GetBooksByIdQuery : IRequest<BookViewModel>
    {
        public GetBooksByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
