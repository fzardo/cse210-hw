public class Activity
{
    private DateTime _date;
    private int _duration; // Duration in minutes

    public Activity(DateTime date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public DateTime Date => _date;
    public int Duration => _duration;

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return (GetDistance() / _duration) * 60; // Speed in kph
    }

    public virtual double GetPace()
    {
        return _duration / GetDistance(); // Pace in min per km
    }

    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} Activity ({_duration} min): Distance {GetDistance():0.0} km, Speed {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
    }
}