using System;

class Program
{
    static void Main()
    {
        // Get the first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // Get the last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // Show the text James Bond style!
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}
