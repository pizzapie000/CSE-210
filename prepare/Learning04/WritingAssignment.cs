// class that inherits from Assignment
public class WritingAssignment : Assignment
{
    // Private variable for the title of the assignment
    private string _title;

    // Constructor that adds all member variables
    // (Calls the base class constructor to add the students name and their topic)
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic) // Call the base constructor
    {
        _title = title; // Add title
    }

    // Method to get the writing information
    public string GetWritingInformation()
    {
        // Prints the title and the student's name (This is inherited from the bass class)
        return $"{_title} by {_studentName}";
    }
}
