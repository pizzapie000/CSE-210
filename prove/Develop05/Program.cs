using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        string filePath = "goals.txt"; // path for saving/loading goals
        int userScore = 0; // Tracks the user's score
        int userLevel = 1; // track the user's level

        // Main menu loop
        while (true)
        {
            Console.WriteLine("\nEternal Quest Menu");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Show Goals");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Display Score and Level"); // Updated for level
            Console.WriteLine("0. Exit");
            Console.Write("Choose an option: ");
            string option = Console.ReadLine();

            // menu settings
            switch (option)
            {
                case "1":
                    // Create a new goal
                    Console.Write("Enter goal name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Choose goal type: 1. Simple 2. Eternal 3. Checklist");
                    string goalType = Console.ReadLine();
                    
                    if (goalType == "1") // Simple Goal
                    {
                        Console.Write("Enter points: ");
                        int points = int.Parse(Console.ReadLine());
                        goalManager.AddGoal(new SimpleGoal(name, points));
                    }
                    else if (goalType == "2") // Eternal Goal
                    {
                        Console.Write("Enter points: ");
                        int points = int.Parse(Console.ReadLine());
                        goalManager.AddGoal(new EternalGoal(name, points));
                    }
                    else if (goalType == "3") // Checklist Goal
                    {
                        Console.Write("Enter points per completion: ");
                        int points = int.Parse(Console.ReadLine());
                        Console.Write("Enter required count to complete: ");
                        int requiredCount = int.Parse(Console.ReadLine());
                        Console.Write("Enter bonus points: ");
                        int bonus = int.Parse(Console.ReadLine());
                        goalManager.AddGoal(new ChecklistGoal(name, points, requiredCount, bonus));
                    }
                    break;

                case "2":
                    // This records my progress on a goal and award points
                    Console.WriteLine("Choose a goal to record:");
                    goalManager.DisplayAllGoals();
                    Console.Write("Enter goal number: ");
                    int goalIndex = int.Parse(Console.ReadLine()) - 1;
                    if (goalIndex >= 0 && goalIndex < goalManager.Goals.Count)
                    {
                        Goal selectedGoal = goalManager.Goals[goalIndex];
                        userScore += selectedGoal.Points;
                        selectedGoal.MarkComplete();
                        Console.WriteLine($"Event recorded! You earned {selectedGoal.Points} points.");

                        // level up
                        int previousLevel = userLevel;
                        userLevel = userScore / 1000 + 1; // Level up every 1000 points
                        if (userLevel > previousLevel)
                        {
                            Console.WriteLine($"Good work! You are now level {userLevel}!");
                        }
                    }
                    break;

                case "3":
                    // list of all the goals
                    Console.WriteLine("\nCurrent Goals:");
                    goalManager.DisplayAllGoals();
                    break;

                case "4":
                    // Save goals
                    goalManager.SaveGoals(filePath);
                    Console.WriteLine("Goals saved");
                    break;

                case "5":
                    // Loads goals
                    goalManager.LoadGoals(filePath);
                    Console.WriteLine("Goals loaded");
                    break;

                case "6":
// score and level
                    Console.WriteLine($"\nYour current score is: {userScore} points");
                    Console.WriteLine($"Your current level is: {userLevel}");
                    break;

                case "0":
                    // Exit
                    Console.WriteLine("see you later!");
                    return;

                default:
                    // just in case there is an error menu
                    Console.WriteLine("That input doesnt work. Try another.");
                    break;
            }
        }
    }
}
