﻿using System;

class Car
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());       
        Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n));
        int outCount = n - 1;
        int inCount = n;
        for (int i = 1; i <= (n / 2) - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', outCount), new string('.', inCount));
            outCount--;
            inCount += 2;
        }
        Console.WriteLine("{0}{1}{0}", new string('*', n / 2 + 1), new string('.', inCount));
        for (int i = 0; i < n / 2 - 2; i++)
        {
            Console.WriteLine("*{0}*", new string('.', 3 * n - 2));
        }
        Console.WriteLine(new string('*', 3 * n));
        for (int i = 0; i < (n / 2) - 2; i++)
		{
            Console.WriteLine("{0}*{1}*{2}*{1}*{0}", new string('.', n / 2), new string('.', n / 2 - 1), new string('.', n - 2));
		}
        Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', n / 2), new string('*', n / 2 + 1), new string('.', n - 2));
    }
}
