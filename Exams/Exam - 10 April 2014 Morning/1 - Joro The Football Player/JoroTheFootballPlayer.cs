using System;

class JoroTheFootballPlayer
{
    static void Main()
    {
        string leap = Console.ReadLine();
        int p = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());
        double plays = (52 - h) * (2.0 / 3) + h + (p * 0.5);
        if (leap == "t")
        {
           plays += 3;
        }
        Console.WriteLine((int)plays);
    }
}
