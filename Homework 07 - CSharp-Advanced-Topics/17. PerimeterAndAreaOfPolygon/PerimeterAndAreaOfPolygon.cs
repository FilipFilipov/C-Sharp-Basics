using System;
using System.Collections.Generic;

class PerimeterAndAreaOfPolygon
{
    static void Main()
    {
        Console.Write("How many points does the polygon have? ");
        uint pointNumber = uint.Parse(Console.ReadLine());
        Point[] points = new Point[pointNumber];
        for (int i = 0; i < pointNumber; i++)
        {
            Console.WriteLine("Enter coordinates x and y for point {0}, separated by a space:", (i + 1));
            string[] input = Console.ReadLine().Split(' ');
            double x = double.Parse(input[0]);
            double y = double.Parse(input[1]);
            {
                points[i] = new Point(x, y);
            }
        }
        Polygon polygon = new Polygon(points);
        Console.WriteLine();
        Console.WriteLine("perimeter = {0:F2}\n" + "area = {1:F2}", polygon.CalculatePerimeter(), polygon.CalculateArea());
    }

    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
    }

    public class Polygon
    {
        private List<Point> pointList = new List<Point>();

        public Polygon(Point[] pointArr)
        {
            this.pointList.AddRange(pointArr);
            this.pointList.Add(pointList[0]);
        }

        public double CalculatePerimeter()
        {
            double perimeter = 0;
            for (int i = 0; i < (pointList.Count - 1); i++)
            {
                double distance = Math.Sqrt(Math.Pow((pointList[i].X - pointList[i + 1].X), 2) +
                    Math.Pow((pointList[i].Y - pointList[i + 1].Y), 2));
                perimeter += distance;
            }
            return perimeter;
        }

        public double CalculateArea()
        {
            double area = 0;
            for (int i = 0; i < (pointList.Count - 1); i++)
            {
                area += (pointList[i].X * pointList[(i + 1)].Y) - (pointList[i].Y * pointList[(i + 1)].X);
            }
            return Math.Abs(area / 2);
        }
    }

}
