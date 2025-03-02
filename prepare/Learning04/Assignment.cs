public class Assignment
{
    // Private variables for the students name and their topic
    public string _studentName;
    private string _topic;

    // The constructor that adds the student name and the topic
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Method to get the summary of the Assignment
    public string GetSummary()
    {
        // Returns the students name and their topic
        return $"{_studentName} - {_topic}";
    }
}
