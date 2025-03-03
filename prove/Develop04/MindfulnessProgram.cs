using System;
using System.Collections.Generic;

public class MindfulnessProgram
{
    private List<Activity> activityList = new List<Activity>();
    private Activity currentActivity;

    public void AddActivity(Activity activity)
    {
        activityList.Add(activity);
    }

    public void SelectActivity()
    {
        Console.WriteLine("Select an activity to perform:");
        for (int i = 0; i < activityList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {activityList[i].Description}");
        }

        int choice;
        while (true)
        {
            Console.Write("Enter the number of the activity: ");
            if (int.TryParse(Console.ReadLine(), out choice) && choice > 0 && choice <= activityList.Count)
            {
                currentActivity = activityList[choice - 1];
                
                // Prompt for the duration of the activity the user choosees
                Console.Write("Enter the duration of the activity in seconds: ");
                int duration = int.Parse(Console.ReadLine());
                currentActivity.Duration = duration;

                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }

    public void RunActivity()
    {
        if (currentActivity != null)
        {
            currentActivity.Start();
        }
    }

    public void Start()
    {
        Console.WriteLine("Starting the mindfulness program.");
        SelectActivity();
        RunActivity();
        Console.WriteLine("Mindfulness program completed.");
    }
}
