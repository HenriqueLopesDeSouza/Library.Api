using Library.Application.ViewModels;
using Library.Core.Repositories;
using MediatR;

namespace Library.Application.Queries.GetLoanById
{
    public class GetLoansByIdQueryHandler : IRequestHandler<GetLoansByIdQuery, LoanViewModel>
    {
        private readonly ILoanRepository _loanRepository;
        public GetLoansByIdQueryHandler(ILoanRepository loanRepository)
        {
            _loanRepository = loanRepository;
        }

        public async Task<LoanViewModel> Handle(GetLoansByIdQuery request, CancellationToken cancellationToken)
        {
            var loan = await _loanRepository.GetDetailsByIdAsync(request.Id);

            if (loan == null) return null;

            var loanViewModel = new LoanViewModel(
                loan.Id,
                loan.Book,
                loan.User,
                loan.LoanDate,
                loan.ReturnDate);

            return loanViewModel;
        }
    }
}
