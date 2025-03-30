using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("C# Basics", "John Smith", 600);
        Video video2 = new Video("Advanced C# Techniques", "Jane Doe", 1200);
        Video video3 = new Video("Understanding UML", "Emily White", 900);

        // Add comments to each video
        video1.AddComment(new Comment("Alice", "This video made learning C# so much better. Thanks a lot!"));
        video1.AddComment(new Comment("Bob", "I finally understand variables and loops. your explanation was perfect,!"));
        video1.AddComment(new Comment("Charlie", "Loved the examples."));

        video2.AddComment(new Comment("Diana", "This helped me a lot, thanks!"));
        video2.AddComment(new Comment("Eve", "Loved the section on delegates and events. Very well explained!"));

        video3.AddComment(new Comment("Frank", "Your diagrams really clarified how UML works. Amazing presentation!"));
        video3.AddComment(new Comment("Grace", "Finally, a video that makes UML less intimidating."));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Iterate through the list and shows video details and comments
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}
