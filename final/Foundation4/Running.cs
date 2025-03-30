class Running : Activity
{
    private double distanceInMiles;

    public double DistanceInMiles 
    { 
        get => distanceInMiles; 
        set => distanceInMiles = value; 
    }

    public Running(DateTime date, int duration, double distance)
        : base(date, duration)
    {
        this.distanceInMiles = distance;
    }

    // Implementing abstract methods
    public override double GetDistance() => distanceInMiles;
    public override double GetSpeed() => (distanceInMiles / DurationInMinutes) * 60;
    public override double GetPace() => DurationInMinutes / distanceInMiles;
}
