public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    // Display the date, the prompt, and entry inputted by user.
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine();
    }
}