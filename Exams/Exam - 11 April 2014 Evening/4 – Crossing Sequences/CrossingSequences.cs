using System;
using System.Collections.Generic;

class CrossingSequences
{
    static void Main()
    {
        int t1 = int.Parse(Console.ReadLine());
        int t2 = int.Parse(Console.ReadLine());
        int t3 = int.Parse(Console.ReadLine());
        List <int> tribonacci = new List<int>();
        tribonacci.Add(t1);
        tribonacci.Add(t2);
        tribonacci.Add(t3);
        int tNext = t1 + t2 + t3;
        while (tNext <= 1000000)
        {
            tribonacci.Add(tNext);
            t1 = t2;
            t2 = t3;
            t3 = tNext;
            tNext = t1 + t2 + t3;
        }

        int corner = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        bool oddCorner = true;
        int distance = 0;
        List <int> spiral = new List <int>();
        while (corner <= 1000000)
        {
            spiral.Add(corner);
            if (oddCorner)
            {
                distance += 1;
            }
            corner += distance * step;
            oddCorner = !oddCorner;
        }

        foreach (var number in tribonacci)
        {
            if (spiral.Contains(number))
            {
                Console.WriteLine(number);
                return;
            }
        }
        Console.WriteLine("No");
    }
}
