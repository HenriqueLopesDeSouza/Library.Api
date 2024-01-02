using Library.Core.DTOs;
using Library.Core.Entities;
using Library.Core.Repositories;
using Microsoft.EntityFrameworkCore;


namespace Library.Infrastucture.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly LibraryDbContext _dbContext;
        public UserRepository(LibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(User user)
        {
            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();
        }


        public async Task<List<UserDTO>> GetAllAsync()
        {
            var userDTOList = await _dbContext.Users
                .Select(s => new UserDTO(s.Id, s.FullName, s.Email))
                .ToListAsync();

            return userDTOList;
        }


        public async Task<User> GetByIdAsync(int id)
        {
            return await _dbContext.Users.SingleOrDefaultAsync(u => u.Id == id);
        }

        public async Task<User> GetUserByEmailAndPasswordAsync(string email, string passwordHash)
        {
            return await _dbContext
                .Users
                .SingleOrDefaultAsync(u => u.Email == email && u.Password == passwordHash);
        }
    }
}
