using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // List to store activities of different types
        List<Activity> activities = new List<Activity>
        {
            // Running activity
            new Running(new DateTime(2022, 11, 3), 30, 3.0),

            // Cycling activity
            new Cycling(new DateTime(2022, 11, 3), 40, 15.0),

            // Swimming activity
            new Swimming(new DateTime(2022, 11, 3), 45, 20)
        };

        // Goes through the list and show activity summaries
        foreach (Activity activity in activities)
        {
            // summary for each activity
            Console.WriteLine(activity.GetSummary());
        }
    }
}
