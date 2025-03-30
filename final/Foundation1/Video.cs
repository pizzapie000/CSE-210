using System.Collections.Generic;

// Represents a YouTube video, including its details and associated comments
public class Video
{
    // Properties to store video details
    public string Title { get; private set; } // Title of the video
    public string Author { get; private set; } // Name of the video's author
    public int Length { get; private set; } // Length of the video in seconds
    public List<Comment> Comments { get; private set; } // List of comments associated with the video

    // Constructor to initialize a video with its title, author, and length
    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>(); // Initialize the comments list
    }

    // Adds a new comment to the video
    public void AddComment(Comment comment)
    {
        Comments.Add(comment); // Add the comment to the list
    }

    // Returns the number of comments associated with the video
    public int GetNumberOfComments()
    {
        return Comments.Count; // Count and return the number of comments
    }
}
