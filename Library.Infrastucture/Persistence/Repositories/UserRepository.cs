using Dapper;
using Library.Core.Entities;
using Library.Core.Repositories;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Library.Infrastucture.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly LibraryDbContext _dbContext;
        private readonly string _connectionString;

        public UserRepository(LibraryDbContext dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _connectionString = configuration.GetConnectionString("LibraryCs");

        }

        public async Task AddAsync(User user)
        {
            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();
        }


        public async Task<List<User>> GetAllAsync()
        {
            //Dapper
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();

                var script = "SELECT Id, FullName, Email FROM Users";

                var userDTOList = await sqlConnection.QueryAsync<User>(script);

                return userDTOList.ToList();
            }
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
