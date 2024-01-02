using MediatR;

namespace Library.Application.Commands.DeleteBook
{
    
    public class DeleteBookCommand : IRequest<Unit>
    {
        public DeleteBookCommand(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
