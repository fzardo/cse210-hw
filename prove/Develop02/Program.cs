using System.IO;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        string choice;

        Console.WriteLine("Welcome to your jounal!");

        while (true)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");

            choice = Console.ReadLine().ToLower();

            if (choice == "1" || choice == "write")
            {
                
            }
            else if (choice == "2" || choice == "display")
            {
                
            }
            else if (choice == "3" || choice == "load")
            {
                
            }
            else if (choice == "4" || choice == "save")
            {
                
            }
            else if (choice == "5" || choice == "quit")
            {
                
            }
            else
            {
                Console.WriteLine("Please input a valid choice.");
                Console.WriteLine();
            }
        }
    }
}