using Library.Core.Repositories;
using MediatR;

namespace Library.Application.Commands.DeleteBook
{
    public class DeleteBookCommandHandler : IRequestHandler<DeleteBookCommand, Unit>
    {
        private readonly IBookRepository _bookRepository;
        public DeleteBookCommandHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<Unit> Handle(DeleteBookCommand request, CancellationToken cancellationToken)
        {
            var book = await _bookRepository.GetDetailsByIdAsync(request.Id);

            await _bookRepository.DeleteAsync(book.Id);

            return Unit.Value;
        }
    }
}
