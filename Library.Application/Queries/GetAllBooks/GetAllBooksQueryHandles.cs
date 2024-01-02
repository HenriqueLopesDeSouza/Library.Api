using Library.Application.ViewModels;
using Library.Core.Repositories;
using MediatR;


namespace Library.Application.Queries.GetAllBooks
{
    public class GetAllBooksQueryHandles : IRequestHandler<GetAllBooksQuery, List<BookViewModel>>
    {
        private readonly IBookRepository _bookRepository;
        public GetAllBooksQueryHandles(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<List<BookViewModel>> Handle(GetAllBooksQuery request, CancellationToken cancellationToken)
        {
            var books = await _bookRepository.GetAllAsync();

            var booksViewModel = books

                .Select(p => new BookViewModel(p.Id, p.Title, p.Description, p.ISBN, p.AuthorName, p.YearOfPublication))

                .ToList();

            return booksViewModel;
        }
    }
}
