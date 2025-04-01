using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creates the videos
        Video video1 = new Video("C# Basics", "Joe mama", 632);
        Video video2 = new Video("Advanced C# Techniques", "C#pro", 5432);
        Video video3 = new Video("Understanding UML", "Timmy Gamesmaster", 900);

        // Add comments to each video
        video1.AddComment(new Comment("Alicenwonderland", "This video made learning C# so much better. Thanks a lot!"));
        video1.AddComment(new Comment("C#master23", "I finally understand variables and loops. your explanation was perfect,!"));
        video1.AddComment(new Comment("Charlie", "I still dont get this. What is a variable?"));

        video2.AddComment(new Comment("Timmy", "This helped me a lot, thanks!"));
        video2.AddComment(new Comment("Jimbob", "Loved the section on delegates and events. Very well explained!"));

        video3.AddComment(new Comment("Tumbo", "Your diagrams really clarified how UML works. Amazing presentation!"));
        video3.AddComment(new Comment("Bubby", "Finally, a video that makes UML less intimidating."));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // shows all the video details and comments
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
