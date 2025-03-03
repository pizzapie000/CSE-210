public class ReflectionActivity : Activity
{
    // List of prompts
    private static readonly List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    // List of deeper thinking questions
    private static readonly List<string> questions = new List<string>
    {
        "Why did this matter to you?",
        "Have you done something like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself?",
        "How can you remember this in the future?"
    };

    public string ReflectionPrompt { get; private set; }

    // Constructor to set the description and duration, then it picks a random prompt.
    public ReflectionActivity(string description, int duration)
        : base(duration, description)
    {
        ReflectionPrompt = GetRandomPrompt();
    }

    // Method to select a random prompt from the list
    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }

    // Method to select a random question from the list
    private string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(questions.Count);
        return questions[index];
    }

    // Starts the reflection activity
    public override void Start()
    {
        base.Start();
        StartMessage();
        Console.WriteLine($"Reflection prompt: {ReflectionPrompt}");
        Console.WriteLine("You will be asked more questions to help you think even deeper.");
        AnimateCountdown(3);  // Pause to let them prepare

        int timeElapsed = 0;

        while (timeElapsed < Duration)
        {
            string question = GetRandomQuestion();
            Console.WriteLine($"Reflection question: {question}");
            AnimateCountdown(30);  // Pauses for 30 seconds
            timeElapsed += 30;
        }

        EndMessage();
        End();
    }

    // Method for customizeds animations
    protected override void AnimateActivity(int duration)
    {
        // Uses a specific animation. I have a specific animation I built for the breathingactivity.
    }
}
