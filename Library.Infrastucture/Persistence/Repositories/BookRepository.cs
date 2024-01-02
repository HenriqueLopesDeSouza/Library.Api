using Library.Core.Entities;
using Library.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Infrastucture.Persistence.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly LibraryDbContext _dbContext;
        public BookRepository(LibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(Book book)
        {
            await _dbContext.Books.AddAsync(book);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entityToDelete = await _dbContext.Books.FindAsync(id);

            if (entityToDelete != null)
            {
                _dbContext.Books.Remove(entityToDelete);
                await _dbContext.SaveChangesAsync();
            }
        }


        public async Task<List<Book>> GetAllAsync()
        {
            return await _dbContext.Books.ToListAsync();
        }

        public async Task<Book> GetDetailsByIdAsync(int id)
        {
            return await _dbContext.Books.SingleOrDefaultAsync(u => u.Id == id);
        }

    }
}
