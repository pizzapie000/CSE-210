public class ChecklistGoal : Goal
{
    public int RequiredCount { get; set; }
    public int CompletedCount { get; set; } // times the goal has been completed
    public int Bonus { get; set; } // Bonus points for completing the goal

    // Constructor goal properties
    public ChecklistGoal(string name, int points, int requiredCount, int bonus) : base(name, points)
    {
        RequiredCount = requiredCount;
        CompletedCount = 0; // Start with no completions
        Bonus = bonus;
    }

    // Mark the goal complete, update the completed count
    public override void MarkComplete()
    {
        CompletedCount++;
        if (CompletedCount >= RequiredCount)
        {
            IsComplete = true; // Mark goal as completed if all required completions are done
        }
    }

    // Display the goal's details, including completion progress
    public override string DisplayGoal()
    {
        return $"{Name} - {Points} points - Completed: {CompletedCount}/{RequiredCount} - Bonus: {Bonus}";
    }

    // Format the goal's data for saving to a file
    public override string SaveFormat()
    {
        return $"ChecklistGoal|{Name}|{Points}|{CompletedCount}|{RequiredCount}|{Bonus}|{IsComplete}";
    }
}
