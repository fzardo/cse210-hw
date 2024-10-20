public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "relax by walking your breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        int durationHolder = _duration;

        while (_duration > 0)
        {
            Breathing("Breath in...", 4);
            Breathing("Breath out...", 4);
            Console.WriteLine();
        }

        _duration = durationHolder;
        
        DisplayEndingMessage();
    }

    private void Breathing(string message, int seconds)
    {
        Console.Write(message);
        ShowCountDown(seconds);
        _duration -= seconds;
    }
}