// Represents a goal that is never complete and earns points repeatedly
public class EternalGoal : Goal
{
    // Constructor to initialize eternal goal properties
    public EternalGoal(string name, int points) : base(name, points) { }

    // Eternal goals remain incomplete, so no changes to the completion state
    public override void MarkComplete() { }

    // Display the goal's details
    public override string DisplayGoal()
    {
        return $"{Name} - {Points} points (Eternal)";
    }

    // Format the goal's data for saving to a file
    public override string SaveFormat()
    {
        return $"EternalGoal|{Name}|{Points}";
    }
}
