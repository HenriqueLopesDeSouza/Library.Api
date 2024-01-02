using Library.Application.ViewModels;
using Library.Core.Repositories;
using MediatR;

namespace Library.Application.Queries.GetBookById
{
    public class GetBooksByIdQueryHandler : IRequestHandler<GetBooksByIdQuery, BookViewModel>
    {
        private readonly IBookRepository _bookRepository;
        public GetBooksByIdQueryHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<BookViewModel> Handle(GetBooksByIdQuery request, CancellationToken cancellationToken)
        {
            var book = await _bookRepository.GetDetailsByIdAsync(request.Id);

            if (book == null) return null;

            var bookDetailsViewModel = new BookViewModel(
                book.Id,
                book.Title,
                book.Description,
                book.ISBN,
                book.AuthorName,
                book.YearOfPublication);


            return bookDetailsViewModel;
        }
    }
}
