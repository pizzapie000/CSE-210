// This is for the actual comment on a YouTube video
public class Comment
{
    // Properties to store details
    public string Name { get; private set; } // Name of the commenter
    public string Text { get; private set; } // Text

    // Constructor
    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }
}
