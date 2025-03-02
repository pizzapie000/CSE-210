using System;

public class Activity
{
    public int Duration { get; set; }
    public string Description { get; set; }

    public Activity(int duration, string description)
    {
        Duration = duration;
        Description = description;
    }

    public virtual void Start()
    {
        Console.WriteLine($"Starting activity: {Description}");
    }

    public void End()
    {
        Console.WriteLine("Ending activity.");
    }
}
