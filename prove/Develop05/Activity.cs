public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        _name = "";
        _description = "";
        _duration = 0;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine($"This activity will help you {_description}");
        Console.WriteLine();
        Console.WriteLine("How long, in seconds, would you like for your session?");
        _duration = int.Parse(Console.ReadLine());
        GetReadyCountdown();
    }

    private void GetReadyCountdown()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");

        ShowCountDown(5);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        ShowCountDown(5);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} of the {_name} Activity.");
        ShowCountDown(5);
        Console.Clear();

        // Log the activity completion
        SaveLog(_name);
        Console.Clear();
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            // Write how many seconds left
            Console.Write(i);

            // Wait for 1000 (1 second)
            Thread.Sleep(1000);

            Console.Write("\b \b");
        }
    }

    public void SaveLog(string activityType)
    {
        string logEntry = $"{DateTime.Now}: {activityType} Activity for {_duration} seconds";
        File.AppendAllText("activity_log.txt", logEntry + Environment.NewLine);
    }

    public void LoadLogs()
    {
        if (File.Exists("activity_log.txt"))
        {
            string[] logs = File.ReadAllLines("activity_log.txt");
            Console.Clear();
            Console.WriteLine("Activity Log:");
            foreach (string log in logs)
            {
                Console.WriteLine(log);
            }
            Console.WriteLine("Press Enter to return to the menu.");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("No activity logs found.");
            Console.WriteLine("Press Enter to return to the menu.");
            Console.ReadLine();
        }
    }

}