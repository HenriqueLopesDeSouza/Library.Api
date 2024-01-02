using Library.Core.Entities;


namespace Library.Core.Repositories
{
    public interface ILoanRepository
    {
        Task<Loan> GetDetailsByIdAsync(int id);
        Task AddAsync(Loan loan);
        Task<List<Loan>> GetAllAsync();
        Task UpdateLoan(Loan updatedLoan);
    }
}
