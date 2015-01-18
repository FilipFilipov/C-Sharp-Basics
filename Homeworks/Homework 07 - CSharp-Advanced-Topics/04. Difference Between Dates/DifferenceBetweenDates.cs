using System;
using System.Globalization;

class DifferenceBetweenDates
{
    static void Main()
    {
        Console.WriteLine("Enter two dates in the format \"DD.MM.YYYY\":");
        Console.Write("Enter first date: ");
        DateTime dateA = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", null, DateTimeStyles.None);
        Console.Write("Enter second date: ");
        DateTime dateB = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", null, DateTimeStyles.None);
        TimeSpan difference = (dateB - dateA);
        Console.WriteLine("Difference in days is: {0}", difference.Days);
    }
}
