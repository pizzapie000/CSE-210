// class that inherits from Assignment
public class MathAssignment : Assignment
{
    // Private variables for the section and problems
    private string _section;
    private string _problems;

    // Constructor that adds all the member variables
    // (also calls the base class constructor to add the student name and topic)
    public MathAssignment(string studentName, string topic, string section, string problems)
        : base(studentName, topic) // Call the base constructor
    {
        _section = section;
        _problems = problems;
    }

    // Method to get the homework list
    public string GetHomeworkList()
    {
        // Returns the section number and problems
        return $"Section {_section} Problems {_problems}";
    }
}
