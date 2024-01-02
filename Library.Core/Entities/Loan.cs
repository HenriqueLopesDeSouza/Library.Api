using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Entities
{
    public class Loan : BaseEntity
    {
        public Loan(int bookId, int userId)
        {
            BookId = bookId;
            UserId = userId;
        }

        public Loan(int bookId, int userId, DateTime returnDate)
        {
            BookId = bookId;
            UserId = userId;
            ReturnDate = returnDate;
            LoanDate = DateTime.Now;
        }

        public Loan(Book book, User user, DateTime returnDate)
        {
            Book = book;
            User = user;
            ReturnDate = returnDate;
            LoanDate = DateTime.Now;
        }

        public void ReturnBook(int loanId, DateTime returnDate)
        {
            this.Id = loanId;
            ReturnDate = returnDate;
        }

        public int BookId { get; set; }
        public int UserId { get; set; }
        public Book Book { get; set; }
        public User User { get; set; }
        public DateTime LoanDate { get; private set; }
        public DateTime ReturnDate { get; private set; }
    }
}
