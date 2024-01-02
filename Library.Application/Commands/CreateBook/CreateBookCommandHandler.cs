using Library.Core.Entities;
using Library.Core.Repositories;
using MediatR;

namespace Library.Application.Commands.CreateBook
{

    public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand, int>
    {
        private readonly IBookRepository _bookRepository;
        public CreateBookCommandHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<int> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            var project = new Book(request.Title, request.Description, request.ISBN, request.AuthorName, request.YearOfPublication);


            await _bookRepository.AddAsync(project);

            return project.Id;
        }
    }
}
