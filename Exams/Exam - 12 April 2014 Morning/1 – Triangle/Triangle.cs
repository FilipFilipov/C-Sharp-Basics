using System;
using System.Globalization;
using System.Threading;

class Triangle
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int aX = int.Parse(Console.ReadLine());
        int aY = int.Parse(Console.ReadLine());
        int bX = int.Parse(Console.ReadLine());
        int bY = int.Parse(Console.ReadLine());
        int cX = int.Parse(Console.ReadLine());
        int cY = int.Parse(Console.ReadLine());
        double sideA = Math.Sqrt(Math.Pow((aX - bX), 2) + Math.Pow((aY - bY), 2));
        double sideB = Math.Sqrt(Math.Pow((bX - cX), 2) + Math.Pow((bY - cY), 2));
        double sideC = Math.Sqrt(Math.Pow((cX - aX), 2) + Math.Pow((cY - aY), 2));
        if ((sideA + sideB > sideC) && (sideB + sideC > sideA) && (sideC + sideA > sideB))
        {            
            double p = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
            Console.WriteLine("Yes");
            Console.WriteLine("{0:F2}", area);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("{0:F2}", sideA);
        }
    }
}
