using System;
using System.Globalization;

class BeerTime
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter a time (hh:mm AM/PM): ");
            DateTime currentTime;
            if (DateTime.TryParseExact(Console.ReadLine(), "h:mm tt", null, DateTimeStyles.None, out currentTime))
            {
                DateTime start = DateTime.Parse("1:00 PM");
                DateTime end = DateTime.Parse("3:00 AM");
                if (currentTime > start || currentTime < end)
                {
                    Console.WriteLine("beer time");
                }
                else
                {
                    Console.WriteLine("non-beer time");
                }
                break;
            }
            else
            {
                Console.WriteLine("invalid time");
            }
        }        
    }
}
