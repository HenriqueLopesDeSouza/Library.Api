using Library.Core.Entities;

namespace Library.Application.ViewModels
{

    public class LoanViewModel
    { 
        public LoanViewModel(int id, Book book, User user, DateTime loanDate, DateTime returnDate)
        {
            Id = id;
            Book = book;
            User = user;
            LoanDate = loanDate;
            ReturnDate = returnDate;
        }
        public int Id { get; set; }
        public Book Book { get; set; }
        public User User { get; set; }
        public DateTime LoanDate { get; private set; }
        public DateTime ReturnDate { get; private set; }
    }
}
