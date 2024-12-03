using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using library.Models;

public class mylibrary
{
    public static void Main()
    {


        bool run = true;

        while (run)
        {
            System.Console.WriteLine("Min biblotek");
            System.Console.WriteLine("1. Lägg till böcker");
            System.Console.WriteLine("2. Visa böcker");
            System.Console.WriteLine("3. Lägg till författare");
            System.Console.WriteLine("4. Visa författare");
            System.Console.WriteLine("5. Lägg till lån");
            System.Console.WriteLine("6. Visa lån");
            System.Console.WriteLine("7. Visa låne historik");
            System.Console.WriteLine("8. Lägg till BokFörfattare");
            System.Console.WriteLine("9. visa bokFörfattare");
            System.Console.WriteLine("10. Lista alla böcker som mer än en författare har bidragt i");
            System.Console.WriteLine("11. Lista alla författare som har bidragt i en viss bok");
            System.Console.WriteLine("12. Tabort bok");
            System.Console.WriteLine("13. Tabort förattare");
            System.Console.WriteLine("14. Stäng av bibloteket");
            System.Console.WriteLine("Skriv in ditt val:");

            string val = Console.ReadLine();
            switch (val)
            {
                case "1":

                    Add.Addbook();
                    System.Console.WriteLine("Böckerna har lagts till");
                    break;
                case "2":
                    Read.Readbook();
                    System.Console.WriteLine("Böcker visades");
                    break;
                case "3":
                    Add.AddAuthor();
                    System.Console.WriteLine("Författare har lagts till");
                    break;
                case "4":
                    Read.ReadAuthor();
                    System.Console.WriteLine("Författare visades");
                    break;
                case "5":
                    Add.Addloan();
                    System.Console.WriteLine("Låne har lagts till");
                    break;
                case "6":
                    Read.ReadLoan();
                    System.Console.WriteLine("Lån visades");
                    break;
                case "7": 
                    Read.ShowLoanHistory();
                    break;
                case "8":
                    Add.AddBookAuthor();
                    break;
                case "9":
                    Read.ReadbookAuthor();
                    break;
                case "10":
                    System.Console.WriteLine("Ange förattarens namn");
                    string authorName = Console.ReadLine();
                    Read.ListBooksByAuthor(authorName);
                    break;
                case "11":
                    System.Console.WriteLine("Ange Bokens namn:");
                    string BookTitle = Console.ReadLine();
                    Read.ListAuthorsBybook(BookTitle);
                    break;
                case "12":
                    System.Console.WriteLine("Ange Bokens ID:");
                    int bookID = Convert.ToInt32(Console.ReadLine());
                    Remove.RemoveBook(bookID);
                    break;
                case "13":
                    System.Console.WriteLine("Ange författarens ID:");    
                    int authorID = Convert.ToInt32(Console.ReadLine());
                    Remove.RemoveAuthor(authorID);
                    break;               
                case "14":
                    run = false;
                    System.Console.WriteLine("Biblotekt har stängts");
                    break;
                default:
                    System.Console.WriteLine("Fel. Försök agin...");
                    break;

            }
        }
    }
}