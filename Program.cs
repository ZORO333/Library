using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using library.Models;

public class mylibrary
{
    public static void Main()
    {
        System.Console.WriteLine("Min biblotek");
        System.Console.WriteLine("1. Lägg till böcker");
        System.Console.WriteLine("2. Stäng av bibloteket");

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