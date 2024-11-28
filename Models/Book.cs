using System;

namespace library.Models
{
    public class Book
    {
        public int ID {get; set;}
        public string Title {get; set;}

        public DateTime published {get; set;}
        public ICollection<BookAuthor> BookAuthors {get; set;}
        public ICollection<Loan> Loans {get; set;}
    }
}