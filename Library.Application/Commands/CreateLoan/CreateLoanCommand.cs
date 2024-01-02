using MediatR;


namespace Library.Application.Commands.CreateLoan
{
    public class CreateLoanCommand : IRequest<int>
    {
        public int BookId { get; set; }
        public int UserId { get; set; } 
    }
}
