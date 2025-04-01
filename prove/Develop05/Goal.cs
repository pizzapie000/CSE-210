public abstract class Goal
{
    // Shared attributes for all the types of goals
    public string Name { get; set; } // Name of the goal
    public int Points { get; set; } // Points for when they complete the goal
    public bool IsComplete { get; set; }

    public Goal(string name, int points)
    {
        Name = name;
        Points = points;
        IsComplete = false; // Goals start as incomplete so that they can be completed by a later boolean
    }

    // check off the goal as complete
    public abstract void MarkComplete();

    // Abstract method for showing the goal's details
    public abstract string DisplayGoal();

    // saves to a file
    public abstract string SaveFormat();
}
