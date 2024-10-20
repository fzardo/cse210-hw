public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity()
    {
        _name = "Reflecting";
        _description = "reflect on times in your life when you have shown stregth and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        DisplayPrompt();

        DisplayQuestion();

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        Random random = new Random();
        int index = random.Next(_prompts.Count);

        return _prompts[index];
    }

    private string GetRandomQuestion()
    {
        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?"
        };

        Random random = new Random();
        int index = random.Next(_questions.Count);

        return _questions[index];
    }

    private void DisplayPrompt()
    {
        Console.Clear();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($" --- {GetRandomPrompt()} --- ");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press Enter to continue.");

        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
    }

    public void DisplayQuestion()
    {
        int durationHolder = _duration;

        while (_duration > 0)
        {
            Console.WriteLine(GetRandomQuestion());
            int ponderingQuestion = 8;
            ShowCountDown(ponderingQuestion);
            _duration -= ponderingQuestion;
        }

        _duration = durationHolder;
    }
}