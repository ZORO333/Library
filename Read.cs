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
                System.Console.WriteLine("Inga Böcker hittades i databasen.");
            }
        }
 
    }
    public static void ReadAuthor()
    {
        using (var context = new AppDbContext())
        {
            var authors = context.Authors
                .Include(a => a.BookAuthors)
                .ToList();
        

            //kontroll
            if(authors.Any())
            {
                foreach(var author in authors)
                {
                    System.Console.WriteLine($"Författarens namn: {author.Name}, Författarens older; {author.Age}");
                }
                
            }
            else
            {
                System.Console.WriteLine("Inga författare hittades i databasen.");
            }
        }
    }
    public static void ReadLoan()
    {
        using (var context = new AppDbContext())
        {
            var loans = context.Loans
                .Include(l => l.Book)
                .ToList();
        

            //kontroll
            if(loans.Any())
            {
                foreach(var loan in loans)
                {
                    System.Console.WriteLine($"lånetagares namn: {loan.Name}, låne datum; {loan.LoanDate}, Retur datum: {loan.ReturnDate}");
                }
                
            }
            else
            {
                System.Console.WriteLine("Inga lån hittades i databasen.");
            }
        }
    }
}