using System;
using library.Models;

public class Remove
{
    public static void RemoveBook(int bookID)
    {
        using (var context = new AppDbContext())
        {
            var transaction = context.Database.BeginTransaction();
            try
            {
                var book = context.Books.Find(bookID);
                if(book != null)
                {
                    var bookAuthors = context.bookAuthors.Where(ba => ba.BookID == bookID).ToList();
                    if (bookAuthors.Any())
                    {
                        context.bookAuthors.RemoveRange(bookAuthors);
                    }
                    var Loans = context.Loans.Where(l => l.BookID == bookID).ToList();
                    if(Loans.Any())
                    {
                        context.Loans.RemoveRange(Loans);
                    }
                    context.Books.Remove(book);
                    context.SaveChanges();
                    transaction.Commit();
                    System.Console.WriteLine("Boken har tagits bort");
                }

            }
            catch (Exception ex)
            {
                
                transaction.Rollback();
                System.Console.WriteLine($"Fel: {ex.Message}");
                return;
            }
        }

    }

}