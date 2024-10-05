public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, List<string> text)
    {
        _reference = reference;
        _words = new List<Word>();

        foreach (string verse in text)
        {
            _words.AddRange(verse.Split(' ').Select(w => new Word(w)));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        // Create a list of indices for words that are currently visible
        List<int> availableIndices = new List<int>();
        
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden()) // Only consider words that are not hidden
            {
                availableIndices.Add(i);
            }
        }

        // Determine how many words we can actually hide
        int countToHide = Math.Min(numberToHide, availableIndices.Count);

        for (int i = 0; i < countToHide; i++)
        {
            int index = random.Next(availableIndices.Count); // Select a random index from available words
            _words[availableIndices[index]].Hide(); // Hide the word
            availableIndices.RemoveAt(index); // Remove this index from the available list to prevent reselection
        }
    }

    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();
        string wordsText = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{referenceText}\n{wordsText}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}