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
                if (book != null)
                {
                    context.bookAuthors.RemoveRange(context.bookAuthors.Where(ba => ba.BookID == bookID));
                }
                context.SaveChanges();
                transaction.Commit();
                System.Console.WriteLine("Boken har tagits bort");

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