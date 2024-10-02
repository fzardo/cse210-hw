using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();          // 1/1
        Fraction fraction2 = new Fraction(6);         // 6/1
        Fraction fraction3 = new Fraction(6, 7);      // 6/7

        // Display the fractions
        Console.WriteLine($"Fraction 1: {fraction1.GetFractionString()} - Decimal: {fraction1.GetDecimalValue()}");
        Console.WriteLine($"Fraction 2: {fraction2.GetFractionString()} - Decimal: {fraction2.GetDecimalValue()}");
        Console.WriteLine($"Fraction 3: {fraction3.GetFractionString()} - Decimal: {fraction3.GetDecimalValue()}");

        fraction1.SetTop(3);
        fraction1.SetBottom(4);
        Console.WriteLine($"Updated Fraction 1: {fraction1.GetFractionString()} - Decimal: {fraction1.GetDecimalValue()}");
    }
}