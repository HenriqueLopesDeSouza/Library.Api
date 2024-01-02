﻿using Library.Core.DTOs;
using Library.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Repositories
{
    public interface IUserRepository
    {
        Task<List<UserDTO>> GetAllAsync();
        Task<User> GetByIdAsync(int id);
        Task<User> GetUserByEmailAndPasswordAsync(string email, string passwordHash);
        Task AddAsync(User user);
    }
}
