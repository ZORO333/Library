using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;
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
            DateTime publishedDate;
            while(!DateTime.TryParse(Console.ReadLine(), out publishedDate))
            {
                System.Console.WriteLine("Fel formatering försök igen....");
            }

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
    public static void Addloan()
    {
        using(var context = new AppDbContext())
        {
            System.Console.WriteLine("Skriv in låntagares namn:");
            string name = Console.ReadLine();
            System.Console.WriteLine("Skriv in låne datum");
            DateTime loandata;
            while(!DateTime.TryParse(Console.ReadLine(), out loandata))
            {
                System.Console.WriteLine("Fel formatering försök igen....");
            }
            System.Console.WriteLine("Skriv in retur datum:");
            DateTime returndate;
            while(!DateTime.TryParse(Console.ReadLine(), out returndate))
            {
                System.Console.WriteLine("Fel formatering försök igen....");
            }
            System.Console.WriteLine("Välj bok från listan:");
            var books = context.Books.ToList();
            foreach (var book in books)
            {
                System.Console.WriteLine($"ID:{book.ID}, Titel: {book.Title} ");
            }
            System.Console.WriteLine("Ange bok-ID:");
            int bookID;
            while(!int.TryParse(Console.ReadLine(),out bookID))
            {
                System.Console.WriteLine("Fel bok-ID, försök igen....");
            }
            var newLoan = new Loan
            {
                Name = name,
                LoanDate = loandata,
                ReturnDate = returndate,
                BookID = bookID
            };
            context.Loans.Add(newLoan);
            context.SaveChanges();
            System.Console.WriteLine("Nytt lån sparat.");
        }
    }
    public static void AddBookAuthor()
    {
        using(var context = new AppDbContext())
        {
            System.Console.WriteLine("Välj bok från listan:");
            var books = context.Books.ToList();
            foreach (var book in books)
            {
                System.Console.WriteLine($"ID:{book.ID}, Titel: {book.Title} ");
            }
            System.Console.WriteLine("Ange bok-ID:");
            int bookID;
            while(!int.TryParse(Console.ReadLine(),out bookID))
            {
                System.Console.WriteLine("Fel bok-ID, försök igen....");
            }

            System.Console.WriteLine("Välj bok från listan:");
            var authors = context.Authors.ToList();
            foreach (var author in authors)
            {
                System.Console.WriteLine($"ID:{author.ID}, Namn: {author.Name}, Older: {author.Age}");
            }
            System.Console.WriteLine("Ange bok-ID:");
            int authorID;
            while(!int.TryParse(Console.ReadLine(),out authorID))
            {
                System.Console.WriteLine("Fel bok-ID, försök igen....");
            }
            
            var newBookauthor = new BookAuthor
            {
                BookID = bookID,
                AuthorID = authorID
            };
            context.bookAuthors.Add(newBookauthor);
            context.SaveChanges();
            System.Console.WriteLine("Nytt bookAuthor sparat.");
        }
        
    }

}