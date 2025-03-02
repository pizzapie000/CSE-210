using System;
using System.Threading;

public class BreathingActivity : Activity
{
    private const int CycleDuration = 8;  // 4 seconds inhale + 4 seconds exhale

    public BreathingActivity(string description, int duration)
        : base(duration, description)
    {
    }

    public override void Start()
    {
        base.Start();
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly.");
        Console.WriteLine("Clear your mind and focus on your breathing.");

        int repetitions = Duration / CycleDuration;

        for (int i = 0; i < repetitions; i++)
        {
            Console.Write("Inhale...");
            AnimateBreath(true);  // Animate inhale
            Console.WriteLine("\nExhale...");
            AnimateBreath(false);  // Animate exhale
        }

        Console.WriteLine("Breathing exercise done.");
        End();
    }

    private void AnimateBreath(bool isInhale)
    {
        var stages = new[] { "()", "( )", "(  )", "(   )" };

        if (!isInhale) Array.Reverse(stages);

        foreach (var stage in stages)
        {
            Console.WriteLine(stage);  // Print on a new line, then wait for 1 second (1000 milliseconds)
            Thread.Sleep(1000);
        }
    }
}
