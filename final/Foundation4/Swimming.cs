class Swimming : Activity
{
    private int numberOfLaps;

    public int NumberOfLaps 
    { 
        get => numberOfLaps; 
        set => numberOfLaps = value; 
    }

    public Swimming(DateTime date, int duration, int laps)
        : base(date, duration)
    {
        this.numberOfLaps = laps;
    }

    // abstract methods
    public override double GetDistance() => numberOfLaps * 50 / 1000.0 * 0.62; // Convert laps to miles
    public override double GetSpeed() => (GetDistance() / DurationInMinutes) * 60;
    public override double GetPace() => DurationInMinutes / GetDistance();
}
