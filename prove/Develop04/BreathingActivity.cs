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
        StartMessage();
        Console.WriteLine("Clear your mind and focus on your breathing.");

        int repetitions = Duration / CycleDuration;

        for (int i = 0; i < repetitions; i++)
        {
            Console.Write("Inhale...");
            AnimateCountdown(4);  // Animate inhale
            Console.WriteLine("\nExhale...");
            AnimateCountdown(4);  // Animate exhale
        }

        EndMessage();
        End();
    }

    protected override void AnimateActivity(int duration)
    {
        // Implement specific animation if needed
    }
}
