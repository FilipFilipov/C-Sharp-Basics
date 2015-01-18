using System;

class Rectangles
{
    static void Main()
    {
        Console.WriteLine("Enter your rectangle's width and height:");
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double perimeter = (width + height) * 2;
        double area = width * height;
        Console.WriteLine("Perimeter = {0}\nArea = {1}", perimeter, area);
    }
}
