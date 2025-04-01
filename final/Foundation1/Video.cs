using System.Collections.Generic;

// This section represents aa YouTube video
public class Video
{

    public string Title { get; private set; } // Title of the video
    public string Author { get; private set; } // Name of the author
    public int Length { get; private set; } // Length of the video (SECONDS)
    public List<Comment> Comments { get; private set; } // List of comments that are tied to a specific video

    // Constructor
    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    // Add a new comment to the video
    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }



    public int GetNumberOfComments()
    {
        return Comments.Count; // This Counts the number of comments
    }
}
