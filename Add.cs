using System.Runtime.CompilerServices;
using library.Models;

public class Add
{
    public static void Addbook()
    {
        using(var context = new AppDbContext())
        {

        
            System.Console.WriteLine("Skriv in book titel");
            string bookTitle = Console.ReadLine();
            System.Console.WriteLine("Skriv in publicerade datum:");
            DateTime publishedDate = DateTime.Parse(Console.ReadLine());

            var newBook = new Book
            {
                Title = bookTitle,
                Published = publishedDate
            };
            context.Books.Add(newBook);
        }
    }
}