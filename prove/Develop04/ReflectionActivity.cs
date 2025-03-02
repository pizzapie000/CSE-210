using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectionActivity : Activity
{
    private static readonly List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static readonly List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public string ReflectionPrompt { get; private set; }

    public ReflectionActivity(string description, int duration)
        : base(duration, description)
    {
        ReflectionPrompt = GetRandomPrompt();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(questions.Count);
        return questions[index];
    }

    public override void Start()
    {
        base.Start();
        Console.WriteLine($"This activity will help you reflect on times in your life when you have shown strength and resilience.");
        Console.WriteLine($"Reflection prompt: {ReflectionPrompt}");
        Console.WriteLine("You will be prompted with questions to reflect deeply on this experience.");
        Console.WriteLine("Prepare to begin...");
        AnimateSpinner(3000);  // Pause to prepare

        int timeElapsed = 0;

        while (timeElapsed < Duration)
        {
            string question = GetRandomQuestion();
            Console.WriteLine($"Reflection question: {question}");
            AnimateSpinner(30000);  // Pauses for 30 seconds
            timeElapsed += 30;
        }

        Console.WriteLine("Reflection activity completed.");
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
