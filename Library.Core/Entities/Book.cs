using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Entities
{
    public class Book : BaseEntity
    {
        public Book(string title, string description, string isbn, string authorName, int yearOfPublication)
        {
            Title = title;
            Description = description;
            ISBN = isbn;
            AuthorName = authorName;
            YearOfPublication = yearOfPublication;
            CreatedAt = DateTime.Now;
        }
        public Book()
        {
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public string ISBN { get; set; }
        public string AuthorName { get; set; }
        public int YearOfPublication { get; set; }

    }
}
