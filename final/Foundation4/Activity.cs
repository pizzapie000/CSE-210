abstract class Activity
{
    // Private member variables
    private DateTime date; 
    private int durationInMinutes;

    // Public properties for controlled access
    public DateTime Date 
    { 
        get => date; 
        set => date = value; 
    }

    public int DurationInMinutes 
    { 
        get => durationInMinutes; 
        set => durationInMinutes = value; 
    }

    // Constructor for common attributes
    public Activity(DateTime date, int duration)
    {
        this.date = date;
        this.durationInMinutes = duration;
    }

    // Methods for calculating distance, speed, and pace
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // method activity summary
    public virtual string GetSummary()
    {
        return $"{Date:dd MMM yyyy} ({DurationInMinutes} min): Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}
