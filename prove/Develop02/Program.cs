class Program
{
    static void Main(string[] args)
    {
        PromptGenerator promptGenerator = new PromptGenerator();

        Journal journal = new Journal();

        Entry newEntry;

        string filename = "myFile.txt";
        
        string choice;

        Console.WriteLine("Welcome to your jounal!");

        // While ensure the program keep running until the user decide to quit

        // Display the main menu of the program

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

            Console.Clear();

            // Choice 1
            // Write option instantiate a new entry every time its called, generate a random prompt, and print it.
            // Then ask user input, take the date and call AddEntry function from Journal class.

            if (choice == "1" || choice == "write")
            {
                newEntry = new Entry();

                newEntry._promptText = promptGenerator.GetRandomPrompt();

                Console.WriteLine(newEntry._promptText);

                newEntry._entryText = Console.ReadLine();

                newEntry._date = DateTime.Now.ToString("yyyy-MM-dd");

                journal.AddEntry(newEntry);

                Console.Clear();

                Console.WriteLine("New entry added!");
            }

            // Choice 2
            // Calls DisplayAll from Journal class

            else if (choice == "2" || choice == "display")
            {
                journal.DisplayAll();
            }

            // Choice 3
            // Calls LoadFromFile from Journal class and gives a feedback message.

            else if (choice == "3" || choice == "load")
            {
                journal.LoadFromFile(filename);

                Console.WriteLine("Journal loaded!");
            }

            // Choice 4
            // Calls SaveToFile from Journal class and gives a feedback message.

            else if (choice == "4" || choice == "save")
            {
                journal.SaveToFile(filename);

                Console.WriteLine("Journal saved!");
            }

            // Choice 5
            // Quit the program

            else if (choice == "5" || choice == "quit")
            {
                Environment.Exit(0);
            }

            // Choice 6
            // Inform the user inputted an invalid choice.

            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }
}