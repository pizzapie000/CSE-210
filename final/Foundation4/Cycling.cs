class Cycling : Activity
{
    private double speedInMph;

    public double SpeedInMph 
    { 
        get => speedInMph; 
        set => speedInMph = value; 
    }

    public Cycling(DateTime date, int duration, double speed)
        : base(date, duration)
    {
        this.speedInMph = speed;
    }

    // abstract methods
    public override double GetDistance() => (speedInMph * DurationInMinutes) / 60;
    public override double GetSpeed() => speedInMph;
    public override double GetPace() => 60 / speedInMph;
}
