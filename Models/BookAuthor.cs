using System;

namespace library.Models
{
    public class BookAuthor
    {
        public int BookID {get; set;}
        public Book book {get; set;}

        public int AuthorID {get; set;}
        public Author author {get; set;}
    }
}