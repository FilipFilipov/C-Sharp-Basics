using System;

class NumberComparer
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Greater number: " + Math.Max(a, b));
    }
}
