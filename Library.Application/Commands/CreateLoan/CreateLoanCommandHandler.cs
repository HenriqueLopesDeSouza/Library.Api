using Library.Core.Entities;
using Library.Core.Repositories;
using MediatR;


namespace Library.Application.Commands.CreateLoan
{
    public class CreateLoanCommandHandler : IRequestHandler<CreateLoanCommand, int>
    {
        private readonly ILoanRepository _loanRepository;
        public CreateLoanCommandHandler(ILoanRepository loanRepository)
        {
            _loanRepository = loanRepository;
        }

        public async Task<int> Handle(CreateLoanCommand request, CancellationToken cancellationToken)
        {

            var loan = new Loan(request.BookId, request.UserId, request.ReturnDate);

            await _loanRepository.AddAsync(loan);
         
             return loan.Id;
        }
    }
}
