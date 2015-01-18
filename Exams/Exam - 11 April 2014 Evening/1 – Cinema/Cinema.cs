using System;
using System.Globalization;
using System.Threading;

class Cinema
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string projection = Console.ReadLine();
        int rows = int.Parse(Console.ReadLine());
        int columns = int.Parse(Console.ReadLine());
        double price = 0;
        switch(projection)
        {
            case "Premiere":
                price = 12; break;
            case "Normal":
                price = 7.5; break;
            case "Discount":
                price = 5; break;
        }
        Console.WriteLine("{0:F2} leva", rows * columns * price);
    }
}
