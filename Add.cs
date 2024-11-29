using System.Runtime.CompilerServices;
using library.Models;

public class Add
{
    public static void Addbook()
    {
        using(var context = new AppDbContext())
        {

        
            System.Console.WriteLine("Skriv in book titel:");
            string bookTitle = Console.ReadLine();
            System.Console.WriteLine("Skriv in publicerade datum:");
            DateTime publishedDate = DateTime.Parse(Console.ReadLine());

            var newBook = new Book
            {
                Title = bookTitle,
                Published = publishedDate
            };
            context.Books.Add(newBook);
            context.SaveChanges();
        }
    }
    public static void AddAuthor()
    {
        using(var context = new AppDbContext())
        {
            System.Console.WriteLine("Skriv in författarens namn:");
            string AuthorName = Console.ReadLine();
            System.Console.WriteLine("Skriv in författarens older:");
            string AuthorAge = Console.ReadLine();

            var newAuthor = new Author
            {
                Name = AuthorName,
                Age = AuthorAge
            };
            context.Authors.Add(newAuthor);
            context.SaveChanges();
        }
    }

}