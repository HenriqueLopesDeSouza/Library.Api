using Library.Core.Entities;

namespace Library.Core.Repositories
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllAsync();
        Task<User> GetByIdAsync(int id);
        Task<User> GetUserByEmailAndPasswordAsync(string email, string passwordHash);
        Task AddAsync(User user);
    }
}
