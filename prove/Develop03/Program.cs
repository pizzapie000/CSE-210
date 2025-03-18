using System;
using System.Collections.Generic;

public class Program
{
    private List<Scripture> scriptureLibrary;
    private Scripture currentScripture;

    public Program()
    {
        // Scripture library with Bible, Book of Mormon, and DC scriptures
        scriptureLibrary = new List<Scripture>
        {
            // Bible
            new Scripture("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.", new Reference("John", 3, 16)),
            new Scripture("Trust in the Lord with all thine heart; and lean not unto thine own understanding.", new Reference("Proverbs", 3, 5)),
            new Scripture("I can do all things through Christ which strengtheneth me.", new Reference("Philippians", 4, 13)),

            // Book of Mormon
            new Scripture("For behold, this is my work and my glory—to bring to pass the immortality and eternal life of man.", new Reference("Moses", 1, 39)),
            new Scripture("When ye are in the service of your fellow beings ye are only in the service of your God.", new Reference("Mosiah", 2, 17)),
            new Scripture("And if men come unto me I will show unto them their weakness.", new Reference("Ether", 12, 27)),

            // Doctrine and Covenants
            new Scripture("Behold, I am Jesus Christ, the Son of God. I am the life and the light of the world.", new Reference("Doctrine and Covenants", 11, 28)),
            new Scripture("Remember the worth of souls is great in the sight of God.", new Reference("Doctrine and Covenants", 18, 10)),
            new Scripture("And if it so be that you should labor all your days in crying repentance unto this people, and bring, save it be one soul unto me, how great shall be your joy.", new Reference("Doctrine and Covenants", 18, 15))
        };
    }

    private void SelectRandomScripture()
    {
        Random random = new Random();
        int randomIndex = random.Next(scriptureLibrary.Count);
        currentScripture = scriptureLibrary[randomIndex];
    }

    public void StartMemorization()
    {
        SelectRandomScripture();

        while (true)
        {
            Console.Clear();
            Console.WriteLine($"{currentScripture.Reference.FullReference()}:");
            Console.WriteLine(currentScripture.DisplayText());

            if (currentScripture.AreAllWordsHidden())
            {
                Console.WriteLine("\nCongratulations! You've hidden the entire scripture.");
                break;
            }

            Console.WriteLine("\nPress Enter to hide a few words or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }

            currentScripture.HideRandomWords();
        }
    }

    public static void Main()
    {
        Program program = new Program();
        program.StartMemorization();
    }
}
