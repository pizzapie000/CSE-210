using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private static readonly List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public string ListingPrompt { get; private set; }
    public List<string> Items { get; private set; }

    public ListingActivity(string description, int duration)
        : base(duration, description)
    {
        ListingPrompt = GetRandomPrompt();
        Items = new List<string>();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }

    public override void Start()
    {
        base.Start();
        Console.WriteLine($"This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Console.WriteLine($"Listing prompt: {ListingPrompt}");
        Console.WriteLine("You will have a few seconds to think about the prompt, then start listing items.");

        AnimateSpinner(3000);  // Pause for preparation

        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Enter an item: ");
            string item = Console.ReadLine();
            Items.Add(item);
        }

        Console.WriteLine($"You have listed {Items.Count} items.");
        Console.WriteLine("Listing activity completed.");
        End();
    }

    private void AnimateSpinner(int duration)
    {
        var spinner = new[] { '|', '/', '-', '\\' };
        int spinnerIndex = 0;
        int timeElapsed = 0;

        while (timeElapsed < duration)
        {
            Console.Write(spinner[spinnerIndex]);
            spinnerIndex = (spinnerIndex + 1) % spinner.Length;
            Thread.Sleep(250);
            Console.Write("\b");
            timeElapsed += 250;
        }
    }
}
