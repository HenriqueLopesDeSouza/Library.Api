using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Entities
{
    public class User : BaseEntity
    {

        public User(string fullName, string email)
        {
            FullName = fullName;
            Email = email;
        }
        public User(string fullName, string email, string password, string role)
        {
            FullName = fullName;
            Email = email;
            CreatedAt = DateTime.Now;
            Active = true;
            Password = password;
            Role = role;
        }
        public User() { }
        public string FullName { get; private set; }
        public string Email { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public bool Active { get; set; }
        public string Password { get; private set; }
        public string Role { get; private set; }
    }
}
