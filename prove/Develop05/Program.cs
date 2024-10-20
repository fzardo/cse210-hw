using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        ListingActivity listingActivity = new ListingActivity();

        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflection activity");
            Console.WriteLine("3. Start listening activity");
            Console.WriteLine("4. Load activity logs");
            Console.WriteLine("5. Quit");
            Console.Write("Select a choice from the menu.");

            int choice;
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                breathingActivity.Run();
            }

            else if (choice == 2)
            {
                reflectingActivity.Run();
            }

            else if (choice == 3)
            {
                listingActivity.Run();
            }

            else if (choice == 4)
            {
                // Call LoadLogs from the Activity class
                breathingActivity.LoadLogs();
                reflectingActivity.LoadLogs();
                listingActivity.LoadLogs();
            }

            else if (choice == 5)
            {
                Environment.Exit(0);
            }

            else
            {
                Console.WriteLine("Invalid input, please try again.");
                Console.Clear();
            }
        }
    }
}