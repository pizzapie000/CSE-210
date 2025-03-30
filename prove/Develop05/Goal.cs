public abstract class Goal
{
    // Shared attributes for all goal types
    public string Name { get; set; } // Name of the goal
    public int Points { get; set; } // Points awarded for completing the goal
    public bool IsComplete { get; set; }

    public Goal(string name, int points)
    {
        Name = name;
        Points = points;
        IsComplete = false; // Goals start as incomplete
    }

    // Abstract method for marking the goal as complete
    public abstract void MarkComplete();

    // Abstract method for showing the goal's details
    public abstract string DisplayGoal();

    // Abstract method for formatting the goal for saving to a file
    public abstract string SaveFormat();
}
