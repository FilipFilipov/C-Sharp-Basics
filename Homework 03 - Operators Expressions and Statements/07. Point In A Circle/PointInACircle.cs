using System;

class PointInACircle
{
    static void Main()
    {
        Console.WriteLine("Enter coordinates to check if the point is in the circle K[{0, 0}, 2]:");
        Console.Write("X = ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Y = ");
        double y = double.Parse(Console.ReadLine());
        double distance = Math.Sqrt(x * x + y * y);
        Console.WriteLine(distance <= 2 ? "Inside" : "Outside");
    }
}