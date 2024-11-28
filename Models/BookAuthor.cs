using System;

namespace library.Models
{
    public class BookAuthor
    {
        public int BookID {get; set;}
        public Book Book {get; set;}

        public int AuthorID {get; set;}
        public Author Author {get; set;}
    }
}