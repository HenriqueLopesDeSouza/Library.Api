using Library.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Repositories
{
    public interface IBookRepository
    {
        Task<Book> GetDetailsByIdAsync(int id);
        Task AddAsync(Book project);
        Task<List<Book>> GetAllAsync();
        Task DeleteAsync(int id);

    }
}
