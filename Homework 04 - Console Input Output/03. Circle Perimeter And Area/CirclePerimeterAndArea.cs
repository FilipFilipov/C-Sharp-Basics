using System;
class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Enter circle radius: ");
        double r = double.Parse(Console.ReadLine());
        double perimeter = 2 * Math.PI * r;
        double area = Math.PI * r * r;
        Console.WriteLine("perimeter = {0:F2}\narea = {1:F2}", perimeter, area);
    }
}
