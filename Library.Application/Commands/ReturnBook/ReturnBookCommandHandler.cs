using Library.Core.Entities;
using Library.Core.Repositories;
using MediatR;

namespace Library.Application.Commands.ReturnBook
{
    public class ReturnBookCommandHandler : IRequestHandler<ReturnBookCommand, int>
    {
        private readonly ILoanRepository _loanRepository;
        public ReturnBookCommandHandler(ILoanRepository loanRepository)
        {
            _loanRepository = loanRepository;
        }

        public async Task<int> Handle(ReturnBookCommand request, CancellationToken cancellationToken)
        {
            Loan loan = await _loanRepository.GetDetailsByIdAsync(request.LoanId);

            if (loan == null)
                throw new InvalidOperationException($"Error  loan: User with ID {request.LoanId} not found.");

            loan.ReturnBook(request.LoanId, request.ReturnDate);

            await _loanRepository.UpdateLoan(loan);

            return loan.Id;
        }
    }
}
