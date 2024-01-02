using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.DTOs
{
    public class UserDTO
    {
        public UserDTO(int id, string fullName, string email)
        {
            Id = id;
            this.Name = fullName;
            Email = email;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

    }
}
