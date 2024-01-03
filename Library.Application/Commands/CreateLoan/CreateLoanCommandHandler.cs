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

<<<<<<< HEAD
            var loan = new Loan(request.BookId, request.UserId);
=======
            var loan = new Loan(request.BookId, request.UserId, request.ReturnDate);
>>>>>>> 166f174973f436d8222b1669524f260d726fe617

            await _loanRepository.AddAsync(loan);
         
             return loan.Id;
        }
    }
}
