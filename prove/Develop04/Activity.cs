public abstract class Activity
{
    // How long the activity is in seconds
    public int Duration { get; set; }
    // Describes the activity
    public string Description { get; set; }

    // Sets the duration and description (Constructor)
    public Activity(int duration, string description)
    {
        Duration = duration;
        Description = description;
    }

    // Method that starts the activity
    public virtual void Start()
    {
        Console.WriteLine($"Starting activity: {Description}");
    }

    // Method that ends the activity
    public void End()
    {
        Console.WriteLine("Ending activity.");
    }

    // Simple Countdown animation (Method)  
    protected void AnimateCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000); // (Wait for 1 second)
        }
        Console.WriteLine();
    }

    // Abstract method for any custom animations, for the derived classes
    protected abstract void AnimateActivity(int duration);

    // Simple start message (method)
    protected void StartMessage()
    {
        Console.WriteLine($"Starting {Description}. This activity will last for {Duration} seconds.");
    }

    // Simple ending message (method)
    protected void EndMessage()
    {
        Console.WriteLine($"Well done! You have completed the {Description} activity for {Duration} seconds.");
    }
}
