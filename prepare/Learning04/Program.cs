class Program
{
    static void Main(string[] args)
    {
        // Create The MathAssignment instance with student name, topic, section and problem.
        MathAssignment math = new MathAssignment("Byron Bursett", "Trigonometry", "2.3", "5-10");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

        // Create the writingassignment instance with student name, topic, and title in that order
        WritingAssignment writing = new WritingAssignment("Ryan Bjornberg", "Egyptian History", "The Middle Kingdom");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}
