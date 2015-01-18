using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        if (a > b)
        {
            a += b;
            b = a - b;
            a -= b;
        }
        Console.WriteLine(a + " " + b);
    }
}
