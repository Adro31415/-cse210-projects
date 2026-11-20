using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(6 , 7);

        Console.WriteLine($"{fraction1.GetTop()} , {fraction1.GetBottom()}");
        Console.WriteLine($"{fraction2.GetTop()} , {fraction2.GetBottom()}");
        Console.WriteLine($"{fraction3.GetTop()} , {fraction3.GetBottom()}");

        fraction1.SetTop(10);
        fraction1.SetBottom(2);

        Console.WriteLine($"{fraction1.GetTop()} , {fraction1.GetBottom()}");

        Console.WriteLine(" ");

        Fraction fraction4 = new Fraction(1);
        Fraction fraction5 = new Fraction(5);
        Fraction fraction6 = new Fraction(3 , 4);
        Fraction fraction7 = new Fraction(1 , 3);

        Console.WriteLine($"{fraction4.GetFractionString()} , {fraction4.GetDecimalValue()}");
        Console.WriteLine($"{fraction5.GetFractionString()} , {fraction5.GetDecimalValue()}");
        Console.WriteLine($"{fraction6.GetFractionString()} , {fraction6.GetDecimalValue()}");
        Console.WriteLine($"{fraction7.GetFractionString()} , {fraction7.GetDecimalValue()}");

    
    }

}