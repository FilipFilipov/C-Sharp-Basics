using System;

class Volleyball
{
    static void Main()
    {
        string leap = Console.ReadLine();
        int p = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());
        double plays = (48 - h) * (3 / 4.0) + h + p * (2 / 3.0);
        if (leap == "leap")
        {
            plays += (plays * 0.15);
        }
        Console.WriteLine((int)plays);
    }
}
