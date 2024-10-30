using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running(new DateTime(2024, 10, 27), 30, 4.8);
        Cycling cycling = new Cycling(new DateTime(2024, 10, 28), 30, 20);
        Swimming swimming = new Swimming(new DateTime(2024, 10, 29), 30, 20);

        // Adding all activities to a list
        List<Activity> activities = new List<Activity> { running, cycling, swimming };

        // Displaying summaries for each activity
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}