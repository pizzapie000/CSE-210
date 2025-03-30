using System.IO;
using System.Collections.Generic;

// Manages a collection of goals
public class GoalManager
{
    public List<Goal> Goals = new List<Goal>(); // List of all goals

    // Adds a new goal to the collection
    public void AddGoal(Goal goal)
    {
        Goals.Add(goal);
    }

    // Shows all goals in the collection
    public void DisplayAllGoals()
    {
        foreach (var goal in Goals)
        {
            Console.WriteLine(goal.DisplayGoal());
        }
    }

    // Saves goals to a file
    public void SaveGoals(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var goal in Goals)
            {
                writer.WriteLine(goal.SaveFormat());
            }
        }
    }

    // Loads goals from a file
    public void LoadGoals(string filePath)
    {
        Goals.Clear(); // Clear existing goals
        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var parts = line.Split('|');
             
                if (parts[0] == "SimpleGoal")
                {
                    Goals.Add(new SimpleGoal(parts[1], int.Parse(parts[2])));
                }
                else if (parts[0] == "EternalGoal")
                {
                    Goals.Add(new EternalGoal(parts[1], int.Parse(parts[2])));
                }
                else if (parts[0] == "ChecklistGoal")
                {
                    Goals.Add(new ChecklistGoal(parts[1], int.Parse(parts[2]), int.Parse(parts[4]), int.Parse(parts[3])));
                }
            }
        }
    }
}
