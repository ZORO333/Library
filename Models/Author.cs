using System;

namespace library.Models
{
    public class Author
    {
        public int ID {get; set;}
        public string Name {get; set;}
        public string Age {get; set;}

        public ICollection<Book> Books {get; set;}
    }
}