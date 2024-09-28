public class PromptGenerator
{
    public List<string> _prompts;

    // When called, randomly select one of the prompts below and return it.
    // Original prompts were written.

    public string GetRandomPrompt()
    {
        _prompts = new List<string>
        {
            "What did I spent most of my free time in today?",

            "What was the most interesting part of my day?",

            "What made me smile today?",

            "What did I do that made me ponder my actions?",
            
            "What did today I would like to do again?"
        };

        Random random = new Random();
        int index = random.Next(_prompts.Count);

        return _prompts[index];
    }
}