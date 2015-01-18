using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Enter coeficients:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double discriminant = b * b - (4 * a * c);
        if (discriminant < 0)
        {
            Console.WriteLine("no real roots");
        }
        else if (discriminant == 0)
        {
            Console.WriteLine("x1=x2=" + -b / (2 * a));
        }
        else
        {
            Console.WriteLine("x1=" + (-b - Math.Sqrt(discriminant)) / (2 * a));
            Console.WriteLine("x2=" + (-b + Math.Sqrt(discriminant)) / (2 * a));
        }        
    }
}
