using System;

class Trapezoids
{
    static void Main()
    {
        Console.WriteLine("Enter your trapezoid's dimentions: ");
        Console.Write("A = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("B = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("H = ");
        double h = double.Parse(Console.ReadLine());
        Console.WriteLine("Area = {0}", (a + b) * h / 2);
    }
}
