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

    // Format the data and save it into the file provided by Program Class.

    public void SaveToFile(string file)
    {
        List<string> lines = new List<string>();

        foreach (Entry entry in _entries)
        {
            lines.Add($"{entry._date}|{entry._promptText}|{entry._entryText}");
        }

        // Using File.WriteAllLines to save entries to the file

        File.WriteAllLines(file, lines);
    }


    // Load it from the file provided by Program Class and format into a more easy-to-read format.

    public void LoadFromFile(string file)
    {
        string[] lines = File.ReadAllLines(file);

        _entries.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            Entry entry = new Entry
            {
                _date = parts[0],

                _promptText = parts[1],
                
                _entryText = parts[2]
            };

            _entries.Add(entry);
        }
    }
}