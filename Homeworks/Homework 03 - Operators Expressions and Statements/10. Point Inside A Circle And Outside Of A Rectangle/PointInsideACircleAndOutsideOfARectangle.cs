using System;

class PointInsideACircleAndOutsideOfARectangle
{
    static void Main()
    {
        Console.WriteLine("Enter coordinates to check if the point is in the circle K[{1, 1}, 1.5],\nbut outside the rectangle R[{1, -1}, 6, 2]:");
        Console.Write("X = ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Y = ");
        double y = double.Parse(Console.ReadLine());
        double adjustedX = x - 1;
        double adjustedY = y - 1;
        double distance = Math.Sqrt((adjustedX * adjustedX) + (adjustedY * adjustedY));
        if ((distance <= 1.5) && (x < -1 || x > 5 || y < -1 || y > 1))
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");
    }
}

