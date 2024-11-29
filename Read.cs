using library.Models;
using Microsoft.EntityFrameworkCore;

public class Read
{
    public static void Readbook()
    {
        using (var context = new AppDbContext())
        {
            var books = context.Books
                .Include(b => b.BookAuthors)
                .ToList();
        

            //kontroll
            if(books.Any())
            {
                foreach(var book in books)
                {
                    System.Console.WriteLine($"Titel: {book.Title}, publicrade datum; {book.Published}");
                }
                
            }
            else
            {
                System.Console.WriteLine("Inga personer hittades i databasen.");
            }
        }
 
    }
}