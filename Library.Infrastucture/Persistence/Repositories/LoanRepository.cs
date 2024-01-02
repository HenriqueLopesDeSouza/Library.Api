using Library.Core.Entities;
using Library.Core.Repositories;
using Microsoft.EntityFrameworkCore;


namespace Library.Infrastucture.Persistence.Repositories
{
    public class LoanRepository : ILoanRepository
    {
        private readonly LibraryDbContext _dbContext;
        public LoanRepository(LibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }



    public async Task AddAsync(Loan loan)
    {
        var existingUser = await _dbContext.Users.FirstOrDefaultAsync(u => u.Id == loan.UserId);

        if (existingUser == null)
        {
            throw new Exception($"User with ID {loan.UserId} not found.");
        }

        var existingBook = await _dbContext.Books.FirstOrDefaultAsync(b => b.Id == loan.BookId);

        if (existingBook == null)
        {
            throw new Exception($"Book with ID {loan.BookId} not found.");
        }

        await _dbContext.Loans.AddAsync(loan);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<List<Loan>> GetAllAsync()
        {
            return await _dbContext.Loans.Include(p => p.Book)
                .Include(p => p.User).ToListAsync();
        }

        public async Task<Loan> GetDetailsByIdAsync(int id)
        {
            return await _dbContext.Loans
            .Include(p => p.Book)
            .Include(p => p.User)
            .SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task UpdateLoan(Loan updatedLoan)
        {
            var existingLoan = _dbContext.Loans.Find(updatedLoan.Id);

            if (existingLoan != null)
            {
                _dbContext.Entry(existingLoan).CurrentValues.SetValues(updatedLoan);

                _dbContext.SaveChanges();
            }
            else 
            {
                throw new Exception("Loan not found.");
            }
        }

     
    }
}
