using System;

class Program
{
    public static void Main(string[] args)
    {
        // Create a scripture library, which is pre-filled with scriptures
        ScriptureLibrary scriptureLibrary = new ScriptureLibrary();
        
        // Get a random scripture from the library
        Scripture scripture = scriptureLibrary.GetRandomScripture();

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide random words or type 'quit' to exit.");

            string input = Console.ReadLine();
            if (input?.ToLower() == "quit")
                break;

            // Hide a few random words
            scripture.HideRandomWords(2); // You can adjust the number of words to hide

            // Check if all words are hidden
            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine("All words are now hidden.");
                break;
            }
        }
    }
}