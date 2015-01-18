using System;

class WorkHours
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        double p = double.Parse(Console.ReadLine()) / 100;
        double work = (d * 0.9 * 12 * p);
        int diff = (int)work - h;
		Console.WriteLine(diff > 0 ? "Yes" : "No");
        Console.WriteLine(diff);
    }
}
