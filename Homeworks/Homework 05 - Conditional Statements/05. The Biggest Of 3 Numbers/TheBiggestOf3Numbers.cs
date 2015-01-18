using System;

class TheBiggestOf3Numbers
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers to compare:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double max = a;
        max = Math.Max(max, b);
        max = Math.Max(max, c);
        Console.WriteLine(max + " is the biggest");
    }
}
