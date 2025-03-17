using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction();
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDivisonValue());

        Fraction fraction1 = new Fraction(4);
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDivisonValue());

        Fraction fraction2 = new Fraction(4, 20);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDivisonValue());

        Fraction fraction3 = new Fraction(1, 3);
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDivisonValue());

    }
}