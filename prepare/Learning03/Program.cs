using System;

class Program
{
    static void Main(string[] args)
    {
        // Tests all constructors
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(3, 4);

        // Tests getters and setters things
        Console.WriteLine(fraction1.GetFractionString()); // Output: 1/1
        Console.WriteLine(fraction1.GetDecimalValue());   // Output: 1

        fraction2.SetDenominator(7);
        Console.WriteLine(fraction2.GetFractionString()); // Output: 5/7
        Console.WriteLine(fraction2.GetDecimalValue());   // Output: 0.714...

        Console.WriteLine(fraction3.GetFractionString()); // Output: 3/4
        Console.WriteLine(fraction3.GetDecimalValue());   // Output: 0.75
    }
}
