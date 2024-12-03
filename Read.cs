using System.IO.Compression;
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
    public static void ReadbookAuthor()
    {
        using (var context = new AppDbContext())
        {
            var bookAuthor = context.bookAuthors
                .Include(b => b.Book)
                .ThenInclude(ba => ba.BookAuthors)
                .Include(a => a.Author)
                .ThenInclude(ba => ba.BookAuthors)
                .ToList();
        

            //kontroll
            if(bookAuthor.Any())
            {
                foreach(var bookAuthor1 in bookAuthor)
                {
                    System.Console.WriteLine($"Bok-ID: {bookAuthor1.BookID}, Författare-ID; {bookAuthor1.AuthorID}");
                }
                
            }
            else
            {
                System.Console.WriteLine("Inga Bokförfattare hittades i databasen.");
            }
        }
    }
    public static void ListBooksByAuthor(string authorName)
    {
        using (var context = new AppDbContext())
        {
            var books = context.Books
                .Include(b => b.BookAuthors)
                .ThenInclude(ba => ba.Author)
                .Where(b => b.BookAuthors.Any(ba => ba.Author.Name == authorName))
                .ToList();
            if(books.Any())
            {
                System.Console.WriteLine($"Böcker av {authorName}");
                foreach(var book in books)
                {
                    System.Console.WriteLine($"-{book.Title}");
                }
            }
            else
            {
                System.Console.WriteLine($"Ingen bok hittades för författaren {authorName}");
            }
        }
        
    }


    public static void ListAuthorsBybook(string BookTitle)
    {
        using (var context = new AppDbContext())
        {
            var authors = context.Authors
                .Include(a => a.BookAuthors)
                .ThenInclude(ba => ba.Book)
                .Where(a => a.BookAuthors.Any(ba => ba.Book.Title == BookTitle))
                .ToList();
            if(authors.Any())
            {
                System.Console.WriteLine($"Författare för boken{BookTitle}");
                foreach(var author in authors)
                {
                    System.Console.WriteLine($"-{author.Name}");
                }
            }
            else
            {
                System.Console.WriteLine($"Ingen författare hittades för boken {BookTitle}");
            }
        }
        
    }
    public static void ShowLoanHistory()
    {
        using (var context = new AppDbContext())
        {
            var loans = context.Loans
                .Include(l => l.Book)
                .OrderBy(l => l.LoanDate)
                .ToList();
            if(loans.Any())
            {
                System.Console.WriteLine("Lånehistorik");
                foreach (var loan in loans)
                {
                    System.Console.WriteLine($"Bok: {loan.Book.Title}, lånad av: {loan.Name}, lånedatum: {loan.LoanDate:yyyy-mm-dd}, Returdatum: {loan.ReturnDate:yyyy-mm-dd}");
                }

            }
            else
            {
                System.Console.WriteLine("Ingen lånehistorik hittades");
            }
        }
        
    }
}