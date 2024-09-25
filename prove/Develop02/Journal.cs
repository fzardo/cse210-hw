using System.IO;

public class Journal
{    
    public List<Entry> _entries = new List<Entry>();

    // Add a new entry to Entry.
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    // Calls Display from Entry class for each entry inputted.
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    // TODO
    public void SaveToFile(string file)
    {

    }

    //TODO
    public void LoadFromFile(string file)
    {
        string[] lines = File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string firstName = parts[0];
            string lastName = parts[1];
        }
    }
}