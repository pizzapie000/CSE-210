public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points) { }

    public override void MarkComplete()
    {
        IsComplete = true;
    }

    public override string DisplayGoal()
    {
        return $"{Name} - {Points} points - Completed: {IsComplete}";
    }

    public override string SaveFormat()
    {
        return $"SimpleGoal|{Name}|{Points}|{IsComplete}";
    }
}
