abstract class Activity
{
    // Private member variables
    private DateTime date; 
    private int durationInMinutes;

    // Public properties
    public DateTime Date => date;
public int DurationInMinutes => durationInMinutes;


    // Constructor
    public Activity(DateTime date, int duration)
    {
        this.date = date;
        this.durationInMinutes = duration;
    }

    // calculate distance, speed, and pace
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // summary
    public virtual string GetSummary()
    {
        return $"{Date:dd MMM yyyy} ({DurationInMinutes} min): Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}
