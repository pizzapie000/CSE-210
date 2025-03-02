using System;
using System.Collections.Generic;

public class Program
{
    private Scripture scripture;

    public Program()
    {
        Reference reference = new Reference("John", 3, 16);
        scripture = new Scripture("For God so loved the world...", reference);
    }

    public void StartMemorization()
    {
        Console.Clear();
        Console.WriteLine($"{scripture.Reference.FullReference()}: {scripture.Text}");
        while (true)
        {
            Console.WriteLine("Press Enter to hide a few words or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }

            HideRandomWords();
            Console.Clear();
            Console.WriteLine($"{scripture.Reference.FullReference()}: {scripture.Text}");
        }
    }

    private void HideRandomWords()
    {
        // Implement the logic to hide random words in the scripture
    }

    public static void Main()
    {
        Program program = new Program();
        program.StartMemorization();
    }
}
