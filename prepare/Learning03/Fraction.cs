public class Fraction
{
    private int _numerator;
    private int _denominator;

    // Default constructor
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    // Constructor with numerator only
    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    // Constructor with numerator and denominator
    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    // Gets and Sets Numerator
    public int GetNumerator()
    {
        return _numerator;
    }
    public void SetNumerator(int numerator)
    {
        _numerator = numerator;
    }

    // Gets and Sets Denominator
    public int GetDenominator()
    {
        return _denominator;
    }
    public void SetDenominator(int denominator)
    {
        _denominator = denominator;
    }

    // get fraction string
    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }

    // get decimal value
    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}
