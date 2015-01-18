using System;

class Electricity
{
    static void Main()
    {
        int floors = int.Parse(Console.ReadLine());
        int flats = int.Parse(Console.ReadLine());
        TimeSpan time = TimeSpan.Parse(Console.ReadLine());
        double watts = 0;
        if (time.Hours < 9)
        {
            watts = floors * flats * (100.53 + 8 * 125.9);
        }
        else if (time.Hours >= 14 && time.Hours < 19)
        {
            watts = floors * flats * (2 * 100.53 + 2 * 125.9);
        }
        else if (time.Hours >= 19)
        {
            watts = floors * flats * (7 * 100.53 + 6 * 125.9);
        }
        Console.WriteLine("{0} Watts", (long)watts);
    }
}
