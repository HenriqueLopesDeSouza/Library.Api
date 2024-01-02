using MediatR;

namespace Library.Application.Commands.ReturnBook
{
    public class ReturnBookCommand : IRequest<int>
    {
        public ReturnBookCommand(int loadId) 
        {
            LoanId = loadId;
            ReturnDate = DateTime.Now;
        }
        public int LoanId { get; private set; }
        public DateTime ReturnDate { get; private set; }
    }
}
