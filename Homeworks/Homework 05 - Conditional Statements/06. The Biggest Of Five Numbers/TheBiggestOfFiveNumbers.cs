using System;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter five numbers to compare:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());
        double max = double.MinValue;
        max = (a > max) ? a : max;
        max = (b > max) ? b : max;
        max = (c > max) ? c : max;
        max = (d > max) ? d : max;
        max = (e > max) ? e : max;
        Console.WriteLine(max + " is the biggest");
    }
}
