public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity()
    {
        _name = "Listing";
        _description = "reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        UserInput();

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        Random random = new Random();
        int index = random.Next(_prompts.Count);

        return _prompts[index];
    }

    private List<string> GetListFromUser()
    {
        List<string> listFromUser = new List<string>();
        return listFromUser;
    }

    private void UserInput()
    {
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($" --- {GetRandomPrompt()} --- ");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        int durationHolder = _duration;

        Task countdownTask = Task.Run(() => StartCountdown(durationHolder));

        while (countdownTask.Status != TaskStatus.RanToCompletion)
        {
            Console.ReadLine();
            _count++;
        }

        _duration = durationHolder;

        Console.WriteLine($"You listed {_count} items!");
        Console.WriteLine();
    }

    // Countdown method to run in a separate task
    private void StartCountdown(int duration)
    {
        for (int i = duration; i > 0; i--)
        {
            Thread.Sleep(1000);  // Wait for 1 second
            _duration--;         // Decrease the duration
        }
    }
}