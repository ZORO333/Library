using System;

namespace library.Models
{
    public class Loan
    {
        public int ID {get; set;}
        public string Name {get; set;}
        public DateTime LoanDate {get; set;}
        public DateTime ReturnDate {get; set;}
        public int BookID {get; set;}
        public Book Book {get; set;}
    }
}