using Library.Application.ViewModels;
using MediatR;

namespace Library.Application.Queries.GetLoanById
{
    public class GetLoansByIdQuery : IRequest<LoanViewModel>
    {
        public GetLoansByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }

    }
}
