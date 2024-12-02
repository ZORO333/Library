﻿using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using library.Models;

public class mylibrary
{
    public static void Main()
    {
        System.Console.WriteLine("Min biblotek");
        System.Console.WriteLine("1. Lägg till böcker");
        System.Console.WriteLine("2. Visa böcker");
        System.Console.WriteLine("3. Lägg till författare");
        System.Console.WriteLine("4. Visa författare");
        System.Console.WriteLine("5. Lägg till lån");
        System.Console.WriteLine("6. Visa lån");
        System.Console.WriteLine("7. Lägg till BokFörfattare");
        System.Console.WriteLine("8. visa bokFörfattare");
        System.Console.WriteLine("9. tabort bok");
        System.Console.WriteLine("10. Stäng av bibloteket");
        System.Console.WriteLine("Skriv in ditt val:");

        bool run = true;

        while (run)
        {
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
                    Add.AddBookAuthor();
                    break;
                case "8":
                    Read.ReadbookAuthor();
                    break;
                case "9":
                    Remove.RemoveBook();
                    break;                   
                case "10":
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